using FluentNHibernate.Mapping;
using PSalud.Entities.Domains.ServiciosMedicos;

namespace PSalud.DataAccess.Mappings.ServiciosMedicos
{
    public class ServicioPorCitaMap : ClassMap<ServiciosPorCita>
    {
        public ServicioPorCitaMap()
        {
            Table("TB_PSL_SERVICIOSXCITAS");
            Id(x => x.Id_ServiciosXCita);
            References(x => x.Id_Cita);
            References(x => x.Id_Servicio);
        }
    }
}
