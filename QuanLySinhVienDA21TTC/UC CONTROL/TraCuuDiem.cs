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
using Excel = Microsoft.Office.Interop.Excel;

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
            dvgTraCuu.DataSource = bangdiem;
        }
        private void dgvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void TraCuuDiem_Load(object sender, EventArgs e)
        {
            LoadBangDiem();
            // Tạo một cột mới
            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
            textColumn.HeaderText = "ĐIỂM TỔNG KẾT";
            textColumn.Name = "diemtongket";

            // Thêm cột vào DataGridView
            dvgTraCuu.Columns.Add(textColumn);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = "select tblDiemSo.mamonhoc, tenmonhoc, tensinhvien ,diemquatrinh, diemthi from tblDiemSo inner join tblMonHoc on tblDiemSo.mamonhoc = tblMonHoc.mamonhoc inner join tblSinhVien on tblSinhVien.masinhvien = tblDiemSo.masinhvien where tblDiemSo.masinhvien = '" + txtTimkiem.Text+"'";
            bangdiem = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            dvgTraCuu.DataSource = bangdiem;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadBangDiem();
        }

        private void dgvDiem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra nếu đang format cột "diemtongket"
            if (dvgTraCuu.Columns[e.ColumnIndex].Name == "diemtongket" && e.RowIndex >= 0)
            {
                // Lấy giá trị của cột "diemquatrinh" và cột "diemthi"
                DataGridViewRow row = dvgTraCuu.Rows[e.RowIndex];
                object diemQuaTrinh = row.Cells["diemquatrinh"].Value;
                object diemThi = row.Cells["diemthi"].Value;

                // Kiểm tra nếu cả hai điểm có giá trị
                if (diemQuaTrinh != null && diemThi != null)
                {
                    // Thực hiện tính toán và đặt giá trị cho cột "diemtongket"
                    double diemTongKet = (Convert.ToDouble(diemQuaTrinh) + Convert.ToDouble(diemThi)) / 2;
                    e.Value = diemTongKet.ToString("N2"); // Hiển thị giá trị với hai chữ số thập phân
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dvgTraCuu.Rows.Count > 0)
            {
                Excel.Application xcelApp = new Excel.Application();
                xcelApp.Workbooks.Add(Type.Missing);
                for (int i = 2; i < dvgTraCuu.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i - 1] = dvgTraCuu.Columns[i - 1].HeaderText;
                }
                xcelApp.Cells[1, 6] = dvgTraCuu.Columns[0].HeaderText;
                
                for (int i = 0; i < dvgTraCuu.Rows.Count; i++)
                {
                    for (int j = 0; j < dvgTraCuu.Columns.Count - 1; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dvgTraCuu.Rows[i].Cells[j + 1].Value?.ToString();
                    }
                    object diemQuaTrinh = dvgTraCuu.Rows[i].Cells[4].Value;
                    object diemThi = dvgTraCuu.Rows[i].Cells[5].Value;
                    if (diemQuaTrinh != null && diemThi != null)
                    {
                        // Thực hiện tính toán trung bình cộng
                        double diemTongKet = (Convert.ToDouble(diemQuaTrinh) + Convert.ToDouble(diemThi)) / 2;

                        // Gán giá trị vào ô tương ứng trong Excel
                        xcelApp.Cells[i + 2, 6] = diemTongKet.ToString("N2"); // Hiển thị giá trị với hai chữ số thập phân
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
