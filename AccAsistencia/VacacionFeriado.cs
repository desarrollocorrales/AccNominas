using System;

namespace AccAsistencia
{
    public class VacacionFeriado
    {
        public int id_interno { set; get; }
        public int id_feriado { set; get; }
        public DateTime fecha { set; get; }
        public string concepto { set; get; }
        public string descripcion { set; get; }
    }
}
