using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Receipt_and_Expense_Tracker_System
{
    public partial class DashboardForm : Form
    {
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
    }
}