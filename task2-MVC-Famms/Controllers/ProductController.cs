using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using task2_MVC_Famms.Data;
using task2_MVC_Famms.Entities;
using task2_MVC_Famms.Models;

namespace task2_MVC_Famms.Controllers
{
    public class ProductController : Controller
    {
        //private List<Product> Products;

        public IActionResult Index()
        {
            var model = new ProductIndexViewModel
            {
                Products = ProductData.ListProducts()
            };
            return View(model);
        }
    }
}
