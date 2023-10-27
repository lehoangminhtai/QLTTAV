using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private Size originalParentSize;

        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            // Lưu trạng thái kích thước gốc của form cha
            originalParentSize = this.Size;

            // Thay đổi kích thước của form cha để vừa với form con
            //this.Size = new Size(childForm.Size.Width, childForm.Size.Height);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LopHoc());
            label_nameButton.Text = btnLopHoc.Text;
        }
        private void RestoreParentSize()
        {
            this.Size = originalParentSize;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            //RestoreParentSize();
        }

        private void btnKetQuaTT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KetQua());
            label_nameButton.Text = btnKetQuaTT.Text;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
