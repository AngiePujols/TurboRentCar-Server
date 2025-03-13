using Microsoft.AspNetCore.Mvc;
using TechMaster.Context;
using TurboRentCar.Entities;

namespace TechMaster.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly TurboRentContext context;

        public UsuarioController(TurboRentContext techMasterContext)
        {
            this.context = techMasterContext;
        }

        // GET: api/Usuario/GetUsuarios
        [HttpGet]
        [Route("GetUsuarios")]
        public ActionResult Get()
        {
            var usuarios = context.Usuario.ToList();
            return Ok(usuarios);
        }

        // POST: api/Usuario/Save
        [HttpPost]
        [Route("Save")]
        public ActionResult Save(Usuario usuario)
        {
            var nuevoUsuario = new Usuario()
            {
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                rol = usuario.rol,  
                Username = usuario.Username,
                Password = usuario.Password,  
                Email = usuario.Email,
                FechaRegistro = DateTime.Now,
                Activo = usuario.Activo
            };

            context.Usuario.Add(nuevoUsuario);
            context.SaveChanges();

            return Ok(new { Message = "Usuario guardado exitosamente" });
        }

        // PUT: api/Usuario/Update
        [HttpPut]
        [Route("Update")]
        public ActionResult Update(Usuario usuarioData)
        {
            var usuarioUpdate = context.Usuario.Where(u => u.Id == usuarioData.Id).FirstOrDefault();

            if (usuarioUpdate == null)
            {
                throw new Exception("Usuario no encontrado");
            }

            usuarioUpdate.Nombre = usuarioData.Nombre;
            usuarioUpdate.Apellido = usuarioData.Apellido;
            usuarioUpdate.rol = usuarioData.rol;  
            usuarioUpdate.Username = usuarioData.Username;
            usuarioUpdate.Password = usuarioData.Password;  
            usuarioUpdate.Email = usuarioData.Email;
            usuarioUpdate.Activo = usuarioData.Activo;

            context.SaveChanges();

            return Ok(new { Message = "Usuario actualizado exitosamente" });
        }

        // DELETE: api/Usuario/Delete/{IdUsuario}
        [HttpDelete]
        [Route("Delete/{IdUsuario}")]
        public ActionResult Delete(int IdUsuario)
        {
            var usuarioDelete = context.Usuario.Find(IdUsuario);

            if (usuarioDelete == null)
            {
                throw new Exception("Usuario no encontrado");
            }

            context.Usuario.Remove(usuarioDelete);
            context.SaveChanges();

            return Ok(new { Message = "Usuario eliminado exitosamente" });
        }
    }
}
