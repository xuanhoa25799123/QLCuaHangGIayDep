using ShoeShopManagement.BLL.BillDetails;
using ShoeShopManagement.BLL.Bills;
using ShoeShopManagement.BLL.Employees;
using ShoeShopManagement.BLL.ProductDetails;
using ShoeShopManagement.BLL.Products;
using ShoeShopManagement.DAL;
using ShoeShopManagement.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeShopManagement
{
    public partial class MainForm : Form
    {
        private DataTable chiTietDonHang;
        private IUnitOfWork _unitOfWork;
        private IProductDetailService _productDetailService;
        private IProductService _productService;
        private IBillService _billService;
        private IBillDetailService _billDetailService;
        public MainForm(IUnitOfWork unitOfWork)
        {
            chiTietDonHang = new DataTable();
            chiTietDonHang.Columns.Add("ID", typeof(int));
            chiTietDonHang.Columns.Add("TenSP", typeof(string));
            chiTietDonHang.Columns.Add("Gia", typeof(int));
            chiTietDonHang.Columns.Add("SoLuong", typeof(int));
            chiTietDonHang.Columns.Add("Size", typeof(string));
            _unitOfWork = unitOfWork;
            _productDetailService = new ProductDetailService(_unitOfWork);
            _productService = new ProductService(_unitOfWork);
            _billService = new BillService(_unitOfWork);
            _billDetailService = new BillDetailService(_unitOfWork);
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtGiamGia.Text = "0";
                txtNgayLap.Text = DateTime.Now.ToString();
                txtTongThanhToan.Text = "0";
                txtTongTienHang.Text = "0";
                gvChiTietDonHang.AutoGenerateColumns = false;
                if (WorkingContext.Instance.CurrentLoginInfo.RoleName == "NHANVIEN")
                {
                    tsmAdmin.Enabled = false;
                    sảnPhẩmToolStripMenuItem.Enabled = false;
                    thốngKêToolStripMenuItem.Enabled = false;
                    báoCáoToolStripMenuItem.Enabled = false;
                    nhậpHàngToolStripMenuItem.Enabled = false;
                }
                gvSanPham.DataSource = _productDetailService.GetAll().Select(c=> new { c.ID, c.Product.Name, c.Product.Price, c.Quantity, c.Size }).ToList();
                lbTenDangNhap.Text += WorkingContext.Instance.currentLoginName;
                lbChiNhanh.Text += WorkingContext.Instance.currentBranch;
                lbVaiTro.Text += WorkingContext.Instance.CurrentLoginInfo.RoleName;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sai thông tin đăng nhập \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();

            }
        }

        private void tsmAdmin_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm(_unitOfWork);
            form.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillForm form = new BillForm(_unitOfWork);
            form.ShowDialog();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm(_unitOfWork);
            form.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm(_unitOfWork);
            form.ShowDialog();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm(_unitOfWork);
            form.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticForm form = new StatisticForm(_unitOfWork);
            form.ShowDialog();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            gvSanPham.DataSource = _productDetailService.GetAll()
                .Select(c => new { c.ID, c.Product.Name, c.Product.Price, c.Quantity, c.Size })
                .Where(c=> c.Name.Contains(txtTimKiem.Text))
                .ToList();
        }

        private void gvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRow dr = null;
            dr = chiTietDonHang.NewRow();
            dr["ID"] = (int)gvSanPham.SelectedRows[0].Cells["clID"].Value;
            dr["TenSP"] = gvSanPham.SelectedRows[0].Cells["clTenSanPham"].Value.ToString();
            dr["Size"] = gvSanPham.SelectedRows[0].Cells["clSize"].Value.ToString();
            dr["Gia"] = (int)gvSanPham.SelectedRows[0].Cells["clGia"].Value;
            dr["SoLuong"] = 1;
            chiTietDonHang.Rows.Add(dr);
            gvChiTietDonHang.DataSource = chiTietDonHang;
        }

        private void gvChiTietDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = grid.Rows[e.RowIndex];
                string TenSP = row.Cells["clTenSP"].Value.ToString();
                for (int i = chiTietDonHang.Rows.Count-1;i>=0; i--)
                {
                    DataRow dr = chiTietDonHang.Rows[i];
                    if (dr["TenSP"] == TenSP)
                        chiTietDonHang.Rows.Remove(dr);
                }
                gvChiTietDonHang.DataSource = chiTietDonHang;
            }
        }

        private void gvChiTietDonHang_DataSourceChanged(object sender, EventArgs e)
        {
            UpdateBillInfo();
        }

        private void UpdateBillInfo()
        {
            int TongTien = 0;
            int GiamGia = 0;
            if (!string.IsNullOrEmpty(txtGiamGia.Text))
            {
                GiamGia = int.Parse(txtGiamGia.Text);
            }
            foreach(DataGridViewRow row in gvChiTietDonHang.Rows)
            {
                TongTien += (int)row.Cells["clSoLuongCT"].Value * (int)row.Cells["clGiaCT"].Value;
            }
            txtNgayLap.Text = DateTime.Now.ToString();
            txtTongTienHang.Text = TongTien.ToString();
            txtTongThanhToan.Text = (TongTien - (GiamGia*TongTien/100)).ToString();
        }


        private void gvChiTietDonHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid.RowCount > 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row = grid.Rows[e.RowIndex];
                int SoLuongMua = (int)row.Cells["clSoLuongCT"].Value;
                string TenSP = row.Cells["clTenSP"].Value.ToString();
                string Size = row.Cells["clSizeCT"].Value.ToString();
                int SoLuongCo = _productDetailService.GetAll().Where(c => (c.Product.Name == TenSP && c.Size == Size)).Select(c => c.Quantity).FirstOrDefault();
                if (SoLuongMua > SoLuongCo)
                {
                    MessageBox.Show("Số lượng mua vượt quá số lượng có ở chi nhánh", "Thông báo", MessageBoxButtons.OK);
                    row.Cells["clSoLuongCT"].Value = 1;
                }
                UpdateBillInfo();
            }
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            UpdateBillInfo();
        }

        private void gvChiTietDonHang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateBillInfo();
        }

        private void gvChiTietDonHang_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateBillInfo();
        }

        private void btnHuyDon_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtSDT.Text = "";
            chiTietDonHang.Rows.Clear();
            gvChiTietDonHang.DataSource = chiTietDonHang;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            gvSanPham.DataSource = _productDetailService.GetAll().Select(c => new { c.ID, c.Product.Name, c.Product.Price, c.Quantity, c.Size }).ToList();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuuDon_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtSDT.Text))
                {
                    MessageBox.Show("Họ tên và số điện thoại không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                Bill bill = new Bill
                {
                    EmployeeID = Convert.ToInt32(WorkingContext.Instance.CurrentLoginInfo.Id),
                    CustomerName = txtHoTen.Text,
                    PhoneNumber = txtSDT.Text,
                    CheckoutDate = Convert.ToDateTime(txtNgayLap.Text),
                    Total = Convert.ToInt32(txtTongTienHang.Text),
                    Discount = Convert.ToInt32(txtGiamGia.Text) * Convert.ToInt32(txtTongTienHang.Text) / 100
                };
                _billService.AddBill(bill);
                int BillID = _billService.GetAll().OrderByDescending(c=>c.ID).Select(c => c.ID).FirstOrDefault();
                foreach(DataGridViewRow row in gvChiTietDonHang.Rows)
                {
                    BillDetail billDetail = new BillDetail
                    {
                        BillID = BillID,
                        ProductID = (int)row.Cells["clIDCT"].Value,
                        CurrentUnitPrice = (int)row.Cells["clGiaCT"].Value,
                        Quantity = (int)row.Cells["clSoLuongCT"].Value
                    };
                    string size = row.Cells["clSizeCT"].Value.ToString();
                    _billDetailService.AddBillDetail(billDetail);
                    _productDetailService.UpdateProductDetailQuantity(billDetail.Quantity, billDetail.ProductID, size);
                    txtHoTen.Text = "";
                    txtSDT.Text = "";
                    chiTietDonHang.Rows.Clear();
                    gvChiTietDonHang.DataSource = chiTietDonHang;
                    int total1;
                    int total2;
                    if (_productDetailService.GetQuantityByProductID(billDetail.ProductID) == null)
                        total1 = 0;
                    else
                        total1 = Convert.ToInt32(_productDetailService.GetQuantityByProductID(billDetail.ProductID));
                    if (_productDetailService.GetQuantityByProductIDFromRemote(billDetail.ProductID) == null)
                        total2 = 0;
                    else
                        total2 = Convert.ToInt32(_productDetailService.GetQuantityByProductIDFromRemote(billDetail.ProductID));
                    _productDetailService.UpdateProductQuantity(total1 + total2, billDetail.ProductID);
                }
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                gvSanPham.DataSource = _productDetailService.GetAll().Select(c => new { c.ID, c.Product.Name, c.Product.Price, c.Quantity, c.Size }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
