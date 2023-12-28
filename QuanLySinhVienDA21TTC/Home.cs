using QuanLySinhVienDA21TTC.UC_CONTROL;
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
    public partial class Home : Form
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangmonhoc = new DataTable();
        public Home()
        {
            InitializeComponent();
        }
        void LoadMonHoc()
        {
            bangmonhoc.Clear();
            string query = "select mamonhoc, tenmonhoc, sotinchi, hocky, tengiaovien from tblMonHoc inner join tblGiaoVien on tblMonHoc.magiaovien = tblGiaoVien.magiaovien";
            bangmonhoc = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            danhSachSinhVienn1.Visible = true;
            danhSachSinhVienn1.BringToFront();
            danhSachGiaoVien1.Visible = false;
            danhSachMonHoc1.Visible = false;
            themGiaoVien1.Visible = false;
            themSinhVien1.Visible = false;
            themMonHoc1.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            danhSachGiaoVien1.Visible=false;
            danhSachMonHoc1.Visible=false;
            themGiaoVien1.Visible=false;
            themSinhVien1.Visible=false;
            themMonHoc1.Visible=false;
            danhSachSinhVienn1.Visible = false;
            background1.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            danhSachGiaoVien1.Visible = true;
            danhSachGiaoVien1.BringToFront();
            danhSachMonHoc1.Visible = false;
            themGiaoVien1.Visible = false;
            themSinhVien1.Visible = false;
            themMonHoc1.Visible = false;
            danhSachSinhVienn1.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DanhSachMonHoc danhsach = new DanhSachMonHoc();
            danhsach.DanhSachMonHoc_Load(this, null);
            danhSachMonHoc1.Visible = true;
            danhSachMonHoc1.BringToFront();
            danhSachGiaoVien1.Visible = false;
            themGiaoVien1.Visible = false;
            themSinhVien1.Visible = false;
            themMonHoc1.Visible = false;
            danhSachSinhVienn1.Visible = false;
        }

        private void danhSachMonHoc1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            themSinhVien1.Visible = true;
            themSinhVien1.BringToFront();
            danhSachGiaoVien1.Visible = false;
            danhSachMonHoc1.Visible = false;
            themGiaoVien1.Visible = false;
            themMonHoc1.Visible = false;
            danhSachSinhVienn1.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            themGiaoVien1.Visible = true;
            themGiaoVien1.BringToFront();
            danhSachGiaoVien1.Visible = false;
            danhSachMonHoc1.Visible = false;
            themSinhVien1.Visible = false;
            themMonHoc1.Visible = false;
            danhSachSinhVienn1.Visible = false;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            themMonHoc1.Visible = true;
            themMonHoc1.BringToFront();
            danhSachGiaoVien1.Visible = false;
            danhSachMonHoc1.Visible = false;
            themGiaoVien1.Visible = false;
            themSinhVien1.Visible = false;
            danhSachSinhVienn1.Visible = false;
        }
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
