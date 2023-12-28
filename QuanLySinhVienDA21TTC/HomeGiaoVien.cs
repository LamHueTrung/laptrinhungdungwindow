using QuanLySinhVienDA21TTC.UC_CONTROL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVienDA21TTC
{
    public partial class HomeGiaoVien : Form
    {
        public string magiaovien = "";
        public HomeGiaoVien(string magiaovien)
        {
            this.magiaovien = magiaovien;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeGiaoVien_Load(object sender, EventArgs e)
        {
            danhSachMonGV1.Visible = false;
            chamDiemSinhVien1.Visible = false;
            background1.Visible = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            danhSachMonGV1.Visible = true;
            danhSachMonGV1.BringToFront();
            danhSachMonGV1.MaGiaoVien = magiaovien;
            chamDiemSinhVien1.Visible = false;
            background1.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            chamDiemSinhVien1.Visible = true;
            chamDiemSinhVien1.BringToFront();
            chamDiemSinhVien1.MaGiaoVien = magiaovien;
            danhSachMonGV1.Visible = false;
            background1.Visible = false;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
