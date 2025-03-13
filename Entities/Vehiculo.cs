using System.ComponentModel.DataAnnotations.Schema;

namespace TurboRentCar.Entities
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public int TipoVehiculoId { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public int TipoCombustibleId { get; set; }
        public string Placa { get; set; }
        public string Estado { get; set; } 

        public virtual Tipos_Vehiculos TipoVehiculo { get; set; }
        public virtual Modelos Modelos { get; set; }
        public virtual TipoCombustible TipoCombustible { get; set; }

        public  virtual ICollection<Inspeccion> Inspeccion { get; set; }
        public virtual ICollection<RentaDevolucion> RentaDevolucion { get; set; }
    }
}
