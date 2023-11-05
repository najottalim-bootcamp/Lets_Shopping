namespace LetsShopping.Domain.Dtos.CommentsDtos;

public class CommentDto
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
    public string TEXT { get; set; }
}
