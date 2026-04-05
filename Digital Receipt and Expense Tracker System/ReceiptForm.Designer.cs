namespace Digital_Receipt_and_Expense_Tracker_System
{
    partial class ReceiptForm
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
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dgvReceiptItems = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptItems)).BeginInit();
            this.SuspendLayout();

            // lblBusinessName
            this.lblBusinessName.AutoSize = true;
            this.lblBusinessName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBusinessName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblBusinessName.Location = new System.Drawing.Point(20, 15);
            this.lblBusinessName.Text = "Business Name";

            // lblDate
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDate.ForeColor = System.Drawing.Color.Gray;
            this.lblDate.Location = new System.Drawing.Point(20, 50);
            this.lblDate.Text = "Date";

            // lblCustomer
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomer.Location = new System.Drawing.Point(20, 75);
            this.lblCustomer.Text = "Customer:";

            // dgvReceiptItems
            this.dgvReceiptItems.AllowUserToAddRows = false;
            this.dgvReceiptItems.AllowUserToDeleteRows = false;
            this.dgvReceiptItems.ReadOnly = true;
            this.dgvReceiptItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiptItems.Location = new System.Drawing.Point(20, 110);
            this.dgvReceiptItems.Size = new System.Drawing.Size(560, 280);
            this.dgvReceiptItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblTotal.Location = new System.Drawing.Point(20, 405);
            this.lblTotal.Text = "Total: ₱0.00";

            // btnPrint
            this.btnPrint.Location = new System.Drawing.Point(20, 450);
            this.btnPrint.Size = new System.Drawing.Size(130, 35);
            this.btnPrint.Text = "🖨 Print Receipt";
            this.btnPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            // btnClose
            this.btnClose.Location = new System.Drawing.Point(165, 450);
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.Text = "Close";
            this.btnClose.BackColor = System.Drawing.Color.SlateGray;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Click += new System.EventHandler((s, e) => this.Close());

            // ReceiptForm
            this.ClientSize = new System.Drawing.Size(610, 510);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.dgvReceiptItems);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Text = "Receipt";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DataGridView dgvReceiptItems;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
    }
}