using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Service.Dtos.CategoryDto
{
    public class CategoryDto
    { 
        public string? Name { get; set; }
        public int ParentId { get; set; }
    }
}
