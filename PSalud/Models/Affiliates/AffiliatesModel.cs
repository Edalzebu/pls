using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using NHibernate.Mapping;
using PSalud.Entities.Domains.Generals;
using PSalud.Entities.Domains.Pacientes;

namespace PSalud.Models.Affiliates
{
    public class AffiliatesModel
    {
        //--------Personal Info------------
        [Required]
        [RegularExpression("[0-9]{13}", ErrorMessage = "La identidad debe tener 13 digitos")]
        [Display(Name = "Numero de Identidad")]
        public int NumeroIdentidad { get; set; }

        [Required]
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }

        [Required]
        [Display(Name = "Primer Apellido")]
        public string PrimerApellido { get; set; }

        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }

        [Required]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [Display(Name = "Género")]
        public char Genero { get; set; }

        [Required]
        [Display(Name = "Direccion de Vivienda")]
        [DataType(DataType.MultilineText)]
        public string Direccion { get; set; }

        [Display(Name = "Correo Electrónico")]
        [DataType(DataType.EmailAddress)]
        public string CorreoElectronico { get; set; }

        [Display(Name = "Teléfono Fijo")]
        public string Telefono { get; set; }

        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public bool Activo { get; set; }

        [Required]
        [Display(Name = "Ciudad de Vivienda")]
        public List<Ciudades> Ciudad { get; set; }

        //---------Affiliate Info------------
        [Required]
        [Display(Name = "Número de Seguro Social")]
        public string NoIhss { get; set; }

        [Required]
        [Display(Name = "Tipo de Paciente")]
        public List<TipoPacientes> TipoPaciente { get; set; }

        [Display(Name = "Observaciones Médicas")]
        [DataType(DataType.MultilineText)]
        public string ObservacionesMedicas { get; set; }
    }
}