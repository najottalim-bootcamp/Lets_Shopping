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
        
    }
}
