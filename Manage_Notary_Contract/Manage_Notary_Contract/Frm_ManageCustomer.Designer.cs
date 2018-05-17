namespace Manage_Notary_Contract
{
    partial class Frm_ManageCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_customer = new System.Windows.Forms.DataGridView();
            this.col_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_del = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addInfo = new System.Windows.Forms.Button();
            this.btn_editInfo = new System.Windows.Forms.Button();
            this.btn_deleteInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_lastname
            // 
            this.txt_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastname.Location = new System.Drawing.Point(223, 186);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(224, 44);
            this.txt_lastname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // txt_CMND
            // 
            this.txt_CMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CMND.Location = new System.Drawing.Point(223, 244);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(224, 44);
            this.txt_CMND.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "CMND";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1224, 143);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thông tin khách hàng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(822, 184);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(379, 44);
            this.txt_address.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 42);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa Chỉ";
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phoneNumber.Location = new System.Drawing.Point(822, 249);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(379, 44);
            this.txt_phoneNumber.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 42);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số điện thoại";
            // 
            // dt_customer
            // 
            this.dt_customer.AllowUserToAddRows = false;
            this.dt_customer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dt_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_check,
            this.col_name,
            this.col_id_code,
            this.col_address,
            this.col_phone,
            this.col_del});
            this.dt_customer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dt_customer.Location = new System.Drawing.Point(0, 520);
            this.dt_customer.Name = "dt_customer";
            this.dt_customer.RowHeadersVisible = false;
            this.dt_customer.RowTemplate.Height = 33;
            this.dt_customer.Size = new System.Drawing.Size(1224, 345);
            this.dt_customer.TabIndex = 11;
            this.dt_customer.Click += new System.EventHandler(this.dt_customer_Click);
            // 
            // col_check
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = false;
            this.col_check.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_check.FalseValue = "0";
            this.col_check.Frozen = true;
            this.col_check.HeaderText = "Check";
            this.col_check.Name = "col_check";
            this.col_check.TrueValue = "1";
            // 
            // col_name
            // 
            this.col_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_name.DataPropertyName = "LastName";
            this.col_name.Frozen = true;
            this.col_name.HeaderText = "Họ và tên";
            this.col_name.Name = "col_name";
            this.col_name.Width = 200;
            // 
            // col_id_code
            // 
            this.col_id_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_id_code.DataPropertyName = "ID_Code";
            this.col_id_code.HeaderText = "CMND";
            this.col_id_code.Name = "col_id_code";
            this.col_id_code.Width = 150;
            // 
            // col_address
            // 
            this.col_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_address.DataPropertyName = "NPerson_Address";
            this.col_address.HeaderText = "Địa chỉ";
            this.col_address.Name = "col_address";
            this.col_address.Width = 300;
            // 
            // col_phone
            // 
            this.col_phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_phone.DataPropertyName = "Phone_Number";
            this.col_phone.HeaderText = "số điện thoại";
            this.col_phone.Name = "col_phone";
            // 
            // col_del
            // 
            this.col_del.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_del.DataPropertyName = "Is_Delete";
            this.col_del.HeaderText = "Xóa";
            this.col_del.Name = "col_del";
            this.col_del.Width = 50;
            // 
            // btn_addInfo
            // 
            this.btn_addInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addInfo.Location = new System.Drawing.Point(321, 359);
            this.btn_addInfo.Name = "btn_addInfo";
            this.btn_addInfo.Size = new System.Drawing.Size(273, 60);
            this.btn_addInfo.TabIndex = 12;
            this.btn_addInfo.Text = "Thêm thông tin";
            this.btn_addInfo.UseVisualStyleBackColor = true;
            this.btn_addInfo.Click += new System.EventHandler(this.btn_addInfo_Click);
            // 
            // btn_editInfo
            // 
            this.btn_editInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editInfo.Location = new System.Drawing.Point(612, 359);
            this.btn_editInfo.Name = "btn_editInfo";
            this.btn_editInfo.Size = new System.Drawing.Size(261, 60);
            this.btn_editInfo.TabIndex = 13;
            this.btn_editInfo.Text = "Sửa thông tin";
            this.btn_editInfo.UseVisualStyleBackColor = true;
            // 
            // btn_deleteInfo
            // 
            this.btn_deleteInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteInfo.Location = new System.Drawing.Point(879, 359);
            this.btn_deleteInfo.Name = "btn_deleteInfo";
            this.btn_deleteInfo.Size = new System.Drawing.Size(179, 60);
            this.btn_deleteInfo.TabIndex = 14;
            this.btn_deleteInfo.Text = "Xóa";
            this.btn_deleteInfo.UseVisualStyleBackColor = true;
            this.btn_deleteInfo.Click += new System.EventHandler(this.btn_deleteInfo_Click);
            // 
            // Frm_ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 865);
            this.Controls.Add(this.btn_deleteInfo);
            this.Controls.Add(this.btn_editInfo);
            this.Controls.Add(this.btn_addInfo);
            this.Controls.Add(this.dt_customer);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_CMND);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.label2);
            this.Name = "Frm_ManageCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ManageCustomer";
            this.Load += new System.EventHandler(this.Frm_ManageCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dt_customer;
        private System.Windows.Forms.Button btn_addInfo;
        private System.Windows.Forms.Button btn_editInfo;
        private System.Windows.Forms.Button btn_deleteInfo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_del;
    }
}