using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace MagicVilla_API.Datos
{
    public class AplicarionDbContext : DbContext
    {
        public AplicarionDbContext(DbContextOptions<AplicarionDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura la cadena de conexión y habilita el retry en caso de fallos transitorios.
            optionsBuilder.UseSqlServer(
                "Server=192.15.200.45;Database=MagicVilla;TrustServerCertificate=true;User Id=Prueba;Password=serversql;MultipleActiveResultSets=true",
                options => options.EnableRetryOnFailure());

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Villa> Villas { get; set; } 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Villa>().HasData(
            new Villa()
            {
                Id = 1,
                Nombre = "Villa Real",
                detalle = "Detalle de la Villa",
                ImagenUrl = "",
                Ocupantes = 5,
                MetrosCuadrados = 50,
                tarifa = 200,
                Amenidad = "",
                FechaCreacion = DateTime.Now,
                FechaActualizacion = DateTime.Now,
            },

              new Villa()
              {
                  Id = 2,
                  Nombre = "Premium Vista a la piscina",
                  detalle = "Detalle de la Villa",
                  ImagenUrl = "",
                  Ocupantes = 4,
                  MetrosCuadrados = 40,
                  tarifa = 150,
                  Amenidad = "",
                  FechaCreacion = DateTime.Now,
                  FechaActualizacion = DateTime.Now,
              }
              );
    }

    }
}
