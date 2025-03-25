
using Libreria.CasoDeUso_Compartida.InterfacesCU;
using Libreria.CasoDeUsoCompartida;
using Libreria.CasoDeUsoCompartida.DTOs.Usuarios;
using Libreria.CasoDeUsoCompartida.InterfacesCU;
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;

namespace Libreria.LogicaAplicacion.CasoUso.Usuarios
{
    public class AddUsuario: IAdd<UsuarioDto>
    {
        private IRepositorioUsuario _repo;

        public AddUsuario(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public void Execute(UsuarioDto usuario)
        {
            Usuario unU = new Usuario(usuario.Id,
                                      usuario.Nombre,
                                      usuario.Email,
                                      usuario.Password,
                                      usuario.Rol);
            _repo.Add(unU);
        }
    }
}
