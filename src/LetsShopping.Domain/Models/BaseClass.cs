using System.ComponentModel.DataAnnotations;

namespace LetsShopping.Domain.Models
{
    public class BaseClass
    {
        [Key]
        public int Id { get; set; }
        public Status Status { get; set; } = Status.Created;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
