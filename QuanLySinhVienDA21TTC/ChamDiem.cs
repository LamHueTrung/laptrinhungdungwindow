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
    public partial class ChamDiem : Form
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangdiem = new DataTable();
        string masinhvien = "";
        string mamonhoc = "";
        public ChamDiem(string masinhvien, string mamonhoc)
        {

            InitializeComponent();
            this.masinhvien = masinhvien;
            this.mamonhoc = mamonhoc;
        }
        public void LoadDiem()
        {
            string query = "select diemquatrinh, diemthi from tblDiemSo where mamonhoc = '" + mamonhoc+"' and masinhvien = '"+masinhvien+"'";
            bangdiem = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            if (bangdiem.Rows.Count > 0)
            {
                txtDiemQuaTrinh.Text = bangdiem.Rows[0]["diemquatrinh"].ToString();
                txtDiemThi.Text = bangdiem.Rows[0]["diemthi"].ToString();

            }
            else
            {
                MessageBox.Show("Không tìm thấy.");
            }

        }
        private void ChamDiem_Load(object sender, EventArgs e)
        {
            LoadDiem();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string query = "update tblDiemSo set diemquatrinh = N'" + txtDiemQuaTrinh.Text + "', diemthi = " + txtDiemThi.Text + " where mamonhoc = '" + mamonhoc+"' and masinhvien = '"+masinhvien+"'";
            bangdiem = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            MessageBox.Show("Chấm điểm thành công");
            this.Hide();
        }
    }
}
