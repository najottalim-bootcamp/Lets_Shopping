namespace LetsShopping.Service.Interfaces.Users
{
    public interface IUserService
    {
        public ValueTask<int> CreateUserAsync(UsersDto usersDto);
        public ValueTask<int> UpdateUserAsync(int UserId,UsersDto UserName);
        public ValueTask<int> DeleteUserByIdAsync(int UserId);
        public ValueTask<List<User>> GetAllAsync(string Tablename);
        public ValueTask<User> GetByIdUser(int UserId, string Tablename);

    }
}
