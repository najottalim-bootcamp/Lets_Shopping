namespace LetsShopping.Domain.Models.Cards
{
    public class Card : BaseClass
    {
        public string CardNumber { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Amount { get; set; }

    }
}
