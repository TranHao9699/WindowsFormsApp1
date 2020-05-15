namespace WindowsFormsApp1
{
    partial class FormMain
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuItemHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNhomNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemThietLapHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBangLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTaoMoiBangLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDanhSachBangLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDonViCap2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTaoMoiDonViCap2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDanhSachDonViCap2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDonViCap3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTaoMoiDonViCap3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDanhSachDonViCap3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCanBo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTaoMoiCanBo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDanhSachCanBo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLuongChiTiet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLuongChiTietCacCanBo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLuongChiTietTheoDonVi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLuongTongHop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLuongTongHopTheoMaNgach = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLuongTongHopTheoDonVi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHuongDanSuDung = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHeThong,
            this.menuItemQuanLy,
            this.menuItemBaoCao,
            this.menuItemTimKiem,
            this.menuItemTroGiup});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuItemHeThong
            // 
            this.menuItemHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNguoiDung,
            this.menuItemNhomNguoiDung,
            this.menuItemThietLapHeThong,
            this.menuItemDangXuat});
            this.menuItemHeThong.Name = "menuItemHeThong";
            this.menuItemHeThong.Size = new System.Drawing.Size(72, 20);
            this.menuItemHeThong.Text = "&Hệ Thống";
            // 
            // menuItemNguoiDung
            // 
            this.menuItemNguoiDung.Name = "menuItemNguoiDung";
            this.menuItemNguoiDung.Size = new System.Drawing.Size(180, 22);
            this.menuItemNguoiDung.Text = "Người dùng";
            // 
            // menuItemNhomNguoiDung
            // 
            this.menuItemNhomNguoiDung.Name = "menuItemNhomNguoiDung";
            this.menuItemNhomNguoiDung.Size = new System.Drawing.Size(180, 22);
            this.menuItemNhomNguoiDung.Text = "Nhóm người dùng";
            this.menuItemNhomNguoiDung.Click += new System.EventHandler(this.Group_Click);
            // 
            // menuItemThietLapHeThong
            // 
            this.menuItemThietLapHeThong.Name = "menuItemThietLapHeThong";
            this.menuItemThietLapHeThong.Size = new System.Drawing.Size(180, 22);
            this.menuItemThietLapHeThong.Text = "Thiết lập hệ thống";
            // 
            // menuItemDangXuat
            // 
            this.menuItemDangXuat.Name = "menuItemDangXuat";
            this.menuItemDangXuat.Size = new System.Drawing.Size(180, 22);
            this.menuItemDangXuat.Text = "Đăng xuất";
            // 
            // menuItemQuanLy
            // 
            this.menuItemQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBangLuong,
            this.menuItemDonViCap2,
            this.menuItemDonViCap3,
            this.menuItemCanBo});
            this.menuItemQuanLy.Name = "menuItemQuanLy";
            this.menuItemQuanLy.Size = new System.Drawing.Size(65, 20);
            this.menuItemQuanLy.Text = "&Quản Lý ";
            // 
            // menuItemBangLuong
            // 
            this.menuItemBangLuong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTaoMoiBangLuong,
            this.menuItemDanhSachBangLuong});
            this.menuItemBangLuong.Name = "menuItemBangLuong";
            this.menuItemBangLuong.Size = new System.Drawing.Size(139, 22);
            this.menuItemBangLuong.Text = "Bảng lương";
            // 
            // menuItemTaoMoiBangLuong
            // 
            this.menuItemTaoMoiBangLuong.Name = "menuItemTaoMoiBangLuong";
            this.menuItemTaoMoiBangLuong.Size = new System.Drawing.Size(193, 22);
            this.menuItemTaoMoiBangLuong.Text = "Tạo mới bảng lương ";
            // 
            // menuItemDanhSachBangLuong
            // 
            this.menuItemDanhSachBangLuong.Name = "menuItemDanhSachBangLuong";
            this.menuItemDanhSachBangLuong.Size = new System.Drawing.Size(193, 22);
            this.menuItemDanhSachBangLuong.Text = "Danh sách bảng lương";
            // 
            // menuItemDonViCap2
            // 
            this.menuItemDonViCap2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTaoMoiDonViCap2,
            this.menuItemDanhSachDonViCap2});
            this.menuItemDonViCap2.Name = "menuItemDonViCap2";
            this.menuItemDonViCap2.Size = new System.Drawing.Size(139, 22);
            this.menuItemDonViCap2.Text = "Đơn vị cấp 2";
            // 
            // menuItemTaoMoiDonViCap2
            // 
            this.menuItemTaoMoiDonViCap2.Name = "menuItemTaoMoiDonViCap2";
            this.menuItemTaoMoiDonViCap2.Size = new System.Drawing.Size(196, 22);
            this.menuItemTaoMoiDonViCap2.Text = "Tạo mới đơn vị cấp 2";
            // 
            // menuItemDanhSachDonViCap2
            // 
            this.menuItemDanhSachDonViCap2.Name = "menuItemDanhSachDonViCap2";
            this.menuItemDanhSachDonViCap2.Size = new System.Drawing.Size(196, 22);
            this.menuItemDanhSachDonViCap2.Text = "Danh sách đơn vị cấp 2";
            // 
            // menuItemDonViCap3
            // 
            this.menuItemDonViCap3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTaoMoiDonViCap3,
            this.menuItemDanhSachDonViCap3});
            this.menuItemDonViCap3.Name = "menuItemDonViCap3";
            this.menuItemDonViCap3.Size = new System.Drawing.Size(139, 22);
            this.menuItemDonViCap3.Text = "Đơn vị cấp 3";
            // 
            // menuItemTaoMoiDonViCap3
            // 
            this.menuItemTaoMoiDonViCap3.Name = "menuItemTaoMoiDonViCap3";
            this.menuItemTaoMoiDonViCap3.Size = new System.Drawing.Size(196, 22);
            this.menuItemTaoMoiDonViCap3.Text = "Tạo mới đơn vị cấp 3";
            // 
            // menuItemDanhSachDonViCap3
            // 
            this.menuItemDanhSachDonViCap3.Name = "menuItemDanhSachDonViCap3";
            this.menuItemDanhSachDonViCap3.Size = new System.Drawing.Size(196, 22);
            this.menuItemDanhSachDonViCap3.Text = "Danh sách đơn vị cấp 3";
            // 
            // menuItemCanBo
            // 
            this.menuItemCanBo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemTaoMoiCanBo,
            this.menuItemDanhSachCanBo});
            this.menuItemCanBo.Name = "menuItemCanBo";
            this.menuItemCanBo.Size = new System.Drawing.Size(139, 22);
            this.menuItemCanBo.Text = "Cán bộ";
            // 
            // menuItemTaoMoiCanBo
            // 
            this.menuItemTaoMoiCanBo.Name = "menuItemTaoMoiCanBo";
            this.menuItemTaoMoiCanBo.Size = new System.Drawing.Size(168, 22);
            this.menuItemTaoMoiCanBo.Text = "Tạo mới cán bộ ";
            // 
            // menuItemDanhSachCanBo
            // 
            this.menuItemDanhSachCanBo.Name = "menuItemDanhSachCanBo";
            this.menuItemDanhSachCanBo.Size = new System.Drawing.Size(168, 22);
            this.menuItemDanhSachCanBo.Text = "Danh sách cán bộ";
            // 
            // menuItemBaoCao
            // 
            this.menuItemBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLuongChiTiet,
            this.menuItemLuongTongHop});
            this.menuItemBaoCao.Name = "menuItemBaoCao";
            this.menuItemBaoCao.Size = new System.Drawing.Size(63, 20);
            this.menuItemBaoCao.Text = "&Báo Cáo";
            // 
            // menuItemLuongChiTiet
            // 
            this.menuItemLuongChiTiet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLuongChiTietCacCanBo,
            this.menuItemLuongChiTietTheoDonVi});
            this.menuItemLuongChiTiet.Name = "menuItemLuongChiTiet";
            this.menuItemLuongChiTiet.Size = new System.Drawing.Size(160, 22);
            this.menuItemLuongChiTiet.Text = "Lương chi tiết";
            // 
            // menuItemLuongChiTietCacCanBo
            // 
            this.menuItemLuongChiTietCacCanBo.Name = "menuItemLuongChiTietCacCanBo";
            this.menuItemLuongChiTietCacCanBo.Size = new System.Drawing.Size(210, 22);
            this.menuItemLuongChiTietCacCanBo.Text = "Lương chi tiết các cán bộ";
            // 
            // menuItemLuongChiTietTheoDonVi
            // 
            this.menuItemLuongChiTietTheoDonVi.Name = "menuItemLuongChiTietTheoDonVi";
            this.menuItemLuongChiTietTheoDonVi.Size = new System.Drawing.Size(210, 22);
            this.menuItemLuongChiTietTheoDonVi.Text = "Lương chi tiết theo đơn vị";
            this.menuItemLuongChiTietTheoDonVi.Click += new System.EventHandler(this.lươngChiTiếtTheoToolStripMenuItem_Click);
            // 
            // menuItemLuongTongHop
            // 
            this.menuItemLuongTongHop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLuongTongHopTheoMaNgach,
            this.menuItemLuongTongHopTheoDonVi});
            this.menuItemLuongTongHop.Name = "menuItemLuongTongHop";
            this.menuItemLuongTongHop.Size = new System.Drawing.Size(160, 22);
            this.menuItemLuongTongHop.Text = "Lương tổng hợp";
            // 
            // menuItemLuongTongHopTheoMaNgach
            // 
            this.menuItemLuongTongHopTheoMaNgach.Name = "menuItemLuongTongHopTheoMaNgach";
            this.menuItemLuongTongHopTheoMaNgach.Size = new System.Drawing.Size(243, 22);
            this.menuItemLuongTongHopTheoMaNgach.Text = "Lương tổng hợp theo mã ngạch";
            // 
            // menuItemLuongTongHopTheoDonVi
            // 
            this.menuItemLuongTongHopTheoDonVi.Name = "menuItemLuongTongHopTheoDonVi";
            this.menuItemLuongTongHopTheoDonVi.Size = new System.Drawing.Size(243, 22);
            this.menuItemLuongTongHopTheoDonVi.Text = "Lương tổng hợp theo đơn vị";
            // 
            // menuItemTimKiem
            // 
            this.menuItemTimKiem.Name = "menuItemTimKiem";
            this.menuItemTimKiem.Size = new System.Drawing.Size(70, 20);
            this.menuItemTimKiem.Text = "&Tìm Kiếm";
            // 
            // menuItemTroGiup
            // 
            this.menuItemTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHuongDanSuDung,
            this.menuItemGioiThieu});
            this.menuItemTroGiup.Name = "menuItemTroGiup";
            this.menuItemTroGiup.Size = new System.Drawing.Size(64, 20);
            this.menuItemTroGiup.Text = "T&rợ Giúp";
            // 
            // menuItemHuongDanSuDung
            // 
            this.menuItemHuongDanSuDung.Name = "menuItemHuongDanSuDung";
            this.menuItemHuongDanSuDung.Size = new System.Drawing.Size(180, 22);
            this.menuItemHuongDanSuDung.Text = "Hướng dẫn sử dụng";
            // 
            // menuItemGioiThieu
            // 
            this.menuItemGioiThieu.Name = "menuItemGioiThieu";
            this.menuItemGioiThieu.Size = new System.Drawing.Size(180, 22);
            this.menuItemGioiThieu.Text = "Giới thiệu";
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 428);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(800, 22);
            this.statusMain.TabIndex = 1;
            this.statusMain.Text = "statusStrip1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "FormMain";
            this.Text = "Bài thực hành Lập Trình .NET1 - Phần mềm Quản lý Tiền lương";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuItemNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem menuItemNhomNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem menuItemThietLapHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuItemDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuItemBangLuong;
        private System.Windows.Forms.ToolStripMenuItem menuItemTaoMoiBangLuong;
        private System.Windows.Forms.ToolStripMenuItem menuItemDanhSachBangLuong;
        private System.Windows.Forms.ToolStripMenuItem menuItemDonViCap2;
        private System.Windows.Forms.ToolStripMenuItem menuItemTaoMoiDonViCap2;
        private System.Windows.Forms.ToolStripMenuItem menuItemDanhSachDonViCap2;
        private System.Windows.Forms.ToolStripMenuItem menuItemDonViCap3;
        private System.Windows.Forms.ToolStripMenuItem menuItemTaoMoiDonViCap3;
        private System.Windows.Forms.ToolStripMenuItem menuItemDanhSachDonViCap3;
        private System.Windows.Forms.ToolStripMenuItem menuItemCanBo;
        private System.Windows.Forms.ToolStripMenuItem menuItemTaoMoiCanBo;
        private System.Windows.Forms.ToolStripMenuItem menuItemDanhSachCanBo;
        private System.Windows.Forms.ToolStripMenuItem menuItemBaoCao;
        private System.Windows.Forms.ToolStripMenuItem menuItemLuongChiTiet;
        private System.Windows.Forms.ToolStripMenuItem menuItemLuongChiTietCacCanBo;
        private System.Windows.Forms.ToolStripMenuItem menuItemLuongChiTietTheoDonVi;
        private System.Windows.Forms.ToolStripMenuItem menuItemLuongTongHop;
        private System.Windows.Forms.ToolStripMenuItem menuItemTimKiem;
        private System.Windows.Forms.ToolStripMenuItem menuItemTroGiup;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemLuongTongHopTheoMaNgach;
        private System.Windows.Forms.ToolStripMenuItem menuItemLuongTongHopTheoDonVi;
        private System.Windows.Forms.ToolStripMenuItem menuItemHuongDanSuDung;
        private System.Windows.Forms.ToolStripMenuItem menuItemGioiThieu;
    }
}

