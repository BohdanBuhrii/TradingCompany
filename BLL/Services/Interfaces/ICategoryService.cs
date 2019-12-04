using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface ICategoryService
    {
        IList<CategoryDTO> GetCategoriesByGroupId(int groupId);

        IList<CategoryGroupDTO> GetAllCategoryGroups();

        IList<CategoryDTO> GetAllCategories();

        void AddCategory(CategoryDTO category);

        void AddCategoryGroup(CategoryGroupDTO categoryGroup);

        void RemoveCategory(int categoryId);

        void RemoveCategoryGroup(int groupId);

        bool CategoryExist(string categoryName);

        bool CategoryGroupExist(string categoryGroupName);

        CategoryGroupDTO GetGroupByName(string name);

        void UpdateCategories(IEnumerable<CategoryDTO> categories);

        void UpdateCategoryGroups(IEnumerable<CategoryGroupDTO> groups);
    }
}
