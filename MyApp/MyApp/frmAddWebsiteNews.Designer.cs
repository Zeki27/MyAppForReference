
namespace MyApp
{
    partial class frmAddWebsiteNews
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
            this.btnCreateNews = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtNewsTitleHu = new System.Windows.Forms.TextBox();
            this.rtxtNewsDescHu = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtxtNewsDescEn = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNewsTitleEn = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateNews
            // 
            this.btnCreateNews.FlatAppearance.BorderSize = 0;
            this.btnCreateNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateNews.ForeColor = System.Drawing.Color.Silver;
            this.btnCreateNews.Location = new System.Drawing.Point(446, 376);
            this.btnCreateNews.Name = "btnCreateNews";
            this.btnCreateNews.Size = new System.Drawing.Size(82, 23);
            this.btnCreateNews.TabIndex = 0;
            this.btnCreateNews.Text = "Create News";
            this.btnCreateNews.UseVisualStyleBackColor = true;
            this.btnCreateNews.Click += new System.EventHandler(this.btnCreateNews_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Silver;
            this.btnClose.Location = new System.Drawing.Point(534, 376);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNewsTitleHu
            // 
            this.txtNewsTitleHu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtNewsTitleHu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewsTitleHu.ForeColor = System.Drawing.Color.Silver;
            this.txtNewsTitleHu.Location = new System.Drawing.Point(17, 83);
            this.txtNewsTitleHu.Name = "txtNewsTitleHu";
            this.txtNewsTitleHu.Size = new System.Drawing.Size(164, 13);
            this.txtNewsTitleHu.TabIndex = 2;
            // 
            // rtxtNewsDescHu
            // 
            this.rtxtNewsDescHu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.rtxtNewsDescHu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtNewsDescHu.ForeColor = System.Drawing.Color.Silver;
            this.rtxtNewsDescHu.Location = new System.Drawing.Point(17, 140);
            this.rtxtNewsDescHu.Name = "rtxtNewsDescHu";
            this.rtxtNewsDescHu.Size = new System.Drawing.Size(249, 203);
            this.rtxtNewsDescHu.TabIndex = 4;
            this.rtxtNewsDescHu.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(14, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hír címe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(14, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hír leírása:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(89, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Magyar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtxtNewsDescHu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNewsTitleHu);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 358);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtxtNewsDescEn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtNewsTitleEn);
            this.panel2.Location = new System.Drawing.Point(331, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 358);
            this.panel2.TabIndex = 8;
            // 
            // rtxtNewsDescEn
            // 
            this.rtxtNewsDescEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.rtxtNewsDescEn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtNewsDescEn.ForeColor = System.Drawing.Color.Silver;
            this.rtxtNewsDescEn.Location = new System.Drawing.Point(17, 140);
            this.rtxtNewsDescEn.Name = "rtxtNewsDescEn";
            this.rtxtNewsDescEn.Size = new System.Drawing.Size(249, 203);
            this.rtxtNewsDescEn.TabIndex = 4;
            this.rtxtNewsDescEn.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(14, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "News description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(89, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "English";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(14, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "News title:";
            // 
            // txtNewsTitleEn
            // 
            this.txtNewsTitleEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.txtNewsTitleEn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewsTitleEn.ForeColor = System.Drawing.Color.Silver;
            this.txtNewsTitleEn.Location = new System.Drawing.Point(17, 83);
            this.txtNewsTitleEn.Name = "txtNewsTitleEn";
            this.txtNewsTitleEn.Size = new System.Drawing.Size(164, 13);
            this.txtNewsTitleEn.TabIndex = 2;
            // 
            // frmAddWebsiteNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(623, 406);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreateNews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddWebsiteNews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddWebsiteNews";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAddWebsiteNews_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAddWebsiteNews_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmAddWebsiteNews_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNews;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtNewsTitleHu;
        private System.Windows.Forms.RichTextBox rtxtNewsDescHu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtxtNewsDescEn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewsTitleEn;
    }
}