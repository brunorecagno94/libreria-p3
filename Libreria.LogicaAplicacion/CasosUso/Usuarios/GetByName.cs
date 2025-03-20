using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaAccesoDatos.Listas;

namespace Libreria.LogicaAplicacion.CasosUso.Usuarios
{
    public class GetByName
    {
        RepositorioUsuario repoUsuarios = new RepositorioUsuario();

        public Usuario Execute(string nombre)
        {
            return repoUsuarios.GetByName(nombre);
        }
    }
}
