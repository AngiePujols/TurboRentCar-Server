using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TurboRentCar.Entities;

namespace TurboRentCar.EntityConfigurations
{
    public class VehiculoConfiguration : IEntityTypeConfiguration<Vehiculo>
    {
        public void Configure(EntityTypeBuilder<Vehiculo> builder)
        {
            builder.ToTable("Vehiculo");
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Placa)
                .IsRequired()
                .HasMaxLength(10);
            builder.Property(v => v.Estado)
                .IsRequired()
                .HasMaxLength(15);

            // Datos de prueba para Vehiculo
            builder.HasData(
                new Vehiculo { Id = 1, TipoVehiculoId = 1, MarcaId = 1, ModeloId = 1, TipoCombustibleId = 1, Placa = "A123456", Estado = "Disponible" },
                new Vehiculo { Id = 2, TipoVehiculoId = 2, MarcaId = 2, ModeloId = 2, TipoCombustibleId = 2, Placa = "B234567", Estado = "Disponible" },
                new Vehiculo { Id = 3, TipoVehiculoId = 3, MarcaId = 3, ModeloId = 3, TipoCombustibleId = 3, Placa = "C345678", Estado = "Disponible" },
                new Vehiculo { Id = 4, TipoVehiculoId = 4, MarcaId = 4, ModeloId = 4, TipoCombustibleId = 4, Placa = "D456789", Estado = "Disponible" }
            );

          

            // Relación con Modelo
            builder.HasOne(v => v.Modelos)
                .WithMany(m => m.Vehiculo)
                .HasForeignKey(v => v.ModeloId)
                .HasConstraintName("FK_Vehiculo_Modelos");

            // Relación con TipoCombustible
            builder.HasOne(v => v.TipoCombustible)
                .WithMany(tc => tc.Vehiculo)
                .HasForeignKey(v => v.TipoCombustibleId)
                .HasConstraintName("FK_Vehiculo_TipoCombustible");
        }
    }
}