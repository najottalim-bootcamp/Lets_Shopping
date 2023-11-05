using global::LetsShopping.DataAccess.Repositories.UserRepository;

namespace LetsShopping.Service.Interfaces.Users
{
    public interface IUserService : IUserRepository
    {
        ValueTask<IList<Order>> GetAllOrderByUserId();
    }
}
