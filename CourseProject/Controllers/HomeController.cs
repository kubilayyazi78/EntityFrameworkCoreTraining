using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Controllers
{
    public class HomeController : Controller
    {
        private DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //    CourseProject.Models.Request model = new Models.Request();

            //    model.Name = "Kubilay";
            //    model.Email = "kubilayyazi@hotmail.com";
            //    model.Phone = "0537345894";
            //    model.Message = "Kursa Başlandı";


            //    return View(model);
            //}

            return View();
        }
        [HttpGet]
        public IActionResult AddRequest()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRequest(Request model)
        {
            _context.Requests.Add(model);
            _context.SaveChanges();
            return View("Thanks",model);
        }

    }
}