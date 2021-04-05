using System;

namespace QLThuVien.Model
{
    class DTO_NhanVien
    {
        private int MaNhanVien, DienThoai, MaBangCap;
        private String TenNhanVien, DiaChi;
        private DateTime NgaySinh;

        public DTO_NhanVien(int MaNV, String TenNV, DateTime NgaySinh, String DiaChi, int DT, int MaBangCap)
        {
            this.MaNhanVien = MaNV;
            this.TenNhanVien = TenNV;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.DienThoai = DT;
            this.MaBangCap = MaBangCap;
        }
        public DTO_NhanVien( String TenNV, DateTime NgaySinh, String DiaChi, int DT, int MaBangCap)
        {
            this.TenNhanVien = TenNV;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.DienThoai = DT;
            this.MaBangCap = MaBangCap;
        }

        public DTO_NhanVien() { }

        public int UI_MaNhanVien
        {
            get
            {
                return this.MaNhanVien;
            }

            set
            {
                this.MaNhanVien = value;
            }
        }

        public String UI_TenNhanVien
        {
            get
            {
                return this.TenNhanVien;
            }

            set
            {
                this.TenNhanVien = value;
            }
        }

        public String UI_DiaChi
        {
            get
            {
                return this.DiaChi;
            }

            set
            {
                this.DiaChi = value;
            }
        }


        public int UI_DienThoai
        {
            get
            {
                return this.DienThoai;
            }

            set
            {
                this.DienThoai = value;
            }
        }

        public int UI_MaBangCap
        {
            get
            {
                return this.MaBangCap;
            }

            set
            {
                this.MaBangCap = value;
            }
        }

        public DateTime UI_NgaySinh
        {
            get
            {
                return this.NgaySinh;
            }

            set
            {
                this.NgaySinh = value;
            }
        }



    }
}
