namespace LetsShopping.Domain.Exceptions.Users
{
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException() 
        {
            this.TitleMessage = "Not found User !";
        }
    }
}
