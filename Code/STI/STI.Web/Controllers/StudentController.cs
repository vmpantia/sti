using Microsoft.AspNetCore.Mvc;
using STI.BAL.Contractors;
using STI.Web.Models;

namespace STI.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _student;
        public StudentController(IStudentService student) => _student = student;

        public async Task<IActionResult> Index()
        {
            var model = new StudentViewModel
            {
                studentList = await _student.GetStudentsAsync()
            };
            return View(model);
        }
    }
}
