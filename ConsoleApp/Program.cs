using DAL;
using DAL.Models;
using DAL.UnitOfWork;
using System;
using System.Threading.Tasks;
using TradingCompany.ConsoleApp.Pages;

namespace TradingCompany
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            //var unitOfWork = new UnitOfWork();

            //var a = unitOfWork.CategoryRepository.GetByIdAsync(1).Result;
            //var d = unitOfWork.CategoryGroupRepository.AddAsync(
            //    new CategoryGroup 
            //{ Name="knjkooooooooooook", IsActive=true }).Result;

            //unitOfWork.SaveChanges();
            //var a = await unitOfWork.ManufacturerRepository.GetAllAsync();

            //unitOfWork.ManufacturerRepository.AddAsync(new Manufacturer { Name = "Olesya" });
            //Console.WriteLine(unitOfWork.SaveChangesAsync());
            //var a = await unitOfWork.ManufacturerRepository.GetByIdAsync(1);

            //unitOfWork.ManufacturerRepository.Remove(a);

            var page = new TablesPage();
            page.Init();

            //DateTime dateTime = new DateTime();
            //string a = dateTime.ToString();//.ToShortDateString();
            //Console.ReadLine();
        }
    }
}
