using QuanLySinhVienDA21TTC.UC_CONTROL;
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

namespace QuanLySinhVienDA21TTC
{
    public partial class DangNhap : Form
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangsinhvien = new DataTable();
        DataTable banggiaovien = new DataTable();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtTenDangNhap.Text;
            string quyen = cbbQuyen.SelectedItem.ToString();
            if (quyen == "Quản Trị")
            {
                if (tendangnhap == "admin")
                {
                    txtTenDangNhap.Clear();
                    MessageBox.Show("Đăng nhập quản Trị");
                    Home home = new Home();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            else if (quyen == "Sinh Viên")
            {
                string query = "Select masinhvien from tblSinhVien where masinhvien = '"+ tendangnhap + "'";
                bangsinhvien = ketnoi.DocDuLieu(query);
                bodocghi = ketnoi.docghi;
                string masinhvien = "";
                if (bangsinhvien.Rows.Count > 0)
                {
                     masinhvien = bangsinhvien.Rows[0]["masinhvien"].ToString();
                }
                if (tendangnhap == masinhvien)
                {
                    txtTenDangNhap.Clear();
                    MessageBox.Show("Đăng nhập thành công");
                    HomeSinhVien home = new HomeSinhVien(masinhvien);
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            else if (quyen == "Giáo Viên")
            {
                string query = "Select magiaovien from tblGiaoVien where magiaovien = '" + tendangnhap + "'";
                banggiaovien = ketnoi.DocDuLieu(query);
                bodocghi = ketnoi.docghi;
                string magiaovien = "";
                magiaovien = banggiaovien.Rows[0]["magiaovien"].ToString();

                if (tendangnhap == magiaovien)
                {
                    txtTenDangNhap.Clear();
                    MessageBox.Show("Đăng nhập thành công");
                    HomeGiaoVien home = new HomeGiaoVien(magiaovien);
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            cbbQuyen.SelectedIndex = 0;
        }
    }
}
