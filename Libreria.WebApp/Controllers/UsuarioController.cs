using Libreria.CasoDeUso_Compartida.InterfacesCU;
using Libreria.CasoDeUsoCompartida.DTOs.Usuarios;
using Libreria.CasoDeUsoCompartida.InterfacesCU;
using Libreria.CasoDeUsoCompartida.InterfacesCU.Usuarios;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.Excepciones.Usuario;
using Libreria.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Libreria.WebApp.Controllers
{
    public class UsuarioController : Controller
    {

        IGetAll<Usuario> _getAll;
        IAdd<UsuarioDto> _add;
        IRemove _remove;
        IGetByNameUsuario _getByName;
        IGetById<Usuario> _getById;

        public UsuarioController(IGetAll<Usuario> getAll,
                                 IAdd<UsuarioDto> add,
                                 IRemove remove,
                                 IGetByNameUsuario getByName,
                                 IGetById<Usuario> getById) 
        {
            _getAll = getAll;
            _add = add;
            _remove = remove;
            _getByName = getByName;
            _getById = getById;
        }


        public IActionResult Index()
        {
            return View(_getAll.Execute());
        }

        public IActionResult SerchName(string nombre)
        {
            return View("index",_getByName.Execute(nombre));
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(int id)
        { 
            Usuario unU =  _getById.Execute(id);
            if (unU == null)
            {
                return RedirectToAction("index");
            }
            return View(unU);
        }

        [HttpPost]
        public IActionResult Create(VMUsuario usuario)
        {
            try
            {
                UsuarioDto unU = new UsuarioDto();
                
                unU.Id = usuario.Id;

                _add.Execute(unU);
                return RedirectToAction("index");
            }
            catch (NombreException)
            {
                ViewBag.Message = "El nombre ingresado no es correcto";
            }
            catch (EmailException)
            {
                ViewBag.Message = "El email ingresado no es correcto";
            }
            catch (IdException)
            {
                ViewBag.Message = "El id ingresado no es correcto";
            }
            catch (Exception)
            {
                ViewBag.Message = "Hubo un error";
            }
            return View();

        }

        public IActionResult Delete(int id)
        {
            _remove.Execute(id);
            return RedirectToAction("index");
        }

    }
}
