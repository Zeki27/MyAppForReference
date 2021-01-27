using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class frmLogInRegister : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public frmLogInRegister()
        {
            InitializeComponent();
            pnlLogIn.BringToFront();
            lblDbName.Text = SQLConnection.database;
        }

        #region LoginPanel
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            SQLCommands.UserLogIn(txtLogInEmail.Text, txtLoginPassword.Text);
            if (SQLCommands._loggedIn)
            {
                this.Close();
                FormOpenClose.OpenMainForm();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnklblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlRegister.BringToFront();
        }

        private void chckRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnModifyDB_Click(object sender, EventArgs e)
        {
            FormOpenClose.OpenSqlModifyForm();
        }
        #endregion


        #region Draggable
        private void frmWelcome_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmWelcome_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmWelcome_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion


        #region RegisterPanel
        private void btnRegister_Click(object sender, EventArgs e)
        {
            pnlLogIn.BringToFront();
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackToLogIn_Click(object sender, EventArgs e)
        {
            pnlLogIn.BringToFront();
        }
        #endregion

        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlLogIn_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
