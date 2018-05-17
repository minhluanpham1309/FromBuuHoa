namespace Manage_Notary_Contract
{
    partial class Frm_Employee
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_bDay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_stDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.col_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_Id_Em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name_Em = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_birth_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_start_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên: ";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(329, 21);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(360, 35);
            this.txt_name.TabIndex = 1;
            // 
            // txt_bDay
            // 
            this.txt_bDay.Location = new System.Drawing.Point(888, 23);
            this.txt_bDay.Name = "txt_bDay";
            this.txt_bDay.Size = new System.Drawing.Size(227, 35);
            this.txt_bDay.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(759, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Sinh: ";
            // 
            // txt_stDay
            // 
            this.txt_stDay.Location = new System.Drawing.Point(329, 87);
            this.txt_stDay.Name = "txt_stDay";
            this.txt_stDay.Size = new System.Drawing.Size(238, 35);
            this.txt_stDay.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày bắt đầu: ";
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(764, 90);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(351, 35);
            this.txt_salary.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lương:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Check,
            this.col_Id_Em,
            this.col_Name_Em,
            this.col_birth_day,
            this.col_start_day,
            this.col_salary,
            this.col_stt});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1438, 381);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(567, 162);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(154, 42);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Thêm NV";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(751, 162);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(189, 42);
            this.btn_Edit.TabIndex = 10;
            this.btn_Edit.Text = "Sửa Thông Tin";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(961, 162);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(154, 42);
            this.btn_Del.TabIndex = 11;
            this.btn_Del.Text = "Xóa NV";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // col_Check
            // 
            this.col_Check.FalseValue = "0";
            this.col_Check.Frozen = true;
            this.col_Check.HeaderText = "Check";
            this.col_Check.IndeterminateValue = "0";
            this.col_Check.Name = "col_Check";
            this.col_Check.TrueValue = "1";
            // 
            // col_Id_Em
            // 
            this.col_Id_Em.DataPropertyName = "ID_Employee";
            this.col_Id_Em.HeaderText = "ID NV";
            this.col_Id_Em.Name = "col_Id_Em";
            this.col_Id_Em.ReadOnly = true;
            this.col_Id_Em.Visible = false;
            this.col_Id_Em.Width = 150;
            // 
            // col_Name_Em
            // 
            this.col_Name_Em.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Name_Em.DataPropertyName = "Employee_Name";
            this.col_Name_Em.HeaderText = "Tên nhân viên";
            this.col_Name_Em.Name = "col_Name_Em";
            this.col_Name_Em.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Name_Em.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_birth_day
            // 
            this.col_birth_day.DataPropertyName = "Birth_Day";
            this.col_birth_day.HeaderText = "Ngày Sinh";
            this.col_birth_day.Name = "col_birth_day";
            this.col_birth_day.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_birth_day.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_birth_day.Width = 200;
            // 
            // col_start_day
            // 
            this.col_start_day.DataPropertyName = "Date_Start";
            this.col_start_day.HeaderText = "Ngày bắt đầu";
            this.col_start_day.Name = "col_start_day";
            this.col_start_day.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_start_day.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_start_day.Width = 200;
            // 
            // col_salary
            // 
            this.col_salary.DataPropertyName = "Salary";
            this.col_salary.HeaderText = "Lương";
            this.col_salary.Name = "col_salary";
            this.col_salary.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_salary.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_salary.Width = 200;
            // 
            // col_stt
            // 
            this.col_stt.DataPropertyName = "Is_Delete";
            this.col_stt.HeaderText = "Trạng Thái";
            this.col_stt.Name = "col_stt";
            this.col_stt.Width = 200;
            // 
            // Frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 608);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_stDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_bDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_bDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_stDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id_Em;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name_Em;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_birth_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_start_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stt;
    }
}