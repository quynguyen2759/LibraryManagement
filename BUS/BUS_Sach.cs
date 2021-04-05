using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.DATA;
using QLThuVien.Model;



namespace QLThuVien.BUS
{

    ////////////////////////////////////////////KHOONG SU DUNG LINQ CHO Sach
    class BUS_Sach
    {


        DATA.DATA_Sach sach = new DATA_Sach();
        public DataTable Bus_LayDSSach()
        {
            try
            {
                return sach.LayDSSach(); ;
            }catch(Exception )
            {
                return null;
            }
        }



        public bool Bus_ThemSach(DTO_Sach s)
        {
            return sach.ThemSach(s);
        }


        public bool Bus_CapNhatSach(DTO_Sach s)
        {
            return sach.CapNhatSach(s);
        }


        public bool Bus_Xoa(String s)
        {
               
            return sach.XoaSach(s); 
        }

        public DataTable Bus_TimSach(string Options, string key)
        {
            return sach.TimSach(Options, key);
        }


    }
}
