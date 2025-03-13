namespace TurboRentCar.Entities
{
    public class Modelos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
     

    }
}
