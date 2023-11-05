namespace LetsShopping.Domain.Models.Card
{
    public class Card : BaseClass
    {
        public int CardNumber { get; set; }
        public DateTime ExpireData { get; set; }
        public int Amount { get; set; }
        public DateTime? DeletedAt { get; set; }

    }
}
