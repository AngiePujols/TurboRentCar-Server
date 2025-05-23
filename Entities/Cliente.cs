﻿using System.Text.Json.Serialization;

namespace TurboRentCar.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string NoTarjetaCredito { get; set; }
        public decimal LimiteCredito { get; set; }
        public string TipoPersona { get; set; }
        public string Estado { get; set; }

        [JsonIgnore]
        public virtual ICollection<Inspeccion> Inspeccion { get; set; }
        [JsonIgnore]
        public virtual ICollection<RentaDevolucion> RentaDevolucion { get; set; }
    }
}
