using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;
using BLL.Services.Interfaces;
using DAL.UnitOfWork;
using DTO;

namespace BLL.Services.ImplementedServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IList<CategoryDTO> GetCategoriesByGroupId(int groupId)
        {
            var categories = _unitOfWork.CategoryRepository.Get(c => c.CategoryGroupId == groupId);
            var categoryDTOs = new List<CategoryDTO>();
            foreach (var category in categories)
            {
                categoryDTOs.Add(_mapper.Map<CategoryDTO>(category));
            }

            return categoryDTOs;
        }

        public IList<CategoryGroupDTO> GetAllCategoryGroups()
        {
            var categoryGroups = _unitOfWork.CategoryGroupRepository.GetAll();
            var categoryGroupDTOs = new List<CategoryGroupDTO>();
            foreach (var group in categoryGroups)
            {
                categoryGroupDTOs.Add(_mapper.Map<CategoryGroupDTO>(group));
            }

            return categoryGroupDTOs;
        }

        public IList<CategoryDTO> GetAllCategories()
        {
            var categories = _unitOfWork.CategoryRepository.GetAll();
            var categoryDTOs = new List<CategoryDTO>();
            foreach (var category in categories)
            {
                categoryDTOs.Add(_mapper.Map<CategoryDTO>(category));
            }

            return categoryDTOs;
        }
    }
}
