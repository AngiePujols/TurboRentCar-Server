using System.ComponentModel.DataAnnotations.Schema;

namespace TurboRentCar.Entities
{
    public class Inspeccion
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public int ClienteId { get; set; }
        public bool TieneRalladuras { get; set; }
        public string CantidadCombustible { get; set; }
        public bool TieneGomaRespuesta { get; set; }
        public bool TieneGato { get; set; }
        public bool TieneRoturasCristal { get; set; }
        public string EstadoGomas { get; set; }
        public DateTime Fecha { get; set; }
        public int EmpleadoId { get; set; }
        public string Estado { get; set; }

        public virtual Vehiculo Vehiculo { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Empleados Empleados { get; set; }

    }
}
