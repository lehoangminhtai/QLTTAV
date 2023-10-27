namespace GUI
{
    partial class KetQua
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
            this.lvKetQua = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoaKQ = new System.Windows.Forms.Button();
            this.btnSuaKQ = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoCauDocDung = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoCauNgheDung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnTinhDiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvKetQua
            // 
            this.lvKetQua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvKetQua.FullRowSelect = true;
            this.lvKetQua.GridLines = true;
            this.lvKetQua.HideSelection = false;
            this.lvKetQua.Location = new System.Drawing.Point(12, 12);
            this.lvKetQua.Name = "lvKetQua";
            this.lvKetQua.Size = new System.Drawing.Size(679, 519);
            this.lvKetQua.TabIndex = 0;
            this.lvKetQua.UseCompatibleStateImageBehavior = false;
            this.lvKetQua.View = System.Windows.Forms.View.Details;
            this.lvKetQua.SelectedIndexChanged += new System.EventHandler(this.lvKetQua_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã học viên";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã thi thử";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số câu đọc đúng";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số câu nghe đúng";
            this.columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Điểm";
            // 
            // btnXoaKQ
            // 
            this.btnXoaKQ.Location = new System.Drawing.Point(761, 464);
            this.btnXoaKQ.Name = "btnXoaKQ";
            this.btnXoaKQ.Size = new System.Drawing.Size(194, 42);
            this.btnXoaKQ.TabIndex = 20;
            this.btnXoaKQ.Text = "Xoá";
            this.btnXoaKQ.UseVisualStyleBackColor = true;
            this.btnXoaKQ.Click += new System.EventHandler(this.btnXoaKQ_Click);
            // 
            // btnSuaKQ
            // 
            this.btnSuaKQ.Location = new System.Drawing.Point(761, 416);
            this.btnSuaKQ.Name = "btnSuaKQ";
            this.btnSuaKQ.Size = new System.Drawing.Size(194, 42);
            this.btnSuaKQ.TabIndex = 21;
            this.btnSuaKQ.Text = "Sửa";
            this.btnSuaKQ.UseVisualStyleBackColor = true;
            this.btnSuaKQ.Click += new System.EventHandler(this.btnSuaKQ_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(761, 368);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(194, 42);
            this.btnThem.TabIndex = 22;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaTT
            // 
            this.txtMaTT.Location = new System.Drawing.Point(926, 108);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(208, 26);
            this.txtMaTT.TabIndex = 18;
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(926, 38);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(208, 26);
            this.txtMaHV.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(757, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số câu đọc đúng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(757, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã thi thử";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(757, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã học viên";
            // 
            // txtSoCauDocDung
            // 
            this.txtSoCauDocDung.Location = new System.Drawing.Point(926, 172);
            this.txtSoCauDocDung.Name = "txtSoCauDocDung";
            this.txtSoCauDocDung.Size = new System.Drawing.Size(208, 26);
            this.txtSoCauDocDung.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(757, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số câu nghe đúng";
            // 
            // txtSoCauNgheDung
            // 
            this.txtSoCauNgheDung.Location = new System.Drawing.Point(926, 244);
            this.txtSoCauNgheDung.Name = "txtSoCauNgheDung";
            this.txtSoCauNgheDung.Size = new System.Drawing.Size(208, 26);
            this.txtSoCauNgheDung.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(757, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Điểm";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(926, 308);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(208, 26);
            this.txtDiem.TabIndex = 18;
            // 
            // btnTinhDiem
            // 
            this.btnTinhDiem.Location = new System.Drawing.Point(1015, 416);
            this.btnTinhDiem.Name = "btnTinhDiem";
            this.btnTinhDiem.Size = new System.Drawing.Size(150, 42);
            this.btnTinhDiem.TabIndex = 23;
            this.btnTinhDiem.Text = "Tính điểm";
            this.btnTinhDiem.UseVisualStyleBackColor = true;
            this.btnTinhDiem.Click += new System.EventHandler(this.btnTinhDiem_Click);
            // 
            // KetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 591);
            this.Controls.Add(this.btnTinhDiem);
            this.Controls.Add(this.btnXoaKQ);
            this.Controls.Add(this.btnSuaKQ);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtSoCauNgheDung);
            this.Controls.Add(this.txtSoCauDocDung);
            this.Controls.Add(this.txtMaTT);
            this.Controls.Add(this.txtMaHV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvKetQua);
            this.Name = "KetQua";
            this.Text = "KetQua";
            this.Load += new System.EventHandler(this.KetQua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvKetQua;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnXoaKQ;
        private System.Windows.Forms.Button btnSuaKQ;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoCauDocDung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoCauNgheDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnTinhDiem;
    }
}