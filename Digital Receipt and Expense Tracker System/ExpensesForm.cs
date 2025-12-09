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
    public partial class ExpensesForm : Form
    {
        private int userId; // current logged-in user

        public ExpensesForm(int loggedInUserId)
        {
            InitializeComponent();
            userId = loggedInUserId;
            LoadExpenses();
        }

        // 🔹 Load all expenses for this user
        private void LoadExpenses()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    string query = @"SELECT expense_id AS 'ID',
                                            expense_name AS 'Expense Name',
                                            category AS 'Category',
                                            amount AS 'Amount',
                                            expense_date AS 'Date',
                                            notes AS 'Notes'
                                     FROM expenses
                                     WHERE user_id = @userId
                                     ORDER BY expense_date DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvExpenses.DataSource = dt;

                    UpdateTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading expenses: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 🔹 Add new expense
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExpenseName.Text) || string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please enter an expense name and amount.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    string query = @"INSERT INTO expenses (user_id, expense_name, category, amount, expense_date, notes)
                                     VALUES (@userId, @name, @category, @amount, NOW(), @notes)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@name", txtExpenseName.Text.Trim());
                    cmd.Parameters.AddWithValue("@category", txtCategory.Text.Trim());
                    cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(txtAmount.Text.Trim()));
                    cmd.Parameters.AddWithValue("@notes", txtNotes.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("✅ Expense added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                    LoadExpenses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding expense: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 🔹 Delete selected expense
        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an expense to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int expenseId = Convert.ToInt32(dgvExpenses.SelectedRows[0].Cells["ID"].Value);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this expense?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    try
                    {
                        string query = "DELETE FROM expenses WHERE expense_id = @id AND user_id = @userId";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", expenseId);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("🗑 Expense deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadExpenses();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting expense: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 🔹 Calculate and update total expenses
        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvExpenses.Rows)
            {
                if (row.Cells["Amount"].Value != DBNull.Value)
                    total += Convert.ToDecimal(row.Cells["Amount"].Value);
            }
            lblTotal.Text = $"Total Expenses: ₱{total:N2}";
        }

        // 🔹 Clear all text fields
        private void ClearInputs()
        {
            txtExpenseName.Clear();
            txtCategory.Clear();
            txtAmount.Clear();
            txtNotes.Clear();
        }

        // 🔹 Back button to dashboard
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardForm dashboard = new DashboardForm("User", "Role");
            dashboard.Show();
        }
    }
}