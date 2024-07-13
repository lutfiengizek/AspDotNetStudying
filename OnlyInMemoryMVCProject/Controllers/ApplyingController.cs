using Microsoft.AspNetCore.Mvc;
using OnlyInMemoryMVCProject.Models;


namespace OnlyInMemoryMVCProject.Controllers
{
    
    public class ApplyingController : Controller
    {
        private readonly ILogger<ApplyingController> _logger;
        public ApplyingController(ILogger<ApplyingController> logger)
        {
            _logger = logger;    
        }
        public IActionResult Apply()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Apply(Candidate ApplyData)
        {
            //_logger.LogInformation($"{ApplyData.FirstName}{DateTime.UtcNow.ToLongTimeString()}");
            return View();
        }
    }aslan dayım
}