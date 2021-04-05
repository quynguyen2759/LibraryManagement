using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QLThuVien.DATA
{
    class DataBaseConnection
    {
        //Update, Delete, Insert
        SqlConnection sqlConn;//Đối tượng kết nối CSDL//using System.Data.SqlClient;
        SqlDataAdapter da; //Đối tượng điều phối DL
        DataSet ds;//Đói tượng chứa CSDL

        public DataBaseConnection()
        {
            string cnStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;//using System.Configuration;
            sqlConn = new SqlConnection(cnStr);
        }
        //Phương thức thực thi câu lệnh SQL truy vấn dữ liệu
        public DataTable Execute(string sqlStr) //using System.Data;
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0];
        }

        //Phương thức thực thi câu lệnh Thêm, Xóa, Sửa
        public void ExecuteNonQuery(string sqlStr)
        {
            try
            {
                SqlCommand sqlCmd = new SqlCommand(sqlStr, sqlConn);
                sqlConn.Open();//Mở kết nối
                sqlCmd.ExecuteNonQuery();//Lệnh thêm/sửa/xóa
            }
            catch (SqlException e)
            {
                Console.WriteLine("Không thể kết nối đến csdl\n", e);
                sqlConn.Close();
            }
            finally
            {
                sqlConn.Close();//Đóng kết nối 
            }
        }
    }
}
