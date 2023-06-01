using ProductManagement.Models;

namespace ProductManagement.Infrastructure.IRepository
{
    public interface ICategory
    {
        List<CategoryInfo> GetCategoryData();
        CategoryInfo GetCategoryById(int id);
        CategoryInfo AddCategory(CategoryInfo categoryInfo);
        CategoryInfo UpadateCategory(CategoryInfo categoryInfo);
        CategoryInfo DeleteCategory(int id);
    }
}
