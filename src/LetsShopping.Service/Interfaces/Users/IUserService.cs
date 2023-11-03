

using LetsShopping.Service.Dtos.UsersDtos;

namespace LetsShopping.Service.Interfaces.Users
{
    public interface IUserService
    {
        public Task<bool> CreateUserAsync(string UserName);
        public Task<bool> UpdateUserAsync(UsersDto UserName);
        public Task<bool> DeleteUserByIdAsync(int UserId);
        public Task<IEnumerable<Domain.Models.Users.Users>> GetAllAsync();
    }
}
