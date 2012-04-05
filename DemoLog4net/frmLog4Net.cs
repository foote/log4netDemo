
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DemoLog4net
{
    public partial class frmLog4Net : Form
    {
        log4net.ILog log = log4net.LogManager.GetLogger("frmLog4NetTester");

        public frmLog4Net()
        {
            InitializeComponent();
        }

        private void btnLogIt_Click(object sender, EventArgs e)
        {
            if (true)
            {
                log.Warn("Warning - Danger");
                lblStatus.Text = "Done logging";
            }
            else
            {
                lblStatus.Text = "Not logging";
            }



        }

        private void frmLog4Net_Load(object sender, EventArgs e)
        {
            ///   New Comment
        }

    }
}
