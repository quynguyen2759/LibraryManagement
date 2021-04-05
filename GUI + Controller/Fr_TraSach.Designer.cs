namespace QLThuVien.GUI___Controller
{
    partial class Fr_TraSach
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
            this.lv_SachMuon = new System.Windows.Forms.ListView();
            this.lv_CTPhieuMuon = new System.Windows.Forms.ListView();
            this.txt_TimPhieuMuon = new System.Windows.Forms.TextBox();
            this.btn_TimPhieuMuon = new System.Windows.Forms.Button();
            this.btn_TraSach = new System.Windows.Forms.Button();
            this.dtp_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.btn_Muon = new System.Windows.Forms.Button();
            this.btn_Sach = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_DocGia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_SachMuon
            // 
            this.lv_SachMuon.HideSelection = false;
            this.lv_SachMuon.Location = new System.Drawing.Point(259, 196);
            this.lv_SachMuon.Name = "lv_SachMuon";
            this.lv_SachMuon.Size = new System.Drawing.Size(546, 320);
            this.lv_SachMuon.TabIndex = 0;
            this.lv_SachMuon.UseCompatibleStateImageBehavior = false;
            this.lv_SachMuon.SelectedIndexChanged += new System.EventHandler(this.lv_SachMuon_SelectedIndexChanged);
            // 
            // lv_CTPhieuMuon
            // 
            this.lv_CTPhieuMuon.HideSelection = false;
            this.lv_CTPhieuMuon.Location = new System.Drawing.Point(885, 224);
            this.lv_CTPhieuMuon.Name = "lv_CTPhieuMuon";
            this.lv_CTPhieuMuon.Size = new System.Drawing.Size(368, 152);
            this.lv_CTPhieuMuon.TabIndex = 1;
            this.lv_CTPhieuMuon.UseCompatibleStateImageBehavior = false;
            this.lv_CTPhieuMuon.SelectedIndexChanged += new System.EventHandler(this.lv_CTPhieuMuon_SelectedIndexChanged);
            // 
            // txt_TimPhieuMuon
            // 
            this.txt_TimPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txt_TimPhieuMuon.Location = new System.Drawing.Point(260, 157);
            this.txt_TimPhieuMuon.Name = "txt_TimPhieuMuon";
            this.txt_TimPhieuMuon.Size = new System.Drawing.Size(274, 24);
            this.txt_TimPhieuMuon.TabIndex = 2;
            // 
            // btn_TimPhieuMuon
            // 
            this.btn_TimPhieuMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btn_TimPhieuMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_TimPhieuMuon.ForeColor = System.Drawing.Color.White;
            this.btn_TimPhieuMuon.Location = new System.Drawing.Point(540, 152);
            this.btn_TimPhieuMuon.Name = "btn_TimPhieuMuon";
            this.btn_TimPhieuMuon.Size = new System.Drawing.Size(115, 29);
            this.btn_TimPhieuMuon.TabIndex = 3;
            this.btn_TimPhieuMuon.Text = "Tìm phiếu";
            this.btn_TimPhieuMuon.UseVisualStyleBackColor = false;
            this.btn_TimPhieuMuon.Click += new System.EventHandler(this.btn_TimPhieuMuon_Click);
            // 
            // btn_TraSach
            // 
            this.btn_TraSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btn_TraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_TraSach.ForeColor = System.Drawing.Color.White;
            this.btn_TraSach.Location = new System.Drawing.Point(1035, 382);
            this.btn_TraSach.Name = "btn_TraSach";
            this.btn_TraSach.Size = new System.Drawing.Size(95, 31);
            this.btn_TraSach.TabIndex = 6;
            this.btn_TraSach.Text = "Trả sách";
            this.btn_TraSach.UseVisualStyleBackColor = false;
            this.btn_TraSach.Click += new System.EventHandler(this.btn_TraSach_Click);
            // 
            // dtp_NgayTra
            // 
            this.dtp_NgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dtp_NgayTra.Location = new System.Drawing.Point(978, 439);
            this.dtp_NgayTra.Name = "dtp_NgayTra";
            this.dtp_NgayTra.Size = new System.Drawing.Size(242, 24);
            this.dtp_NgayTra.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(366, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Quay lại";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_NhanVien);
            this.groupBox3.Controls.Add(this.btn_Muon);
            this.groupBox3.Controls.Add(this.btn_Sach);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btn_DocGia);
            this.groupBox3.Location = new System.Drawing.Point(6, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 469);
            this.groupBox3.TabIndex = 22;
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
            // btn_Muon
            // 
            this.btn_Muon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.btn_Muon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Muon.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_Muon.ForeColor = System.Drawing.Color.White;
            this.btn_Muon.Location = new System.Drawing.Point(11, 233);
            this.btn_Muon.Name = "btn_Muon";
            this.btn_Muon.Size = new System.Drawing.Size(179, 63);
            this.btn_Muon.TabIndex = 12;
            this.btn_Muon.Text = "Mượn sách";
            this.btn_Muon.UseVisualStyleBackColor = false;
            this.btn_Muon.Click += new System.EventHandler(this.btn_Muon_Click);
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
            this.btn_Sach.Click += new System.EventHandler(this.btn_Sach_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 11F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            this.button2.Location = new System.Drawing.Point(11, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 63);
            this.button2.TabIndex = 9;
            this.button2.Text = "Trả sách";
            this.button2.UseVisualStyleBackColor = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(909, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ngày trả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(663, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(267, 55);
            this.label9.TabIndex = 24;
            this.label9.Text = "TRẢ SÁCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(881, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sách đã mượn trong phiếu";
            // 
            // Fr_TraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QLThuVien.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1276, 652);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp_NgayTra);
            this.Controls.Add(this.btn_TraSach);
            this.Controls.Add(this.btn_TimPhieuMuon);
            this.Controls.Add(this.txt_TimPhieuMuon);
            this.Controls.Add(this.lv_CTPhieuMuon);
            this.Controls.Add(this.lv_SachMuon);
            this.Name = "Fr_TraSach";
            this.Text = "Fr_TraSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Fr_TraSach_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_SachMuon;
        private System.Windows.Forms.ListView lv_CTPhieuMuon;
        private System.Windows.Forms.TextBox txt_TimPhieuMuon;
        private System.Windows.Forms.Button btn_TimPhieuMuon;
        private System.Windows.Forms.Button btn_TraSach;
        private System.Windows.Forms.DateTimePicker dtp_NgayTra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Button btn_Muon;
        private System.Windows.Forms.Button btn_Sach;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_DocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
    }
}