

using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorioUsuario: IRepositorio<Usuario>
    {
        IEnumerable<Usuario> GetByName(string value);
    }
}
