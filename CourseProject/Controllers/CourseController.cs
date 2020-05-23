using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Controllers
{
    public class CourseController : Controller
    {
        private ICourseRepository _repository;

        public CourseController(ICourseRepository repository)
        {
            _repository = repository;
        }
         
        public IActionResult Index()
        {
            var courses = _repository.GetCoursesActive(true);

           ViewBag.CourseCount = courses.Count();
            return View(courses);

        }
    }
}