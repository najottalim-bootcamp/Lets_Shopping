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
            _userService.CreateCardAsync(model);
            return Ok("Created");            
        }
        [HttpGet]
        public IActionResult GetAllCard() 
        {
            var res = _userService.GetAllCardAsync();
            return Ok(res);
        }
        
        #endregion Card Controller
    }
}
