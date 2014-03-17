
using FluentNHibernate.Mapping;

namespace PSalud.DataAccess.Mappings.Pacientes
{
    class PacientesMap : ClassMap<Entities.Domains.Pacientes.Pacientes>
    {
        public PacientesMap()
        {
            Table("TB_PSL_PACIENTES");
            Id(x => x.Id_Paciente);
            References(x => x.Persona).Column("ID_PERSONA");
            References(x => x.Id_Tipo_Paciente).Column("ID_TIPO_PACIENTE");
            Map(x => x.No_Ihss);
            Map(x => x.Observaciones_Medicas);
        }
    }
}
