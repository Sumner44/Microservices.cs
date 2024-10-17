using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using ProductServices.Models;





namespace OrderService.Controllers
{ 
[ApiController]
[Route("[controller]")]
public class OrdersController : ControllerBase
{
    private static readonly List<Order> orders = new List<Order>
    {
        new Order { Id = 1, OrderDate = DateTime.Now, CustomerName = "John Doe", Products = new List<Product> { new Product { Id = 1, Name = "Product 1", Price = 10.00M } } }
    };

    [HttpGet]
    public ActionResult<List<Order>> GetOrders()
    {
        return Ok(orders);
    }
}
}
