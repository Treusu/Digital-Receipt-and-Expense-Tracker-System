namespace Digital_Receipt_and_Expense_Tracker_System
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            lblWelcome = new Label();
            btnSales = new Button();
            btnExpenses = new Button();
            btnReceipts = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblWelcome.Location = new Point(25, 25);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(168, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, Admin!";
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.MediumSlateBlue;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSales.ForeColor = Color.White;
            btnSales.Location = new Point(30, 80);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(150, 45);
            btnSales.TabIndex = 1;
            btnSales.Text = "💰 Sales";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnExpenses
            // 
            btnExpenses.BackColor = Color.MediumSlateBlue;
            btnExpenses.FlatStyle = FlatStyle.Flat;
            btnExpenses.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnExpenses.ForeColor = Color.White;
            btnExpenses.Location = new Point(200, 80);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Size = new Size(150, 45);
            btnExpenses.TabIndex = 2;
            btnExpenses.Text = "📊 Expenses";
            btnExpenses.UseVisualStyleBackColor = false;
            // 
            // btnReceipts
            // 
            btnReceipts.BackColor = Color.MediumSlateBlue;
            btnReceipts.FlatStyle = FlatStyle.Flat;
            btnReceipts.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReceipts.ForeColor = Color.White;
            btnReceipts.Location = new Point(370, 80);
            btnReceipts.Name = "btnReceipts";
            btnReceipts.Size = new Size(150, 45);
            btnReceipts.TabIndex = 3;
            btnReceipts.Text = "\U0001f9fe Receipts";
            btnReceipts.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(450, 25);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(90, 30);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 160);
            Controls.Add(btnLogout);
            Controls.Add(btnReceipts);
            Controls.Add(btnExpenses);
            Controls.Add(btnSales);
            Controls.Add(lblWelcome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Receipt Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btnReceipts;
        private System.Windows.Forms.Button btnLogout;
    }
}
