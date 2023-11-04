using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Domain.Models.Category
{
    public class Category : BaseClass
    {
        public string? Name { get; set; }
        public int ParentId { get; set; }
        public enum Status
        {

        }
        public DateTime ModifiedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
