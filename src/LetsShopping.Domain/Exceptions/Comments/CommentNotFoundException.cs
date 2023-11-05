namespace LetsShopping.Domain.Exceptions.Comments
{
    public class CommentNotFoundException : NotFoundException
    {
        public CommentNotFoundException() 
        {
            this.TitleMessage = "Comment not Found!";
        }
    }
}
