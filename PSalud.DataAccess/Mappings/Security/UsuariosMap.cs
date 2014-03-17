using FluentNHibernate.Mapping;
using PSalud.Entities.Domains.Security;


namespace PSalud.DataAccess.Mappings.Security
{
    class UsuariosMap : ClassMap<Usuarios>
    {
        public UsuariosMap()
        {
            Table("TB_SEG_USUARIO");
            Id(x => x.Id_Usuario);
            References(x => x.Id_Persona).Column("ID_PERSONA");
            Map(x => x.Nombre_Usuario);
            Map(x => x.Contrasenia);
            Map(x => x.Active);
            References(x => x.Id_Sucursal).Column("ID_SUCURSAL");
        }
    }
}
