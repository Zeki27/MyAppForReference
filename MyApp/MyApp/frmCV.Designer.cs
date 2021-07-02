
namespace MyApp
{
    partial class frmCV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lbllogo = new System.Windows.Forms.Label();
            this.btnPd = new System.Windows.Forms.Button();
            this.btnDriving = new System.Windows.Forms.Button();
            this.btnLang = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnEduc = new System.Windows.Forms.Button();
            this.btnPersInfo = new System.Windows.Forms.Button();
            this.pnlBottomMenu = new System.Windows.Forms.Panel();
            this.btnExecuteAll = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlIndicatorBase = new System.Windows.Forms.Panel();
            this.pnlIndicator = new System.Windows.Forms.Panel();
            this.lblTableName = new System.Windows.Forms.Label();
            this.lstView = new System.Windows.Forms.ListView();
            this.PIName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIBirthplace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PIEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlCVData = new System.Windows.Forms.Panel();
            this.pnlSideMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlBottomMenu.SuspendLayout();
            this.pnlIndicatorBase.SuspendLayout();
            this.pnlCVData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.Controls.Add(this.pnlLogo);
            this.pnlSideMenu.Controls.Add(this.btnPd);
            this.pnlSideMenu.Controls.Add(this.btnDriving);
            this.pnlSideMenu.Controls.Add(this.btnLang);
            this.pnlSideMenu.Controls.Add(this.btnExp);
            this.pnlSideMenu.Controls.Add(this.btnWork);
            this.pnlSideMenu.Controls.Add(this.btnEduc);
            this.pnlSideMenu.Controls.Add(this.btnPersInfo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(120, 600);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlLogo.Controls.Add(this.lbllogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(120, 100);
            this.pnlLogo.TabIndex = 3;
            // 
            // lbllogo
            // 
            this.lbllogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllogo.AutoSize = true;
            this.lbllogo.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.lbllogo.Location = new System.Drawing.Point(33, 25);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(55, 54);
            this.lbllogo.TabIndex = 0;
            this.lbllogo.Text = "Z";
            // 
            // btnPd
            // 
            this.btnPd.FlatAppearance.BorderSize = 0;
            this.btnPd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPd.ForeColor = System.Drawing.Color.Silver;
            this.btnPd.Location = new System.Drawing.Point(0, 400);
            this.btnPd.Name = "btnPd";
            this.btnPd.Size = new System.Drawing.Size(120, 50);
            this.btnPd.TabIndex = 0;
            this.btnPd.Text = "Personal description";
            this.btnPd.UseVisualStyleBackColor = true;
            this.btnPd.Click += new System.EventHandler(this.btnPd_Click);
            // 
            // btnDriving
            // 
            this.btnDriving.FlatAppearance.BorderSize = 0;
            this.btnDriving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDriving.ForeColor = System.Drawing.Color.Silver;
            this.btnDriving.Location = new System.Drawing.Point(0, 350);
            this.btnDriving.Name = "btnDriving";
            this.btnDriving.Size = new System.Drawing.Size(120, 50);
            this.btnDriving.TabIndex = 0;
            this.btnDriving.Text = "Driving licenses";
            this.btnDriving.UseVisualStyleBackColor = true;
            this.btnDriving.Click += new System.EventHandler(this.btnDriving_Click);
            // 
            // btnLang
            // 
            this.btnLang.FlatAppearance.BorderSize = 0;
            this.btnLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLang.ForeColor = System.Drawing.Color.Silver;
            this.btnLang.Location = new System.Drawing.Point(0, 300);
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(120, 50);
            this.btnLang.TabIndex = 0;
            this.btnLang.Text = "Language";
            this.btnLang.UseVisualStyleBackColor = true;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // btnExp
            // 
            this.btnExp.FlatAppearance.BorderSize = 0;
            this.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExp.ForeColor = System.Drawing.Color.Silver;
            this.btnExp.Location = new System.Drawing.Point(0, 250);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(120, 50);
            this.btnExp.TabIndex = 0;
            this.btnExp.Text = "Experience";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnWork
            // 
            this.btnWork.FlatAppearance.BorderSize = 0;
            this.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWork.ForeColor = System.Drawing.Color.Silver;
            this.btnWork.Location = new System.Drawing.Point(0, 200);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(120, 50);
            this.btnWork.TabIndex = 0;
            this.btnWork.Text = "Workplace";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnEduc
            // 
            this.btnEduc.FlatAppearance.BorderSize = 0;
            this.btnEduc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEduc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEduc.ForeColor = System.Drawing.Color.Silver;
            this.btnEduc.Location = new System.Drawing.Point(0, 150);
            this.btnEduc.Name = "btnEduc";
            this.btnEduc.Size = new System.Drawing.Size(120, 50);
            this.btnEduc.TabIndex = 0;
            this.btnEduc.Text = "Education";
            this.btnEduc.UseVisualStyleBackColor = true;
            this.btnEduc.Click += new System.EventHandler(this.btnEduc_Click);
            // 
            // btnPersInfo
            // 
            this.btnPersInfo.FlatAppearance.BorderSize = 0;
            this.btnPersInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPersInfo.ForeColor = System.Drawing.Color.Silver;
            this.btnPersInfo.Location = new System.Drawing.Point(0, 100);
            this.btnPersInfo.Name = "btnPersInfo";
            this.btnPersInfo.Size = new System.Drawing.Size(120, 50);
            this.btnPersInfo.TabIndex = 0;
            this.btnPersInfo.Text = "Personal Info";
            this.btnPersInfo.UseVisualStyleBackColor = true;
            this.btnPersInfo.Click += new System.EventHandler(this.btnPersInfo_Click);
            // 
            // pnlBottomMenu
            // 
            this.pnlBottomMenu.Controls.Add(this.btnExecuteAll);
            this.pnlBottomMenu.Controls.Add(this.btnClose);
            this.pnlBottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomMenu.Location = new System.Drawing.Point(120, 500);
            this.pnlBottomMenu.Name = "pnlBottomMenu";
            this.pnlBottomMenu.Size = new System.Drawing.Size(730, 100);
            this.pnlBottomMenu.TabIndex = 1;
            // 
            // btnExecuteAll
            // 
            this.btnExecuteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.btnExecuteAll.FlatAppearance.BorderSize = 0;
            this.btnExecuteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecuteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExecuteAll.ForeColor = System.Drawing.Color.Silver;
            this.btnExecuteAll.Location = new System.Drawing.Point(472, 25);
            this.btnExecuteAll.Name = "btnExecuteAll";
            this.btnExecuteAll.Size = new System.Drawing.Size(120, 50);
            this.btnExecuteAll.TabIndex = 0;
            this.btnExecuteAll.Text = "Execute All";
            this.btnExecuteAll.UseVisualStyleBackColor = false;
            this.btnExecuteAll.Click += new System.EventHandler(this.btnExecuteAll_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.ForeColor = System.Drawing.Color.Silver;
            this.btnClose.Location = new System.Drawing.Point(598, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlIndicatorBase
            // 
            this.pnlIndicatorBase.Controls.Add(this.pnlIndicator);
            this.pnlIndicatorBase.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIndicatorBase.Location = new System.Drawing.Point(120, 0);
            this.pnlIndicatorBase.Name = "pnlIndicatorBase";
            this.pnlIndicatorBase.Size = new System.Drawing.Size(10, 500);
            this.pnlIndicatorBase.TabIndex = 2;
            // 
            // pnlIndicator
            // 
            this.pnlIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlIndicator.Location = new System.Drawing.Point(0, 100);
            this.pnlIndicator.Name = "pnlIndicator";
            this.pnlIndicator.Size = new System.Drawing.Size(10, 50);
            this.pnlIndicator.TabIndex = 0;
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTableName.ForeColor = System.Drawing.Color.Silver;
            this.lblTableName.Location = new System.Drawing.Point(6, 25);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(93, 20);
            this.lblTableName.TabIndex = 0;
            this.lblTableName.Text = "Select Data";
            // 
            // lstView
            // 
            this.lstView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.lstView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PIName,
            this.PIBirthplace,
            this.PIBirth,
            this.PIAddress,
            this.PIPhoneNumber,
            this.PIEmail});
            this.lstView.ForeColor = System.Drawing.Color.Silver;
            this.lstView.HideSelection = false;
            this.lstView.Location = new System.Drawing.Point(10, 59);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(698, 379);
            this.lstView.TabIndex = 2;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            // 
            // PIName
            // 
            this.PIName.Text = "Name";
            this.PIName.Width = 81;
            // 
            // PIBirthplace
            // 
            this.PIBirthplace.Text = "Birthplace";
            this.PIBirthplace.Width = 92;
            // 
            // PIBirth
            // 
            this.PIBirth.Text = "Birth";
            this.PIBirth.Width = 96;
            // 
            // PIAddress
            // 
            this.PIAddress.Text = "Address";
            this.PIAddress.Width = 121;
            // 
            // PIPhoneNumber
            // 
            this.PIPhoneNumber.Text = "PhoneNumber";
            this.PIPhoneNumber.Width = 103;
            // 
            // PIEmail
            // 
            this.PIEmail.Text = "Email";
            this.PIEmail.Width = 192;
            // 
            // pnlCVData
            // 
            this.pnlCVData.Controls.Add(this.lstView);
            this.pnlCVData.Controls.Add(this.lblTableName);
            this.pnlCVData.Location = new System.Drawing.Point(130, 0);
            this.pnlCVData.Name = "pnlCVData";
            this.pnlCVData.Size = new System.Drawing.Size(720, 500);
            this.pnlCVData.TabIndex = 3;
            // 
            // frmCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.pnlIndicatorBase);
            this.Controls.Add(this.pnlBottomMenu);
            this.Controls.Add(this.pnlSideMenu);
            this.Controls.Add(this.pnlCVData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCV";
            this.Text = "frmCV";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlBottomMenu.ResumeLayout(false);
            this.pnlIndicatorBase.ResumeLayout(false);
            this.pnlCVData.ResumeLayout(false);
            this.pnlCVData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Button btnEduc;
        private System.Windows.Forms.Button btnPersInfo;
        private System.Windows.Forms.Panel pnlBottomMenu;
        private System.Windows.Forms.Panel pnlIndicatorBase;
        private System.Windows.Forms.Button btnPd;
        private System.Windows.Forms.Button btnDriving;
        private System.Windows.Forms.Button btnLang;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnExecuteAll;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.Panel pnlIndicator;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.ColumnHeader PIName;
        private System.Windows.Forms.ColumnHeader PIBirthplace;
        private System.Windows.Forms.ColumnHeader PIBirth;
        private System.Windows.Forms.ColumnHeader PIAddress;
        private System.Windows.Forms.ColumnHeader PIPhoneNumber;
        private System.Windows.Forms.ColumnHeader PIEmail;
        private System.Windows.Forms.Panel pnlCVData;
    }
}