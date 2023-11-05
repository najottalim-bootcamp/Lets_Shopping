using LetsShopping.Domain.Dtos.CardDtos;
using LetsShopping.Domain.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.DataAccess.Repositories.CardsRepositories
{
    public class CardRepository : BaseRepository, ICardRepisotry
    {
        public ValueTask<int> CreateAsync(CardDto model)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> DeleteAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IList<Card>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Card> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> UpdateAsync(int Id, CardDto model)
        {
            throw new NotImplementedException();
        }
    }
}
