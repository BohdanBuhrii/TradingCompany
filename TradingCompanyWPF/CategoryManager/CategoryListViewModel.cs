using BLL.Services.Interfaces;
using DTO;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TradingCompanyWPF.CategoryManager
{
    public class CategoryListViewModel : INotifyPropertyChanged
    {
        private readonly ICategoryService _categoryService;
        private CategoryDTO selectedCategory;

        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<CategoryDTO> Categories;

        public CategoryListViewModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            Categories = new ObservableCollection<CategoryDTO>(_categoryService.GetAllCategories());            
        }

        public CategoryDTO SelectedCategory
        {
            get { return selectedCategory ; }
            set
            {
                selectedCategory = value;
                OnPropertyChanged("SelectedCategory");
            }
        }

        public string Name
        {
            get { return selectedCategory.Name; }
            set
            {
                selectedCategory.Name = value;
                OnPropertyChanged("Name");
            }
        }



        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
