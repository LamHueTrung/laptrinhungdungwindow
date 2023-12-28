using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienDA21TTC
{
    internal class KetNoiDuLieu
    {
        public SqlConnection ketnoi;
        public SqlDataAdapter docghi;
        public SqlCommand lenh;
        public SqlCommandBuilder capnhat;
        public KetNoiDuLieu()
        {
            ketnoi = new SqlConnection();
            string chuoiketnoi = "Data Source = LAMHUETRUNG; Initial Catalog = QUANLYSINHVIEN; Integrated Security = True";
            ketnoi.ConnectionString = chuoiketnoi;
        }
        public DataTable DocDuLieu(string sql)
        {
            ketnoi.Open();
            docghi = new SqlDataAdapter(sql, ketnoi);
            DataTable bangtam = new DataTable();
            docghi.Fill(bangtam);
            ketnoi.Close();
            return bangtam;
        }
        //Dành cho câu lệnh insert/update/delete
        public void ThaoTacDuLieu(string sql)
        {
            ketnoi.Open();
            lenh = new SqlCommand(sql, ketnoi);
            lenh.ExecuteNonQuery();
            ketnoi.Close();
        }
        //Không cần sử dụng câu lệnh insert/update/delete
        public void CapNhatDuLieu(SqlDataAdapter bdg, DataTable dt)
        {
            capnhat = new SqlCommandBuilder(bdg);
            bdg.Update(dt);
        }
    }
}
