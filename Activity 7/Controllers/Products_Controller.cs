
using Microsoft.AspNetCore.Mvc;
using ProductServices.Models;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Product 1", Price = 10.00M },
        new Product { Id = 2, Name = "Product 2", Price = 20.00M },
    };

    [HttpGet]
    public ActionResult<List<Product>> GetProducts()
    {
        return Ok(products);
    }
}

