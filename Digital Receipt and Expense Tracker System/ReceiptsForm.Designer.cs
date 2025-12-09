namespace Digital_Receipt_and_Expense_Tracker_System
{
    partial class ReceiptsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Modern UI Design

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvReceipts = new System.Windows.Forms.DataGridView();
            this.viewColumn = new System.Windows.Forms.DataGridViewButtonColumn();

            this.panelTop.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).BeginInit();
            this.SuspendLayout();

            // -------------------------------------------------------
            // Top Panel
            // -------------------------------------------------------
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 65;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.btnBack);

            // Title
            this.lblTitle.Text = "Receipts Dashboard";
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(80, 18);

            // Back Button
            this.btnBack.Text = "◀ Back";
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Location = new System.Drawing.Point(10, 15);
            this.btnBack.Size = new System.Drawing.Size(60, 35);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // -------------------------------------------------------
            // Search Panel
            // -------------------------------------------------------
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Location = new System.Drawing.Point(30, 90);
            this.panelSearch.Size = new System.Drawing.Size(350, 40);
            this.panelSearch.Controls.Add(this.txtSearch);

            // Search TextBox
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(10, 10);
            this.txtSearch.Width = 330;
            this.txtSearch.PlaceholderText = "Search by customer name...";

            // Search Button
            this.btnSearch.Text = "Search";
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(390, 90);
            this.btnSearch.Size = new System.Drawing.Size(110, 40);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // Refresh Button
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(510, 90);
            this.btnRefresh.Size = new System.Drawing.Size(110, 40);
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // -------------------------------------------------------
            // DataGridView (modern style)
            // -------------------------------------------------------
            this.dgvReceipts.Location = new System.Drawing.Point(30, 150);
            this.dgvReceipts.Size = new System.Drawing.Size(760, 380);
            this.dgvReceipts.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceipts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipts.ReadOnly = true;
            this.dgvReceipts.AllowUserToAddRows = false;
            this.dgvReceipts.AllowUserToDeleteRows = false;
            this.dgvReceipts.RowHeadersVisible = false;
            this.dgvReceipts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Column Header Style
            this.dgvReceipts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.dgvReceipts.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReceipts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvReceipts.EnableHeadersVisualStyles = false;

            // View Button Column
            this.viewColumn.HeaderText = "View";
            this.viewColumn.Name = "viewColumn";
            this.viewColumn.Text = "Open";
            this.viewColumn.UseColumnTextForButtonValue = true;
            this.viewColumn.Width = 70;

            this.dgvReceipts.Columns.Add(this.viewColumn);
            this.dgvReceipts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceipts_CellContentClick);

            // -------------------------------------------------------
            // Form Settings
            // -------------------------------------------------------
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.ClientSize = new System.Drawing.Size(820, 570);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvReceipts);
            this.Text = "Receipts Dashboard";

            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvReceipts;
        private System.Windows.Forms.DataGridViewButtonColumn viewColumn;
    }
}
