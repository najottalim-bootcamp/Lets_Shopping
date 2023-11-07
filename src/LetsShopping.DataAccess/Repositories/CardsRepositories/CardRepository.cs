namespace LetsShopping.DataAccess.Repositories.CardsRepositories
{
    public class CardRepository : BaseRepository, ICardRepisotry
    {
        public async ValueTask<int> CreateAsync(CardDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Insert into Card(CardNumber,ExpireDate,Amount,Status,CreatedAt) Values(\'{model.CardNumber}\', GETDATE() , {model.Amount} ,{(int)Status.Created},Getdate());";
                int created = await _connection.ExecuteAsync(query, model);
                return 1;
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
                string query = $"EXEC DeleteById \'Card\' , {Id}";
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

        public async ValueTask<List<Card>> GetAllAsync()
        {
            try
            {
                await _connection.OpenAsync();
                string query = "Exec GetAll 'Card'";
                var get = (await _connection.QueryAsync<Card>(query)).ToList();
                return get;
            }
            catch
            {
                return new List<Card>();
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public async ValueTask<Card> GetByIdAsync(int Id)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"EXEC GetAllById 'Card' , {Id};";
                var price = await _connection.QueryFirstOrDefaultAsync<Card>(query);
                return price;
            }
            catch
            {
                return new Card();

            }
            finally
            {
                await _connection.CloseAsync();
            }

        }

        public async ValueTask<int> UpdateAsync(int Id, CardDto model)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"Update Card Set CardNumber = ' {model.CardNumber}', Amount = {model.Amount} ,Status = {(int)Status.Updated},ModifiedAt = GetDate() Where Id = {Id};";
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
