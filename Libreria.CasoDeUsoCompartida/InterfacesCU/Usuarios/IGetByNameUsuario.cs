

using Libreria.LogicaNegocio.Entidades;

namespace Libreria.CasoDeUsoCompartida.InterfacesCU.Usuarios
{
    public interface IGetByNameUsuario 
    {
        IEnumerable<Usuario> Execute(string valor);
    }
}

