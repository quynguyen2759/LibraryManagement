using QLThuVien.GUI;
using QLThuVien.GUI___Controller;
using System;
using System.Windows.Forms;

namespace QLThuVien.GUI_Tier
{
    public partial class Fr_Main : Form
    {
        public Fr_Main()
        {
            InitializeComponent();
        }



        private void btn_FrSach_Click(object sender, EventArgs e)
        {
            Form FrSach = new Fr_Sach();
            FrSach.Show();
            this.Hide();
        }

        private void btn_FrDocGia_Click(object sender, EventArgs e)
        {
            Form FrDocGia = new Fr_DocGia();
            FrDocGia.Show();
            this.Hide();
        }





        private void btn_frNhanVien_Click(object sender, EventArgs e)
        {
             Form FrNhanVien = new Fr_NhanVien();
             FrNhanVien.Show();
             this.Hide();
        }

        private void btn_MuonSach_Click(object sender, EventArgs e)
        {
            Form FrMuonSach = new Fr_MuonSach();
            FrMuonSach.Show();
            this.Hide();
        }

        private void btn_TraSach_Click(object sender, EventArgs e)
        {
            Form FrTraSach= new Fr_TraSach();
            FrTraSach.Show();
            this.Hide();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            DATA.DTA_TaiKhoan tk = new DATA.DTA_TaiKhoan();
            if (txt_TenDangNhap.Equals("") || txt_Pass.Equals(""))
                MessageBox.Show("Nhập thiếu thông tin", "Đăng nhập không thành công");
            else
            {
                if(tk.KiemTraDangNhap(txt_TenDangNhap.Text.ToString(), txt_Pass.Text.ToString()) == false )
                {
                    MessageBox.Show("Sai tài khoản  hoặc sai mật khẩu", "Đăng nhập không thành công");
                }
                else
                {
                    if(tk.QuyenTruyCapQuanLy(txt_TenDangNhap.Text.ToString(), txt_Pass.Text.ToString()))
                    {
                        MessageBox.Show("Đăng nhập thành công!\nQuyền truy cập là Quản lí các chức năng bạn đều sử dụng được nhé!", "Đăng nhập thành công");
                        grb_ChucNang.Visible = true;
                        btn_frNhanVien.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công!\nQuyền truy cập là Nhân viên, Bạn có thể sử dụng được các chức năng (NGOẠI TRỪ CHỨC NĂNG QUẢN LÝ NHÂN VIÊN)!", "Đăng nhập thành công");
                        grb_ChucNang.Visible = true;
                        btn_frNhanVien.Enabled = false;
                    }

                    grb_DangNhap.Visible = false;
                        
                }
            }
        }

        private void chucnang()
        {
          //  btn_frNhanVien.Enabled = true;
            btn_FrSach.Visible = true;
            btn_TraSach.Visible = true;
            btn_FrDocGia.Visible = true;
            btn_MuonSach.Visible = true;
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất không?",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                grb_DangNhap.Visible = true;
                grb_ChucNang.Visible = false;
            }
           
        }

        private void Fr_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
