using ShoeShopManagement.BLL.Common;
using ShoeShopManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShopManagement.BLL.Categories
{
    public interface ICategoryService : ICrudService<Category>
    {
        IQueryable<Category> GetAll();
        void AddCategory(Category category);
        void UpdateCategory(Category category);
    }
}
