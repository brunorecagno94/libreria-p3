namespace Libreria.LogicaNegocio.Excepciones.Libro
{
    public class NombreException : LibroException
    {
        public NombreException() { }

        public NombreException(string? message) : base(message)
        {
        }
    }
}
