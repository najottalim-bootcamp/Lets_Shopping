using LetsShopping.Domain.Dtos.CardDtos;
using LetsShopping.Domain.Dtos.CartsDtos;
using LetsShopping.Domain.Dtos.UsersDtos;
using LetsShopping.Domain.Models.Cards;
using LetsShopping.Domain.Models.Carts;
using LetsShopping.Domain.Models.Category;
using LetsShopping.Domain.Models.Orders;

namespace LetsShopping.Service.Interfaces.Users
{
    public interface IUserService
    {
        public ValueTask<int> CreateUserAsync(UsersDto model);
        public ValueTask<int> UpdateUserAsync(int Id, UsersDto model);
        public ValueTask<int> DeleteUserAsync(int Id);
        public ValueTask<User> GetUserByIdAsync(int Id);
        public ValueTask<IList<User>> GetAllUserAsync();


        public ValueTask<int> CreateCartAsync(CartDto model);
        public ValueTask<int> UpdateCartAsync(int Id, CartDto model);
        public ValueTask<int> DeleteCartAsync(int Id);
        public ValueTask<Cart> GetCartByIdAsync(int Id);
        public ValueTask<IList<Cart>> GetAllCartAsync();


        public ValueTask<int> CreateCardAsync(CardDto model);
        public ValueTask<int> UpdateCardAsync(int Id, CardDto model);
        public ValueTask<int> DeleteCardAsync(int Id);
        public ValueTask<Card> GetCardByIdAsync(int Id);
        public ValueTask<IList<Card>> GetAllCardAsync();


        public ValueTask<IList<Product>> GetAllProduct();
        public ValueTask<IList<Category>> GetAllCategory();
        public ValueTask<IList<Domain.Models.Companies.Company>> GetAllCompany();
        public ValueTask<IList<Order>> GetAllOrderByUserId();


    }
}
