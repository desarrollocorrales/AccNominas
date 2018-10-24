using System.Collections.Generic;

namespace AccAsistencia {

    public class Empleado 
    {
        public int id_interno { set; get; }
        public int id_depto { set; get; }
        public Departamento departamento { set; get; }
        public string nombre { set; get; }
        public bool activado { set; get; }
        public string activo { set; get; }
        public bool variado { set; get; }
        public List<Horario> lstHorarios { set; get; }

        public string datos
        {
            get
            {
                return (id_interno + " - " + nombre);
            }
        }
    }
}
