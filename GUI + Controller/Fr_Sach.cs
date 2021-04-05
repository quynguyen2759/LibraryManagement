using QLThuVien.DATA;
using QLThuVien.GUI_Tier;
using QLThuVien.Model;
using System;
using System.Data;
using System.Windows.Forms;
using QLThuVien.BUS;
using QLThuVien.GUI___Controller;

namespace QLThuVien.GUI
{
    public partial class Fr_Sach : Form
    {
        private DATA_Sach sa = new DATA_Sach();
        private BUS_Sach bus_Sach = new BUS_Sach();

        public Fr_Sach()
        {
            InitializeComponent();
        }

        #region Load dữ liệu
        private void loadSach()
        {
            lvSach.FullRowSelect = true;
            lvSach.View = View.Details;
            lvSach.Columns.Add("Mã Sách");
            lvSach.Columns.Add("Tên Sách", 200);
            lvSach.Columns.Add("Tác Giả", 100);
            lvSach.Columns.Add("Năm xuất bản", 50);
            lvSach.Columns.Add("Nhà xuất bản", 100);
            lvSach.Columns.Add("Trị Giá", 50);
            lvSach.Columns.Add("Ngày Nhập", 100);
            if (bus_Sach.Bus_LayDSSach() != null)
            {
                DataTable dt = bus_Sach.Bus_LayDSSach();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvItem = new ListViewItem(dt.Rows[i][0].ToString());
                    lvItem.SubItems.Add(dt.Rows[i][1].ToString());
                    lvItem.SubItems.Add(dt.Rows[i][2].ToString());
                    lvItem.SubItems.Add(dt.Rows[i][3].ToString());
                    lvItem.SubItems.Add(dt.Rows[i][4].ToString());
                    lvItem.SubItems.Add(dt.Rows[i][5].ToString());
                    lvItem.SubItems.Add(dt.Rows[i][6].ToString());
                    lvSach.Items.Add(lvItem);
                }
            }
            else
                MessageBox.Show("Dữ liệu sách hiện đang không có! (có thể không có sách hoặc dữ liệu sách bị lỗi!)");

        }
        #endregion

