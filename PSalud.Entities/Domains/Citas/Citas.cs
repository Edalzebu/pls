using System;
using PSalud.Entities.Domains.Profiles;
using PSalud.Entities.Domains.Security;

namespace PSalud.Entities.Domains.Citas
{
    public class Citas
    {
        public virtual int Id_Cita { get; set; }
        public virtual Personas Id_Paciente { get; set; }
        public virtual Medicos.Medicos Id_Medico {get; set;}
        public virtual Sucursales Id_Sucursal { get; set; }
        public virtual Usuarios Id_Usuario { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual DateTime Hora {get; set; }
        public virtual TipoCita TipodeCita { get; set; }
        public virtual string Observaciones { get; set; }
        public virtual Usuarios Usuario { get; set; }
        
    }
}
