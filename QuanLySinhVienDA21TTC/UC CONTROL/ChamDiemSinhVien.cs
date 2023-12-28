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
    public partial class ChamDiemSinhVien : UserControl
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangdiem = new DataTable();
        int donghh = 0;
        private string _magiaovien = "";
        public ChamDiemSinhVien()
        {
            InitializeComponent();
        }
        public string MaGiaoVien
        {
            get { return _magiaovien; }
            set { _magiaovien = value; }
        }
        public void LoadBangDiem()
        {
            bangdiem.Clear();
            string query = "select tblDiemSo.mamonhoc, tenmonhoc,tblDiemSo.masinhvien, tensinhvien ,diemquatrinh, diemthi from tblDiemSo inner join tblMonHoc on tblDiemSo.mamonhoc = tblMonHoc.mamonhoc inner join tblSinhVien on tblSinhVien.masinhvien = tblDiemSo.masinhvien inner join tblGiaoVien on tblMonHoc.magiaovien = tblGiaoVien.magiaovien where tblGiaoVien.magiaovien = '" + _magiaovien+"' ";
            bangdiem = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            dgvDiem.DataSource = bangdiem;
        }
        private void ChamDiemSinhVien_Load(object sender, EventArgs e)
        {
            LoadBangDiem();
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Text = "Chấm điểm";
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "btnchamdiem";
            buttonColumn.UseColumnTextForButtonValue = true;

            // Thêm cột vào DataGridView
            dgvDiem.Columns.Add(buttonColumn);
            buttonColumn.DisplayIndex = dgvDiem.Columns.Count - 1;
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDiem.Columns["btnchamdiem"].Index && e.RowIndex >= 0)
            {
                donghh = e.RowIndex;
                if (donghh >= 0)
                {
                    string mamonhoc = bangdiem.Rows[donghh][0].ToString();
                    string masinhvien = bangdiem.Rows[donghh][3].ToString();
                    ChamDiem chamdiem = new ChamDiem(masinhvien, mamonhoc);
                    chamdiem.ShowDialog();
                    LoadBangDiem();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadBangDiem() ;
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
