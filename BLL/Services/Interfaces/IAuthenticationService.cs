using DTO;
using System.Threading.Tasks;

namespace BLL.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<bool> CheckCredentials(CredentialsDTO credentials);
        Task<bool> UserExist(string login);
    }
}
