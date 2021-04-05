using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Model
{
    class DTO_ChiTietMuonTra
    {
        public int MaCTPM, MaSach, mapm;
        public string tenSach, istra;
        public DateTime ngaytra;

        public DTO_ChiTietMuonTra(int mact, int masach, int mapm, string tensach, string istra, DateTime ngaytra)
        {
            this.MaCTPM = mact;
            this.MaSach = masach;
            this.mapm = mapm;
            this.tenSach = tensach;
            this.istra = istra;
            this.ngaytra = ngaytra;
        }

        public DTO_ChiTietMuonTra(int mact, string istra, DateTime ngaytra)
        {
            this.MaCTPM = mact;

            this.istra = istra;
            this.ngaytra = ngaytra;
        }

        public DTO_ChiTietMuonTra(int masach, int mapm, string tensach, string istra, DateTime ngaytra)
        {
            this.MaSach = masach;
            this.mapm = mapm;
            this.tenSach = tensach;
            this.istra = istra;
            this.ngaytra = ngaytra;
        }
    }
}
