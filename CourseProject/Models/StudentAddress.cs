using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class StudentAddress
    {

        public int Id { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        //Navigation prop

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
