namespace Libreria.LogicaNegocio.Excepciones.Libro
{
    public class IdException : LibroException
    {
        public IdException()
        {
        }

        public IdException(string? message) : base(message)
        {
        }
    }
}
