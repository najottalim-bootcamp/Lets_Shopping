using LetsShopping.Domain.Dtos.AddressDtos;
using LetsShopping.Domain.Models.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.DataAccess.Repositories.AddressRepositories
{
    public interface IAddressRepository:IBaseRepository<Address, AddressDto> 
    {
    }
}
