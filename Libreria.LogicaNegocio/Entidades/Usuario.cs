


using Libreria.LogicaNegocio.Excepciones.Usuario;

namespace Libreria.LogicaNegocio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }


        public Usuario(int id, string nombre, string email, string password, string rol)
        {
            Id = id;
            Nombre = nombre;
            Email = email;
            Password = password;
            Rol = rol;
            Validar();
        }
        
        private void Validar()
        {
            if (string.IsNullOrEmpty(Nombre))
                throw new NombreException("Ugyldig navn");
            if (string.IsNullOrEmpty(Email))
                throw new EmailException("Email inválido");
            if (string.IsNullOrEmpty(Password))
                throw new EmailException("Password inválido");
            if (string.IsNullOrEmpty(Rol))
                throw new EmailException("Rol inválido");
            if (Id <= 0) throw new IdException("Id invalido");
        }

    }
}
