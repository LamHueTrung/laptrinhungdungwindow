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
    public partial class DangKyMonHoc : UserControl
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangmonhoc = new DataTable();
        DataTable bangdiem = new DataTable();
        int donghh = 0;
        private string _maSinhVien = "";

        public DangKyMonHoc()
        {
            InitializeComponent();
        }
        public string MaSinhVien
        {
            get { return _maSinhVien; }
            set { _maSinhVien = value; }
        }
        public void LoadMonHoc()
        {
            bangmonhoc.Clear();
            string query = "select mamonhoc, tenmonhoc, sotinchi, hocky, tengiaovien from tblMonHoc inner join tblGiaoVien on tblMonHoc.magiaovien = tblGiaoVien.magiaovien";
            bangmonhoc = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            dgvMonHoc.DataSource = bangmonhoc;
        }
        private void DangKyMonHoc_Load(object sender, EventArgs e)
        {
            LoadMonHoc();
            // Tạo một cột mới
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Text = "Đăng Ký";
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "btndangky";
            buttonColumn.UseColumnTextForButtonValue = true;

            // Thêm cột vào DataGridView
            dgvMonHoc.Columns.Add(buttonColumn);
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMonHoc.Columns["btndangky"].Index && e.RowIndex >= 0)
            {
                donghh = e.RowIndex;
                if (donghh >= 0)
                {
                    string mamonhoc = bangmonhoc.Rows[donghh][0].ToString();
                    string query = "insert into tblDiemSo (masinhvien, mamonhoc, diemquatrinh, diemthi) values ('"+ _maSinhVien +"', N'" + mamonhoc + "', " + 0 + ", " + 0 + ")";
                    bangdiem = ketnoi.DocDuLieu(query);
                    bodocghi = ketnoi.docghi;
                    MessageBox.Show("Đăng ký môn học " + bangmonhoc.Rows[donghh][1].ToString() + " thành công");
                    LoadMonHoc();
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = "Select * from tblMonHoc where tenmonhoc = '" + txtTimkiem.Text + "'";
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
