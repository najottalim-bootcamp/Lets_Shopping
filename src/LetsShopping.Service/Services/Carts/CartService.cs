using LetsShopping.DataAccess.Repositories.CartsRepositories;
using LetsShopping.Domain.Dtos.CartsDtos;
using LetsShopping.Domain.Exceptions.Carts;
using LetsShopping.Domain.Exceptions.Users;
using LetsShopping.Domain.Models.Carts;
using LetsShopping.Domain.Models.Users;
using LetsShopping.Service.Interfaces.Carts;

namespace LetsShopping.Service.Services.Carts;

public class CartService : ICartService
{
    private readonly ICartRepository _cartRepository;
    public CartService(ICartRepository cartRepository)
    {
        _cartRepository = cartRepository;
    }

    public async ValueTask<int> CreateAsync(CartDto model)
    {
        int res = await _cartRepository.CreateAsync(model);
        if (res == 0)
        {
            throw new CartsNotFoundException();
        }
        return res;
    }

    public async ValueTask<int> DeleteAsync(int Id)
    {
        int res = await _cartRepository.DeleteAsync(Id);
        if (res == 0)
        {
            throw new CartsNotFoundException();
        }
        return res;
    }

    public async ValueTask<IList<Cart>> GetAllAsync()
    {
        IList<Cart> carts = (await _cartRepository.GetAllAsync());
        if (carts == null)
        {
            throw new UserNotFoundException();
        }
        return carts;
    }

    public async ValueTask<Cart> GetByIdAsync(int Id)
    {
        Cart cart = await _cartRepository.GetByIdAsync(Id);
        if (cart == null)
        {
            throw new CartsNotFoundException();
        }
        return cart;
    }

    public async ValueTask<int> UpdateAsync(int Id, CartDto model)
    {
        int update = await _cartRepository.UpdateAsync(Id, model);
        if (update == 0)
        {
            throw new CartsNotFoundException();
        }
        return update;
    }
}
