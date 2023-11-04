namespace LetsShopping.Domain.Models.Users
{
    public class User : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public DateTime DeletedAt { get; set; }
        public int CardId { get; set; }
    }
}
