namespace LetsShopping.Domain.Exceptions.Orders
{
    public class OrderListNotFoundException : NotFoundException
    {
        public OrderListNotFoundException()
        {
            this.TitleMessage = "OrderList Not Found !";
        }
    }
}
