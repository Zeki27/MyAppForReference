
namespace MyApp
{
    partial class frmMain
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
            this.btnAddNews = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lbllogo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.pnlWeb = new System.Windows.Forms.Panel();
            this.btnWebTab = new System.Windows.Forms.Button();
            this.pnlIndicator = new System.Windows.Forms.Panel();
            this.pnlSideMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlWeb.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNews
            // 
            this.btnAddNews.FlatAppearance.BorderSize = 0;
            this.btnAddNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNews.ForeColor = System.Drawing.Color.Silver;
            this.btnAddNews.Location = new System.Drawing.Point(20, 20);
            this.btnAddNews.Name = "btnAddNews";
            this.btnAddNews.Size = new System.Drawing.Size(120, 70);
            this.btnAddNews.TabIndex = 1;
            this.btnAddNews.Text = "Add News";
            this.btnAddNews.UseVisualStyleBackColor = true;
            this.btnAddNews.Click += new System.EventHandler(this.btnAddNews_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(0, 470);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 70);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.Controls.Add(this.btnWebTab);
            this.pnlSideMenu.Controls.Add(this.pnlLogo);
            this.pnlSideMenu.Controls.Add(this.btnExit);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(120, 540);
            this.pnlSideMenu.TabIndex = 3;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlLogo.Controls.Add(this.lbllogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(120, 100);
            this.pnlLogo.TabIndex = 2;
            this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogo_MouseDown);
            this.pnlLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlLogo_MouseMove);
            this.pnlLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlLogo_MouseUp);
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
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(20, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "Curriculum Vitae";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenu.Location = new System.Drawing.Point(120, 0);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(660, 100);
            this.pnlTopMenu.TabIndex = 4;
            this.pnlTopMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopMenu_MouseDown);
            this.pnlTopMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopMenu_MouseMove);
            this.pnlTopMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopMenu_MouseUp);
            // 
            // pnlWeb
            // 
            this.pnlWeb.Controls.Add(this.button1);
            this.pnlWeb.Controls.Add(this.btnAddNews);
            this.pnlWeb.Location = new System.Drawing.Point(130, 100);
            this.pnlWeb.Name = "pnlWeb";
            this.pnlWeb.Size = new System.Drawing.Size(650, 440);
            this.pnlWeb.TabIndex = 5;
            // 
            // btnWebTab
            // 
            this.btnWebTab.FlatAppearance.BorderSize = 0;
            this.btnWebTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWebTab.ForeColor = System.Drawing.Color.Silver;
            this.btnWebTab.Location = new System.Drawing.Point(0, 100);
            this.btnWebTab.Name = "btnWebTab";
            this.btnWebTab.Size = new System.Drawing.Size(120, 70);
            this.btnWebTab.TabIndex = 3;
            this.btnWebTab.Text = "Web";
            this.btnWebTab.UseVisualStyleBackColor = true;
            this.btnWebTab.Click += new System.EventHandler(this.btnWebTab_Click);
            // 
            // pnlIndicator
            // 
            this.pnlIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlIndicator.Location = new System.Drawing.Point(120, 100);
            this.pnlIndicator.Name = "pnlIndicator";
            this.pnlIndicator.Size = new System.Drawing.Size(10, 70);
            this.pnlIndicator.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(780, 540);
            this.Controls.Add(this.pnlIndicator);
            this.Controls.Add(this.pnlWeb);
            this.Controls.Add(this.pnlTopMenu);
            this.Controls.Add(this.pnlSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My App";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlWeb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddNews;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWebTab;
        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.Panel pnlWeb;
        private System.Windows.Forms.Panel pnlIndicator;
    }
}

