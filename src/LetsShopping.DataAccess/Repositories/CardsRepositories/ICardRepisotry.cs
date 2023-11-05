using LetsShopping.Domain.Dtos.CardDtos;
using LetsShopping.Domain.Models.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsShopping.DataAccess.Repositories.CardsRepositories
{
    public interface ICardRepisotry : IBaseRepository<Card , CardDto>
    {

    }
}
