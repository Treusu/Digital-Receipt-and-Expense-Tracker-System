namespace Digital_Receipt_and_Expense_Tracker_System
{
    partial class ReceiptsForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvReceipts = new System.Windows.Forms.DataGridView();
            this.viewColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "Receipts";

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(20, 55);
            this.txtSearch.Size = new System.Drawing.Size(300, 23);
            this.txtSearch.PlaceholderText = "Search by customer name...";

            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(335, 53);
            this.btnSearch.Size = new System.Drawing.Size(100, 27);
            this.btnSearch.Text = "🔍 Search";
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(445, 53);
            this.btnRefresh.Size = new System.Drawing.Size(100, 27);
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // dgvReceipts
            this.dgvReceipts.AllowUserToAddRows = false;
            this.dgvReceipts.AllowUserToDeleteRows = false;
            this.dgvReceipts.ReadOnly = true;
            this.dgvReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceipts.Location = new System.Drawing.Point(20, 100);
            this.dgvReceipts.Size = new System.Drawing.Size(760, 430);
            this.dgvReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceipts_CellContentClick);

            // viewColumn (button column for opening receipt)
            this.viewColumn.Name = "viewColumn";
            this.viewColumn.HeaderText = "View";
            this.viewColumn.Text = "View";
            this.viewColumn.UseColumnTextForButtonValue = true;
            this.viewColumn.Width = 70;
            this.dgvReceipts.Columns.Add(this.viewColumn);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(20, 545);
            this.btnDelete.Size = new System.Drawing.Size(130, 32);
            this.btnDelete.Text = "🗑 Delete Sale";
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // btnBack
            this.btnBack.Location = new System.Drawing.Point(165, 545);
            this.btnBack.Size = new System.Drawing.Size(100, 32);
            this.btnBack.Text = "← Back";
            this.btnBack.BackColor = System.Drawing.Color.SlateGray;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // ReceiptsForm
            this.ClientSize = new System.Drawing.Size(810, 600);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvReceipts);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Text = "Receipts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvReceipts;
        private System.Windows.Forms.DataGridViewButtonColumn viewColumn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
    }
}