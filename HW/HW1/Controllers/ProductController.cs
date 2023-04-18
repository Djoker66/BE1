using Microsoft.AspNetCore.Mvc;

namespace HW1.Controllers
{
    public class ProductController : Controller
    {
        public ContentResult Details( int id, string name, decimal price)
       {
           ContentResult result = new ContentResult();
           result.Content = "Product detail - Id: " + id + "  name: " + name + "  price:" + price;
           return result;
       }
    }
}
