namespace Digital_Receipt_and_Expense_Tracker_System
{
    partial class ExpensesForm
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

            // Input labels & fields
            this.lblExpenseName = new System.Windows.Forms.Label();
            this.txtExpenseName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();

            // Buttons
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            // Grid & total
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "Expenses";

            // Input row  — left column inputs
            int row1Y = 55, row2Y = 90, row3Y = 125, row4Y = 160;

            this.lblExpenseName.AutoSize = true;
            this.lblExpenseName.Location = new System.Drawing.Point(20, row1Y + 3);
            this.lblExpenseName.Text = "Expense Name:";

            this.txtExpenseName.Location = new System.Drawing.Point(130, row1Y);
            this.txtExpenseName.Size = new System.Drawing.Size(200, 23);

            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, row2Y + 3);
            this.lblCategory.Text = "Category:";

            this.txtCategory.Location = new System.Drawing.Point(130, row2Y);
            this.txtCategory.Size = new System.Drawing.Size(200, 23);

            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(20, row3Y + 3);
            this.lblAmount.Text = "Amount (₱):";

            this.txtAmount.Location = new System.Drawing.Point(130, row3Y);
            this.txtAmount.Size = new System.Drawing.Size(200, 23);

            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(20, row4Y + 3);
            this.lblNotes.Text = "Notes:";

            this.txtNotes.Location = new System.Drawing.Point(130, row4Y);
            this.txtNotes.Size = new System.Drawing.Size(200, 23);

            // Buttons
            this.btnAddExpense.Location = new System.Drawing.Point(350, 55);
            this.btnAddExpense.Size = new System.Drawing.Size(130, 32);
            this.btnAddExpense.Text = "➕ Add Expense";
            this.btnAddExpense.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddExpense.ForeColor = System.Drawing.Color.White;
            this.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);

            this.btnDeleteExpense.Location = new System.Drawing.Point(350, 100);
            this.btnDeleteExpense.Size = new System.Drawing.Size(130, 32);
            this.btnDeleteExpense.Text = "🗑 Delete";
            this.btnDeleteExpense.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteExpense.ForeColor = System.Drawing.Color.White;
            this.btnDeleteExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteExpense.Click += new System.EventHandler(this.btnDeleteExpense_Click);

            this.btnBack.Location = new System.Drawing.Point(350, 155);
            this.btnBack.Size = new System.Drawing.Size(130, 32);
            this.btnBack.Text = "← Back";
            this.btnBack.BackColor = System.Drawing.Color.SlateGray;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // dgvExpenses
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToDeleteRows = false;
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenses.Location = new System.Drawing.Point(20, 210);
            this.dgvExpenses.Size = new System.Drawing.Size(760, 350);
            this.dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTotal.Location = new System.Drawing.Point(20, 575);
            this.lblTotal.Text = "Total Expenses: ₱0.00";

            // ExpensesForm
            this.ClientSize = new System.Drawing.Size(810, 615);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblExpenseName);
            this.Controls.Add(this.txtExpenseName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.btnDeleteExpense);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.lblTotal);
            this.Text = "Expenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblExpenseName;
        private System.Windows.Forms.TextBox txtExpenseName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.Label lblTotal;
    }
}