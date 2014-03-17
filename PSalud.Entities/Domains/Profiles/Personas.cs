using PSalud.Entities.Domains.Generals;
using System;
namespace PSalud.Entities.Domains.Profiles
{
    public class Personas
    {
        public virtual int Id_Persona { get; set; }
        public virtual int Numero_Identidad { get; set; }
        public virtual string Nombres { get; set; }
        public virtual string Primer_Apellido { get; set; }
        public virtual string Segundo_Apellido { get; set; }
        public virtual DateTime Fecha_Nacimiento { get; set; }
        public virtual char Genero { get; set; }
        public virtual string Direccion_Vivienda { get; set; }
        public virtual string Correo_Electronico { get; set; }
        public virtual string Telefono { get; set; }
        public virtual string Celular { get; set; }
        public virtual bool Activo { get; set; }
        public virtual Ciudades Id_Ciudad { get; set; }
    }
}
