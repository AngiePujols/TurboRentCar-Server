using Microsoft.AspNetCore.Mvc;
using TechMaster.Context;
using TurboRentCar.Entities;

namespace TurboRentCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly TurboRentContext context;

        public VehiculoController(TurboRentContext turboRentCarContext)
        {
            this.context = turboRentCarContext;
        }

        [HttpGet]
        [Route("GetVehiculos")]
        public ActionResult Get()
        {
            var vehiculos = context.Vehiculo.ToList();
            return Ok(vehiculos);
        }

        [HttpPost]
        [Route("Save")]
        public ActionResult Save(Vehiculo vehiculoData)
        {
            // Verificar si el tipo de vehículo existe
            var tipoVehiculoExists = context.Tipos_Vehiculos.Any(tv => tv.Id == vehiculoData.TipoVehiculoId);
            if (!tipoVehiculoExists)
            {
                return BadRequest(new { Message = "Tipo de vehículo no encontrado." });
            }

            // Verificar si la marca existe
            var marcaExists = context.Marcas.Any(m => m.Id == vehiculoData.MarcaId);
            if (!marcaExists)
            {
                return BadRequest(new { Message = "Marca no encontrada." });
            }

            // Verificar si el modelo existe
            var modeloExists = context.Modelos.Any(m => m.Id == vehiculoData.ModeloId);
            if (!modeloExists)
            {
                return BadRequest(new { Message = "Modelo no encontrado." });
            }

            // Verificar si el tipo de combustible existe
            var tipoCombustibleExists = context.TipoCombustible.Any(tc => tc.Id == vehiculoData.TipoCombustibleId);
            if (!tipoCombustibleExists)
            {
                return BadRequest(new { Message = "Tipo de combustible no encontrado." });
            }

            // Crear nuevo vehículo
            var newVehiculo = new Vehiculo
            {
                TipoVehiculoId = vehiculoData.TipoVehiculoId,
                MarcaId = vehiculoData.MarcaId,
                ModeloId = vehiculoData.ModeloId,
                TipoCombustibleId = vehiculoData.TipoCombustibleId,
                Placa = vehiculoData.Placa,
                Estado = vehiculoData.Estado
            };

            context.Vehiculo.Add(newVehiculo);
            context.SaveChanges();

            return Ok(new { Message = "Vehículo guardado" });
        }

        [HttpPut]
        [Route("Update")]
        public ActionResult Update(Vehiculo vehiculoData)
        {
            // Buscar el vehículo a actualizar
            var vehiculoUpdate = context.Vehiculo.FirstOrDefault(v => v.Id == vehiculoData.Id);
            if (vehiculoUpdate == null)
            {
                return NotFound(new { Message = "Vehículo no encontrado" });
            }

            // Verificar si el tipo de vehículo existe
            var tipoVehiculoExists = context.Tipos_Vehiculos.Any(tv => tv.Id == vehiculoData.TipoVehiculoId);
            if (!tipoVehiculoExists)
            {
                return BadRequest(new { Message = "Tipo de vehículo no encontrado." });
            }

            // Verificar si la marca existe
            var marcaExists = context.Marcas.Any(m => m.Id == vehiculoData.MarcaId);
            if (!marcaExists)
            {
                return BadRequest(new { Message = "Marca no encontrada." });
            }

            // Verificar si el modelo existe
            var modeloExists = context.Modelos.Any(m => m.Id == vehiculoData.ModeloId);
            if (!modeloExists)
            {
                return BadRequest(new { Message = "Modelo no encontrado." });
            }

            // Verificar si el tipo de combustible existe
            var tipoCombustibleExists = context.TipoCombustible.Any(tc => tc.Id == vehiculoData.TipoCombustibleId);
            if (!tipoCombustibleExists)
            {
                return BadRequest(new { Message = "Tipo de combustible no encontrado." });
            }

            // Actualizar los datos del vehículo
            vehiculoUpdate.TipoVehiculoId = vehiculoData.TipoVehiculoId;
            vehiculoUpdate.MarcaId = vehiculoData.MarcaId;
            vehiculoUpdate.ModeloId = vehiculoData.ModeloId;
            vehiculoUpdate.TipoCombustibleId = vehiculoData.TipoCombustibleId;
            vehiculoUpdate.Placa = vehiculoData.Placa;
            vehiculoUpdate.Estado = vehiculoData.Estado;

            context.SaveChanges();

            return Ok(new { Message = "Vehículo actualizado" });
        }

        [HttpDelete]
        [Route("Delete/{id_Vehiculo}")]
        public ActionResult Delete(int id_Vehiculo)
        {
            var vehiculoDelete = context.Vehiculo.Find(id_Vehiculo);
            if (vehiculoDelete == null)
            {
                return NotFound(new { Message = "Vehículo no encontrado" });
            }

            context.Vehiculo.Remove(vehiculoDelete);
            context.SaveChanges();

            return Ok(new { Message = "Vehículo eliminado" });
        }
    }
}