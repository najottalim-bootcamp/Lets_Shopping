using LetsShopping.Domain.Dtos.UsersDtos;

namespace LetsShopping.Service.Services.User
{
    public class UserServices : IUserService
    {
        public ValueTask<int> CreateCardAsync(CardDto model)
        public ValueTask<int> CreateAsync(UsersDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> CreateCartAsync(CartDto model)
        public ValueTask<int> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> CreateUserAsync(UsersDto model)
        public ValueTask<IList<Domain.Models.Users.User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteCardAsync(int Id)

        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteCartAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteUserAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Card>> GetAllCardAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Cart>> GetAllCartAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Category>> GetAllCategory()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Domain.Models.Companies.Company>> GetAllCompany()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Domain.Models.Orders.Order>> GetAllOrderByUserId()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Product>> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Domain.Models.Users.User>> GetAllUserAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Card> GetCardByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Cart> GetCartByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Domain.Models.Users.User> GetUserByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateCardAsync(int Id, CardDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateCartAsync(int Id, CartDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateUserAsync(int Id, UsersDto model)
        public ValueTask<int> UpdateAsync(int Id, UsersDto model)
        {
            throw new NotImplementedException();
        }
    }
}
