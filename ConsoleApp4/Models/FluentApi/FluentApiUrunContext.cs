using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Models.FluentApi
{



    public class FluentApiUrunContext : DbContext
    {

        public FluentApiUrunContext()
        {

        }
        public FluentApiUrunContext(DbContextOptions<FluentApiUrunContext> options) : base(options)
        {

        }
        public DbSet<Urun> Urunler { get; set; }
        //   public DbSet<Trailer> Trailer { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MsSqllocalDb;Database=MovieDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Urun>().ToTable("Movie");
            modelBuilder.Entity<Urun>().HasKey(i => i.UrunId);
            modelBuilder.Entity<Urun>().Property(i => i.UrunId).HasColumnName("Id");
            modelBuilder.Entity<Urun>().Property(i => i.UrunAdi).HasColumnName("Name");




        }



    }


}
