
namespace ShoeShopManagement
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gvNhanVien = new System.Windows.Forms.DataGridView();
            this.cmsNhanVien = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chuyểnChiNhánhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaTrong = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbChiNhanhTK = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoaTrongTK = new System.Windows.Forms.Button();
            this.btnLuuTK = new System.Windows.Forms.Button();
            this.cbbVaiTro = new System.Windows.Forms.ComboBox();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clIDTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clXoaTK = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clResetMK = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabAdmin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).BeginInit();
            this.cmsNhanVien.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaiKhoan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabPage1);
            this.tabAdmin.Controls.Add(this.tabPage2);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(800, 501);
            this.tabAdmin.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gvNhanVien, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.133971F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.86603F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 469);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách nhân viên:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbChiNhanh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(396, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 23);
            this.panel1.TabIndex = 1;
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Items.AddRange(new object[] {
            "Chi nhánh Bùi Thị Xuân",
            "Chi nhánh Phan Đình Phùng"});
            this.cbbChiNhanh.Location = new System.Drawing.Point(67, 1);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(162, 21);
            this.cbbChiNhanh.TabIndex = 1;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chi nhánh:";
            // 
            // gvNhanVien
            // 
            this.gvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clTen,
            this.clNgaySinh,
            this.clDiaChi,
            this.clLuong,
            this.clViTri,
            this.clSDT,
            this.clXoa});
            this.tableLayoutPanel1.SetColumnSpan(this.gvNhanVien, 2);
            this.gvNhanVien.ContextMenuStrip = this.cmsNhanVien;
            this.gvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvNhanVien.Location = new System.Drawing.Point(3, 32);
            this.gvNhanVien.Name = "gvNhanVien";
            this.gvNhanVien.RowHeadersVisible = false;
            this.gvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvNhanVien.Size = new System.Drawing.Size(780, 325);
            this.gvNhanVien.TabIndex = 2;
            this.gvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvNhanVien_CellClick);
            this.gvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvNhanVien_CellContentClick);
            // 
            // cmsNhanVien
            // 
            this.cmsNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chuyểnChiNhánhToolStripMenuItem});
            this.cmsNhanVien.Name = "cmsNhanVien";
            this.cmsNhanVien.Size = new System.Drawing.Size(172, 26);
            // 
            // chuyểnChiNhánhToolStripMenuItem
            // 
            this.chuyểnChiNhánhToolStripMenuItem.Name = "chuyểnChiNhánhToolStripMenuItem";
            this.chuyểnChiNhánhToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.chuyểnChiNhánhToolStripMenuItem.Text = "Chuyển chi nhánh";
            this.chuyểnChiNhánhToolStripMenuItem.Click += new System.EventHandler(this.chuyểnChiNhánhToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnXoaTrong);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtViTri);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 103);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm / cập nhật thông tin nhân viên";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Location = new System.Drawing.Point(618, 74);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoaTrong
            // 
            this.btnXoaTrong.Location = new System.Drawing.Point(699, 74);
            this.btnXoaTrong.Name = "btnXoaTrong";
            this.btnXoaTrong.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTrong.TabIndex = 3;
            this.btnXoaTrong.Text = "Xóa trống";
            this.btnXoaTrong.UseVisualStyleBackColor = true;
            this.btnXoaTrong.Click += new System.EventHandler(this.btnXoaTrong_Click);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(69, 48);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(225, 20);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // txtLuong
            // 
            this.txtLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLuong.Location = new System.Drawing.Point(565, 48);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(209, 20);
            this.txtLuong.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(379, 48);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(134, 20);
            this.txtSDT.TabIndex = 1;
            // 
            // txtViTri
            // 
            this.txtViTri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtViTri.Location = new System.Drawing.Point(338, 22);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(175, 20);
            this.txtViTri.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Location = new System.Drawing.Point(565, 22);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(209, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(33, 22);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(47, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(121, 22);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(173, 20);
            this.txtTen.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(300, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Vị trí:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lương:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tài khoản";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.21374F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.78626F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.102345F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.89765F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 469);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbChiNhanhTK);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 32);
            this.panel2.TabIndex = 0;
            // 
            // cbbChiNhanhTK
            // 
            this.cbbChiNhanhTK.FormattingEnabled = true;
            this.cbbChiNhanhTK.Items.AddRange(new object[] {
            "Chi nhánh Bùi Thị Xuân",
            "Chi nhánh Phan Đình Phùng"});
            this.cbbChiNhanhTK.Location = new System.Drawing.Point(67, 7);
            this.cbbChiNhanhTK.Name = "cbbChiNhanhTK";
            this.cbbChiNhanhTK.Size = new System.Drawing.Size(164, 21);
            this.cbbChiNhanhTK.TabIndex = 1;
            this.cbbChiNhanhTK.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanhTK_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Chi nhánh:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvTaiKhoan);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 425);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách tài khoản:";
            // 
            // gvTaiKhoan
            // 
            this.gvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIDTK,
            this.clTenNhanVien,
            this.clTenTK,
            this.clVaiTro,
            this.clXoaTK,
            this.clResetMK});
            this.gvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTaiKhoan.Location = new System.Drawing.Point(3, 16);
            this.gvTaiKhoan.Name = "gvTaiKhoan";
            this.gvTaiKhoan.RowHeadersVisible = false;
            this.gvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTaiKhoan.Size = new System.Drawing.Size(477, 406);
            this.gvTaiKhoan.TabIndex = 0;
            this.gvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTaiKhoan_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoaTrongTK);
            this.groupBox3.Controls.Add(this.btnLuuTK);
            this.groupBox3.Controls.Add(this.cbbVaiTro);
            this.groupBox3.Controls.Add(this.cbbNhanVien);
            this.groupBox3.Controls.Add(this.txtTenTK);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(492, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 425);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thêm tài khoản";
            // 
            // btnXoaTrongTK
            // 
            this.btnXoaTrongTK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaTrongTK.Location = new System.Drawing.Point(210, 136);
            this.btnXoaTrongTK.Name = "btnXoaTrongTK";
            this.btnXoaTrongTK.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTrongTK.TabIndex = 2;
            this.btnXoaTrongTK.Text = "Xóa trống";
            this.btnXoaTrongTK.UseVisualStyleBackColor = true;
            this.btnXoaTrongTK.Click += new System.EventHandler(this.btnXoaTrongTK_Click);
            // 
            // btnLuuTK
            // 
            this.btnLuuTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuTK.Location = new System.Drawing.Point(129, 136);
            this.btnLuuTK.Name = "btnLuuTK";
            this.btnLuuTK.Size = new System.Drawing.Size(75, 23);
            this.btnLuuTK.TabIndex = 2;
            this.btnLuuTK.Text = "Lưu";
            this.btnLuuTK.UseVisualStyleBackColor = true;
            this.btnLuuTK.Click += new System.EventHandler(this.btnLuuTK_Click);
            // 
            // cbbVaiTro
            // 
            this.cbbVaiTro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbVaiTro.FormattingEnabled = true;
            this.cbbVaiTro.Items.AddRange(new object[] {
            "Giám đốc",
            "Quản lý chi nhánh",
            "Nhân viên"});
            this.cbbVaiTro.Location = new System.Drawing.Point(88, 96);
            this.cbbVaiTro.Name = "cbbVaiTro";
            this.cbbVaiTro.Size = new System.Drawing.Size(197, 21);
            this.cbbVaiTro.TabIndex = 1;
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(88, 63);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(197, 21);
            this.cbbNhanVien.TabIndex = 1;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenTK.Location = new System.Drawing.Point(88, 31);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(197, 20);
            this.txtTenTK.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Vai trò:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nhân viên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên tài khoản:";
            // 
            // clID
            // 
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "ID";
            this.clID.Name = "clID";
            this.clID.Width = 50;
            // 
            // clTen
            // 
            this.clTen.DataPropertyName = "Name";
            this.clTen.HeaderText = "Tên";
            this.clTen.Name = "clTen";
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.DataPropertyName = "DateOfBirth";
            this.clNgaySinh.HeaderText = "Ngày sinh";
            this.clNgaySinh.Name = "clNgaySinh";
            // 
            // clDiaChi
            // 
            this.clDiaChi.DataPropertyName = "Address";
            this.clDiaChi.HeaderText = "Địa chỉ";
            this.clDiaChi.Name = "clDiaChi";
            this.clDiaChi.Width = 150;
            // 
            // clLuong
            // 
            this.clLuong.DataPropertyName = "Salary";
            this.clLuong.HeaderText = "Lương";
            this.clLuong.Name = "clLuong";
            // 
            // clViTri
            // 
            this.clViTri.DataPropertyName = "Position";
            this.clViTri.HeaderText = "Vị trí";
            this.clViTri.Name = "clViTri";
            // 
            // clSDT
            // 
            this.clSDT.DataPropertyName = "PhoneNumber";
            this.clSDT.HeaderText = "Số điện thoại";
            this.clSDT.Name = "clSDT";
            // 
            // clXoa
            // 
            this.clXoa.HeaderText = "Xóa";
            this.clXoa.Name = "clXoa";
            this.clXoa.Text = "Xóa";
            this.clXoa.UseColumnTextForButtonValue = true;
            this.clXoa.Width = 75;
            // 
            // clIDTK
            // 
            this.clIDTK.DataPropertyName = "ID";
            this.clIDTK.HeaderText = "ID";
            this.clIDTK.Name = "clIDTK";
            this.clIDTK.Width = 50;
            // 
            // clTenNhanVien
            // 
            this.clTenNhanVien.DataPropertyName = "Name";
            this.clTenNhanVien.HeaderText = "Tên nhân viên";
            this.clTenNhanVien.Name = "clTenNhanVien";
            this.clTenNhanVien.Width = 150;
            // 
            // clTenTK
            // 
            this.clTenTK.DataPropertyName = "loginName";
            this.clTenTK.HeaderText = "Tên tài khoản";
            this.clTenTK.Name = "clTenTK";
            this.clTenTK.Width = 75;
            // 
            // clVaiTro
            // 
            this.clVaiTro.DataPropertyName = "groupname";
            this.clVaiTro.HeaderText = "Vai trò";
            this.clVaiTro.Name = "clVaiTro";
            // 
            // clXoaTK
            // 
            this.clXoaTK.HeaderText = "Xóa";
            this.clXoaTK.Name = "clXoaTK";
            this.clXoaTK.Text = "Xóa";
            this.clXoaTK.UseColumnTextForButtonValue = true;
            this.clXoaTK.Width = 50;
            // 
            // clResetMK
            // 
            this.clResetMK.HeaderText = "Đặt lại mật khẩu";
            this.clResetMK.Name = "clResetMK";
            this.clResetMK.Text = "Đặt lại mật khẩu";
            this.clResetMK.UseColumnTextForButtonValue = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.tabAdmin);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tabAdmin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).EndInit();
            this.cmsNhanVien.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTaiKhoan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaTrong;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbChiNhanhTK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvTaiKhoan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXoaTrongTK;
        private System.Windows.Forms.Button btnLuuTK;
        private System.Windows.Forms.ComboBox cbbVaiTro;
        private System.Windows.Forms.ComboBox cbbNhanVien;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ContextMenuStrip cmsNhanVien;
        private System.Windows.Forms.ToolStripMenuItem chuyểnChiNhánhToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clViTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
        private System.Windows.Forms.DataGridViewButtonColumn clXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIDTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVaiTro;
        private System.Windows.Forms.DataGridViewButtonColumn clXoaTK;
        private System.Windows.Forms.DataGridViewButtonColumn clResetMK;
    }
}