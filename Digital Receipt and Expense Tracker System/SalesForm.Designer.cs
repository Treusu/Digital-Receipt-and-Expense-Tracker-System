namespace Digital_Receipt_and_Expense_Tracker_System
{
    partial class SalesForm
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

            // Customer row
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();

            // Date row
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();

            // Buttons
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            // Grid & total
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "New Sale";

            // Customer
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(20, 58);
            this.lblCustomer.Text = "Customer Name:";

            this.txtCustomer.Location = new System.Drawing.Point(140, 55);
            this.txtCustomer.Size = new System.Drawing.Size(250, 23);
            this.txtCustomer.PlaceholderText = "Enter customer name...";

            // Sale Date
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Location = new System.Drawing.Point(20, 98);
            this.lblSaleDate.Text = "Sale Date:";

            this.dtpSaleDate.Location = new System.Drawing.Point(140, 95);
            this.dtpSaleDate.Size = new System.Drawing.Size(250, 23);
            this.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaleDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpSaleDate.ShowUpDown = false;
            this.dtpSaleDate.Value = System.DateTime.Now;

            // Buttons
            this.btnAddItem.Location = new System.Drawing.Point(420, 55);
            this.btnAddItem.Size = new System.Drawing.Size(130, 32);
            this.btnAddItem.Text = "➕ Add Item";
            this.btnAddItem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);

            this.btnSave.Location = new System.Drawing.Point(420, 100);
            this.btnSave.Size = new System.Drawing.Size(130, 32);
            this.btnSave.Text = "💾 Save Sale";
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnBack.Location = new System.Drawing.Point(565, 100);
            this.btnBack.Size = new System.Drawing.Size(100, 32);
            this.btnBack.Text = "← Back";
            this.btnBack.BackColor = System.Drawing.Color.SlateGray;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // dgvItems
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ReadOnly = true;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Location = new System.Drawing.Point(20, 150);
            this.dgvItems.Size = new System.Drawing.Size(760, 360);
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTotal.Location = new System.Drawing.Point(20, 525);
            this.lblTotal.Text = "Total: ₱0.00";

            // SalesForm
            this.ClientSize = new System.Drawing.Size(810, 570);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblSaleDate);
            this.Controls.Add(this.dtpSaleDate);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.lblTotal);
            this.Text = "New Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lblTotal;
    }
}