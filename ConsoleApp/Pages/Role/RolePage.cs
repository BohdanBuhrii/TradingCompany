using DAL;
using DAL.Models;
using DAL.UnitOfWork;
using System;
using TradingCompany.ConsoleApp.Converter;
using TradingCompany.ConsoleApp.Core;

namespace TradingCompany.ConsoleApp.Pages
{
    public class RolePage : Page
    {
        private readonly IUnitOfWork _unitOfWork;
        private Role role;

        public RolePage(Role role)
        {
            this.role = role;
            _unitOfWork = DependencyInjectorDAL.Resolve<IUnitOfWork>();


            buttons.Add(new Button { Text = role.ConvertToString(), ButtonAction = NullAction});
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
                role.Name = Console.ReadLine();

                _unitOfWork.RoleRepository.Update(role);
                _unitOfWork.SaveChanges();

                ShowSuccessMessage("Entity was updated successfully.");
            }
            catch (Exception)
            {
                ShowErrorMessage("Something wrong with data.");
            }
            finally
            {
                var rolePage = new RolePage(role);
                rolePage.Init();
            }
        }

        public virtual void DeleteEntity() 
        {
            try
            {
                _unitOfWork.RoleRepository.Remove(role);
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
            var rolePage = new RolesPage();
            rolePage.Init();
        }
    }
}