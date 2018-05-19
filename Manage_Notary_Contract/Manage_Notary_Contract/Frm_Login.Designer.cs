namespace Manage_Notary_Contract
{
    partial class Frm_Login
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.bttLogIn = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.linkLbForgetPass = new System.Windows.Forms.LinkLabel();
            this.bttThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(57, 64);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(176, 32);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Email or Phone";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(57, 130);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(112, 32);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.LightGray;
            this.txtUsername.Location = new System.Drawing.Point(62, 92);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(387, 39);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Email address or phone number";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.LightGray;
            this.txtPassword.Location = new System.Drawing.Point(62, 158);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(387, 39);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Enter password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // bttLogIn
            // 
            this.bttLogIn.BackColor = System.Drawing.Color.RoyalBlue;
            this.bttLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttLogIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttLogIn.Location = new System.Drawing.Point(62, 233);
            this.bttLogIn.Name = "bttLogIn";
            this.bttLogIn.Size = new System.Drawing.Size(152, 31);
            this.bttLogIn.TabIndex = 4;
            this.bttLogIn.Text = "Log In";
            this.bttLogIn.UseVisualStyleBackColor = false;
            this.bttLogIn.Click += new System.EventHandler(this.bttLogIn_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(15, 16);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(106, 32);
            this.lbLogin.TabIndex = 6;
            this.lbLogin.Text = "LOGIN";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLbForgetPass
            // 
            this.linkLbForgetPass.AutoSize = true;
            this.linkLbForgetPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLbForgetPass.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLbForgetPass.Location = new System.Drawing.Point(305, 200);
            this.linkLbForgetPass.Name = "linkLbForgetPass";
            this.linkLbForgetPass.Size = new System.Drawing.Size(213, 32);
            this.linkLbForgetPass.TabIndex = 8;
            this.linkLbForgetPass.TabStop = true;
            this.linkLbForgetPass.Text = "Forgotten account?";
            this.linkLbForgetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbForgetPass_LinkClicked);
            // 
            // bttThoat
            // 
            this.bttThoat.BackColor = System.Drawing.Color.RoyalBlue;
            this.bttThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttThoat.Location = new System.Drawing.Point(297, 233);
            this.bttThoat.Name = "bttThoat";
            this.bttThoat.Size = new System.Drawing.Size(152, 31);
            this.bttThoat.TabIndex = 9;
            this.bttThoat.Text = "Exit";
            this.bttThoat.UseVisualStyleBackColor = false;
            this.bttThoat.Click += new System.EventHandler(this.bttThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Controls.Add(this.lbLogin);
            this.panel1.Controls.Add(this.bttThoat);
            this.panel1.Controls.Add(this.lbPassword);
            this.panel1.Controls.Add(this.linkLbForgetPass);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.bttLogIn);
            this.panel1.Location = new System.Drawing.Point(34, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 292);
            this.panel1.TabIndex = 10;

            // 
            // Frm_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 355);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button bttLogIn;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.LinkLabel linkLbForgetPass;
        private System.Windows.Forms.Button bttThoat;
        private System.Windows.Forms.Panel panel1;
    }
}