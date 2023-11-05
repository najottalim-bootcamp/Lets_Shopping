
using LetsShopping.Domain.Dtos.UsersDtos;
using LetsShopping.Domain.Models.Users;
using LetsShopping.Service.Dtos.UsersDtos;

namespace LetsShopping.DataAccess.Repositories.UserRepository;

public interface IUserRepository : IBaseRepository<User,UsersDto>
{

}
