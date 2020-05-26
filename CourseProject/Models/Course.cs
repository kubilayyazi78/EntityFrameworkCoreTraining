using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Course
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool isActive { get; set; }

        // bir kursun bir eğitmeni olur "bir" kısmına navigation property ekliyoruz.
        //lazy loading
        //aynı işlem null olabilir   public int? InstructorId { get; set; }

        public int InstructorId { get; set; }
        public  Instructor Instructor { get; set; }


    }
}
