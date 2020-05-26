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

                    if (_context.Instructors.Count() == 0)
                    {
                        _context.Instructors.AddRange(Instructors);
                    }

                    if (_context.Courses.Count() == 0)
                    {
                        _context.Courses.AddRange(Courses);
                    }
                   

                }
                //if (context is IdendityContext)
                //{

                //}

                if (context is UserContext)
                {
                    UserContext _userContext = context as UserContext;

                    if (_userContext.Users.Count() == 0)
                    {
                        _userContext.Users.AddRange(Users);
                    }

                }

            }


            context.SaveChanges();

        }

        private static Course[] Courses
        {
            get
            {
                Course[] courses = new Course[]
                   {
                    new Course(){ Name="Css", Price=10,  Description="About css", isActive=true, Instructor=Instructors[0]},
                    new Course(){ Name="html", Price=20,  Description="About html", isActive=true,Instructor=Instructors[1]},
                    new Course(){ Name="js", Price=10,  Description="About js", isActive=false,Instructor=Instructors[2]},
                     new Course(){ Name="cs", Price=100,  Description="About cs", isActive=false,Instructor=Instructors[3]},
                    new Course(){ Name="c", Price=20,  Description="About c", isActive=true,Instructor=Instructors[0]},
                     new Course(){ Name="react", Price=50,  Description="About react", isActive=true,Instructor=Instructors[0]},
                     new Course(){ Name="angular", Price=5,  Description="About angular", isActive=false,Instructor=Instructors[4]}
                   };
                return courses;
            }
        }
        private static Instructor[] Instructors =
        {
            new Instructor(){Name="Kubilay",Contact =new Contact(){ Email="a", Phone="1", Address=new Address(){City="a", Country="a", Text="a"} } },
            new Instructor(){Name="Ahmet"},
            new Instructor(){Name="Belo"},
            new Instructor(){Name="Alpi"},
            new Instructor(){Name="Mira"}
        };

        private static User[] Users =
        {
          new User(){ City="İstanbul", Email="deneme@hot.com", Password="123", UserName="belo"},
          new User(){ City="Karabük", Email="den222eme@hot.com", Password="1234", UserName="mira"},
          new User(){ City="Adıyaman", Email="denem022e@hot.com", Password="12302", UserName="berko"},
          new User(){ City="Elazığ", Email="eee@hot.com", Password="123", UserName="elazig"},
          new User(){ City="İzmir", Email="35@hot.com", Password="3535", UserName="gelsin"}
        };
    }
}
