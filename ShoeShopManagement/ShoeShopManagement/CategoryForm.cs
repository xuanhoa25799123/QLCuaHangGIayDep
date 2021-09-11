using ShoeShopManagement.BLL.Categories;
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
    
    public partial class CategoryForm : Form
    {
        private IUnitOfWork _unitOfWork;
        private ICategoryService _categoryService;
        private IQueryable<Category> _listCategory;
        public CategoryForm(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _categoryService = new CategoryService(_unitOfWork);
            _listCategory = _categoryService.GetAll();
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (WorkingContext.Instance.CurrentLoginInfo.RoleName == "GIAMDOC") btnLuu.Enabled = false;
                txtID.Text = "0";
                Category non = new Category { ID = 0, Name = "Không có thể loại cha" };
                List < Category > categories = _listCategory.ToList();
                categories.Add(non);
                cbbTheLoaiCha.DataSource = categories;
                cbbTheLoaiCha.ValueMember = "ID";
                cbbTheLoaiCha.DisplayMember = "Name";
                cbbTheLoaiCha.SelectedValue = 0;
                dataGridView1.DataSource = _listCategory.Select(c=>new { c.ID, c.Name, c.Parent_ID }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra \r\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.SelectedRows[0].Cells["clID"].Value.ToString();
            txtTenTheLoai.Text = dataGridView1.SelectedRows[0].Cells["clTenTl"].Value.ToString();
            cbbTheLoaiCha.SelectedValue = (int)dataGridView1.SelectedRows[0].Cells["clIDTLCha"].Value;
        }
        private void Reset()
        {
            txtID.Text = "0";
            txtTenTheLoai.Text = "";
            cbbTheLoaiCha.SelectedValue = 0;
        }
        private void btnXoaTrong_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Category category = new Category 
            { ID = Convert.ToInt32(txtID.Text), 
                Name = txtTenTheLoai.Text,
                Parent_ID = Convert.ToInt32(cbbTheLoaiCha.SelectedValue)
            };
            if (txtID.Text == "0")
                _categoryService.AddCategory(category);
            else
                _categoryService.UpdateCategory(category);
            CategoryForm_Load(null, EventArgs.Empty);
            Reset();
        }
    }
}
