using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.Excepciones.Usuario;

namespace Libreria.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Usuario u = new Usuario(1, "", "asdf","","");
                Console.WriteLine(u.Nombre);
                Console.WriteLine(u.Id);
                Console.WriteLine(u.Email);
            }
            //catch (NombreException)
            //{
            //    Console.WriteLine("El nombre ingresado no es correcto");
            //}
            //catch (EmailException)
            //{
            //    Console.WriteLine("El email ingresado no es correcto");
            //}
            //catch (IdException)
            //{
            //    Console.WriteLine("El id ingresado no es correcto");
            //}
            catch (UsuarioException)
            {
                Console.WriteLine("Ingreso mal los datos");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
        }
    }
}

