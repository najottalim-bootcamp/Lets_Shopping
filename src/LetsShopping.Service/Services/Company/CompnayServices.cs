using LetsShopping.DataAccess.Repositories.CategoryRepository;
using LetsShopping.DataAccess.Repositories.Discount;
using LetsShopping.Domain.Dtos.DiscountDtos;
using LetsShopping.Domain.Dtos.ProductsDtos;
using LetsShopping.Domain.Enums;
using LetsShopping.Domain.Exceptions.Carts;
using LetsShopping.Service.Interfaces;
using LetsShopping.Service.Interfaces.Company;

namespace LetsShopping.Service.Services.Company
{
    public class CompnayServices : ICompanyServices
    {

        private readonly ICatogoryRepository _catogoryRepository;
        private readonly IDiscountRepository _discountRepository;
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

        public async ValueTask<int> CreateCategoryAsync(CategoryDto model)
        {
            int res = await _catogoryRepository.CreateAsync(model);
            return res;

        }
        public async ValueTask<int> DeleteCategoryAsync(int Id)
        {
            int res = await _catogoryRepository.DeleteAsync(Id);
            return res;
        }

        public async ValueTask<IList<Category>> GetAllCategoryAsync()
        {
            List<Category> res = await _catogoryRepository.GetAllAsync();
            return res.Where(c => c.Status != Status.Deleted).ToList();
        }
         
        
        public async ValueTask<Category> GetCategoryByIdAsync(int Id)
        {
            Category category = await _catogoryRepository.GetByIdAsync(Id);

            return category;
        }
        public async ValueTask<int> UpdateCategoryAsync(int Id, CategoryDto model)
        {
            int update = await _catogoryRepository.UpdateAsync(Id, model);
            return update;
        }

        #endregion Category Services



        #region Discount Services
        public async ValueTask<int> CreateDiscpuntAsync(DiscountDto model)
        {
            int res  = await _discountRepository.CreateAsync(model);
            return res;
        }
        public async ValueTask<int> DeleteDiscpuntAsync(int Id)
        {
            int res = await _discountRepository.DeleteAsync(Id);
            return res;
        }
        public async ValueTask<IList<Discount>> GetAllDiscountAsync()
        {
            List<Discount> discounts = await _discountRepository.GetAllAsync();
            return discounts.Where(c => c.Status != Status.Deleted).ToList();
        }
        public async ValueTask<Discount> GetDiscpuntByIdAsync(int Id)
        {
           Discount discount = await _discountRepository.GetByIdAsync(Id);

            return discount;
        }
        public async ValueTask<int> UpdateDiscpuntAsync(int Id, DiscountDto model)
        {
            int update = await _discountRepository.UpdateAsync(Id,model);
            return update;
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
