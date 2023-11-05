namespace LetsShopping.Domain.Exceptions.Carts
{
    public class CartsNotFoundException : NotFoundException
    {
        public CartsNotFoundException()
        {
            this.TitleMessage = "Carts not Found!";
        }
    }
}
