using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaAccesoDatos.Listas;

namespace Libreria.LogicaAplicacion.CasosUso.Usuarios
{
    public class AddUsuario
    {
        RepositorioUsuario repoUsuarios = new RepositorioUsuario();
        public void Execute(Usuario usuario)
        {
            repoUsuarios.Add(usuario);
        }
    }
}
