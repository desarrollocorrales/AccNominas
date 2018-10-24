using System;

namespace AccAsistencia
{
    public class Checada
    {
        public int id_interno { set; get; }
        public DateTime fecha_hora { set; get; }
        public Concepto oConcepto { set; get; }

        public string lugar { set; get; }
    }

    public class Checadas
    {
        public int idInterno { get; set; }
        public string empleado { get; set; }

        public int idDepto { get; set; }
        public string departamento { get; set; }

        public string fechaHora { get; set; }
    }
}
