
namespace TurboRentCar.Dto
{
    public class RentaDevolucionDTO
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

        public string VehiculoMarca { get; set; }
        public string VehiculoModelo { get; set; }
        public string VehiculoPlaca { get; set; }

        public string VehiculoEstado { get; set; }
        public string EmpleadoNombre { get; set; }
        public decimal EmpleadoComision { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteCedula { get; set; }
        public decimal Total { get; set; }



    }
}
