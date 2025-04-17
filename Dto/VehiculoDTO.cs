
namespace TurboRentCar.Dto
{
    public class VehiculoDTO
    {
        public int Id { get; set; }
        public int TipoVehiculoId { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public int TipoCombustibleId { get; set; }
        public string Placa { get; set; }
        public string Estado { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string TipoCombustible { get; set; }
        public string TipoVehiculo { get; set; }
    }
}