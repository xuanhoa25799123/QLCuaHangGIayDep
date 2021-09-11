
namespace ShoeShopManagement
{
    partial class ProductForm
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
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnXoaBoLoc = new System.Windows.Forms.Button();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvSanPham = new System.Windows.Forms.DataGridView();
            this.csmGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).BeginInit();
            this.csmGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblinfo);
            this.groupBox1.Controls.Add(this.btnThemSP);
            this.groupBox1.Controls.Add(this.btnXoaBoLoc);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.cbbTheLoai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc / tìm kiếm";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(510, 28);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(0, 13);
            this.lblinfo.TabIndex = 4;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSP.Location = new System.Drawing.Point(692, 23);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(96, 23);
            this.btnThemSP.TabIndex = 3;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnXoaBoLoc
            // 
            this.btnXoaBoLoc.Location = new System.Drawing.Point(429, 23);
            this.btnXoaBoLoc.Name = "btnXoaBoLoc";
            this.btnXoaBoLoc.Size = new System.Drawing.Size(75, 23);
            this.btnXoaBoLoc.TabIndex = 3;
            this.btnXoaBoLoc.Text = "Xóa bộ lọc";
            this.btnXoaBoLoc.UseVisualStyleBackColor = true;
            this.btnXoaBoLoc.Click += new System.EventHandler(this.btnXoaBoLoc_Click);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(284, 25);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(139, 20);
            this.txtTenSP.TabIndex = 2;
            this.txtTenSP.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(63, 25);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(131, 21);
            this.cbbTheLoai.TabIndex = 1;
            this.cbbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbbTheLoai_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thể loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvSanPham);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(794, 381);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm:";
            // 
            // gvSanPham
            // 
            this.gvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clTenSP,
            this.clTenTL,
            this.clGia,
            this.clMoTa,
            this.clTongSoLuong,
            this.clTrangThai,
            this.clXoa});
            this.gvSanPham.ContextMenuStrip = this.csmGrid;
            this.gvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSanPham.Location = new System.Drawing.Point(3, 16);
            this.gvSanPham.Name = "gvSanPham";
            this.gvSanPham.RowHeadersVisible = false;
            this.gvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSanPham.Size = new System.Drawing.Size(788, 362);
            this.gvSanPham.TabIndex = 0;
            this.gvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSanPham_CellContentClick);
            // 
            // csmGrid
            // 
            this.csmGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtToolStripMenuItem,
            this.chiTiếtSảnPhẩmToolStripMenuItem});
            this.csmGrid.Name = "csmGrid";
            this.csmGrid.Size = new System.Drawing.Size(168, 48);
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            this.cậpNhậtToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtToolStripMenuItem_Click);
            // 
            // chiTiếtSảnPhẩmToolStripMenuItem
            // 
            this.chiTiếtSảnPhẩmToolStripMenuItem.Name = "chiTiếtSảnPhẩmToolStripMenuItem";
            this.chiTiếtSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.chiTiếtSảnPhẩmToolStripMenuItem.Text = "Chi tiết sản phẩm";
            this.chiTiếtSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtSảnPhẩmToolStripMenuItem_Click);
            // 
            // clID
            // 
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "ID";
            this.clID.Name = "clID";
            this.clID.Width = 50;
            // 
            // clTenSP
            // 
            this.clTenSP.DataPropertyName = "Name";
            this.clTenSP.HeaderText = "Tên sản phẩm";
            this.clTenSP.Name = "clTenSP";
            this.clTenSP.Width = 200;
            // 
            // clTenTL
            // 
            this.clTenTL.DataPropertyName = "CategoryName";
            this.clTenTL.HeaderText = "Tên thể loại";
            this.clTenTL.Name = "clTenTL";
            // 
            // clGia
            // 
            this.clGia.DataPropertyName = "Price";
            this.clGia.HeaderText = "Giá";
            this.clGia.Name = "clGia";
            // 
            // clMoTa
            // 
            this.clMoTa.DataPropertyName = "Description";
            this.clMoTa.HeaderText = "Mô tả";
            this.clMoTa.Name = "clMoTa";
            // 
            // clTongSoLuong
            // 
            this.clTongSoLuong.DataPropertyName = "TotalQuantity";
            this.clTongSoLuong.HeaderText = "Tổng số lượng";
            this.clTongSoLuong.Name = "clTongSoLuong";
            // 
            // clTrangThai
            // 
            this.clTrangThai.DataPropertyName = "State";
            this.clTrangThai.HeaderText = "Không kinh doanh";
            this.clTrangThai.Name = "clTrangThai";
            this.clTrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clTrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clTrangThai.Width = 75;
            // 
            // clXoa
            // 
            this.clXoa.HeaderText = "Ngừng kinh doanh";
            this.clXoa.Name = "clXoa";
            this.clXoa.Text = "Ngừng kinh doanh";
            this.clXoa.UseColumnTextForButtonValue = true;
            this.clXoa.Width = 75;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductForm";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSanPham)).EndInit();
            this.csmGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnXoaBoLoc;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvSanPham;
        private System.Windows.Forms.ContextMenuStrip csmGrid;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongSoLuong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clTrangThai;
        private System.Windows.Forms.DataGridViewButtonColumn clXoa;
    }
}