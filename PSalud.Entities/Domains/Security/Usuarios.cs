using PSalud.Entities.Domains.Profiles;

namespace PSalud.Entities.Domains.Security
{
    public class Usuarios
    {
        public virtual int Id_Usuario { get; set; }
        public virtual Personas Id_Persona { get; set; }
        public virtual string Nombre_Usuario { get; set; }
        public virtual string Contrasenia { get; set; }
        public virtual bool Active { get; set; }
        public virtual Sucursales Id_Sucursal { get; set; }
    }
}
