using Libreria.LogicaNegocio.Excepciones.Usuario;

namespace Libreria.LogicaNegocio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public string Password { get; set; }
        public Usuario(int id, string nombre, string email)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
            Validar();
        }

        private void Validar()
        {
            if (string.IsNullOrEmpty(Nombre))
                throw new NombreException("El nombre ingresado no es correcto");
            if (string.IsNullOrEmpty(Email))
                throw new EmailException("El email ingresado no es correcto");
            if (Id <= 0) throw new IdException("El ID no es válido");
        }

    }
}
