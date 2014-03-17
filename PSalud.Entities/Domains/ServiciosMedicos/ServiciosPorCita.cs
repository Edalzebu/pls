
namespace PSalud.Entities.Domains.ServiciosMedicos
{
    public class ServiciosPorCita
    {
        public virtual int Id_ServiciosXCita { get; set; }
        public virtual Citas.Citas Id_Cita { get; set; }
        public virtual Servicios Id_Servicio { get; set; }
    }
}
