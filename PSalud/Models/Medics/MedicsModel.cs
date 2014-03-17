using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PSalud.Entities.Domains.Clinicas;
using PSalud.Entities.Domains.Generals;
using PSalud.Entities.Domains.Medicos;
using PSalud.Entities.Domains.Profiles;

namespace PSalud.Models.Medics
{
    public class MedicsModel
    {
        //--------Personal Info------------
        [Required]
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

        //--------Medics Info------------
        [Display(Name = "Especialidad")]
        public List<Especialidades> Especialidades { get; set; }

        [Display(Name = "Clinica")]
        public List<Clinicas> Clinicas { get; set; }
    }
}