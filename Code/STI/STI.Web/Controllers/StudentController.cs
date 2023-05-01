using Microsoft.AspNetCore.Mvc;
using STI.BAL.Contractors;
using STI.BAL.Models.DTOs;
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

        public async Task<IActionResult> Add()
        {
            var model = new StudentViewModel
            {
                inputStudent = new StudentDTO()
            };
            return View(model);
        }
    }
}
