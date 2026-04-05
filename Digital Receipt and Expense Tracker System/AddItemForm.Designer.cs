namespace Digital_Receipt_and_Expense_Tracker_System
{
    partial class AddItemForm
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();

            // lblItemName
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(20, 20);
            this.lblItemName.Text = "Item Name:";

            // txtItemName
            this.txtItemName.Location = new System.Drawing.Point(120, 17);
            this.txtItemName.Size = new System.Drawing.Size(200, 23);

            // lblQuantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(20, 60);
            this.lblQuantity.Text = "Quantity:";

            // numQuantity
            this.numQuantity.Location = new System.Drawing.Point(120, 57);
            this.numQuantity.Minimum = 1;
            this.numQuantity.Maximum = 9999;
            this.numQuantity.Value = 1;
            this.numQuantity.Size = new System.Drawing.Size(100, 23);
            this.numQuantity.ValueChanged += new System.EventHandler(this.UpdateSubtotal);

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 100);
            this.lblPrice.Text = "Price (₱):";

            // numPrice
            this.numPrice.Location = new System.Drawing.Point(120, 97);
            this.numPrice.Minimum = 0;
            this.numPrice.Maximum = 999999;
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Size = new System.Drawing.Size(100, 23);
            this.numPrice.ValueChanged += new System.EventHandler(this.UpdateSubtotal);

            // lblSubtotal
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(20, 140);
            this.lblSubtotal.Text = "Subtotal (₱):";

            // txtSubtotal
            this.txtSubtotal.Location = new System.Drawing.Point(120, 137);
            this.txtSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotal.ReadOnly = true;

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(120, 180);
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.Text = "Add Item";
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(220, 180);
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // AddItemForm
            this.ClientSize = new System.Drawing.Size(360, 235);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Text = "Add Item";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}