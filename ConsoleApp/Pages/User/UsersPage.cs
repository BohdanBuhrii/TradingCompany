using DAL;
using DAL.Models;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using TradingCompany.ConsoleApp.Core;

namespace TradingCompany.ConsoleApp.Pages
{
    public class UsersPage : ListView
    {
        private readonly IUnitOfWork _unitOfWork;
        private IEnumerable<User> users;

        public UsersPage()
        {
            _unitOfWork = DependencyInjectorDAL.Resolve<IUnitOfWork>();
            users = _unitOfWork.UserRepository.GetAllAsync().Result;

            foreach (var user in users)
            {
                buttons.Add(new Button
                {
                    Text = ToString(user),
                    Entity = user,
                    ButtonAction = ShowEntity,
                    AbilityToChange = false,
                    BackgroundColor = ConsoleColor.DarkYellow
                });

            }

            buttons.Add(new Button
            {
                Text = "Add new entity",
                ButtonAction = AddNewEntity,
                AbilityToChange = false,
                BackgroundColor = ConsoleColor.DarkYellow
            });
            buttons.Add(new Button
            {
                Text = "<-- back to Tables' Page",
                ButtonAction = BackToTablesPage,
                AbilityToChange = false,
                BackgroundColor = ConsoleColor.DarkYellow
            });
        }

        public string ToString(User user) 
        {
            return user.Login;
        }

        public void BackToTablesPage()
        {
            var tablesPage = new TablesPage();
            tablesPage.Init();
        }

        public virtual void AddNewEntity()
        {
            Console.Clear();

            ShowMessage("Creating new entity");

            var user = new User();
            try
            {
                Console.WriteLine("Login:");
                user.Login = Console.ReadLine();

                Console.WriteLine("Email:");
                user.Email = Console.ReadLine();

                Console.WriteLine("Password:");
                user.PasswordHash = Console.ReadLine();
                
                Console.WriteLine("Role:");
                user.RoleId = Convert.ToInt32(Console.ReadLine());
                

                _unitOfWork.UserRepository.Add(user);
                _unitOfWork.SaveChanges();
                ShowSuccessMessage("Entity created successfully");
            }
            catch (Exception)
            {
                ShowErrorMessage("Something wrong with data");
            }
            finally
            {
                var entitiesPage = new UsersPage();
                entitiesPage.Init();
            }
        }

        public virtual void ShowEntity()
        {
            var showPage = new UserPage((User)buttons[CurrentPosition].Entity);
            showPage.Init();
        }
    }
}