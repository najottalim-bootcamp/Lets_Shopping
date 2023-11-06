namespace LetsShopping.Service.Interfaces
{
    public interface IBaseInterface<TModel, TDto>
    {
        public ValueTask<bool> Create(TDto dto);
        public ValueTask<bool> Update(int id, TDto dto);
        public ValueTask<bool> Delete(int id);
        public ValueTask<List<TModel>> GetAll(string Tablename);
        public ValueTask<TModel> GetById(int id, string Tablename);
        ValueTask<Domain.Models.Addresses.Address> GetAddressByIdAsync(int Id);
    }
}
