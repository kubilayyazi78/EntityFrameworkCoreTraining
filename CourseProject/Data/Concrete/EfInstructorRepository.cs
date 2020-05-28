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
            //return _context.Instructors.Include(i => i.Courses);

            //IEnumerable<Instructor> instructors = _context.Instructors;

            //foreach (var ins in instructors)
            //{
            //    _context.Entry(ins).Collection(i => i.Courses)
            //        .Query()
            //        .Where(i => i.isActive)
            //        .Load();
            //}
            //return instructors;

            _context.Courses.Where(i => i.Instructor != null ).Load();//&& i.isActive

            return _context.Instructors;

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
