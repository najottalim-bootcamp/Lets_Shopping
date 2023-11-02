using LetsShopping.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Service.Dtos.OrdersDtos
{
    internal class OrderDetailsDto
    {
        public int UserId { get; set; }
        public int BranchAddressId { get; set; }
        public decimal Total { get; set; }
        public OrderStatus Status { get; set; }
    }
}
