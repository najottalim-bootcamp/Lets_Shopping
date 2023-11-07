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
        public IActionResult CreateCard(CardDto model)
        {
            var res =  _userService.CreateCardAsync(model);
            if(res.Result >0) 
            {
                return Ok("Created");

            }
            return BadRequest("was not created");
        }
        [HttpGet]
        public IActionResult GetAllCard()
        {
            var res = _userService.GetAllCardAsync();
            return Ok(res.Result);
        }
        [HttpGet]
        public IActionResult GetAllCardById(int Id)
        {
            var res = _userService.GetCardByIdAsync(Id);
            return Ok(res.Result);
        }
        [HttpDelete]
        public IActionResult DeleteCard(int Id)
        {
            var res = _userService.DeleteCardAsync(Id);
            if (res.Result <0)
            {
                return Ok("Deleted");

            }
            return BadRequest("was not Deleted");
        }
        [HttpPut]
        public IActionResult UpdateCard(int Id, CardDto card)
        {
            var res = _userService.UpdateCardAsync(Id, card);
            if (res.Result > 0)
            {
                return Ok("Updated");

            }
            return BadRequest("was not Updated");
        }


        #endregion Card Controller





        #region User Controller
        [HttpPost]
        public IActionResult CreateUser(UsersDto model)
        {
            var res = _userService.CreateUserAsync(model);
            if (res.Result > 0)
            {
                return Ok("Created");

            }
            return BadRequest("was not created");
        }
        [HttpGet]
        public IActionResult GetAllUser()
        {
            var res = _userService.GetAllUserAsync();
            return Ok(res.Result);
        }
        [HttpGet]
        public IActionResult GetAllUserById(int Id)
        {
            var res = _userService.GetUserByIdAsync(Id);
            return Ok(res.Result);
        }
        [HttpDelete]
        public IActionResult DeleteUser(int Id)
        {
            var res = _userService.DeleteUserAsync(Id);
            if (res.Result < 0)
            {
                return Ok("Deleted");

            }
            return BadRequest("was not deleted");
        }
        [HttpPut]
        public IActionResult UpdateUser(int Id, UsersDto user)
        {
            var res = _userService.UpdateUserAsync(Id, user);
            if (res.Result > 0)
            {
                return Ok("Updated");

            }
            return BadRequest("was not updated");
        }


        #endregion User Controller






        #region Cart Controller
        [HttpPost]
        public IActionResult CreateCart(CartDto model)
        {
            var res = _userService.CreateCartAsync(model);
            if (res.Result > 0)
            {
                return Ok("Created");

            }
            return BadRequest("was not created");
        }
        [HttpGet]
        public IActionResult GetAllCart(int UserId)
        {
            var res = _userService.GetAllCartByUserIdAsync(UserId);
            return Ok(res.Result);
        }
        [HttpGet]
        public IActionResult GetAllCartById(int Id)
        {
            var res = _userService.GetCartByIdAsync(Id);
            return Ok(res.Result);
        }
        [HttpDelete]
        public IActionResult DeleteCart(int Id)
        {
            var res = _userService.DeleteCartAsync(Id);
            if (res.Result < 0)
            {
                return Ok("Deleted");

            }
            return BadRequest("was not deleted");
        }
        [HttpPut]
        public IActionResult UpdateCart(int Id, CartDto cart)
        {
            var res = _userService.UpdateCartAsync(Id, cart);
            if (res.Result > 0)
            {
                return Ok("Updated");

            }
            return BadRequest("was not updated");
        }


        #endregion Cart Controller


        [HttpGet]
        public IActionResult GetAllCategory()
        {
            var res = _userService.GetAllCategory();
            return Ok(res.Result);
        }
        [HttpGet]

        public IActionResult GetAllCompnay()
        {
            var res = _userService.GetAllCompany();
            return Ok(res.Result);
        }
        [HttpGet]
        public IActionResult GetOrders(int userId)
        {
            var res = _userService.GetAllOrderByUserId(userId);
            return Ok(res.Result);
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var res = _userService.GetAllProduct();
            return Ok(res.Result);
        }


    }
}
