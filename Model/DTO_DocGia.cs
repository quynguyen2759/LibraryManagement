using System;

namespace QLThuVien.Model
{
    class DTO_DocGia
    {
        private int MaDocGia;
        private String TenDocGia, DiaChi, Email;
        private DateTime NgaySinh, NgayLapThe, NgayHetHan;
        //private float TienNo;

        public DTO_DocGia(int MaDG, String TenDG, DateTime NgaySinh,
            String DiaChi, String Email, DateTime NgayLapThe, DateTime NgayHetHan)
        {
            this.MaDocGia = MaDG;
            this.TenDocGia = TenDG;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.Email = Email;
            this.NgayLapThe = NgayLapThe;
            this.NgayHetHan = NgayHetHan;
         //   this.TienNo = TienNo;

        }

        public DTO_DocGia(String TenDG, DateTime NgaySinh,
            String DiaChi, String Email, DateTime NgayLapThe, DateTime NgayHetHan)
        {
          
            this.TenDocGia = TenDG;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.Email = Email;
            this.NgayLapThe = NgayLapThe;
            this.NgayHetHan = NgayHetHan;
         //   this.TienNo = TienNo;

        }

        public int UI_MaDocGia
        {
            get
            {
                return this.MaDocGia;
            }

            set
            {
                this.MaDocGia = value;
            }
        }




        public String UI_TenDocGia
        {
            get
            {
                return this.TenDocGia;
            }

            set
            {
                this.TenDocGia = value;
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

        public String UI_Email
        {
            get
            {
                return this.Email;
            }

            set
            {
                this.Email = value;
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


        public DateTime UI_NgayLapThe
        {
            get
            {
                return this.NgayLapThe;
            }

            set
            {
                this.NgayLapThe = value;
            }
        }


        public DateTime UI_NgayHetHan
        {
            get
            {
                return this.NgayHetHan;
            }

            set
            {
                this.NgayHetHan = value;
            }
        }

    }
}
