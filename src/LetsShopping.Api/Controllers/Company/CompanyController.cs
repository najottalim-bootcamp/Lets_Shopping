
using LetsShopping.Domain.Dtos.AddressDtos;
using LetsShopping.Domain.Dtos.Category;
using LetsShopping.Domain.Dtos.CompnayDtos;
using LetsShopping.Domain.Dtos.DiscountDtos;
using LetsShopping.Domain.Dtos.ProductsDtos;
using LetsShopping.Domain.Exceptions.Addresses;
using LetsShopping.Domain.Exceptions.Cards;
using LetsShopping.Domain.Exceptions.Categories;
using LetsShopping.Domain.Exceptions.Companies;
using LetsShopping.Domain.Exceptions.Discounts;
using LetsShopping.Domain.Exceptions.Products;
using LetsShopping.Domain.Models.Category;
using LetsShopping.Domain.Models.Companies;
using LetsShopping.Domain.Models.Products;
using LetsShopping.Service.Interfaces.Company;

namespace LetsShopping.Api.Controllers.Company

{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyServices _companyServices;

        public CompanyController(ICompanyServices company)
        {
            _companyServices = company;
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllCompaniesAsync()
        {
            IEnumerable<LetsShopping.Domain.Models.Companies.Company> result = await _companyServices.GetAllCompanyAsync();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("error!");
        }
        [HttpGet("{Id}")]
        public async ValueTask<IActionResult> GetCompanyByIdAsync(int id)
        {
            var result = await _companyServices.GetCompanyByIdAsync(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(new CompanyNotFoundException());
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateCompanyAsync(CompanyDto company)
        {
            int result = await _companyServices.CreateCompanyAsync(company);
            if (result != 0)
            {
                return Ok("Added");
            }
            return BadRequest("error");
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteCompanyByIdAsync(int id)
        {
            int result = await _companyServices.DeleteCompanyAsync(id);
            if (result != 0)
            {
                return Ok("deleted");
            }
            return BadRequest(new CompanyNotFoundException());
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateCompanyAsync(int Id, CompanyDto company)
        {
            int result = await _companyServices.UpdateCompanyAsync(Id, company);
            if (result != 0)
            {
                return Ok("updated");
            }
            return BadRequest(new CompanyNotFoundException());
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllProductsAsync()
        {
            IEnumerable<Product> result = await _companyServices.GetAllProductAsync();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("error!");
        }
        [HttpGet("{Id}")]
        public async ValueTask<IActionResult> GetProductByIdAsync(int id)
        {
            var result = await _companyServices.GetProductByIdAsync(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(new ProductNotFoundException());
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateProductAsync(ProductDto product)
        {
            int result = await _companyServices.CreateProductAsync(product);
            if (result != 0)
            {
                return Ok("Added");
            }
            return BadRequest("error");
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteProductByIdAsync(int id)
        {
            int result = await _companyServices.DeleteProductAsync(id);
            if (result != 0)
            {
                return Ok("deleted");
            }
            return BadRequest(new ProductNotFoundException());
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateProductAsync(int Id, ProductDto product)
        {
            int result = await _companyServices.UpdateProductAsync(Id, product);
            if (result != 0)
            {
                return Ok("updated");
            }
            return BadRequest(new CompanyNotFoundException());

        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAddressAsync()
        {
            IEnumerable<LetsShopping.Domain.Models.Addresses.Address> result = await _companyServices.GetAllAddressAsync();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("error!");
        }
        [HttpGet("{Id}")]
        public async ValueTask<IActionResult> GetAddressByIdAsync(int id)
        {
            var result = await _companyServices.GetAddressByIdAsync(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(new AddressNotFoundExeption());
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateAddressAsync(AddressDto company)
        {
            int result = await _companyServices.CreateAddressAsync(company);
            if (result != 0)
            {
                return Ok("Added");
            }
            return BadRequest("error");
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteAddressByIdAsync(int id)
        {
            int result = await _companyServices.DeleteAddressAsync(id);
            if (result != 0)
            {
                return Ok("deleted");
            }
            return BadRequest(new AddressNotFoundExeption());
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllCardsAsync()
        {
            IEnumerable<LetsShopping.Domain.Models.Cards.Card> result = await _companyServices.GetAllCardAsync();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("Error");
        }
        [HttpGet("{Id}")]
        public async ValueTask<IActionResult> GetCardsByIdAsync(int id)
        {
            var result = await _companyServices.GetAddressByIdAsync(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(new CardsNotFoundExceptions());
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateCardsAsync(AddressDto company)
        {
            int result = await _companyServices.CreateAddressAsync(company);
            if (result != 0)
            {
                return Ok("Added");
            }
            return BadRequest("error!!");
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteCardsByIdAsync(int id)
        {
            int result = await _companyServices.DeleteAddressAsync(id);
            if (result != 0)
            {
                return Ok("deleted");
            }
            return BadRequest(new CardsNotFoundExceptions());
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllCategory()
        {
            var result = await _companyServices.GetAllCategoryAsync();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("Error!!");
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdCategory(int id)
        {
            var result = await _companyServices.GetCategoryByIdAsync(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(new CategoryNotFoundException());
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateCategory(CategoryDto category)
        {
            var result = await _companyServices.CreateCategoryAsync(category);
            if (result != 0)
            {
                return Ok("created");
            }
            return BadRequest(new CategoryNotFoundException());
        }
        [HttpPatch]
        public async ValueTask<IActionResult> UpdateCategory(int Id, CategoryDto category)
        {
            int result = await _companyServices.UpdateCategoryAsync(Id, category);
            if (result != 0)
            {
                return Ok("updated");
            }
            return BadRequest(new CategoryNotFoundException());
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteCategory(int Id)
        {
            int result = await _companyServices.DeleteCategoryAsync(Id);
            if (result != 0)
            {
                return Ok("deleted");
            }
            return BadRequest(new CategoryNotFoundException());
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllDiscount()
        {
            var result = await _companyServices.GetAllDiscountAsync();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("Erorr");
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetByIdDiscount(int id)
        {
            var result = await _companyServices.GetDiscpuntByIdAsync(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(new DiscountNotFoundException());
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateDiscount(DiscountDto discount)
        {
            int result = await _companyServices.CreateDiscpuntAsync(discount);
            if (result != 0)
            {
                return Ok("created");
            }
            return BadRequest("Erorr");
        }
        [HttpPatch]
        public async ValueTask<IActionResult> UpdateDiscount(int Id, DiscountDto discount)
        {
            var result = await _companyServices.UpdateDiscpuntAsync(Id, discount);
            if (result != 0)
            {
                return Ok("updated");
            }
            return BadRequest(new DiscountNotFoundException());
        }
        [HttpDelete]
        public async ValueTask<IActionResult> DeleteDiscount(int Id)
        {
            var result = await _companyServices.DeleteDiscpuntAsync(Id);

            if (result != 0)
            {
                return Ok("deleted");
            }
            return BadRequest(new DiscountNotFoundException());
        }
    }

}
