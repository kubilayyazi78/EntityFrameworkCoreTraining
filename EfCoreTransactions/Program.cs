using EfCoreTransactions.Models;
using System;
using System.Linq;

namespace EfCoreTransactions
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindContext db = new NorthwindContext())
            {

                using (var transaction = db.Database.BeginTransaction())
                {



                    try
                    {
                        var products = db.Products.Take(5).ToList();

                        foreach (var product in products)
                        {
                            Console.WriteLine("updating product : {0}", product.ProductId);

                            product.UnitsInStock += 100;

                            if (product == products[4])
                            {
                                product.UnitsInStock += 32750;
                            }
                        }

                        db.SaveChanges();

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        Console.WriteLine("error");
                    }



                }
            }
        }
    }
}
