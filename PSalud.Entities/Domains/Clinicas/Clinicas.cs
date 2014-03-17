using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSalud.Entities.Domains.Generals;

namespace PSalud.Entities.Domains.Clinicas
{
    public class Clinicas
    {
        public virtual int Id_Clinica { get; set; }
        public virtual string Nombre_Clinica { get; set; }
        public virtual string Abreviatura { get; set; }
        public virtual string Direccion { get; set; }
        public virtual string Direccion_Alterna { get; set; }
        public virtual Ciudades Id_Ciudad { get; set; }
        public virtual int Apartado_Postal { get; set; }
    }
}
