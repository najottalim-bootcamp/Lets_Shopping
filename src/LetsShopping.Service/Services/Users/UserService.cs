using LetsShopping.DataAccess.Repositories.UserRepository;
using LetsShopping.Domain.Dtos.UsersDtos;
using LetsShopping.Domain.Exceptions.Users;

namespace LetsShopping.Service.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async ValueTask<int> CreateAsync(UsersDto model)
        {
            int res = await _userRepository.CreateAsync(model);
            if (res == 0)
            {
                throw new UserNotFoundException();
            }
            return res;
        }

        public async ValueTask<int> DeleteAsync(int Id)
        {
            int res = await _userRepository.DeleteAsync(Id);
            if (res == 0)
            {
                throw new UserNotFoundException();
            }
            return res;
        }

        public async ValueTask<IList<User>> GetAllAsync()
        {
            IList<User> users = (await _userRepository.GetAllAsync());
            if (users == null)
            {
                throw new UserNotFoundException();
            }
            return users;
        }

        public ValueTask<IList<Order>> GetAllOrderByUserId()
        {
            throw new NotImplementedException();
        }

        public async ValueTask<User> GetByIdAsync(int Id)
        {
            User user = await _userRepository.GetByIdAsync(Id);
            if (user == null)
            {
                throw new UserNotFoundException();
            }
            return user;
        }

        public async ValueTask<int> UpdateAsync(int Id, UsersDto model)
        {
            int update = await _userRepository.UpdateAsync(Id, model);
            if (update == 0)
            {
                throw new UserNotFoundException();
            }
            return update;
        }
    }
}
