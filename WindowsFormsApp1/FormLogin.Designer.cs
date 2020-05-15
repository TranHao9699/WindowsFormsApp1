namespace WindowsFormsApp1
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.labelTenForm = new System.Windows.Forms.Label();
            this.labelTenDangNhap = new System.Windows.Forms.Label();
            this.labelMatKhau = new System.Windows.Forms.Label();
            this.labelChanTrang = new System.Windows.Forms.Label();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.textBoxTenDangNhap = new System.Windows.Forms.TextBox();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxTieuDe = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.groupBoxTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 1;
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Location = new System.Drawing.Point(136, 25);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(271, 21);
            this.labelTieuDe.TabIndex = 2;
            this.labelTieuDe.Text = "TRƯỜNG ĐẠI HỌC MỎ  - ĐỊA CHẤT";
            this.labelTieuDe.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelTenForm
            // 
            this.labelTenForm.AutoSize = true;
            this.labelTenForm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTenForm.Location = new System.Drawing.Point(84, 25);
            this.labelTenForm.Name = "labelTenForm";
            this.labelTenForm.Size = new System.Drawing.Size(293, 32);
            this.labelTenForm.TabIndex = 3;
            this.labelTenForm.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // labelTenDangNhap
            // 
            this.labelTenDangNhap.AutoSize = true;
            this.labelTenDangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenDangNhap.Location = new System.Drawing.Point(87, 67);
            this.labelTenDangNhap.Name = "labelTenDangNhap";
            this.labelTenDangNhap.Size = new System.Drawing.Size(99, 17);
            this.labelTenDangNhap.TabIndex = 4;
            this.labelTenDangNhap.Text = "Tên đăng nhập";
            // 
            // labelMatKhau
            // 
            this.labelMatKhau.AutoSize = true;
            this.labelMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatKhau.Location = new System.Drawing.Point(87, 131);
            this.labelMatKhau.Name = "labelMatKhau";
            this.labelMatKhau.Size = new System.Drawing.Size(66, 17);
            this.labelMatKhau.TabIndex = 5;
            this.labelMatKhau.Text = "Mật khẩu";
            // 
            // labelChanTrang
            // 
            this.labelChanTrang.AutoSize = true;
            this.labelChanTrang.Location = new System.Drawing.Point(135, 243);
            this.labelChanTrang.Name = "labelChanTrang";
            this.labelChanTrang.Size = new System.Drawing.Size(180, 21);
            this.labelChanTrang.TabIndex = 6;
            this.labelChanTrang.Text = "QUẢN LÝ TIỀN LƯƠNG";
            this.labelChanTrang.Click += new System.EventHandler(this.labelChanTrang_Click);
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangNhap.Location = new System.Drawing.Point(90, 186);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(104, 25);
            this.buttonDangNhap.TabIndex = 7;
            this.buttonDangNhap.Text = "Đăng Nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(264, 186);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(100, 25);
            this.buttonThoat.TabIndex = 8;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // textBoxTenDangNhap
            // 
            this.textBoxTenDangNhap.Location = new System.Drawing.Point(90, 87);
            this.textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            this.textBoxTenDangNhap.Size = new System.Drawing.Size(274, 29);
            this.textBoxTenDangNhap.TabIndex = 9;
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Location = new System.Drawing.Point(90, 151);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(274, 29);
            this.textBoxMatKhau.TabIndex = 10;
            this.textBoxMatKhau.TextChanged += new System.EventHandler(this.textBoxMatKhau_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTenForm);
            this.groupBox1.Controls.Add(this.buttonDangNhap);
            this.groupBox1.Controls.Add(this.labelChanTrang);
            this.groupBox1.Controls.Add(this.buttonThoat);
            this.groupBox1.Controls.Add(this.textBoxMatKhau);
            this.groupBox1.Controls.Add(this.textBoxTenDangNhap);
            this.groupBox1.Controls.Add(this.labelTenDangNhap);
            this.groupBox1.Controls.Add(this.labelMatKhau);
            this.groupBox1.Location = new System.Drawing.Point(-31, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 266);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "\'\'\'\'";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaChi.Location = new System.Drawing.Point(137, 61);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(271, 38);
            this.labelDiaChi.TabIndex = 12;
            this.labelDiaChi.Text = "18 Phố Viên, P. Đức Thắng, Q. Bắc Từ Liêm, TP. Hà Nội";
            this.labelDiaChi.Click += new System.EventHandler(this.labelDiaChi_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::WindowsFormsApp1.Properties.Resources.Logo_Truong_Dai_hoc_Mo___Dia_chat;
            this.pictureBoxLogo.Location = new System.Drawing.Point(43, 22);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(78, 81);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBoxTieuDe
            // 
            this.groupBoxTieuDe.Controls.Add(this.pictureBoxLogo);
            this.groupBoxTieuDe.Controls.Add(this.labelDiaChi);
            this.groupBoxTieuDe.Controls.Add(this.labelTieuDe);
            this.groupBoxTieuDe.Location = new System.Drawing.Point(-39, -1);
            this.groupBoxTieuDe.Name = "groupBoxTieuDe";
            this.groupBoxTieuDe.Size = new System.Drawing.Size(468, 110);
            this.groupBoxTieuDe.TabIndex = 11;
            this.groupBoxTieuDe.TabStop = false;
            this.groupBoxTieuDe.Text = "\"\"";
            this.groupBoxTieuDe.Enter += new System.EventHandler(this.groupBoxTieuDe_Enter);
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(401, 353);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxTieuDe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.groupBoxTieuDe.ResumeLayout(false);
            this.groupBoxTieuDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.Label labelTenForm;
        private System.Windows.Forms.Label labelTenDangNhap;
        private System.Windows.Forms.Label labelMatKhau;
        private System.Windows.Forms.Label labelChanTrang;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.TextBox textBoxTenDangNhap;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.GroupBox groupBoxTieuDe;
    }
}