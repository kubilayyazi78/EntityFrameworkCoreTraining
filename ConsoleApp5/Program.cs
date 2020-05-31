using ConsoleApp5.Models;
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DataContext db = new DataContext())
            {

                db.Products.Add(new Product
                {
                    Name = "Kubilay",
                    Price = "10"
                });

                db.Products.Add(new Product
                {
                    Name = "Miray",
                    Price = "20"
                });

                db.SaveChanges();
            }
        }
    }
}
