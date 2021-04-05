using QLThuVien.DATA;
using QLThuVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.BUS
{
    class BUS_NhanVien
    {
        DATA_NhanVien NhanVien;
        public bool ThemNhanVien(DTO_NhanVien dto_NhanVien)
        {
            NhanVien = new DATA_NhanVien();
            return NhanVien.ThemNV(dto_NhanVien);
        }


        public bool SuaNhanVien(DTO_NhanVien dto_NhanVien)
        {
            NhanVien = new DATA_NhanVien();
            return NhanVien.SuaNV(dto_NhanVien);
        }

        public bool XoaNhanVien(string mnv)
        {
            NhanVien = new DATA_NhanVien();
            return NhanVien.XoaNV(mnv);
        }

    }
}
