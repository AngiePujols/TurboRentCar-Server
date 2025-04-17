namespace TurboRentCar.Dto
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string NoTarjetaCredito { get; set; }
        public decimal LimiteCredito { get; set; }
        public string TipoPersona { get; set; }
        public string Estado { get; set; }

    }
}
