using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace N2NPOS
{
    public partial class frmSell : Form
    {
        // Declare class-wide variables
        string connString = Properties.Settings.Default.posDataConnectionString;
        List<string> itemName = new List<string>();
        List<string> itemGroup = new List<string>();
        List<string> itemPrice = new List<string>();

        double moneyTotal = 0.00;

        public frmSell()
        {
            InitializeComponent();
        }

        private void frmSell_Load(object sender, EventArgs e)
        {
            // Declare variables for SQL mdf file and its connection properties
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = connString;

            myConn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * from [stock]", myConn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    itemName.Add(dr.GetValue(1).ToString());
                    itemGroup.Add(dr.GetValue(2).ToString());
                    itemPrice.Add(dr.GetValue(3).ToString());
                }

                for (int i = 0; i <= itemGroup.Count - 1; i++)
                {
                    stockListView.Groups.Add(i.ToString(), itemGroup[i].ToString());
                }

                for (int j = 0; j <= itemPrice.Count - 1; j++)
                {
                    stockListView.Items.Add(itemName[j].ToString() + " : £" + itemPrice[j].ToString());
                    stockListView.Items[j].Group = stockListView.Groups[j];
                }

                stockListView.Visible = true;
                stockListView.Dock = DockStyle.Fill;
            }
        }

        private void stockListView_Click(object sender, EventArgs e)
        {
            if (stockListView.SelectedItems.Count != 0)
            {
                orderListBox.Items.Add((string)stockListView.SelectedItems[0].Text);
                string[] words = stockListView.SelectedItems[0].Text.Split('£');
                string item = words[0];
                double price = Convert.ToDouble(words[1]);
                moneyTotal = moneyTotal + price;
                lblSubtotal.Text = "£" + moneyTotal.ToString("0.00");
                // << customer second display code goes in here >>
            }
        }

        private void orderListBox_DoubleClick(object sender, EventArgs e)
        {
            DialogResult msg;
            msg = MessageBox.Show("Remove " + orderListBox.SelectedItem.ToString() + "?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                string[] words = orderListBox.SelectedItem.ToString().Split('£');
                string item = words[0];
                double price = Convert.ToDouble(words[1]);

                moneyTotal = moneyTotal - price;

                lblSubtotal.Text = "£" + moneyTotal.ToString("0.00");
                // <<customer second display code>>
                orderListBox.Items.Remove(orderListBox.SelectedItem);
            }
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            DialogResult msg;
            msg = MessageBox.Show("Clear items from order?" + Environment.NewLine + "This cannot be undone.", "Confirm Clearance", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                moneyTotal = 0.00;
                lblSubtotal.Text = "£0.00";
                orderListBox.Items.Clear();
                // << customer second disp code >> //
                MessageBox.Show("Items cleared.", "N2NPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            DialogResult msg;
            msg = MessageBox.Show("Are you sure you want to cancel the sale?" + Environment.NewLine + "This cannot be undone.", "Confirm Sale Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                moneyTotal = 0.00;
                lblSubtotal.Text = "£0.00";
                orderListBox.Items.Clear();
                // << customer second disp code >> //
                MessageBox.Show("Sale cancelled.", "N2NPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {

        }

        
    }
}
