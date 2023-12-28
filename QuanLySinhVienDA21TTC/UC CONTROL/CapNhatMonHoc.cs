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
    public partial class CapNhatMonHoc : UserControl
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangmonhoc = new DataTable();
        string mamonhoc = "";
        public CapNhatMonHoc(string mamonhoc)
        {
            this.mamonhoc = mamonhoc;
            InitializeComponent();
        }
        void LoadGiaoVien()
        {
            string query = "select * from tblGiaoVien";
            cbmGiaoVien.DataSource = ketnoi.DocDuLieu(query);
            cbmGiaoVien.DisplayMember = "tengiaovien";
            cbmGiaoVien.ValueMember = "magiaovien";
        }
        void LoadMonHoc()
        {
            string query = "Select * from tblMonHoc where mamonhoc = '" + mamonhoc + "'";
            bangmonhoc = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            if (bangmonhoc.Rows.Count > 0)
            {
                txtMaMonHoc.Enabled = false;
                txtMaMonHoc.Text = bangmonhoc.Rows[0]["mamonhoc"].ToString();
                txtTenMonHoc.Text = bangmonhoc.Rows[0]["tenmonhoc"].ToString();
                txtSoTinChi.Text = bangmonhoc.Rows[0]["sotinchi"].ToString();
                txtHocKy.Text = bangmonhoc.Rows[0]["hocky"].ToString();
                LoadGiaoVien();
                cbmGiaoVien.SelectedValue = bangmonhoc.Rows[0]["magiaovien"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy giáo viên với mã giáo viên này.");
            }
        }
        private void CapNhatMonHoc_Load(object sender, EventArgs e)
        {
            LoadMonHoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "update tblMonHoc set tenmonhoc = N'" + txtTenMonHoc.Text + "', sotinchi = " + txtSoTinChi.Text + ", hocky = '" + txtHocKy.Text + "', magiaovien = '" + cbmGiaoVien.SelectedValue + "' where mamonhoc = '" + txtMaMonHoc.Text + "'";
            bangmonhoc = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            MessageBox.Show("Cập nhật thành công");
            this.Hide();
        }
    }
}
