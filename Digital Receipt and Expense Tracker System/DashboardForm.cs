using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace Digital_Receipt_and_Expense_Tracker_System
{
    public partial class DashboardForm : Form
    {


        private void LoadDashboardStats()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                decimal revenue = 0;
                decimal expenses = 0;
                int sales = 0;

                string revenueQuery = "SELECT IFNULL(SUM(total_amount),0) FROM sales WHERE user_id=@user";
                MySqlCommand cmdRev = new MySqlCommand(revenueQuery, conn);
                cmdRev.Parameters.AddWithValue("@user", loggedInUserId);
                revenue = Convert.ToDecimal(cmdRev.ExecuteScalar());

                string expenseQuery = "SELECT IFNULL(SUM(amount),0) FROM expenses WHERE user_id=@user";
                MySqlCommand cmdExp = new MySqlCommand(expenseQuery, conn);
                cmdExp.Parameters.AddWithValue("@user", loggedInUserId);
                expenses = Convert.ToDecimal(cmdExp.ExecuteScalar());

                string salesQuery = "SELECT COUNT(*) FROM sales WHERE user_id=@user";
                MySqlCommand cmdSales = new MySqlCommand(salesQuery, conn);
                cmdSales.Parameters.AddWithValue("@user", loggedInUserId);
                sales = Convert.ToInt32(cmdSales.ExecuteScalar());

                decimal profit = revenue - expenses;

                lblRevenue.Text = $"Revenue: ₱{revenue:N2}";
                lblExpenses.Text = $"Expenses: ₱{expenses:N2}";
                lblProfit.Text = $"Profit: ₱{profit:N2}";
                lblSalesCount.Text = $"Sales: {sales}";
            }
        }

        private void LoadChartData()
        {
            chartDashboard.Series["Revenue"].Points.Clear();
            chartDashboard.Series["Expenses"].Points.Clear();

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                string revenueQuery = @"SELECT DATE(sale_date) day, SUM(total_amount) total
                                FROM sales
                                GROUP BY DATE(sale_date)";

                MySqlCommand cmd = new MySqlCommand(revenueQuery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    chartDashboard.Series["Revenue"].Points.AddXY(
                        reader["day"].ToString(),
                        Convert.ToDecimal(reader["total"])
                    );
                }

                reader.Close();

                string expenseQuery = @"SELECT DATE(expense_date) day, SUM(amount) total
                                FROM expenses
                                GROUP BY DATE(expense_date)";

                MySqlCommand cmd2 = new MySqlCommand(expenseQuery, conn);
                MySqlDataReader reader2 = cmd2.ExecuteReader();

                while (reader2.Read())
                {
                    chartDashboard.Series["Expenses"].Points.AddXY(
                        reader2["day"].ToString(),
                        Convert.ToDecimal(reader2["total"])
                    );
                }
            }
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();
            LoadChartData();
        }
        public DashboardForm(string username, string role)
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome {username} ({role})";
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Close the dashboard and open the login form
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
        private int loggedInUserId = 1; // Replace this later with the real ID from login

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Pass the user ID to the SalesForm constructor
            SalesForm salesForm = new SalesForm(loggedInUserId);

            // When SalesForm closes, show the dashboard again
            salesForm.FormClosed += (s, args) => this.Show();

            salesForm.Show();
        }

        private void btnReceipts_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Pass the user ID to ReceiptsForm just like the other forms
            ReceiptsForm receiptsForm = new ReceiptsForm(loggedInUserId);

            receiptsForm.FormClosed += (s, args) => this.Show();
            receiptsForm.Show();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpensesForm expensesForm = new ExpensesForm(loggedInUserId);
            expensesForm.FormClosed += (s, args) => this.Show();
            expensesForm.Show();
        }
        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnalyticsForm analytics = new AnalyticsForm(loggedInUserId);
            analytics.FormClosed += (s, args) => this.Show();
            analytics.Show();
        }


    }
}