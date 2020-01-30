using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ProyectAplication.Models
{
    public class AstronomyContext : DbContext
    {
        //DEFINITION OF THE CONEXION CHAIN
        public AstronomyContext() : base("AstronomyChain") { }
        //CONSTELLATION CLASS
        public DbSet<Constellation> Constellations { get; set; }
        // STAR CLASS
        public DbSet<Star> Stars { get; set; }
        //ONLY SINGULAR TABLE
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}