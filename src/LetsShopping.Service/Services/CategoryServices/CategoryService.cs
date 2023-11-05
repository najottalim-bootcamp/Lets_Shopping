using LetsShopping.DataAccess.Repositories.CardsRepositories;
using LetsShopping.DataAccess.Repositories.CartsRepositories;
using LetsShopping.DataAccess.Repositories.CategoryRepository;
using LetsShopping.Domain.Dtos.Category;
using LetsShopping.Domain.Exceptions.Carts;
using LetsShopping.Domain.Exceptions.Users;
using LetsShopping.Domain.Models.Cards;
using LetsShopping.Domain.Models.Carts;
using LetsShopping.Domain.Models.Category;
using LetsShopping.Service.Interfaces.ICategoryInterface;

namespace LetsShopping.Service.Services.CategoryServices
{
    public class CategoryService : ICatogoryInterface
    {
        private readonly ICatogoryRepository _catogoryRepository;
        public CategoryService(ICatogoryRepository catogoryRepository)
        {
            _catogoryRepository = catogoryRepository;
        }
        public async ValueTask<int> CreateAsync(CategoryDto model)
        {
            int result = await _catogoryRepository.CreateAsync(model);
            if (result == 0)
            {
                throw new CartsNotFoundException();
            }
            return result;
        }

        public async ValueTask<int> DeleteAsync(int Id)
        {
            int res = await _catogoryRepository.DeleteAsync(Id);
            if (res == 0)
            {
                throw new CartsNotFoundException();
            }
            return res;
        }

        public async ValueTask<IList<Category>> GetAllAsync()
        {
            IList<Category> categories = (await _catogoryRepository.GetAllAsync());
            if (categories == null)
            {
                throw new UserNotFoundException();
            }
            return categories;
        }

        public async ValueTask<Category> GetByIdAsync(int Id)
        {
            Category category = await _catogoryRepository.GetByIdAsync(Id);
            if (category == null)
            {
                throw new CartsNotFoundException();
            }
            return category;
        }

        public async ValueTask<int> UpdateAsync(int Id, CategoryDto model)
        {
            int update = await _catogoryRepository.UpdateAsync(Id, model);
            if (update == 0)
            {
                throw new CartsNotFoundException();
            }
            return update;
        }
    }
}
