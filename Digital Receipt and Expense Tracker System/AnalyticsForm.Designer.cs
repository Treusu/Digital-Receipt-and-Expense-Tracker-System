using System.Windows.Forms.DataVisualization.Charting;

namespace Digital_Receipt_and_Expense_Tracker_System
{
    partial class AnalyticsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel topPanel;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.topPanel = new System.Windows.Forms.Panel();

            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series seriesRevenue = new Series();
            Series seriesExpenses = new Series();

            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();

            //
            // topPanel
            //
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.topPanel.Controls.Add(this.lblTitle);
            this.topPanel.Controls.Add(this.cmbView);
            this.topPanel.Controls.Add(this.btnBack);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Height = 80;

            //
            // lblTitle
            //
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(400, 40);
            this.lblTitle.Text = "Revenue & Expense Analytics";

            //
            // cmbView
            //
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.Items.AddRange(new object[] {
            });
            this.cmbView.Location = new System.Drawing.Point(520, 25);
            this.cmbView.Size = new System.Drawing.Size(140, 28);
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);

            //
            // btnBack
            //
            this.btnBack.BackColor = System.Drawing.Color.Firebrick;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(690, 22);
            this.btnBack.Size = new System.Drawing.Size(110, 35);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            //
            // chart1
            //
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);

            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);

            this.chart1.Location = new System.Drawing.Point(30, 110);
            this.chart1.Size = new System.Drawing.Size(780, 420);
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right));

            //
            // Revenue Series
            //
            seriesRevenue.ChartArea = "ChartArea1";
            seriesRevenue.Legend = "Legend1";
            seriesRevenue.Name = "Revenue";
            seriesRevenue.ChartType = SeriesChartType.Line;
            seriesRevenue.BorderWidth = 3;

            //
            // Expense Series
            //
            seriesExpenses.ChartArea = "ChartArea1";
            seriesExpenses.Legend = "Legend1";
            seriesExpenses.Name = "Expenses";
            seriesExpenses.ChartType = SeriesChartType.Line;
            seriesExpenses.BorderWidth = 3;

            this.chart1.Series.Add(seriesRevenue);
            this.chart1.Series.Add(seriesExpenses);

            //
            // AnalyticsForm
            //
            this.ClientSize = new System.Drawing.Size(840, 560);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.topPanel);
            this.Name = "AnalyticsForm";
            this.Text = "Analytics Dashboard";
            this.Load += new System.EventHandler(this.AnalyticsForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}