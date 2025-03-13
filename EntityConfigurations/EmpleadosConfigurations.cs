using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TurboRentCar.Entities;

namespace TurboRentCar.EntityConfigurations
{
    public class EmpleadosConfigurations : IEntityTypeConfiguration<Empleados>
    {
        public void Configure(EntityTypeBuilder<Empleados> builder)
        {
            builder.ToTable("Empleados");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.nombre)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.direccion)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.telefono)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(e => e.email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.cedula)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(e => e.tanda_labor)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(e => e.fecha_nacimiento)
                .HasColumnType("date");

            builder.Property(e => e.fecha_contratacion)
                .HasColumnType("date");

            builder.Property(e => e.porcentaje_comision)
                .HasColumnType("decimal(5,2)");

            builder.Property(e => e.foto)
                .HasMaxLength(255);

            builder.HasData(
                new Empleados { Id = 1, nombre = "Juan Pérez", direccion = "Calle 123", telefono = "809-555-1234", email = "juan.perez@email.com", cedula = "001-1234567-8", tanda_labor = "Matutina", fecha_nacimiento = new DateTime(1985, 5, 10), fecha_contratacion = new DateTime(2020, 5, 10), porcentaje_comision = 5.00m, estado = "Activo", foto = "juan.jpg" },
                new Empleados { Id = 2, nombre = "María Martínez", direccion = "Avenida Central 45", telefono = "809-555-5678", email = "maria.martinez@email.com", cedula = "002-2345678-9", tanda_labor = "Vespertina", fecha_nacimiento = new DateTime(1990, 8, 15), fecha_contratacion = new DateTime(2019, 8, 15), porcentaje_comision = 7.50m, estado = "Activo", foto = "maria.jpg" },
                new Empleados { Id = 3, nombre = "Pedro González", direccion = "Calle Norte 78", telefono = "809-555-9101", email = "pedro.gonzalez@email.com", cedula = "003-3456789-0", tanda_labor = "Nocturna", fecha_nacimiento = new DateTime(1987, 3, 20), fecha_contratacion = new DateTime(2021, 3, 20), porcentaje_comision = 6.00m, estado = "Activo", foto = "pedro.jpg" }
            );
        }
    }
}

