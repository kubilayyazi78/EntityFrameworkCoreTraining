using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class StudentCourse
    {  //N-N İLİŞKİ
        public int Id { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }


        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
