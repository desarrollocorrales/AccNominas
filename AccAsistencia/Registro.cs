using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccAsistencia
{
    public class Registro
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public char Tipo { get; set; }
        public int IdEmpleado { get; set; }
        public int IdSucursal { get; set; }
        public int IdChecador { get; set; }
    }
}
