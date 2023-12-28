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
    public partial class frmThemMonHoc : Form
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangmonhoc = new DataTable();
        public frmThemMonHoc()
        {
            InitializeComponent();
        }
        void LoadMonHoc()
        {
            string query = "select * from tblGiaoVien";
            cbmGiaoVien.DataSource = ketnoi.DocDuLieu(query);
            cbmGiaoVien.DisplayMember = "tengiaovien";
            cbmGiaoVien.ValueMember = "magiaovien";
        }

        private void frmThemMonHoc_Load(object sender, EventArgs e)
        {
            LoadMonHoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaMonHoc.Text != "")
            {
                string query = "insert into tblMonHoc (mamonhoc, tenmonhoc, sotinchi, hocky, magiaovien) values ('" + txtMaMonHoc.Text + "', N'" + txtTenMonHoc.Text + "', " + txtSoTinChi.Text + ", '" + txtHocKy.Text + "', '" + cbmGiaoVien.SelectedValue + "')";
                bangmonhoc = ketnoi.DocDuLieu(query);
                bodocghi = ketnoi.docghi;
                MessageBox.Show("Thêm môn học thành công");
                this.Hide();
                frmMonHoc formMonHoc = new frmMonHoc();
                formMonHoc.ShowDialog();
            } else
            {
                MessageBox.Show("Không bỏ trống mã môn học");
            }
        }
    }
}
