namespace LetsShopping.Domain.Models.Comments;

public class Comment : BaseClass
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public string TEXT { get; set; }
    public DateTime DeletedAt { get; set; }
}
