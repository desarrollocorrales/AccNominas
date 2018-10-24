using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccSettings;
using AccAsistencia;
using AccAsistencia.DAL;
using AccAsistencia.Utilerias;
using AccNominas.Formularios.Horarios;

namespace AccNominas.Formularios.Reportes
{
    public partial class FrmAsistenciaTodosChecadores : Form
    {
        private Empleado oEmpleado;
        private ReporteAsistencia oReporte;
        private enum MinMax
        {
            MIN = 0,
            MAX = 1
        }

        public FrmAsistenciaTodosChecadores(Empleado pEmpleado)
        {
            InitializeComponent();
            oEmpleado = pEmpleado;
        }

        private void FrmAsistenciaTodosChecadores_Load(object sender, EventArgs e)
        {
            PreararFormulario();
        }

        private void CrearReporte()
        {
            oReporte = new ReporteAsistencia();
            oReporte.oEmpleado = oEmpleado;

            List<Horario> lstHorarios = oEmpleado.lstHorarios;

            int id = oReporte.oEmpleado.id_interno;
            DateTime dtInicio = dtpInicial.Value.Date;
            DateTime dtFinal = dtpFinal.Value.AddDays(1).Date;

            ChecadasDAL oChecadasDAL = new ChecadasDAL();
            List<Checada> lstChecadas =
                oChecadasDAL.ObtenerChecadasTodosChecadores(id, dtInicio, dtFinal);

            JustificacionesDAL oJustificacionesDAL = new JustificacionesDAL();
            List<Justificacion> lstJustificaciones =
                oJustificacionesDAL.ObtenerJustificaciones(id, dtInicio, dtFinal);

            oReporte.lstAsistencias =
                ObtenerAsistencias(lstChecadas, lstHorarios, lstJustificaciones);

            gridReporte.DataSource = null;
            gridReporte.DataSource = oReporte.lstAsistencias;
        }

        private List<Asistencia> ObtenerAsistencias(List<Checada> lstChecadas, List<Horario> lstHorarios, List<Justificacion> lstJustificaciones)
        {
            List<Asistencia> lstAsistencias = new List<Asistencia>();
            DateTime fechaInicial = dtpInicial.Value.Date;
            DateTime fecha = new DateTime(fechaInicial.Year, fechaInicial.Month, fechaInicial.Day);
            Asistencia oAsistencia = new Asistencia();
            Justificacion oJustificacion = new Justificacion();
            DateTime fechaFinal = dtpFinal.Value.Date;
            fechaFinal = fechaFinal.AddDays(1);
            List<VacacionFeriado> lFeriados = ObtenerJustificacionesMasivas();
            VacacionFeriado oFeriado;

            while (fecha < fechaFinal)
            {
                /* Dia Completo Justificado */
                oFeriado = lFeriados.Find(o => o.fecha.Date == fecha
                                            && o.id_interno == oEmpleado.id_interno);
                if (oFeriado != null)
                {
                    Asistencia diaJustificado = new Asistencia();
                    diaJustificado.Fecha = fecha;
                    diaJustificado.EntradaTurno = fecha;
                    diaJustificado.InicioDescanso = fecha;
                    diaJustificado.TerminoDescanso = fecha;
                    diaJustificado.SalidaTurno = fecha;
                    diaJustificado.sEntradaTurno = oFeriado.concepto;
                    diaJustificado.sInicioDescanso = oFeriado.concepto;
                    diaJustificado.sTerminoDescanso = oFeriado.concepto;
                    diaJustificado.sSalidaTurno = oFeriado.concepto;
                    diaJustificado.JustificacionTodoElDia = true;
                    lstAsistencias.Add(diaJustificado);

                    fecha = fecha.AddDays(1);
                    continue;
                }
                /***************************************/

                List<Checada> lstAuxiliar = new List<Checada>();
                lstAuxiliar = lstChecadas.FindAll(o => o.fecha_hora.Date == fecha);

                List<Justificacion> lstAuxiliarJustificaciones = new List<Justificacion>();
                lstAuxiliarJustificaciones = lstJustificaciones.FindAll(o => o.fecha_hora.Date == fecha);

                oAsistencia = new Asistencia();
                oJustificacion = new Justificacion();
                Horario oHorario = new Horario();
                if (lstHorarios.Find(o => o.dias_que_aplica[fecha.DayOfWeek.GetHashCode()] == '1') != null)
                {
                    oHorario = lstHorarios.Find(o => o.dias_que_aplica[fecha.DayOfWeek.GetHashCode()] == '1');
                    oAsistencia.EntradaTurnoOficial = new DateTime(oHorario.lstDetalles.Find(o => o.oConcepto.clave == "ET").hora_checada.Value.Ticks);
                    oAsistencia.SalidaTurnoOficial = new DateTime(oHorario.lstDetalles.Find(o => o.oConcepto.clave == "ST").hora_checada.Value.Ticks);
                }
                else
                {

                    oAsistencia.Fecha = fecha;
                    oAsistencia.EntradaTurno = new DateTime();
                    oAsistencia.InicioDescanso = new DateTime();
                    oAsistencia.TerminoDescanso = new DateTime();
                    oAsistencia.SalidaTurno = new DateTime();
                    lstAsistencias.Add(oAsistencia);

                    fecha = fecha.AddDays(1);
                    continue;
                }

                oAsistencia.Fecha = fecha;

                oJustificacion = lstAuxiliarJustificaciones.Find(o => o.oConcepto.clave == "ET");
                if (oJustificacion != null)
                {
                    oAsistencia.EntradaTurno = oJustificacion.fecha_hora;
                    oAsistencia.JustificacionET = true;
                }
                else
                {
                    oAsistencia.EntradaTurno = ObtenerConceptoAsistencia(lstAuxiliar, "ET", MinMax.MIN);
                }

                oAsistencia.InicioDescanso = ObtenerConceptoAsistencia(lstAuxiliar, "DE", MinMax.MIN);
                oAsistencia.TerminoDescanso = ObtenerConceptoAsistencia(lstAuxiliar, "DE", MinMax.MAX);

                oJustificacion = lstAuxiliarJustificaciones.Find(o => o.oConcepto.clave == "ST");
                if (oJustificacion != null)
                {
                    oAsistencia.SalidaTurno = oJustificacion.fecha_hora;
                    oAsistencia.JustificacionST = true;
                }
                else
                {
                    if (oHorario.checa_dia_siguiente)
                    {
                        lstAuxiliar = lstChecadas.FindAll(o => o.fecha_hora.Date == fecha.AddDays(1));
                    }
                    oAsistencia.SalidaTurno = ObtenerConceptoAsistencia(lstAuxiliar, "ST", MinMax.MAX);
                }

                lstAsistencias.Add(oAsistencia);

                fecha = fecha.AddDays(1);
            }

            return lstAsistencias;
        }

