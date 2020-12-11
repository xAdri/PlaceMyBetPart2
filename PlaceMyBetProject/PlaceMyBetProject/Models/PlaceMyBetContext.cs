using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace PlaceMyBetProject.Models
{
    public class PlaceMyBetContext : DbContext
    {
        public DbSet<Evento> Evento { get; set; }   //Tabla
        public DbSet<Mercado> Mercado { get; set; } //Tabla
        public DbSet<Apuesta> Apuesta { get; set; } //Tabla
        public DbSet<Usuario> Usuario { get; set; } //Tabla
        public DbSet<Cuenta> Cuenta { get; set; }   //Tabla


        public PlaceMyBetContext()
        {
        }

        public PlaceMyBetContext(DbContextOptions options)
        : base(options)
        {
        }

        //Metodo de configuracion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=placemybet2;Uid=root;Pwd=''; SslMode = none");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Evento>().HasData(new Evento(1, "Valencia", "Levante", DateTime.Now));
            modelBuilder.Entity<Mercado>().HasData(new Mercado(1000, 1.5, 1.9, 1.9, 50, 50, 1));
            modelBuilder.Entity<Usuario>().HasData(new Usuario("adriperez@gmail.com", "Adri", "Perez", 24));
            modelBuilder.Entity<Apuesta>().HasData(new Apuesta(12, 1.5, "over", 1.9, 20, DateTime.Now, 1, "adriperez@gmail.com", 1000));
            modelBuilder.Entity<Cuenta>().HasData(new Cuenta(250.25, "Bankia", "123456789", "adriperez@gmail.com"));*/
        }
    }
}