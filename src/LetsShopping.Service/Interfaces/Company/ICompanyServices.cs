using LetsShopping.Domain.Dtos.CompnayDtos;
using LetsShopping.Domain.Models.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Service.Interfaces.Company
{
    public interface ICompanyServices:IBaseInter<Domain.Models.Companies.Company, CompanyDto>
    {
    }
}
