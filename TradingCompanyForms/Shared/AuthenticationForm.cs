using BLL;
using BLL.Services.Interfaces;
using DTO;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using TradingCompanyForms.Admin;
using TradingCompanyForms.CategoryManager;
using Unity.Resolution;

namespace TradingCompanyForms.Shared
{
    public partial class AuthenticationForm : Form
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;

        public AuthenticationForm(
            IAuthenticationService authenticationService,
            IUserService userService)
        {
            _authenticationService = authenticationService;
            _userService = userService;

            InitializeComponent();
        }

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {

        }

        private async void LogInBtn_Click(object sender, EventArgs e)
        {
            this.LogInBtn.Enabled = false;
            if (await _authenticationService.UserExist(this.EmailTB.Text))
            {
                if (await _authenticationService.CheckCredentials(
                    new CredentialsDTO
                    {
                        Email = this.EmailTB.Text,
                        Password = this.PasswordTB.Text
                    }))
                {
                    var user = await _userService.GetUserByEmail(this.EmailTB.Text);
                    var form = user.Role.Name switch
                    {
                        "CategoryManager" => 
                            (Form)DependencyInjectorBLL
                            .Resolve<CategoriesForm>(new ParameterOverride("user", user)),
                        "Admin" => 
                            (Form)DependencyInjectorBLL.Resolve<AdminForm>(),
                        _ => (Form)DependencyInjectorBLL.Resolve<AuthenticationForm>()

                    };
                    
                    form.Show();
                    this.Hide();
                }
                else
                { 
                    MessageBox.Show("Incorrect credentials", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User not found", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.LogInBtn.Enabled = true;
        }
    }
}
