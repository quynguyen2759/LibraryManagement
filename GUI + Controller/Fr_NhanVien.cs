using QLThuVien.DATA;
using QLThuVien.GUI_Tier;
using QLThuVien.Model;
using System;
using System.Data;
using System.Windows.Forms;
using QLThuVien.BUS;
using QLThuVien.GUI;

namespace QLThuVien.GUI___Controller
{
    public partial class Fr_NhanVien : Form
    {
        public Fr_NhanVien()
        {
            InitializeComponent();
        }

        private void Fr_NhanVien_Load(object sender, EventArgs e)
        {
            hienthiNhanVien();
            loadcbox();
            btn_Xoa.Enabled = false;
            btn_Sua.Enabled = false;
        }
        BUS_NhanVien bus_NhanVien = new BUS_NhanVien();

        private DATA_NhanVien nv;

        private void hienthiNhanVien()
        {
            lv_NhanVien.FullRowSelect = true;
            lv_NhanVien.View = View.Details;
            lv_NhanVien.Columns.Add("Mã Nhan Vien", 100);
            lv_NhanVien.Columns.Add("Tên Nhân Viên", 200);
            lv_NhanVien.Columns.Add("Ngày sinh", 100);
            lv_NhanVien.Columns.Add("Điện thoại", 50);
            lv_NhanVien.Columns.Add("Địa chỉ", 50);
            lv_NhanVien.Columns.Add("Bằng cấp", 100);
            nv = new DATA_NhanVien();
            foreach (NhanVien sa in nv.layDSNhanVien())
            {
                ListViewItem lv = new ListViewItem(sa.MaNhanVien.ToString());
                lv.SubItems.Add(sa.HoTenNhanVien.ToString());
                lv.SubItems.Add(sa.NgaySinh.ToString());
                lv.SubItems.Add(sa.DienThoai.ToString());
                lv.SubItems.Add(sa.DiaChi.ToString());
                lv.SubItems.Add(sa.BangCap.TenBangCap.ToString());
                lv_NhanVien.Items.Add(lv);
            }
        }

        private void loadcbox()
        {
            cb_BangCap.DataSource = nv.layDSBangCap();
            cb_BangCap.DisplayMember = "TenBangCap";
            cb_BangCap.ValueMember = "MaBangCap";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = txt_TenNhanVien.Text;
                string dc = txt_DiaChi.Text;
                int sdt = int.Parse(txt_DienThoai.Text);
                int mbc = int.Parse(cb_BangCap.SelectedValue.ToString());
                DTO_NhanVien nv = new DTO_NhanVien(ten, dtp_NgaySinh.Value, dc, sdt, mbc);
                if (bus_NhanVien.ThemNhanVien(nv))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                    lv_NhanVien.Items.Clear();
                    hienthiNhanVien();
                    clear();
                }
                else
                    MessageBox.Show("Thêm không thành công! kiểm tra dữ liệu vừa nhập lại!", "Thông báo");

            }
            catch(Exception)
            {
                MessageBox.Show("Thêm không thành công! kiểm tra dữ liệu vừa nhập lại!", "Thông báo");
            }
               
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = int.Parse(txt_MaNhanVien.Text);
                string ten = txt_TenNhanVien.Text;
                string dc = txt_DiaChi.Text;
                int sdt = int.Parse(txt_DienThoai.Text);
                int mbc = int.Parse(cb_BangCap.SelectedValue.ToString());
                DTO_NhanVien nv = new DTO_NhanVien(ma, ten, dtp_NgaySinh.Value, dc, sdt, mbc);
                DialogResult dr = MessageBox.Show("Bạn muốn sửa nhân viên này?", "Sửa nhân viên!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    if (bus_NhanVien.SuaNhanVien(nv))
                    {
                        MessageBox.Show("Sửa thành công!", "Thông báo");
                        lv_NhanVien.Items.Clear();
                        hienthiNhanVien();
                        clear();
                    }
                    else
                        MessageBox.Show("Sửa không thành công! kiểm tra dữ liệu vừa nhập lại!", "Thông báo");
                }

                   
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa không thành công! kiểm tra dữ liệu vừa nhập lại!", "Thông báo");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (lv_NhanVien.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn muốn xóa nhân viên này?", "XÓA!", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    bus_NhanVien.XoaNhanVien(lv_NhanVien.SelectedItems[0].SubItems[0].Text);
                    MessageBox.Show("Đã xóa nhân viên đã chọn!");
                    lv_NhanVien.Items.Clear();
                    hienthiNhanVien();
                    clear();

                }
            }
            else
                MessageBox.Show("Bạn phải chọn dòng cần xóa");
           
        }

        private void lv_NhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_NhanVien.SelectedItems.Count > 0)
            {
                txt_MaNhanVien.Text = lv_NhanVien.SelectedItems[0].SubItems[0].Text;
                txt_TenNhanVien.Text = lv_NhanVien.SelectedItems[0].SubItems[1].Text;
                dtp_NgaySinh.Text = lv_NhanVien.SelectedItems[0].SubItems[2].Text;
                txt_DiaChi.Text = lv_NhanVien.SelectedItems[0].SubItems[4].Text;
                txt_DienThoai.Text = lv_NhanVien.SelectedItems[0].SubItems[3].Text;
                cb_BangCap.Text = lv_NhanVien.SelectedItems[0].SubItems[5].Text;
                btn_Sua.Enabled = true;
                btn_Xoa.Enabled = true;

            }
        }

        private void clear()
        {
            txt_MaNhanVien.Text = "";
            string ten = txt_TenNhanVien.Text = "";
            string dc = txt_DiaChi.Text = "";
            txt_DienThoai.Text = "";
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            Form fr_main = new Fr_Main();
            fr_main.Show();
            this.Hide();
        }

        private void btn_Sach_Click(object sender, EventArgs e)
        {
            Form FrSach = new Fr_Sach();
            FrSach.Show();
            this.Hide();
        }

        private void btn_DocGia_Click(object sender, EventArgs e)
        {
            Form FrDocGia = new Fr_DocGia();
            FrDocGia.Show();
            this.Hide();
        }

        private void btn_Muon_Click(object sender, EventArgs e)
        {
            Form FrMuonSach = new Fr_MuonSach();
            FrMuonSach.Show();
            this.Hide();
        }

        private void btn_Tra_Click(object sender, EventArgs e)
        {
            Form FrTraSach = new Fr_TraSach();
            FrTraSach.Show();
            this.Hide();
        }
    }
}
