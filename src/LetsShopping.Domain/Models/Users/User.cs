namespace LetsShopping.Domain.Models.Users
{
    public class User : BaseClass
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
    }
}
