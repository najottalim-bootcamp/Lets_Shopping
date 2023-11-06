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

        public ValueTask<Address> GetAddressByIdAsync(int Id)
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
