using LetsShopping.Domain.Dtos.UsersDtos;

namespace LetsShopping.Service.Services.UserService
{
    public class UserServicesBase
    {

        public ValueTask<int> CreateUserAsync(UsersDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateUserAsync(int Id, UsersDto model)
        {
            throw new NotImplementedException();
        }
    }
}