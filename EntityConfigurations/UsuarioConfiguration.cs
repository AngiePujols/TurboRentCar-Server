using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TurboRentCar.Entities;

namespace TurboRentCar.EntityConfigurations
{
    public class UsuarioConfiguration: IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(usuario => usuario.Id);

            builder.HasData(new List<Usuario>()
            {
                new Usuario
                {
                    Id = 1,
                    Nombre = "Juan",
                    Apellido = "Perez",
                    rol = "admin",
                    Username = "jperez",
                    Password = "password123",
                    Email = "juan.perez@example.com",
                    FechaRegistro = new DateTime(2024, 1, 1),
                    Activo = true
                },
                new Usuario
                {
                    Id = 2,
                    Nombre = "Maria",
                    Apellido = "Garcia",
                    rol = "vendedor",
                    Username = "mgarcia",
                    Password = "password456",
                    Email = "maria.garcia@example.com",
                    FechaRegistro = new DateTime(2024, 1, 5),
                    Activo = true
                },
                new Usuario
                {
                    Id = 3,
                    Nombre = "Luis",
                    Apellido = "Rodriguez",
                    rol = "vendedor",
                    Username = "lrodriguez",
                    Password = "password789",
                    Email = "luis.rodriguez@example.com",
                    FechaRegistro = new DateTime(2024, 1, 10),
                    Activo = true
                }
            });

        }
    }
}
