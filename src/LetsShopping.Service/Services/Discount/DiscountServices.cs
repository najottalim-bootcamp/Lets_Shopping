namespace LetsShopping.Service.Services.Discount
{
    public class DiscountServices : IDiscountService
    {
        public ValueTask<bool> CreateDiscount(DiscountDto discount)
        {
            throw new NotImplementedException();
        }

        public ValueTask DeleteDiscount(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<List<Domain.Models.Users.Discount>> GetDiscountAll()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Domain.Models.Users.Discount> GetDiscountById(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> UpdateDiscount(int Id, DiscountDto discount)
        {
            throw new NotImplementedException();
        }
    }
}
