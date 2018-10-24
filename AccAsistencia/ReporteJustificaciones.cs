using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccAsistencia
{
    public class ReporteJustificaciones
    {
        public Empleado oEmpleado { set; get; }
        public DateTime dtInicio { set; get; }
        public DateTime dtFin { set; get; }
        public List<Justificacion> lstJustificaciones { set; get; }
    }
}
