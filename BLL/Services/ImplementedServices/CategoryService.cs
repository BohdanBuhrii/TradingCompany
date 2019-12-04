using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL.Services.Interfaces;
using DAL.UnitOfWork;
using DTO;
using DAL.Models;

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

        public void AddCategory(CategoryDTO category)
        {
            _unitOfWork.CategoryRepository.Add(_mapper.Map<Category>(category));
            _unitOfWork.SaveChanges();
        }

        public void AddCategoryGroup(CategoryGroupDTO categoryGroup)
        {
            _unitOfWork.CategoryGroupRepository.Add(_mapper.Map<CategoryGroup>(categoryGroup));
            _unitOfWork.SaveChanges();
        }

        public void RemoveCategory(int categoryId)
        {
            _unitOfWork.CategoryRepository.Remove(categoryId);
            _unitOfWork.SaveChanges();
        }

        public void RemoveCategoryGroup(int groupId)
        {
            _unitOfWork.CategoryGroupRepository.Remove(groupId);
            _unitOfWork.SaveChanges();
        }

        public bool CategoryExist(string categoryName)
        {
            return _unitOfWork.CategoryRepository
                .Get(c => c.Name == categoryName)
                .Any();
        }

        public bool CategoryGroupExist(string categoryGroupName)
        {
            return _unitOfWork.CategoryGroupRepository
                .Get(g => g.Name == categoryGroupName)
                .Any();
        }

        public CategoryGroupDTO GetGroupByName(string name)
        {
            return _mapper.Map<CategoryGroupDTO>(
                _unitOfWork.CategoryGroupRepository
                .Get(g => g.Name == name)
                .FirstOrDefault());
        }

        public void UpdateCategories(IEnumerable<CategoryDTO> categories)
        {
            foreach (var category in categories)
            {
                _mapper.Map(
                    category,
                    _unitOfWork.CategoryRepository.GetById(category.Id)
                );
            }

            _unitOfWork.SaveChanges();
        }

        public void UpdateCategoryGroups(IEnumerable<CategoryGroupDTO> groups)
        {
            foreach (var group in groups)
            {
                _mapper.Map(
                    group,
                    _unitOfWork.CategoryGroupRepository.GetById(group.Id)
                );
            }

            _unitOfWork.SaveChanges();
        }
    }
}
