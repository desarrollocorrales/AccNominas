using System;

namespace AccAsistencia
{
    public class HorarioGrid
    {
        public int id_horario { set; get; }
        public int id_detalle { set; get; }
        public string descripcion { set; get; }
        public bool checa_dia_siguiente { set; get; }
        public string concepto { set; get; }
        public TimeSpan hora_minima { set; get; }
        public TimeSpan? hora_checada { set; get; }
        public TimeSpan hora_maxima { set; get; }
    }
}
