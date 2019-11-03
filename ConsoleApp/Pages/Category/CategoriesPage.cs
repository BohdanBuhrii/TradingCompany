using DAL;
using DAL.Models;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using TradingCompany.ConsoleApp.Core;
using TradingCompany.ConsoleApp.Converter;

namespace TradingCompany.ConsoleApp.Pages
{
    public class CategoriesPage : ListView
    {
        private readonly IUnitOfWork _unitOfWork;
        private IEnumerable<Category> categories;

        public CategoriesPage()
        {
            _unitOfWork = DependencyInjectorDAL.Resolve<IUnitOfWork>();
            categories = _unitOfWork.CategoryRepository.GetAllAsync().Result;

            foreach (var category in categories)
            {
                buttons.Add(new Button
                {
                    Text = category.Name,
                    Entity = category,
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

        public string ToString(Category category) 
        {
            return category.Name;
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

            var category = new Category();
            try
            {
                Console.WriteLine("Name:");
                category.Name = Console.ReadLine();

                Console.WriteLine("IsActive:");
                category.IsActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("CategoryGroupId:");
                category.CategoryGroupId = Convert.ToInt32(Console.ReadLine());

                _unitOfWork.CategoryRepository.Add(category);
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