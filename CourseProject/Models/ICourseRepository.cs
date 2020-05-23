﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
   public interface ICourseRepository
    {
       // IQueryable<Request> Requests { get; }
        IQueryable<Course> Courses { get; }


        Course GetById(int courseId);

        IEnumerable<Course> GetCourses();

        IEnumerable<Course> GetCoursesActive(bool isActive);

        void CreateCourse(Course newCourse);

        void UpdateCourse(Course updateCourse);

        void DeleteCourse(int courseId);
    }


}