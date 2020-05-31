using ConsoleApp4.Models.CustomEf;
using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomMovieContext db = new CustomMovieContext();

            foreach (var item in db.Movie.ToList())
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();
        }
    }
}
