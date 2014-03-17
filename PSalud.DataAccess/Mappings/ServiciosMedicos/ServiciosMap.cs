using FluentNHibernate.Mapping;
using PSalud.Entities.Domains;
using PSalud.Entities.Domains.ServiciosMedicos;

namespace PSalud.DataAccess.Mappings.ServiciosMedicos
{
    public class ServiciosMap : ClassMap<Servicios>
    {
        public ServiciosMap()
        {
            Table("TB_PSL_SERVICIOS");
            Id(x => x.Id_Servicio);
            Map(x => x.Servicio);
            Map(x => x.Descripcion);
            Map(x => x.DescripcionInterna);
            Map(x => x.Visible_Clientes);
            Map(x => x.Duracion);
            Map(x => x.Costo);
        }
    }
}
