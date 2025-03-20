namespace Libreria.LogicaNegocio.Excepciones.Libro
{
    public class LibroException : LogicaNegocioException
    {
        public LibroException() { }
        public LibroException(string? message) : base(message)
        {
        }
    }
}
