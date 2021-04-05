using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QLThuVien.DATA
{
    class DTA_TaiKhoan
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

        public DTA_TaiKhoan()
        {
            cnn = new DataBaseConnection();
            sqlConn = new SqlConnection(cnStr);
        }

        public bool KiemTraDangNhap(string tk, string mk)
        {
            bool dem = false;
            String sqlString = String.Format("Select quyentruycap from TaiKhoan where taikhoan = '{0}' AND matkhau = '{1}'", tk, mk);
            DataTable dt = cnn.Execute(sqlString);
            for (int i = 0; i < dt.Rows.Count; i++)
                dem = true;
            return dem;
        }


        public bool QuyenTruyCapQuanLy(string tk, string mk)
        {
            bool dem = false;
            String sqlString = String.Format("Select * from TaiKhoan where taikhoan = '{0}' AND matkhau = '{1}' AND quyentruycap = 1", tk, mk);
            DataTable dt = cnn.Execute(sqlString);
            for (int i = 0; i < dt.Rows.Count; i++)
                dem = true;
            return dem;
        }

    }
   

}
