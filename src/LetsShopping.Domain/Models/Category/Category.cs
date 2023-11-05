namespace LetsShopping.Domain.Models.Category
{
    public class Category : BaseClass
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }
}
