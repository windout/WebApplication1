
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly Product _product;
        public ProductController(Product product)
        {
            _product = product;
        }
        [HttpGet("api/[Controller]/List")]
        public dynamic GetAllProducts()
        {
            return _product.GetAllList();
        }
    }  
}
