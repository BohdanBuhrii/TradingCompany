using BLL.Services.Interfaces;
using DTO;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace TradingCompanyWPF.CategoryManager
{
    /// <summary>
    /// Interaction logic for CategoryListWindow.xaml
    /// </summary>
    public partial class CategoryListWindow : Window
    {
        private CategoryListViewModel _viewModel;
        private readonly ICategoryService _categoryService;

        public CategoryListWindow(CategoryListViewModel viewModel, ICategoryService categoryService)
        {
            _viewModel = viewModel;
            _categoryService = categoryService;
            DataContext = _viewModel;

            InitializeComponent();
            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(CategoriesDG.ItemsSource);
            //view.Filter = SatisfyFilter;
        }

        private bool SatisfyFilter(object obj)
        {
            return (obj as CategoryDTO).Name.ToLower().Contains(FilterTB.Text.Trim().ToLower());
        }

        private void CategoriesDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //throw new NotImplementedException();//role_cmbbx.Text = _viewModel.SelectedRole.RoleDescription;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (CategoriesDG.SelectedItems.Count > 0)
            {
                CategoryDTO user = new CategoryDTO();
                var dialog = MessageBox.Show("Are you sure?", "Update", MessageBoxButton.YesNo);

                if (dialog == MessageBoxResult.Yes)
                {
                    throw new NotImplementedException();/*
                    user = _viewModel.SelectedCategory;
                    user.FirstName = NameTB.Text;
                    _categoryService.Update(user);*/
                }
                CategoriesDG.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Choose user");
            }
        }

        private void FilterTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            _viewModel.Filter(FilterTB.Text);
        }

        private void AddCategoryBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Refresh();
        }
    }

}
