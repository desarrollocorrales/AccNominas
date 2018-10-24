using System;
using System.Collections.Generic;

namespace AccAsistencia
{
    public class Horario
    {
        public int id_horario { set; get; }
        public string descripcion { set; get; }
        public string dias_que_aplica { set; get; }
        public string dias_que_no_aplica { set; get; }
        public DateTime fecha_actualizacion { set; get; }
        public bool checa_dia_siguiente { set; get; }
        public DateTime vigencia_inicio { set; get; }
        public DateTime vigencia_fin { set; get; }
        public int prioridad { set; get; }

        public List<HorariosDetalles> lstDetalles { set; get; }
    }
}
