using Microsoft.AspNetCore.Mvc;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.Excepciones.Libro;
using Libreria.WebApp.Models;

namespace Libreria.WebApp.Controllers
{
    public class LibroController : Controller
    {
        static List<Libro> _libros = new List<Libro>();
        public IActionResult Index()
        {
            return View(_libros);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VMLibro libro)
        {
            try
            {
                Libro nuevoLibro = new Libro(libro.Id,
                    libro.Nombre,
                    libro.Editorial);
                _libros.Add(nuevoLibro);
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
            catch (EditorialException)
            {
                ViewBag.Message = "La editorial ingresada no es correcta";
            }
            catch (Exception)
            {
                ViewBag.Message = "Hubo un error";

            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            Libro libroBorrar = _libros.FirstOrDefault(item => item.Id == id);
            _libros.Remove(libroBorrar);
            return RedirectToAction("Index");
        }
    }
}
