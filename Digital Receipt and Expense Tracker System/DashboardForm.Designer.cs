namespace Digital_Receipt_and_Expense_Tracker_System
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblSalesCount = new System.Windows.Forms.Label();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnReceipts = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.chartDashboard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "Dashboard";

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.Location = new System.Drawing.Point(20, 55);
            this.lblWelcome.Text = "Welcome!";

            // Stats labels
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblRevenue.Location = new System.Drawing.Point(20, 95);
            this.lblRevenue.Text = "Revenue: ₱0.00";

            this.lblExpenses.AutoSize = true;
            this.lblExpenses.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblExpenses.ForeColor = System.Drawing.Color.IndianRed;
            this.lblExpenses.Location = new System.Drawing.Point(220, 95);
            this.lblExpenses.Text = "Expenses: ₱0.00";

            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblProfit.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblProfit.Location = new System.Drawing.Point(440, 95);
            this.lblProfit.Text = "Profit: ₱0.00";

            this.lblSalesCount.AutoSize = true;
            this.lblSalesCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSalesCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblSalesCount.Location = new System.Drawing.Point(660, 95);
            this.lblSalesCount.Text = "Sales: 0";

            // Nav buttons
            int btnTop = 130;
            int btnW = 130, btnH = 36;

            this.btnSales.Location = new System.Drawing.Point(20, btnTop);
            this.btnSales.Size = new System.Drawing.Size(btnW, btnH);
            this.btnSales.Text = "🛒 Sales";
            this.btnSales.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);

            this.btnReceipts.Location = new System.Drawing.Point(165, btnTop);
            this.btnReceipts.Size = new System.Drawing.Size(btnW, btnH);
            this.btnReceipts.Text = "🧾 Receipts";
            this.btnReceipts.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnReceipts.ForeColor = System.Drawing.Color.White;
            this.btnReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipts.Click += new System.EventHandler(this.btnReceipts_Click);

            this.btnExpenses.Location = new System.Drawing.Point(310, btnTop);
            this.btnExpenses.Size = new System.Drawing.Size(btnW, btnH);
            this.btnExpenses.Text = "💸 Expenses";
            this.btnExpenses.BackColor = System.Drawing.Color.IndianRed;
            this.btnExpenses.ForeColor = System.Drawing.Color.White;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);

            this.btnAnalytics.Location = new System.Drawing.Point(455, btnTop);
            this.btnAnalytics.Size = new System.Drawing.Size(btnW, btnH);
            this.btnAnalytics.Text = "📊 Analytics";
            this.btnAnalytics.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAnalytics.ForeColor = System.Drawing.Color.White;
            this.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);

            this.btnLogout.Location = new System.Drawing.Point(660, btnTop);
            this.btnLogout.Size = new System.Drawing.Size(btnW, btnH);
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.BackColor = System.Drawing.Color.DimGray;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // chartDashboard
            this.chartDashboard.ChartAreas.Add("ChartArea1");
            this.chartDashboard.Legends.Add("Legend1");
            this.chartDashboard.Series.Add("Revenue");
            this.chartDashboard.Series["Revenue"].Color = System.Drawing.Color.SteelBlue;
            this.chartDashboard.Series.Add("Expenses");
            this.chartDashboard.Series["Expenses"].Color = System.Drawing.Color.IndianRed;
            this.chartDashboard.Location = new System.Drawing.Point(20, 185);
            this.chartDashboard.Size = new System.Drawing.Size(760, 370);

            // DashboardForm
            this.ClientSize = new System.Drawing.Size(810, 580);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.lblExpenses);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.lblSalesCount);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnReceipts);
            this.Controls.Add(this.btnExpenses);
            this.Controls.Add(this.btnAnalytics);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.chartDashboard);
            this.Text = "Dashboard - Digital Receipt & Expense Tracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblExpenses;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblSalesCount;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnReceipts;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDashboard;
    }
}