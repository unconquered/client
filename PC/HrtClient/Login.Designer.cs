namespace HrtClient
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.chkRememberUserName = new System.Windows.Forms.CheckBox();
            this.chkRemberPassword = new System.Windows.Forms.CheckBox();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lnkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.lnkLabelPasswordRetrieve = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClosing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClosing)).BeginInit();
            this.SuspendLayout();
            // 
            // chkRememberUserName
            // 
            this.chkRememberUserName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.chkRememberUserName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkRememberUserName.Location = new System.Drawing.Point(106, 211);
            this.chkRememberUserName.Name = "chkRememberUserName";
            this.chkRememberUserName.Size = new System.Drawing.Size(89, 16);
            this.chkRememberUserName.TabIndex = 0;
            this.chkRememberUserName.Text = "记住用户名";
            this.chkRememberUserName.UseVisualStyleBackColor = false;
            this.chkRememberUserName.CheckedChanged += new System.EventHandler(this.chkRememberUserName_CheckedChanged);
            // 
            // chkRemberPassword
            // 
            this.chkRemberPassword.BackColor = System.Drawing.SystemColors.MenuBar;
            this.chkRemberPassword.FlatAppearance.BorderSize = 0;
            this.chkRemberPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkRemberPassword.Location = new System.Drawing.Point(230, 211);
            this.chkRemberPassword.Name = "chkRemberPassword";
            this.chkRemberPassword.Size = new System.Drawing.Size(76, 16);
            this.chkRemberPassword.TabIndex = 0;
            this.chkRemberPassword.Text = "记住密码";
            this.chkRemberPassword.UseVisualStyleBackColor = false;
            this.chkRemberPassword.CheckedChanged += new System.EventHandler(this.remberPassword_CheckedChanged);
            // 
            // cmbAccount
            // 
            this.cmbAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cmbAccount.BackColor = System.Drawing.SystemColors.Window;
            this.cmbAccount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAccount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmbAccount.Location = new System.Drawing.Point(106, 145);
            this.cmbAccount.Margin = new System.Windows.Forms.Padding(0);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(200, 20);
            this.cmbAccount.TabIndex = 1;
            this.cmbAccount.Tag = "";
            this.cmbAccount.SelectedIndexChanged += new System.EventHandler(this.cmbAccount_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPassword.Location = new System.Drawing.Point(106, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 21);
            this.txtPassword.TabIndex = 2;
            // 
            // lnkLabelRegister
            // 
            this.lnkLabelRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(150)))), ((int)(((byte)(69)))));
            this.lnkLabelRegister.AutoSize = true;
            this.lnkLabelRegister.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(150)))), ((int)(((byte)(69)))));
            this.lnkLabelRegister.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkLabelRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(150)))), ((int)(((byte)(69)))));
            this.lnkLabelRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(150)))), ((int)(((byte)(69)))));
            this.lnkLabelRegister.Location = new System.Drawing.Point(312, 148);
            this.lnkLabelRegister.Name = "lnkLabelRegister";
            this.lnkLabelRegister.Size = new System.Drawing.Size(53, 12);
            this.lnkLabelRegister.TabIndex = 3;
            this.lnkLabelRegister.TabStop = true;
            this.lnkLabelRegister.Text = "注册账号";
            this.lnkLabelRegister.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(150)))), ((int)(((byte)(69)))));
            this.lnkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabelRegister_LinkClicked);
            // 
            // lnkLabelPasswordRetrieve
            // 
            this.lnkLabelPasswordRetrieve.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(150)))), ((int)(((byte)(69)))));
            this.lnkLabelPasswordRetrieve.AutoSize = true;
            this.lnkLabelPasswordRetrieve.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(150)))), ((int)(((byte)(69)))));
            this.lnkLabelPasswordRetrieve.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(150)))), ((int)(((byte)(69)))));
            this.lnkLabelPasswordRetrieve.Location = new System.Drawing.Point(312, 182);
            this.lnkLabelPasswordRetrieve.Name = "lnkLabelPasswordRetrieve";
            this.lnkLabelPasswordRetrieve.Size = new System.Drawing.Size(53, 12);
            this.lnkLabelPasswordRetrieve.TabIndex = 4;
            this.lnkLabelPasswordRetrieve.TabStop = true;
            this.lnkLabelPasswordRetrieve.Text = "找回密码";
            this.lnkLabelPasswordRetrieve.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(150)))), ((int)(((byte)(69)))));
            this.lnkLabelPasswordRetrieve.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabelPasswordRetrieve_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Location = new System.Drawing.Point(106, 253);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(175, 32);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMinimize.BackgroundImage")));
            this.pbMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMinimize.ErrorImage = null;
            this.pbMinimize.Location = new System.Drawing.Point(336, 12);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(15, 15);
            this.pbMinimize.TabIndex = 7;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbClosing
            // 
            this.pbClosing.BackColor = System.Drawing.Color.Transparent;
            this.pbClosing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbClosing.BackgroundImage")));
            this.pbClosing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbClosing.Location = new System.Drawing.Point(357, 12);
            this.pbClosing.Name = "pbClosing";
            this.pbClosing.Size = new System.Drawing.Size(15, 15);
            this.pbClosing.TabIndex = 8;
            this.pbClosing.TabStop = false;
            this.pbClosing.Click += new System.EventHandler(this.pbClosing_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(384, 296);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cmbAccount);
            this.Controls.Add(this.pbClosing);
            this.Controls.Add(this.lnkLabelPasswordRetrieve);
            this.Controls.Add(this.lnkLabelRegister);
            this.Controls.Add(this.chkRemberPassword);
            this.Controls.Add(this.chkRememberUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pbMinimize);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "登录";
            this.TransparencyKey = System.Drawing.SystemColors.ScrollBar;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClosing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRememberUserName;
        private System.Windows.Forms.CheckBox chkRemberPassword;
        private System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel lnkLabelRegister;
        private System.Windows.Forms.LinkLabel lnkLabelPasswordRetrieve;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbClosing;
    }
}

