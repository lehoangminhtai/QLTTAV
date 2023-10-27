namespace GUI
{
    partial class LopHoc
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
            this.lvLopHoc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtHocPhi = new System.Windows.Forms.TextBox();
            this.txtTenLH = new System.Windows.Forms.TextBox();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoBuoiHoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoHV = new System.Windows.Forms.TextBox();
            this.btnDsHV = new System.Windows.Forms.Button();
            this.lvHocVien = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvLopHoc
            // 
            this.lvLopHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvLopHoc.FullRowSelect = true;
            this.lvLopHoc.GridLines = true;
            this.lvLopHoc.HideSelection = false;
            this.lvLopHoc.Location = new System.Drawing.Point(12, 12);
            this.lvLopHoc.Name = "lvLopHoc";
            this.lvLopHoc.Size = new System.Drawing.Size(869, 302);
            this.lvLopHoc.TabIndex = 0;
            this.lvLopHoc.UseCompatibleStateImageBehavior = false;
            this.lvLopHoc.View = System.Windows.Forms.View.Details;
            this.lvLopHoc.SelectedIndexChanged += new System.EventHandler(this.lvLopHoc_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã lớp học";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên lớp học";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên phòng học";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Học phí";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số buổi học";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số lượng học viên";
            this.columnHeader6.Width = 115;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Trạng thái";
            this.columnHeader7.Width = 135;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(896, 360);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(182, 44);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm lớp";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(896, 436);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(182, 44);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Thay đổi";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(896, 505);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(182, 44);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá lớp";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtHocPhi
            // 
            this.txtHocPhi.Location = new System.Drawing.Point(1023, 156);
            this.txtHocPhi.Name = "txtHocPhi";
            this.txtHocPhi.Size = new System.Drawing.Size(208, 26);
            this.txtHocPhi.TabIndex = 14;
            // 
            // txtTenLH
            // 
            this.txtTenLH.Location = new System.Drawing.Point(1023, 68);
            this.txtTenLH.Name = "txtTenLH";
            this.txtTenLH.Size = new System.Drawing.Size(208, 26);
            this.txtTenLH.TabIndex = 15;
            this.txtTenLH.TextChanged += new System.EventHandler(this.txtTenLH_TextChanged);
            // 
            // txtMaLH
            // 
            this.txtMaLH.Location = new System.Drawing.Point(1023, 23);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(208, 26);
            this.txtMaLH.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(887, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Học phí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(887, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên lớp";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(887, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(887, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Trạng thái";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(1023, 289);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(208, 26);
            this.txtTrangThai.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(887, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số buổi học";
            // 
            // txtSoBuoiHoc
            // 
            this.txtSoBuoiHoc.Location = new System.Drawing.Point(1023, 206);
            this.txtSoBuoiHoc.Name = "txtSoBuoiHoc";
            this.txtSoBuoiHoc.Size = new System.Drawing.Size(208, 26);
            this.txtSoBuoiHoc.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(887, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên phòng";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(1023, 114);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(208, 26);
            this.txtTenPhong.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(887, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số học viên";
            // 
            // txtSoHV
            // 
            this.txtSoHV.Location = new System.Drawing.Point(1023, 247);
            this.txtSoHV.Name = "txtSoHV";
            this.txtSoHV.Size = new System.Drawing.Size(208, 26);
            this.txtSoHV.TabIndex = 14;
            // 
            // btnDsHV
            // 
            this.btnDsHV.Location = new System.Drawing.Point(1097, 436);
            this.btnDsHV.Name = "btnDsHV";
            this.btnDsHV.Size = new System.Drawing.Size(134, 44);
            this.btnDsHV.TabIndex = 1;
            this.btnDsHV.Text = "DS Học Viên";
            this.btnDsHV.UseVisualStyleBackColor = true;
            // 
            // lvHocVien
            // 
            this.lvHocVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lvHocVien.GridLines = true;
            this.lvHocVien.Location = new System.Drawing.Point(12, 334);
            this.lvHocVien.Name = "lvHocVien";
            this.lvHocVien.Size = new System.Drawing.Size(869, 219);
            this.lvHocVien.TabIndex = 0;
            this.lvHocVien.UseCompatibleStateImageBehavior = false;
            this.lvHocVien.View = System.Windows.Forms.View.Details;
            this.lvHocVien.SelectedIndexChanged += new System.EventHandler(this.lvLopHoc_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã học viên";
            this.columnHeader8.Width = 70;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Họ tên ";
            this.columnHeader9.Width = 132;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ngày sinh";
            this.columnHeader10.Width = 105;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Giới tính";
            this.columnHeader11.Width = 75;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Số ĐT";
            this.columnHeader12.Width = 75;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Địa chỉ";
            this.columnHeader13.Width = 162;
            // 
            // LopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 565);
            this.Controls.Add(this.txtSoHV);
            this.Controls.Add(this.txtSoBuoiHoc);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.txtHocPhi);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtTenLH);
            this.Controls.Add(this.txtMaLH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDsHV);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lvHocVien);
            this.Controls.Add(this.lvLopHoc);
            this.Name = "LopHoc";
            this.Text = "Lớp học";
            this.Load += new System.EventHandler(this.LopHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLopHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtHocPhi;
        private System.Windows.Forms.TextBox txtTenLH;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoBuoiHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoHV;
        private System.Windows.Forms.Button btnDsHV;
        private System.Windows.Forms.ListView lvHocVien;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}