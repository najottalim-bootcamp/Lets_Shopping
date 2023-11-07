using LetsShopping.Domain.Dtos.CardDtos;
using LetsShopping.Service.Interfaces.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LetsShopping.Api.Controllers.Users
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        #region Card Controller
        [HttpPost]
        public  IActionResult CreateCard(CardDto model) 
        {
            var res = _userService.CreateCardAsync(model);
            return Ok(res);
        }
        [HttpGet]
        public IActionResult GetAllCard() 
        {
            var res = _userService.GetAllCardAsync();
            return Ok(res);
        }
        [HttpGet]
        public IActionResult GetAllCardById(int Id)
        {
            var res = _userService.GetCardByIdAsync(Id);
            return Ok(res);
        }
        [HttpDelete]
        public IActionResult DeleteCard(int Id)
        {
            var res = _userService.DeleteCardAsync(Id);
            return Ok(res);
        }
        [HttpPut]
        public IActionResult UpdateCard(int Id,CardDto card)
        {
            var res = _userService.UpdateCardAsync(Id,card);
            return Ok(res);
        }


        #endregion Card Controller
    }
}
