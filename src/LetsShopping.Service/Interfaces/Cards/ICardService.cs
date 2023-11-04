using LetsShopping.Domain.Models.Card;
using LetsShopping.Service.Dtos.CardDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.Service.Interfaces.Cards
{
    public interface ICardService
    {
        public ValueTask<int> CreateProductCategoryAsync(CardDto cardDto);
        public ValueTask<int> UpdateProductCategoryAsync(int CardId, CardDto cardDto);
        public ValueTask<int> DeleteProductCategoryAsync(int CardId);
        public ValueTask<Card> GetByIdProductCategoryId(int CardId, string Tablename);
        public ValueTask<List<Card>> GetAllProductCategory(string Tablename);
    }
}
