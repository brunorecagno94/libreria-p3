
using Libreria.CasoDeUsoCompartida.InterfacesCU;
using Libreria.LogicaNegocio.InterfacesRepositorios;

namespace Libreria.LogicaAplicacion.CasoUso.Usuarios
{
    public class RemoveUsuario: IRemove
    {
        private IRepositorioUsuario _repo;

        public RemoveUsuario(IRepositorioUsuario repo)
        {
            _repo = repo;
        }
        public void Execute(int id)
        {
            _repo.Remove(id);
        }

    }
}
