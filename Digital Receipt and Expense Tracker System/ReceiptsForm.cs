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
        public ReceiptsForm()
        {
            InitializeComponent();
            LoadReceipts();
        }

        private void LoadReceipts()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT sale_id AS 'Receipt ID', customer_name AS 'Customer', total_amount AS 'Total', sale_date AS 'Date' FROM sales ORDER BY sale_date DESC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvReceipts.DataSource = dt;
            }
        }

        private void dgvReceipts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int saleId = Convert.ToInt32(dgvReceipts.Rows[e.RowIndex].Cells["Receipt ID"].Value);
                ShowReceiptDetails(saleId);
            }
        }

        private void ShowReceiptDetails(int saleId)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                // Get sale details
                string saleQuery = "SELECT customer_name, total_amount, sale_date FROM sales WHERE sale_id = @saleId";
                MySqlCommand saleCmd = new MySqlCommand(saleQuery, conn);
                saleCmd.Parameters.AddWithValue("@saleId", saleId);
                MySqlDataReader reader = saleCmd.ExecuteReader();

                string customer = "";
                decimal total = 0;
                DateTime saleDate = DateTime.Now;

                if (reader.Read())
                {
                    customer = reader["customer_name"].ToString();
                    total = Convert.ToDecimal(reader["total_amount"]);
                    saleDate = Convert.ToDateTime(reader["sale_date"]);
                }
                reader.Close();

                // Get sale items
                string itemQuery = "SELECT item_name AS 'Item Name', quantity AS 'Quantity', price AS 'Price', subtotal AS 'Subtotal' FROM sale_items WHERE sale_id = @saleId";
                MySqlDataAdapter adapter = new MySqlDataAdapter(itemQuery, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@saleId", saleId);
                DataTable itemsTable = new DataTable();
                adapter.Fill(itemsTable);

                // Open the detailed receipt form
                ReceiptForm receiptForm = new ReceiptForm(itemsTable, customer, total);
                receiptForm.ShowDialog();
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