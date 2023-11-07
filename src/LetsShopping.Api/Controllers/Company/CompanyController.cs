using LetsShopping.Domain.Exceptions.Companies;
using LetsShopping.Service.Interfaces.Company;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
                return Ok("Created");
            }
            return BadRequest(new CompanyNotFoundException());
        }
    }
}
