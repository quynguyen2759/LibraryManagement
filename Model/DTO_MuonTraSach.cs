using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Model
{
    class DTO_MuonTraSach
    {

        public int maphieumuon;
        public DateTime ngaymuon;
        public int madocgia;
        public DTO_MuonTraSach() { 
            }

        public DTO_MuonTraSach(int mpm, DateTime ngaymuon, int madocgia)
        {
            this.maphieumuon = mpm;
            this.madocgia = madocgia;
            this.ngaymuon = ngaymuon;
        }

        public DTO_MuonTraSach( DateTime ngaymuon, int madocgia)
        {
            this.madocgia = madocgia;
            this.ngaymuon = ngaymuon;
        }

    }
}
