namespace Digital_Receipt_and_Expense_Tracker_System
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
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

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series revenueSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series expenseSeries = new System.Windows.Forms.DataVisualization.Charting.Series();

            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).BeginInit();
            this.SuspendLayout();

            // lblWelcome
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Size = new System.Drawing.Size(500, 30);
            this.lblWelcome.Text = "Welcome";

            // Revenue Card
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.Location = new System.Drawing.Point(30, 70);
            this.lblRevenue.Size = new System.Drawing.Size(200, 40);
            this.lblRevenue.Text = "Revenue: ₱0.00";

            // Expenses Card
            this.lblExpenses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblExpenses.Location = new System.Drawing.Point(250, 70);
            this.lblExpenses.Size = new System.Drawing.Size(200, 40);
            this.lblExpenses.Text = "Expenses: ₱0.00";

            // Profit Card
            this.lblProfit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProfit.Location = new System.Drawing.Point(470, 70);
            this.lblProfit.Size = new System.Drawing.Size(200, 40);
            this.lblProfit.Text = "Profit: ₱0.00";

            // Sales Count Card
            this.lblSalesCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSalesCount.Location = new System.Drawing.Point(690, 70);
            this.lblSalesCount.Size = new System.Drawing.Size(150, 40);
            this.lblSalesCount.Text = "Sales: 0";

            // Chart Setup
            chartArea1.Name = "ChartArea1";
            this.chartDashboard.ChartAreas.Add(chartArea1);

            legend1.Name = "Legend1";
            this.chartDashboard.Legends.Add(legend1);

            revenueSeries.Name = "Revenue";
            revenueSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            revenueSeries.BorderWidth = 3;

            expenseSeries.Name = "Expenses";
            expenseSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            expenseSeries.BorderWidth = 3;

            this.chartDashboard.Series.Add(revenueSeries);
            this.chartDashboard.Series.Add(expenseSeries);

            this.chartDashboard.Location = new System.Drawing.Point(30, 130);
            this.chartDashboard.Size = new System.Drawing.Size(810, 300);

            // Buttons
            this.btnSales.Text = "Sales";
            this.btnSales.Location = new System.Drawing.Point(30, 460);
            this.btnSales.Size = new System.Drawing.Size(120, 40);
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);

            this.btnReceipts.Text = "Receipts";
            this.btnReceipts.Location = new System.Drawing.Point(170, 460);
            this.btnReceipts.Size = new System.Drawing.Size(120, 40);
            this.btnReceipts.Click += new System.EventHandler(this.btnReceipts_Click);

            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.Location = new System.Drawing.Point(310, 460);
            this.btnExpenses.Size = new System.Drawing.Size(120, 40);
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);

            this.btnAnalytics.Text = "Analytics";
            this.btnAnalytics.Location = new System.Drawing.Point(450, 460);
            this.btnAnalytics.Size = new System.Drawing.Size(120, 40);
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);

            this.btnLogout.Text = "Logout";
            this.btnLogout.Location = new System.Drawing.Point(720, 460);
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // DashboardForm
            this.ClientSize = new System.Drawing.Size(880, 520);

            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.lblExpenses);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.lblSalesCount);

            this.Controls.Add(this.chartDashboard);

            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnReceipts);
            this.Controls.Add(this.btnExpenses);
            this.Controls.Add(this.btnAnalytics);
            this.Controls.Add(this.btnLogout);

            this.Text = "POS Dashboard";

            this.Load += new System.EventHandler(this.DashboardForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.chartDashboard)).EndInit();
            this.ResumeLayout(false);
        }
    }
}