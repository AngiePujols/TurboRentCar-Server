using Microsoft.AspNetCore.Mvc;
using TechMaster.Context;
using TurboRentCar.Entities;

namespace TurboRentCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasController : ControllerBase
    {
        private readonly TurboRentContext context;

        public MarcasController(TurboRentContext turboRentCarContext)
        {
            this.context = turboRentCarContext;
        }

        [HttpGet]
        [Route("GetMarcas")]
        public ActionResult Get()
        {
            var marcas = context.Marcas.ToList();
            return Ok(marcas);
        }

        [HttpPost]
        [Route("Save")]
        public ActionResult Save(Marcas marcaData)
        {
            // Crear nueva marca
            var newMarca = new Marcas
            {
                Descripcion = marcaData.Descripcion,
                Estado = marcaData.Estado
            };

            context.Marcas.Add(newMarca);
            context.SaveChanges();

            return Ok(new { Message = "Marca guardada" });
        }

        [HttpPut]
        [Route("Update")]
        public ActionResult Update(Marcas marcaData)
        {
            // Buscar la marca a actualizar
            var marcaUpdate = context.Marcas.FirstOrDefault(m => m.Id == marcaData.Id);
            if (marcaUpdate == null)
            {
                return NotFound(new { Message = "Marca no encontrada" });
            }

            // Actualizar los datos de la marca
            marcaUpdate.Descripcion = marcaData.Descripcion;
            marcaUpdate.Estado = marcaData.Estado;

            context.SaveChanges();

            return Ok(new { Message = "Marca actualizada" });
        }

        [HttpDelete]
        [Route("Delete/{id_Marca}")]
        public ActionResult Delete(int id_Marca)
        {
            var marcaDelete = context.Marcas.Find(id_Marca);
            if (marcaDelete == null)
            {
                return NotFound(new { Message = "Marca no encontrada" });
            }

            context.Marcas.Remove(marcaDelete);
            context.SaveChanges();

            return Ok(new { Message = "Marca eliminada" });
        }
    }
}