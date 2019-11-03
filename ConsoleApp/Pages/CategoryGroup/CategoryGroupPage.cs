using DAL;
using DAL.Models;
using DAL.UnitOfWork;
using System;
using TradingCompany.ConsoleApp.Converter;
using TradingCompany.ConsoleApp.Core;

namespace TradingCompany.ConsoleApp.Pages
{
    public class CategoryGroupPage : Page
    {
        private readonly IUnitOfWork _unitOfWork;
        private CategoryGroup categoryGroup;

        public CategoryGroupPage(CategoryGroup categoryGroup)
        {
            this.categoryGroup = categoryGroup;
            _unitOfWork = DependencyInjectorDAL.Resolve<IUnitOfWork>();


            buttons.Add(new Button { Text = categoryGroup.ConvertToString(), ButtonAction = NullAction});
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
                categoryGroup.Name = Console.ReadLine();

                Console.WriteLine("IsActive:");
                categoryGroup.IsActive = Convert.ToBoolean(Console.ReadLine());

                _unitOfWork.CategoryGroupRepository.Update(categoryGroup);
                _unitOfWork.SaveChanges();

                ShowSuccessMessage("Entity was updated successfully.");
            }
            catch (Exception)
            {
                ShowErrorMessage("Something wrong with data.");
            }
            finally
            {
                var categoryGroupPage = new CategoryGroupPage(categoryGroup);
                categoryGroupPage.Init();
            }
        }

        public virtual void DeleteEntity() 
        {
            try
            {
                _unitOfWork.CategoryGroupRepository.Remove(categoryGroup);
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
            var categoryGroupsPage = new CategoryGroupsPage();
            categoryGroupsPage.Init();
        }
    }
}