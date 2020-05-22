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
        private IRepository _repository;

        public CourseController(IRepository repository)
        {
            _repository = repository;
        }
         
        public IActionResult Index()
        {
            return View();
        }
    }
}