namespace LetsShopping.Domain.Exceptions.Addresses
{
    public class AddressNotFoundExeption : NotFoundException
    {
        public AddressNotFoundExeption() 
        {
            this.TitleMessage = "Address not Found!";
        }

    }
}
