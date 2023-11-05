using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Domain.Models.Adress
{
    public class Adress:BaseClass
    {
        public  string Country { get; set; }
        public string City { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
