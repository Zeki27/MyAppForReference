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
    public partial class frmCV : Form
    {
        public frmCV()
        {
            InitializeComponent();
            pnlIndicator.Height = btnPersInfo.Height;
            pnlIndicator.Top = btnPersInfo.Top;
            pnlPersonalinfo.BringToFront();
        }

        #region Indicator panel height changer
        private void IndicatorPnl(int height, int top)
        {
            pnlIndicator.Height = height;
            pnlIndicator.Top = top;
        }

        #endregion

        #region SideMenuButtons

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExecuteAll_Click(object sender, EventArgs e)
        {

        }

        private void btnPersInfo_Click(object sender, EventArgs e)
        {
            IndicatorPnl(btnPersInfo.Height, btnPersInfo.Top);
            pnlPersonalinfo.BringToFront();
        }

        private void btnEduc_Click(object sender, EventArgs e)
        {
            IndicatorPnl(btnEduc.Height, btnEduc.Top);
            pnlEdu.BringToFront();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            IndicatorPnl(btnWork.Height, btnWork.Top);
            pnlWork.BringToFront();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            IndicatorPnl(btnExp.Height, btnExp.Top);
            pnlExp.BringToFront();
        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            IndicatorPnl(btnLang.Height, btnLang.Top);
            pnlLang.BringToFront();
        }

        private void btnDriving_Click(object sender, EventArgs e)
        {
            IndicatorPnl(btnDriving.Height, btnDriving.Top);
            pnlDriving.BringToFront();
        }

        private void btnPd_Click(object sender, EventArgs e)
        {
            IndicatorPnl(btnPd.Height, btnPd.Top);
            pnlPd.BringToFront();
        }
        #endregion



    }
}
