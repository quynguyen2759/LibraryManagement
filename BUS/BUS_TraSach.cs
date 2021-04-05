using QLThuVien.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.BUS
{
    class BUS_TraSach
    {

        DATA.DATA_TraSach trasach = new DATA.DATA_TraSach();
        public bool Bus_TraSach(DTO_ChiTietMuonTra ct)
        {
                return trasach.CapNhapTraSach(ct) ;
        }


        public IEnumerable<PhieuMuonSach> timMaPhieuMuon(String ch)
        {
            return trasach.timMaPhieuMuon(ch);
        }


        public IEnumerable<PhieuMuonSach> layDSPhieuMuon ()
        {
            return trasach.layDSPhieuMuon();
        }
        public IEnumerable<ChiTietPhieuMuon> layDSCTPM(string ch)
        {
            return trasach.layDSCTPhieUMuon(ch);
        }

    }
}
