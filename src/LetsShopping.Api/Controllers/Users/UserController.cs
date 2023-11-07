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
            var res = _userService.CreateCardAsync(model);
            return Ok(res.Result);
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
            return Ok(res.Result);
        }
        [HttpPut]
        public IActionResult UpdateCard(int Id, CardDto card)
        {
            var res = _userService.UpdateCardAsync(Id, card);
            return Ok(res.Result);
        }


        #endregion Card Controller





        #region User Controller
        [HttpPost]
        public IActionResult CreateUser(UsersDto model)
        {
            var res = _userService.CreateUserAsync(model);
            return Ok(res.Result);
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
            return Ok(res.Result);
        }
        [HttpPut]
        public IActionResult UpdateUser(int Id, UsersDto user)
        {
            var res = _userService.UpdateUserAsync(Id, user);
            return Ok(res.Result);
        }


        #endregion User Controller






        #region Cart Controller
        [HttpPost]
        public IActionResult CreateCart(CartDto model)
        {
            var res = _userService.CreateCartAsync(model);
            return Ok(res);
        }
        [HttpGet]
        public IActionResult GetAllCart(int UserId)
        {
            var res = _userService.GetAllCartByUserIdAsync(UserId);
            return Ok(res);
        }
        [HttpGet]
        public IActionResult GetAllCartById(int Id)
        {
            var res = _userService.GetCartByIdAsync(Id);
            return Ok(res);
        }
        [HttpDelete]
        public IActionResult DeleteCart(int Id)
        {
            var res = _userService.DeleteCartAsync(Id);
            return Ok(res);
        }
        [HttpPut]
        public IActionResult UpdateCart(int Id, CartDto cart)
        {
            var res = _userService.UpdateCartAsync(Id, cart);
            return Ok(res);
        }


        #endregion Cart Controller


        [HttpGet]
        public IActionResult GetAllCategory()
        {
            var res = _userService.GetAllCategory();
            return Ok(res);
        }
        [HttpGet]

        public IActionResult GetAllCompnay()
        {
            var res = _userService.GetAllCompany();
            return Ok(res);
        }
        [HttpGet]
        public IActionResult GetOrders(int userId)
        {
            var res = _userService.GetAllOrderByUserId(userId);
            return Ok(res);
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var res = _userService.GetAllProduct();
            return Ok(res);
        }


    }
}
