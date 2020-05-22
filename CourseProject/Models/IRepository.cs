using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
   public interface IRepository
    {
        IEnumerable<Request> Requests { get; }
        IEnumerable<Course> Courses { get; }
    }
}
