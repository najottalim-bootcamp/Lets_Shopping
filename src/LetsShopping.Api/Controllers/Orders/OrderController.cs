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
        public  IActionResult CreateOrder(OrderDto order)
        {
            var result = _order.CreateOrder(order);
            if (result.Result > 0)
            {
                return Ok("Created");
            }
            return BadRequest("Do not Created!");
            
        }
        [HttpPut]
        public IActionResult UpdateOrder(int id,OrderDto order)
        {
            var updated = _order.UpdateOrder(id, order);
            if (updated.Result > 0)
            {
                return Ok("Updated");
            }
            return BadRequest("Do not Updated");
        }
        [HttpDelete]
        public IActionResult DeleteOrder(int id)
        {
            var deleted = _order.DeleteOrder(id);
            if (deleted.Result > 0)
            {

                return Ok("Deleted");
            }
            return BadRequest("Do not deleted");
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
            var created = _order.CreatedOrderList(order);
            if (created.Result > 0)
            {
                return Ok("Created");
            }
            return BadRequest("Do not created!");
        }
        [HttpPut]
        public IActionResult UpdateOrderList(int id,OrderListDto order)
        {
            var updated = _order.UpdateOrderList(id, order);
            if (updated.Result > 0)
            {
                return Ok("Updated");
            }
            return BadRequest("Do not Updated!");
        }
        [HttpDelete]
        public IActionResult DeleteOrderList(int id)
        {
            var deleted = _order.DeleteOrderList(id);
            if (deleted.Result > 0)
            {
                return Ok("Deleted");
            }
            return BadRequest("Do not deleted");
        }
        
    }
}
