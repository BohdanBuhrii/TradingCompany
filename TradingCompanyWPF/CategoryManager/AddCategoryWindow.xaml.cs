using BLL;
using BLL.Services.Interfaces;
using DTO;
using System;
using System.Windows;

namespace TradingCompanyWPF.CategoryManager
{
    /// <summary>
    /// Interaction logic for AddCategoryWindow.xaml
    /// </summary>
    public partial class AddCategoryWindow : Window
    {
        private readonly ICategoryService _categoryService;

        public AddCategoryWindow()
        {
            _categoryService = DependencyInjectorBLL.Resolve<ICategoryService>();

            InitializeComponent();

            foreach(var group in _categoryService.GetAllCategoryGroups())
            GroupCB.Items.Add(group.Name);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveBtn.IsEnabled = false;

            _categoryService.AddCategory(new CategoryDTO
            {
                Name = NameTB.Text,
                IsActive = IsActiveCB.IsChecked,
                CategoryGroup = _categoryService.GetGroupByName(GroupCB.SelectedItem.ToString())
            });


            this.Close();
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            if (_categoryService.CategoryExist(NameTB.Text))
            {
                SaveBtn.IsEnabled = false;
                AlertLabel.Visibility = Visibility.Visible;
            }
            else
            {
                if (GroupCB.SelectedItem?.ToString().Length > 0)
                {
                    SaveBtn.IsEnabled = true;
                }

                AlertLabel.Visibility = Visibility.Hidden;
            }
        }

        private void GroupCB_SelectionChanged(object sender, EventArgs e)
        {
            if (NameTB.Text.Length > 0)
            {
                SaveBtn.IsEnabled = true;
            }
        }
    }
}
