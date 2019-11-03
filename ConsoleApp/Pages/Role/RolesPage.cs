using DAL;
using DAL.Models;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using TradingCompany.ConsoleApp.Core;

namespace TradingCompany.ConsoleApp.Pages
{
    public class RolesPage : ListView
    {
        private readonly IUnitOfWork _unitOfWork;
        private IEnumerable<Role> roles;

        public RolesPage()
        {
            _unitOfWork = DependencyInjectorDAL.Resolve<IUnitOfWork>();
            roles = _unitOfWork.RoleRepository.GetAllAsync().Result;

            foreach (var role in roles)
            {
                buttons.Add(new Button
                {
                    Text = ToString(role),
                    Entity = role,
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

        public string ToString(Role role) 
        {
            return role.Name;
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

            var role = new Role();
            try
            {
                Console.WriteLine("Name:");
                role.Name = Console.ReadLine();

                _unitOfWork.RoleRepository.Add(role);
                _unitOfWork.SaveChanges();
                ShowSuccessMessage("Entity created successfully");
            }
            catch (Exception)
            {
                ShowErrorMessage("Something wrong with data");
            }
            finally
            {
                var entitiesPage = new RolesPage();
                entitiesPage.Init();
            }
        }

        public virtual void ShowEntity()
        {
            var showPage = new RolePage((Role)buttons[CurrentPosition].Entity);
            showPage.Init();
        }
    }
}