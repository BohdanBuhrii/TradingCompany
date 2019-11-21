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

    }
}
