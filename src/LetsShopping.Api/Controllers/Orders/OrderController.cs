namespace LetsShopping.Api.Controllers.Orders
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderInterface _order;
        public OrderController(IOrderInterface order)
        {
            _order = order;
        }
        [HttpGet]
        public IActionResult GetAllAsync()
        {
            var result = _order.GetAllAsync();
            return Ok(result.Result);
        }
        [HttpGet]
        public IActionResult GetByIdAsync(int id)
        {
            var result = _order.GetByIdAsync(id);
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult CreateAsync(OrderDto orderDto)
        {
            var result = _order.CreateAsync(orderDto);
            return Ok(result.Result);
        }
        [HttpPatch]
        public IActionResult UpdateAsync(int Id, OrderDto orderDto)
        {
            var reuslt = _order.UpdateAsync(Id, orderDto);
            return Ok(reuslt);
        }
        [HttpDelete]
        public IActionResult DeleteAsync(int Id)
        {
            var result = _order.DeleteAsync(Id);
            return Ok(result.Result);
        }
    }
}
