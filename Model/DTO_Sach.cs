using System;

namespace QLThuVien.Model
{
    class DTO_Sach
    {
        int MaSach, NamXB;
        String TenSach, TacGia, NXB;
        float Gia;
        DateTime NgayNhap;

        public DTO_Sach() { }

        public DTO_Sach(String TenSach, String TacGia, int NamXB, String NXB, float Gia, DateTime NgayNhap)
        {
          ///  this.MaSach = MaSach;
            this.TenSach = TenSach;
            this.TacGia = TacGia;
            this.NXB = NXB;
            this.NamXB = NamXB;
            this.Gia = Gia;
            this.NgayNhap = NgayNhap;
        }

        public DTO_Sach(int MaSach, String TenSach, String TacGia, int NamXB, String NXB, float Gia, DateTime NgayNhap)
        {
            this.MaSach = MaSach;
            this.TenSach = TenSach;
            this.TacGia = TacGia;
            this.NXB = NXB;
            this.NamXB = NamXB;
            this.Gia = Gia;
            this.NgayNhap = NgayNhap;
        }

        public int UI_MaSach
        {
            get
            {
                return this.MaSach;
            }

            set
            {
                this.MaSach = value;
            }
        }

        public String UI_TenSach
        {
            get
            {
                return this.TenSach;
            }

            set
            {
                this.TenSach = value;
            }
        }


        public String UI_TacGia
        {
            get
            {
                return this.TacGia;
            }

            set
            {
                this.TacGia = value;
            }
        }


        public String UI_NXB
        {
            get
            {
                return this.NXB;
            }

            set
            {
                this.NXB = value;
            }
        }


        public int UI_NamXB
        {
            get
            {
                return this.NamXB;
            }

            set
            {
                this.NamXB = value;
            }
        }


        public float UI_Gia
        {
            get
            {
                return this.Gia;
            }

            set
            {
                this.Gia = value;
            }
        }

        public DateTime UI_NgayNhap
        {
            get
            {
                return this.NgayNhap;
            }

            set
            {
                this.NgayNhap = value;
            }
        }


    }



}
