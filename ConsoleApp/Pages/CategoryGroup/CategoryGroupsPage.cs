using DAL;
using DAL.Models;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using TradingCompany.ConsoleApp.Core;

namespace TradingCompany.ConsoleApp.Pages
{
    public class CategoryGroupsPage : ListView
    {
        private readonly IUnitOfWork _unitOfWork;
        private IEnumerable<CategoryGroup> categoryGroups;

        public CategoryGroupsPage()
        {
            _unitOfWork = DependencyInjectorDAL.Resolve<IUnitOfWork>();
            categoryGroups = _unitOfWork.CategoryGroupRepository.GetAllAsync().Result;

            foreach (var group in categoryGroups)
            {
                buttons.Add(new Button
                {
                    Text = ToString(group),
                    Entity = group,
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

        public string ToString(CategoryGroup categoryGroup) 
        {
            return categoryGroup.Name;
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

            var categoryGroup = new CategoryGroup();
            try
            {
                Console.WriteLine("Name:");
                categoryGroup.Name = Console.ReadLine();

                Console.WriteLine("IsActive:");
                categoryGroup.IsActive = Convert.ToBoolean(Console.ReadLine());

                _unitOfWork.CategoryGroupRepository.Add(categoryGroup);
                _unitOfWork.SaveChanges();
                ShowSuccessMessage("Entity created successfully");
            }
            catch (Exception)
            {
                ShowErrorMessage("Something wrong with data");
            }
            finally
            {
                var entitiesPage = new CategoriesPage();
                entitiesPage.Init();
            }
        }

        public virtual void ShowEntity()
        {
            var showPage = new CategoryPage((Category)buttons[CurrentPosition].Entity);
            showPage.Init();
        }
    }
}