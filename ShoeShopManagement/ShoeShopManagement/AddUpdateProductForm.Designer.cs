
namespace ShoeShopManagement
{
    partial class AddUpdateProductForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTongSoLuong = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThemTheLoai = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTaiLai = new System.Windows.Forms.Button();
            this.btnXoaTrong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thể loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mô tả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng số lượng";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(228, 2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(246, 20);
            this.txtTenSP.TabIndex = 1;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(96, 85);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(378, 53);
            this.txtMoTa.TabIndex = 1;
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(96, 32);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(164, 21);
            this.cbbTheLoai.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(96, 59);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(378, 20);
            this.txtGia.TabIndex = 1;
            // 
            // txtTongSoLuong
            // 
            this.txtTongSoLuong.Location = new System.Drawing.Point(96, 144);
            this.txtTongSoLuong.Name = "txtTongSoLuong";
            this.txtTongSoLuong.Size = new System.Drawing.Size(378, 20);
            this.txtTongSoLuong.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(399, 176);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(318, 176);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemTheLoai
            // 
            this.btnThemTheLoai.Location = new System.Drawing.Point(266, 32);
            this.btnThemTheLoai.Name = "btnThemTheLoai";
            this.btnThemTheLoai.Size = new System.Drawing.Size(87, 23);
            this.btnThemTheLoai.TabIndex = 3;
            this.btnThemTheLoai.Text = "Thêm thể loại";
            this.btnThemTheLoai.UseVisualStyleBackColor = true;
            this.btnThemTheLoai.Click += new System.EventHandler(this.btnThemTheLoai_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(96, 2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(42, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtTaiLai
            // 
            this.txtTaiLai.Location = new System.Drawing.Point(359, 32);
            this.txtTaiLai.Name = "txtTaiLai";
            this.txtTaiLai.Size = new System.Drawing.Size(115, 23);
            this.txtTaiLai.TabIndex = 4;
            this.txtTaiLai.Text = "Tải lại thể loại";
            this.txtTaiLai.UseVisualStyleBackColor = true;
            this.txtTaiLai.Click += new System.EventHandler(this.txtTaiLai_Click);
            // 
            // btnXoaTrong
            // 
            this.btnXoaTrong.Location = new System.Drawing.Point(237, 176);
            this.btnXoaTrong.Name = "btnXoaTrong";
            this.btnXoaTrong.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTrong.TabIndex = 5;
            this.btnXoaTrong.Text = "Xóa trống";
            this.btnXoaTrong.UseVisualStyleBackColor = true;
            this.btnXoaTrong.Click += new System.EventHandler(this.btnXoaTrong_Click);
            // 
            // AddUpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 211);
            this.Controls.Add(this.btnXoaTrong);
            this.Controls.Add(this.txtTaiLai);
            this.Controls.Add(this.btnThemTheLoai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cbbTheLoai);
            this.Controls.Add(this.txtTongSoLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "AddUpdateProductForm";
            this.Text = "Thêm / cập nhật thông tin sản phẩm";
            this.Load += new System.EventHandler(this.AddUpdateProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTongSoLuong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThemTheLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button txtTaiLai;
        private System.Windows.Forms.Button btnXoaTrong;
    }
}