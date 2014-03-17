

namespace PSalud.Entities.Domains.ServiciosMedicos
{
    public class Servicios
    {
        public virtual int Id_Servicio { get; set; }
        public virtual string Servicio { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual string DescripcionInterna { get; set; }
        public virtual bool Visible_Clientes { get; set; }
        public virtual string Duracion { get; set; }
        public virtual double Costo { get; set; }
    }
}
