namespace Digital_Receipt_and_Expense_Tracker_System
{
    partial class ExpensesForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblExpenseName = new Label();
            this.txtExpenseName = new TextBox();
            this.lblCategory = new Label();
            this.txtCategory = new TextBox();
            this.lblAmount = new Label();
            this.txtAmount = new TextBox();
            this.lblNotes = new Label();
            this.txtNotes = new TextBox();
            this.btnAddExpense = new Button();
            this.btnDeleteExpense = new Button();
            this.dgvExpenses = new DataGridView();
            this.lblTotal = new Label();
            this.btnBack = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();

            // Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitle.Location = new Point(20, 20);
            this.lblTitle.Text = "Expense Tracker";

            // Expense Name
            this.lblExpenseName.AutoSize = true;
            this.lblExpenseName.Font = new Font("Segoe UI", 10F);
            this.lblExpenseName.Location = new Point(20, 70);
            this.lblExpenseName.Text = "Expense Name:";

            this.txtExpenseName.Location = new Point(150, 70);
            this.txtExpenseName.Size = new Size(200, 23);

            // Category
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new Font("Segoe UI", 10F);
            this.lblCategory.Location = new Point(20, 110);
            this.lblCategory.Text = "Category:";

            this.txtCategory.Location = new Point(150, 110);
            this.txtCategory.Size = new Size(200, 23);

            // Amount
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new Font("Segoe UI", 10F);
            this.lblAmount.Location = new Point(20, 150);
            this.lblAmount.Text = "Amount (₱):";

            this.txtAmount.Location = new Point(150, 150);
            this.txtAmount.Size = new Size(200, 23);

            // Notes
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new Font("Segoe UI", 10F);
            this.lblNotes.Location = new Point(20, 190);
            this.lblNotes.Text = "Notes:";

            this.txtNotes.Location = new Point(150, 190);
            this.txtNotes.Multiline = true;
            this.txtNotes.Size = new Size(200, 60);

            // Buttons
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.Location = new Point(150, 270);
            this.btnAddExpense.Size = new Size(120, 35);
            this.btnAddExpense.Click += new EventHandler(this.btnAddExpense_Click);

            this.btnDeleteExpense.Text = "Delete Selected";
            this.btnDeleteExpense.Location = new Point(280, 270);
            this.btnDeleteExpense.Size = new Size(120, 35);
            this.btnDeleteExpense.Click += new EventHandler(this.btnDeleteExpense_Click);

            // DataGridView
            this.dgvExpenses.Location = new Point(20, 320);
            this.dgvExpenses.Size = new Size(600, 200);
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Total
            this.lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblTotal.Location = new Point(20, 540);
            this.lblTotal.Size = new Size(300, 30);
            this.lblTotal.Text = "Total Expenses: ₱0.00";

            // Back Button
            this.btnBack.Text = "Back";
            this.btnBack.Location = new Point(500, 540);
            this.btnBack.Size = new Size(100, 30);
            this.btnBack.Click += new EventHandler(this.btnBack_Click);

            // Form
            this.ClientSize = new Size(650, 600);
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
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnBack);
            this.Text = "Expenses";
            this.StartPosition = FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Label lblTitle;
        private Label lblExpenseName;
        private TextBox txtExpenseName;
        private Label lblCategory;
        private TextBox txtCategory;
        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblNotes;
        private TextBox txtNotes;
        private Button btnAddExpense;
        private Button btnDeleteExpense;
        private DataGridView dgvExpenses;
        private Label lblTotal;
        private Button btnBack;

        #endregion
    }
}
