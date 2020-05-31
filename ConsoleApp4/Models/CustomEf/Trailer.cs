using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Models.CustomEf
{
  public  class Trailer
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        public int MovieId { get; set; }

        public Movie Movie { get; set; }
    }
}
