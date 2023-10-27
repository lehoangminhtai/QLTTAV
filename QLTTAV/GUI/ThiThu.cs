using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThiThu : Form
    {
        public ThiThu()
        {
            InitializeComponent();
        }

        private void ThiThu_Load(object sender, EventArgs e)
        {
            HienThiThongTinThiThu();
        }

        private void HienThiThongTinThiThu()
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select * From ThongTinThiThu", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                livThiThu.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader.GetString(0));
                    lvi.SubItems.Add(reader.GetString(1));
                    DateTime NgayThi = reader.GetDateTime(2);
                    lvi.SubItems.Add(NgayThi.ToString("dd-MM-yyyy"));
                    
                    TimeSpan GioThi = reader.GetTimeSpan(3);
                    lvi.SubItems.Add(GioThi.ToString());
                    
                    int GioiHan = reader.GetInt32(4);
                    lvi.SubItems.Add(GioiHan+"");
                    lvi.SubItems.Add(reader.GetString(5));
                    livThiThu.Items.Add(lvi);
                }
                reader.Close();

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void livThiThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(livThiThu.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem lvi = livThiThu.SelectedItems[0];
            String MaTT = lvi.SubItems[0].Text;
            HienThiTheoMaTT(MaTT);
        }

        private void HienThiTheoMaTT(string MaTT)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand(MaTT, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "HienThiTheoMaTT";
                cmd.Connection = conn;

                SqlParameter para = new SqlParameter("@MaTT", SqlDbType.NChar);
                para.Value = MaTT;
                cmd.Parameters.Add(para);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtMaTT.Text = reader.GetString(0);
                    txtPhongThi.Text = reader.GetString(1);
                    txtNgayThi.Text = reader.GetDateTime(2).ToString("dd-MM-yyyy");
                    txtGioThi.Text = reader.GetTimeSpan(3).ToString();
                    txtGioiHan.Text = reader.GetInt32(4) + "";
                    txtMaNV.Text = reader.GetString(5);
                }

                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemTT_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemThiThu";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaTT", SqlDbType.NChar).Value = txtMaTT.Text;
                cmd.Parameters.Add("@PhongThi", SqlDbType.NVarChar).Value = txtPhongThi.Text;

                DateTime ngayThi;
                if (DateTime.TryParseExact(txtNgayThi.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayThi))
                {
                    cmd.Parameters.Add("@NgayThi", SqlDbType.Date).Value = ngayThi;
                }
                else
                {
                    MessageBox.Show("Ngày thi không hợp lệ.");
                    return;
                }
                
                cmd.Parameters.Add("@GioThi", SqlDbType.Time).Value = txtGioThi.Text;
                cmd.Parameters.Add("@GioiHan", SqlDbType.Int).Value = txtGioiHan.Text;
                cmd.Parameters.Add("@MaNV", SqlDbType.NChar).Value = txtMaNV.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    HienThiThongTinThiThu();
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CapNhatThiThu";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaTT", SqlDbType.NChar).Value = txtMaTT.Text;
                cmd.Parameters.Add("@PhongThi", SqlDbType.NVarChar).Value = txtPhongThi.Text;

                DateTime ngayThi;
                if (DateTime.TryParseExact(txtNgayThi.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayThi))
                {
                    cmd.Parameters.Add("@NgayThi", SqlDbType.Date).Value = ngayThi;
                }
                else
                {
                    MessageBox.Show("Ngày thi không hợp lệ.");
                    return;
                }
                cmd.Parameters.Add("@GioThi", SqlDbType.Time).Value = txtGioThi.Text;
                cmd.Parameters.Add("@GioiHan", SqlDbType.Int).Value = txtGioiHan.Text;
                cmd.Parameters.Add("@MaNV", SqlDbType.NChar).Value = txtMaNV.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    HienThiThongTinThiThu();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaTT_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaThiThu";
                cmd.Connection = conn;
                cmd.Parameters.Add("@MaTT", SqlDbType.NChar).Value = txtMaTT.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    HienThiThongTinThiThu();
                    txtMaTT.Clear();
                    txtPhongThi.Clear();
                    txtNgayThi.Clear();
                    txtGioThi.Clear();
                    txtGioiHan.Clear();
                    txtMaNV.Clear();
                    MessageBox.Show("Xoá thành công!");
                }
                else
                {
                    MessageBox.Show("Xoá thất bại!");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
