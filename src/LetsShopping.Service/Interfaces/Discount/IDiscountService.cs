namespace LetsShopping.Service.Interfaces
{
    public interface IDiscountService
    {
        public ValueTask<bool> CreateDiscount(DiscountDto discount);
        public ValueTask<bool> UpdateDiscount(int Id, DiscountDto discount);
        public ValueTask DeleteDiscount(int Id);
        public ValueTask<List<Discount>> GetDiscountAll();
        public ValueTask<Discount> GetDiscountById(int Id);

    }
}
