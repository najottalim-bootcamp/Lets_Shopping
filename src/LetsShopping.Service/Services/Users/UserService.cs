using LetsShopping.DataAccess.Repositories.CardsRepositories;
using LetsShopping.DataAccess.Repositories.CartsRepositories;
using LetsShopping.DataAccess.Repositories.CategoryRepository;
using LetsShopping.DataAccess.Repositories.ProductRepositories;
using LetsShopping.DataAccess.Repositories.UserRepository;

namespace LetsShopping.Service.Services.Users
{
    public class UserService : IUserService
    {

        private readonly UserRepository _userRepository;
        private readonly CardRepository _cardRepository;
        private readonly CartRepository _cartRepository;
        


        #region Card Services

        public ValueTask<int> CreateCardAsync(CardDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteCardAsync(int Id)
        {
            throw new NotImplementedException();
        }
        public ValueTask<IList<Card>> GetAllCardAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateCardAsync(int Id, CardDto model)
        {
            throw new NotImplementedException();
        }
        public ValueTask<Card> GetCardByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        #endregion  Card Services



        #region Cart Services
        public ValueTask<int> DeleteCartAsync(int Id)
        {
            throw new NotImplementedException();
        }
        public ValueTask<int> CreateCartAsync(CartDto model)
        {
            throw new NotImplementedException();
        }
        public ValueTask<IList<Cart>> GetAllCartAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateCartAsync(int Id, CartDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Cart> GetCartByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }


        #endregion Cart Services



        #region User Services
        public ValueTask<int> CreateUserAsync(UsersDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteUserAsync(int Id)
        {
            throw new NotImplementedException();
        }
        public ValueTask<IList<User>> GetAllUserAsync()
        {
            throw new NotImplementedException();
        }



        public ValueTask<User> GetUserByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }


        public ValueTask<int> UpdateUserAsync(int Id, UsersDto model)
        {
            throw new NotImplementedException();
        }
        #endregion User Services




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

    }
}
