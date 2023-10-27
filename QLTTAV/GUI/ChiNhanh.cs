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
using DTO;
using DAL;
using System.Globalization;

namespace GUI
{
    public partial class ChiNhanh : Form
    {
        public ChiNhanh()
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
                cmd.CommandText = "ThemChiNhanh";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaCN", SqlDbType.NChar).Value = txtMaCN.Text;
                cmd.Parameters.Add("@TenCN", SqlDbType.NVarChar).Value = txtTenCN.Text;
                cmd.Parameters.Add("@DiaChiCN", SqlDbType.NVarChar).Value = txtDiaChi.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    ThongTinChiNhanh();
                    MessageBox.Show("Thêm chi nhánh thành công!");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
                
        }

        private void lvChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvChiNhanh.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem liv = lvChiNhanh.SelectedItems[0];
            string MaCN = liv.SubItems[0].Text;
            HienThiChiNhanhTheoMa(MaCN);
        }

        private void HienThiChiNhanhTheoMa(string MaCN)
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThongTinChiNhanhTheoMa";
            cmd.Connection = conn;
            SqlParameter parama = new SqlParameter("@MaCN", SqlDbType.VarChar);
            parama.Value = MaCN;
            cmd.Parameters.Add(parama);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtMaCN.Text = reader.GetString(0);
                txtTenCN.Text = reader.GetString(1);
                txtDiaChi.Text = reader.GetString(2);
            }
            reader.Close();
        }

        private void ChiNhanh_Load(object sender, EventArgs e)
        {
            ThongTinChiNhanh();
        }

        private void ThongTinChiNhanh()
        {
            SqlConnection conn = SQLConnectionData.Connect();
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from v_ChiNhanh", conn);

            SqlDataReader reader = cmd.ExecuteReader();
            lvChiNhanh.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(0));
                item.SubItems.Add(reader.GetString(1));
                item.SubItems.Add(reader.GetString(2));
                lvChiNhanh.Items.Add(item);
            }

            reader.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaThongTinChiNhanh";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaCN", SqlDbType.NChar).Value = txtMaCN.Text;
                cmd.Parameters.Add("@TenCN", SqlDbType.NVarChar).Value = txtTenCN.Text;
                cmd.Parameters.Add("@DiaChiCN", SqlDbType.NVarChar).Value = txtDiaChi.Text;

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    ThongTinChiNhanh();
                    MessageBox.Show("Sửa chi nhánh thành công!");
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = SQLConnectionData.Connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaChiNhanh";
                cmd.Connection = conn;

                cmd.Parameters.Add("@MaCN", SqlDbType.NChar).Value = txtMaCN.Text;

                int n = cmd.ExecuteNonQuery();

                if (n > 0)
                {
                    ThongTinChiNhanh();
                    txtMaCN.Clear();
                    txtTenCN.Clear();
                    txtDiaChi.Clear();
                    MessageBox.Show("Xoá chi nhánh thành công!");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Xoá chi nhánh thất bại!");
                    conn.Close();
                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
