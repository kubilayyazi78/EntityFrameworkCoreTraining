﻿using System;
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
            return View(_repository.GetAll());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            TempData["InstructorEditId"] = id;
            return View("Index");
        }

        [HttpPost]
        public IActionResult Edit(Instructor entity)
        {
            _repository.Update(entity);
            return View("Index");
        }
    }
}