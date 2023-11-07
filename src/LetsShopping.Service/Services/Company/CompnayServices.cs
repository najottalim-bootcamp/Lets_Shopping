using LetsShopping.Domain.Dtos.DiscountDtos;
using LetsShopping.Domain.Dtos.ProductsDtos;
using LetsShopping.Service.Interfaces;
using LetsShopping.Service.Interfaces.Company;

namespace LetsShopping.Service.Services.Company
{
    public class CompnayServices : ICompanyServices
    {
        #region Address Services 
        public ValueTask<IList<Address>> GetAllAddressAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> CreateAddressAsync(AddressDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Address> GetAddressByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
        public ValueTask<int> DeleteAddressAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateAddressAsync(int Id, AddressDto model)
        {
            throw new NotImplementedException();
        }

        #endregion Address Services 


        #region Company Services 

        public ValueTask<int> CreateCompanyAsync(CompanyDto model)
        {
            throw new NotImplementedException();
        }
        public ValueTask<int> DeleteCompanyAsync(int Id)
        {
            throw new NotImplementedException();
        }
        public ValueTask<IList<Domain.Models.Companies.Company>> GetAllCompanyAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Domain.Models.Companies.Company> GetCompanyByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
        public ValueTask<int> UpdateCompanyAsync(int Id, CompanyDto model)
        {
            throw new NotImplementedException();
        }


        #endregion Company Services 


        #region Card Services 

        public ValueTask<int> CreateCardAsync(CardDto model)
        {
            throw new NotImplementedException();
        }
        public ValueTask<int> DeleteCardAsync(int Id)
        {
            throw new NotImplementedException();
        }
        public ValueTask<int> UpdateCardAsync(int Id, CardDto model)
        {
            throw new NotImplementedException();
        }
        
        public ValueTask<IList<Card>> GetAllCardAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Card> GetCardByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
        #endregion Card Services 



        #region Category Services 

        public ValueTask<int> CreateCategoryAsync(CategoryDto model)
        {
            throw new NotImplementedException();
        }
        public ValueTask<int> DeleteCategoryAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Category>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }
        public ValueTask<Category> GetCategoryByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
        public ValueTask<int> UpdateCategoryAsync(int Id, CategoryDto model)
        {
            throw new NotImplementedException();
        }

        #endregion Category Services



        #region Discount Services
        public ValueTask<int> CreateDiscpuntAsync(DiscountDto model)
        {
            throw new NotImplementedException();
        }
        public ValueTask<int> DeleteDiscpuntAsync(int Id)
        {
            throw new NotImplementedException();
        }
        public ValueTask<IList<Discount>> GetAllDiscountAsync()
        {
            throw new NotImplementedException();
        }
        public ValueTask<Discount> GetDiscpuntByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
        public ValueTask<int> UpdateDiscpuntAsync(int Id, DiscountDto model)
        {
            throw new NotImplementedException();
        }

        #endregion Discount Services


        #region Product Services

        public ValueTask<int> CreateProductAsync(ProductDto model)
        {
            throw new NotImplementedException();
        }
        public ValueTask<int> DeleteProductAsync(int Id)
        {
            throw new NotImplementedException();
        }
        public ValueTask<IList<Product>> GetAllProductAsync()
        {
            throw new NotImplementedException();
        }
        public ValueTask<Product> GetProductByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
        public ValueTask<int> UpdateProductAsync(int Id, ProductDto model)
        {
            throw new NotImplementedException();
        }
        #endregion Product Services

    }
}
