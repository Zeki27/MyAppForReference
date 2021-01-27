
namespace MyApp
{
    partial class frmLogInRegister
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
            this.txtLogInEmail = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.lnklblCreateAccount = new System.Windows.Forms.LinkLabel();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chckRememberMe = new System.Windows.Forms.CheckBox();
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.btnModifyDB = new System.Windows.Forms.Button();
            this.lblDbName = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.btnBackToLogIn = new System.Windows.Forms.Button();
            this.btnExit2 = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegisterConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterUserName = new System.Windows.Forms.TextBox();
            this.txtRegisterEmail = new System.Windows.Forms.TextBox();
            this.pnlLogIn.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLogInEmail
            // 
            this.txtLogInEmail.Location = new System.Drawing.Point(38, 154);
            this.txtLogInEmail.Name = "txtLogInEmail";
            this.txtLogInEmail.Size = new System.Drawing.Size(200, 20);
            this.txtLogInEmail.TabIndex = 0;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(38, 206);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(200, 20);
            this.txtLoginPassword.TabIndex = 1;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // lnklblCreateAccount
            // 
            this.lnklblCreateAccount.AutoSize = true;
            this.lnklblCreateAccount.Location = new System.Drawing.Point(57, 344);
            this.lnklblCreateAccount.Name = "lnklblCreateAccount";
            this.lnklblCreateAccount.Size = new System.Drawing.Size(162, 13);
            this.lnklblCreateAccount.TabIndex = 3;
            this.lnklblCreateAccount.TabStop = true;
            this.lnklblCreateAccount.Text = "Don’t have an account? Sign up";
            this.lnklblCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblCreateAccount_LinkClicked);
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.ForeColor = System.Drawing.Color.Silver;
            this.lblEMail.Location = new System.Drawing.Point(35, 138);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(79, 13);
            this.lblEMail.TabIndex = 6;
            this.lblEMail.Text = "E-mail Address:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.Silver;
            this.lblPassword.Location = new System.Drawing.Point(35, 190);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Silver;
            this.lblWelcome.Location = new System.Drawing.Point(79, 17);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(115, 29);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogIn.ForeColor = System.Drawing.Color.Silver;
            this.lblLogIn.Location = new System.Drawing.Point(108, 52);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(54, 20);
            this.lblLogIn.TabIndex = 5;
            this.lblLogIn.Text = "Log In";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(38, 287);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(80, 30);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(158, 287);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chckRememberMe
            // 
            this.chckRememberMe.AutoSize = true;
            this.chckRememberMe.ForeColor = System.Drawing.Color.Silver;
            this.chckRememberMe.Location = new System.Drawing.Point(38, 246);
            this.chckRememberMe.Name = "chckRememberMe";
            this.chckRememberMe.Size = new System.Drawing.Size(95, 17);
            this.chckRememberMe.TabIndex = 2;
            this.chckRememberMe.Text = "Remember Me";
            this.chckRememberMe.UseVisualStyleBackColor = true;
            this.chckRememberMe.CheckedChanged += new System.EventHandler(this.chckRememberMe_CheckedChanged);
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.Controls.Add(this.btnModifyDB);
            this.pnlLogIn.Controls.Add(this.lblWelcome);
            this.pnlLogIn.Controls.Add(this.chckRememberMe);
            this.pnlLogIn.Controls.Add(this.txtLogInEmail);
            this.pnlLogIn.Controls.Add(this.btnExit);
            this.pnlLogIn.Controls.Add(this.txtLoginPassword);
            this.pnlLogIn.Controls.Add(this.btnLogIn);
            this.pnlLogIn.Controls.Add(this.lnklblCreateAccount);
            this.pnlLogIn.Controls.Add(this.lblLogIn);
            this.pnlLogIn.Controls.Add(this.lblDbName);
            this.pnlLogIn.Controls.Add(this.lblDatabase);
            this.pnlLogIn.Controls.Add(this.lblEMail);
            this.pnlLogIn.Controls.Add(this.lblPassword);
            this.pnlLogIn.Location = new System.Drawing.Point(12, 12);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(276, 376);
            this.pnlLogIn.TabIndex = 0;
            this.pnlLogIn.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogIn_Paint);
            // 
            // btnModifyDB
            // 
            this.btnModifyDB.Location = new System.Drawing.Point(39, 102);
            this.btnModifyDB.Name = "btnModifyDB";
            this.btnModifyDB.Size = new System.Drawing.Size(52, 22);
            this.btnModifyDB.TabIndex = 8;
            this.btnModifyDB.Text = "Modify";
            this.btnModifyDB.UseVisualStyleBackColor = true;
            this.btnModifyDB.Click += new System.EventHandler(this.btnModifyDB_Click);
            // 
            // lblDbName
            // 
            this.lblDbName.AutoSize = true;
            this.lblDbName.ForeColor = System.Drawing.Color.Silver;
            this.lblDbName.Location = new System.Drawing.Point(97, 86);
            this.lblDbName.Name = "lblDbName";
            this.lblDbName.Size = new System.Drawing.Size(91, 13);
            this.lblDbName.TabIndex = 6;
            this.lblDbName.Text = "Exampledatabase";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.ForeColor = System.Drawing.Color.Silver;
            this.lblDatabase.Location = new System.Drawing.Point(35, 86);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(56, 13);
            this.lblDatabase.TabIndex = 6;
            this.lblDatabase.Text = "Database:";
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.btnBackToLogIn);
            this.pnlRegister.Controls.Add(this.btnExit2);
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.lblRegister);
            this.pnlRegister.Controls.Add(this.lblConfirmPassword);
            this.pnlRegister.Controls.Add(this.label1);
            this.pnlRegister.Controls.Add(this.lblName);
            this.pnlRegister.Controls.Add(this.label2);
            this.pnlRegister.Controls.Add(this.txtRegisterConfirmPassword);
            this.pnlRegister.Controls.Add(this.txtRegisterPassword);
            this.pnlRegister.Controls.Add(this.txtRegisterUserName);
            this.pnlRegister.Controls.Add(this.txtRegisterEmail);
            this.pnlRegister.Location = new System.Drawing.Point(12, 12);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(276, 376);
            this.pnlRegister.TabIndex = 10;
            this.pnlRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegister_Paint);
            // 
            // btnBackToLogIn
            // 
            this.btnBackToLogIn.Location = new System.Drawing.Point(43, 328);
            this.btnBackToLogIn.Name = "btnBackToLogIn";
            this.btnBackToLogIn.Size = new System.Drawing.Size(199, 23);
            this.btnBackToLogIn.TabIndex = 6;
            this.btnBackToLogIn.Text = "Back to Log In";
            this.btnBackToLogIn.UseVisualStyleBackColor = true;
            this.btnBackToLogIn.Click += new System.EventHandler(this.btnBackToLogIn_Click);
            // 
            // btnExit2
            // 
            this.btnExit2.Location = new System.Drawing.Point(162, 278);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Size = new System.Drawing.Size(80, 30);
            this.btnExit2.TabIndex = 5;
            this.btnExit2.Text = "Exit";
            this.btnExit2.UseVisualStyleBackColor = true;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(42, 278);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(80, 30);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRegister.ForeColor = System.Drawing.Color.Silver;
            this.lblRegister.Location = new System.Drawing.Point(7, 8);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(263, 29);
            this.lblRegister.TabIndex = 27;
            this.lblRegister.Text = "Register a new account";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.Silver;
            this.lblConfirmPassword.Location = new System.Drawing.Point(40, 218);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.lblConfirmPassword.TabIndex = 30;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(39, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Password:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Silver;
            this.lblName.Location = new System.Drawing.Point(39, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 13);
            this.lblName.TabIndex = 28;
            this.lblName.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(39, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "E-mail Address:";
            // 
            // txtRegisterConfirmPassword
            // 
            this.txtRegisterConfirmPassword.Location = new System.Drawing.Point(43, 234);
            this.txtRegisterConfirmPassword.Name = "txtRegisterConfirmPassword";
            this.txtRegisterConfirmPassword.PasswordChar = '*';
            this.txtRegisterConfirmPassword.Size = new System.Drawing.Size(200, 20);
            this.txtRegisterConfirmPassword.TabIndex = 3;
            this.txtRegisterConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(42, 180);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.PasswordChar = '*';
            this.txtRegisterPassword.Size = new System.Drawing.Size(200, 20);
            this.txtRegisterPassword.TabIndex = 2;
            this.txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // txtRegisterUserName
            // 
            this.txtRegisterUserName.Location = new System.Drawing.Point(42, 76);
            this.txtRegisterUserName.Name = "txtRegisterUserName";
            this.txtRegisterUserName.Size = new System.Drawing.Size(200, 20);
            this.txtRegisterUserName.TabIndex = 0;
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.Location = new System.Drawing.Point(42, 127);
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(200, 20);
            this.txtRegisterEmail.TabIndex = 1;
            // 
            // frmLogInRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.pnlLogIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogInRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmWelcome_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmWelcome_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmWelcome_MouseUp);
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogInEmail;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.LinkLabel lnklblCreateAccount;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chckRememberMe;
        private System.Windows.Forms.Panel pnlLogIn;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Button btnBackToLogIn;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegisterConfirmPassword;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox txtRegisterUserName;
        private System.Windows.Forms.TextBox txtRegisterEmail;
        private System.Windows.Forms.Label lblDbName;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Button btnModifyDB;
    }
}