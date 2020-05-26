using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Data.Abstract;
using CourseProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Controllers
{
    public class ContactController : Controller
    {
        IGenericRepository<Contact> _repository;

        public ContactController(IGenericRepository<Contact> repository)
        {
            _repository = repository;
        }


        public IActionResult Index()
        {
            return View(_repository.GetAll());
        }
    }
}