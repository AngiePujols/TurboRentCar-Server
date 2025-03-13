using Microsoft.EntityFrameworkCore;
using TurboRentCar.Entities;
using TurboRentCar.EntityConfigurations;

namespace TechMaster.Context
{
    public class TurboRentContext : DbContext
    {
        public TurboRentContext(DbContextOptions<TurboRentContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EmpleadosConfigurations());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new InspeccionConfiguration());
            modelBuilder.ApplyConfiguration(new MarcasConfigurations());
            modelBuilder.ApplyConfiguration(new ModelosConfiguration());
            modelBuilder.ApplyConfiguration(new RentaDevolucionConfiguration());
            modelBuilder.ApplyConfiguration(new TipoCombustibleConfiguration());
            modelBuilder.ApplyConfiguration(new Tipos_VehiculosConfiguration());
            modelBuilder.ApplyConfiguration(new VehiculoConfiguration());
         

        }

        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Tipos_Vehiculos> Tipos_Vehiculos { get; set; }
        public DbSet<Marcas> Marcas { get; set; }
        public DbSet<Modelos> Modelos { get; set; }
        public DbSet<TipoCombustible> TipoCombustible { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Inspeccion> Inspeccion { get; set; }
        public DbSet<RentaDevolucion> RentaDevolucion { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}


