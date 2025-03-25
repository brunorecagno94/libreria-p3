using Libreria.CasoDeUsoCompartida.InterfacesCU.Usuarios;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;

namespace Libreria.LogicaAplicacion.CasoUso.Usuarios
{
    public class GetByName: IGetByNameUsuario
    {
        private IRepositorioUsuario _repo;

        public GetByName(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public IEnumerable<Usuario> Execute(string valor)
        {
            return _repo.GetByName(valor);
        }
    }
}
