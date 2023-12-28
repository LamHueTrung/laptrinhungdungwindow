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
    public partial class DanhSachMonGV : UserControl
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangmonhoc = new DataTable();
        int donghh = 0;
        private string _magiaovien = "";
        public DanhSachMonGV()
        {
            InitializeComponent();
        }
        public string MaGiaoVien
        {
            get { return _magiaovien; }
            set { _magiaovien = value; }
        }
        public void LoadMonHoc()
        {
            bangmonhoc.Clear();
            string query = "select mamonhoc, tenmonhoc, sotinchi, hocky, tengiaovien from tblMonHoc inner join tblGiaoVien on tblMonHoc.magiaovien = tblGiaoVien.magiaovien";
            bangmonhoc = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            dgvMonHoc.DataSource = bangmonhoc;
        }
        private void DanhSachMonGV_Load(object sender, EventArgs e)
        {
            LoadMonHoc();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = "select mamonhoc, tenmonhoc, sotinchi, hocky, tengiaovien from tblMonHoc inner join tblGiaoVien on tblMonHoc.magiaovien = tblGiaoVien.magiaovien where tenmonhoc LIKE N'%" + txtTimkiem.Text + "%'";
            bangmonhoc = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            dgvMonHoc.DataSource = bangmonhoc;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadMonHoc();
        }
    }
}
