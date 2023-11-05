using LetsShopping.Domain.Dtos.UsersDtos;

namespace LetsShopping.Service.Services.User
{
    public class UserServices : IUserService
    {
        public ValueTask<int> CreateAsync(UsersDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Domain.Models.Users.User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Domain.Models.Users.User> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateAsync(int Id, UsersDto model)
        {
            throw new NotImplementedException();
        }
    }
}
