using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradingCompany.ConsoleApp.Converter
{
    public static class ToStringConverter
    {
        public static string ConvertToString(this Category category)
        {
            return $"Id: {category.Id}, Name: { category.Name }, IsActive: { category.IsActive }, CategoryGroupId: { category.CategoryGroupId }";
        }
        public static string ConvertToString(this CategoryGroup categoryGroup)
        {
            return $"Id: {categoryGroup.Id }, Name: {categoryGroup.Name}, IsActive: {categoryGroup.IsActive}";
        }

        public static string ConvertToString(this User user)
        {
            return $"Id: {user.Id}, Login: {user.Login}, Email: {user.Email}, Password: {user.PasswordHash}, RoleId: {user.RoleId}";
        }

        public static string ConvertToString(this Role role)
        {
            return $"Id: {role.Id}, Name: {role.Name}";
        }
    }
}
