
using Libreria.LogicaNegocio.Entidades;
using Libreria.LogicaNegocio.InterfacesRepositorios;
using System.Collections.Generic;

namespace Libreria.LogicaAccesoDatos.Lista
{
    public class RepositorioUsuario: IRepositorioUsuario
    {
        private static List<Usuario> _usuarios = new List<Usuario>();


        public void Add(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public void Remove(int id)
        {
            Usuario usuarioEliminar = GetById(id);
            _usuarios.Remove(usuarioEliminar);
        }
        public IEnumerable<Usuario> GetAll()
        {
            return _usuarios;
        }

        public Usuario GetById(int id)
        {
            Usuario usuarioEliminar = null;
            foreach (var usuario in _usuarios)
            {
                if (usuario.Id == id)
                    usuarioEliminar = usuario;
            }
            return usuarioEliminar;
        }

        public IEnumerable<Usuario> GetByName(string value)
        {
            List<Usuario> aux = new List<Usuario>();
            foreach (var usuario in _usuarios)
            {
                if (usuario.Nombre.ToLower().Contains(value.ToLower()))
                    aux.Add(usuario);
            }
            return aux;
        }
    }
}
