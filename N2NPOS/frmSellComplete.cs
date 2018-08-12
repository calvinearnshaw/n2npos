using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2NPOS
{
    public partial class frmSellComplete : Form
    {
        // Setup static variable for passed-in data from frmSell.cs
        public static double subtotal = 0.00;
        public static List<string> basketList = new List<string>();
        
        // Setup class-wide variables
        public double moneyTotal = 0.00;
        public double tendered = 0.00;

        public frmSellComplete()
        {
            InitializeComponent();
        }

        private void frmSellComplete_Load(object sender, EventArgs e)
        {
            // Set moneyTotal to be the same as Subtotal.
            moneyTotal = subtotal;

            // Now set the Amount Due label to be the same as moneyTotal
            lblAmountDue.Text = "£" + moneyTotal.ToString("0.00");

            // We won't dispose the Subtotal variable yet, as it'll be
            // recorded onto the Transactions database at the end of
            // the Sale Completion process.
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbTendered.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbTendered.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbTendered.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbTendered.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbTendered.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbTendered.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbTendered.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbTendered.AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbTendered.AppendText("9");
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (IsStringValid(tbTendered.Text, Convert.ToChar(".")))
            {

            }
            tbTendered.AppendText(".");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbTendered.AppendText("0");
        }

        private bool IsStringValid(string str, char search)
        {
            bool foundSearch = false;
            foreach (char c in str)
            {
                if (c == search)
                {
                    if (foundSearch) return false;
                    foundSearch = true;
                }
            }
            return foundSearch;
        }
    }
}
