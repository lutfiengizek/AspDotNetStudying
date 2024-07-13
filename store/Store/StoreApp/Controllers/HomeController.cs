using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Controllers 
{
    public class HomeController : Controller
    {
        public ActionResult Index(){
            return View("Index");
        }
    }
}