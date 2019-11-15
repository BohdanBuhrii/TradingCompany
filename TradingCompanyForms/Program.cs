using BLL;
using System;
using System.Windows.Forms;
using TradingCompanyForms.Shared;

namespace TradingCompanyForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(DependencyInjectorBLL.Resolve<AuthenticationForm>());
        }
    }
}
