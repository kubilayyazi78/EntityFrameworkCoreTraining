using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp4.Models.DataAnnotations
{
    [Table("Movie")]
    public class Product
    {
        [Key]
        [Column("Id")]
        public int UrunId { get; set; }


        [Column("Name")]
        //[MaxLength(50)]
       // [Required]
        public string UrunAdi { get; set; }
    }
}
