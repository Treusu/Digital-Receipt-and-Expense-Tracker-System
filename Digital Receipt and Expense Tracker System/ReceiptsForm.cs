using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (e.ColumnIndex == dgvReceipts.Columns["viewColumn"].Index && e.RowIndex >= 0)
            {
                int saleId = Convert.ToInt32(dgvReceipts.Rows[e.RowIndex].Cells["sale_id"].Value);
                OpenReceipt(saleId);
            }
        }

        private void OpenReceipt(int saleId)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                // Load sale info
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

                // Load item info
                string itemsQuery = "SELECT item_name, quantity, price, subtotal FROM sale_items WHERE sale_id = @id";
                MySqlCommand itemsCmd = new MySqlCommand(itemsQuery, conn);
                itemsCmd.Parameters.AddWithValue("@id", saleId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(itemsCmd);
                DataTable itemsTable = new DataTable();
                adapter.Fill(itemsTable);

                // Open receipt preview
                ReceiptForm receipt = new ReceiptForm(itemsTable, customer, total);
                receipt.ShowDialog();
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