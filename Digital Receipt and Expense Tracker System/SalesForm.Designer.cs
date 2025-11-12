namespace Digital_Receipt_and_Expense_Tracker_System
{
    partial class SalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblCustomer = new Label();
            txtCustomer = new TextBox();
            dgvItems = new DataGridView();
            lblTotal = new Label();
            btnAddItem = new Button();
            btnSave = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(176, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Sales Recording";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 10F);
            lblCustomer.Location = new Point(32, 70);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(112, 19);
            lblCustomer.TabIndex = 1;
            lblCustomer.Text = "Customer Name:";
            // 
            // txtCustomer
            // 
            txtCustomer.Font = new Font("Segoe UI", 10F);
            txtCustomer.Location = new Point(150, 67);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(300, 25);
            txtCustomer.TabIndex = 2;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(36, 110);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersVisible = false;
            dgvItems.Size = new Size(600, 250);
            dgvItems.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(36, 370);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(250, 25);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total: ₱0.00";
            // 
            // btnAddItem
            // 
            btnAddItem.Font = new Font("Segoe UI", 10F);
            btnAddItem.Location = new Point(660, 110);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(120, 35);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10F);
            btnSave.Location = new Point(660, 160);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 35);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save Sale";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.Location = new Point(660, 325);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 35);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(820, 430);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(btnAddItem);
            Controls.Add(lblTotal);
            Controls.Add(dgvItems);
            Controls.Add(txtCustomer);
            Controls.Add(lblCustomer);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Module";
            Load += SalesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}
