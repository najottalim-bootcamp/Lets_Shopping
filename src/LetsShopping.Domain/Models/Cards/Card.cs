using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Domain.Models.Card
{
    public class Card : BaseClass
    {       
        public int CardNumber { get; set; }
        public DateTime ExpireData { get; set; }
        public int Amount { get; set; }
        public CardStatus Status { get; set; }
        public DateTime DeletedAt { get; set; }
     
    }
}
