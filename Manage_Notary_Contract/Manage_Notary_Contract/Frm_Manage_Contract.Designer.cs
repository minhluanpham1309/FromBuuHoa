namespace Manage_Notary_Contract
{
    partial class Frm_detail_contract
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name_p = new System.Windows.Forms.TextBox();
            this.grb_info_person = new System.Windows.Forms.GroupBox();
            this.lbl_add = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_code = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_year = new System.Windows.Forms.ComboBox();
            this.cbo_num_bo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dpk_date_sign = new System.Windows.Forms.DateTimePicker();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.dpk_date_ask = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_type_contract = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_name_contract = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_number_no = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_show_list = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.grb_info_person.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên: ";
            // 
            // txt_name_p
            // 
            this.txt_name_p.Location = new System.Drawing.Point(134, 37);
            this.txt_name_p.Name = "txt_name_p";
            this.txt_name_p.Size = new System.Drawing.Size(282, 44);
            this.txt_name_p.TabIndex = 1;
            // 
            // grb_info_person
            // 
            this.grb_info_person.Controls.Add(this.lbl_add);
            this.grb_info_person.Controls.Add(this.txt_address);
            this.grb_info_person.Controls.Add(this.label2);
            this.grb_info_person.Controls.Add(this.txt_id_code);
            this.grb_info_person.Controls.Add(this.label1);
            this.grb_info_person.Controls.Add(this.txt_name_p);
            this.grb_info_person.Location = new System.Drawing.Point(3, 12);
            this.grb_info_person.Name = "grb_info_person";
            this.grb_info_person.Size = new System.Drawing.Size(817, 138);
            this.grb_info_person.TabIndex = 2;
            this.grb_info_person.TabStop = false;
            this.grb_info_person.Text = "Thông tin người yêu cầu";
            this.grb_info_person.Enter += new System.EventHandler(this.grb_info_person_Enter);
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.Location = new System.Drawing.Point(8, 84);
            this.lbl_add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(124, 36);
            this.lbl_add.TabIndex = 4;
            this.lbl_add.Text = "Địa chỉ: ";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(137, 78);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(670, 44);
            this.txt_address.TabIndex = 5;
            this.txt_address.Leave += new System.EventHandler(this.txt_address_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "CMND: ";
            // 
            // txt_id_code
            // 
            this.txt_id_code.Location = new System.Drawing.Point(525, 34);
            this.txt_id_code.Name = "txt_id_code";
            this.txt_id_code.Size = new System.Drawing.Size(282, 44);
            this.txt_id_code.TabIndex = 3;
            this.txt_id_code.Leave += new System.EventHandler(this.txt_id_code_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_year);
            this.groupBox1.Controls.Add(this.cbo_num_bo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dpk_date_sign);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.dpk_date_ask);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_description);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbo_type_contract);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbo_name_contract);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_number_no);
            this.groupBox1.Location = new System.Drawing.Point(5, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 376);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hợp đồng";
            // 
            // cbo_year
            // 
            this.cbo_year.FormattingEnabled = true;
            this.cbo_year.Location = new System.Drawing.Point(671, 39);
            this.cbo_year.Name = "cbo_year";
            this.cbo_year.Size = new System.Drawing.Size(130, 44);
            this.cbo_year.TabIndex = 21;
            // 
            // cbo_num_bo
            // 
            this.cbo_num_bo.FormattingEnabled = true;
            this.cbo_num_bo.Location = new System.Drawing.Point(526, 39);
            this.cbo_num_bo.Name = "cbo_num_bo";
            this.cbo_num_bo.Size = new System.Drawing.Size(69, 44);
            this.cbo_num_bo.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(604, 39);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 36);
            this.label12.TabIndex = 19;
            this.label12.Text = "Năm: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "Giá CC:";
            // 
            // dpk_date_sign
            // 
            this.dpk_date_sign.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_date_sign.Location = new System.Drawing.Point(602, 80);
            this.dpk_date_sign.Name = "dpk_date_sign";
            this.dpk_date_sign.Size = new System.Drawing.Size(200, 44);
            this.dpk_date_sign.TabIndex = 16;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(538, 169);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(263, 44);
            this.txt_price.TabIndex = 18;
            // 
            // dpk_date_ask
            // 
            this.dpk_date_ask.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_date_ask.Location = new System.Drawing.Point(173, 80);
            this.dpk_date_ask.Name = "dpk_date_ask";
            this.dpk_date_ask.Size = new System.Drawing.Size(200, 44);
            this.dpk_date_ask.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 36);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ngày công chứng:";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(18, 246);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(783, 115);
            this.txt_description.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 213);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 36);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nội dung: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 36);
            this.label8.TabIndex = 9;
            this.label8.Text = "Quyển số:";
            // 
            // cbo_type_contract
            // 
            this.cbo_type_contract.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_type_contract.Enabled = false;
            this.cbo_type_contract.FormattingEnabled = true;
            this.cbo_type_contract.Location = new System.Drawing.Point(173, 168);
            this.cbo_type_contract.Name = "cbo_type_contract";
            this.cbo_type_contract.Size = new System.Drawing.Size(260, 44);
            this.cbo_type_contract.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 36);
            this.label7.TabIndex = 7;
            this.label7.Text = "Loại hợp đồng:";
            // 
            // cbo_name_contract
            // 
            this.cbo_name_contract.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_name_contract.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_name_contract.FormattingEnabled = true;
            this.cbo_name_contract.Location = new System.Drawing.Point(173, 121);
            this.cbo_name_contract.Name = "cbo_name_contract";
            this.cbo_name_contract.Size = new System.Drawing.Size(629, 44);
            this.cbo_name_contract.TabIndex = 6;
            this.cbo_name_contract.SelectedIndexChanged += new System.EventHandler(this.cbo_name_contract_SelectedIndexChanged);
            this.cbo_name_contract.Leave += new System.EventHandler(this.cbo_name_contract_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên hợp đồng: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày yêu cầu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số công chứng:";
            // 
            // txt_number_no
            // 
            this.txt_number_no.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_number_no.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_number_no.Location = new System.Drawing.Point(173, 39);
            this.txt_number_no.Name = "txt_number_no";
            this.txt_number_no.Size = new System.Drawing.Size(220, 44);
            this.txt_number_no.TabIndex = 1;
            this.txt_number_no.Leave += new System.EventHandler(this.txt_number_no_Leave);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(468, 543);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(147, 40);
            this.btn_change.TabIndex = 7;
            this.btn_change.Text = "Lưu thay đổi";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_show_list
            // 
            this.btn_show_list.Location = new System.Drawing.Point(631, 543);
            this.btn_show_list.Name = "btn_show_list";
            this.btn_show_list.Size = new System.Drawing.Size(182, 40);
            this.btn_show_list.TabIndex = 8;
            this.btn_show_list.Text = "Xem danh sách";
            this.btn_show_list.UseVisualStyleBackColor = true;
            this.btn_show_list.Click += new System.EventHandler(this.btn_show_list_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 548);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 36);
            this.label11.TabIndex = 9;
            this.label11.Text = "Ghi chú:";
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(137, 545);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(310, 44);
            this.txt_note.TabIndex = 20;
            // 
            // Frm_detail_contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 597);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_show_list);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_info_person);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_detail_contract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hợp đồng";
            this.Load += new System.EventHandler(this.Frm_Manage_Contract_Load);
            this.grb_info_person.ResumeLayout(false);
            this.grb_info_person.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name_p;
        private System.Windows.Forms.GroupBox grb_info_person;
        private System.Windows.Forms.Label lbl_add;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_code;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_type_contract;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_name_contract;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_number_no;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_show_list;
        private System.Windows.Forms.DateTimePicker dpk_date_sign;
        private System.Windows.Forms.DateTimePicker dpk_date_ask;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.ComboBox cbo_year;
        private System.Windows.Forms.ComboBox cbo_num_bo;
        private System.Windows.Forms.Label label12;
    }
}