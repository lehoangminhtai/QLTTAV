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
    public partial class KetQua : Form
    {
        public KetQua()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemKetQuaTT";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaHV", SqlDbType.NChar).Value = txtMaHV.Text;
                cmd.Parameters.Add("@MaTT", SqlDbType.NChar).Value = txtMaTT.Text;
                cmd.Parameters.Add("@SoCauNgheDung", SqlDbType.Int).Value = txtSoCauNgheDung.Text;
                cmd.Parameters.Add("@SoCauDocDung", SqlDbType.Int).Value = txtSoCauDocDung.Text;
                
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    KetQuaThiThu();
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaKQ_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaKetQuaTT";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaHV", SqlDbType.NChar).Value = txtMaHV.Text;
                cmd.Parameters.Add("@MaTT", SqlDbType.NChar).Value = txtMaTT.Text;
                cmd.Parameters.Add("@SoCauNgheDung", SqlDbType.Int).Value = txtSoCauNgheDung.Text;
                cmd.Parameters.Add("@SoCauDocDung", SqlDbType.Int).Value = txtSoCauDocDung.Text;
                cmd.Parameters.Add("@Diem", SqlDbType.Int).Value = txtDiem.Text;
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    KetQuaThiThu();
                    MessageBox.Show("Sửa thành công!");
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

        private void btnXoaKQ_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaKetQuaTT";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaHV", SqlDbType.NChar).Value = txtMaHV.Text;
                cmd.Parameters.Add("@MaTT", SqlDbType.NChar).Value = txtMaTT.Text;
               
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    KetQuaThiThu();
                    txtMaHV.Clear();
                    txtMaTT.Clear();
                    txtSoCauDocDung.Clear();
                    txtSoCauNgheDung.Clear();
                    txtDiem.Clear();
                    MessageBox.Show("Xoá thành công!");
                }
                else
                {
                    MessageBox.Show("Xoá thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KetQua_Load(object sender, EventArgs e)
        {
            KetQuaThiThu();
            
        }

        private void KetQuaThiThu()
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from v_KetQua", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            lvKetQua.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetInt32(2)+"");
                item.SubItems.Add(reader.GetInt32(3) + "");
                item.SubItems.Add(reader.GetInt32(4) + "");
                lvKetQua.Items.Add(item);
            }

            reader.Close();
        }

        private void lvKetQua_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKetQua.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem liv = lvKetQua.SelectedItems[0];
            string MaHV = liv.SubItems[0].Text;
            string MaTT = liv.SubItems[1].Text;
            HienThiKetQuaTTTheoMa(MaHV, MaTT);
        }

        private void HienThiKetQuaTTTheoMa(string MaHV, string MaTT)
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThongTinKetQuaTTTheoMa";
            cmd.Connection = conn;
            SqlParameter parama = new SqlParameter("@MaHV", SqlDbType.VarChar);
            SqlParameter parama1 = new SqlParameter("@MaTT", SqlDbType.VarChar);
            parama.Value = MaHV;
            parama1.Value = MaTT;
            cmd.Parameters.Add(parama);
            cmd.Parameters.Add(parama1);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMaHV.Text = reader.GetString(0);
                txtMaTT.Text = reader.GetString(1);
                txtSoCauNgheDung.Text = reader.GetInt32(2) + "";
                txtSoCauDocDung.Text = reader.GetInt32(3)+"";
                txtDiem.Text = reader.GetInt32(4) + "";
            }
            reader.Close();
        }

        private void btnTinhDiem_Click(object sender, EventArgs e)
        {
           /* ListViewItem liv = lvKetQua.SelectedItems[0];
            string MaHV = liv.SubItems[0].Text;
            string MaTT = liv.SubItems[1].Text;*/
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select dbo.TinhDiemTT(@SoCauNgheDung,@SoCauDocDung)";
                cmd.Connection = conn;

                cmd.Parameters.Add("@SoCauNgheDung", SqlDbType.Int).Value = txtSoCauNgheDung.Text;
                cmd.Parameters.Add("@SoCauDocDung", SqlDbType.Int).Value = txtSoCauDocDung.Text;

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    int diem = (int)result;
                    txtDiem.Text = diem.ToString();
                    
                    conn.Close();
                }
                else
                {
                  
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
