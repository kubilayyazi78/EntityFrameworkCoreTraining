using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class EfCourseRepository : ICourseRepository
    {

        private DataContext _context;

        public EfCourseRepository(DataContext context)
        {
            _context = context;
        }

        //  public IQueryable<Request> Requests => _context.Requests;

        public IQueryable<Course> Courses => _context.Courses;

        public int CreateCourse(Course newCourse)
        {
            _context.Courses.Add(newCourse);

            _context.SaveChanges();

            return newCourse.Id;
        }

        public void DeleteCourse(int courseId)
        {
           // var entity = _context.Courses.Where(i => i.Id == courseId).FirstOrDefault();

            _context.Courses.Remove(new Course() {
                 Id=courseId
            });

            _context.SaveChanges();
        }

        public Course GetById(int courseId)
        {
            return _context.Courses.Include(i=>i.Instructor).Where(i => i.Id == courseId).FirstOrDefault();

            //return _context.Courses.Find(courseId);
        }

        public IEnumerable<Course> GetCourses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesActive(bool isActive)
        {
            return _context.Courses.Where(i => i.isActive == isActive).ToList();
        }

        public IEnumerable<Course> GetCoursesByFilters(string name = null, decimal? price = null, string isActive = null)
        {
            IQueryable<Course> query = _context.Courses;

            if (name!=null)
            {
                query = query.Where(i => i.Name.ToLower().Contains(name.ToLower()));
            }

            if (price!=null)
            {
                query = query.Where(i => i.Price >= price);
            }

            if (isActive=="on")
            {
                query = query.Where(i => i.isActive == true);
            }

            return query.Include(i=>i.Instructor).ToList();

        }

        public void UpdateCourse(Course updateCourse, Course originalCourse = null)
        {
            //_context.Courses.Update(updateCourse);
            //_context.SaveChanges();

            if (originalCourse == null)
            {

                originalCourse = _context.Courses.Find(updateCourse.Id);
            }
            else
            {
                _context.Courses.Attach(originalCourse);
            }



            originalCourse.Name = updateCourse.Name;
            originalCourse.Description = updateCourse.Description;
            originalCourse.Price = updateCourse.Price;
            originalCourse.isActive = updateCourse.isActive;

            EntityEntry entry = _context.Entry(originalCourse);

            Console.WriteLine($"Entity State :  {entry.State}");
            // Modifed, Uncanged,Added,Deleted,Detached

            foreach (var property in new string[] { "Name", "Description", "Price", "isActive" })
            {
                Console.WriteLine($"{property} - old : {entry.OriginalValues[property]} new : {entry.CurrentValues[property]}");
            }

            _context.SaveChanges();

        }
    }
}
