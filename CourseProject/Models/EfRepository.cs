using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class EfRepository : IRepository
    {

        private DataContext _context;

        public EfRepository(DataContext context)
        {
            _context = context;
        }

        public IQueryable<Request> Requests => _context.Requests;

        public IQueryable<Course> Courses => _context.Courses;
    }
}
