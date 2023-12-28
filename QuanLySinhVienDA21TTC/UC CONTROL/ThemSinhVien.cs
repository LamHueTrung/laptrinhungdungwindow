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
    public partial class ThemSinhVien : UserControl
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangsinhvien = new DataTable();
        public ThemSinhVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text != "")
            {
                string query = "insert into tblSinhVien (masinhvien, tensinhvien, ngaysinh, lop, sodienthoai, email) values ('" + txtMSSV.Text + "', N'" + txtTenSinhVien.Text + "', '" + txtNgaySinh.Text + "', '" + txtLop.Text + "', " + txtSoDienThoai.Text + ", '" + txtEmail.Text + "')";
                bangsinhvien = ketnoi.DocDuLieu(query);
                bodocghi = ketnoi.docghi;
                MessageBox.Show("Thêm sinh viên thành công");
            }
            else
            {
                MessageBox.Show("Không bỏ trống mã sinh viên");
            }
        }
    }
}
