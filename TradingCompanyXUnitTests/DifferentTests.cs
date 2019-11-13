using AutoMapper;
using DAL;
using DAL.Models;
using DAL.UnitOfWork;
using DTO;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace TradingCompanyXUnitTests
{
    public class DifferentTests
    {
        [Fact]
        public void Repository_Can_Add_And_Get_Entities()
        {
            var unitOfWork = TestHelper.GetUnitOfWorkForTesting();
            
            var testRole = unitOfWork.RoleRepository.Add(new Role { Name = "TestRole" });

            unitOfWork.SaveChanges();

            var role = unitOfWork.RoleRepository.GetByIdAsync(testRole.Id).Result;

            Assert.NotNull(role);
            Assert.Equal(testRole, role);
            Assert.Equal("TestRole", role.Name);
        }

        [Fact]
        public void Update_Mapped_Entities()
        {
            var unitOfWork = TestHelper.GetUnitOfWorkForTesting();
            var mapper = new MapperConfiguration(cfg => {
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<Role, RoleDTO>();
                cfg.CreateMap<RoleDTO, Role>().ForMember(r => r.Users, opt => opt.Ignore());
            }).CreateMapper();

            var testRole = unitOfWork.RoleRepository.Add(new Role { Name = "TestRole" });

            var role = mapper.Map<Role, RoleDTO>(testRole);
            role.Name = "TEST";

            var model = mapper.Map<RoleDTO, Role>(role);

            unitOfWork.RoleRepository.Update(model);

            unitOfWork.SaveChanges();

            Assert.Equal("TEST", unitOfWork.RoleRepository.GetByIdAsync(testRole.Id).Result.Name);
        }

        [Fact]
        public void Some_Test()
        {
            var context = new TradingCompanyContext();
            
        }
    }
}
