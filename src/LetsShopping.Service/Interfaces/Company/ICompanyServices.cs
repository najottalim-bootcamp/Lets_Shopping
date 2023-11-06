using LetsShopping.Domain.Dtos.CardDtos;

using LetsShopping.Domain.Dtos.Category;
using LetsShopping.Domain.Dtos.DiscountDtos;
using LetsShopping.Domain.Dtos.ProductsDtos;
using LetsShopping.Domain.Models.Cards;

using LetsShopping.Domain.Models.Category;


namespace LetsShopping.Service.Interfaces.Company
{
    public interface ICompanyServices : IBaseInterface<Domain.Models.Companies.Company, CompanyDto>
    {
        public ValueTask<int> CreateCompanyAsync(CompanyDto model);
        public ValueTask<int> UpdateCompanyAsync(int Id, CompanyDto model);
        public ValueTask<int> DeleteCompanyAsync(int Id);
        public ValueTask<Domain.Models.Companies.Company> GetCompnayByIdAsync(int Id);
        public ValueTask<IList<Domain.Models.Companies.Company>> GetAllCompanyAsync();


        public ValueTask<int> CreateProductAsync(ProductDto model);
        public ValueTask<int> UpdateProductAsync(int Id, ProductDto model);
        public ValueTask<int> DeleteProductAsync(int Id);
        public ValueTask<Product> GetProductByIdAsync(int Id);
        public ValueTask<IList<Product>> GetAllProductAsync();


        public ValueTask<int> CreateAddressAsync(AddressDto model);
        public ValueTask<int> UpdateAddressAsync(int Id, AddressDto model);
        public ValueTask<int> DeleteAddressAsync(int Id);
        public ValueTask<Domain.Models.Orders.Order> GetAddressByIdAsync(int Id);
        public ValueTask<IList<Domain.Models.Orders.Order>> GetAllAddressAsync();
        public ValueTask<LetsShopping.Domain.Models.Addresses.Address> GetAddressByIdAsync(int Id);
        public ValueTask<IList<LetsShopping.Domain.Models.Addresses.Address>> GetAllAddressAsync();



        public ValueTask<int> CreateCardAsync(CardDto model);
        public ValueTask<int> UpdateCardAsync(int Id, CardDto model);
        public ValueTask<int> DeleteCardAsync(int Id);
        public ValueTask<Card> GetCardByIdAsync(int Id);
        public ValueTask<IList<Card>> GetAllCardAsync();


        public ValueTask<int> CreateCategoryAsync(CategoryDto model);
        public ValueTask<int> UpdateCategoryAsync(int Id, CategoryDto model);
        public ValueTask<int> DeleteCategoryAsync(int Id);
        public ValueTask<Category> GetCategoryByIdAsync(int Id);
        public ValueTask<IList<Category>> GetAllCategoryAsync();


        public ValueTask<int> CreateDiscpuntAsync(DiscountDto model);
        public ValueTask<int> UpdateDiscpuntAsync(int Id, DiscountDto model);
        public ValueTask<int> DeleteDiscpuntAsync(int Id);
        public ValueTask<Discount> GetDiscpuntByIdAsync(int Id);
        public ValueTask<IList<Discount>> GetAllDiscountAsync();


    }
}
