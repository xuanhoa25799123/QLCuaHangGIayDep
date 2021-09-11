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
    public partial class ProductForm : Form
    {
        private IUnitOfWork _unitOfWork;
        private IProductService _productService;
        private ICategoryService _categoryService;
        private IQueryable<Product> _listProduct;
        public ProductForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _productService = new ProductService(_unitOfWork);
            _categoryService = new CategoryService(_unitOfWork);
            _listProduct = _productService.GetAll();
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (WorkingContext.Instance.CurrentLoginInfo.RoleName == "GIAMDOC")
                {
                    btnThemSP.Enabled = false;
                    cậpNhậtToolStripMenuItem.Enabled = false;
                }    
                gvSanPham.AutoGenerateColumns = false;
                Category non = new Category { ID = 0, Name = "Chọn thể loại" };
                List<Category> categories = _categoryService.GetAll().ToList();
                categories.Add(non);
                cbbTheLoai.DataSource = categories;
                cbbTheLoai.ValueMember = "ID";
                cbbTheLoai.DisplayMember = "Name";
                cbbTheLoai.SelectedValue = 0;
                gvSanPham.DataSource = _listProduct.Select(c => new { c.ID, c.Name, CategoryName = c.Category.Name, c.Price, c.Description, c.State, c.TotalQuantity }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            AddUpdateProductForm form = new AddUpdateProductForm(_unitOfWork, 0);
            form.Text = "Thêm sản phẩm";
            form.ShowDialog();
        }

        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTheLoai.SelectedValue is Category)
            { }
            else
            { 
                int ID = (int)cbbTheLoai.SelectedValue;
                if (ID != 0)
                {
                    gvSanPham.DataSource = _productService.GetAll()
                   .Select(c => new { c.ID, c.Name, CategoryName = c.Category.Name, CategoryID = c.Category.ID, ParentID = c.Category.Parent_ID, c.Price, c.Description, c.State, c.TotalQuantity })
                   .Where(c => (c.CategoryID == ID || c.ParentID == ID) && c.Name.Contains(txtTenSP.Text))
                   .ToList();
                }
                else
                {
                    gvSanPham.DataSource = _productService.GetAll()
                  .Select(c => new { c.ID, c.Name, CategoryName = c.Category.Name, CategoryID = c.Category.ID, ParentID = c.Category.Parent_ID, c.Price, c.Description, c.State, c.TotalQuantity })
                  .Where(c=> c.Name.Contains(txtTenSP.Text))
                  .ToList();
                }    
            }
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            int ID = (int)cbbTheLoai.SelectedValue;
            if (ID != 0)
            {
                gvSanPham.DataSource = _productService.GetAll()
               .Select(c => new { c.ID, c.Name, CategoryName = c.Category.Name, CategoryID = c.Category.ID, ParentID = c.Category.Parent_ID, c.Price, c.Description, c.State, c.TotalQuantity })
               .Where(c => (c.CategoryID == ID || c.ParentID == ID) && c.Name.Contains(txtTenSP.Text))
               .ToList();
            }
            else
            {
                gvSanPham.DataSource = _productService.GetAll()
              .Select(c => new { c.ID, c.Name, CategoryName = c.Category.Name, CategoryID = c.Category.ID, ParentID = c.Category.Parent_ID, c.Price, c.Description, c.State, c.TotalQuantity })
              .Where(c => c.Name.Contains(txtTenSP.Text))
              .ToList();
            }
        }

        private void btnXoaBoLoc_Click(object sender, EventArgs e)
        {
            ProductForm_Load(null, EventArgs.Empty);
        }

        private void gvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                int ProductID = (int)gvSanPham.SelectedRows[0].Cells["clID"].Value;
                _productService.DeleteProduct(ProductID);
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
                ProductForm_Load(null, EventArgs.Empty);
            }
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ProductID = (int)gvSanPham.SelectedRows[0].Cells["clID"].Value;
            AddUpdateProductForm form = new AddUpdateProductForm(_unitOfWork, ProductID);
            form.Text = "Cập nhật sản phẩm";
            form.ShowDialog();
        }

        private void chiTiếtSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ProductID = (int)gvSanPham.SelectedRows[0].Cells["clID"].Value;
            ProductDetailForm form = new ProductDetailForm(_unitOfWork, ProductID);
            form.ShowDialog();
        }
    }
}