        private DateTime? ObtenerConceptoAsistencia(List<Checada> lstChecadas, string clave_concepto, MinMax MM)
        {
            DateTime? Asistencia = null;

            if (clave_concepto == "DE" && MM == MinMax.MAX)
            {
                //**** Buscar si hay 2 o mas checadas de descanso
                if (lstChecadas.FindAll(o => o.oConcepto.clave == "DE").Count >= 2)
                {
                    Asistencia = lstChecadas.FindAll(o => o.oConcepto.clave == "DE").Max(p => p.fecha_hora);
                }
            }
            else
            {
                //**** Buscar si hay por lo menos una checada de ese concepto
                if (lstChecadas.FindAll(o => o.oConcepto.clave == clave_concepto).Count != 0)
                {
                    Asistencia = new DateTime();
                    switch (MM)
                    {
                        case MinMax.MIN:
                            Asistencia = lstChecadas.FindAll(o => o.oConcepto.clave == clave_concepto).Min(p => p.fecha_hora);
                            break;
                        case MinMax.MAX:
                            Asistencia = lstChecadas.FindAll(o => o.oConcepto.clave == clave_concepto).Max(p => p.fecha_hora);
                            break;
                    }
                }
            }

            return Asistencia;
        }

        private void InicializarTimePickers()
        {
            int anio = DateTime.Now.Year;
            int mes = DateTime.Now.Month;
            int ultimoDiaDelMes = DateTime.DaysInMonth(anio, mes);
            dtpInicial.Value = new DateTime(anio, mes, 1);
            dtpFinal.Value = DateTime.Now;
        }

        private void PreararFormulario()
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
            lblIdInterno.Text = oEmpleado.id_interno.ToString();
            lblNombre.Text = oEmpleado.nombre;
            InicializarTimePickers();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CrearReporte();
        }

        private void gridReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Asistencia oAsistencia;
            switch (e.KeyChar)
            {
                case 'j':
                case 'J':
                    // Justificar
                    if (validarPermiso("justificar") == false)
                    {
                        return;
                    }

                    oAsistencia = (Asistencia)gvReporte.GetFocusedRow();
                    FrmJustificar frmJustificar = new FrmJustificar(oAsistencia.Fecha, oEmpleado);
                    frmJustificar.ShowDialog();
                    CrearReporte();
                    break;
                case 'c':
                case 'C':
                    // Ver Checadas
                    oAsistencia = (Asistencia)gvReporte.GetFocusedRow();
                    FrmConsultarChecadasTodosChecadores frmConsultar = new FrmConsultarChecadasTodosChecadores(oAsistencia.Fecha, oEmpleado.id_interno);
                    frmConsultar.ShowDialog();
                    break;
            }
        }

        private bool validarPermiso(string permiso)
        {
            if (Configuracion.oUsuario.permisos.Contains(permiso))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Este usuario no tiene permiso para realizar esta accion.",
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
        }

        private List<VacacionFeriado> ObtenerJustificacionesMasivas()
        {
            DateTime fechaInicial = dtpInicial.Value.Date;
            DateTime fechaFinal = dtpFinal.Value.Date.AddDays(1);

            JustificacionesDAL DAL = new JustificacionesDAL();
            List<VacacionFeriado> lJustificacionesMasivas = new List<VacacionFeriado>();
            lJustificacionesMasivas = DAL.ObtenerFeriados(oEmpleado.id_interno, fechaInicial, fechaFinal);

            return lJustificacionesMasivas;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvReporte.RowCount != 0)
                {
                    DateTime fechaInicial = dtpInicial.Value.Date;
                    DateTime fechaFinal = dtpFinal.Value.Date;
                    List<Asistencia> lstAsistencias = (List<Asistencia>)gridReporte.DataSource;
                    ExcelExporter oExporter = new ExcelExporter();
                    bool bExito = oExporter.ExportarReporte(oReporte, fechaInicial, fechaFinal);
                    if (bExito)
                    {
                        MessageBox.Show("El reporte se ha exportado correctamente.",
                                        "",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                        if (oExporter.PATH != string.Empty)
                        {
                            System.Diagnostics.Process.Start(oExporter.PATH);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al exportar el reporte.",
                                        "",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message,
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
