namespace ProyectAplication.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ProyectAplication.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ProyectAplication.Models.AstronomyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProyectAplication.Models.AstronomyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Constellations.AddOrUpdate(z => z.IdConstellation,
                new Constellation { IdConstellation = 1, Name_C = "Osa Mayor", Hemisphere = "Norte", Period = "Siempre", Name_S = "Alioth" },
                new Constellation { IdConstellation = 2, Name_C = "Osa Menor", Hemisphere = "Norte", Period = "Siempre", Name_S = "Estrella Polar" });
            context.Stars.AddOrUpdate(z => z.IdCStar,
                new Star { IdCStar = 1, Name_S = "Sirio", Tipo = "Blanca", IdConstellation = 3 },
                new Star { IdCStar = 2, Name_S = "Estrella Polar", Tipo = "Cefeida clásica", IdConstellation = 2 });
        }
    }
}
