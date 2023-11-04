using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace task2_MVC_Famms.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
