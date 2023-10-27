namespace GUI
{
    partial class ThiThu
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
            this.livThiThu = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.txtPhongThi = new System.Windows.Forms.TextBox();
            this.txtNgayThi = new System.Windows.Forms.TextBox();
            this.txtGioThi = new System.Windows.Forms.TextBox();
            this.txtGioiHan = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnThemTT = new System.Windows.Forms.Button();
            this.btnXoaTT = new System.Windows.Forms.Button();
            this.btnSuaTT = new System.Windows.Forms.Button();
            this.MaTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhongThi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayThi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioThi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GioiHan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // livThiThu
            // 
            this.livThiThu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaTT,
            this.PhongThi,
            this.NgayThi,
            this.GioThi,
            this.GioiHan,
            this.MaNV});
            this.livThiThu.FullRowSelect = true;
            this.livThiThu.GridLines = true;
            this.livThiThu.HideSelection = false;
            this.livThiThu.Location = new System.Drawing.Point(12, 12);
            this.livThiThu.Name = "livThiThu";
            this.livThiThu.Size = new System.Drawing.Size(820, 678);
            this.livThiThu.TabIndex = 0;
            this.livThiThu.UseCompatibleStateImageBehavior = false;
            this.livThiThu.View = System.Windows.Forms.View.Details;
            this.livThiThu.SelectedIndexChanged += new System.EventHandler(this.livThiThu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(852, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã TT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(852, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng Thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(852, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(852, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giờ Thi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(852, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giới Hạn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(852, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã NV";
            // 
            // txtMaTT
            // 
            this.txtMaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTT.Location = new System.Drawing.Point(986, 24);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(331, 30);
            this.txtMaTT.TabIndex = 2;
            // 
            // txtPhongThi
            // 
            this.txtPhongThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhongThi.Location = new System.Drawing.Point(986, 74);
            this.txtPhongThi.Name = "txtPhongThi";
            this.txtPhongThi.Size = new System.Drawing.Size(331, 30);
            this.txtPhongThi.TabIndex = 2;
            // 
            // txtNgayThi
            // 
            this.txtNgayThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayThi.Location = new System.Drawing.Point(986, 124);
            this.txtNgayThi.Name = "txtNgayThi";
            this.txtNgayThi.Size = new System.Drawing.Size(331, 30);
            this.txtNgayThi.TabIndex = 2;
            // 
            // txtGioThi
            // 
            this.txtGioThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioThi.Location = new System.Drawing.Point(986, 174);
            this.txtGioThi.Name = "txtGioThi";
            this.txtGioThi.Size = new System.Drawing.Size(331, 30);
            this.txtGioThi.TabIndex = 2;
            // 
            // txtGioiHan
            // 
            this.txtGioiHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioiHan.Location = new System.Drawing.Point(986, 224);
            this.txtGioiHan.Name = "txtGioiHan";
            this.txtGioiHan.Size = new System.Drawing.Size(331, 30);
            this.txtGioiHan.TabIndex = 2;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(986, 274);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(331, 30);
            this.txtMaNV.TabIndex = 2;
            // 
            // btnThemTT
            // 
            this.btnThemTT.Location = new System.Drawing.Point(994, 353);
            this.btnThemTT.Name = "btnThemTT";
            this.btnThemTT.Size = new System.Drawing.Size(147, 49);
            this.btnThemTT.TabIndex = 3;
            this.btnThemTT.Text = "Thêm";
            this.btnThemTT.UseVisualStyleBackColor = true;
            this.btnThemTT.Click += new System.EventHandler(this.btnThemTT_Click);
            // 
            // btnXoaTT
            // 
            this.btnXoaTT.Location = new System.Drawing.Point(994, 513);
            this.btnXoaTT.Name = "btnXoaTT";
            this.btnXoaTT.Size = new System.Drawing.Size(147, 49);
            this.btnXoaTT.TabIndex = 3;
            this.btnXoaTT.Text = "Xoá";
            this.btnXoaTT.UseVisualStyleBackColor = true;
            this.btnXoaTT.Click += new System.EventHandler(this.btnXoaTT_Click);
            // 
            // btnSuaTT
            // 
            this.btnSuaTT.Location = new System.Drawing.Point(994, 433);
            this.btnSuaTT.Name = "btnSuaTT";
            this.btnSuaTT.Size = new System.Drawing.Size(147, 49);
            this.btnSuaTT.TabIndex = 3;
            this.btnSuaTT.Text = "Sửa";
            this.btnSuaTT.UseVisualStyleBackColor = true;
            this.btnSuaTT.Click += new System.EventHandler(this.btnSuaTT_Click);
            // 
            // MaTT
            // 
            this.MaTT.Text = "Mã TT";
            this.MaTT.Width = 80;
            // 
            // PhongThi
            // 
            this.PhongThi.Text = "Phòng Thi";
            this.PhongThi.Width = 80;
            // 
            // NgayThi
            // 
            this.NgayThi.Text = "Ngày Thi";
            this.NgayThi.Width = 80;
            // 
            // GioThi
            // 
            this.GioThi.Text = "Giờ Thi";
            this.GioThi.Width = 80;
            // 
            // GioiHan
            // 
            this.GioiHan.Text = "Giới Hạn";
            this.GioiHan.Width = 80;
            // 
            // MaNV
            // 
            this.MaNV.Text = "Mã NV";
            this.MaNV.Width = 80;
            // 
            // ThiThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 706);
            this.Controls.Add(this.btnSuaTT);
            this.Controls.Add(this.btnXoaTT);
            this.Controls.Add(this.btnThemTT);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtGioiHan);
            this.Controls.Add(this.txtGioThi);
            this.Controls.Add(this.txtNgayThi);
            this.Controls.Add(this.txtPhongThi);
            this.Controls.Add(this.txtMaTT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.livThiThu);
            this.Name = "ThiThu";
            this.Text = "ThiThu";
            this.Load += new System.EventHandler(this.ThiThu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView livThiThu;
        private System.Windows.Forms.ColumnHeader MaTT;
        private System.Windows.Forms.ColumnHeader PhongThi;
        private System.Windows.Forms.ColumnHeader NgayThi;
        private System.Windows.Forms.ColumnHeader GioThi;
        private System.Windows.Forms.ColumnHeader GioiHan;
        private System.Windows.Forms.ColumnHeader MaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.TextBox txtPhongThi;
        private System.Windows.Forms.TextBox txtNgayThi;
        private System.Windows.Forms.TextBox txtGioThi;
        private System.Windows.Forms.TextBox txtGioiHan;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnThemTT;
        private System.Windows.Forms.Button btnXoaTT;
        private System.Windows.Forms.Button btnSuaTT;
    }
}