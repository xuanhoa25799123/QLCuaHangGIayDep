using ShoeShopManagement.BLL.Categories;
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
    public partial class AddUpdateProductForm : Form
    {
        private IUnitOfWork _unitOfWork;
        private Product _productInfo;
        private ICategoryService _categoryService;
        private IProductService _productService;
        private int productID;
        public AddUpdateProductForm(IUnitOfWork unitOfWork, int productID)
        {
            this.productID = productID;
            _unitOfWork = unitOfWork;
            _productService = new ProductService(_unitOfWork);
            _categoryService = new CategoryService(_unitOfWork);
            if (productID != 0)
                _productInfo = _productService.GetByID(productID);
            InitializeComponent();
        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            CategoryForm form = new CategoryForm(_unitOfWork);
            form.ShowDialog();
        }

        private void AddUpdateProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = productID.ToString();
                List<Category> categories = _categoryService.GetAll().ToList();
                cbbTheLoai.DataSource = categories;
                cbbTheLoai.ValueMember = "ID";
                cbbTheLoai.DisplayMember = "Name";
                if(productID != 0)
                {
                    txtTenSP.Text = _productInfo.Name;
                    txtGia.Text = _productInfo.Price.ToString();
                    txtMoTa.Text = _productInfo.Description;
                    txtTongSoLuong.Text = _productInfo.TotalQuantity.ToString();
                    cbbTheLoai.SelectedValue = _productInfo.CategoryID;
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ID = Convert.ToInt32(txtID.Text),
                Price = Convert.ToInt32(txtGia.Text),
                CategoryID = Convert.ToInt32(cbbTheLoai.SelectedValue),
                Description = txtMoTa.Text,
                TotalQuantity = Convert.ToInt32(txtTongSoLuong.Text),
                Name = txtTenSP.Text
            };
            if (productID == 0)
                _productService.AddProduct(product);
            else
                _productService.UpdateProduct(product);
            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTaiLai_Click(object sender, EventArgs e)
        {
            List<Category> categories = _categoryService.GetAll().ToList();
            cbbTheLoai.DataSource = categories;
            cbbTheLoai.ValueMember = "ID";
            cbbTheLoai.DisplayMember = "Name";
        }

        private void btnXoaTrong_Click(object sender, EventArgs e)
        {
            txtGia.Text = "";
            txtTenSP.Text = "";
            txtMoTa.Text = "";
            txtTongSoLuong.Text = "";
        }
    }
}
