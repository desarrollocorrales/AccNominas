using System;

namespace AccAsistencia
{
    public class HorariosDetalles
    {
        public int id_detalle { set; get; }
        public int id_horario { set; get; }
        public Concepto oConcepto { set; get; }
        public TimeSpan hora_minima { set; get; }
        public TimeSpan? hora_checada { set; get; }
        public TimeSpan hora_maxima { set; get; }
    }
}
