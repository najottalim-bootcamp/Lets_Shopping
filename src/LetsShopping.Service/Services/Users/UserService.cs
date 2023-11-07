using LetsShopping.DataAccess.Repositories.CategoryRepository;
using LetsShopping.DataAccess.Repositories.CompanyRepository;
using LetsShopping.DataAccess.Repositories.OrderRepositories;
using LetsShopping.DataAccess.Repositories.ProductRepositories;
using LetsShopping.Domain.Enums;

namespace LetsShopping.Service.Services.Users
{
    public class UserService 
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
        public ValueTask<List<Card>> GetAllCardAsync()
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
        public ValueTask<List<Cart>> GetAllCartAsync()
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
        public ValueTask<List<User>> GetAllUserAsync()
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




        public async ValueTask<List<Category>> GetAllCategory()
        {
            CategoryRepository cat = new CategoryRepository();

            List<Category> categories = await cat.GetAllAsync();
            
            return  categories.Where(c => c.Status == Status.Deleted).ToList();

        }

        public async ValueTask<List<Domain.Models.Companies.Company>> GetAllCompany()
        {
            CompanyRepository cat = new CompanyRepository();

            List<Domain.Models.Companies.Company> companies = await cat.GetAllAsync();

            return companies.Where(c => c.Status != Status.Deleted).ToList();

        }

        public async ValueTask<List<Domain.Models.Orders.Order>> GetAllOrderByUserId(int userId)
        {
            OrderRepository cat = new OrderRepository();

            List<Domain.Models.Orders.Order> orders = await cat.GetAllAsync();
            orders = orders.Where(x => x.UserId == userId).Where(x=>x.Status != Status.Deleted).ToList();

            return orders;
        }

        public async ValueTask<List<Product>> GetAllProduct()
        {
            ProductRepository cat = new ProductRepository();

            List<Product> products = await cat.GetAllAsync();
            products = products.Where(x=>x.Status!= Status.Deleted && x.Count>0).ToList();

            return products;
        }

    }
}
