using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Controllers
{
    public class StudentCourseController : Controller
    {

        private DataContext _context;

        public StudentCourseController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {//modelin kurs kısmı dolduruldu.
            var model = new StudentCourseModel();
            model.Courses = _context
                .Courses
                .Include(i => i.StudentCourses)
                .ThenInclude(i => i.Student)
             //   .Where(i=>i.isActive)
                .ToList();

            //modelin student kısmı

            model.Students = _context
                .Students
                .Include(i => i.StudentCourses)
                .ThenInclude(i => i.Course)
              //  .Where(i=>i.StudentCourses
            //    .Any(j=>j.Course.isActive))//onaylı bir kursa dahil olmus öğrencileri getiriyoruz.
                .ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult EditStudent(int id)
        {
            var student = _context.Students.Find(id);
            ViewBag.Courses = _context.Courses.Include(p => p.StudentCourses);//ilişkileri öğrenmek için
            return View("StudentEditor", student);
        }

        [HttpPost]
        public IActionResult EditStudent(int id,int[] courseId)
        {
            Student student = _context.Students.Include(s => s.StudentCourses)
                .First(i => i.Id == id);

            if (student!=null)
            {
                student.StudentCourses = courseId.Select(cid => new StudentCourse()
                {
                    CourseId = cid,
                    StudentId = id
                }).ToList();
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}