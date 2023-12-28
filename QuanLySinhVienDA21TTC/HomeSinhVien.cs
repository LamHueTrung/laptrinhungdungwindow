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
    public partial class HomeSinhVien : Form
    {
       public string masinhvien = "";
        public HomeSinhVien(string masinhvien)
        {
            InitializeComponent();
            this.masinhvien = masinhvien;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            dangKyMonHoc2.Visible = true;
            dangKyMonHoc2.BringToFront();
            dangKyMonHoc2.MaSinhVien = masinhvien;
            traCuuDiem1.Visible = false;
            background1.Visible = false;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void HomeSinhVien_Load(object sender, EventArgs e)
        {
            dangKyMonHoc2.Visible = false;
            traCuuDiem1.Visible = false;
            background1.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            traCuuDiem1.Visible = true;
            traCuuDiem1.BringToFront();
            traCuuDiem1.MaSinhVien = masinhvien;
            dangKyMonHoc2.Visible=false;
            background1.Visible = false;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
