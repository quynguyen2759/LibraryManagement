using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuVien.Model;
using System.Collections.Specialized;

namespace QLThuVien.DATA
{
    class DATA_NhanVien
    {
        private DTO_NhanVien dto_NhanVien = new DTO_NhanVien();
        SqlConnection sqlConn;
        string cnStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
        QLThuVienDataContext tvD;
        public DATA_NhanVien()
        {
            sqlConn = new SqlConnection(cnStr);
            tvD = new QLThuVienDataContext(sqlConn);
        }
        public IEnumerable<NhanVien> layDSNhanVien()
        {
            //string sql = "select MaNhanVien, HoTenNhanVien, NgaySinh, DiaChi, DienThoai,"+
            //    " TenBangCap from NHANVIEN, BANGCAP where NHANVIEN.MaBangCap = BANGCAP.MaBangCap";
            //DataTable dt = conClass.Execute(sql);
            //return dt;
            IEnumerable<NhanVien> nvien = tvD.GetTable<NhanVien>();
            return nvien;
        }
        public IEnumerable<BangCap> layDSBangCap()
        {
            //string sql = "Select * from BANGCAP";
            //DataTable dt = conClass.Execute(sql);
            //return dt;
            IEnumerable<BangCap> bcap = tvD.GetTable<BangCap>();
            return bcap;
        }


        public bool ThemNV(DTO_NhanVien nv)
        {
            //string sql = string.Format("Insert into NHANVIEN (HoTenNhanVien,NgaySinh,DiaChi,DienThoai,MaBangCap)"
            //       + " values (N'{0}','{1}','{2}','{3}','{4}')", ten, date, dc, dt, mbc);
            //conClass.ExecuteNonquery(sql);
            try
            {
                NhanVien em = new NhanVien();
                em.HoTenNhanVien = nv.UI_TenNhanVien;
                em.NgaySinh = nv.UI_NgaySinh;
                em.DiaChi = nv.UI_DiaChi;
                em.DienThoai = nv.UI_DienThoai;
                em.MaBangCap = nv.UI_MaBangCap;
                tvD.NhanViens.InsertOnSubmit(em);
                tvD.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool SuaNV(DTO_NhanVien nv)
        {
            //string sql = string.Format("Update NHANVIEN set HoTenNhanVien ="
            //            + "N'{0}',NgaySinh =N'{1}',DiaChi =N'{2}',DienThoai =N'{3}',MaBangCap =N'{4}' where MaNhanVien ="
            //            + ma_nv, ten, date, dc, dt, mbc);
            //conClass.ExecuteNonquery(sql);
            try
            {
                NhanVien em = tvD.NhanViens.FirstOrDefault(s => s.MaNhanVien.Equals(nv.UI_MaNhanVien));
                em.HoTenNhanVien = nv.UI_TenNhanVien;
                em.NgaySinh = nv.UI_NgaySinh;
                em.DiaChi = nv.UI_DiaChi;
                em.DienThoai = nv.UI_DienThoai;
                em.MaBangCap = nv.UI_MaBangCap;
                tvD.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public bool XoaNV(string ma_nv)
        {
            //string sql = "Delete from NHANVIEN where MaNhanVien = " + ma_nv;
            //conClass.ExecuteNonquery(sql);
            try
            {
                NhanVien em = tvD.NhanViens.FirstOrDefault(s => s.MaNhanVien.Equals(ma_nv));
                tvD.NhanViens.DeleteOnSubmit(em);
                tvD.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
