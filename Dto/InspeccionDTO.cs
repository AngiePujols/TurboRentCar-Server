
namespace TurboRentCar.Dto
{
    public class InspeccionDTO
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

        public string VehiculoMarca { get; set; }
        public string VehiculoModelo { get; set; }
        public string VehiculoPlaca { get; set; }
        public string Cliente { get; set; }

        public string Empleado { get; set; }

    }
}
