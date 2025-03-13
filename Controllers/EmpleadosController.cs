using Microsoft.AspNetCore.Mvc;
using TechMaster.Context;
using TurboRentCar.Entities;

namespace TurboRentCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly TurboRentContext context;

        public EmpleadosController(TurboRentContext turboRentCarContext)
        {
            this.context = turboRentCarContext;
        }

        [HttpGet]
        [Route("GetEmpleados")]
        public ActionResult Get()
        {
            var empleados = context.Empleados.ToList();
            return Ok(empleados);
        }

        [HttpPost]
        [Route("Save")]
        public ActionResult Save(Empleados empleadoData)
        {
            // Crear nuevo empleado
            var newEmpleado = new Empleados
            {
                nombre = empleadoData.nombre,
                direccion = empleadoData.direccion,
                telefono = empleadoData.telefono,
                email = empleadoData.email,
                cedula = empleadoData.cedula,
                tanda_labor = empleadoData.tanda_labor,
                fecha_nacimiento = empleadoData.fecha_nacimiento,
                fecha_contratacion = empleadoData.fecha_contratacion,
                porcentaje_comision = empleadoData.porcentaje_comision,
                estado = empleadoData.estado,
                foto = empleadoData.foto
            };

            context.Empleados.Add(newEmpleado);
            context.SaveChanges();

            return Ok(new { Message = "Empleado guardado" });
        }

        [HttpPut]
        [Route("Update")]
        public ActionResult Update(Empleados empleadoData)
        {
            // Buscar el empleado a actualizar
            var empleadoUpdate = context.Empleados.FirstOrDefault(e => e.Id == empleadoData.Id);
            if (empleadoUpdate == null)
            {
                return NotFound(new { Message = "Empleado no encontrado" });
            }

            // Actualizar los datos del empleado
            empleadoUpdate.nombre = empleadoData.nombre;
            empleadoUpdate.direccion = empleadoData.direccion;
            empleadoUpdate.telefono = empleadoData.telefono;
            empleadoUpdate.email = empleadoData.email;
            empleadoUpdate.cedula = empleadoData.cedula;
            empleadoUpdate.tanda_labor = empleadoData.tanda_labor;
            empleadoUpdate.fecha_nacimiento = empleadoData.fecha_nacimiento;
            empleadoUpdate.fecha_contratacion = empleadoData.fecha_contratacion;
            empleadoUpdate.porcentaje_comision = empleadoData.porcentaje_comision;
            empleadoUpdate.estado = empleadoData.estado;
            empleadoUpdate.foto = empleadoData.foto;

            context.SaveChanges();

            return Ok(new { Message = "Empleado actualizado" });
        }

        [HttpDelete]
        [Route("Delete/{id_Empleado}")]
        public ActionResult Delete(int id_Empleado)
        {
            var empleadoDelete = context.Empleados.Find(id_Empleado);
            if (empleadoDelete == null)
            {
                return NotFound(new { Message = "Empleado no encontrado" });
            }

            context.Empleados.Remove(empleadoDelete);
            context.SaveChanges();

            return Ok(new { Message = "Empleado eliminado" });
        }
    }
}