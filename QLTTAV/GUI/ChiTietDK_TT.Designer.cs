namespace GUI
{
    partial class ChiTietDK_TT
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
            this.livChiTietDK_TT = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.txtNgayDK = new System.Windows.Forms.TextBox();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.btnThemChiTietDK_TT = new System.Windows.Forms.Button();
            this.btnSuaChiTietDK_TT = new System.Windows.Forms.Button();
            this.btnXoaChiTietDK_TT = new System.Windows.Forms.Button();
            this.MaHV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayDK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // livChiTietDK_TT
            // 
            this.livChiTietDK_TT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaHV,
            this.MaTT,
            this.NgayDK});
            this.livChiTietDK_TT.FullRowSelect = true;
            this.livChiTietDK_TT.GridLines = true;
            this.livChiTietDK_TT.HideSelection = false;
            this.livChiTietDK_TT.Location = new System.Drawing.Point(15, 13);
            this.livChiTietDK_TT.Name = "livChiTietDK_TT";
            this.livChiTietDK_TT.Size = new System.Drawing.Size(707, 659);
            this.livChiTietDK_TT.TabIndex = 0;
            this.livChiTietDK_TT.UseCompatibleStateImageBehavior = false;
            this.livChiTietDK_TT.View = System.Windows.Forms.View.Details;
            this.livChiTietDK_TT.SelectedIndexChanged += new System.EventHandler(this.livChiTietDK_TT_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(740, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã TT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(740, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã HV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(740, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày ĐK";
            // 
            // txtMaHV
            // 
            this.txtMaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHV.Location = new System.Drawing.Point(845, 35);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(288, 30);
            this.txtMaHV.TabIndex = 2;
            // 
            // txtNgayDK
            // 
            this.txtNgayDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayDK.Location = new System.Drawing.Point(845, 157);
            this.txtNgayDK.Name = "txtNgayDK";
            this.txtNgayDK.Size = new System.Drawing.Size(288, 30);
            this.txtNgayDK.TabIndex = 2;
            // 
            // txtMaTT
            // 
            this.txtMaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTT.Location = new System.Drawing.Point(845, 95);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(288, 30);
            this.txtMaTT.TabIndex = 2;
            // 
            // btnThemChiTietDK_TT
            // 
            this.btnThemChiTietDK_TT.Location = new System.Drawing.Point(857, 251);
            this.btnThemChiTietDK_TT.Name = "btnThemChiTietDK_TT";
            this.btnThemChiTietDK_TT.Size = new System.Drawing.Size(143, 43);
            this.btnThemChiTietDK_TT.TabIndex = 3;
            this.btnThemChiTietDK_TT.Text = "Thêm";
            this.btnThemChiTietDK_TT.UseVisualStyleBackColor = true;
            this.btnThemChiTietDK_TT.Click += new System.EventHandler(this.btnThemChiTietDK_TT_Click);
            // 
            // btnSuaChiTietDK_TT
            // 
            this.btnSuaChiTietDK_TT.Location = new System.Drawing.Point(857, 332);
            this.btnSuaChiTietDK_TT.Name = "btnSuaChiTietDK_TT";
            this.btnSuaChiTietDK_TT.Size = new System.Drawing.Size(143, 43);
            this.btnSuaChiTietDK_TT.TabIndex = 4;
            this.btnSuaChiTietDK_TT.Text = "Sửa";
            this.btnSuaChiTietDK_TT.UseVisualStyleBackColor = true;
            this.btnSuaChiTietDK_TT.Click += new System.EventHandler(this.btnSuaChiTietDK_TT_Click);
            // 
            // btnXoaChiTietDK_TT
            // 
            this.btnXoaChiTietDK_TT.Location = new System.Drawing.Point(857, 413);
            this.btnXoaChiTietDK_TT.Name = "btnXoaChiTietDK_TT";
            this.btnXoaChiTietDK_TT.Size = new System.Drawing.Size(143, 43);
            this.btnXoaChiTietDK_TT.TabIndex = 5;
            this.btnXoaChiTietDK_TT.Text = "Xoá";
            this.btnXoaChiTietDK_TT.UseVisualStyleBackColor = true;
            this.btnXoaChiTietDK_TT.Click += new System.EventHandler(this.btnXoaChiTietDK_TT_Click);
            // 
            // MaHV
            // 
            this.MaHV.Text = "Mã HV";
            this.MaHV.Width = 80;
            // 
            // MaTT
            // 
            this.MaTT.Text = "Mã TT";
            this.MaTT.Width = 80;
            // 
            // NgayDK
            // 
            this.NgayDK.Text = "Ngày Đăng Kí";
            this.NgayDK.Width = 130;
            // 
            // ChiTietDK_TT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 692);
            this.Controls.Add(this.btnXoaChiTietDK_TT);
            this.Controls.Add(this.btnSuaChiTietDK_TT);
            this.Controls.Add(this.btnThemChiTietDK_TT);
            this.Controls.Add(this.txtMaTT);
            this.Controls.Add(this.txtNgayDK);
            this.Controls.Add(this.txtMaHV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.livChiTietDK_TT);
            this.Name = "ChiTietDK_TT";
            this.Text = "ChiTietDK_TT";
            this.Load += new System.EventHandler(this.ChiTietDK_TT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView livChiTietDK_TT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.TextBox txtNgayDK;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.Button btnThemChiTietDK_TT;
        private System.Windows.Forms.Button btnSuaChiTietDK_TT;
        private System.Windows.Forms.Button btnXoaChiTietDK_TT;
        private System.Windows.Forms.ColumnHeader MaHV;
        private System.Windows.Forms.ColumnHeader MaTT;
        private System.Windows.Forms.ColumnHeader NgayDK;
    }
}