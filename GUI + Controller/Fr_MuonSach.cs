using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuVien.BUS;
using QLThuVien.DATA;
using QLThuVien.GUI;
using QLThuVien.GUI_Tier;
using QLThuVien.Model;

namespace QLThuVien.GUI___Controller
{
    public partial class Fr_MuonSach : Form
    {

        QLThuVienDataContext Db = new QLThuVienDataContext();
        DateTime aDateTime = DateTime.Now;
        public Fr_MuonSach()
        {
            InitializeComponent();
        }
        DATA_MuonSach MuonSach = new DATA_MuonSach();
        DATA_Sach sach = new DATA_Sach();
        BUS_MuonSach bus_MuonSach;
        void hienThiSach()
        {
            bus_MuonSach = new BUS_MuonSach();
            MuonSach = new DATA_MuonSach();
            lv_Sach.FullRowSelect = true;
            lv_Sach.View = View.Details;
            lv_Sach.Columns.Add("Mã Sách", 100);
            lv_Sach.Columns.Add("Tên Sách", 200);
            lv_Sach.Columns.Add("Tác Giả", 100);
            lv_Sach.Columns.Add("Năm xuất bản", 50);
            lv_Sach.Columns.Add("Nhà xuất bản", 100);
            foreach (Sach sa in MuonSach.layDSSach())
            {
                ListViewItem lv = new ListViewItem(sa.MaSach.ToString());
                lv.SubItems.Add(sa.TenSach.ToString());
                lv.SubItems.Add(sa.TacGia.ToString());
                lv.SubItems.Add(sa.NamXuatBan.ToString());
                lv.SubItems.Add(sa.NhaXuatBan.ToString());
                lv_Sach.Items.Add(lv);
            }
        }

        private void Fr_MuonSach_Load(object sender, EventArgs e)
        {
            hienThiSach();
            hienThiDocGia();
            hienthiPhieuMuon();
            lvGioSach.Columns.Add("Mã sách", 100);
            lvGioSach.Columns.Add("Tên sách", 200);
        }


        void hienThiDocGia()
        {
            bus_MuonSach = new BUS_MuonSach();
            MuonSach = new DATA_MuonSach();
            lv_DocGia.Clear();
            lv_DocGia.FullRowSelect = true;
            lv_DocGia.View = View.Details;
            lv_DocGia.Columns.Add("Mã Độc Giả", 100);
            lv_DocGia.Columns.Add("Tên Độc Giả", 200);
            lv_DocGia.Columns.Add("Ngày lập thẻ", 105);
            lv_DocGia.Columns.Add("Ngày hết hạn", 105);
            foreach (DocGia dg in MuonSach.layDSTenDG())
            {
                ListViewItem lv = new ListViewItem(dg.MaDocGia.ToString());
                lv.SubItems.Add(dg.HoTenDocGia.ToString());
                lv.SubItems.Add(dg.NgayLapThe.ToString());
                lv.SubItems.Add(dg.NgayHetHan.ToString());
                lv_DocGia.Items.Add(lv);
            }
        }

        void hienthiPhieuMuon()
        {
            bus_MuonSach = new BUS_MuonSach();
            MuonSach = new DATA_MuonSach();
            lv_PhieuMuon.FullRowSelect = true;
            lv_PhieuMuon.View = View.Details;
            lv_PhieuMuon.Columns.Add("Mã Phiếu Mượn", 100);
            lv_PhieuMuon.Columns.Add("Mã độc giả", 200);
            lv_PhieuMuon.Columns.Add("Ngày lập phiếu mượn", 105);
            foreach (PhieuMuonSach pm in MuonSach.layDSPhieuMuon())
            {
                ListViewItem lv = new ListViewItem(pm.MaPhieuMuon.ToString());
                lv.SubItems.Add(pm.MaDocGia.ToString());
                lv.SubItems.Add(pm.NgayMuon.ToString());
                lv_PhieuMuon.Items.Add(lv);
            }
        }

