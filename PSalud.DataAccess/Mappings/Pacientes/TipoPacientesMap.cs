
using FluentNHibernate.Mapping;
using PSalud.Entities.Domains.Pacientes;

namespace PSalud.DataAccess.Mappings.Pacientes
{
    class TipoPacientesMap : ClassMap<TipoPacientes>
    {
        public TipoPacientesMap()
        {
            Table("TB_INF_TIPOPACIENTE");
            Id(x => x.Id_TipoPaciente);
            Map(x => x.Tipo_Paciente);
        }
    }
}
