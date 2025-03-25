using Libreria.CasoDeUsoCompartida.InterfacesCU;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;

namespace Libreria.LogicaAplicacion.CasoUso.Usuarios
{
    public class GetById: IGetById<Usuario>
    {
        private IRepositorioUsuario _repo;

        public GetById(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public Usuario Execute(int id)
        {
            return _repo.GetById(id);
        }
    }
}
