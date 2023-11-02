using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Service.Dtos.ProductsDtos
{
    public class ProductInventoryDto
    {
        public decimal Quantity { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
