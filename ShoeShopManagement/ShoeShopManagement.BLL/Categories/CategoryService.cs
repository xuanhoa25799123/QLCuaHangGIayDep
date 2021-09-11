using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.DAL;
using ShoeShopManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Categories
{
    public class CategoryService : CrudService<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public IQueryable<Category> GetAll()
        {
            return this._repository.GetAll();
        }

        public void AddCategory(Category category)
        {
            _unitOfWork.SprocNonQuery("sp_AddCategory", new object[] { category.Name, category.Parent_ID });
        }

        public void UpdateCategory(Category category)
        {
            _unitOfWork.SprocNonQuery("sp_UpdateCategory", new object[] { category.ID, category.Name, category.Parent_ID });
        }
    }
}
