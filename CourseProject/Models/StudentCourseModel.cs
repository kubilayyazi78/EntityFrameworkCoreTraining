﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class StudentCourseModel
    {
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Student>  Students{ get; set; }

    }
}
