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

            // We won't dispose the Subtotal variable yet, as it'll be
            // recorded onto the Transactions database at the end of
            // the Sale Completion process.
        }
    }
}
