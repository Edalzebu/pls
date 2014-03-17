using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PSalud.Entities.Domains.Pacientes;
using PSalud.Entities.Domains.Profiles;
using PSalud.Models.Affiliates;
using AutoMapper;
using PSalud.Models.Medics;


namespace PSalud.Utility
{
    public class AutoMapperConfig
    {
        public static void Configuration()
        {
            Mapper.CreateMap<AffiliatesModel, Personas>()
                .ForMember(x => x.Numero_Identidad, o => o.MapFrom(y => y.NumeroIdentidad))
                .ForMember(x => x.Primer_Apellido, o => o.MapFrom(y => y.PrimerApellido))
                .ForMember(x => x.Segundo_Apellido, o => o.MapFrom(y => y.SegundoApellido))
                .ForMember(x => x.Fecha_Nacimiento, o => o.MapFrom(y => y.FechaNacimiento))
                .ForMember(x => x.Direccion_Vivienda, o => o.MapFrom(y => y.Direccion))
                .ForMember(x => x.Correo_Electronico, o => o.MapFrom(y => y.CorreoElectronico))
                ;
            Mapper.CreateMap<Personas, AffiliatesModel>()
                .ForMember(x => x.NumeroIdentidad, o => o.MapFrom(y => y.Numero_Identidad))
                .ForMember(x => x.PrimerApellido, o => o.MapFrom(y => y.Primer_Apellido))
                .ForMember(x => x.SegundoApellido, o => o.MapFrom(y => y.Segundo_Apellido))
                .ForMember(x => x.FechaNacimiento, o => o.MapFrom(y => y.Fecha_Nacimiento))
                .ForMember(x => x.Direccion, o => o.MapFrom(y => y.Direccion_Vivienda))
                .ForMember(x => x.CorreoElectronico, o => o.MapFrom(y => y.Correo_Electronico));

            Mapper.CreateMap<AffiliatesModel, Pacientes>()
                .ForMember(x => x.No_Ihss, o => o.MapFrom(y => y.NoIhss))
                .ForMember(x => x.Observaciones_Medicas, o => o.MapFrom(y => y.ObservacionesMedicas));

            Mapper.CreateMap<MedicsModel, Personas>()
                .ForMember(x => x.Numero_Identidad, o => o.MapFrom(y => y.NumeroIdentidad))
                .ForMember(x => x.Primer_Apellido, o => o.MapFrom(y => y.PrimerApellido))
                .ForMember(x => x.Segundo_Apellido, o => o.MapFrom(y => y.SegundoApellido))
                .ForMember(x => x.Fecha_Nacimiento, o => o.MapFrom(y => y.FechaNacimiento))
                .ForMember(x => x.Direccion_Vivienda, o => o.MapFrom(y => y.Direccion))
                .ForMember(x => x.Correo_Electronico, o => o.MapFrom(y => y.CorreoElectronico));
            
            
        }
    }
}