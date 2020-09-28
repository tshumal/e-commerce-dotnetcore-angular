
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase    
    {
        [HttpGet]
        public string GetProducts()
        {
            return "reutrn list products";
        }

        [HttpGet("{id}")]
        public string GetProduct()
        {
            return "reutrn a product";
        }
        
    }
}