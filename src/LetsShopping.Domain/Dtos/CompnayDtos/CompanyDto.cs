using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Domain.Dtos.CompnayDtos
{
    public class CompanyDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public int AddressId { get; set; }
        public int СardId { get; set; }
    }
}
