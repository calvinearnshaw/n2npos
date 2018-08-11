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
    public partial class frmBugReporting : Form
    {
        // Define class wide variables
        public string exceptionText;
        
        public frmBugReporting()
        {
            InitializeComponent();
        }

        private void frmBugReporting_Load(object sender, EventArgs e)
        {
            lblExceptionTxt.Text = "Error given by N2NPOS:" + Environment.NewLine + exceptionText;
        }

        public void prepareCrashReport()
        {
            
        }
    }
}
