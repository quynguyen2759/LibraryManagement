using QLThuVien.DATA;
using QLThuVien.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.BUS
{
    class BUS_DocGia
    {
        DATA_DocGia docgia = new DATA_DocGia();
        public DataTable Bus_LayDSDocGia()
        {
            try
            {
                return docgia.LayDSDocGia();
            }catch(Exception)
            {
                return null;
            }
        }


        public bool Bus_ThemDocGia(DTO_DocGia dg)
        {
            try
            {
                docgia.ThemDocGia(dg);
                return true;
            }catch(Exception )
            {
                return false;
            }
        }

        public bool Bus_CapNhatDocGia(DTO_DocGia dg)
        {
            try
            {
                docgia.CapNhatDocGia(dg);
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        public bool Bus_Xoa(String madocgia)
        {
            docgia = new DATA_DocGia();
              return docgia.XoaDocGia(madocgia); ;
     
        }

        public DataTable Bus_TimDocGia(string Option, string key)
        {
            try
            {
                return docgia.TimDocGia(Option, key);
            }
            catch (Exception )
            {
                return null;
            }
        }

    }
}
