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
                Usuario u = new Usuario(1, "Nombre", "mail@gmail.com");
                Console.WriteLine(u.Id);
                Console.WriteLine(u.Nombre);
                Console.WriteLine(u.Email);
            }
           catch (UsuarioException us)
            {
                Console.WriteLine("Datos incorrectos");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

