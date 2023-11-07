using LetsShopping.DataAccess.Repositories.AddressRepositories;
using LetsShopping.Domain.Exceptions.Discounts;
using LetsShopping.Domain.Exceptions.Users;
using System.Reflection;

namespace LetsShopping.Service.Services.Company
{
    public class CompanyServices : ICompanyServices
    {
        private readonly IAddressRepository _address;
        private readonly ICompanyRepository _company;
        private readonly IProductRepository _product;
        private readonly ICardRepisotry _card;
        private readonly ICatogoryRepository _catogoryRepository;
        private readonly IDiscountRepository _discountRepository;
        #region Address Services 
        public async ValueTask<IList<Address>> GetAllAddressAsync()
        {
            IList<Address> address = await _address.GetAllAsync();
            return address;
        }

        public async ValueTask<int> CreateAddressAsync(AddressDto model)
        {
            int res = await _address.CreateAsync(model);
            return res;
        }

        public async ValueTask<Address> GetAddressByIdAsync(int Id)
        {
            Address address = await _address.GetByIdAsync(Id);
            return address;
        }
        public async ValueTask<int> DeleteAddressAsync(int Id)
        {
            int res = await _address.DeleteAsync(Id);
            return res;
        }

        public async ValueTask<int> UpdateAddressAsync(int Id, AddressDto model)
        {
            int update = await _address.UpdateAsync(Id, model);
            return update;
        }

        #endregion Address Services 


        #region Company Services 
        public async ValueTask<int> CreateCompanyAsync(CompanyDto model)
        {
            int cm = await _company.CreateAsync(model);
            return cm;
        }
        public async ValueTask<int> DeleteCompanyAsync(int Id)
        {
            int cm = await _company.DeleteAsync(Id);
            return cm;
        }
        public async ValueTask<IList<Domain.Models.Companies.Company>> GetAllCompanyAsync()
        {
            List<Domain.Models.Companies.Company> companies = await _company.GetAllAsync();

            return companies.Where(c => c.Status != Status.Deleted).ToList();
        }

        public async ValueTask<Domain.Models.Companies.Company> GetCompanyByIdAsync(int Id)
        {
            Domain.Models.Companies.Company comp = await _company.GetByIdAsync(Id);
            return comp;

        }
        public async ValueTask<int> UpdateCompanyAsync(int Id, CompanyDto model)
        {
            int result = await _company.UpdateAsync(Id, model);
            return result;
        }


        #endregion Company Services 


        #region Card Services 

        public async ValueTask<int> CreateCardAsync(CardDto model)
        {
            int res = await _card.CreateAsync(model);
            return res;
        }
        public async ValueTask<int> DeleteCardAsync(int Id)
        {
            int res = await _card.DeleteAsync(Id);
            return res;
        }
        public async ValueTask<int> UpdateCardAsync(int Id, CardDto model)
        {
            int update = await _card.UpdateAsync(Id, model);
            return update;
        }
        public async ValueTask<IList<Card>> GetAllCardAsync()
        {
            IList<Card> card = await _card.GetAllAsync();
            return card;
        }
        public async ValueTask<Card> GetCardByIdAsync(int Id)
        {
            Card card = await _card.GetByIdAsync(Id);
            return card;
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
            int res = await _discountRepository.CreateAsync(model);
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
            int update = await _discountRepository.UpdateAsync(Id, model);
            return update;
        }

        #endregion Discount Services


        #region Product Services

        public async ValueTask<int> CreateProductAsync(ProductDto model)
        {
            int result = await _product.CreateAsync(model);
            return result;
        }
        public async ValueTask<int> DeleteProductAsync(int Id)
        {
            int result = await _product.DeleteAsync(Id);
            return result;
        }
        public async ValueTask<IList<Product>> GetAllProductAsync()
        {
            List<Product> products = (List<Product>)await _product.GetAllAsync();
            products = products.Where(x => x.Status != Status.Deleted && x.Count > 0).ToList();

            return products;
        }
        public async ValueTask<Product> GetProductByIdAsync(int Id)
        {
            Product pr = await _product.GetByIdAsync(Id);
            return pr;
        }
        public async ValueTask<int> UpdateProductAsync(int Id, ProductDto model)
        {
            int result = await _product.UpdateAsync(Id, model);
            return result;
        }
        #endregion Product Services

    }
}
