using QLThuVien.BUS;
using QLThuVien.DATA;
using QLThuVien.GUI;
using QLThuVien.GUI___Controller;
using QLThuVien.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLThuVien.GUI_Tier
{
    public partial class Fr_DocGia : Form
    {
        public Fr_DocGia()
        {
            InitializeComponent();
        }

        private BUS_DocGia bus_DocGia = new BUS_DocGia();
        //private DTO_DocGia docgia = new DTO_DocGia();
        private void loadDocGia()
        {
            lv_Reader.FullRowSelect = true;
            lv_Reader.View = View.Details;
            lv_Reader.Columns.Add("Mã Độc Giả");
            lv_Reader.Columns.Add("Tên Độc Giả", 200);
            lv_Reader.Columns.Add("Ngày Sinh", 105);
            lv_Reader.Columns.Add("Địa Chỉ", 175);
            lv_Reader.Columns.Add("Email", 150);
            lv_Reader.Columns.Add("Ngày lập thẻ", 105);
            lv_Reader.Columns.Add("Ngày hết hạn", 105);


            if (bus_DocGia.Bus_LayDSDocGia() != null)
            {
                DataTable dt = bus_DocGia.Bus_LayDSDocGia();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvItem = new ListViewItem(dt.Rows[i][0].ToString());
                    lvItem.SubItems.Add(dt.Rows[i][1].ToString());
                    lvItem.SubItems.Add(dt.Rows[i][2].ToString());
                    lvItem.SubItems.Add(dt.Rows[i][3].ToString());
                    lvItem.SubItems.Add(dt.Rows[i][4].ToString());
                    lvItem.SubItems.Add(dt.Rows[i][5].ToString());
                    lvItem.SubItems.Add(dt.Rows[i][6].ToString());
                    lv_Reader.Items.Add(lvItem);
                }
            }
            else
                MessageBox.Show("Dữ liệu trong độc giả không có", "Thông báo");
           
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
              //  int madg = int.Parse(txt_MaDocGia.Text);
               
                //     float dept = float.Parse(txt_Dept.Text);
            if (txt_Name.Text.Equals("") || txt_Address.Text.Equals("") || txt_Email.Text.Equals("") ||
                        dtp_Date.Value.ToString().Equals("") || dtp_Create.Value.ToString().Equals("")
                        || dtp_Expired.Value.ToString().Equals(""))
                    MessageBox.Show("Thêm độc giả không thành công!\nBạn đã nhập thiếu thông tin! Hãy kiểm tra lại", "Lỗi");
            else
                try
                {
                    string name = txt_Name.Text;
                    DateTime date = dtp_Date.Value;
                    string address = txt_Address.Text;
                    string email = txt_Email.Text;
                    DateTime created = dtp_Create.Value;
                    DateTime expired = dtp_Expired.Value;
                    DTO_DocGia d = new DTO_DocGia(name, date, address, email, created, expired);
                    if(bus_DocGia.Bus_ThemDocGia(d) == true)
                    {
                        MessageBox.Show("Thêm độc giả thành công!", "Thông báo");
                        txt_Name.Clear();
                        txt_Address.Clear();
                        txt_Email.Clear();
                        txt_Dept.Clear(); 
                        lv_Reader.Clear();
                        loadDocGia();
                    }
                    else
                        MessageBox.Show("Thêm độc giả không thành công!\nLỗi cơ sở dữ liệu", "Lỗi");

                }catch (Exception )
                {
                   MessageBox.Show("Thêm không thành công!\nLưu ý có thể ban nhập sai kiểu dữ liệu!", "Lỗi");
                }
           
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
                string MaDocGia = txt_MaDocGia.Text;
                if (bus_DocGia.Bus_Xoa(MaDocGia))
                {
                    lv_Reader.Clear();
                    loadDocGia();
                    MessageBox.Show("Xóa độc giả thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa độc giả không thành công!\nLỗi cơ sở dữ liệu", "Lỗi");
                }
            

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            btn_Update.Enabled = false;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.Equals("") || txt_Address.Text.Equals("") || txt_Email.Text.Equals("") ||
                       dtp_Date.Value.ToString().Equals("") || dtp_Create.Value.ToString().Equals("")
                       || dtp_Expired.Value.ToString().Equals(""))
                MessageBox.Show("Sửa độc giả không thành công!\nBạn đã nhập thiếu thông tin! Hãy kiểm tra lại", "Lỗi");
            else
                try
                {
                    int madocgia = int.Parse(txt_MaDocGia.Text);
                    string name = txt_Name.Text;
                    DateTime date = dtp_Date.Value;
                    string address = txt_Address.Text;
                    string email = txt_Email.Text;
                    DateTime created = dtp_Create.Value;
                    DateTime expired = dtp_Expired.Value;
                    DTO_DocGia d = new DTO_DocGia(madocgia, name, date, address, email, created, expired);
                    if (bus_DocGia.Bus_CapNhatDocGia(d) == true)
                    {
                        MessageBox.Show("Sửa độc giả thành công!", "Thông báo");
                        txt_Name.Clear();
                        txt_Address.Clear();
                        txt_Email.Clear();
                        txt_Dept.Clear();
                        lv_Reader.Clear();
                        loadDocGia();
                        btn_Save.Enabled = false;
                        btn_Cancel.Enabled = false;
                    }
                    else
                        MessageBox.Show("Sửa độc giả không thành công!\nLỗi cơ sở dữ liệu", "Lỗi");

                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công!\nLưu ý có thể ban nhập sai kiểu dữ liệu!", "Lỗi");
                }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_MaDocGia.Clear();
            txt_Name.Clear();
            txt_Address.Clear();
            txt_Email.Clear();
            txt_Dept.Clear();
            btn_Save.Enabled = false;
            btn_Cancel.Enabled = false;
            btn_Update.Enabled = true;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form FrMain = new Fr_Main();
            FrMain.Show();
            this.Hide();
        }

        private void lv_Reader_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lv_Reader.SelectedItems.Count > 0)
                {
                    ListViewItem lvi = lv_Reader.SelectedItems[lv_Reader.SelectedItems.Count - 1];
                    if (lvi != null)
                        foreach (ListViewItem lv in lv_Reader.SelectedItems)
                        {
                            txt_MaDocGia.Text = lv.SubItems[0].Text;
                            txt_Name.Text = lv.SubItems[1].Text;
                            dtp_Date.Value = DateTime.Parse(lv.SubItems[2].Text);
                            txt_Address.Text = lv.SubItems[3].Text;
                            txt_Email.Text = lv.SubItems[4].Text;
                            dtp_Create.Value = DateTime.Parse(lv.SubItems[5].Text);
                            dtp_Expired.Value = DateTime.Parse(lv.SubItems[6].Text);
                            txt_Dept.Text = lv.SubItems[7].Text;
                            btn_Update.Enabled = true;
                            btn_Save.Enabled = true;
                            btn_Cancel.Enabled = true;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Fr_DocGia_Load(object sender, EventArgs e)
        {
            loadDocGia();
            dtp_Expired.Value = DateTime.Now.AddYears(2);
            dtp_Create.Value = DateTime.Now;

        }

        private void btn_Sach_Click(object sender, EventArgs e)
        {
            Form FrSach = new Fr_Sach();
            FrSach.Show();
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

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            Form FrNhanVien = new Fr_NhanVien();
            FrNhanVien.Show();
            this.Hide();
        }
    }
}
