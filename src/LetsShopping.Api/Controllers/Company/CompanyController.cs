using LetsShopping.Domain.Dtos.Category;
using LetsShopping.Domain.Dtos.CompnayDtos;
using LetsShopping.Domain.Dtos.DiscountDtos;
using LetsShopping.Domain.Dtos.ProductsDtos;
using LetsShopping.Domain.Exceptions.Companies;
using LetsShopping.Domain.Exceptions.Products;
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
            return BadRequest(new CompanyNotFoundException());
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
            if(result != 0)
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
 /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [HttpGet]
        public async ValueTask<IActionResult> GetAllProductsAsync()
        {
            IEnumerable<Product> result = await _companyServices.GetAllProductAsync();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest(new ProductNotFoundException());
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
            if(result != 0)
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
        //////////////////////////////////////////////////////////////////////////////////////////
        [HttpGet]
        public IActionResult GetAllCategory()
        {
            var result = _companyServices.GetAllCategoryAsync();
            return Ok(result);

        }
        [HttpGet]
        public IActionResult GetByIdCategory(int id)
        {
            var result = _companyServices.GetCategoryByIdAsync(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateCategory(CategoryDto category)
        {
            var result = _companyServices.CreateCategoryAsync(category);
            return Ok(result);
        }
        [HttpPatch]
        public IActionResult UpdateCategory(int Id, CategoryDto category)
        {
            var result = _companyServices.UpdateCategoryAsync(Id, category);
            return Ok(result);
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int Id)
        {
            var result = _companyServices.DeleteCategoryAsync(Id);
            return Ok(result);
        }
        [HttpGet]
        ////////////////////////////////////////////////////////////////
        public IActionResult GetAllDiscount()
        {
            var result = _companyServices.GetAllDiscountAsync();
            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetByIdDiscount(int id)
        {
            var result = _companyServices.GetDiscpuntByIdAsync(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateDiscount(DiscountDto discount)
        {
            var result = _companyServices.CreateDiscpuntAsync(discount);
            return Ok(result);
        }
        [HttpPatch]
        public IActionResult UpdateDiscount(int Id, DiscountDto discount)
        {
            var result = _companyServices.UpdateDiscpuntAsync(Id, discount);
            return Ok(result);
        }
        [HttpDelete]
        public IActionResult DeleteDiscount(int Id)
        {
            var result = _companyServices.DeleteDiscpuntAsync(Id);
            return Ok(result);
        }
        ////////////////////////////////////////////////////////////////////


    }
}
