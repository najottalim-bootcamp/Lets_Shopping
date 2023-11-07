namespace LetsShopping.Domain.Exceptions.Addresses
{
    public class Address : NotFoundException
    {
        public Address() 
        {
            this.TitleMessage = "Address not Found!";
        }

    }
}
