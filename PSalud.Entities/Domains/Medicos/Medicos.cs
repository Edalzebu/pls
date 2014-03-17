using PSalud.Entities.Domains.Profiles;
using PSalud.Entities.Domains.Security;

namespace PSalud.Entities.Domains.Medicos
{
    public class Medicos
    {
        public virtual int Id_Medicos { get; set; }
        public virtual Personas Id_Persona { get; set; }
        public virtual Especialidades Id_Especialidad { get; set; }
        public virtual Clinicas.Clinicas Id_Clinica { get; set; }
    }
}
