using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public static class SeedDatabase
    {
        public static void Seed(DbContext context)
        {
            //context.Database.Migrate();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context is DataContext)
                {
                    DataContext _context = context as DataContext;

                    if (_context.Courses.Count() == 0)
                    {
                        _context.Courses.AddRange(Courses);
                    }
                    if (_context.Instructors.Count()==0)
                    {
                        _context.Instructors.AddRange(Instructors);
                    }

                    context.SaveChanges();
                }
                //if (context is IdendityContext)
                //{

                //}

            }

        }

        private static Course[] Courses =
        {
          new Course(){ Name="Css", Price=10,  Description="About css", isActive=true},
          new Course(){ Name="html", Price=20,  Description="About html", isActive=true},
          new Course(){ Name="js", Price=10,  Description="About js", isActive=false},
          new Course(){ Name="cs", Price=100,  Description="About cs", isActive=false},
          new Course(){ Name="c", Price=20,  Description="About c", isActive=true},
          new Course(){ Name="react", Price=50,  Description="About react", isActive=true},
          new Course(){ Name="angular", Price=5,  Description="About angular", isActive=false}
        };

        private static Instructor[] Instructors =
        {
            new Instructor(){ City="İstanbul", Name="Kubilay"},
            new Instructor(){ City="İstanbul", Name="Ahmet"},
            new Instructor(){ City="Fas", Name="Belo"},
            new Instructor(){ City="Makedon", Name="Alpi"},
            new Instructor(){ City="Karabük", Name="Mira"}
        };
    }
}
