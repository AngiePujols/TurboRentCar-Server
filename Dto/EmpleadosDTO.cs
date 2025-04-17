namespace TurboRentCar.Dto
{
    public class EmpleadosDTO
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string cedula { get; set; }
        public string tanda_labor { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public DateTime fecha_contratacion { get; set; }
        public decimal porcentaje_comision { get; set; }
        public string estado { get; set; }
        public string foto { get; set; }
    }
}
