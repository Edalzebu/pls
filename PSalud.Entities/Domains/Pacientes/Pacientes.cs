
using PSalud.Entities.Domains.Profiles;

namespace PSalud.Entities.Domains.Pacientes
{
    public class Pacientes
    {
        public virtual int Id_Paciente { get; set; }
        public virtual Personas Persona { get; set; }//Id_Persona
        public virtual string No_Ihss { get; set; }
        public virtual TipoPacientes Id_Tipo_Paciente { get; set; }
        public virtual string Observaciones_Medicas { get; set; }

        public virtual void AddPerson(Personas person)
        {
            Persona = person;
        }

        public virtual void AddTipoPaciente(TipoPacientes tipoPacientes)
        {
            Id_Tipo_Paciente = tipoPacientes;
        }
    }
}
