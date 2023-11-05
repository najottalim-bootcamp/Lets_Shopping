

using LetsShopping.Domain.Dtos.CartsDtos;
using LetsShopping.Domain.Models.Carts;

namespace LetsShopping.DataAccess.Repositories.CartsRepositories;

public interface ICartRepository : IBaseRepository<Cart, CartDto>
{

}
