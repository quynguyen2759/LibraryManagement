using QLThuVien.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace QLThuVien.DATA
{
    class DATA_DocGia : DataBaseConnection
    {
        DataBaseConnection cnn;
        SqlConnection sqlConn;
        string cnStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
        public DATA_DocGia()
        {
            cnn = new DataBaseConnection();
            sqlConn = new SqlConnection(cnStr);
        }

        public DataTable LayDSDocGia()
        {
            String sqlString = "Select * from DocGia";
            DataTable dt = cnn.Execute(sqlString);
            return dt;
        }

        public bool XoaDocGia(string MaDocGia)
        {
            try
            {
                string sql = "Delete from DocGia where MaDocGia = " + MaDocGia;
                //   cnn.ExecuteNonQuery(sql);
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public void ThemDocGia(DTO_DocGia dg)
        {
            string sql = string.Format("Insert into DocGia(HoTenDocGia, NgaySinh, DiaChi, Email, NgayLapThe, NgayHetHan)" +
                " values(N'{0}','{1}',N'{2}',N'{3}','{4}','{5}')", dg.UI_TenDocGia, dg.UI_NgaySinh,
                dg.UI_DiaChi, dg.UI_Email, dg.UI_NgayLapThe, dg.UI_NgayHetHan);
            cnn.ExecuteNonQuery(sql);
        }

        public void CapNhatDocGia(DTO_DocGia dg)
        {
            string sql = string.Format("update DocGia set" +
                "[HoTenDocGia]=N'{1}',[NgaySinh]='{2}',[DiaChi]=N'{3}',[Email]=N'{4}',[NgayLapThe]='{5}',[NgayHetHan]='{6}'" +
                " where [MaDocGia] = {0}", dg.UI_MaDocGia, dg.UI_TenDocGia, dg.UI_NgaySinh,
                dg.UI_DiaChi, dg.UI_Email, dg.UI_NgayLapThe, dg.UI_NgayHetHan);
            cnn.ExecuteNonQuery(sql);
        }

        public DataTable TimDocGia(string Options, string key)
        {
            string sql = string.Format("select * from DocGia where {0} like '%{1}%' " +
                "or {0} like '_{1}'" +
                "or {0} like '{1}_'" +
                "or {0} like '_{1}_'", Options, key);
            return cnn.Execute(sql);
        }


    }
}
