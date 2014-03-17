using FluentNHibernate.Mapping;

namespace PSalud.DataAccess.Mappings.Clinicas
{
    class ClinicasMap : ClassMap<Entities.Domains.Clinicas.Clinicas>
    {
        public ClinicasMap()
        {
            Table("TB_PSL_CLINICAS");
            Id(x => x.Id_Clinica);
            Map(x => x.Nombre_Clinica);
            Map(x => x.Abreviatura);
            Map(x => x.Direccion);
            Map(x => x.Direccion_Alterna);
            References(x => x.Id_Ciudad).Column("ID_CIUDAD");
            Map(x => x.Apartado_Postal);
        }
    }
}
