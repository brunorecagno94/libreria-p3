
using Libreria.CasoDeUsoCompartida.InterfacesCU;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;

namespace Libreria.LogicaAplicacion.CasoUso.Usuarios
{
    public class GetAllUsuario: IGetAll<Usuario>
    {
        private IRepositorioUsuario _repo;

        public GetAllUsuario(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public IEnumerable<Usuario> Execute()
        {
            return _repo.GetAll();
        }
    }
}
