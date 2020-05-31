using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Models.Relationships
{
  public  class ProductDetail
    {
        public int  Id { get; set; }

        public string Color { get; set; }


        public Product  Product { get; set; }
        public int PrId { get; set; }
    }
}
