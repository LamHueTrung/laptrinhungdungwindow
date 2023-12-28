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

namespace QuanLySinhVienDA21TTC
{
    public partial class frmThemSinhVien : Form
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangsinhvien = new DataTable();
        public frmThemSinhVien()
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
                this.Hide();
                frmDSSV formSinhVien = new frmDSSV();
                formSinhVien.ShowDialog();
            } else
            {
                MessageBox.Show("Không bỏ trống mã sinh viên");
            }
        }
    }
}
