using Libreria.LogicaAccesoDatos.Listas;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosUso.Usuarios
{
    public class RemoveUsuario
    {
        RepositorioUsuario repoUsuarios = new RepositorioUsuario();
        public void Execute(int id)
        {
            repoUsuarios.Remove(id);
        }
    }
}
