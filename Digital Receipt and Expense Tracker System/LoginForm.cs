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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                lblMessage.Text = "⚠️ Please enter both username and password.";
                lblMessage.ForeColor = System.Drawing.Color.OrangeRed;
                return;
            }

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    string query = "SELECT * FROM users WHERE username=@username AND password=MD5(@password)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = reader["role"].ToString();
                        MessageBox.Show($"Welcome {username}! You are logged in as {role}.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Go to Dashboard
                        this.Hide();
                        DashboardForm dashboard = new DashboardForm(username, role);
                        dashboard.Show();
                    }
                    else
                    {
                        lblMessage.Text = "❌ Invalid username or password.";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "❌ Error: " + ex.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}