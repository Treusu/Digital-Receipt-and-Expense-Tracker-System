using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Digital_Receipt_and_Expense_Tracker_System
{
    public partial class SalesForm : Form
    {
        private int userId;
        public SalesForm(int loggedInUserId)
        {
            InitializeComponent();
            userId = loggedInUserId;
            SetupDataGrid();
        }

        private void SetupDataGrid()
        {
            dgvItems.Columns.Clear();
            dgvItems.Columns.Add("item_name", "Item Name");
            dgvItems.Columns.Add("quantity", "Quantity");
            dgvItems.Columns.Add("price", "Price");
            dgvItems.Columns.Add("subtotal", "Subtotal");

            dgvItems.Columns["price"].DefaultCellStyle.Format = "N2";
            dgvItems.Columns["subtotal"].DefaultCellStyle.Format = "N2";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using (var addItemForm = new AddItemForm())
            {
                if (addItemForm.ShowDialog() == DialogResult.OK)
                {
                    dgvItems.Rows.Add(addItemForm.ItemName, addItemForm.Quantity, addItemForm.Price, addItemForm.Subtotal);
                    CalculateTotal();
                }
            }
        }

        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Cells["subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["subtotal"].Value);
                }
            }
            lblTotal.Text = $"Total: ₱{total:N2}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomer.Text) || dgvItems.Rows.Count == 0)
            {
                MessageBox.Show("Please enter a customer name and add at least one item.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                MySqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Insert sale
                    string saleQuery = "INSERT INTO sales (customer_name, sale_date, total_amount, user_id) VALUES (@customer, NOW(), @total, @user)";
                    MySqlCommand saleCmd = new MySqlCommand(saleQuery, conn, transaction);
                    saleCmd.Parameters.AddWithValue("@customer", txtCustomer.Text.Trim());
                    saleCmd.Parameters.AddWithValue("@total", GetTotalAmount());
                    saleCmd.Parameters.AddWithValue("@user", userId);
                    saleCmd.ExecuteNonQuery();

                    int saleId = (int)saleCmd.LastInsertedId;

                    // Insert sale items
                    foreach (DataGridViewRow row in dgvItems.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string itemQuery = "INSERT INTO sale_items (sale_id, item_name, quantity, price, subtotal) VALUES (@saleId, @item, @qty, @price, @subtotal)";
                        MySqlCommand itemCmd = new MySqlCommand(itemQuery, conn, transaction);
                        itemCmd.Parameters.AddWithValue("@saleId", saleId);
                        itemCmd.Parameters.AddWithValue("@item", row.Cells["item_name"].Value);
                        itemCmd.Parameters.AddWithValue("@qty", row.Cells["quantity"].Value);
                        itemCmd.Parameters.AddWithValue("@price", row.Cells["price"].Value);
                        itemCmd.Parameters.AddWithValue("@subtotal", row.Cells["subtotal"].Value);
                        itemCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("✅ Sale recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvItems.Rows.Clear();
                    txtCustomer.Clear();
                    lblTotal.Text = "Total: ₱0.00";

                    // Prepare items for receipt
                    DataTable receiptTable = new DataTable();
                    receiptTable.Columns.Add("Item Name");
                    receiptTable.Columns.Add("Quantity");
                    receiptTable.Columns.Add("Price");
                    receiptTable.Columns.Add("Subtotal");

                    foreach (DataGridViewRow row in dgvItems.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            receiptTable.Rows.Add(
                                row.Cells["item_name"].Value,
                                row.Cells["quantity"].Value,
                                row.Cells["price"].Value,
                                row.Cells["subtotal"].Value
                            );
                        }
                    }

                    // Show receipt form
                    ReceiptForm receiptForm = new ReceiptForm(receiptTable, txtCustomer.Text, GetTotalAmount());
                    receiptForm.ShowDialog();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving sale: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private decimal GetTotalAmount()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Cells["subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["subtotal"].Value);
                }
            }
            return total;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboard = new DashboardForm("User", "Role");
            dashboard.Show();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