        private void reLoadSach(DataTable dt)
        {
            lvSach.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvItem = new ListViewItem(dt.Rows[i][0].ToString());
                lvItem.SubItems.Add(dt.Rows[i][1].ToString());
                lvItem.SubItems.Add(dt.Rows[i][2].ToString());
                lvItem.SubItems.Add(dt.Rows[i][3].ToString());
                lvItem.SubItems.Add(dt.Rows[i][4].ToString());
                lvItem.SubItems.Add(dt.Rows[i][5].ToString());
                lvItem.SubItems.Add(dt.Rows[i][6].ToString());
                lvSach.Items.Add(lvItem);
            }
        }

        private void Fr_Sach_Load(object sender, EventArgs e)
        {
            loadSach();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        #region Xử lý sự kiện click trên 1 dòng
        //Lấy thông tin trên listview gán vào các Textbox
        private void lvSach_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (lvSach.SelectedItems.Count > 0)
                {
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    ListViewItem lvi = lvSach.SelectedItems[lvSach.SelectedItems.Count - 1];
                    if (lvi != null)
                        foreach (ListViewItem lv in lvSach.SelectedItems)
                        {
                            txtMaSach.Text = lv.SubItems[0].Text;
                            txtTenSach.Text = lv.SubItems[1].Text;
                            txtTacGia.Text = lv.SubItems[2].Text;
                            txtNamXuatBan.Text = lv.SubItems[3].Text;
                            txtNXB.Text = lv.SubItems[4].Text;
                            txtTriGia.Text = lv.SubItems[5].Text;
                            dtpNgayNhap.Value = DateTime.Parse(lv.SubItems[6].Text);

                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        #endregion

        #region Xử lý Button Quay lại form Main
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Đăng xuất không?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Form fr_main = new Fr_Main();
                fr_main.Show();
                this.Hide();
            }
        }
        #endregion

        #region Xử lý Button Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            // int maSach = int.Parse(txtMaSach.Text);

            //kiểm tra rỗng
            if (txtTenSach.Text.Equals("") || txtTacGia.Text.Equals("")
                    || txtNamXuatBan.Text.Equals("") || txtNXB.Text.Equals("")
                    || txtTriGia.Text.Equals("") || dtpNgayNhap.Value == null)
                MessageBox.Show("Thêm không thành công!\nBạn đã nhập thiếu thông tin! Hãy kiểm tra lại", "Lỗi");
            else
            try
                {
                     if (int.Parse(txtNamXuatBan.Text) <= 0 || int.Parse(txtNamXuatBan.Text) > DateTime.Now.Year)
                        MessageBox.Show("Thêm không thành công!\nNăm sản xuất phải lớn hơn 0 hoặc nhỏ hơn bằng năm hiện tại! Hãy kiểm tra lại", "Lỗi");
                    else if (int.Parse(txtTriGia.Text) <= 0)
                        MessageBox.Show("Thêm không thành công!\n Trị giá sách phải lớn hơn 0! Hãy kiểm tra lại", "Lỗi");
                    String tenSach = txtTenSach.Text;
                    String tacGia = txtTacGia.Text;
                    int namXuatBan = int.Parse(txtNamXuatBan.Text);
                    String nxb = txtNXB.Text;
                    float trigia = int.Parse(txtTriGia.Text);
                    DateTime ngayNhap = dtpNgayNhap.Value;
                    DTO_Sach s = new DTO_Sach(tenSach, tacGia, namXuatBan, nxb, trigia, ngayNhap);
                    if (bus_Sach.Bus_ThemSach(s) == true)
                    {
                        MessageBox.Show("Thêm thành công!\nSách đã được thêm vào!", "Thông báo");
                        txtTenSach.Clear();
                        txtTacGia.Clear();
                        txtNamXuatBan.Clear();
                        txtTriGia.Clear();
                        txtNXB.Clear();
                        lvSach.Clear();
                        loadSach();
                    }
                    else
                        MessageBox.Show("Thêm không thành công!\nLỗi cơ sở dữ liệu", "Lỗi");
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm không thành công!\nLưu ý Năm xuất bản và trị giá phải là số!", "Lỗi");
                }

        }
        #endregion

        #region Xử lý button Cập nhật
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text.Equals("") || txtTacGia.Text.Equals("")
                    || txtNamXuatBan.Text.Equals("") || txtNXB.Text.Equals("")
                    || txtTriGia.Text.Equals("") || dtpNgayNhap.Value == null)
                MessageBox.Show("Sửa không thành công!\nBạn đã nhập thiếu thông tin! Hãy kiểm tra lại", "Lỗi");
            else
                try
                {
                    int masach = int.Parse(txtMaSach.Text);
                    String tenSach = txtTenSach.Text;
                    String tacGia = txtTacGia.Text;
                    int namXuatBan = int.Parse(txtNamXuatBan.Text);
                    String nxb = txtNXB.Text;
                    float trigia = int.Parse(txtTriGia.Text);
                    DateTime ngayNhap = dtpNgayNhap.Value;
                    DTO_Sach s = new DTO_Sach(masach, tenSach, tacGia, namXuatBan, nxb, trigia, ngayNhap);
                    if (bus_Sach.Bus_CapNhatSach(s))
                    {
                        MessageBox.Show("Sửa thành công!\nSách đã được sửa!", "Thông báo");
                        txtTenSach.Clear();
                        txtTacGia.Clear();
                        txtNamXuatBan.Clear();
                        txtTriGia.Clear();
                        txtNXB.Clear();
                        lvSach.Clear();
                        loadSach();
                    }
                    else
                        MessageBox.Show("Sửa không thành công!\nLỗi cơ sở dữ liệu", "Lỗi");
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công!\nKiểm tra lại dữ lieu nhập(Năm xb hoặc trị giá là số !!", "Lỗi");
                }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn sửa sách đang chọn với thông tin đang nhập trên không?", "Sửa không?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (txtTenSach.Text.Equals("") || txtTacGia.Text.Equals("")
                    || txtNamXuatBan.Text.Equals("") || txtNXB.Text.Equals("")
                    || txtTriGia.Text.Equals("") || dtpNgayNhap.Value == null)
                    MessageBox.Show("Sửa không thành công!\nBạn đã nhập thiếu thông tin! Hãy kiểm tra lại", "Lỗi");
               
                else
                    try
                    {
                        if (int.Parse(txtNamXuatBan.Text) <= 0 || int.Parse(txtNamXuatBan.Text) > DateTime.Now.Year)
                            MessageBox.Show("Thêm không thành công!\nNăm sản xuất phải lớn hơn 0 hoặc nhỏ hơn bằng năm hiện tại! Hãy kiểm tra lại", "Lỗi");
                        else if (int.Parse(txtTriGia.Text) <= 0)
                            MessageBox.Show("Thêm không thành công!\n Trị giá sách phải lớn hơn 0! Hãy kiểm tra lại", "Lỗi");
                        int masach = int.Parse(txtMaSach.Text);
                        String tenSach = txtTenSach.Text;
                        String tacGia = txtTacGia.Text;
                        int namXuatBan = int.Parse(txtNamXuatBan.Text);
                        String nxb = txtNXB.Text;
                        float trigia = int.Parse(txtTriGia.Text);
                        DateTime ngayNhap = dtpNgayNhap.Value;
                        DTO_Sach s = new DTO_Sach(masach, tenSach, tacGia, namXuatBan, nxb, trigia, ngayNhap);
                        if (bus_Sach.Bus_CapNhatSach(s) == true)
                        {
                            MessageBox.Show("Sửa thành công!\nSách đã được sửa!", "Thông báo");
                            txtTenSach.Clear();
                            txtTacGia.Clear();
                            txtNamXuatBan.Clear();
                            txtTriGia.Clear();
                            txtNXB.Clear();
                            lvSach.Clear();
                            loadSach();
                        }
                        else
                            MessageBox.Show("Sửa không thành công!\nLỗi cơ sở dữ liệu", "Lỗi");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sửa không thành công!\nLưu ý Năm xuất bản và trị giá phải là số!", "Lỗi");
                    }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtNamXuatBan.Clear();
            txtTriGia.Clear();
            txtNXB.Clear();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        #endregion

        #region Xử lý button Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa sách đang chọn không?", "Xóa không?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                sa = new DATA_Sach();
                string MaSach = txtMaSach.Text;
                if (sa.XoaSach(MaSach) == true)
                {
                    MessageBox.Show("Xóa sách thành công!", "Thông báo");
                    lvSach.Clear();
                    loadSach();
                }
                else
                    MessageBox.Show("Xóa sách không thành công!\nDo khóa ngoại", "Lỗi");
            }
               
            
        }

        

    

        #endregion

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if(txt_Tim.Text.Equals(""))
                MessageBox.Show("Lỗi không tìm thấy dữ liệu!\n Chọn options tìm rỗng!", "Lỗi");
            else
                try
                {
                    int choose = cbb_Options.SelectedIndex;
                    string Options = "TenSach";
                    string key = txt_Tim.Text;
                    DataTable dt;
                    switch (choose)
                    {
                        case 0:
                            Options = "TenSach";
                            break;
                        case 1:
                            Options = "TacGia";
                            break;
                        case 2:
                            Options = "NamXuatBan";
                            break;
                        case 3:
                            Options = "NhaXuatBan";
                            break;
                        case 4:
                            Options = "TriGia";
                            break;
                        default:
                            break;
                    }

                    dt = this.bus_Sach.Bus_TimSach(Options, key);
                    if(dt == null)
                        MessageBox.Show("Lỗi không tìm thấy dữ liệu!", "Lỗi");
                    else
                        reLoadSach(dt);
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi không tìm thấy dữ liệu!", "Lỗi");
                }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_DocGia_Click(object sender, EventArgs e)
        {
            Form FrDocGia = new Fr_DocGia();
            FrDocGia.Show();
            this.Hide();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            Form FrNhanVien = new Fr_NhanVien();
            FrNhanVien.Show();
            this.Hide();
        }

        private void btn_Tra_Click(object sender, EventArgs e)
        {
            Form FrTraSach = new Fr_TraSach();
            FrTraSach.Show();
            this.Hide();
        }

        private void btn_Muon_Click(object sender, EventArgs e)
        {
            Form FrMuonSach = new Fr_MuonSach();
            FrMuonSach.Show();
            this.Hide();
        }
    }
}
