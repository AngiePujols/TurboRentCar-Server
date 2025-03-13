using Microsoft.AspNetCore.Mvc;
using TechMaster.Context;
using TurboRentCar.Entities;

namespace TurboRentCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoCombustibleController : ControllerBase
    {
        private readonly TurboRentContext context;

        public TipoCombustibleController(TurboRentContext turboRentCarContext)
        {
            this.context = turboRentCarContext;
        }

        [HttpGet]
        [Route("GetTiposCombustible")]
        public ActionResult Get()
        {
            var tiposCombustible = context.TipoCombustible.ToList();
            return Ok(tiposCombustible);
        }

        [HttpPost]
        [Route("Save")]
        public ActionResult Save(TipoCombustible tipoCombustibleData)
        {
            // Crear nuevo tipo de combustible
            var newTipoCombustible = new TipoCombustible
            {
                Descripcion = tipoCombustibleData.Descripcion,
                Estado = tipoCombustibleData.Estado
            };

            context.TipoCombustible.Add(newTipoCombustible);
            context.SaveChanges();

            return Ok(new { Message = "Tipo de combustible guardado" });
        }

        [HttpPut]
        [Route("Update")]
        public ActionResult Update(TipoCombustible tipoCombustibleData)
        {
            // Buscar el tipo de combustible a actualizar
            var tipoCombustibleUpdate = context.TipoCombustible.FirstOrDefault(t => t.Id == tipoCombustibleData.Id);
            if (tipoCombustibleUpdate == null)
            {
                return NotFound(new { Message = "Tipo de combustible no encontrado" });
            }

            // Actualizar los datos del tipo de combustible
            tipoCombustibleUpdate.Descripcion = tipoCombustibleData.Descripcion;
            tipoCombustibleUpdate.Estado = tipoCombustibleData.Estado;

            context.SaveChanges();

            return Ok(new { Message = "Tipo de combustible actualizado" });
        }

        [HttpDelete]
        [Route("Delete/{id_TipoCombustible}")]
        public ActionResult Delete(int id_TipoCombustible)
        {
            var tipoCombustibleDelete = context.TipoCombustible.Find(id_TipoCombustible);
            if (tipoCombustibleDelete == null)
            {
                return NotFound(new { Message = "Tipo de combustible no encontrado" });
            }

            context.TipoCombustible.Remove(tipoCombustibleDelete);
            context.SaveChanges();

            return Ok(new { Message = "Tipo de combustible eliminado" });
        }
    }
}