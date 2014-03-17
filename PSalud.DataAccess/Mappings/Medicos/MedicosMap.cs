using FluentNHibernate.Mapping;

namespace PSalud.DataAccess.Mappings.Medicos
{
    public class MedicosMap : ClassMap<Entities.Domains.Medicos.Medicos>
    {
        public MedicosMap()
        {
            Table("TB_PSL_MEDICOS");
            Id(x => x.Id_Medicos);
            References(x => x.Id_Persona).Column("ID_PERSONA");
            References(x => x.Id_Especialidad).Column("ID_ESPECIALIDAD");
            References(x => x.Id_Clinica).Column("ID_CLINICA");
        }
    }
}
