using FluentNHibernate.Mapping;

namespace PSalud.DataAccess.Mappings.Citas
{
    public class CitasMap: ClassMap<Entities.Domains.Citas.Citas>
    {
        public CitasMap()
        {
            Table("TB_PSL_CITAS");
            Id(x => x.Id_Cita);
            References(x => x.Id_Medico).Column("ID_MEDICO");
            References(x => x.Id_Paciente).Column("ID_PACIENTE");
            References(x => x.Id_Sucursal).Column("ID_CLINICA");
            References(x => x.TipodeCita).Column("ID_TIPO_CITA");
            References(x => x.Id_Usuario).Column("ID_USUARIO");
            Map(x => x.Fecha);
            Map(x => x.Hora);
            Map(x => x.Observaciones);
        }
    }
}
