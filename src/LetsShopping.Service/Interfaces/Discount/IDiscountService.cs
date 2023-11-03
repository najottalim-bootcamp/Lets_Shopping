using LetsShopping.Service.Dtos.DiscountDtos;
using System.Security.AccessControl;

namespace LetsShopping.Service.Interfaces.Discount
{
    public interface IDiscountService
    {
        public Task CreateDiscount(DiscountDto discount);


    }
}
