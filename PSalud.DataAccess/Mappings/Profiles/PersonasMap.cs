using FluentNHibernate.Mapping;
using PSalud.Entities.Domains.Profiles;

namespace PSalud.DataAccess.Mappings.Profiles
{
    class PersonasMap: ClassMap<Personas>
    {
        public PersonasMap()
        {
            Table("PERSONA");
            Id(x => x.Id_Persona);
            Map(x => x.Numero_Identidad);
            Map(x => x.Nombres);
            Map(x => x.Primer_Apellido);
            Map(x => x.Segundo_Apellido);
            Map(x => x.Fecha_Nacimiento);
            Map(x => x.Genero);
            Map(x => x.Direccion_Vivienda);
            Map(x => x.Correo_Electronico);
            Map(x => x.Telefono);
            Map(x => x.Celular);
            Map(x => x.Activo);
            References(x => x.Id_Ciudad).Column("ID_CIUDAD");
        }
    }
}
