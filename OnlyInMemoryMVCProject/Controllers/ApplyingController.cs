using Microsoft.AspNetCore.Mvc;
using OnlyInMemoryMVCProject.Models;


namespace OnlyInMemoryMVCProject.Controllers
{
    public class ApplyingController : Controller
    {
        public IActionResult Apply()
        {
            return View();
        }
    }
}