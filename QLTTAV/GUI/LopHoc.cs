using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LopHoc : Form
    {
        public LopHoc()
        {
            InitializeComponent();
        }

        

        private void lvLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLopHoc.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem liv = lvLopHoc.SelectedItems[0];
            
            string MaLH = liv.SubItems[0].Text;
            
            HienThiLopHocTheoMa(MaLH);
            HienThiHocVienTheoMaLop(MaLH);
        }

        private void HienThiHocVienTheoMaLop(string MaLH)
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HocVienTheoMaLop";
            cmd.Connection = conn;

            cmd.Parameters.Add("@MaLH",SqlDbType.NChar).Value = MaLH;
            SqlDataReader reader = cmd.ExecuteReader();
            lvHocVien.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(1));
                item.SubItems.Add(reader.GetString(2));
                DateTime ngaySinh = reader.GetDateTime(3);
                item.SubItems.Add(ngaySinh.ToString("dd-MM-yyyy"));
                item.SubItems.Add(reader.GetString(4));
                item.SubItems.Add(reader.GetString(5));
                item.SubItems.Add(reader.GetString(6));
                lvHocVien.Items.Add(item);
            }

            reader.Close();
        }

        private void HienThiLopHocTheoMa(string MaLH)
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThongTinLopHocTheoMa";
            cmd.Connection = conn;

            SqlParameter parama = new SqlParameter("@MaLH", SqlDbType.VarChar);
            parama.Value = MaLH;
            cmd.Parameters.Add(parama);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMaLH.Text = reader.GetString(0);
                txtTenLH.Text = reader.GetString(1);
                txtTenPhong.Text = reader.GetString(2);
                txtHocPhi.Text = reader.GetDouble(3) + "";
                txtSoBuoiHoc.Text = reader.GetInt32(4) + "";
                txtSoHV.Text = reader.GetInt32(5) + "";
                txtTrangThai.Text = reader.GetString(6);
            }
            reader.Close();
        }

        private void LopHoc_Load(object sender, EventArgs e)
        {
            ThongTinLopHoc();
            
        }

        private void ThongTinLopHoc()
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from v_LopHoc", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            lvLopHoc.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(2));
                item.SubItems.Add(reader.GetDouble(3) + "");
                item.SubItems.Add(reader.GetInt32(4) + "");
                item.SubItems.Add(reader.GetInt32(5) + "");
                item.SubItems.Add(reader.GetString(6));
                lvLopHoc.Items.Add(item);
            }

            reader.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemLopHoc";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaLH",SqlDbType.NChar).Value = txtMaLH.Text;
                cmd.Parameters.Add("@TenLH",SqlDbType.NVarChar).Value = txtTenLH.Text;
                cmd.Parameters.Add("@TenPhongHoc", SqlDbType.NVarChar).Value = txtTenPhong.Text;
                cmd.Parameters.Add("@HocPhi",SqlDbType.Float).Value = txtHocPhi.Text;
                cmd.Parameters.Add("@SoBuoihoc", SqlDbType.Int).Value = txtSoBuoiHoc.Text;
                cmd.Parameters.Add("@SoLuongHV", SqlDbType.Int).Value = txtSoHV.Text;
                

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    ThongTinLopHoc();
                    MessageBox.Show("Thêm lớp học thành công!");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Thêm lớp học thất bại!");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTenLH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaThongTinLopHoc";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaLH", SqlDbType.NChar).Value = txtMaLH.Text;
                cmd.Parameters.Add("@TenLH", SqlDbType.NVarChar).Value = txtTenLH.Text;
                cmd.Parameters.Add("@TenPhongHoc", SqlDbType.NVarChar).Value = txtTenPhong.Text;
                cmd.Parameters.Add("@HocPhi", SqlDbType.Float).Value = txtHocPhi.Text;
                cmd.Parameters.Add("@SoBuoihoc", SqlDbType.Int).Value = txtSoBuoiHoc.Text;
                cmd.Parameters.Add("@SoLuongHV", SqlDbType.Int).Value = txtSoHV.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    ThongTinLopHoc();
                    string maLH = txtMaLH.Text.Trim();
                    UpdateTrangThai(maLH);
                    MessageBox.Show("Sửa lớp học thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateTrangThai(string maLH)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateTrangThai";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaLH", SqlDbType.NChar).Value = txtMaLH.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtTrangThai.Text = reader.GetString(0);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaLopHoc";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaLH", SqlDbType.NChar).Value = txtMaLH.Text;

                int n = cmd.ExecuteNonQuery();

                if (n > 0)
                {
                    ThongTinLopHoc();
                    txtMaLH.Clear();
                    txtTenLH.Clear();
                    txtTenPhong.Clear();
                    txtHocPhi.Clear();
                    txtSoBuoiHoc.Clear();
                    txtSoHV.Clear();
                    txtTrangThai.Clear();
                    MessageBox.Show("Xoá lớp học thành công!");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Xoá lớp học thất bại!");
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
