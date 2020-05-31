using ConsoleApp4.Models.CustomEf;
using ConsoleApp4.Models.DataAnnotations;
using ConsoleApp4.Models.EfCore;
using ConsoleApp4.Models.FluentApi;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomMovieContext db = new CustomMovieContext();

            //foreach (var item in db.Movie.ToList())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //UrunContext db = new UrunContext();

            //foreach (var item in db.Urunler.ToList())
            //{
            //    Console.WriteLine(item.UrunAdi);
            //}

            //FluentApiUrunContext db = new FluentApiUrunContext();

            //foreach (var item in db.Urunler.ToList())
            //{
            //    Console.WriteLine(item.UrunAdi);
            //}



            //using (MovieContext db=new MovieContext())
            //{
            //    string name = "Movie1";
            //    var movies = db.Movie.FromSql($"select * from dbo.Movie where Name={name}")
            //        .Select(i => new {
            //            i.Name
            //        })
            //        .OrderBy(i=>i.Name)
            //        .ToList();

            //    foreach (var item in movies)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}

            //using (MovieContext db = new MovieContext())
            //{
            //    string name = "Dark";
            //    var movies = db.Movie.FromSql($"GetMoviesByName {name}").ToList();

            //    foreach (var movie in movies)
            //    {
            //        Console.WriteLine(movie.Name);
            //    }
            //}



            using (MovieContext db = new MovieContext())
            {
                string name = "Dark";
                //var movies = db.Database.ExecuteSqlCommand("insert into Movie(name) values ('deneme')");

               // var p0 = new SqlParameter("@Name", "Movie");



                var movies = db.Database.ExecuteSqlCommand("CreateMovie @name,@name,@name",new[] {"aa","bb","cc"});

                //foreach (var movie in movies)
                //{
                //    Console.WriteLine(movie.Name);
                //}


                Console.WriteLine(movies);
            }


            Console.ReadKey();
        }
    }
}
