using System;

namespace AccAsistencia
{
    public class EmpleadoHorario
    {
        public int id_empleado { set; get; }
        public int id_horario { set; get; }
        public DateTime vigencia_inicio { set; get; }
        public DateTime vigencia_fin { set; get; }
        public int prioridad { set; get; }
    }
}
