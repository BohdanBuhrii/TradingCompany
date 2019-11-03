using DAL;
using DAL.Models;
using DAL.UnitOfWork;
using System;
using TradingCompany.ConsoleApp.Converter;
using TradingCompany.ConsoleApp.Core;

namespace TradingCompany.ConsoleApp.Pages
{
    public class CategoryPage : Page
    {
        private readonly IUnitOfWork _unitOfWork;
        private Category category;

        public CategoryPage(Category category)
        {
            this.category = category;
            _unitOfWork = DependencyInjectorDAL.Resolve<IUnitOfWork>();


            buttons.Add(new Button { Text = category.ConvertToString(), ButtonAction = NullAction});
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
                category.Name = Console.ReadLine();

                Console.WriteLine("IsActive:");
                category.IsActive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("CategoryGroupId:");
                category.CategoryGroupId = Convert.ToInt32(Console.ReadLine());

                _unitOfWork.CategoryRepository.Update(category);
                _unitOfWork.SaveChanges();

                ShowSuccessMessage("Entity was updated successfully.");
            }
            catch (Exception)
            {
                ShowErrorMessage("Something wrong with data.");
            }
            finally
            {
                var categoryPage = new CategoryPage(category);
                categoryPage.Init();
            }
        }

        public virtual void DeleteEntity() 
        {
            try
            {
                _unitOfWork.CategoryRepository.Remove(category);
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
            var categoryPage = new CategoriesPage();
            categoryPage.Init();
        }
    }
}