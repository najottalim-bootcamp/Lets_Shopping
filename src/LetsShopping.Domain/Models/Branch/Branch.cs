using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Domain.Models.Branch
{
    public class Branch 
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string TelePhone { get; set; }
    }
}
