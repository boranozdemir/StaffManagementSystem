using Microsoft.AspNetCore.Mvc;

namespace StaffManagement.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
