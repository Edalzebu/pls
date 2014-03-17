using FluentNHibernate.Mapping;
using PSalud.Entities.Domains.Profiles;

namespace PSalud.DataAccess.Mappings.Profiles
{
    public class EspecialidadesMap : ClassMap<Especialidades>
    {
        public EspecialidadesMap()
        {
            Table("TB_PSL_ESPECIALIDADES");
            Id(x => x.Id_Especialidad);
            Map(x => x.Especialidad);
        }
        
    }
}
