using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSalud.Models.Affiliates
{
    public class ListAffiliatesModel
    {
        public long Id { get; set; }
        public bool Editar { get; set; }
        public string Nombres { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
    }
}