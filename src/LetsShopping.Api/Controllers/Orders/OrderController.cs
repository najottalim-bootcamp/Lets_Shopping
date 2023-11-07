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
        public IActionResult GetAllOrder() 
        {
            var result =_order.GetAllOrder();
            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetByIdOrder(int id)
        {
            var result = _order.GetByIdOrder(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult CreateOrder(OrderDto order)
        {
            _order.CreateOrder(order);
            return Ok("Created");
        }
        [HttpPatch]
        public IActionResult UpdateOrder(int id,OrderDto order)
        {
            _order.UpdateOrder(id, order);
            return Ok("Updated");
        }
        [HttpDelete]
        public IActionResult DeleteOrder(int id)
        {
            _order.DeleteOrder(id);
            return Ok("Deleted");
        }

        
        
    }
}
