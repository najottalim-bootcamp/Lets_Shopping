using LetsShopping.Domain.Dtos.CompnayDtos;
using LetsShopping.Domain.Models.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.DataAccess.Repositories.CompanyRepository
{
    public interface ICompanyRepository:IBaseRepository<Company,CompanyDto>
    {
    }
}
