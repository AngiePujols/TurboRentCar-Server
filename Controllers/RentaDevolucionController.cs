using Microsoft.AspNetCore.Mvc;
using TechMaster.Context;
using TurboRentCar.Entities;

namespace TurboRentCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentaDevolucionController : ControllerBase
    {
        private readonly TurboRentContext context;

        public RentaDevolucionController(TurboRentContext turboRentCarContext)
        {
            this.context = turboRentCarContext;
        }

        [HttpGet]
        [Route("GetRentasDevoluciones")]
        public ActionResult Get()
        {
            var rentasDevoluciones = context.RentaDevolucion.ToList();
            return Ok(rentasDevoluciones);
        }

        [HttpPost]
        [Route("Save")]
        public ActionResult Save(RentaDevolucion rentaDevolucionData)
        {
            // Verificar si el empleado existe
            var empleadoExists = context.Empleados.Any(e => e.Id == rentaDevolucionData.EmpleadoId);
            if (!empleadoExists)
            {
                return BadRequest(new { Message = "Empleado no encontrado." });
            }

            // Verificar si el cliente existe
            var clienteExists = context.Cliente.Any(c => c.Id == rentaDevolucionData.ClienteId);
            if (!clienteExists)
            {
                return BadRequest(new { Message = "Cliente no encontrado." });
            }

            // Verificar si el vehículo existe
            var vehiculoExists = context.Vehiculo.Any(v => v.Id == rentaDevolucionData.VehiculoId);
            if (!vehiculoExists)
            {
                return BadRequest(new { Message = "Vehículo no encontrado." });
            }

            // Crear nueva renta/devolución
            var newRentaDevolucion = new RentaDevolucion
            {
                EmpleadoId = rentaDevolucionData.EmpleadoId,
                ClienteId = rentaDevolucionData.ClienteId,
                VehiculoId = rentaDevolucionData.VehiculoId,
                FechaRenta = rentaDevolucionData.FechaRenta,
                FechaDevolucion = rentaDevolucionData.FechaDevolucion,
                MontoPorDia = rentaDevolucionData.MontoPorDia,
                CantidadDias = rentaDevolucionData.CantidadDias,
                Comentario = rentaDevolucionData.Comentario,
                Estado = rentaDevolucionData.Estado
            };

            context.RentaDevolucion.Add(newRentaDevolucion);
            context.SaveChanges();

            return Ok(new { Message = "Renta/Devolución guardada" });
        }

        [HttpPut]
        [Route("Update")]
        public ActionResult Update(RentaDevolucion rentaDevolucionData)
        {
            // Buscar la renta/devolución a actualizar
            var rentaDevolucionUpdate = context.RentaDevolucion.FirstOrDefault(r => r.Id == rentaDevolucionData.Id);
            if (rentaDevolucionUpdate == null)
            {
                return NotFound(new { Message = "Renta/Devolución no encontrada" });
            }

            // Verificar si el empleado existe
            var empleadoExists = context.Empleados.Any(e => e.Id == rentaDevolucionData.EmpleadoId);
            if (!empleadoExists)
            {
                return BadRequest(new { Message = "Empleado no encontrado." });
            }

            // Verificar si el cliente existe
            var clienteExists = context.Cliente.Any(c => c.Id == rentaDevolucionData.ClienteId);
            if (!clienteExists)
            {
                return BadRequest(new { Message = "Cliente no encontrado." });
            }

            // Verificar si el vehículo existe
            var vehiculoExists = context.Vehiculo.Any(v => v.Id == rentaDevolucionData.VehiculoId);
            if (!vehiculoExists)
            {
                return BadRequest(new { Message = "Vehículo no encontrado." });
            }

            // Actualizar los datos de la renta/devolución
            rentaDevolucionUpdate.EmpleadoId = rentaDevolucionData.EmpleadoId;
            rentaDevolucionUpdate.ClienteId = rentaDevolucionData.ClienteId;
            rentaDevolucionUpdate.VehiculoId = rentaDevolucionData.VehiculoId;
            rentaDevolucionUpdate.FechaRenta = rentaDevolucionData.FechaRenta;
            rentaDevolucionUpdate.FechaDevolucion = rentaDevolucionData.FechaDevolucion;
            rentaDevolucionUpdate.MontoPorDia = rentaDevolucionData.MontoPorDia;
            rentaDevolucionUpdate.CantidadDias = rentaDevolucionData.CantidadDias;
            rentaDevolucionUpdate.Comentario = rentaDevolucionData.Comentario;
            rentaDevolucionUpdate.Estado = rentaDevolucionData.Estado;

            context.SaveChanges();

            return Ok(new { Message = "Renta/Devolución actualizada" });
        }

        [HttpDelete]
        [Route("Delete/{id_RentaDevolucion}")]
        public ActionResult Delete(int id_RentaDevolucion)
        {
            var rentaDevolucionDelete = context.RentaDevolucion.Find(id_RentaDevolucion);
            if (rentaDevolucionDelete == null)
            {
                return NotFound(new { Message = "Renta/Devolución no encontrada" });
            }

            context.RentaDevolucion.Remove(rentaDevolucionDelete);
            context.SaveChanges();

            return Ok(new { Message = "Renta/Devolución eliminada" });
        }
    }
}