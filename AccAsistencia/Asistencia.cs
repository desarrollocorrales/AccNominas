using System;

namespace AccAsistencia
{
    public class Asistencia
    {
        private string sEntrada;
        private string sIniDescanso;
        private string sFinDescanso;
        private string sSalida;

        public DateTime Fecha { get; set; }
        public DateTime? EntradaTurno { get; set; }
        public DateTime? InicioDescanso { get; set; }
        public DateTime? TerminoDescanso { get; set; }
        public DateTime? SalidaTurno { get; set; }
        public DateTime EntradaTurnoOficial { get; set; }
        public DateTime SalidaTurnoOficial { get; set; }
        public bool JustificacionET { get; set; }
        public bool JustificacionID { get; set; }
        public bool JustificacionTD { get; set; }
        public bool JustificacionST { get; set; }
        public bool JustificacionTodoElDia { get; set; }
        public string sEntradaTurno
        {
            set
            {
                sEntrada = value;
            }

            get
            {
                if (EntradaTurno.HasValue)
                {
                    if (EntradaTurno.Value == new DateTime())
                    {
                        return "Descanso";
                    }
                    else
                    {
                        if (EntradaTurno.Value == Fecha)
                        {
                            return sEntrada;
                        }
                        else
                        {
                            return EntradaTurno.Value.ToString("dd/MM/yyyy HH:mm");
                        }
                    }
                }
                else
                {
                    return "Sin Registro";
                }
            }
        }
        public string sInicioDescanso
        {
            set
            {
                sIniDescanso = value;
            }

            get
            {
                if (InicioDescanso.HasValue)
                {
                    if (InicioDescanso.Value == new DateTime())
                    {
                        return "Descanso";
                    }
                    else
                    {
                        if (InicioDescanso.Value == Fecha)
                        {
                            return sIniDescanso;
                        }
                        else
                        {
                            return InicioDescanso.Value.ToString("dd/MM/yyyy HH:mm");
                        }
                    }
                }
                else
                {
                    return "Sin Registro";
                }
            }
        }
        public string sTerminoDescanso
        {
            set
            {
                sFinDescanso = value;
            }

            get
            {
                if (TerminoDescanso.HasValue)
                {
                    if (TerminoDescanso.Value == new DateTime())
                    {
                        return "Descanso";
                    }
                    else
                    {
                        if (TerminoDescanso.Value == Fecha)
                        {
                            return sFinDescanso;
                        }
                        else
                        {
                            return TerminoDescanso.Value.ToString("dd/MM/yyyy HH:mm");
                        }
                    }
                }
                else
                {
                    return "Sin Registro";
                }
            }
        }
        public string sSalidaTurno
        {
            set
            {
                sSalida = value;
            }

            get
            {
                if (SalidaTurno.HasValue)
                {
                    if (SalidaTurno.Value == new DateTime())
                    {
                        return "Descanso";
                    }
                    else
                    {
                        if (SalidaTurno.Value == Fecha)
                        {
                            return sSalida;
                        }
                        else
                        {
                            return SalidaTurno.Value.ToString("dd/MM/yyyy HH:mm");
                        }
                    }
                }
                else
                {
                    return "Sin Registro";
                }
            }
        }
    }
}
