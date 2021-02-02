
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
            this.pnlMenuTop = new System.Windows.Forms.Panel();
            this.btnWebsiteDbTab = new System.Windows.Forms.Button();
            this.pnlWebSiteDb = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNews = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddSoftware = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddWebsites = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddGames = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMenuTop.SuspendLayout();
            this.pnlWebSiteDb.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuTop
            // 
            this.pnlMenuTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenuTop.Controls.Add(this.btnWebsiteDbTab);
            this.pnlMenuTop.Location = new System.Drawing.Point(12, 12);
            this.pnlMenuTop.Name = "pnlMenuTop";
            this.pnlMenuTop.Size = new System.Drawing.Size(146, 510);
            this.pnlMenuTop.TabIndex = 0;
            // 
            // btnWebsiteDbTab
            // 
            this.btnWebsiteDbTab.BackColor = System.Drawing.Color.Transparent;
            this.btnWebsiteDbTab.FlatAppearance.BorderSize = 0;
            this.btnWebsiteDbTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWebsiteDbTab.Location = new System.Drawing.Point(15, 40);
            this.btnWebsiteDbTab.Name = "btnWebsiteDbTab";
            this.btnWebsiteDbTab.Size = new System.Drawing.Size(115, 46);
            this.btnWebsiteDbTab.TabIndex = 2;
            this.btnWebsiteDbTab.Text = "Website Database";
            this.btnWebsiteDbTab.UseVisualStyleBackColor = false;
            this.btnWebsiteDbTab.Click += new System.EventHandler(this.btnWebsiteDbTab_Click);
            // 
            // pnlWebSiteDb
            // 
            this.pnlWebSiteDb.Controls.Add(this.btnAddGames);
            this.pnlWebSiteDb.Controls.Add(this.btnAddWebsites);
            this.pnlWebSiteDb.Controls.Add(this.btnAddSoftware);
            this.pnlWebSiteDb.Controls.Add(this.btnAddNews);
            this.pnlWebSiteDb.Controls.Add(this.label4);
            this.pnlWebSiteDb.Controls.Add(this.label3);
            this.pnlWebSiteDb.Controls.Add(this.label2);
            this.pnlWebSiteDb.Controls.Add(this.label5);
            this.pnlWebSiteDb.Controls.Add(this.label1);
            this.pnlWebSiteDb.Location = new System.Drawing.Point(164, 12);
            this.pnlWebSiteDb.Name = "pnlWebSiteDb";
            this.pnlWebSiteDb.Size = new System.Drawing.Size(608, 510);
            this.pnlWebSiteDb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "News";
            // 
            // btnAddNews
            // 
            this.btnAddNews.Location = new System.Drawing.Point(17, 98);
            this.btnAddNews.Name = "btnAddNews";
            this.btnAddNews.Size = new System.Drawing.Size(111, 23);
            this.btnAddNews.TabIndex = 1;
            this.btnAddNews.Text = "Add News";
            this.btnAddNews.UseVisualStyleBackColor = true;
            this.btnAddNews.Click += new System.EventHandler(this.btnAddNews_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Softwares";
            // 
            // btnAddSoftware
            // 
            this.btnAddSoftware.Location = new System.Drawing.Point(17, 189);
            this.btnAddSoftware.Name = "btnAddSoftware";
            this.btnAddSoftware.Size = new System.Drawing.Size(111, 23);
            this.btnAddSoftware.TabIndex = 1;
            this.btnAddSoftware.Text = "Add Software";
            this.btnAddSoftware.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Websites";
            // 
            // btnAddWebsites
            // 
            this.btnAddWebsites.Location = new System.Drawing.Point(17, 282);
            this.btnAddWebsites.Name = "btnAddWebsites";
            this.btnAddWebsites.Size = new System.Drawing.Size(111, 23);
            this.btnAddWebsites.TabIndex = 1;
            this.btnAddWebsites.Text = "Add Websites";
            this.btnAddWebsites.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "News";
            // 
            // btnAddGames
            // 
            this.btnAddGames.Location = new System.Drawing.Point(17, 375);
            this.btnAddGames.Name = "btnAddGames";
            this.btnAddGames.Size = new System.Drawing.Size(111, 23);
            this.btnAddGames.TabIndex = 1;
            this.btnAddGames.Text = "Add Games";
            this.btnAddGames.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(13, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "WebsiteDatabase";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 534);
            this.Controls.Add(this.pnlWebSiteDb);
            this.Controls.Add(this.pnlMenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My App";
            this.pnlMenuTop.ResumeLayout(false);
            this.pnlWebSiteDb.ResumeLayout(false);
            this.pnlWebSiteDb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuTop;
        private System.Windows.Forms.Button btnWebsiteDbTab;
        private System.Windows.Forms.Panel pnlWebSiteDb;
        private System.Windows.Forms.Button btnAddGames;
        private System.Windows.Forms.Button btnAddWebsites;
        private System.Windows.Forms.Button btnAddSoftware;
        private System.Windows.Forms.Button btnAddNews;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}

