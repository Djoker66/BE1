using Microsoft.AspNetCore.Mvc;

namespace HW1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About() 
        {
            return View(); 
        } 
        
        public ActionResult Contact()
        {
            return View();
        }
    }
}
