using LetsShopping.Domain.Dtos.OrdersDtos;

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
            return Ok(result.Result);
        }
        [HttpGet]
        public IActionResult GetByIdOrder(int id)
        {
            var result = _order.GetByIdOrder(id);
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult CreateOrder(OrderDto order)
        {
            _order.CreateOrder(order);
            return Ok("Created");
        }
        [HttpPut]
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
        [HttpGet]
        public IActionResult GetAllOrderList()
        {
            var result = _order.GetAllOrderList();
            return Ok(result.Result);
        }
        [HttpGet]
        public IActionResult GetByIdOrderList(int id)
        {
            var result = _order.GetByIdOrderList(id);
            return Ok(result.Result);
        }
        [HttpPost]
        public IActionResult CreatedOrderList(OrderListDto order)
        {
            _order.CreatedOrderList(order);
            return Ok("Created");
        }
        [HttpPut]
        public IActionResult UpdateOrderList(int id,OrderListDto order)
        {
            _order.UpdateOrderList(id, order);
            return Ok("Updated");
        }
        [HttpDelete]
        public IActionResult DeleteOrderList(int id)
        {
            _order.DeleteOrderList(id);
            return Ok("Deleted");
        }
        
    }
}
