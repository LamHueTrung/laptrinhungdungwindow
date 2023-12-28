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

    public partial class frmThemGiaoVien : Form
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangsinhvien = new DataTable();
        public frmThemGiaoVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaGiaoVien.Text != "")
            {
                string query = "insert into tblGiaoVien (magiaovien, tengiaovien, chuyennganh, sodienthoai, email) values ('" + txtMaGiaoVien.Text + "', N'" + txtTenGiaoVien.Text + "', N'" + txtChuyenNganh.Text + "', " + txtSoDienThoai.Text + ", '" + txtEmail.Text + "')";
                bangsinhvien = ketnoi.DocDuLieu(query);
                bodocghi = ketnoi.docghi;
                MessageBox.Show("Thêm giáo viên thành công");
                this.Hide();
                frmGiaoVien formGiaoVien = new frmGiaoVien();
                formGiaoVien.ShowDialog();
            } else
            {
                MessageBox.Show("Không bỏ trống mã giáo viên");
            }
        }
    }
}
