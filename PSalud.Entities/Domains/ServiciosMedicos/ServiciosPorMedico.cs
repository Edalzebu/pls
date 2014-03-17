
namespace PSalud.Entities.Domains.ServiciosMedicos
{
    public class ServiciosPorMedico
    {
        public virtual int Id_ServiciosXMedicos { get; set; }
        public virtual Servicios Id_Servicio { get; set; }
        public virtual Medicos.Medicos Id_Medico { get; set; }
    }
}
