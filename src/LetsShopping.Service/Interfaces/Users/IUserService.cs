namespace LetsShopping.Service.Interfaces.Users
{
    public interface IUserService
    {
        public ValueTask<int> CreateUserAsync(UsersDto model);
        public ValueTask<int> UpdateUserAsync(int Id, UsersDto model);
        public ValueTask<int> DeleteUserAsync(int Id);
        public ValueTask<User> GetUserByIdAsync(int Id);
        public ValueTask<List<User>> GetAllUserAsync();


        public ValueTask<int> CreateCartAsync(CartDto model);
        public ValueTask<int> UpdateCartAsync(int Id, CartDto model);
        public ValueTask<int> DeleteCartAsync(int Id);
        public ValueTask<Cart> GetCartByIdAsync(int Id);
        public ValueTask<List<Cart>> GetAllCartByUserIdAsync(int userId);


        public ValueTask<int> CreateCardAsync(CardDto model);
        public ValueTask<int> UpdateCardAsync(int Id, CardDto model);
        public ValueTask<int> DeleteCardAsync(int Id);
        public ValueTask<Card> GetCardByIdAsync(int Id);
        public ValueTask<List<Card>> GetAllCardAsync();


        public ValueTask<List<Product>> GetAllProduct();
        public ValueTask<List<Category>> GetAllCategory();
        public ValueTask<List<Domain.Models.Companies.Company>> GetAllCompany();
        public ValueTask<List<Domain.Models.Orders.Order>> GetAllOrderByUserId(int userId);


    }
}