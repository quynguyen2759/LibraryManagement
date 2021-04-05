using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using QLThuVien.Model;

namespace QLThuVien.DATA
{
    class DATA_TraSach
    {
        SqlConnection sqlConn;
        string cnStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
        QLThuVienDataContext tvD;

        public DATA_TraSach()
        {
            sqlConn = new SqlConnection(cnStr);
            tvD = new QLThuVienDataContext(sqlConn);
        }
        public IEnumerable<PhieuMuonSach> layDSPhieuMuon()
        {
            try
            {
                return tvD.GetTable<PhieuMuonSach>();
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<ChiTietPhieuMuon> layDSCTPhieUMuon(String ch)
        {
            try
            {
                return tvD.ChiTietPhieuMuons.Where(s => s.MaPhieuMuon.ToString().Contains(ch));
            }
            catch
            {
                return null;
            }
;       }


        public bool CapNhapTraSach(DTO_ChiTietMuonTra sach)
        {
            try
            {
                ChiTietPhieuMuon pm = tvD.ChiTietPhieuMuons.FirstOrDefault(p => p.MaCTPM == sach.MaCTPM);
                pm.IsTra = sach.istra;
                pm.NgayTra = sach.ngaytra;
                tvD.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }


        public IEnumerable<PhieuMuonSach> timMaPhieuMuon(String ch)
        {
            try
            {
                return tvD.PhieuMuonSaches.Where(s => s.MaPhieuMuon.ToString().Contains(ch) || s.MaDocGia.ToString().Contains(ch));
            }
            catch
            {
                return null;
            }
            
            
        }
    }
}
