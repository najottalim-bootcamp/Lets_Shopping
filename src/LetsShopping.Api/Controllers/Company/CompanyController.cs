﻿using LetsShopping.Domain.Dtos.CompnayDtos;
using LetsShopping.Domain.Exceptions.Companies;
using LetsShopping.Domain.Models.Companies;
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
    }
}
