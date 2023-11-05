using LetsShopping.Domain.Dtos.UsersDtos;
using LetsShopping.Service.Interfaces.Users;

namespace LetsShopping.Api.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _user;

        public UsersController(IUserService user)
        {
            _user = user;
        }
        [HttpGet]
        public IActionResult GetAllAsync()
        {
            var result = _user.GetAllAsync();
            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetByIdAsync(int id)
        {
            var result = _user.GetByIdAsync(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateAsync(UsersDto usersDto)
        {
            var result = _user.CreateAsync(usersDto);
            return Ok(result);
        }
        [HttpPatch]
        public IActionResult UpdateAsync(int Id, UsersDto usersDto)
        {
            var result = _user.UpdateAsync(Id, usersDto);
            return Ok(result);
        }
        [HttpDelete]
        public IActionResult DeleteAsync(int Id)
        {
            var result = _user.DeleteAsync(Id);
            return Ok(result);
        }

    }
}
