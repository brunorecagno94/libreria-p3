namespace Libreria.LogicaNegocio.Excepciones.Usuario
{
    public class UsuarioException : LogicaNegocioException
    {
        public UsuarioException()
        {
        }

        public UsuarioException(string? message) : base(message)
        {
        }
    }
}