        String tensachgio = "";
        string masachgio = "";
        private void lv_Sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (lv_Sach.SelectedItems.Count > 0)
                {

                    ListViewItem lvi = lv_Sach.SelectedItems[lv_Sach.SelectedItems.Count - 1];
                    if (lvi != null)
                        foreach (ListViewItem lv in lv_Sach.SelectedItems)
                        {
                            masachgio = lv.SubItems[0].Text;
                            tensachgio = lv.SubItems[1].Text;

                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void btn_GioSach_Click(object sender, EventArgs e)
        {
            lvGioSach.FullRowSelect = true;
            lvGioSach.View = View.Details;
            
            ListViewItem lv = new ListViewItem(masachgio);
            lv.SubItems.Add(tensachgio);
            lvGioSach.Items.Add(lv);
        }



        private void lv_DocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

              

                if (lv_DocGia.SelectedItems.Count > 0)
                {

                    ListViewItem lvi = lv_DocGia.SelectedItems[lv_DocGia.SelectedItems.Count - 1];
                    if (lvi != null)
                        foreach (ListViewItem lv in lv_DocGia.SelectedItems)
                        {
                            txt_MaDocGia.Text = lv.SubItems[0].Text;
                            txt_TenDocGia.Text = lv.SubItems[1].Text;
                            dtp_NgayHetHan.Value = DateTime.Parse(lv.SubItems[3].Text);

                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        int maPM;

        private void btn_MuonSach_Click(object sender, EventArgs e)
        {
            bus_MuonSach = new BUS_MuonSach();
            MuonSach = new DATA_MuonSach();
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn mượn sách đang chọn trên không?\nKiểm tra kĩ nhé!", "Mượn không?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if(dtp_NgayHetHan.Value.Date >= DateTime.Now.Date)
                {
                    if (lvGioSach.Items.Count == 0 || txt_MaDocGia.Text.Equals(""))
                    {
                        MessageBox.Show("Mượn sách không thành công !\nGio sách hoặc mã độc giả còn trống! Hãy kiểm tra lại!", "Lỗi");
                    }
                    //     else if()
                    else
                    {
                        MessageBox.Show(dtp_NgayHetHan.Value.Year.ToString() + DateTime.Now.Date.ToString());
                        DTO_MuonTraSach mts = new DTO_MuonTraSach(dtp_NgayMuon.Value, int.Parse(txt_MaDocGia.Text));
                        maPM = bus_MuonSach.BUS_ThemPM(mts);
                        if (maPM == -1)
                        {
                            txt_MaPhieuMuon.Text = "";
                            MessageBox.Show("Mượn sách không thành công !", "Lỗi");
                        }
                        else
                        {
                            foreach (ListViewItem lv in lvGioSach.Items)
                            {
                                if (bus_MuonSach.BUS_ThemCTMS(maPM, lv.SubItems[0].Text.ToString(), lv.SubItems[1].Text.ToString(), "Chưa trả") == false)
                                    MessageBox.Show("Mượn sách không thành công!", "Thông báo");

                            }
                            txt_MaPhieuMuon.Text = maPM.ToString();
                            MessageBox.Show("Mượn sách thành công!\nĐã mươn được " + lvGioSach.Items.Count +
                                " quyển sách\nMã phiếu mượn: " + maPM, "Thông báo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mượn sách không thành công! Ngày hết hạn thẻ!!!!", "Thông báo");
                }
            }
                


        }

        private void lv_PhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (lv_PhieuMuon.SelectedItems.Count > 0)
                {

                    ListViewItem lvi = lv_PhieuMuon.SelectedItems[lv_PhieuMuon.SelectedItems.Count - 1];
                    if (lvi != null)
                        foreach (ListViewItem lv in lv_PhieuMuon.SelectedItems)
                        {
                            txt_MaPhieuMuon.Text = lv.SubItems[0].Text;

                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Đăng xuất không?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Form fr_main = new Fr_Main();
                fr_main.Show();
                this.Hide();
            }
        }

        private void btn_TimDocGia_Click(object sender, EventArgs e)
        {
            bus_MuonSach = new BUS_MuonSach();
            MuonSach = new DATA_MuonSach();
            lv_DocGia.Clear();
            lv_DocGia.FullRowSelect = true;
            lv_DocGia.View = View.Details;
            lv_DocGia.Columns.Add("Mã Độc Giả", 100);
            lv_DocGia.Columns.Add("Tên Độc Giả", 200);
            lv_DocGia.Columns.Add("Ngày lập thẻ", 105);
            lv_DocGia.Columns.Add("Ngày hết hạn", 105);
            foreach (DocGia dg in MuonSach.TimDocGia(txt_TimDocGia.Text))
            {
                ListViewItem lv = new ListViewItem(dg.MaDocGia.ToString());
                lv.SubItems.Add(dg.HoTenDocGia.ToString());
                lv.SubItems.Add(dg.NgayLapThe.ToString());
                lv.SubItems.Add(dg.NgayHetHan.ToString());
                lv_DocGia.Items.Add(lv);
            }
            
        }

        private void btn_TimSach_Click(object sender, EventArgs e)
        {
            bus_MuonSach = new BUS_MuonSach();
            MuonSach = new DATA_MuonSach();
            lv_Sach.FullRowSelect = true;
            lv_Sach.View = View.Details;
            lv_Sach.Columns.Add("Mã Sách", 100);
            lv_Sach.Columns.Add("Tên Sách", 200);
            lv_Sach.Columns.Add("Tác Giả", 100);
            lv_Sach.Columns.Add("Năm xuất bản", 50);
            lv_Sach.Columns.Add("Nhà xuất bản", 100);
            foreach (Sach sa in MuonSach.timSach(txt_TimSach.Text))
            {
                ListViewItem lv = new ListViewItem(sa.MaSach.ToString());
                lv.SubItems.Add(sa.TenSach.ToString());
                lv.SubItems.Add(sa.TacGia.ToString());
                lv.SubItems.Add(sa.NamXuatBan.ToString());
                lv.SubItems.Add(sa.NhaXuatBan.ToString());
                lv_Sach.Items.Add(lv);
            }
            
        }

        private void btn_BoSachCanMuon_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lv in lvGioSach.SelectedItems)
            {
                lvGioSach.Items.Remove(lv);

            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void btn_TraSach_Click(object sender, EventArgs e)
        {
            Form FrTraSach = new Fr_TraSach();
            FrTraSach.Show();
            this.Hide();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            Form FrNhanVien = new Fr_NhanVien();
            FrNhanVien.Show();
            this.Hide();
        }
    }
    
}
