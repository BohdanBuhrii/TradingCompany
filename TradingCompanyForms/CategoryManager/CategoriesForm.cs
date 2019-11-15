using BLL;
using DTO;
using System.Windows.Forms;
using TradingCompanyForms.Shared;

namespace TradingCompanyForms.CategoryManager
{
    public partial class CategoriesForm : Form
    {
        private readonly UserDTO _user;

        public CategoriesForm(UserDTO user)
        {
            _user = user;

            InitializeComponent();

            this.LoginLbl.Text = _user.Login;
            this.Refresh();
        }

        private void LogOutBtn_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
            var form = DependencyInjectorBLL.Resolve<AuthenticationForm>();
            form.Show();
        }

        public new void Dispose()
        {
            base.Dispose();
            this.Parent.Dispose();
        }
    }
}
