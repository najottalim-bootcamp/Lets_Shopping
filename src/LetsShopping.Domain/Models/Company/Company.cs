using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Domain.Models.Company
{
    public class Company:BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string СardId { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
