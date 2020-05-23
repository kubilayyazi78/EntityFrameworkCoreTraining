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

        public void CreateCourse(Course newCourse)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourse(int courseId)
        {
            throw new NotImplementedException();
        }

        public Course GetById(int courseId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCourses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesActive(bool isActive)
        {
            return _context.Courses.Where(i => i.isActive == isActive).ToList();
        }

        public void UpdateCourse(Course updateCourse)
        {
            throw new NotImplementedException();
        }
    }
}
