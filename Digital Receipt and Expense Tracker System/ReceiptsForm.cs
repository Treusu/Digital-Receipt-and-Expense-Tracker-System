using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Digital_Receipt_and_Expense_Tracker_System
{
    public partial class ReceiptsForm : Form
    {
        private int userId;

        public ReceiptsForm(int loggedUserId)
        {
            InitializeComponent();
            userId = loggedUserId;
            LoadReceipts();
        }

        private void LoadReceipts(string search = "")
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    string query = @"
                        SELECT sale_id, customer_name, sale_date, total_amount
                        FROM sales 
                        WHERE user_id = @user
                        AND customer_name LIKE @search
                        ORDER BY sale_date DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", userId);
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvReceipts.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading receipts: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadReceipts(txtSearch.Text.Trim());
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadReceipts();
        }

        private void dgvReceipts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dgvReceipts.Columns["viewColumn"].Index)
            {
                int saleId = Convert.ToInt32(dgvReceipts.Rows[e.RowIndex].Cells["sale_id"].Value);
                OpenReceipt(saleId);
            }
        }

        private void OpenReceipt(int saleId)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                string saleQuery = "SELECT customer_name, total_amount FROM sales WHERE sale_id = @id";
                MySqlCommand saleCmd = new MySqlCommand(saleQuery, conn);
                saleCmd.Parameters.AddWithValue("@id", saleId);

                MySqlDataReader reader = saleCmd.ExecuteReader();
                string customer = "";
                decimal total = 0;

                if (reader.Read())
                {
                    customer = reader.GetString("customer_name");
                    total = reader.GetDecimal("total_amount");
                }
                reader.Close();

                string itemsQuery = "SELECT item_name, quantity, price, subtotal FROM sale_items WHERE sale_id = @id";
                MySqlCommand itemsCmd = new MySqlCommand(itemsQuery, conn);
                itemsCmd.Parameters.AddWithValue("@id", saleId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(itemsCmd);
                DataTable itemsTable = new DataTable();
                adapter.Fill(itemsTable);

                ReceiptForm receipt = new ReceiptForm(itemsTable, customer, total);
                receipt.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReceipts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a sale to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int saleId = Convert.ToInt32(dgvReceipts.SelectedRows[0].Cells["sale_id"].Value);
            string customerName = dgvReceipts.SelectedRows[0].Cells["customer_name"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete the sale for \"{customerName}\"?\n\nThis will also delete all associated sale items and cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                MySqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Delete sale items first (foreign key constraint)
                    string deleteItems = "DELETE FROM sale_items WHERE sale_id = @id";
                    MySqlCommand cmdItems = new MySqlCommand(deleteItems, conn, transaction);
                    cmdItems.Parameters.AddWithValue("@id", saleId);
                    cmdItems.ExecuteNonQuery();

                    // Then delete the sale itself
                    string deleteSale = "DELETE FROM sales WHERE sale_id = @id AND user_id = @userId";
                    MySqlCommand cmdSale = new MySqlCommand(deleteSale, conn, transaction);
                    cmdSale.Parameters.AddWithValue("@id", saleId);
                    cmdSale.Parameters.AddWithValue("@userId", userId);
                    cmdSale.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("🗑 Sale deleted successfully!", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadReceipts(txtSearch.Text.Trim());
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error deleting sale: " + ex.Message, "Database Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboard = new DashboardForm("User", "Role");
            dashboard.Show();
        }
    }
}