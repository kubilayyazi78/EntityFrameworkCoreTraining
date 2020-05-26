using CourseProject.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
   public interface IInstructorRepository:IGenericRepository<Instructor>
    {
        //Instructor Get(int id);
        //IEnumerable<Instructor> GetAll();
        //void Delete(int id);
        //void Update(Instructor entity);
        //void Insert(Instructor entity);


        IEnumerable<Instructor> GetTopInstructor();
    }
}
