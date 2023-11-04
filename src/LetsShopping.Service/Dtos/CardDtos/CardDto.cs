using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Service.Dtos.CardDtos
{
    public class CardDto
    {
        public int CardNumber { get; set; }
        public DateTime ExpireData { get; set; }
        public int Amount { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
