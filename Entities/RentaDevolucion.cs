using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TurboRentCar.Entities
{
    public class RentaDevolucion
    {
        public int Id { get; set; }
        public int EmpleadoId { get; set; }
        public int ClienteId { get; set; }
        public int VehiculoId { get; set; }
        public DateTime FechaRenta { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public decimal MontoPorDia { get; set; }
        public int CantidadDias { get; set; }
        public string Comentario { get; set; }
        public string Estado { get; set; } 

        public virtual Empleados Empleado { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
