namespace Libreria.LogicaNegocio.Excepciones.Usuario
{
    public class IdException : UsuarioException
    {
        public IdException() { }

        public IdException(string? message) : base(message)
        {
        }
    }
}
