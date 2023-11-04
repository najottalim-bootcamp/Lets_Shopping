namespace LetsShopping.DataAccess.Repositories
{
    public interface IBaseRepository<TModel, TView> where TModel : class
    {
        public ValueTask<int> CreateAsync(TView model);
        public ValueTask<int> UpdateAsync(int Id, TView model);
        public ValueTask<int> DeleteAsync(int Id);
        public ValueTask<TModel> GetByIdAsync(int Id);
        public ValueTask<IList<TModel>> GetAllAsync();
    }
}
