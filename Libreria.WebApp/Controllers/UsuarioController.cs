using Microsoft.AspNetCore.Mvc;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.Excepciones.Usuario;
using Libreria.WebApp.Models;
using Libreria.LogicaAplicacion.CasosUso.Usuarios;

namespace Libreria.WebApp.Controllers
{
    public class UsuarioController : Controller
    {
        GetAllUsuario listaUsuarios = new GetAllUsuario();
        AddUsuario agregarUsuario = new AddUsuario();
        RemoveUsuario borrarUsuario = new RemoveUsuario();

        public IActionResult Index()
        {
            return View(listaUsuarios.Execute());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VMUsuario usuario)
        {
            try
            {
                Usuario nuevoUsuario = new Usuario(usuario.Id,
                    usuario.Nombre,
                    usuario.Email);
                agregarUsuario.Execute(nuevoUsuario);
                return RedirectToAction("Index");
            }
            catch (IdException)
            {
                ViewBag.Message = "El ID ingresado no es correcto";
            }
            catch (NombreException)
            {
                ViewBag.Message = "El nombre ingresado no es correcto";
            }
            catch (EmailException)
            {
                ViewBag.Message = "El email ingresado no es correcto";
            }
            catch (Exception)
            {
                ViewBag.Message = "Hubo un error";

            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            borrarUsuario.Execute(id);
            return RedirectToAction("Index");
        }
    }
}
