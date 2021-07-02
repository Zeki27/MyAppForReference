using MyApp.Models;
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
        #region model lists
        public List<mdlPersonalInfo> lstPi = new List<mdlPersonalInfo>();
        public List<mdlEducation> lstEdu = new List<mdlEducation>();
        public List<mdlWork> lstWork = new List<mdlWork>();
        public List<mdlExp> lstExp = new List<mdlExp>();
        public List<mdlLang> lstLang = new List<mdlLang>();
        public List<mdlDrivLic> lstDrivlic = new List<mdlDrivLic>();
        public List<mdlPersonalDesc> lstPersDesc = new List<mdlPersonalDesc>();
        #endregion

        public frmCV()
        {
            InitializeComponent();
            pnlIndicator.Height = btnPersInfo.Height;
            pnlIndicator.Top = btnPersInfo.Top;
            lstView.Clear();
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
            lblTableName.Text = btnPersInfo.Text;

            WriteLstPiView();
        }

        private void btnEduc_Click(object sender, EventArgs e)
        {
            IndicatorPnl(btnEduc.Height, btnEduc.Top);
            lblTableName.Text = btnEduc.Text;

            WriteLstEduView();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            IndicatorPnl(btnWork.Height, btnWork.Top);
            lblTableName.Text = btnWork.Text;

            WriteLstWorkView();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            IndicatorPnl(btnExp.Height, btnExp.Top);
            lblTableName.Text = btnExp.Text;

            WriteLstExpView();
        }

        private void btnLang_Click(object sender, EventArgs e)
        {
            IndicatorPnl(btnLang.Height, btnLang.Top);
            lblTableName.Text = btnLang.Text;

            WriteLstLangView();
        }

        private void btnDriving_Click(object sender, EventArgs e)
        {
            IndicatorPnl(btnDriving.Height, btnDriving.Top);
            lblTableName.Text = btnDriving.Text;

            WriteLstDrivLicView();
        }

        private void btnPd_Click(object sender, EventArgs e)
        {
            IndicatorPnl(btnPd.Height, btnPd.Top);
            lblTableName.Text = btnPd.Text;

            WriteLstPersDescView();
        }


        #endregion

        #region List Write Methodes
        public void WriteLstPiView()
        {
            lstPi.Clear();
            lstViewPersInfSetting();
            lstPi = SQLCommands.GetPersInfo();
            for (int i = 0; i < lstPi.Count; i++)
            {
                lstView.Items.Add(new ListViewItem(new string[] { lstPi[i].PiName, lstPi[i].PiBirthP, lstPi[i].PiBirtht, lstPi[i].PiAddress, lstPi[i].PiPhone, lstPi[i].PiEmail }));
            }
        }

        public void WriteLstEduView()
        {
            lstEdu.Clear();
            lstViewEduSetting();
            lstEdu = SQLCommands.GetEducation();
            for (int i = 0; i < lstEdu.Count; i++)
            {
                lstView.Items.Add(new ListViewItem(new string[] { lstEdu[i].EduStart, lstEdu[i].EduEnd, lstEdu[i].SchoolNameHun, lstEdu[i].SchoolNameEng, lstEdu[i].EduHun, lstEdu[i].EduEng}));
            }
        }

        public void WriteLstWorkView()
        {
            lstWork.Clear();
            lstViewWorkplaceSetting();
            lstWork = SQLCommands.GetWorkPlace();
            for (int i = 0; i < lstWork.Count; i++)
            {
                lstView.Items.Add(new ListViewItem(new string[] { lstWork[i].WorkStart, lstWork[i].WorkEnd, lstWork[i].WorkNameHun, lstWork[i].WorkNameEng, lstWork[i].RoleHun, lstWork[i].RoleEng }));
            }
        }

        public void WriteLstExpView()
        {
            lstExp.Clear();
            lstViewExpSetting();
            lstExp = SQLCommands.GetExperience();
            for (int i = 0; i < lstExp.Count; i++)
            {
                lstView.Items.Add(new ListViewItem(new string[] { lstExp[i].ExpHun, lstExp[i].ExpEng }));
            }
        }

        public void WriteLstLangView()
        {
            lstLang.Clear();
            lstViewLanguageSetting();
            lstLang = SQLCommands.GetLanguage();
            for (int i = 0; i < lstLang.Count; i++)
            {
                lstView.Items.Add(new ListViewItem(new string[] { lstLang[i].LangHun, lstLang[i].LangEng, lstLang[i].LangLevelHun, lstLang[i].LangLevelEng }));
            }
        }

        public void WriteLstDrivLicView()
        {
            lstDrivlic.Clear();
            lstViewDrivingLicSetting();
            lstDrivlic = SQLCommands.GetDrivingLicense();
            for (int i = 0; i < lstDrivlic.Count; i++)
            {
                lstView.Items.Add(new ListViewItem(new string[] { lstDrivlic[i].DLCat, lstDrivlic[i].DLAcDate, lstDrivlic[i].DLExDate }));
            }
        }

        public void WriteLstPersDescView()
        {
            lstPersDesc.Clear();
            lstViewPersDescSetting();
            lstPersDesc = SQLCommands.GetPersDesc();
            for (int i = 0; i < lstPersDesc.Count; i++)
            {
                lstView.Items.Add(new ListViewItem(new string[] { lstPersDesc[i].PDHun, lstPersDesc[i].PDEng }));
            }
        }

        #endregion

        //Contains the Columns and list view settings
        #region ListViewOptions 

        // Basic options
        private void lstViewBaseOptions()
        {
            lstView.Columns.Clear();
            lstView.Items.Clear();
            lstView.View = View.Details;
            lstView.GridLines = true;
            lstView.AutoArrange = true;
        }

        //Personal Information
        private void lstViewPersInfSetting()
        {
            lstViewBaseOptions();
            lstView.Columns.Add("Name");
            lstView.Columns.Add("Birthplace");
            lstView.Columns.Add("Birth");
            lstView.Columns.Add("Address");
            lstView.Columns.Add("Phone");
            lstView.Columns.Add("E-mail");
        }

        private void lstViewEduSetting()
        {
            lstViewBaseOptions();
            lstView.Columns.Add("Start Date");
            lstView.Columns.Add("End Date");
            lstView.Columns.Add("Schoolname HUN");
            lstView.Columns.Add("Schoolname ENG");
            lstView.Columns.Add("Education HUN");
            lstView.Columns.Add("Education ENG");
        }

        private void lstViewWorkplaceSetting()
        {
            lstViewBaseOptions();
            lstView.Columns.Add("Start Date");
            lstView.Columns.Add("End Date");
            lstView.Columns.Add("Workplace HUN");
            lstView.Columns.Add("Workplace ENG");
            lstView.Columns.Add("Role HUN");
            lstView.Columns.Add("Role ENG");
        }

        private void lstViewExpSetting()
        {
            lstViewBaseOptions();
            lstView.Columns.Add("Experience HUN");
            lstView.Columns.Add("Experience ENG");
        }

        private void lstViewLanguageSetting()
        {
            lstViewBaseOptions();
            lstView.Columns.Add("Language name HUN");
            lstView.Columns.Add("Language name ENG");
            lstView.Columns.Add("Level HUN");
            lstView.Columns.Add("Level ENG");
        }

        private void lstViewDrivingLicSetting()
        {
            lstViewBaseOptions();
            lstView.Columns.Add("Category");
            lstView.Columns.Add("Ac Date");
            lstView.Columns.Add("Ex Date");
        }

        private void lstViewPersDescSetting()
        {
            lstViewBaseOptions();
            lstView.Columns.Add("Description HUN");
            lstView.Columns.Add("Description ENG");
        }
        #endregion
    }
}
