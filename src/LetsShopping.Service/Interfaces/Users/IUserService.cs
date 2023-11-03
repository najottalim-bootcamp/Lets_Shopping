using LetsShopping.Domain.Models.Users;
using LetsShopping.Service.Dtos.UsersDtos;
namespace LetsShopping.Service.Interfaces.Users
{
    public interface IUserService
    {
        public ValueTask<bool> CreateUserAsync(string UserName);
        public ValueTask<bool> UpdateUserAsync(UsersDto UserName);
        public ValueTask<bool> DeleteUserByIdAsync(int UserId);
        public ValueTask<List<User>> GetAllAsync(string Tablename);
        public ValueTask<User> GetByIdUser(int UserId, string Tablename);

    }
}
