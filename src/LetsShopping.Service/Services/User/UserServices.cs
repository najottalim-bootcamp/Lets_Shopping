namespace LetsShopping.Service.Services.User
{
    public class UserServices : IUserService
    {
        public ValueTask<bool> CreateUserAsync(string UserName)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> DeleteUserByIdAsync(int UserId)
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

        public ValueTask<bool> UpdateUserAsync(UsersDto UserName)
        {
            throw new NotImplementedException();
        }
    }
}
