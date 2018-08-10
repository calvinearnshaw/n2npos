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
    public partial class frmMainScreen : Form
    {
        public static string currentUser = "";

        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            // Get forename details based on passed in data from frmLogin.
            lbCurrentUser.Text = "Hi, " + currentUser;
        }

        private void tileSell_Click(object sender, EventArgs e)
        {
            new frmSell().Show();
        }
    }
}
