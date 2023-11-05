using LetsShopping.Domain.Dtos.AddressDtos;
using LetsShopping.Domain.Models.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Service.Interfaces.Address
{
    internal interface IAddressServices:IBaseInter<Domain.Models.Addresses.Address, AddressDto>  
    {
    }
}
