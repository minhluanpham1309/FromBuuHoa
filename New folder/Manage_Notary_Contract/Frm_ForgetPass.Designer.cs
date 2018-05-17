namespace Manage_Notary_Contract
{
    partial class Frm_ForgetPass
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbInstruction = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttSearch = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(26, 28);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(174, 25);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Find your account";
            // 
            // lbInstruction
            // 
            this.lbInstruction.AutoSize = true;
            this.lbInstruction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstruction.Location = new System.Drawing.Point(71, 73);
            this.lbInstruction.Name = "lbInstruction";
            this.lbInstruction.Size = new System.Drawing.Size(544, 21);
            this.lbInstruction.TabIndex = 1;
            this.lbInstruction.Text = "Please enter your email address or phone number to search for your account.";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.LightGray;
            this.txtSearch.Location = new System.Drawing.Point(75, 106);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(540, 29);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Email address or phone number";
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.bttCancel);
            this.panel1.Controls.Add(this.bttSearch);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lbInstruction);
            this.panel1.Location = new System.Drawing.Point(34, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 208);
            this.panel1.TabIndex = 4;
            // 
            // bttSearch
            // 
            this.bttSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.bttSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttSearch.Location = new System.Drawing.Point(400, 158);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(95, 29);
            this.bttSearch.TabIndex = 3;
            this.bttSearch.Text = "Search";
            this.bttSearch.UseVisualStyleBackColor = false;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancel.Location = new System.Drawing.Point(520, 158);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(95, 29);
            this.bttCancel.TabIndex = 4;
            this.bttCancel.Text = "Cancel";
            this.bttCancel.UseVisualStyleBackColor = true;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // Frm_ForgetPass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 274);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ForgetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ForgetPass";
            this.Load += new System.EventHandler(this.Frm_ForgetPass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbInstruction;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttSearch;
    }
}