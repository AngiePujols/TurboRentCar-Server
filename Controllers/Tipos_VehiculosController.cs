using Microsoft.AspNetCore.Mvc;
using TechMaster.Context;
using TurboRentCar.Entities;

namespace TurboRentCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposVehiculosController : ControllerBase
    {
        private readonly TurboRentContext context;

        public TiposVehiculosController(TurboRentContext turboRentCarContext)
        {
            this.context = turboRentCarContext;
        }

        [HttpGet]
        [Route("GetTiposVehiculos")]
        public ActionResult Get()
        {
            var tiposVehiculos = context.Tipos_Vehiculos.ToList();
            return Ok(tiposVehiculos);
        }

        [HttpPost]
        [Route("Save")]
        public ActionResult Save(Tipos_Vehiculos tipoVehiculoData)
        {
            // Crear nuevo tipo de vehículo
            var newTipoVehiculo = new Tipos_Vehiculos
            {
                Descripcion = tipoVehiculoData.Descripcion,
                Estado = tipoVehiculoData.Estado
            };

            context.Tipos_Vehiculos.Add(newTipoVehiculo);
            context.SaveChanges();

            return Ok(new { Message = "Tipo de vehículo guardado" });
        }

        [HttpPut]
        [Route("Update")]
        public ActionResult Update(Tipos_Vehiculos tipoVehiculoData)
        {
            // Buscar el tipo de vehículo a actualizar
            var tipoVehiculoUpdate = context.Tipos_Vehiculos.FirstOrDefault(t => t.Id == tipoVehiculoData.Id);
            if (tipoVehiculoUpdate == null)
            {
                return NotFound(new { Message = "Tipo de vehículo no encontrado" });
            }

            // Actualizar los datos del tipo de vehículo
            tipoVehiculoUpdate.Descripcion = tipoVehiculoData.Descripcion;
            tipoVehiculoUpdate.Estado = tipoVehiculoData.Estado;

            context.SaveChanges();

            return Ok(new { Message = "Tipo de vehículo actualizado" });
        }

        [HttpDelete]
        [Route("Delete/{id_TipoVehiculo}")]
        public ActionResult Delete(int id_TipoVehiculo)
        {
            var tipoVehiculoDelete = context.Tipos_Vehiculos.Find(id_TipoVehiculo);
            if (tipoVehiculoDelete == null)
            {
                return NotFound(new { Message = "Tipo de vehículo no encontrado" });
            }

            context.Tipos_Vehiculos.Remove(tipoVehiculoDelete);
            context.SaveChanges();

            return Ok(new { Message = "Tipo de vehículo eliminado" });
        }
    }
}