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
    public partial class CapNhatGiaoVien : UserControl
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable banggiaovien = new DataTable();
        int donghh = 0;
        string magiaovien = "";
        public CapNhatGiaoVien(string magiaovien)
        {
            this.magiaovien = magiaovien;
            InitializeComponent();
        }
        void LoadGiaoVien()
        {
            string query = "Select * from tblGiaoVien where magiaovien = '" + magiaovien + "'";
            banggiaovien = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            if (banggiaovien.Rows.Count > 0)
            {
                txtMaGiaoVien.Enabled = false;
                txtMaGiaoVien.Text = banggiaovien.Rows[0]["magiaovien"].ToString();
                txtTenGiaoVien.Text = banggiaovien.Rows[0]["tengiaovien"].ToString();
                txtChuyenNganh.Text = banggiaovien.Rows[0]["chuyennganh"].ToString();
                txtSoDienThoai.Text = banggiaovien.Rows[0]["sodienthoai"].ToString();
                txtEmail.Text = banggiaovien.Rows[0]["email"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy giáo viên với mã giáo viên này.");
            }
        }
        private void CapNhatGiaoVien_Load(object sender, EventArgs e)
        {
            LoadGiaoVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "update tblGiaoVien set tengiaovien = N'" + txtTenGiaoVien.Text + "', chuyennganh = N'" + txtChuyenNganh.Text + "', sodienthoai = " + txtSoDienThoai.Text + ", email = '" + txtEmail.Text + "' where magiaovien = '" + txtMaGiaoVien.Text + "'";
            banggiaovien = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            MessageBox.Show("Cập nhật thành công");
            this.Hide();
        }
    }
}
