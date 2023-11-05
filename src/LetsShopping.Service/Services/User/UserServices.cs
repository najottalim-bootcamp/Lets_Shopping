namespace LetsShopping.Service.Services.User
{
    public class UserServices : IUserService
    {
        public ValueTask<int> CreateUserAsync(UsersDto usersDto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> CreateUserAsync(string UserName)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteUserByIdAsync(int UserId)
        {
            throw new NotImplementedException();
        }

        public ValueTask<List<Domain.Models.Users.User>> GetAllAsync(string Tablename)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Domain.Models.Users.User> GetByIdUser(int UserId, string Tablename)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateUserAsync(int UserId, UsersDto UserName)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> UpdateUserAsync(UserDto UserName)
        {
            throw new NotImplementedException();
        }

        ValueTask<bool> IUserService.DeleteUserByIdAsync(int UserId)
        {
            throw new NotImplementedException();
        }
    }
}
