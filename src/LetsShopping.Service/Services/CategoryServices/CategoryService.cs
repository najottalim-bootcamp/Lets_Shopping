using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsShopping.Domain.Dtos.Category;
using LetsShopping.Domain.Models.Category;
using LetsShopping.Service.Interfaces.ICategoryInterface;

namespace LetsShopping.Service.Services.CategoryServices
{
    public class CategoryService : ICatogoryInterface
    {
        public ValueTask<int> CreateAsync(CategoryDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Category>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Category> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateAsync(int Id, CategoryDto model)
        {
            throw new NotImplementedException();
        }
    }
}
