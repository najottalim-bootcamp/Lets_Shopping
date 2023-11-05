

using LetsShopping.Domain.Dtos.CardDtos;
using LetsShopping.Domain.Dtos.Category;
using LetsShopping.Domain.Models.Addresses;
using LetsShopping.Domain.Models.Cards;
using LetsShopping.Domain.Models.Category;
using LetsShopping.Domain.Models.Companies;
using LetsShopping.Domain.Models.Products;

namespace LetsShopping.Service.Interfaces.Company
{
    public interface ICompanyServices :IBaseServicesInterfaces<Domain.Models.Companies.Company, CompanyDto> ,
        IBaseServicesInterfaces<Product,ProductDto>,
        IBaseServicesInterfaces<Address,AddressDto>,
        IBaseServicesInterfaces<Card,CardDto>,
        IBaseServicesInterfaces<Category,CategoryDto>,
        IBaseServicesInterfaces<Discount,DiscountDto>
    {

    }
}
