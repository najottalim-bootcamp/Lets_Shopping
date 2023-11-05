using LetsShopping.Domain.Dtos.CommentsDtos;
using LetsShopping.Domain.Models.Comments;

namespace LetsShopping.DataAccess.Repositories.CommentsRepositories;

public interface ICommentRepository : IBaseRepository<Comment,CommentDto>
{

}
