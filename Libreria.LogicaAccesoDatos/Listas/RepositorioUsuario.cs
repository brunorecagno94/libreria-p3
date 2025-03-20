using Libreria.LogicaNegocio.Entidades;

namespace Libreria.LogicaAccesoDatos.Listas
{
    public class RepositorioUsuario
    {
        private static List<Usuario> _usuarios = new List<Usuario>();

        public IEnumerable<Usuario> GetAll()
        {
            return _usuarios;
        }
        public void Add(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }
        public void Remove(int id)
        {
            Usuario usuarioBorrar = GetById(id);
            _usuarios.Remove(usuarioBorrar);
        }

        public Usuario GetById(int id)
        {
            return _usuarios.FirstOrDefault(item => item.Id == id);
        }

        public Usuario GetByName(string nombre)
        {
            return _usuarios.FirstOrDefault(item => item.Nombre == nombre);
        }
    }
}
