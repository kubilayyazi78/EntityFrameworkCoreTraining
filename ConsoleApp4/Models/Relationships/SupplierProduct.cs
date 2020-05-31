using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Models.Relationships
{
  public  class SupplierProduct
    {
        //public  int Id { get; set; }
        //composite keys 2 tane primary key 
        public int SId { get; set; }
        public Supplier Supplier { get; set; }

        public int PId { get; set; }
        public Product Product { get; set; }
    }
}
