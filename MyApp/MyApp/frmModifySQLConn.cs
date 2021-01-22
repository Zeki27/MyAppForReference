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
    public partial class frmModifySQLConn : Form
    {
        public frmModifySQLConn()
        {
            InitializeComponent();
            txtServerName.Text = SQLConnection.server;
            txtUserId.Text = SQLConnection.user;
            txtPassword.Text = SQLConnection.password;
            txtDatabaseName.Text = SQLConnection.database;
            txtSslmode.Text = SQLConnection.SslMode;
        }

        private void frmModifySQLConn_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifyDb_Click(object sender, EventArgs e)
        {
            SQLConnection.ModifyConParam(txtServerName.Text, txtUserId.Text, txtPassword.Text, txtDatabaseName.Text, txtSslmode.Text);
        }
    }
}
