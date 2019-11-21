using DTO;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> GetUserById(int userId);

        Task<UserDTO> GetUserByEmail(string userEmail);

        Task<UserDTO> AddUser(UserDTO user);

        Task<UserDTO> UpdateUser(UserDTO user);

        Task RemoveUser();
    }
}
