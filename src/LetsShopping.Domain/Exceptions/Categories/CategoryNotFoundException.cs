namespace LetsShopping.Domain.Exceptions.Categories
{
    public class CategoryNotFoundException : NotFoundException
    {
        public CategoryNotFoundException() 
        {
            this.TitleMessage = "Category not found!";
        }
    }
}
