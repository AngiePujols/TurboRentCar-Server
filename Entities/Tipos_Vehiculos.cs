using System.Text.Json.Serialization;

namespace TurboRentCar.Entities
{
    public class Tipos_Vehiculos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        [JsonIgnore]
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }
}
