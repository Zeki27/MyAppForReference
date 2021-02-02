using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnWebsiteDbTab_Click(object sender, EventArgs e)
        {
            pnlWebSiteDb.BringToFront();
        }

        private void btnAddNews_Click(object sender, EventArgs e)
        {
            FormOpenClose.OpenAddWebsiteNewsForm();
        }
    }
}
