namespace LetsShopping.Api.Controllers.Carts
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartsController : ControllerBase
    {
        private readonly ICartService _cart;
        public CartsController(ICartService cart)
        {
            _cart = cart;
        }
        [HttpGet]
        public IActionResult GetAllAsync()
        {
            var result = _cart.GetAllAsync();
            return Ok(result.Result);
        }
        [HttpGet("{id}")]
        public IActionResult GetByIdAsync(int id)
        {
            var result = _cart.GetByIdAsync(id);
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult CreateAsync(CartDto cartsDto)
        {
            var result = _cart.CreateAsync(cartsDto);
            return Ok(result.Result);
        }
        [HttpPatch]
        public IActionResult UpdateAsync(int Id, CartDto cartsDto)
        {
            var result = _cart.UpdateAsync(Id, cartsDto);
            return Ok(result.Result);
        }
        [HttpDelete]
        public IActionResult DeleteAsync(int Id)
        {
            var result = _cart.DeleteAsync(Id);
            return Ok(result.Result);
        }
    }
}
