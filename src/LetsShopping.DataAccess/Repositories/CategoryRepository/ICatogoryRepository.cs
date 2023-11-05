using LetsShopping.Domain.Models.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.DataAccess.Repositories.CategoryRepository
{
    public interface ICatogoryRepository:IBaseRepository<Category,Category>
    {
    }
}
