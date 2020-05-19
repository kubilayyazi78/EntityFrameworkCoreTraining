using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            CourseProject.Models.Request model = new Models.Request();

            model.Name = "Kubilay";
            model.Email = "kubilayyazi@hotmail.com";
            model.Phone = "0537345894";
            model.Message = "Kursa Başlandı";
                

            return View(model);
        }
    }
}