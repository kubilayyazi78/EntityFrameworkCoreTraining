using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseProject.Controllers
{
    public class InstructorController : Controller
    {
        private IInstructorRepository _repository;

        public InstructorController(IInstructorRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            ViewBag.InstructorEditId = TempData["InstructorEditId"];
            ViewBag.InstructorCreateId = TempData["InstructorCreateId"];
            ViewBag.InstructorChangeId = TempData["InstructorChangeId"];
            return View(_repository.GetAll());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            TempData["InstructorEditId"] = id;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Instructor entity)
        {
            _repository.Update(entity);
            return RedirectToAction("Index");
        }

        public IActionResult Create(int id)
        {
            TempData["InstructorCreateId"] = id;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Change(int id)
        {
            TempData["InstructorChangeId"] = id;
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Change(Instructor entity)
        {
            _repository.Update(entity);
            return RedirectToAction("Index");
        }

    }
}