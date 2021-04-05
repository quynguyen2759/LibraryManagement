using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuVien.Model;

namespace QLThuVien.DATA
{

    /// <summary>
    /// ///////////////////////////////Sử dụng LinQ
    /// </summary>
    class DATA_MuonSach
    {
        SqlConnection sqlConn;
        string cnStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
        QLThuVienDataContext tvD;
        public DATA_MuonSach()
        {
            sqlConn = new SqlConnection(cnStr);
            tvD = new QLThuVienDataContext(sqlConn);
        }
        public IEnumerable<Sach> layDSSach()
        {
            return tvD.GetTable<Sach>();
        }

        public IEnumerable<DocGia> layDSTenDG()
        {
            return tvD.GetTable<DocGia>();
        }

        public IEnumerable<PhieuMuonSach> layDSPhieuMuon()
        {
            return tvD.GetTable<PhieuMuonSach>();
        }

        public int ThemPhieuMuon(DTO_MuonTraSach MuonTraSach)
        {

            PhieuMuonSach pm = new PhieuMuonSach();
            pm.NgayMuon = MuonTraSach.ngaymuon;
            pm.MaDocGia = MuonTraSach.madocgia;
            tvD.PhieuMuonSaches.InsertOnSubmit(pm);
            tvD.SubmitChanges();
            return pm.MaPhieuMuon;
        }

        public void ThemChiTietMuon(int nm, string masach, string tensach, string istra)
        {

            ChiTietPhieuMuon ct = new ChiTietPhieuMuon();
            ct.IsTra = istra;
            ct.TenSach = tensach;
            ct.MaPhieuMuon = nm;
            ct.MaSach = Int32.Parse(masach);
            tvD.ChiTietPhieuMuons.InsertOnSubmit(ct);
            tvD.SubmitChanges();
        }


        public IEnumerable<Sach> timSach(string ch)
        {
            return tvD.Saches.Where(s => s.MaSach.ToString().Contains(ch) || s.TenSach.Contains(ch) ||
            s.TacGia.Contains(ch) || s.NhaXuatBan.Contains(ch) || s.NamXuatBan.ToString().Contains(ch));
        }
        public IEnumerable<DocGia> TimDocGia(string ch)
        {
            return tvD.DocGias.Where(s => s.MaDocGia.ToString().Contains(ch) || s.HoTenDocGia.Contains(ch));
            
        }
    }
}
