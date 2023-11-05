
using LetsShopping.Domain.Models.Users;
using LetsShopping.Domain.Dtos.UsersDtos;

namespace LetsShopping.DataAccess.Repositories.UserRepository;

public interface IUserRepository : IBaseRepository<User,UsersDto>
{

}
