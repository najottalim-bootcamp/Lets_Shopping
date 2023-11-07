
using LetsShopping.DataAccess.Repositories.CategoryRepository;
using LetsShopping.DataAccess.Repositories.CompanyRepository;
using LetsShopping.DataAccess.Repositories.ProductRepositories;
using LetsShopping.Domain.Enums;


namespace LetsShopping.Service.Services.Users
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;
        private readonly ICardRepisotry _cardRepository;
        private readonly ICartRepository _cartRepository;


        public UserService(IUserRepository userRepository,
            ICardRepisotry cardRepisotry,
            ICartRepository cartRepository)
        {
            _userRepository = userRepository;
            _cardRepository = cardRepisotry;
            _cartRepository = cartRepository;
        }

        #region Card Services

        public async ValueTask<int> CreateCardAsync(CardDto model)
        {
            var res = await _cardRepository.CreateAsync(model);
            return res;
        }



        public async ValueTask<int> DeleteCardAsync(int Id)
        {
            var res = await _cardRepository.DeleteAsync(Id);
            return res;
        }
        public async ValueTask<List<Card>> GetAllCardAsync()
        {
            var cards = await _cardRepository.GetAllAsync();
            return cards.Where(c => c.Status != Status.Deleted).ToList();
        }

        public ValueTask<int> UpdateCardAsync(int Id, CardDto model)
        {

            var res = _cardRepository.UpdateAsync(Id, model);
            return res;
        }
        public ValueTask<Card> GetCardByIdAsync(int Id)
        {
            var res = _cardRepository.GetByIdAsync(Id);
            return res;
            throw new NotImplementedException();
        }


        #endregion  Card Services



        #region Cart Services
        public ValueTask<int> DeleteCartAsync(int Id)
        {
            var res = _cartRepository.DeleteAsync(Id);
            return res;
        }
        public ValueTask<int> CreateCartAsync(CartDto model)
        {
            var res = _cartRepository.CreateAsync(model);
            return res;
        }
        public async ValueTask<List<Cart>> GetAllCartByUserIdAsync(int userId)
        {
            var ress = await _cartRepository.GetAllAsync();
            ress = ress.Where(x => x.UserId == userId).Where(x => x.Status != Status.Deleted).ToList();
            return ress;
        }

        public ValueTask<int> UpdateCartAsync(int Id, CartDto model)
        {

            var res = _cartRepository.UpdateAsync(Id, model);
            return res;

            throw new NotImplementedException();

        }

        public ValueTask<Cart> GetCartByIdAsync(int Id)
        {

            var res = _cartRepository.GetByIdAsync(Id);
            return res;

            throw new NotImplementedException();

        }


        #endregion Cart Services



        #region User Services

        public async ValueTask<int> CreateUserAsync(UsersDto model)
        {
            var res = await _userRepository.CreateAsync(model);
            return res;
        }


        public async ValueTask<int> DeleteUserAsync(int Id)
        {
            var res = await _userRepository.DeleteAsync(Id);
            return res;
        }
        public async ValueTask<List<User>> GetAllUserAsync()
        {
            var res = await _userRepository.GetAllAsync();
            return res.Where(x => x.Status != Status.Deleted).ToList();
        }




        public async ValueTask<User> GetUserByIdAsync(int Id)
        {
            var res = await _userRepository.GetByIdAsync(Id);
            return res;
        }
        public ValueTask<int> UpdateUserAsync(int Id, UsersDto model)
        {
            var res = _userRepository.UpdateAsync(Id, model);
            return res;
        }
        #endregion User Services




        public async ValueTask<List<Category>> GetAllCategory()
        {
            ICatogoryRepository cat = new CategoryRepository();

            List<Category> categories = await cat.GetAllAsync();



            return categories.Where(c => c.Status != Status.Deleted).ToList();
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
            orders = orders.Where(x => x.UserId == userId).Where(x => x.Status != Status.Deleted).ToList();

            return orders;
        }

        public async ValueTask<List<Product>> GetAllProduct()
        {
            ProductRepository cat = new ProductRepository();

            List<Product> products = (List<Product>)await cat.GetAllAsync();
            products = products.Where(x => x.Status != Status.Deleted && x.Count > 0).ToList();

            return products;
        }

    }
}
