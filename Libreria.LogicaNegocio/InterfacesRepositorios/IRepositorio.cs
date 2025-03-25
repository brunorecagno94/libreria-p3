
namespace Libreria.LogicaNegocio.InterfacesRepositorios
{
    public interface IRepositorio <T>
    {
        void Add(T obj);
        T GetById(int id);
        void Remove(int id);
        IEnumerable<T> GetAll();
    }
}

