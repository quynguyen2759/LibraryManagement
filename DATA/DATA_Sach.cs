using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using QLThuVien.Model;

namespace QLThuVien.DATA
{
    class DATA_Sach : DataBaseConnection
    {

        DataBaseConnection cnn;
        SqlConnection sqlConn;
        string cnStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;//using System.Configuration;
       
        //  public int MaSach { get; set; }
        //   public String TenSach { get; set; }
        //   public String TacGia { get; set; }
        //  public int NamXuatBan { get; set; }
        //   public String NhaXuatBan { get; set; }
        //  public float TriGia { get; set; }
        //   public DateTime NgayNhap { get; set; }
        public DATA_Sach()
        {
            cnn = new DataBaseConnection();
            sqlConn = new SqlConnection(cnStr);
        }
        public DataTable LayDSSach()
        {
            String sqlString = "Select * from Sach";
            DataTable dt = cnn.Execute(sqlString);
            return dt;
        }

        public bool XoaSach(string index_Sach)
        {
            try
            {
                string sql = "Delete from Sach where MaSach = " + index_Sach;
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
        public bool ThemSach(DTO_Sach s)
        {
            try
            {
                string sql = string.Format("Insert into Sach(TenSach, TacGia, NamXuatBan, NhaXuatBan, TriGia, NgayNhap) " +
                 " values(N'{0}',N'{1}',{2},N'{3}',N'{4}', '{5}')", s.UI_TenSach, s.UI_TacGia, s.UI_NamXB, s.UI_NXB, s.UI_Gia, s.UI_NgayNhap);
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

        public DataTable TimSach(string Options, string key)
        {
            try
            {
                string sql = string.Format("select * from Sach where {0} like '%{1}%' " +
                "or {0} like '_{1}'" +
                "or {0} like '{1}_'" +
                "or {0} like '_{1}_'", Options, key);
                return cnn.Execute(sql);
            }
            catch (Exception)
            {
                return null;
            }

        }

        public bool CapNhatSach(DTO_Sach s)
        {
            try
            {
                string sql = string.Format("update Sach set [TenSach] = N'{0}', [TacGia] = N'{1}'," +
                "[NamXuatBan] = {2}, [NhaXuatBan] = N'{3}',[TriGia] = {4}, [NgayNhap] = '{5}' " +
                "where[MaSach] ={6}", s.UI_TenSach, s.UI_TacGia, s.UI_NamXB, s.UI_NXB, s.UI_Gia, s.UI_NgayNhap, s.UI_MaSach);
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

    }
}
