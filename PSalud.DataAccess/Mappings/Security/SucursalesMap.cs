using FluentNHibernate.Mapping;
using PSalud.Entities.Domains.Security;

namespace PSalud.DataAccess.Mappings.Security
{
    class SucursalesMap : ClassMap<Sucursales>
    {
        public SucursalesMap()
        {
            Table("TB_SEG_SUCURSAL");
            Id(x => x.IdSucursal);
            Map(x => x.Sucursal);
        }
    }
}
