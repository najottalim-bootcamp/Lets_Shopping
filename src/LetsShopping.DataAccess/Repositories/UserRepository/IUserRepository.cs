

using LetsShopping.Domain.Models.Users;


namespace LetsShopping.DataAccess.Repositories.UserRepository;

public class IUserRepository
{
    ValueTask<bool> Create(UserDto user);
    ValueTask<bool> Delete(int Id);
    ValueTask<IEnumerable<User>> GetAll();
    ValueTask<User> GetById(int Id, UserDto user);
    ValueTask<bool> Update(UserDto user);
}
