using BLL;
using System.Windows;
using TradingCompanyWPF.CategoryManager;

namespace TradingCompanyWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = DependencyInjectorBLL.Resolve<CategoryListWindow>();
            mainWindow.Show();
        }
    }
}
