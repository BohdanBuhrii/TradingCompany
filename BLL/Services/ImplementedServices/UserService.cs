using System.Threading.Tasks;
using BLL.Services.Interfaces;
using DTO;

namespace BLL.Services.ImplementedServices
{
    public class UserService : IUserService
    {
        public Task<UserDTO> CreateUser(UserDTO user)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserDTO> GetUserByEmail(string userEmail)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserDTO> GetUserById(int userId)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveUser()
        {
            throw new System.NotImplementedException();
        }

        public Task<UserDTO> UpdateUser(UserDTO user)
        {
            throw new System.NotImplementedException();
        }
    }
}
