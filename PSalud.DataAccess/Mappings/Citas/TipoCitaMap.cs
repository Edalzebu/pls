using FluentNHibernate.Mapping;
using PSalud.Entities.Domains.Citas;

namespace PSalud.DataAccess.Mappings.Citas
{
    public class TipoCitaMap : ClassMap<TipoCita>
    {
        public TipoCitaMap()
        {
            Table("TB_PSL_TIPOCITA");
            Id(x=>x.Id_Tipocita);
            Map(x => x.Tipo_Cita);
        }
    }
}
