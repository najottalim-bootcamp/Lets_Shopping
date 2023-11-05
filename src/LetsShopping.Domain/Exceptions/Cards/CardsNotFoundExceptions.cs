namespace LetsShopping.Domain.Exceptions.Cards
{
    public class CardsNotFoundExceptions : NotFoundException
    {
        public CardsNotFoundExceptions() 
        {
            this.TitleMessage = "Cards not Found!";            
        }

    }
}
