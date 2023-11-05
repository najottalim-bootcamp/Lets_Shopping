global using LetsShopping.Domain.Models.Price;
using LetsShopping.Service.Dtos.Price;

namespace LetsShopping.DataAccess.Repositories.PriceRepositories
{
    public interface IPriceRepository : IBaseRepository<Price,PriceDto>
    {
    }
}
