using QLThuVien.BUS;
using QLThuVien.DATA;
using QLThuVien.GUI;
using QLThuVien.GUI_Tier;
using QLThuVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.GUI___Controller
{
    public partial class Fr_TraSach : Form
    {

        private DATA_TraSach TraSach = new DATA_TraSach();
        private BUS_TraSach bus_TraSach;
        public Fr_TraSach()
        {
            InitializeComponent();
        }

        void hienthiPhieuMuon()
        {
            bus_TraSach = new BUS_TraSach();

            lv_SachMuon.FullRowSelect = true;
            lv_SachMuon.View = View.Details;
            lv_SachMuon.Columns.Add("Mã Phiếu Mượn", 100);
            lv_SachMuon.Columns.Add("Mã độc giả", 200);
            lv_SachMuon.Columns.Add("Ngày lập phiếu mượn", 105);
            foreach (PhieuMuonSach pm in bus_TraSach.layDSPhieuMuon())
            {
                ListViewItem lv = new ListViewItem(pm.MaPhieuMuon.ToString());
                lv.SubItems.Add(pm.MaDocGia.ToString());
                lv.SubItems.Add(pm.NgayMuon.ToString());
                lv_SachMuon.Items.Add(lv);
            }
        }

        string mapm;

        void hienthiCTPM()
        {
            TraSach = new DATA_TraSach();
            bus_TraSach = new BUS_TraSach();
            lv_CTPhieuMuon.Clear();
            IEnumerable<ChiTietPhieuMuon> ct = bus_TraSach.layDSCTPM(mapm);
            lv_CTPhieuMuon.Columns.Add("Mã CTPM, 1");
            lv_CTPhieuMuon.Columns.Add("Mã sách, 100");
            lv_CTPhieuMuon.Columns.Add("Tên sách, 100");
            lv_CTPhieuMuon.Columns.Add("Tình trạng", 100);
            lv_CTPhieuMuon.Columns.Add("Ngày trả", 105);
            foreach (ChiTietPhieuMuon pm in ct)
            {
                ListViewItem lv = new ListViewItem(pm.MaCTPM.ToString());
                lv.SubItems.Add(pm.MaSach.ToString());
                lv.SubItems.Add(pm.TenSach.ToString());
                lv.SubItems.Add(pm.IsTra);
                lv.SubItems.Add(pm.NgayTra.ToString());
                lv_CTPhieuMuon.Items.Add(lv);
            }
        }

        
        private void Fr_TraSach_Load(object sender, EventArgs e)
        {
            hienthiPhieuMuon();
            lv_CTPhieuMuon.FullRowSelect = true;
            lv_CTPhieuMuon.View = View.Details;
            
            //   lv_CTPhieuMuon.Columns.Add("Tên sách", 200);
  
        }

        private void lv_SachMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (lv_SachMuon.SelectedItems.Count > 0)
                {

                    ListViewItem lvi = lv_SachMuon.SelectedItems[lv_SachMuon.SelectedItems.Count - 1];
                    if (lvi != null)
                        foreach (ListViewItem lv in lv_SachMuon.SelectedItems)
                        {
                            mapm = lv.SubItems[0].Text;
                            hienthiCTPM();

                        }
                }
             
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        private void btn_TraSach_Click(object sender, EventArgs e)
        {
            bus_TraSach = new BUS_TraSach();
            DialogResult dr = MessageBox.Show("Có phải bạn muốn trả sách đang chọn không?", "Trả không?", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                if(tinhtrang.Equals("Đã trả"))
                {
                    bus_TraSach = new BUS_TraSach();
                    DTO_ChiTietMuonTra ct = new DTO_ChiTietMuonTra(int.Parse(mactpm), "Đã trả", dtp_NgayTra.Value);
                    if (bus_TraSach.Bus_TraSach(ct))

                    {
                        MessageBox.Show("Trả sách thành công", "Thông báo!");
                        hienthiCTPM();
                    }
                    else
                        MessageBox.Show("Trả sách không thành công", "Lỗi");
                }
                else
                {
                    MessageBox.Show("Sách đã trả rồi! không thể trả được nữa", "Lỗi");
                }
               
            }
        }
            
        String mactpm;
        string tinhtrang;
        private void lv_CTPhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (lv_CTPhieuMuon.SelectedItems.Count > 0)
                {

                    ListViewItem lvi = lv_CTPhieuMuon.SelectedItems[lv_CTPhieuMuon.SelectedItems.Count - 1];
                    if (lvi != null)
                        foreach (ListViewItem lv in lv_CTPhieuMuon.SelectedItems)
                        {
                            mactpm = lv.SubItems[0].Text;
                            tinhtrang = lv.SubItems[3].Text;
                        }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btn_TimPhieuMuon_Click(object sender, EventArgs e)
        {
            bus_TraSach = new BUS_TraSach();
            lv_SachMuon.Clear();
            lv_SachMuon.FullRowSelect = true;
            lv_SachMuon.View = View.Details;
            lv_SachMuon.Columns.Add("Mã Phiếu Mượn", 100);
            lv_SachMuon.Columns.Add("Mã độc giả", 200);
            lv_SachMuon.Columns.Add("Ngày lập phiếu mượn", 105);
            foreach (PhieuMuonSach pm in bus_TraSach.timMaPhieuMuon(txt_TimPhieuMuon.Text))
            {
                ListViewItem lv = new ListViewItem(pm.MaPhieuMuon.ToString());
                lv.SubItems.Add(pm.MaDocGia.ToString());
                lv.SubItems.Add(pm.NgayMuon.ToString());
                lv_SachMuon.Items.Add(lv);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn đăng xuất không?","Đăng xuất không?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Form fr_main = new Fr_Main();
                fr_main.Show();
                this.Hide();
            }
                
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

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            Form FrNhanVien = new Fr_NhanVien();
            FrNhanVien.Show();
            this.Hide();
        }
    }
}
