using LetsShopping.Domain.Dtos.AddressDtos;
using LetsShopping.Domain.Models.Addresses;
using LetsShopping.Service.Interfaces.Address;

namespace LetsShopping.Service.Services.Adress
{
    public class AddressServices : IAddressServices
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
