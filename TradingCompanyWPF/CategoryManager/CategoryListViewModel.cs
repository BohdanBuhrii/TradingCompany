using BLL.Services.Interfaces;
using DTO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TradingCompanyWPF.CategoryManager
{
    public class CategoryListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly ICategoryService _categoryService;
        

        public ObservableCollection<CategoryDTO> Categories { get; set; }
        public IList<CategoryGroupDTO> CategoryGroups { get; private set; }

        private CategoryDTO _selectedCategory;

        public CategoryDTO SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                OnPropertyChanged("SelectedCategory");
            }
        }

        public CategoryListViewModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            CategoryGroups = _categoryService.GetAllCategoryGroups();
            Filter();
        }

        public string Name
        {
            get { return _selectedCategory.Name; }
            set
            {
                _selectedCategory.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public bool? IsActive
        {
            get { return _selectedCategory.IsActive; }
            set
            {
                _selectedCategory.IsActive = value;
                OnPropertyChanged("IsActive");
            }
        }

        public string CategoryGroupName
        {
            get { return _selectedCategory.CategoryGroup.Name; }
            set
            {
                _selectedCategory.CategoryGroup.Name = value;
                OnPropertyChanged("CategoryGroup.Name");
            }
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void Filter(string filter = "")
        {
            Categories = new ObservableCollection<CategoryDTO>(_categoryService.FilterCategories(filter));
        }

        public void Refresh()
        {
            CategoryGroups = _categoryService.GetAllCategoryGroups();
            Categories = new ObservableCollection<CategoryDTO>(_categoryService.GetAllCategories());
        }
    }
}
