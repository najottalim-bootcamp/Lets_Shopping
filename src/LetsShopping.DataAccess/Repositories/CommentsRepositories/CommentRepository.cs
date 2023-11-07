namespace LetsShopping.DataAccess.Repositories.CommentsRepositories;

public class CommentRepository : BaseRepository, ICommentRepository
{
    public async ValueTask<int> CreateAsync(CommentDto model)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"Insert into Comment(UserId,ProductId,CommentText,Status,CreatedAt) Values('{model.UserId}',{model.ProductId},'{model.TEXT}',{(int)Status.Created},Getdate());";
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
            string query = $"Exec Delete 'Comment',{Id}";
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

    public async ValueTask<IList<Comment>> GetAllAsync()
    {
        try
        {
            await _connection.OpenAsync();
            string query = "Exec GetAll 'Comment'";
            IList<Comment> get = (await _connection.QueryAsync<Comment>(query)).ToList();
            return get;
        }
        catch
        {
            return new List<Comment>();
        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async ValueTask<Comment> GetByIdAsync(int Id)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"EXEC GetAllById 'Comment' , {Id};";
            Comment comment = await _connection.QueryFirstOrDefaultAsync<Comment>(query);
            return comment;
        }
        catch
        {
            return new Comment();

        }
        finally
        {
            await _connection.CloseAsync();
        }
    }

    public async ValueTask<int> UpdateAsync(int Id, CommentDto model)
    {
        try
        {
            await _connection.OpenAsync();
            string query = $"Update Comment Set UserId = {model.UserId},ProductId = {model.ProductId},CommentText = '{model.TEXT}',Status = {(int)Status.Updated},UpdatedAt = GetDate() Where Id = {Id};";
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
