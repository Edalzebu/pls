using FluentNHibernate.Mapping;
using PSalud.Entities.Domains;
using PSalud.Entities.Domains.ServiciosMedicos;

namespace PSalud.DataAccess.Mappings
{
    public class ServicioPorMedicoMap : ClassMap<ServiciosPorMedico>
    {
        public ServicioPorMedicoMap()
        {
            Table("TB_PSL_SERVICIOSXMEDICOS");
            Id(x => x.Id_ServiciosXMedicos);
            References(x => x.Id_Servicio).Column("ID_SERVICIO");
            References(x => x.Id_Medico).Column("ID_MEDICO");
        }
    }
}
