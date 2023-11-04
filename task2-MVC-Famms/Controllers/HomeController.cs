using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic;
using task2_MVC_Famms.Data;
using task2_MVC_Famms.Models;



namespace task2_MVC_Famms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel
            {
                Products = ProductData.ListProducts()
            };
            return View(model);
        }

      
    }
}