using Microsoft.AspNetCore.Mvc;
using TechMaster.Context;
using TurboRentCar.Entities;

namespace TurboRentCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelosController : ControllerBase
    {
        private readonly TurboRentContext context;

        public ModelosController(TurboRentContext turboRentCarContext)
        {
            this.context = turboRentCarContext;
        }

        [HttpGet]
        [Route("GetModelos")]
        public ActionResult Get()
        {
            var modelos = context.Modelos.ToList();
            return Ok(modelos);
        }

        [HttpPost]
        [Route("Save")]
        public ActionResult Save(Modelos modeloData)
        {
          
            // Crear nuevo modelo
            var newModelo = new Modelos
            {
                Descripcion = modeloData.Descripcion,
                Estado = modeloData.Estado
            };

            context.Modelos.Add(newModelo);
            context.SaveChanges();

            return Ok(new { Message = "Modelo guardado" });
        }

        [HttpPut]
        [Route("Update")]
        public ActionResult Update(Modelos modeloData)
        {
            // Buscar el modelo a actualizar
            var modeloUpdate = context.Modelos.FirstOrDefault(m => m.Id == modeloData.Id);
            if (modeloUpdate == null)
            {
                return NotFound(new { Message = "Modelo no encontrado" });
            }

            // Verificar si la marca existe

            // Actualizar los datos del modelo
            modeloUpdate.Descripcion = modeloData.Descripcion;
            modeloUpdate.Estado = modeloData.Estado;

            context.SaveChanges();

            return Ok(new { Message = "Modelo actualizado" });
        }

        [HttpDelete]
        [Route("Delete/{id_Modelo}")]
        public ActionResult Delete(int id_Modelo)
        {
            var modeloDelete = context.Modelos.Find(id_Modelo);
            if (modeloDelete == null)
            {
                return NotFound(new { Message = "Modelo no encontrado" });
            }

            context.Modelos.Remove(modeloDelete);
            context.SaveChanges();

            return Ok(new { Message = "Modelo eliminado" });
        }
    }
}