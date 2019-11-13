using DAL;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace TradingCompanyXUnitTests
{
    public static class TestHelper
    {
        public static IUnitOfWork GetUnitOfWorkForTesting()
        {
            var context = new TradingCompanyContext(
                new DbContextOptionsBuilder<TradingCompanyContext>()
                .UseInMemoryDatabase(databaseName: "test_database")
                .Options);

            return new UnitOfWork(context);
        }
    }
}
