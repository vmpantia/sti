using Microsoft.AspNetCore.Mvc;

namespace STI.Web.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
