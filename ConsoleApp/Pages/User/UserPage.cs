using DAL;
using DAL.Models;
using DAL.UnitOfWork;
using System;
using System.Security.Cryptography;
using System.Text;
using TradingCompany.ConsoleApp.Converter;
using TradingCompany.ConsoleApp.Core;

namespace TradingCompany.ConsoleApp.Pages
{
    public class UserPage : Page
    {
        private readonly IUnitOfWork _unitOfWork;
        private User user;

        public UserPage(User user)
        {
            this.user = user;
            _unitOfWork = DependencyInjectorDAL.Resolve<IUnitOfWork>();


            buttons.Add(new Button { Text = user.ConvertToString(), ButtonAction = NullAction});
            buttons.Add(new Button { Text = "Edit entity", ButtonAction = EditEntity });
            buttons.Add(new Button { Text = "Delete entity", ButtonAction = DeleteEntity });
            buttons.Add(new Button { Text = "<-- back to entities", ButtonAction = ShowEntities });
        }

        public virtual void EditEntity()
        {
            ShowMessage("Enter new properties:");
            try
            {
                Console.WriteLine("Name:");
                user.Login = Console.ReadLine();

                Console.WriteLine("Email:");
                user.Email = Console.ReadLine();

                Console.WriteLine("Password:");
                user.PasswordHash = Hash(Console.ReadLine());

                Console.WriteLine("Role:");
                user.RoleId = Convert.ToInt32(Console.ReadLine());

                _unitOfWork.UserRepository.Update(user);
                _unitOfWork.SaveChanges();

                ShowSuccessMessage("Entity was updated successfully.");
            }
            catch (Exception)
            {
                ShowErrorMessage("Something wrong with data.");
            }
            finally
            {
                var userPage = new UserPage(user);
                userPage.Init();
            }
        }

        public virtual void DeleteEntity() 
        {
            try
            {
                _unitOfWork.UserRepository.Remove(user);
                _unitOfWork.SaveChanges();
                ShowSuccessMessage("Entity was deleted successfully.");
                ShowEntities();
            }
            catch (Exception)
            {
                ShowErrorMessage("You can't delete this entity");
            }
            finally
            {
                Init();
            }
        }

        public virtual void ShowEntities()
        {
            var userPage = new UsersPage();
            userPage.Init();
        }

        public string Hash(string str)
        {
            var hasher = MD5.Create();
            var hash = hasher.ComputeHash(Encoding.UTF8.GetBytes(str));
            var output = string.Empty;
            foreach (var b in hash)
            {
                output += b.ToString("X2");
            }

            return output;
        }
    }
}