using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TurboRentCar.Entities;

namespace TurboRentCar.EntityConfigurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Cedula)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(c => c.NoTarjetaCredito)
                .HasMaxLength(20);

            builder.HasData(
                new Cliente { Id = 1, Nombre = "Juan", Apellido = "Pérez", Cedula = "001-1234567-8", NoTarjetaCredito = "1234-5678-1234-5678", LimiteCredito = 50000.00m, TipoPersona = "Física", Estado = "Activo" },
                new Cliente { Id = 2, Nombre = "María", Apellido = "Martínez", Cedula = "002-2345678-9", NoTarjetaCredito = "2345-6789-2345-6789", LimiteCredito = 75000.00m, TipoPersona = "Física", Estado = "Activo" },
                new Cliente { Id = 3, Nombre = "Pedro", Apellido = "González", Cedula = "003-3456789-0", NoTarjetaCredito = "3456-7890-3456-7890", LimiteCredito = 60000.00m, TipoPersona = "Física", Estado = "Activo" },
                new Cliente { Id = 4, Nombre = "Ana", Apellido = "Jiménez", Cedula = "004-4567890-1", NoTarjetaCredito = "4567-8901-4567-8901", LimiteCredito = 100000.00m, TipoPersona = "Física", Estado = "Activo" },
                new Cliente { Id = 5, Nombre = "José", Apellido = "Rodríguez", Cedula = "005-5678901-2", NoTarjetaCredito = "5678-9012-5678-9012", LimiteCredito = 80000.00m, TipoPersona = "Física", Estado = "Activo" }
            );  
                
        }
    }
}

