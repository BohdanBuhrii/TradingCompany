using DAL;
using DAL.UnitOfWork;
using System;
using TradingCompany.ConsoleApp.Core;

namespace TradingCompany.ConsoleApp.Pages
{
    public class TablesPage : Page
    {
        public TablesPage()
        {
            buttons.Add(new Button { Text = "Categories", ButtonAction = ShowCategories });
            buttons.Add(new Button { Text = "CategoryGroups", ButtonAction = ShowCategoryGroups });
            buttons.Add(new Button { Text = "Roles", ButtonAction = ShowRoles });
            buttons.Add(new Button { Text = "Users", ButtonAction = ShowUsers });
            buttons.Add(new Button { Text = "<Exit", ButtonAction = Exit });
        }

        public void ShowCategories()
        {
            var categoryPage = new CategoriesPage();
            categoryPage.Init();
        }

        public void ShowCategoryGroups()
        {
            var categoryGroupsPage = new CategoryGroupsPage();
            categoryGroupsPage.Init();
        }

        public void ShowRoles()
        {
            var rolePage = new RolesPage();
            rolePage.Init();
        }

        public void ShowUsers()
        {
            var usersPage = new UsersPage();
            usersPage.Init();
        }
    }
}
