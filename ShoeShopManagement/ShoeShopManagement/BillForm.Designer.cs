
namespace ShoeShopManagement
{
    partial class BillForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXemTatCa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvHoaDon = new System.Windows.Forms.DataGridView();
            this.cmsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).BeginInit();
            this.cmsGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.25F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gvHoaDon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXemTatCa);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtKhachHang);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo điều kiện";
            // 
            // btnXemTatCa
            // 
            this.btnXemTatCa.Location = new System.Drawing.Point(446, 49);
            this.btnXemTatCa.Name = "btnXemTatCa";
            this.btnXemTatCa.Size = new System.Drawing.Size(86, 23);
            this.btnXemTatCa.TabIndex = 3;
            this.btnXemTatCa.Text = "Xem tất cả";
            this.btnXemTatCa.UseVisualStyleBackColor = true;
            this.btnXemTatCa.Click += new System.EventHandler(this.btnXemTatCa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(446, 21);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(86, 23);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm theo ngày";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(88, 51);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(151, 20);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(88, 23);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(151, 20);
            this.txtKhachHang.TabIndex = 2;
            this.txtKhachHang.TextChanged += new System.EventHandler(this.txtKhachHang_TextChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(331, 49);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(99, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(331, 23);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(99, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đến ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lập từ ngày:";
            // 
            // gvHoaDon
            // 
            this.gvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clCustomerName,
            this.clSDT,
            this.clNgayLap,
            this.clGiamGia,
            this.clTongTien,
            this.clTrangThai,
            this.clXoa});
            this.tableLayoutPanel1.SetColumnSpan(this.gvHoaDon, 2);
            this.gvHoaDon.ContextMenuStrip = this.cmsGrid;
            this.gvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvHoaDon.Location = new System.Drawing.Point(3, 89);
            this.gvHoaDon.Name = "gvHoaDon";
            this.gvHoaDon.RowHeadersVisible = false;
            this.gvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvHoaDon.Size = new System.Drawing.Size(794, 358);
            this.gvHoaDon.TabIndex = 2;
            this.gvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvHoaDon_CellContentClick);
            // 
            // cmsGrid
            // 
            this.cmsGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemChiTiếtToolStripMenuItem});
            this.cmsGrid.Name = "cmsGrid";
            this.cmsGrid.Size = new System.Drawing.Size(138, 26);
            // 
            // xemChiTiếtToolStripMenuItem
            // 
            this.xemChiTiếtToolStripMenuItem.Name = "xemChiTiếtToolStripMenuItem";
            this.xemChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.xemChiTiếtToolStripMenuItem.Text = "Xem chi tiết";
            this.xemChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.xemChiTiếtToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbNhanVien);
            this.panel1.Controls.Add(this.cbbChiNhanh);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(561, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 80);
            this.panel1.TabIndex = 1;
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(67, 47);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(160, 21);
            this.cbbNhanVien.TabIndex = 1;
            this.cbbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbbNhanVien_SelectedIndexChanged);
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Items.AddRange(new object[] {
            "Chi nhánh Bùi Thị Xuân",
            "Chi nhánh Phan Đình Phùng"});
            this.cbbChiNhanh.Location = new System.Drawing.Point(67, 18);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(160, 21);
            this.cbbChiNhanh.TabIndex = 0;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chi nhánh:";
            // 
            // clID
            // 
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "ID";
            this.clID.Name = "clID";
            this.clID.Width = 50;
            // 
            // clCustomerName
            // 
            this.clCustomerName.DataPropertyName = "CustomerName";
            this.clCustomerName.HeaderText = "Tên khách hàng";
            this.clCustomerName.Name = "clCustomerName";
            this.clCustomerName.Width = 200;
            // 
            // clSDT
            // 
            this.clSDT.DataPropertyName = "PhoneNumber";
            this.clSDT.HeaderText = "Số điện thoại";
            this.clSDT.Name = "clSDT";
            // 
            // clNgayLap
            // 
            this.clNgayLap.DataPropertyName = "CheckoutDate";
            this.clNgayLap.HeaderText = "Ngày lập";
            this.clNgayLap.Name = "clNgayLap";
            // 
            // clGiamGia
            // 
            this.clGiamGia.DataPropertyName = "Discount";
            this.clGiamGia.HeaderText = "Giảm giá";
            this.clGiamGia.Name = "clGiamGia";
            // 
            // clTongTien
            // 
            this.clTongTien.DataPropertyName = "Total";
            this.clTongTien.HeaderText = "Tổng tiền";
            this.clTongTien.Name = "clTongTien";
            // 
            // clTrangThai
            // 
            this.clTrangThai.DataPropertyName = "State";
            this.clTrangThai.HeaderText = "Đã xóa / hủy";
            this.clTrangThai.Name = "clTrangThai";
            this.clTrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clTrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clXoa
            // 
            this.clXoa.HeaderText = "Xóa/hủy";
            this.clXoa.Name = "clXoa";
            this.clXoa.Text = "Xóa/hủy";
            this.clXoa.UseColumnTextForButtonValue = true;
            this.clXoa.Width = 75;
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BillForm";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.BillForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).EndInit();
            this.cmsGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvHoaDon;
        private System.Windows.Forms.ContextMenuStrip cmsGrid;
        private System.Windows.Forms.ToolStripMenuItem xemChiTiếtToolStripMenuItem;
        private System.Windows.Forms.Button btnXemTatCa;
        private System.Windows.Forms.ComboBox cbbNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongTien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clTrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn clXoa;
    }
}