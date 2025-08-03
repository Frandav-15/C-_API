using Microsoft.AspNetCore.Mvc;
using MyFirst_Api.Data;
using MyFirst_Api.Models;

namespace MyFirst_Api.Controllers
{
   [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly MyAppContext _appContext;

        public ProductController(MyAppContext appContext)
        {
            this._appContext = appContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var list = _appContext.products.ToList();
            return Ok(list);
        }

        [HttpPost]

        public IActionResult AddProduct(ProductDTO pro)
        {
            var product = new Product()
            {
                Description = pro.Description,
                Price = pro.Price

            };

            _appContext.products.Add(product);
            _appContext.SaveChanges();

            return Ok();
        }
    }
}
