namespace Digital_Receipt_and_Expense_Tracker_System
{
    partial class AnalyticsForm
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
            this.lblView = new System.Windows.Forms.Label();
            this.cmbView = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "Analytics";

            // lblView
            this.lblView.AutoSize = true;
            this.lblView.Location = new System.Drawing.Point(20, 60);
            this.lblView.Text = "View:";

            // cmbView
            this.cmbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbView.Location = new System.Drawing.Point(70, 57);
            this.cmbView.Size = new System.Drawing.Size(130, 23);
            this.cmbView.SelectedIndexChanged += new System.EventHandler(this.cmbView_SelectedIndexChanged);

            // chart1
            this.chart1.ChartAreas.Add("ChartArea1");
            this.chart1.Legends.Add("Legend1");
            this.chart1.Series.Add("Revenue");
            this.chart1.Series["Revenue"].Color = System.Drawing.Color.SteelBlue;
            this.chart1.Series.Add("Expenses");
            this.chart1.Series["Expenses"].Color = System.Drawing.Color.IndianRed;
            this.chart1.Location = new System.Drawing.Point(20, 95);
            this.chart1.Size = new System.Drawing.Size(740, 400);

            // btnBack
            this.btnBack.Location = new System.Drawing.Point(20, 510);
            this.btnBack.Size = new System.Drawing.Size(100, 32);
            this.btnBack.Text = "← Back";
            this.btnBack.BackColor = System.Drawing.Color.SlateGray;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // AnalyticsForm
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.cmbView);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnBack);
            this.Text = "Analytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AnalyticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.ComboBox cmbView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnBack;
    }
}