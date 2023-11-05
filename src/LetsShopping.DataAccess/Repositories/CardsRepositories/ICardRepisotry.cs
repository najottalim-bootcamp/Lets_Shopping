using LetsShopping.Domain.Dtos.CardDtos;
using LetsShopping.Domain.Models.Cards;

namespace LetsShopping.DataAccess.Repositories.CardsRepositories
{
    public interface ICardRepisotry : IBaseRepository<Card, CardDto>
    {

    }
}
