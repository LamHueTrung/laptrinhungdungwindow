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

namespace QuanLySinhVienDA21TTC.UC_CONTROL
{
    public partial class CapNhatSinhVien : UserControl
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangsinhvien = new DataTable();
        int donghh = 0;
        string masinhvien = "";
        public CapNhatSinhVien(string masinhvien)
        {
            this.masinhvien = masinhvien;
            InitializeComponent();
        }
        void LoadSinhVien()
        {
            string query = "Select * from tblSinhVien where masinhvien = '" + masinhvien + "'";
            bangsinhvien = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            if (bangsinhvien.Rows.Count > 0)
            {
                txtMSSV.Enabled = false;
                txtMSSV.Text = bangsinhvien.Rows[0]["masinhvien"].ToString();
                txtTenSinhVien.Text = bangsinhvien.Rows[0]["tensinhvien"].ToString();
                txtNgaySinh.Text = bangsinhvien.Rows[0]["ngaysinh"].ToString();
                txtLop.Text = bangsinhvien.Rows[0]["lop"].ToString();
                txtSoDienThoai.Text = bangsinhvien.Rows[0]["sodienthoai"].ToString();
                txtEmail.Text = bangsinhvien.Rows[0]["email"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên với mã sinh viên này.");
            }
        }
        private void CapNhatSinhVien_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "update tblSinhVien set tensinhvien = N'" + txtTenSinhVien.Text + "', ngaysinh = '" + txtNgaySinh.Text + "', lop = '" + txtLop.Text + "', sodienthoai = " + txtSoDienThoai.Text + ", email = '" + txtEmail.Text + "' where masinhvien = '" + txtMSSV.Text + "'";
            bangsinhvien = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            MessageBox.Show("Cập nhật thành công");
            this.Hide();
        }
    }
}
