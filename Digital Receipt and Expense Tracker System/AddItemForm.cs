using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Receipt_and_Expense_Tracker_System
{
    public partial class AddItemForm : Form
    {
        public string ItemName { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public decimal Subtotal { get; private set; }

        public AddItemForm()
        {
            InitializeComponent();
            UpdateSubtotal(null, null);
        }

        private void UpdateSubtotal(object sender, EventArgs e)
        {
            decimal subtotal = numQuantity.Value * numPrice.Value;
            txtSubtotal.Text = subtotal.ToString("N2");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Please enter an item name.");
                return;
            }

            ItemName = txtItemName.Text.Trim();
            Quantity = (int)numQuantity.Value;
            Price = numPrice.Value;
            Subtotal = Quantity * Price;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}