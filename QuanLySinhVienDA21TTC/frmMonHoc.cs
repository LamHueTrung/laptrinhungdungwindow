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
    public partial class frmMonHoc : Form
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        SqlDataAdapter bodocghi;
        DataTable bangmonhoc = new DataTable();
        int donghh = 0;
        public frmMonHoc()
        {
            InitializeComponent();
        }
        void LoadMonHoc()
        {
            string query = "select mamonhoc, tenmonhoc, sotinchi, hocky, tengiaovien from tblMonHoc inner join tblGiaoVien on tblMonHoc.magiaovien = tblGiaoVien.magiaovien";
            bangmonhoc = ketnoi.DocDuLieu(query);
            bodocghi = ketnoi.docghi;
            dgvMonHoc.DataSource = bangmonhoc;
        }
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            LoadMonHoc();
            // Tạo một cột mới
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Text = "Xoá";
            buttonColumn.HeaderText = "";
            buttonColumn.Name = "btnxoa";
            buttonColumn.UseColumnTextForButtonValue = true;

            // Thêm cột vào DataGridView
            dgvMonHoc.Columns.Add(buttonColumn);
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMonHoc.Columns["btnxoa"].Index && e.RowIndex >= 0)
            {
                donghh = e.RowIndex;
                if (donghh >= 0)
                {
                    string mamonhoc = bangmonhoc.Rows[donghh][0].ToString();
                    string query = "delete from tblMonHoc where mamonhoc = '" + mamonhoc + "'";
                    bangmonhoc = ketnoi.DocDuLieu(query);
                    MessageBox.Show("Xoá môn học thành công");
                    LoadMonHoc();
                }
            }
            else
            {
                donghh = e.RowIndex;
                if (donghh >= 0)
                {
                    string mamonhoc = bangmonhoc.Rows[donghh][0].ToString();
                    frmCapNhatMonHoc formCapNhat = new frmCapNhatMonHoc(mamonhoc);
                    formCapNhat.ShowDialog();
                    LoadMonHoc();
                }
            }
        }
    }
}
