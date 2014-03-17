using FluentNHibernate.Mapping;
using PSalud.Entities.Domains.Generals;

namespace PSalud.DataAccess.Mappings.Generals
{
    class CiudadesMap: ClassMap<Ciudades>
    {
        public CiudadesMap()
        {
            Table("TB_INF_CIUDAD");
            Id(x => x.Id_Ciudad);
            Map(x => x.Ciudad);
        }
    }
}
