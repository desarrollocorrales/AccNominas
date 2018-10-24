using System;

namespace AccAsistencia
{
    public class Justificacion
    {
        public int id_justificacion { set; get; }
        public int id_interno { set; get; }
        public DateTime fecha_hora { set; get; }
        public string detalle { set; get; }
        public Concepto oConcepto { set; get; }
        public string autorizado_por { set; get; }
    }
}
