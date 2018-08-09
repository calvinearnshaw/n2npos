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

        private void lblApplicationName_Click(object sender, EventArgs e)
        {
            if (count == 10)
            {
                DialogResult msg;
                msg = MessageBox.Show("Do you wish to start N2NPOS in developer mode?", "N2NPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msg == DialogResult.Yes)
                {
                    programFunctions.startDevMode(connString);
                }
            } else
            {
                count = count + 1;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }   
    }
}
