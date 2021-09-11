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
    public partial class ProductDetailForm : Form
    {
        private IUnitOfWork _unitOfWork;
        private IProductDetailService _productDetailService;
        private IProductService _productService;
        private Product product;
        public ProductDetailForm(IUnitOfWork unitOfWork, int productID)
        {
            _unitOfWork = unitOfWork;
            _productService = new ProductService(_unitOfWork);
            _productDetailService = new ProductDetailService(_unitOfWork);
            product = _productService.GetByID(productID);
            InitializeComponent();
        }

        private void ProductDetailForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = "0";
                txtTenSp.Text = product.Name;
                dgvChiTietSP.AutoGenerateColumns = false;
                cbbChiNhanh.SelectedIndex = WorkingContext.Instance.currentBranchId - 1;
                if (WorkingContext.Instance.CurrentLoginInfo.RoleName != "GIAMDOC")
                    cbbChiNhanh.Enabled = false;
                if (WorkingContext.Instance.CurrentLoginInfo.RoleName == "GIAMDOC")
                    btnThem.Enabled = false;
                dgvChiTietSP.DataSource = _productDetailService.GetProductDetailByProduct(product.ID).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                    dgvChiTietSP.DataSource = _productDetailService.GetProductDetailByProduct(product.ID).ToList();
                else
                    dgvChiTietSP.DataSource = _productDetailService.GetProductDetailByProductFromRemote(product.ID).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void dgvChiTietSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvChiTietSP.SelectedRows[0].Cells["clID"].Value.ToString();
            txtSize.Text = dgvChiTietSP.SelectedRows[0].Cells["clSize"].Value.ToString();
            txtSoLuong.Text = dgvChiTietSP.SelectedRows[0].Cells["clSoLuong"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDetail productDetail = new ProductDetail
                {
                    ID = Convert.ToInt32(txtID.Text),
                    Size = txtSize.Text,
                    Quantity = Convert.ToInt32(txtSoLuong.Text),
                    ProductID = product.ID
                };
                if (cbbChiNhanh.SelectedIndex == WorkingContext.Instance.currentBranchId - 1)
                {
                    productDetail.BranchID = WorkingContext.Instance.currentBranchId;
                    if (txtID.Text == "0")
                    {
                        _productDetailService.AddProductDetail(productDetail);
                    }
                    else
                        _productDetailService.UpdateProductDetail(productDetail);
                }
                else
                {
                    if (WorkingContext.Instance.currentBranchId == 1)
                        productDetail.BranchID = 2;
                    else
                        productDetail.BranchID = 1;
                    if (txtID.Text == "0")
                    {
                        _productDetailService.AddProductDetailFromRemote(productDetail);
                    }
                    else
                        _productDetailService.UpdateProductDetailFromRemote(productDetail);
                }
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                int total1;
                int total2;
                if (_productDetailService.GetQuantityByProductID(product.ID) == null)
                    total1 = 0;
                else
                    total1 = Convert.ToInt32(_productDetailService.GetQuantityByProductID(product.ID));
                if (_productDetailService.GetQuantityByProductIDFromRemote(product.ID) == null)
                    total2 = 0;
                else
                    total2 = Convert.ToInt32(_productDetailService.GetQuantityByProductIDFromRemote(product.ID));
                _productDetailService.UpdateProductQuantity(total1 + total2, product.ID);
                ProductDetailForm_Load(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnXoaTrong_Click(object sender, EventArgs e)
        {
            txtID.Text = "0";
            txtSize.Text = "";
            txtSoLuong.Text = "";
        }
    }
}
