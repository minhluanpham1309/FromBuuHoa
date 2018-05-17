namespace Manage_Notary_Contract
{
    partial class List_Contract
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tol_cbo_day = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tol_cbo_month = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tol_cbo_year = new System.Windows.Forms.ToolStripComboBox();
            this.tol_cbo_show = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tol_txt_find = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tol_btn_change = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.col_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_no_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nu_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_id_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_no_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sig_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_not = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tol_find = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_check,
            this.col_no_num,
            this.col_nu_book,
            this.col_name,
            this.col_id_code,
            this.col_address,
            this.col_no_date,
            this.col_sig_date,
            this.col_des,
            this.col_type_name,
            this.col_type,
            this.col_price,
            this.col_name_no,
            this.col_not});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1423, 534);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.tol_cbo_day,
            this.toolStripLabel3,
            this.tol_cbo_month,
            this.toolStripLabel4,
            this.tol_cbo_year,
            this.tol_cbo_show,
            this.toolStripSeparator1,
            this.tol_txt_find,
            this.tol_find,
            this.toolStripSeparator2,
            this.tol_btn_change});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1423, 50);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(148, 47);
            this.toolStripLabel1.Text = "Xem DS theo: ";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(60, 47);
            this.toolStripLabel2.Text = "Ngày";
            // 
            // tol_cbo_day
            // 
            this.tol_cbo_day.Name = "tol_cbo_day";
            this.tol_cbo_day.Size = new System.Drawing.Size(100, 50);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(73, 47);
            this.toolStripLabel3.Text = "Tháng";
            // 
            // tol_cbo_month
            // 
            this.tol_cbo_month.Name = "tol_cbo_month";
            this.tol_cbo_month.Size = new System.Drawing.Size(121, 50);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(57, 47);
            this.toolStripLabel4.Text = "Năm";
            // 
            // tol_cbo_year
            // 
            this.tol_cbo_year.Name = "tol_cbo_year";
            this.tol_cbo_year.Size = new System.Drawing.Size(100, 50);
            // 
            // tol_cbo_show
            // 
            this.tol_cbo_show.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tol_cbo_show.Items.AddRange(new object[] {
            "Xem Tất Cả",
            "Xem Theo Năm",
            "Xem Theo Tháng",
            "Xem Theo Ngày"});
            this.tol_cbo_show.Name = "tol_cbo_show";
            this.tol_cbo_show.Size = new System.Drawing.Size(160, 50);
            this.tol_cbo_show.Text = "Xem Theo năm";
            this.tol_cbo_show.SelectedIndexChanged += new System.EventHandler(this.tol_cbo_show_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // tol_txt_find
            // 
            this.tol_txt_find.Name = "tol_txt_find";
            this.tol_txt_find.Size = new System.Drawing.Size(200, 50);
            this.tol_txt_find.Leave += new System.EventHandler(this.tol_txt_find_Leave);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // tol_btn_change
            // 
            this.tol_btn_change.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tol_btn_change.Name = "tol_btn_change";
            this.tol_btn_change.Size = new System.Drawing.Size(103, 47);
            this.tol_btn_change.Text = "Thay Đổi";
            this.tol_btn_change.Click += new System.EventHandler(this.tol_btn_change_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1423, 30);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // col_check
            // 
            this.col_check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_check.FalseValue = "0";
            this.col_check.FillWeight = 37.62658F;
            this.col_check.Frozen = true;
            this.col_check.HeaderText = "STT";
            this.col_check.Name = "col_check";
            this.col_check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_check.TrueValue = "1";
            this.col_check.Width = 40;
            // 
            // col_no_num
            // 
            this.col_no_num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_no_num.DataPropertyName = "Notary_Number";
            this.col_no_num.FillWeight = 149.8638F;
            this.col_no_num.Frozen = true;
            this.col_no_num.HeaderText = "Số CC";
            this.col_no_num.Name = "col_no_num";
            this.col_no_num.Width = 80;
            // 
            // col_nu_book
            // 
            this.col_nu_book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_nu_book.DataPropertyName = "Number_Of_Book";
            this.col_nu_book.FillWeight = 301.3927F;
            this.col_nu_book.Frozen = true;
            this.col_nu_book.HeaderText = "Quyển số";
            this.col_nu_book.Name = "col_nu_book";
            this.col_nu_book.Visible = false;
            this.col_nu_book.Width = 50;
            // 
            // col_name
            // 
            this.col_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_name.DataPropertyName = "LastName";
            this.col_name.FillWeight = 609.1368F;
            this.col_name.Frozen = true;
            this.col_name.HeaderText = "Tên người YC";
            this.col_name.Name = "col_name";
            this.col_name.Width = 150;
            // 
            // col_id_code
            // 
            this.col_id_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_id_code.DataPropertyName = "ID_Code";
            this.col_id_code.FillWeight = 2.880784F;
            this.col_id_code.Frozen = true;
            this.col_id_code.HeaderText = "CMND";
            this.col_id_code.Name = "col_id_code";
            this.col_id_code.Width = 80;
            // 
            // col_address
            // 
            this.col_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_address.DataPropertyName = "NPerson_Address";
            this.col_address.FillWeight = 2.880784F;
            this.col_address.Frozen = true;
            this.col_address.HeaderText = "Địa Chỉ";
            this.col_address.Name = "col_address";
            this.col_address.Width = 180;
            // 
            // col_no_date
            // 
            this.col_no_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_no_date.DataPropertyName = "Notary_Date";
            this.col_no_date.FillWeight = 2.880784F;
            this.col_no_date.Frozen = true;
            this.col_no_date.HeaderText = "Ngày chứng thực";
            this.col_no_date.Name = "col_no_date";
            this.col_no_date.Width = 70;
            // 
            // col_sig_date
            // 
            this.col_sig_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_sig_date.DataPropertyName = "Sign_Date";
            this.col_sig_date.FillWeight = 2.880784F;
            this.col_sig_date.Frozen = true;
            this.col_sig_date.HeaderText = "Ngày ký";
            this.col_sig_date.Name = "col_sig_date";
            this.col_sig_date.Width = 70;
            // 
            // col_des
            // 
            this.col_des.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_des.DataPropertyName = "Description";
            this.col_des.FillWeight = 81.81428F;
            this.col_des.Frozen = true;
            this.col_des.HeaderText = "Nội dung";
            this.col_des.Name = "col_des";
            this.col_des.Width = 300;
            // 
            // col_type_name
            // 
            this.col_type_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_type_name.DataPropertyName = "Type_Name_Contract";
            this.col_type_name.FillWeight = 2.880784F;
            this.col_type_name.Frozen = true;
            this.col_type_name.HeaderText = "Loại hợp đồng";
            this.col_type_name.Name = "col_type_name";
            this.col_type_name.Width = 200;
            // 
            // col_type
            // 
            this.col_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_type.DataPropertyName = "Name_Type";
            this.col_type.HeaderText = "Loại";
            this.col_type.Name = "col_type";
            this.col_type.Visible = false;
            // 
            // col_price
            // 
            this.col_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_price.DataPropertyName = "Notary_Price";
            this.col_price.FillWeight = 2.880784F;
            this.col_price.Frozen = true;
            this.col_price.HeaderText = "Giá tiền";
            this.col_price.Name = "col_price";
            this.col_price.Width = 150;
            // 
            // col_name_no
            // 
            this.col_name_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_name_no.DataPropertyName = "Name_Notary";
            this.col_name_no.FillWeight = 2.880784F;
            this.col_name_no.Frozen = true;
            this.col_name_no.HeaderText = "Người Ký CC";
            this.col_name_no.Name = "col_name_no";
            // 
            // col_not
            // 
            this.col_not.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_not.DataPropertyName = "Note";
            this.col_not.Frozen = true;
            this.col_not.HeaderText = "Ghi Chú";
            this.col_not.Name = "col_not";
            this.col_not.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_not.Visible = false;
            // 
            // tol_find
            // 
            this.tol_find.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tol_find.Items.AddRange(new object[] {
            "Theo Tên",
            "Theo CMND",
            "Theo SCC"});
            this.tol_find.Name = "tol_find";
            this.tol_find.Size = new System.Drawing.Size(150, 50);
            this.tol_find.Text = "Tìm Kiếm";
            this.tol_find.SelectedIndexChanged += new System.EventHandler(this.tol_find_SelectedIndexChanged);
            // 
            // List_Contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 614);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "List_Contract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List_Contract";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.List_Contract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripComboBox tol_cbo_show;
        private System.Windows.Forms.ToolStripTextBox tol_txt_find;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tol_btn_change;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox tol_cbo_day;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox tol_cbo_month;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox tol_cbo_year;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_no_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nu_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_no_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sig_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_des;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_not;
        private System.Windows.Forms.ToolStripComboBox tol_find;
    }
}