using Libreria.LogicaNegocio.Excepciones.Libro;

namespace Libreria.LogicaNegocio.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Editorial { get; set; }

        public Libro(int id, string nombre, string editorial)
        {
            Id = id;
            Nombre = nombre;
            Editorial = editorial;
            Validar();
        }

        private void Validar()
        {
            if (string.IsNullOrEmpty(Nombre))
                throw new NombreException("El nombre ingresado no es correcto");
            if (string.IsNullOrEmpty(Editorial))
                throw new EditorialException("La editorial ingresada no es correcta");
            if (Id <= 0) throw new IdException("El ID no es válido");
        }
    }
}
