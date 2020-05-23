using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
   public interface IRepository
    {
        IQueryable<Request> Requests { get; }
        IQueryable<Course> Courses { get; }
    }
}
