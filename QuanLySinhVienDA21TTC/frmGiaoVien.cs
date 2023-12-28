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
    public partial class frmGiaoVien : Form
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable banggiaovien = new DataTable();
        int donghh = 0;
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        void LoadGiaoVien()
        {
            string query = "Select * from tblGiaoVien";
            banggiaovien = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            dvggiaovien.DataSource = banggiaovien;
        }
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            LoadGiaoVien();
            // Tạo một cột mới
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Text = "Xoá";
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "btnxoa";
            buttonColumn.UseColumnTextForButtonValue = true;

            // Thêm cột vào DataGridView
            dvggiaovien.Columns.Add(buttonColumn);
        }

        private void dvggiaovien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dvggiaovien.Columns["btnxoa"].Index && e.RowIndex >= 0)
            {
                donghh = e.RowIndex;
                if (donghh >= 0)
                {
                    string magiaovien = banggiaovien.Rows[donghh][0].ToString();
                    string query = "delete from tblGiaoVien where magiaovien = '" + magiaovien + "'";
                    banggiaovien = ketnoi.DocDuLieu(query);
                    MessageBox.Show("Xoá giáo viên thành công");
                    LoadGiaoVien();
                }
            }
            else
            {
                donghh = e.RowIndex;
                if (donghh >= 0)
                {
                    string magiaovien = banggiaovien.Rows[donghh][0].ToString();
                    frmCapNhatGiaoVien formCapNhat = new frmCapNhatGiaoVien(magiaovien);
                    formCapNhat.ShowDialog();
                    LoadGiaoVien();
                }
            }

        }
    }
}
