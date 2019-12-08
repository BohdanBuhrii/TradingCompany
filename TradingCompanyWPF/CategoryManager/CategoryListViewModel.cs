using BLL.Services.Interfaces;
using DTO;
using System.Collections.ObjectModel;
using System.ComponentModel;
using BLL.Extentions;
using System.Runtime.CompilerServices;

namespace TradingCompanyWPF.CategoryManager
{
    public class CategoryListViewModel : INotifyPropertyChanged
    {
        private readonly ICategoryService _categoryService;
        private CategoryDTO _selectedCategory;

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<CategoryDTO> Categories { get; set; }
        public ObservableCollection<CategoryGroupDTO> CategoryGroups { get; private set; }

        public CategoryListViewModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            Categories = new ObservableCollection<CategoryDTO>(_categoryService.GetAllCategories());
            CategoryGroups = new ObservableCollection<CategoryGroupDTO>(_categoryService.GetAllCategoryGroups());
            _selectedCategory = Categories[0];
        }

        public CategoryDTO SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                OnPropertyChanged("SelectedCategory");
            }
        }

        public string Name
        {
            get { return _selectedCategory?.Name; }
            set
            {
                _selectedCategory.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public bool? IsActive
        {
            get { return _selectedCategory?.IsActive; }
            set
            {
                _selectedCategory.IsActive = value;
                OnPropertyChanged("IsActive");
            }
        }

        public CategoryGroupDTO CategoryGroup
        {
            get { return _selectedCategory?.CategoryGroup; }
            set
            {
                _selectedCategory.CategoryGroup = value;
                OnPropertyChanged("SelectedCategoryGroup");
            }
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void Filter(string filter = "")
        {
            Categories.UseNewSource(_categoryService.FilterCategories(filter));
        }

        public void Refresh()
        {
            Categories.UseNewSource(_categoryService.GetAllCategories());
            CategoryGroups.UseNewSource(_categoryService.GetAllCategoryGroups());
        }
    }
}
