namespace LetsShopping.DataAccess.Repositories.CategoryRepository
{
    public class CategoryRepository : BaseRepository, ICatogoryRepository
    {
        public async ValueTask<int> CreateAsync(CategoryDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Insert into Category(Name, ParentId ,Status,CreatedAt) Values(\'{model.Name}\',{model.ParentId},{(int)Status.Created},Getdate());";
                int created = await _connection.ExecuteAsync(query, model);
                return created;
            }
            catch
            {
                return 0;
            }
            finally
            {
                await _connection.CloseAsync();
            }

        }


        public async ValueTask<int> DeleteAsync(int Id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"EXEC DeleteById \'Category\' , {Id}";
                int deleted = await _connection.ExecuteAsync(query);
                return deleted;

            }
            catch
            {
                return 0;
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async ValueTask<List<Category>> GetAllAsync()
        {
            try
            {
                await _connection.OpenAsync();
                string query = "Exec GetAll \'Category\'";
                var get = (await _connection.QueryAsync<Category>(query)).ToList();
                return get;
            }
            catch
            {
                return new List<Category>();
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async ValueTask<Category> GetByIdAsync(int Id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"EXEC GetAllById 'Category' , {Id};";
                var price = await _connection.QueryFirstOrDefaultAsync<Category>(query);
                return price;
            }
            catch
            {
                return new Category();

            }
            finally
            {
                await _connection.CloseAsync();
            }

        }

        public async ValueTask<int> UpdateAsync(int Id, CategoryDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Update Category Set Name = '{model.Name}',ParentId = {model.ParentId},Status = {(int)Status.Updated},UpdatedAt = GetDate() Where Id = {Id}";
                int updated = await _connection.ExecuteAsync(query);
                return updated;

            }
            catch
            {
                return 0;
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }
    }
}
