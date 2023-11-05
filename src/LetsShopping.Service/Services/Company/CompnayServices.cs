using LetsShopping.Domain.Dtos.AddressDtos;
using LetsShopping.Domain.Models.Addresses;
using LetsShopping.Service.Interfaces.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Service.Services.Company
{
    public class CompnayServices : IAddressServices
    {
        public ValueTask<bool> Create(AddressDto dto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<List<Address>> GetAll(string Tablename)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Address> GetById(int id, string Tablename)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> Update(int id, AddressDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
