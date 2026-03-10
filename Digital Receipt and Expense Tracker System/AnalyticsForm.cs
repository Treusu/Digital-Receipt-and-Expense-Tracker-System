using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Digital_Receipt_and_Expense_Tracker_System
{
    public partial class AnalyticsForm : Form
    {
        private int userId;

        public AnalyticsForm(int loggedUserId)
        {
            InitializeComponent();
            userId = loggedUserId;
        }

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {
            cmbView.Items.Add("Weekly");
            cmbView.Items.Add("Monthly");
            cmbView.SelectedIndex = 0;

            LoadChartData();
        }

        private void cmbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChartData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadChartData()
        {
            chart1.Series["Revenue"].Points.Clear();
            chart1.Series["Expenses"].Points.Clear();

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    string revenueQuery;
                    string expenseQuery;

                    if (cmbView.SelectedItem.ToString() == "Weekly")
                    {
                        revenueQuery = @"SELECT DATE(sale_date) as period, SUM(total_amount) as total
                                         FROM sales
                                         WHERE user_id=@user
                                         GROUP BY DATE(sale_date)";

                        expenseQuery = @"SELECT DATE(expense_date) as period, SUM(amount) as total
                                         FROM expenses
                                         WHERE user_id=@user
                                         GROUP BY DATE(expense_date)";
                    }
                    else
                    {
                        revenueQuery = @"SELECT MONTH(sale_date) as period, SUM(total_amount) as total
                                         FROM sales
                                         WHERE user_id=@user
                                         GROUP BY MONTH(sale_date)";

                        expenseQuery = @"SELECT MONTH(expense_date) as period, SUM(amount) as total
                                         FROM expenses
                                         WHERE user_id=@user
                                         GROUP BY MONTH(expense_date)";
                    }

                    MySqlCommand revCmd = new MySqlCommand(revenueQuery, conn);
                    revCmd.Parameters.AddWithValue("@user", userId);

                    MySqlDataReader revReader = revCmd.ExecuteReader();

                    while (revReader.Read())
                    {
                        chart1.Series["Revenue"].Points.AddXY(
                            revReader["period"].ToString(),
                            Convert.ToDecimal(revReader["total"])
                        );
                    }

                    revReader.Close();

                    MySqlCommand expCmd = new MySqlCommand(expenseQuery, conn);
                    expCmd.Parameters.AddWithValue("@user", userId);

                    MySqlDataReader expReader = expCmd.ExecuteReader();

                    while (expReader.Read())
                    {
                        chart1.Series["Expenses"].Points.AddXY(
                            expReader["period"].ToString(),
                            Convert.ToDecimal(expReader["total"])
                        );
                    }

                    expReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading analytics: " + ex.Message);
                }
            }
        }
    }
}