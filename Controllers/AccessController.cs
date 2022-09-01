using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Tareas.Models; 


namespace Tareas.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(Login login) {

            //var usuario = login.user;

            var user = new Usuario()
            {
                Username = login.username,
                Nombre = login.nombre,
                Password = login.password
            };


            login.Id = 2;

            var deleteUserId = new Usuario()
            {
                UsuarioId = login.Id
            };

            using (var db = new TareasContext())
            {
                 //db.Add(user);

                /* db.Remove(deleteUserId);*/
                 
                 //db.SaveChanges();   
                IEnumerable<Usuario> usuarios = db.Usuarios.FromSqlRaw("SELECT * FROM usuario WHERE usuario_id= {0}",5).ToList();

            }


            try
            {


               return View();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        
        }

    }
}
