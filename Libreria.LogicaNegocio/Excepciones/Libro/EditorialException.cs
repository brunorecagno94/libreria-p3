namespace Libreria.LogicaNegocio.Excepciones.Libro
{
    public class EditorialException : LibroException
    {
        public EditorialException() { }

        public EditorialException(string? message) : base(message)
        {
        }
    }
}
