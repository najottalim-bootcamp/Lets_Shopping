namespace LetsShopping.Service.Interfaces
{
    public interface IBaseServicesInterfaces<TModel, TDto>
    {
        public ValueTask<int> CreateAsync(TDto model);
        public ValueTask<int> UpdateAsync(int Id, TDto model);
        public ValueTask<int> DeleteAsync(int Id);
        public ValueTask<TModel> GetByIdAsync(int Id);
        public ValueTask<IList<TModel>> GetAllAsync();
    }
}
