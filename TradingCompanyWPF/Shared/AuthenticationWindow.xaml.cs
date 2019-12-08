using BLL;
using BLL.Services.Interfaces;
using DTO;
using System;
using System.Windows;
using TradingCompanyWPF.CategoryManager;

namespace TradingCompanyWPF.Shared
{
    /// <summary>
    /// Interaction logic for AuthenticationWindow.xaml
    /// </summary>
    public partial class AuthenticationWindow : Window
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;

        public AuthenticationWindow(
            IAuthenticationService authenticationService,
            IUserService userService)
        {
            _authenticationService = authenticationService;
            _userService = userService;

            InitializeComponent();
        }

        private async void LogInBtn_Click(object sender, EventArgs e)
        {
            this.LogInBtn.IsEnabled = false;
            if (await _authenticationService.UserExist(this.EmailTB.Text))
            {
                if (await _authenticationService.CheckCredentials(
                    new CredentialsDTO
                    {
                        Email = this.EmailTB.Text,
                        Password = this.PasswordTB.Password
                    }))
                {
                    var user = await _userService.GetUserByEmail(this.EmailTB.Text);
                    var form = user.Role.Name switch
                    {
                        "CategoryManager" =>
                            (Window)DependencyInjectorBLL
                            .Resolve<CategoryListWindow>(),
                        //"Admin" => (Window)DependencyInjectorBLL.Resolve<AdminWindow>(),
                        _ => (Window)DependencyInjectorBLL.Resolve<AuthenticationWindow>()

                    };

                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect credentials", "Login error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("User not found", "Login error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            this.LogInBtn.IsEnabled = true;
        }
    }
}
