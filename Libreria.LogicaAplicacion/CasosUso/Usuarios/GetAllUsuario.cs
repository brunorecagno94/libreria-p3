using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaAccesoDatos.Listas;

namespace Libreria.LogicaAplicacion.CasosUso.Usuarios
{
    public class GetAllUsuario
    {
        RepositorioUsuario repoUsuarios = new RepositorioUsuario();
        public IEnumerable<Usuario> Execute()
        {
            return repoUsuarios.GetAll();
        }
    }
}
