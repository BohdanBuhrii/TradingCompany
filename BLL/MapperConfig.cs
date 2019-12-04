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
                cfg.CreateMap<User, UserDTO>()
                    .ReverseMap();

                cfg.CreateMap<Role, RoleDTO>();
                cfg.CreateMap<RoleDTO, Role>()
                    .ForMember(r => r.Users, opt => opt.Ignore());

                cfg.CreateMap<Category, CategoryDTO>();
                cfg.CreateMap<CategoryDTO, Category>()
                    .ForMember(c => c.CategoryGroupId,
                               opt => opt.MapFrom(cDTO => cDTO.CategoryGroup.Id))
                    .ForMember(c => c.CategoryDiscounts, opt => opt.Ignore())
                    .ForMember(c => c.Products, opt => opt.Ignore())
                    .ForMember(c => c.CategoryGroup, opt => opt.Ignore());

                cfg.CreateMap<CategoryGroup, CategoryGroupDTO>();
                cfg.CreateMap<CategoryGroupDTO, CategoryGroup>();
            }).CreateMapper();
        }
    }
}
