namespace Manage_Notary_Contract
{
    partial class Frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_Manage_Contract = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_add_contract = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_list_contract = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_manage_em = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSmenuBttDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuBttThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Manage_Contract,
            this.menu_manage_em,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.tSmenuBttDangXuat,
            this.tsMenuBttThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);

            this.menuStrip1.Size = new System.Drawing.Size(1156, 25);

            this.menuStrip1.Size = new System.Drawing.Size(1156, 44);

            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
           
            this.menu_Manage_Contract.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_add_contract,
            this.mn_list_contract});
            this.menu_Manage_Contract.Name = "menu_Manage_Contract";

            this.menu_Manage_Contract.Size = new System.Drawing.Size(118, 19);

            this.menu_Manage_Contract.Size = new System.Drawing.Size(228, 38);

            this.menu_Manage_Contract.Text = "Quản lý Hợp Đồng";
            // 
            // mn_add_contract
            // 
            this.mn_add_contract.Name = "mn_add_contract";

            this.mn_add_contract.Size = new System.Drawing.Size(184, 22);

            this.mn_add_contract.Size = new System.Drawing.Size(337, 38);

            this.mn_add_contract.Text = "Thêm hợp đồng";
            this.mn_add_contract.Click += new System.EventHandler(this.mn_add_contract_Click);
            // 
            // mn_list_contract
            // 
            this.mn_list_contract.Name = "mn_list_contract";

            this.mn_list_contract.Size = new System.Drawing.Size(184, 22);

            this.mn_list_contract.Size = new System.Drawing.Size(337, 38);

            this.mn_list_contract.Text = "Danh sách hợp đồng";
            this.mn_list_contract.Click += new System.EventHandler(this.mn_list_contract_Click);
            // 
            // menu_manage_em
            // 
            this.menu_manage_em.Name = "menu_manage_em";

            this.menu_manage_em.Size = new System.Drawing.Size(115, 19);

            this.menu_manage_em.Size = new System.Drawing.Size(223, 38);

            this.menu_manage_em.Text = "Quản lý nhân viên";
            this.menu_manage_em.Click += new System.EventHandler(this.menu_manage_em_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";

            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(125, 19);

            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(241, 38);

            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            this.quảnLýKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // tSmenuBttDangXuat
            // 
            this.tSmenuBttDangXuat.Name = "tSmenuBttDangXuat";
            this.tSmenuBttDangXuat.Size = new System.Drawing.Size(72, 19);
            this.tSmenuBttDangXuat.Text = "Đăng xuất";
            this.tSmenuBttDangXuat.Click += new System.EventHandler(this.tSmenuBttDangXuat_Click);
            // 
            // tsMenuBttThoat
            // 
            this.tsMenuBttThoat.Name = "tsMenuBttThoat";
            this.tsMenuBttThoat.Size = new System.Drawing.Size(50, 19);
            this.tsMenuBttThoat.Text = "Thoát";
            this.tsMenuBttThoat.Click += new System.EventHandler(this.tsMenuBttThoat_Click);
            // 
            // Frm_Main
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);

            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 607);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Văn phòng Công Chứng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_Manage_Contract;
        private System.Windows.Forms.ToolStripMenuItem menu_manage_em;
        private System.Windows.Forms.ToolStripMenuItem mn_add_contract;
        private System.Windows.Forms.ToolStripMenuItem mn_list_contract;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSmenuBttDangXuat;
        private System.Windows.Forms.ToolStripMenuItem tsMenuBttThoat;
    }
}

