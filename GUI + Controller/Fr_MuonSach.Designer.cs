namespace QLThuVien.GUI___Controller
{
    partial class Fr_MuonSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_Sach = new System.Windows.Forms.ListView();
            this.lv_DocGia = new System.Windows.Forms.ListView();
            this.txt_MaDocGia = new System.Windows.Forms.TextBox();
            this.txt_MaPhieuMuon = new System.Windows.Forms.TextBox();
            this.dtp_NgayMuon = new System.Windows.Forms.DateTimePicker();
            this.btn_MuonSach = new System.Windows.Forms.Button();
            this.lvGioSach = new System.Windows.Forms.ListView();
            this.btn_GioSach = new System.Windows.Forms.Button();
            this.txt_TenDocGia = new System.Windows.Forms.TextBox();
            this.lv_PhieuMuon = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_BoSachCanMuon = new System.Windows.Forms.Button();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.txt_TimDocGia = new System.Windows.Forms.TextBox();
            this.btn_TimSach = new System.Windows.Forms.Button();
            this.btn_TimDocGia = new System.Windows.Forms.Button();
            this.txt_TimSach = new System.Windows.Forms.TextBox();
            this.dtp_NgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.btn_TraSach = new System.Windows.Forms.Button();
            this.btn_Sach = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_DocGia = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_Sach
            // 
            this.lv_Sach.HideSelection = false;
            this.lv_Sach.Location = new System.Drawing.Point(282, 402);
            this.lv_Sach.Name = "lv_Sach";
            this.lv_Sach.Size = new System.Drawing.Size(409, 184);
            this.lv_Sach.TabIndex = 0;
            this.lv_Sach.UseCompatibleStateImageBehavior = false;
            this.lv_Sach.SelectedIndexChanged += new System.EventHandler(this.lv_Sach_SelectedIndexChanged);
            // 
            // lv_DocGia
            // 
            this.lv_DocGia.HideSelection = false;
            this.lv_DocGia.Location = new System.Drawing.Point(282, 219);
            this.lv_DocGia.Name = "lv_DocGia";
            this.lv_DocGia.Size = new System.Drawing.Size(409, 140);
            this.lv_DocGia.TabIndex = 1;
            this.lv_DocGia.UseCompatibleStateImageBehavior = false;
            this.lv_DocGia.SelectedIndexChanged += new System.EventHandler(this.lv_DocGia_SelectedIndexChanged);
            // 
            // txt_MaDocGia
            // 
            this.txt_MaDocGia.Enabled = false;
            this.txt_MaDocGia.Location = new System.Drawing.Point(136, 44);
            this.txt_MaDocGia.Name = "txt_MaDocGia";
            this.txt_MaDocGia.Size = new System.Drawing.Size(208, 24);
            this.txt_MaDocGia.TabIndex = 4;
            // 
            // txt_MaPhieuMuon
            // 
            this.txt_MaPhieuMuon.Enabled = false;
            this.txt_MaPhieuMuon.Location = new System.Drawing.Point(161, 55);
            this.txt_MaPhieuMuon.Name = "txt_MaPhieuMuon";
            this.txt_MaPhieuMuon.Size = new System.Drawing.Size(214, 24);
            this.txt_MaPhieuMuon.TabIndex = 5;
            // 
            // dtp_NgayMuon
            // 
            this.dtp_NgayMuon.Enabled = false;
            this.dtp_NgayMuon.Location = new System.Drawing.Point(161, 235);
            this.dtp_NgayMuon.Name = "dtp_NgayMuon";
            this.dtp_NgayMuon.Size = new System.Drawing.Size(230, 24);
            this.dtp_NgayMuon.TabIndex = 6;
            // 
            // btn_MuonSach
            // 
            this.btn_MuonSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btn_MuonSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MuonSach.ForeColor = System.Drawing.Color.White;
            this.btn_MuonSach.Location = new System.Drawing.Point(53, 435);
            this.btn_MuonSach.Name = "btn_MuonSach";
            this.btn_MuonSach.Size = new System.Drawing.Size(344, 34);
            this.btn_MuonSach.TabIndex = 7;
            this.btn_MuonSach.Text = "Mượn sách";
            this.btn_MuonSach.UseVisualStyleBackColor = false;
            this.btn_MuonSach.Click += new System.EventHandler(this.btn_MuonSach_Click);
            // 
            // lvGioSach
            // 
            this.lvGioSach.HideSelection = false;
            this.lvGioSach.Location = new System.Drawing.Point(161, 297);
            this.lvGioSach.Name = "lvGioSach";
            this.lvGioSach.Size = new System.Drawing.Size(229, 122);
            this.lvGioSach.TabIndex = 8;
            this.lvGioSach.UseCompatibleStateImageBehavior = false;
            // 
            // btn_GioSach
            // 
            this.btn_GioSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btn_GioSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GioSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_GioSach.ForeColor = System.Drawing.Color.White;
            this.btn_GioSach.Location = new System.Drawing.Point(540, 605);
            this.btn_GioSach.Name = "btn_GioSach";
            this.btn_GioSach.Size = new System.Drawing.Size(151, 34);
            this.btn_GioSach.TabIndex = 9;
            this.btn_GioSach.Text = "Thêm vào giỏ mượn";
            this.btn_GioSach.UseVisualStyleBackColor = false;
            this.btn_GioSach.Click += new System.EventHandler(this.btn_GioSach_Click);
            // 
            // txt_TenDocGia
            // 
            this.txt_TenDocGia.Enabled = false;
            this.txt_TenDocGia.Location = new System.Drawing.Point(136, 80);
            this.txt_TenDocGia.Name = "txt_TenDocGia";
            this.txt_TenDocGia.Size = new System.Drawing.Size(208, 24);
            this.txt_TenDocGia.TabIndex = 10;
            // 
            // lv_PhieuMuon
            // 
            this.lv_PhieuMuon.HideSelection = false;
            this.lv_PhieuMuon.Location = new System.Drawing.Point(193, -18);
            this.lv_PhieuMuon.Name = "lv_PhieuMuon";
            this.lv_PhieuMuon.Size = new System.Drawing.Size(378, 97);
            this.lv_PhieuMuon.TabIndex = 11;
            this.lv_PhieuMuon.UseCompatibleStateImageBehavior = false;
            this.lv_PhieuMuon.Visible = false;
            this.lv_PhieuMuon.SelectedIndexChanged += new System.EventHandler(this.lv_PhieuMuon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã phiếu mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã độc giả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_MaDocGia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_TenDocGia);
            this.groupBox1.Location = new System.Drawing.Point(25, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 127);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin độc giả";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên độc giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ngày mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sách cần mượn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btn_BoSachCanMuon);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lvGioSach);
            this.groupBox2.Controls.Add(this.btn_MuonSach);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_MaPhieuMuon);
            this.groupBox2.Controls.Add(this.dtp_NgayMuon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox2.Location = new System.Drawing.Point(743, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 502);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mượn sách";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_BoSachCanMuon
            // 
            this.btn_BoSachCanMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btn_BoSachCanMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BoSachCanMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_BoSachCanMuon.ForeColor = System.Drawing.Color.White;
            this.btn_BoSachCanMuon.Location = new System.Drawing.Point(53, 363);
            this.btn_BoSachCanMuon.Name = "btn_BoSachCanMuon";
            this.btn_BoSachCanMuon.Size = new System.Drawing.Size(75, 28);
            this.btn_BoSachCanMuon.TabIndex = 21;
            this.btn_BoSachCanMuon.Text = "Bỏ ra";
            this.btn_BoSachCanMuon.UseVisualStyleBackColor = false;
            this.btn_BoSachCanMuon.Click += new System.EventHandler(this.btn_BoSachCanMuon_Click);
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btn_QuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_QuayLai.ForeColor = System.Drawing.Color.White;
            this.btn_QuayLai.Location = new System.Drawing.Point(63, 580);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(99, 41);
            this.btn_QuayLai.TabIndex = 16;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // txt_TimDocGia
            // 
            this.txt_TimDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_TimDocGia.Location = new System.Drawing.Point(282, 192);
            this.txt_TimDocGia.Name = "txt_TimDocGia";
            this.txt_TimDocGia.Size = new System.Drawing.Size(279, 24);
            this.txt_TimDocGia.TabIndex = 17;
            // 
            // btn_TimSach
            // 
            this.btn_TimSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btn_TimSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_TimSach.ForeColor = System.Drawing.Color.White;
            this.btn_TimSach.Location = new System.Drawing.Point(567, 372);
            this.btn_TimSach.Name = "btn_TimSach";
            this.btn_TimSach.Size = new System.Drawing.Size(124, 27);
            this.btn_TimSach.TabIndex = 18;
            this.btn_TimSach.Text = "Tìm Sách";
            this.btn_TimSach.UseVisualStyleBackColor = false;
            this.btn_TimSach.Click += new System.EventHandler(this.btn_TimSach_Click);
            // 
            // btn_TimDocGia
            // 
            this.btn_TimDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btn_TimDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_TimDocGia.ForeColor = System.Drawing.Color.White;
            this.btn_TimDocGia.Location = new System.Drawing.Point(565, 190);
            this.btn_TimDocGia.Name = "btn_TimDocGia";
            this.btn_TimDocGia.Size = new System.Drawing.Size(126, 28);
            this.btn_TimDocGia.TabIndex = 19;
            this.btn_TimDocGia.Text = "Tìm độc giả";
            this.btn_TimDocGia.UseVisualStyleBackColor = false;
            this.btn_TimDocGia.Click += new System.EventHandler(this.btn_TimDocGia_Click);
            // 
            // txt_TimSach
            // 
            this.txt_TimSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_TimSach.Location = new System.Drawing.Point(282, 372);
            this.txt_TimSach.Name = "txt_TimSach";
            this.txt_TimSach.Size = new System.Drawing.Size(279, 24);
            this.txt_TimSach.TabIndex = 20;
            // 
            // dtp_NgayHetHan
            // 
            this.dtp_NgayHetHan.Enabled = false;
            this.dtp_NgayHetHan.Location = new System.Drawing.Point(712, 70);
            this.dtp_NgayHetHan.Name = "dtp_NgayHetHan";
            this.dtp_NgayHetHan.Size = new System.Drawing.Size(199, 20);
            this.dtp_NgayHetHan.TabIndex = 17;
            this.dtp_NgayHetHan.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_NhanVien);
            this.groupBox3.Controls.Add(this.btn_TraSach);
            this.groupBox3.Controls.Add(this.btn_Sach);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btn_DocGia);
            this.groupBox3.Location = new System.Drawing.Point(12, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 469);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btn_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhanVien.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_NhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_NhanVien.Location = new System.Drawing.Point(11, 373);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(179, 63);
            this.btn_NhanVien.TabIndex = 13;
            this.btn_NhanVien.Text = "Quản lý nhân viên";
            this.btn_NhanVien.UseVisualStyleBackColor = false;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // btn_TraSach
            // 
            this.btn_TraSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btn_TraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TraSach.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_TraSach.ForeColor = System.Drawing.Color.White;
            this.btn_TraSach.Location = new System.Drawing.Point(11, 304);
            this.btn_TraSach.Name = "btn_TraSach";
            this.btn_TraSach.Size = new System.Drawing.Size(179, 63);
            this.btn_TraSach.TabIndex = 12;
            this.btn_TraSach.Text = "Trả sách";
            this.btn_TraSach.UseVisualStyleBackColor = false;
            this.btn_TraSach.Click += new System.EventHandler(this.btn_TraSach_Click);
            // 
            // btn_Sach
            // 
            this.btn_Sach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btn_Sach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Sach.ForeColor = System.Drawing.Color.White;
            this.btn_Sach.Location = new System.Drawing.Point(11, 95);
            this.btn_Sach.Name = "btn_Sach";
            this.btn_Sach.Size = new System.Drawing.Size(179, 63);
            this.btn_Sach.TabIndex = 11;
            this.btn_Sach.Text = "Quản lý sách";
            this.btn_Sach.UseVisualStyleBackColor = false;
            this.btn_Sach.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 11F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.button1.Location = new System.Drawing.Point(11, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "Mượn sách";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(46, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "THƯ VIỆN";
            // 
            // btn_DocGia
            // 
            this.btn_DocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btn_DocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DocGia.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_DocGia.ForeColor = System.Drawing.Color.White;
            this.btn_DocGia.Location = new System.Drawing.Point(11, 164);
            this.btn_DocGia.Name = "btn_DocGia";
            this.btn_DocGia.Size = new System.Drawing.Size(179, 63);
            this.btn_DocGia.TabIndex = 10;
            this.btn_DocGia.Text = "Quản lý độc giả";
            this.btn_DocGia.UseVisualStyleBackColor = false;
            this.btn_DocGia.Click += new System.EventHandler(this.btn_DocGia_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(272, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(318, 55);
            this.label9.TabIndex = 22;
            this.label9.Text = "MƯỢN SÁCH";
            // 
            // Fr_MuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QLThuVien.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1182, 677);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtp_NgayHetHan);
            this.Controls.Add(this.txt_TimSach);
            this.Controls.Add(this.btn_TimDocGia);
            this.Controls.Add(this.btn_TimSach);
            this.Controls.Add(this.txt_TimDocGia);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lv_PhieuMuon);
            this.Controls.Add(this.btn_GioSach);
            this.Controls.Add(this.lv_DocGia);
            this.Controls.Add(this.lv_Sach);
            this.Name = "Fr_MuonSach";
            this.Text = "MuonSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fr_MuonSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Sach;
        private System.Windows.Forms.ListView lv_DocGia;
        private System.Windows.Forms.TextBox txt_MaDocGia;
        private System.Windows.Forms.TextBox txt_MaPhieuMuon;
        private System.Windows.Forms.DateTimePicker dtp_NgayMuon;
        private System.Windows.Forms.Button btn_MuonSach;
        private System.Windows.Forms.ListView lvGioSach;
        private System.Windows.Forms.Button btn_GioSach;
        private System.Windows.Forms.TextBox txt_TenDocGia;
        private System.Windows.Forms.ListView lv_PhieuMuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.TextBox txt_TimDocGia;
        private System.Windows.Forms.Button btn_TimSach;
        private System.Windows.Forms.Button btn_TimDocGia;
        private System.Windows.Forms.TextBox txt_TimSach;
        private System.Windows.Forms.Button btn_BoSachCanMuon;
        private System.Windows.Forms.DateTimePicker dtp_NgayHetHan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Button btn_TraSach;
        private System.Windows.Forms.Button btn_Sach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_DocGia;
        private System.Windows.Forms.Label label9;
    }
}