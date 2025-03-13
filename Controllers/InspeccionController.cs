using Microsoft.AspNetCore.Mvc;
using TechMaster.Context;
using TurboRentCar.Entities;

namespace TurboRentCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspeccionController : ControllerBase
    {
        private readonly TurboRentContext context;

        public InspeccionController(TurboRentContext turboRentCarContext)
        {
            this.context = turboRentCarContext;
        }

        [HttpGet]
        [Route("GetInspecciones")]
        public ActionResult Get()
        {
            var inspecciones = context.Inspeccion.ToList();
            return Ok(inspecciones);
        }

        [HttpPost]
        [Route("Save")]
        public ActionResult Save(Inspeccion inspeccionData)
        {
            // Verificar si el vehículo existe
            var vehiculoExists = context.Vehiculo.Any(v => v.Id == inspeccionData.VehiculoId);
            if (!vehiculoExists)
            {
                return BadRequest(new { Message = "Vehículo no encontrado." });
            }

            // Verificar si el cliente existe
            var clienteExists = context.Cliente.Any(c => c.Id == inspeccionData.ClienteId);
            if (!clienteExists)
            {
                return BadRequest(new { Message = "Cliente no encontrado." });
            }

            // Verificar si el empleado existe
            var empleadoExists = context.Empleados.Any(e => e.Id == inspeccionData.EmpleadoId);
            if (!empleadoExists)
            {
                return BadRequest(new { Message = "Empleado no encontrado." });
            }

            // Crear nueva inspección
            var newInspeccion = new Inspeccion
            {
                VehiculoId = inspeccionData.VehiculoId,
                ClienteId = inspeccionData.ClienteId,
                TieneRalladuras = inspeccionData.TieneRalladuras,
                CantidadCombustible = inspeccionData.CantidadCombustible,
                TieneGomaRespuesta = inspeccionData.TieneGomaRespuesta,
                TieneGato = inspeccionData.TieneGato,
                TieneRoturasCristal = inspeccionData.TieneRoturasCristal,
                EstadoGomas = inspeccionData.EstadoGomas,
                Fecha = inspeccionData.Fecha,
                EmpleadoId = inspeccionData.EmpleadoId,
                Estado = inspeccionData.Estado
            };

            context.Inspeccion.Add(newInspeccion);
            context.SaveChanges();

            return Ok(new { Message = "Inspección guardada" });
        }

        [HttpPut]
        [Route("Update")]
        public ActionResult Update(Inspeccion inspeccionData)
        {
            // Buscar la inspección a actualizar
            var inspeccionUpdate = context.Inspeccion.FirstOrDefault(i => i.Id == inspeccionData.Id);
            if (inspeccionUpdate == null)
            {
                return NotFound(new { Message = "Inspección no encontrada" });
            }

            // Verificar si el vehículo existe
            var vehiculoExists = context.Vehiculo.Any(v => v.Id == inspeccionData.VehiculoId);
            if (!vehiculoExists)
            {
                return BadRequest(new { Message = "Vehículo no encontrado." });
            }

            // Verificar si el cliente existe
            var clienteExists = context.Cliente.Any(c => c.Id == inspeccionData.ClienteId);
            if (!clienteExists)
            {
                return BadRequest(new { Message = "Cliente no encontrado." });
            }

            // Verificar si el empleado existe
            var empleadoExists = context.Empleados.Any(e => e.Id == inspeccionData.EmpleadoId);
            if (!empleadoExists)
            {
                return BadRequest(new { Message = "Empleado no encontrado." });
            }

            // Actualizar los datos de la inspección
            inspeccionUpdate.VehiculoId = inspeccionData.VehiculoId;
            inspeccionUpdate.ClienteId = inspeccionData.ClienteId;
            inspeccionUpdate.TieneRalladuras = inspeccionData.TieneRalladuras;
            inspeccionUpdate.CantidadCombustible = inspeccionData.CantidadCombustible;
            inspeccionUpdate.TieneGomaRespuesta = inspeccionData.TieneGomaRespuesta;
            inspeccionUpdate.TieneGato = inspeccionData.TieneGato;
            inspeccionUpdate.TieneRoturasCristal = inspeccionData.TieneRoturasCristal;
            inspeccionUpdate.EstadoGomas = inspeccionData.EstadoGomas;
            inspeccionUpdate.Fecha = inspeccionData.Fecha;
            inspeccionUpdate.EmpleadoId = inspeccionData.EmpleadoId;
            inspeccionUpdate.Estado = inspeccionData.Estado;

            context.SaveChanges();

            return Ok(new { Message = "Inspección actualizada" });
        }

        [HttpDelete]
        [Route("Delete/{id_Inspeccion}")]
        public ActionResult Delete(int id_Inspeccion)
        {
            var inspeccionDelete = context.Inspeccion.Find(id_Inspeccion);
            if (inspeccionDelete == null)
            {
                return NotFound(new { Message = "Inspección no encontrada" });
            }

            context.Inspeccion.Remove(inspeccionDelete);
            context.SaveChanges();

            return Ok(new { Message = "Inspección eliminada" });
        }
    }
}