using Libreria.LogicaAccesoDatos.Listas;
using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAplicacion.CasosUso.Usuarios
{
    internal class GetById
    {
        RepositorioUsuario repoUsuarios = new RepositorioUsuario();
        public Usuario Execute(int id)
        {
            return repoUsuarios.GetById(id);
        }
    }
}
