using BLL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TradingCompanyWPF.CategoryManager
{
    /// <summary>
    /// Interaction logic for CategoryList.xaml
    /// </summary>
    public partial class CategoryList : Page
    {
        public CategoryList()
        {
            InitializeComponent();
            DataContext = DependencyInjectorBLL.Resolve<CategoryListViewModel>();
        }

        public void CategoryGrid_MouseDoubleClick(MouseButtonEventHandler e) { }
    }
}
