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
    public partial class frmAddWebsiteNews : Form
    {
        private bool mouseDown;
        private Point lastLocation;


        public frmAddWebsiteNews()
        {
            InitializeComponent();
        }

        private void btnCreateNews_Click(object sender, EventArgs e)
        {
            SQLCommands.CreateWebsiteNews(txtNewsTitleHu.Text, rtxtNewsDescHu.Text, txtNewsTitleEn.Text, rtxtNewsDescEn.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Draggable

        private void frmAddWebsiteNews_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmAddWebsiteNews_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmAddWebsiteNews_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion
    }
}
