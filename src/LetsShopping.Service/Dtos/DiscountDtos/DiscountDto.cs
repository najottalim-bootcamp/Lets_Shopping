using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Service.Dtos.DiscountDtos
{
    public class DiscountDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int DiscountPercent { get; set; }
        public bool Active { get; set; }
    }
}
