using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Service.Dtos.AddressDto
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public enum Status
        {

        }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
