using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Services.Interfaces;
using DAL.Models;
using DAL.UnitOfWork;
using DTO;

namespace BLL.Services.ImplementedServices
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UserDTO> AddUser(UserDTO user)
        {
            return _mapper.Map<UserDTO>((
                await _unitOfWork.UserRepository
                .AddAsync(_mapper.Map<User>(user))));
        }

        public async Task<UserDTO> GetUserByEmail(string userEmail)
        {
            return _mapper.Map<UserDTO>((
                await _unitOfWork.UserRepository
                .GetAsync(u => u.Email == userEmail))
                .FirstOrDefault());
        }

        public async Task<UserDTO> GetUserById(int userId)
        {
            return _mapper.Map<UserDTO>((
                await _unitOfWork.UserRepository
                .GetByIdAsync(userId)));
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
