using BLL.Services.Interfaces;
using DAL.UnitOfWork;
using DTO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.ImplementedServices
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthenticationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CheckCredentials(CredentialsDTO credentials)
        {
            return (await _unitOfWork.UserRepository
                .GetAsync(u => u.Login == credentials.Login))
                .Any(u => u.PasswordHash == Hash(credentials.Password));
        }

        public async Task<bool> UserExist(string email)
        {
            return (await _unitOfWork.UserRepository
                .GetAsync(u => u.Email == email))
                .Any();
        }

        public string Hash(string str)
        {
            var hasher = MD5.Create();
            var hash = hasher.ComputeHash(Encoding.UTF8.GetBytes(str));
            var output = string.Empty;
            foreach (var b in hash)
            {
                output += b.ToString("X2");
            }

            return output;
        }
    }
}
