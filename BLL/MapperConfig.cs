using AutoMapper;
using DAL.Models;
using DTO;

namespace BLL
{
    public static class MapperConfig
    {
        public static IMapper CreateMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<Role, RoleDTO>();
                cfg.CreateMap<RoleDTO, Role>()
                    .ForMember(r => r.Users, opt => opt.Ignore());
            }).CreateMapper();
        }
    }
}
