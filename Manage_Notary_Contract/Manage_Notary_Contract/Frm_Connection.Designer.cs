namespace Manage_Notary_Contract
{
    partial class Frm_Connection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbServerName = new System.Windows.Forms.Label();
            this.lbDatabaseName = new System.Windows.Forms.Label();
            this.lbIntegSecurity = new System.Windows.Forms.Label();
            this.txtIntegratedSecurity = new System.Windows.Forms.TextBox();
            this.bttTestConnection = new System.Windows.Forms.Button();
            this.bttConnect = new System.Windows.Forms.Button();
            this.pnConnection = new System.Windows.Forms.Panel();
            this.cbo_servreName = new System.Windows.Forms.ComboBox();
            this.cbbDatabaseName = new System.Windows.Forms.ComboBox();
            this.bttCancel = new System.Windows.Forms.Button();
            this.lbConnection = new System.Windows.Forms.Label();
            this.dgvServerName = new System.Windows.Forms.DataGridView();
            this.colServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServerName)).BeginInit();
            this.SuspendLayout();
            // 
            // lbServerName
            // 
            this.lbServerName.AutoSize = true;
            this.lbServerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServerName.Location = new System.Drawing.Point(59, 65);
            this.lbServerName.Name = "lbServerName";
            this.lbServerName.Size = new System.Drawing.Size(101, 21);
            this.lbServerName.TabIndex = 0;
            this.lbServerName.Text = "Server Name";
            // 
            // lbDatabaseName
            // 
            this.lbDatabaseName.AutoSize = true;
            this.lbDatabaseName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatabaseName.Location = new System.Drawing.Point(59, 115);
            this.lbDatabaseName.Name = "lbDatabaseName";
            this.lbDatabaseName.Size = new System.Drawing.Size(120, 21);
            this.lbDatabaseName.TabIndex = 1;
            this.lbDatabaseName.Text = "Database Name";
            // 
            // lbIntegSecurity
            // 
            this.lbIntegSecurity.AutoSize = true;
            this.lbIntegSecurity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntegSecurity.Location = new System.Drawing.Point(59, 165);
            this.lbIntegSecurity.Name = "lbIntegSecurity";
            this.lbIntegSecurity.Size = new System.Drawing.Size(141, 21);
            this.lbIntegSecurity.TabIndex = 2;
            this.lbIntegSecurity.Text = "Integrated Security";
            // 
            // txtIntegratedSecurity
            // 
            this.txtIntegratedSecurity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntegratedSecurity.Location = new System.Drawing.Point(223, 162);
            this.txtIntegratedSecurity.Name = "txtIntegratedSecurity";
            this.txtIntegratedSecurity.ReadOnly = true;
            this.txtIntegratedSecurity.Size = new System.Drawing.Size(256, 29);
            this.txtIntegratedSecurity.TabIndex = 5;
            this.txtIntegratedSecurity.Text = "True";
            // 
            // bttTestConnection
            // 
            this.bttTestConnection.BackColor = System.Drawing.Color.RoyalBlue;
            this.bttTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttTestConnection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttTestConnection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttTestConnection.Location = new System.Drawing.Point(63, 217);
            this.bttTestConnection.Name = "bttTestConnection";
            this.bttTestConnection.Size = new System.Drawing.Size(154, 31);
            this.bttTestConnection.TabIndex = 6;
            this.bttTestConnection.Text = "Test Connection";
            this.bttTestConnection.UseVisualStyleBackColor = false;
            this.bttTestConnection.Click += new System.EventHandler(this.bttTestConnection_Click);
            // 
            // bttConnect
            // 
            this.bttConnect.BackColor = System.Drawing.Color.RoyalBlue;
            this.bttConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttConnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttConnect.Location = new System.Drawing.Point(257, 217);
            this.bttConnect.Name = "bttConnect";
            this.bttConnect.Size = new System.Drawing.Size(91, 31);
            this.bttConnect.TabIndex = 7;
            this.bttConnect.Text = "Connect";
            this.bttConnect.UseVisualStyleBackColor = false;
            this.bttConnect.Click += new System.EventHandler(this.bttConnect_Click);
            // 
            // pnConnection
            // 
            this.pnConnection.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnConnection.Controls.Add(this.cbo_servreName);
            this.pnConnection.Controls.Add(this.cbbDatabaseName);
            this.pnConnection.Controls.Add(this.bttCancel);
            this.pnConnection.Controls.Add(this.lbConnection);
            this.pnConnection.Controls.Add(this.bttConnect);
            this.pnConnection.Controls.Add(this.lbServerName);
            this.pnConnection.Controls.Add(this.bttTestConnection);
            this.pnConnection.Controls.Add(this.lbDatabaseName);
            this.pnConnection.Controls.Add(this.txtIntegratedSecurity);
            this.pnConnection.Controls.Add(this.lbIntegSecurity);
            this.pnConnection.Location = new System.Drawing.Point(31, 27);
            this.pnConnection.Name = "pnConnection";
            this.pnConnection.Size = new System.Drawing.Size(506, 273);
            this.pnConnection.TabIndex = 8;
            // 
            // cbo_servreName
            // 
            this.cbo_servreName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbo_servreName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_servreName.FormattingEnabled = true;
            this.cbo_servreName.Location = new System.Drawing.Point(223, 62);
            this.cbo_servreName.Name = "cbo_servreName";
            this.cbo_servreName.Size = new System.Drawing.Size(256, 29);
            this.cbo_servreName.TabIndex = 11;
            this.cbo_servreName.SelectedIndexChanged += new System.EventHandler(this.cbo_servreName_SelectedIndexChanged);
            // 
            // cbbDatabaseName
            // 
            this.cbbDatabaseName.BackColor = System.Drawing.Color.White;
            this.cbbDatabaseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDatabaseName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbDatabaseName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDatabaseName.FormattingEnabled = true;
            this.cbbDatabaseName.Location = new System.Drawing.Point(223, 112);
            this.cbbDatabaseName.Name = "cbbDatabaseName";
            this.cbbDatabaseName.Size = new System.Drawing.Size(256, 29);
            this.cbbDatabaseName.TabIndex = 10;
            // 
            // bttCancel
            // 
            this.bttCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancel.ForeColor = System.Drawing.Color.Black;
            this.bttCancel.Location = new System.Drawing.Point(388, 217);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(91, 31);
            this.bttCancel.TabIndex = 9;
            this.bttCancel.Text = "Cancel";
            this.bttCancel.UseVisualStyleBackColor = false;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // lbConnection
            // 
            this.lbConnection.AutoSize = true;
            this.lbConnection.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnection.Location = new System.Drawing.Point(19, 21);
            this.lbConnection.Name = "lbConnection";
            this.lbConnection.Size = new System.Drawing.Size(115, 25);
            this.lbConnection.TabIndex = 8;
            this.lbConnection.Text = "Connection";
            // 
            // dgvServerName
            // 
            this.dgvServerName.AllowUserToAddRows = false;
            this.dgvServerName.AllowUserToDeleteRows = false;
            this.dgvServerName.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvServerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServerName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServerName.ColumnHeadersVisible = false;
            this.dgvServerName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServerName});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServerName.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServerName.Enabled = false;
            this.dgvServerName.EnableHeadersVisualStyles = false;
            this.dgvServerName.Location = new System.Drawing.Point(0, 538);
            this.dgvServerName.Name = "dgvServerName";
            this.dgvServerName.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServerName.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServerName.RowHeadersVisible = false;
            this.dgvServerName.RowHeadersWidth = 20;
            this.dgvServerName.RowTemplate.ReadOnly = true;
            this.dgvServerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvServerName.Size = new System.Drawing.Size(10, 10);
            this.dgvServerName.TabIndex = 9;
            // 
            // colServerName
            // 
            this.colServerName.DataPropertyName = "SERVER NAME";
            this.colServerName.HeaderText = "SERVER NAME";
            this.colServerName.Name = "colServerName";
            this.colServerName.ReadOnly = true;
            // 
            // Frm_Connection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 330);
            this.Controls.Add(this.dgvServerName);
            this.Controls.Add(this.pnConnection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Connector";
            this.Load += new System.EventHandler(this.Frm_Connection_Load);
            this.pnConnection.ResumeLayout(false);
            this.pnConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServerName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbServerName;
        private System.Windows.Forms.Label lbDatabaseName;
        private System.Windows.Forms.Label lbIntegSecurity;
        private System.Windows.Forms.TextBox txtIntegratedSecurity;
        private System.Windows.Forms.Button bttTestConnection;
        private System.Windows.Forms.Button bttConnect;
        private System.Windows.Forms.Panel pnConnection;
        private System.Windows.Forms.Label lbConnection;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.DataGridView dgvServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServerName;
        private System.Windows.Forms.ComboBox cbbDatabaseName;
        private System.Windows.Forms.ComboBox cbo_servreName;
    }

}