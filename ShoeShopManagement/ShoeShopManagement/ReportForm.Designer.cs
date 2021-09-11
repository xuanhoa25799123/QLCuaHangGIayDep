
namespace ShoeShopManagement
{
    partial class ReportForm
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbChiNhanhSapHet = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numSLToiThieu = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.gvSapHet = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvMatHangDaBan = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblTongTienGiamGia = new System.Windows.Forms.Label();
            this.lblTongTienBan = new System.Windows.Forms.Label();
            this.lblSoDonHang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.clTenSH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuongSH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLToiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSapHet)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatHangDaBan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hàng sắp hết";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gvSapHet, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.48325F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.51675F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbChiNhanhSapHet);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.numSLToiThieu);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 41);
            this.panel1.TabIndex = 0;
            // 
            // cbbChiNhanhSapHet
            // 
            this.cbbChiNhanhSapHet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbChiNhanhSapHet.FormattingEnabled = true;
            this.cbbChiNhanhSapHet.Items.AddRange(new object[] {
            "Chi nhánh Bùi Thị Xuân",
            "Chi nhánh Phan Đình Phùng"});
            this.cbbChiNhanhSapHet.Location = new System.Drawing.Point(631, 12);
            this.cbbChiNhanhSapHet.Name = "cbbChiNhanhSapHet";
            this.cbbChiNhanhSapHet.Size = new System.Drawing.Size(146, 21);
            this.cbbChiNhanhSapHet.TabIndex = 2;
            this.cbbChiNhanhSapHet.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanhSapHet_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(567, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Chi nhánh:";
            // 
            // numSLToiThieu
            // 
            this.numSLToiThieu.Location = new System.Drawing.Point(101, 13);
            this.numSLToiThieu.Name = "numSLToiThieu";
            this.numSLToiThieu.Size = new System.Drawing.Size(120, 20);
            this.numSLToiThieu.TabIndex = 1;
            this.numSLToiThieu.ValueChanged += new System.EventHandler(this.numSLToiThieu_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng tối thiểu:";
            // 
            // gvSapHet
            // 
            this.gvSapHet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSapHet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTenSH,
            this.clSize,
            this.clGia,
            this.clSoLuongSH});
            this.gvSapHet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSapHet.Location = new System.Drawing.Point(3, 50);
            this.gvSapHet.Name = "gvSapHet";
            this.gvSapHet.RowHeadersVisible = false;
            this.gvSapHet.Size = new System.Drawing.Size(780, 365);
            this.gvSapHet.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.8756F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.1244F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvMatHangDaBan);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblTongDoanhThu);
            this.groupBox2.Controls.Add(this.lblTongTienGiamGia);
            this.groupBox2.Controls.Add(this.lblTongTienBan);
            this.groupBox2.Controls.Add(this.lblSoDonHang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 354);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê doanh thu";
            // 
            // gvMatHangDaBan
            // 
            this.gvMatHangDaBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMatHangDaBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTen,
            this.clSoLuong,
            this.clThanhTien});
            this.gvMatHangDaBan.Location = new System.Drawing.Point(0, 129);
            this.gvMatHangDaBan.Name = "gvMatHangDaBan";
            this.gvMatHangDaBan.RowHeadersVisible = false;
            this.gvMatHangDaBan.Size = new System.Drawing.Size(780, 220);
            this.gvMatHangDaBan.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tổng doanh thu bán hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng tiền giảm giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng tiền bán hàng:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(275, 97);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(0, 13);
            this.lblTongDoanhThu.TabIndex = 3;
            // 
            // lblTongTienGiamGia
            // 
            this.lblTongTienGiamGia.AutoSize = true;
            this.lblTongTienGiamGia.Location = new System.Drawing.Point(275, 73);
            this.lblTongTienGiamGia.Name = "lblTongTienGiamGia";
            this.lblTongTienGiamGia.Size = new System.Drawing.Size(0, 13);
            this.lblTongTienGiamGia.TabIndex = 3;
            // 
            // lblTongTienBan
            // 
            this.lblTongTienBan.AutoSize = true;
            this.lblTongTienBan.Location = new System.Drawing.Point(275, 50);
            this.lblTongTienBan.Name = "lblTongTienBan";
            this.lblTongTienBan.Size = new System.Drawing.Size(0, 13);
            this.lblTongTienBan.TabIndex = 3;
            // 
            // lblSoDonHang
            // 
            this.lblSoDonHang.AutoSize = true;
            this.lblSoDonHang.Location = new System.Drawing.Point(275, 28);
            this.lblSoDonHang.Name = "lblSoDonHang";
            this.lblSoDonHang.Size = new System.Drawing.Size(0, 13);
            this.lblSoDonHang.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng đơn hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbChiNhanh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khoảng thòi gian";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xem theo ngày";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(257, 25);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(119, 20);
            this.dtpTo.TabIndex = 4;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(61, 25);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(128, 20);
            this.dtpFrom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ ngày:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chi nhánh:";
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Items.AddRange(new object[] {
            "Chi nhánh Bùi Thị Xuân",
            "Chi nhánh Phan Đình Phùng",
            "Cả công ty"});
            this.cbbChiNhanh.Location = new System.Drawing.Point(633, 26);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(141, 21);
            this.cbbChiNhanh.TabIndex = 2;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // clTenSH
            // 
            this.clTenSH.DataPropertyName = "Name";
            this.clTenSH.HeaderText = "Tên";
            this.clTenSH.Name = "clTenSH";
            this.clTenSH.Width = 350;
            // 
            // clSize
            // 
            this.clSize.DataPropertyName = "Size";
            this.clSize.HeaderText = "Size";
            this.clSize.Name = "clSize";
            this.clSize.Width = 150;
            // 
            // clGia
            // 
            this.clGia.DataPropertyName = "Price";
            this.clGia.HeaderText = "Giá";
            this.clGia.Name = "clGia";
            // 
            // clSoLuongSH
            // 
            this.clSoLuongSH.DataPropertyName = "Quantity";
            this.clSoLuongSH.HeaderText = "Số lượng";
            this.clSoLuongSH.Name = "clSoLuongSH";
            this.clSoLuongSH.Width = 150;
            // 
            // clTen
            // 
            this.clTen.DataPropertyName = "Name";
            this.clTen.HeaderText = "Tên sản phẩm";
            this.clTen.Name = "clTen";
            this.clTen.Width = 400;
            // 
            // clSoLuong
            // 
            this.clSoLuong.DataPropertyName = "Quantity";
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.Width = 200;
            // 
            // clThanhTien
            // 
            this.clThanhTien.DataPropertyName = "IntoMoney";
            this.clThanhTien.HeaderText = "Thành tiền";
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.Width = 200;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReportForm";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSapHet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMatHangDaBan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbChiNhanhSapHet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numSLToiThieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gvSapHet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvMatHangDaBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblTongTienGiamGia;
        private System.Windows.Forms.Label lblTongTienBan;
        private System.Windows.Forms.Label lblSoDonHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuongSH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
    }
}