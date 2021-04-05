using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLThuVien.DATA;
using QLThuVien.Model;

namespace QLThuVien.BUS
{
    class BUS_MuonSach
    {
        DATA_MuonSach m = new DATA_MuonSach();
        public int BUS_ThemPM(DTO_MuonTraSach pm)
        {
            try
            {
                return m.ThemPhieuMuon(pm);
            }
            catch (Exception)
            {
                return -1;
            }


        }

        public bool BUS_ThemCTMS(int mapm, string masach, string tensach, string istra)
        {
            try
            {
                m.ThemChiTietMuon(mapm, masach, tensach, istra);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
