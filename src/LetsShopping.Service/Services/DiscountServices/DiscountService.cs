using LetsShopping.DataAccess.Repositories.Discount;
using LetsShopping.Domain.Dtos.DiscountDtos;
using LetsShopping.Domain.Exceptions.Users;
using LetsShopping.Service.Interfaces.IDiscount;

namespace LetsShopping.Service.Services.DiscountServices
{
    public class DiscountService : IDiscountInterface
    {
        private readonly IDiscountRepository _discountRepository;

        public DiscountService(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }

        public async ValueTask<int> CreateAsync(DiscountDto model)
        {
            int res = await _discountRepository.CreateAsync(model);
            if (res == 0)
            {
                throw new DiscountsNotFoundException(); 
            }
            return res;
        }

        public async ValueTask<int> DeleteAsync(int Id)
        {
            int res = await _discountRepository.DeleteAsync(Id);
            if (res == 0)
            {
                throw new DiscountsNotFoundException(); 
            }
            return res;
        }

        public async ValueTask<IList<Discount>> GetAllAsync()
        {
            IList<Discount> discounts = await _discountRepository.GetAllAsync();
            if (discounts == null)
            {
                throw new UserNotFoundException();
            }
            return discounts;
        }

        public async ValueTask<Discount> GetByIdAsync(int Id)
        {
            Discount discount = await _discountRepository.GetByIdAsync(Id);
            if (discount == null)
            {
                throw new DiscountsNotFoundException(); 
            }
            return discount;
        }

        public async ValueTask<int> UpdateAsync(int Id, DiscountDto model)
        {
            int update = await _discountRepository.UpdateAsync(Id, model);
            if (update == 0)
            {
                throw new DiscountsNotFoundException(); 
            }
            return update;
        }
    }

}
