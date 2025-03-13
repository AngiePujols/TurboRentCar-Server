using Microsoft.AspNetCore.Mvc;
using TechMaster.Context;
using TurboRentCar.Entities;

namespace TurboRentCar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly TurboRentContext context;

        public ClientesController(TurboRentContext turboRentCarContext)
        {
            this.context = turboRentCarContext;
        }

        [HttpGet]
        [Route("GetClientes")]
        public ActionResult Get()
        {
            var clientes = context.Cliente.ToList();
            return Ok(clientes);
        }

        [HttpPost]
        [Route("Save")]
        public ActionResult Save(Cliente clienteData)
        {
            // Crear nuevo cliente
            var newCliente = new Cliente
            {
                Nombre = clienteData.Nombre,
                Apellido = clienteData.Apellido,
                Cedula = clienteData.Cedula,
                NoTarjetaCredito = clienteData.NoTarjetaCredito,
                LimiteCredito = clienteData.LimiteCredito,
                TipoPersona = clienteData.TipoPersona,
                Estado = clienteData.Estado
            };

            context.Cliente.Add(newCliente);
            context.SaveChanges();

            return Ok(new { Message = "Cliente guardado" });
        }

        //get cliente by id
        [HttpGet]
        [Route("GetCliente/{id_Cliente}")]
        public ActionResult GetCliente(int id_Cliente)
        {
            var cliente = context.Cliente.Find(id_Cliente);
            if (cliente == null)
            {
                return NotFound(new { Message = "Cliente no encontrado" });
            }

            return Ok(cliente);
        }   

        [HttpPut]
        [Route("Update")]
        public ActionResult Update(Cliente clienteData)
        {
            // Buscar el cliente a actualizar
            var clienteUpdate = context.Cliente.FirstOrDefault(c => c.Id == clienteData.Id);
            if (clienteUpdate == null)
            {
                return NotFound(new { Message = "Cliente no encontrado" });
            }

            // Actualizar los datos del cliente
            clienteUpdate.Nombre = clienteData.Nombre;
            clienteUpdate.Apellido = clienteData.Apellido;
            clienteUpdate.Cedula = clienteData.Cedula;
            clienteUpdate.NoTarjetaCredito = clienteData.NoTarjetaCredito;
            clienteUpdate.LimiteCredito = clienteData.LimiteCredito;
            clienteUpdate.TipoPersona = clienteData.TipoPersona;
            clienteUpdate.Estado = clienteData.Estado;

            context.SaveChanges();

            return Ok(new { Message = "Cliente actualizado" });
        }

        [HttpDelete]
        [Route("Delete/{id_Cliente}")]
        public ActionResult Delete(int id_Cliente)
        {
            var clienteDelete = context.Cliente.Find(id_Cliente);
            if (clienteDelete == null)
            {
                return NotFound(new { Message = "Cliente no encontrado" });
            }

            // Eliminar todas las inspecciones relacionadas
            var inspeccionesRelacionadas = context.Inspeccion
                .Where(i => i.ClienteId == id_Cliente)
                .ToList();

            context.Inspeccion.RemoveRange(inspeccionesRelacionadas); // Elimina las inspecciones
            context.Cliente.Remove(clienteDelete); // Elimina el cliente
            context.SaveChanges();

            return Ok(new { Message = "Cliente eliminado" });
        }
        }
    }