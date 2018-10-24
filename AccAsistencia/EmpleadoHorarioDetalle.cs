using System;

namespace AccAsistencia
{
    public class EmpleadoHorarioDetalle
    {
        public int id_empleado { set; get; }
        public int id_horario { set; get; }
        public string descripcion { set; get; }
        public string dias_que_aplica { set; get; }
        public string dias_que_no_aplica { set; get; }
        public TimeSpan hora_minima { set; get; }
        public TimeSpan? hora_checada { set; get; }
        public TimeSpan hora_maxima { set; get; }
        public string concepto { set; get; }
    }
}
