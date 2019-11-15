using BLL;
using System.Diagnostics;
using System.Windows.Forms;
using TradingCompanyForms.Shared;

namespace TradingCompanyForms.Admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            //var form = DependencyInjectorBLL.Resolve<AuthenticationForm>();
            //form.Show();
            var a = Process.Start(
                @"D:\USERS\Buhrii_B\C#\SE\TradingCompany\ConsoleApp\bin\Debug\netcoreapp3.0\ConsoleApp.exe");
            this.Hide();
        }

        public new void Dispose()
        {
            base.Dispose();
            this.Parent.Dispose();
        }
    }
}
