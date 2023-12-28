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
    public partial class TraCuuDiem : UserControl
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangdiem = new DataTable();
        private string _maSinhVien = "";
        public TraCuuDiem()
        {
            InitializeComponent();
        }
        public string MaSinhVien
        {
            get { return _maSinhVien; }
            set { _maSinhVien = value; }
        }
        
        public void LoadBangDiem()
        {
            bangdiem.Clear();
            string query = "select tblDiemSo.mamonhoc, tenmonhoc, tensinhvien ,diemquatrinh, diemthi from tblDiemSo inner join tblMonHoc on tblDiemSo.mamonhoc = tblMonHoc.mamonhoc inner join tblSinhVien on tblSinhVien.masinhvien = tblDiemSo.masinhvien";
            bangdiem = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            dgvDiem.DataSource = bangdiem;
        }
        private void dgvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void TraCuuDiem_Load(object sender, EventArgs e)
        {
            LoadBangDiem();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = "select tblDiemSo.mamonhoc, tenmonhoc, tensinhvien ,diemquatrinh, diemthi from tblDiemSo inner join tblMonHoc on tblDiemSo.mamonhoc = tblMonHoc.mamonhoc inner join tblSinhVien on tblSinhVien.masinhvien = tblDiemSo.masinhvien where tblDiemSo.masinhvien = '" + txtTimkiem.Text+"'";
            bangdiem = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            dgvDiem.DataSource = bangdiem;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadBangDiem();
        }

        private void dgvDiem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu đang format cột điểm tổng kết
            if (e.ColumnIndex == dgvDiem.Columns["diemtongket"].Index && e.RowIndex >= 0)
            {
                // Lấy giá trị của cột điểm quá trình và cột điểm thi
                DataGridViewRow row = dgvDiem.Rows[e.RowIndex];
                object diemQuaTrinh = row.Cells["diemquatrinh"].Value;
                object diemThi = row.Cells["diemthi"].Value;

                // Kiểm tra nếu cả hai điểm có giá trị
                if (diemQuaTrinh != null && diemThi != null)
                {
                    // Thực hiện tính toán và đặt giá trị cho cột điểm tổng kết
                    double diemTongKet = (Convert.ToDouble(diemQuaTrinh) + Convert.ToDouble(diemThi)) / 2;
                    e.Value = diemTongKet.ToString("N2"); // Hiển thị giá trị với hai chữ số thập phân
                }
            }
        }
    }
}
