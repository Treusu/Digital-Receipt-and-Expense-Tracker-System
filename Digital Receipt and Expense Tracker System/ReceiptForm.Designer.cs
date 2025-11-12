namespace Digital_Receipt_and_Expense_Tracker_System
{
    partial class ReceiptForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblBusinessName;
        private Label lblDate;
        private Label lblCustomer;
        private Label lblTotal;
        private DataGridView dgvReceiptItems;
        private Button btnClose;
        private Button btnPrint;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblBusinessName = new Label();
            this.lblDate = new Label();
            this.lblCustomer = new Label();
            this.lblTotal = new Label();
            this.dgvReceiptItems = new DataGridView();
            this.btnClose = new Button();
            this.btnPrint = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptItems)).BeginInit();
            this.SuspendLayout();


            // btnPrint
            this.btnPrint.Text = "Print Receipt";
            this.btnPrint.Location = new Point(50, 350);
            this.btnPrint.Size = new Size(90, 30);
            this.btnPrint.Click += new EventHandler(this.btnPrint_Click);
            this.Controls.Add(this.btnPrint);

            // lblBusinessName
            this.lblBusinessName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblBusinessName.Location = new Point(100, 10);
            this.lblBusinessName.Size = new Size(250, 30);
            this.lblBusinessName.Text = "Business Name";
            this.lblBusinessName.TextAlign = ContentAlignment.MiddleCenter;

            // lblDate
            this.lblDate.Location = new Point(20, 50);
            this.lblDate.Size = new Size(300, 20);

            // lblCustomer
            this.lblCustomer.Location = new Point(20, 70);
            this.lblCustomer.Size = new Size(300, 20);

            // dgvReceiptItems
            this.dgvReceiptItems.Location = new Point(20, 100);
            this.dgvReceiptItems.Size = new Size(360, 200);
            this.dgvReceiptItems.ReadOnly = true;
            this.dgvReceiptItems.AllowUserToAddRows = false;
            this.dgvReceiptItems.AllowUserToDeleteRows = false;
            this.dgvReceiptItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // lblTotal
            this.lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblTotal.Location = new Point(20, 310);
            this.lblTotal.Size = new Size(360, 30);
            this.lblTotal.TextAlign = ContentAlignment.MiddleRight;

            // btnClose
            this.btnClose.Text = "Close";
            this.btnClose.Location = new Point(250, 350);
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // ReceiptForm
            this.ClientSize = new Size(400, 400);
            this.Controls.Add(this.lblBusinessName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.dgvReceiptItems);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnClose);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.Load += new EventHandler(this.ReceiptForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptItems)).EndInit();
            this.ResumeLayout(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
