using CourseProject.Data.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class EfInstructorRepository :GenericRepository<Instructor>, IInstructorRepository
    {

        private DataContext _context;

        public EfInstructorRepository(DataContext context):base(context)
        {
            _context = context;
        }

        public IEnumerable<Instructor> GetTopInstructor()
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Instructor> GetAll()
        {
            return _context.Instructors.Include(i => i.Courses);
        }

        //public void Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Instructor Get(int id)
        //{
        //    return _context.Instructors.Where(i => i.Id == id).FirstOrDefault();
        //}

        //public IEnumerable<Instructor> GetAll()
        //{
        //    return _context.Instructors;
        //}

        //public void Insert(Instructor entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Instructor entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
