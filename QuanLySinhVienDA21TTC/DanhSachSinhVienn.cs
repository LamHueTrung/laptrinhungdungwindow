﻿using System;
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

    public partial class DanhSachSinhVienn : UserControl
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangsinhvien = new DataTable();
        int donghh = 0;
        public DanhSachSinhVienn()
        {
            InitializeComponent();
        }
        void LoadSinhVien()
        {
            string query = "Select * from tblSinhVien";
            bangsinhvien = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            dvgsinhvien.DataSource = bangsinhvien;
        }
        private void DanhSachSinhVienn_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
            // Tạo một cột mới
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Text = "Xoá";
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "btnxoa";
            buttonColumn.UseColumnTextForButtonValue = true;

            // Thêm cột vào DataGridView
            dvgsinhvien.Columns.Add(buttonColumn);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string query = "Select * from tblSinhVien where masinhvien = '" + txtTimkiem.Text + "'";
            bangsinhvien = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            dvgsinhvien.DataSource = bangsinhvien;
        }
    }
}
