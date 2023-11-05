using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Domain.Models.Cards
{
    public class Card : BaseClass
    {
        public string CardNumber { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Amount { get; set; }
        public DateTime? DeletedAt { get; set; }

    }
}
