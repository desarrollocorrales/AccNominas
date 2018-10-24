using System;

namespace AccAsistencia
{
    public class HorarioVigencia
    {
        public int id_horario { get; set; }
        public int prioridad { get; set; }
        public string descripcion { get; set; }
        public DateTime vigencia_inicio { get; set; }
        public DateTime vigencia_fin { get; set; }
    }
}
