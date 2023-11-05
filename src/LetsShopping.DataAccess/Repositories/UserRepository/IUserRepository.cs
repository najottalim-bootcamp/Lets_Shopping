
using LetsShopping.Domain.Dtos.UsersDtos;
using LetsShopping.Domain.Models.Users;


namespace LetsShopping.DataAccess.Repositories.UserRepository;

public interface IUserRepository : IBaseRepository<User,UsersDto>
{

}
