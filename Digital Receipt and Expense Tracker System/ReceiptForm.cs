using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Digital_Receipt_and_Expense_Tracker_System
{
    public partial class ReceiptForm : Form
    {
        private DataTable receiptItems;
        private string customerName;
        private decimal totalAmount;
        private DateTime saleDate;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintReceipt);

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDoc;
            previewDialog.ShowDialog();
        }
        private void PrintReceipt(object sender, PrintPageEventArgs e)
        {
            float y = 20;
            int leftMargin = 40;
            Font fontRegular = new Font("Segoe UI", 10);
            Font fontBold = new Font("Segoe UI", 10, FontStyle.Bold);

            e.Graphics.DrawString("Slice House", new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Black, leftMargin, y);
            y += 30;
            e.Graphics.DrawString("Digital Receipt", fontBold, Brushes.Black, leftMargin, y);
            y += 25;
            e.Graphics.DrawString("Date: " + saleDate.ToString("MM/dd/yyyy hh:mm tt"), fontRegular, Brushes.Black, leftMargin, y);
            y += 20;
            e.Graphics.DrawString("Customer: " + customerName, fontRegular, Brushes.Black, leftMargin, y);
            y += 30;

            // Header
            e.Graphics.DrawString("Item", fontBold, Brushes.Black, leftMargin, y);
            e.Graphics.DrawString("Qty", fontBold, Brushes.Black, leftMargin + 150, y);
            e.Graphics.DrawString("Price", fontBold, Brushes.Black, leftMargin + 220, y);
            e.Graphics.DrawString("Subtotal", fontBold, Brushes.Black, leftMargin + 300, y);
            y += 20;
            e.Graphics.DrawLine(Pens.Black, leftMargin, y, leftMargin + 380, y);
            y += 10;

            // Items
            foreach (DataRow row in receiptItems.Rows)
            {
                e.Graphics.DrawString(row["Item Name"].ToString(), fontRegular, Brushes.Black, leftMargin, y);
                e.Graphics.DrawString(row["Quantity"].ToString(), fontRegular, Brushes.Black, leftMargin + 150, y);
                e.Graphics.DrawString("₱" + row["Price"].ToString(), fontRegular, Brushes.Black, leftMargin + 220, y);
                e.Graphics.DrawString("₱" + row["Subtotal"].ToString(), fontRegular, Brushes.Black, leftMargin + 300, y);
                y += 20;
            }

            y += 10;
            e.Graphics.DrawLine(Pens.Black, leftMargin, y, leftMargin + 380, y);
            y += 30;            

            // Total
            e.Graphics.DrawString("Total: ₱" + totalAmount.ToString("N2"), fontBold, Brushes.Black, leftMargin + 220, y);
            y += 40;

            e.Graphics.DrawString("Thank you for your purchase!", fontRegular, Brushes.Black, leftMargin, y);
        }
        public ReceiptForm(DataTable items, string customer, decimal total)
        {
            InitializeComponent();
            receiptItems = items;
            customerName = customer;
            totalAmount = total;
            saleDate = DateTime.Now;
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            lblBusinessName.Text = "Slice House";
            lblDate.Text = saleDate.ToString("MMMM dd, yyyy - hh:mm tt");
            lblCustomer.Text = $"Customer: {customerName}";
            lblTotal.Text = $"Total: ₱{totalAmount:N2}";

            dgvReceiptItems.DataSource = receiptItems;
        }
    }
}
