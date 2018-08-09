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
    public partial class frmLogin : Form
    {
        int count = 0;
        string connString = Properties.Settings.Default.posDataConnectionString;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // On loading of the login screen, perform following operations...
            programFunctions.refreshUidBox(cbUsername, connString);

        }
    }
}
