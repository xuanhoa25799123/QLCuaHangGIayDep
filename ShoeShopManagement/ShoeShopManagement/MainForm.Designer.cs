
namespace ShoeShopManagement
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.gvSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHuyDon = new System.Windows.Forms.Button();
            this.btnLuuDon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTongThanhToan = new System.Windows.Forms.TextBox();
            this.txtTongTienHang = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbTenDangNhap = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbChiNhanh = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbVaiTro = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIDCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSizeCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuongCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHuy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietDonHang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdmin,
            this.quảnLýToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmAdmin
            // 
            this.tsmAdmin.Name = "tsmAdmin";
            this.tsmAdmin.Size = new System.Drawing.Size(55, 20);
            this.tsmAdmin.Text = "Admin";
            this.tsmAdmin.Click += new System.EventHandler(this.tsmAdmin_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnPhẩmToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.nhậpHàngToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.nhậpHàngToolStripMenuItem.Text = "Thể loại";
            this.nhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.nhậpHàngToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            this.báoCáoToolStripMenuItem.Click += new System.EventHandler(this.báoCáoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm theo tên sản phẩm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(6, 25);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(330, 20);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaiLai.Location = new System.Drawing.Point(339, 25);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(156, 20);
            this.btnTaiLai.TabIndex = 4;
            this.btnTaiLai.Text = "Tải lại danh sách sản phẩm";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // gvSanPham
            // 
            this.gvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clTenSanPham,
            this.clSize,
            this.clGia,
            this.clSoLuong});
            this.gvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSanPham.Location = new System.Drawing.Point(3, 66);
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.gvSanPham, 2);
            this.gvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSanPham.Size = new System.Drawing.Size(498, 506);
            this.gvSanPham.TabIndex = 5;
            this.gvSanPham.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSanPham_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Location = new System.Drawing.Point(507, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại *";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên *";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT.Location = new System.Drawing.Point(362, 25);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(169, 20);
            this.txtSDT.TabIndex = 3;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHoTen.Location = new System.Drawing.Point(73, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gvChiTietDonHang);
            this.groupBox2.Location = new System.Drawing.Point(507, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 356);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết đơn hàng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // gvChiTietDonHang
            // 
            this.gvChiTietDonHang.AllowUserToAddRows = false;
            this.gvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvChiTietDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIDCT,
            this.clTenSP,
            this.clGiaCT,
            this.clSizeCT,
            this.clSoLuongCT,
            this.clHuy});
            this.gvChiTietDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvChiTietDonHang.Location = new System.Drawing.Point(3, 16);
            this.gvChiTietDonHang.Name = "gvChiTietDonHang";
            this.gvChiTietDonHang.RowHeadersVisible = false;
            this.gvChiTietDonHang.Size = new System.Drawing.Size(534, 337);
            this.gvChiTietDonHang.TabIndex = 0;
            this.gvChiTietDonHang.DataSourceChanged += new System.EventHandler(this.gvChiTietDonHang_DataSourceChanged);
            this.gvChiTietDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvChiTietDonHang_CellContentClick);
            this.gvChiTietDonHang.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvChiTietDonHang_CellValueChanged);
            this.gvChiTietDonHang.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.gvChiTietDonHang_RowsAdded);
            this.gvChiTietDonHang.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gvChiTietDonHang_RowsRemoved);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnHuyDon);
            this.groupBox3.Controls.Add(this.btnLuuDon);
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.txtTongThanhToan);
            this.groupBox3.Controls.Add(this.txtTongTienHang);
            this.groupBox3.Controls.Add(this.txtGiamGia);
            this.groupBox3.Controls.Add(this.txtNgayLap);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(507, 428);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 144);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng kết và hóa đơn";
            // 
            // btnHuyDon
            // 
            this.btnHuyDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyDon.Location = new System.Drawing.Point(310, 107);
            this.btnHuyDon.Name = "btnHuyDon";
            this.btnHuyDon.Size = new System.Drawing.Size(75, 23);
            this.btnHuyDon.TabIndex = 3;
            this.btnHuyDon.Text = "Hủy đơn";
            this.btnHuyDon.UseVisualStyleBackColor = true;
            this.btnHuyDon.Click += new System.EventHandler(this.btnHuyDon_Click);
            // 
            // btnLuuDon
            // 
            this.btnLuuDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuDon.Location = new System.Drawing.Point(391, 107);
            this.btnLuuDon.Name = "btnLuuDon";
            this.btnLuuDon.Size = new System.Drawing.Size(86, 23);
            this.btnLuuDon.TabIndex = 3;
            this.btnLuuDon.Text = "Lưu đơn hàng";
            this.btnLuuDon.UseVisualStyleBackColor = true;
            this.btnLuuDon.Click += new System.EventHandler(this.btnLuuDon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(483, 107);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(54, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTongThanhToan
            // 
            this.txtTongThanhToan.Location = new System.Drawing.Point(107, 76);
            this.txtTongThanhToan.Name = "txtTongThanhToan";
            this.txtTongThanhToan.ReadOnly = true;
            this.txtTongThanhToan.Size = new System.Drawing.Size(179, 20);
            this.txtTongThanhToan.TabIndex = 1;
            // 
            // txtTongTienHang
            // 
            this.txtTongTienHang.Location = new System.Drawing.Point(107, 50);
            this.txtTongTienHang.Name = "txtTongTienHang";
            this.txtTongTienHang.ReadOnly = true;
            this.txtTongTienHang.Size = new System.Drawing.Size(179, 20);
            this.txtTongTienHang.TabIndex = 1;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGiamGia.Location = new System.Drawing.Point(362, 50);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(146, 20);
            this.txtGiamGia.TabIndex = 1;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(107, 24);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.ReadOnly = true;
            this.txtNgayLap.Size = new System.Drawing.Size(179, 20);
            this.txtNgayLap.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tổng thanh toán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng tiền hàng (A)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(292, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "= A + B ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(292, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Giảm giá (B)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày lập";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbTenDangNhap,
            this.lbChiNhanh,
            this.lbVaiTro});
            this.statusStrip1.Location = new System.Drawing.Point(0, 599);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1050, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(91, 17);
            this.lbTenDangNhap.Text = "Tên đăng nhập: ";
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(68, 17);
            this.lbChiNhanh.Text = "Chi nhánh: ";
            // 
            // lbVaiTro
            // 
            this.lbVaiTro.Name = "lbVaiTro";
            this.lbVaiTro.Size = new System.Drawing.Size(46, 17);
            this.lbVaiTro.Text = "Vai trò: ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnTaiLai);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 57);
            this.panel1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.09524F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.90476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gvSanPham, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.95652F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.95652F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.91304F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 575);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "%";
            // 
            // clID
            // 
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "ID";
            this.clID.Name = "clID";
            this.clID.Width = 30;
            // 
            // clTenSanPham
            // 
            this.clTenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clTenSanPham.DataPropertyName = "Name";
            this.clTenSanPham.HeaderText = "Tên sản phẩm";
            this.clTenSanPham.Name = "clTenSanPham";
            this.clTenSanPham.Width = 250;
            // 
            // clSize
            // 
            this.clSize.DataPropertyName = "Size";
            this.clSize.HeaderText = "Size";
            this.clSize.Name = "clSize";
            this.clSize.Width = 50;
            // 
            // clGia
            // 
            this.clGia.DataPropertyName = "Price";
            this.clGia.HeaderText = "GIá";
            this.clGia.Name = "clGia";
            this.clGia.Width = 80;
            // 
            // clSoLuong
            // 
            this.clSoLuong.DataPropertyName = "Quantity";
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.Width = 80;
            // 
            // clIDCT
            // 
            this.clIDCT.DataPropertyName = "ID";
            this.clIDCT.HeaderText = "ID";
            this.clIDCT.Name = "clIDCT";
            this.clIDCT.Width = 50;
            // 
            // clTenSP
            // 
            this.clTenSP.DataPropertyName = "TenSP";
            this.clTenSP.HeaderText = "Tên sản phẩm";
            this.clTenSP.Name = "clTenSP";
            this.clTenSP.ReadOnly = true;
            this.clTenSP.Width = 250;
            // 
            // clGiaCT
            // 
            this.clGiaCT.DataPropertyName = "Gia";
            this.clGiaCT.HeaderText = "Giá";
            this.clGiaCT.Name = "clGiaCT";
            this.clGiaCT.ReadOnly = true;
            this.clGiaCT.Width = 50;
            // 
            // clSizeCT
            // 
            this.clSizeCT.DataPropertyName = "Size";
            this.clSizeCT.HeaderText = "Size";
            this.clSizeCT.Name = "clSizeCT";
            this.clSizeCT.ReadOnly = true;
            this.clSizeCT.Width = 50;
            // 
            // clSoLuongCT
            // 
            this.clSoLuongCT.DataPropertyName = "SoLuong";
            this.clSoLuongCT.HeaderText = "Số lượng";
            this.clSoLuongCT.Name = "clSoLuongCT";
            // 
            // clHuy
            // 
            this.clHuy.HeaderText = "Hủy";
            this.clHuy.Name = "clHuy";
            this.clHuy.Text = "Hủy";
            this.clHuy.UseColumnTextForButtonValue = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 621);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Cửa hàng giày dép";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietDonHang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAdmin;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.DataGridView gvSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvChiTietDonHang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHuyDon;
        private System.Windows.Forms.Button btnLuuDon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTongThanhToan;
        private System.Windows.Forms.TextBox txtTongTienHang;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbTenDangNhap;
        private System.Windows.Forms.ToolStripStatusLabel lbChiNhanh;
        private System.Windows.Forms.ToolStripStatusLabel lbVaiTro;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIDCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSizeCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuongCT;
        private System.Windows.Forms.DataGridViewButtonColumn clHuy;
    }
}