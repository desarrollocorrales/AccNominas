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
using DevExpress.Spreadsheet;
using System.IO;

namespace AccNominas.Formularios.Reportes
{
    public partial class FrmReporteAsistencia : Form
    {
        private Empleado oEmpleado; 
        private ReporteAsistencia oReporte;
        private int MinutosEx = 0;
        string path = string.Empty; string archivoNuevo = string.Empty; string path_Destino = string.Empty;
        private enum MinMax
        {
            MIN = 0,
            MAX = 1
        }

        public FrmReporteAsistencia(Empleado pEmpleado)
        {
            InitializeComponent();
            this.oEmpleado = pEmpleado;
        }

        private void FrmReporteAsistencia_Load(object sender, EventArgs e)
        {
            InicializarTimePickers();
            PreararFormulario();     
        }

        private void InicializarTimePickers()
        {
            int anio = DateTime.Now.Year;
            int mes = DateTime.Now.Month;
            int ultimoDiaDelMes = DateTime.DaysInMonth(anio, mes);
            dtpInicial.Value = new DateTime(anio, mes, 1);
            dtpFinal.Value = DateTime.Now;
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
                oChecadasDAL.ObtenerChecadas(id, dtInicio, dtFinal);

            JustificacionesDAL oJustificacionesDAL = new JustificacionesDAL();
            List<Justificacion> lstJustificaciones =
                oJustificacionesDAL.ObtenerJustificaciones(id, dtInicio, dtFinal);

            oReporte.lstAsistencias = 
                ObtenerAsistencias(lstChecadas, oEmpleado, lstJustificaciones);

                      
        }

        private List<Asistencia> ObtenerAsistencias
            (List<Checada> lstChecadas, Empleado oEmp, List<Justificacion> lstJustificaciones)
        {
            int iDia = 0;
            List<Asistencia> lstAsistencias = new List<Asistencia>();
            DateTime fechaInicial = dtpInicial.Value.Date;
            DateTime fecha = new DateTime(fechaInicial.Year, fechaInicial.Month, fechaInicial.Day);
            Asistencia oAsistencia = new Asistencia();
            Justificacion oJustificacion = new Justificacion();
            DateTime fechaFinal = dtpFinal.Value.Date;
            fechaFinal = fechaFinal.AddDays(1);
            List<VacacionFeriado> lFeriados = ObtenerJustificacionesMasivas();
            VacacionFeriado oFeriado;
            HorarioDAL HDAL = new HorarioDAL();

            while (fecha < fechaFinal)
            {
                /* Dia Completo Justificado */
                oFeriado = lFeriados.Find(o => o.fecha.Date == fecha && o.id_interno == oEmpleado.id_interno);
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
                              int Dia_De_Checada = fecha.DayOfWeek.GetHashCode();
                List<Checada> lstAuxiliar = new List<Checada>();
                lstAuxiliar = lstChecadas.FindAll(o => o.fecha_hora.Date == fecha);

                List<Justificacion> lstAuxiliarJustificaciones = new List<Justificacion>();
                lstAuxiliarJustificaciones = lstJustificaciones.FindAll(o => o.fecha_hora.Date == fecha);

                oAsistencia = new Asistencia();
                oJustificacion = new Justificacion();
                Horario oHorario = new Horario();
                Horario oHorarioDelDia = HDAL.obtenerHorarioDelDia(fecha, oEmpleado.id_interno);
                
                //****************************************************************
                //***** DIAS QUE NO APLICA 
                if (oHorarioDelDia != null)
                {
                    iDia = fecha.DayOfWeek.GetHashCode();
                    if (oHorarioDelDia.dias_que_no_aplica[iDia].Equals('1'))
                        oHorarioDelDia = null;
                }
                //****************************************************************

                if (oHorarioDelDia != null)
                {
                    oHorario = oHorarioDelDia;
                    if (oHorario.dias_que_no_aplica[Dia_De_Checada].Equals('0') == true)
                    {
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
                    if (oHorario.checa_dia_siguiente)
                    {
                        if (oHorario.dias_que_no_aplica[Dia_De_Checada].Equals('0')==true)
                        {
                            oAsistencia.EntradaTurno = ObtenerConceptoAsistencia(lstAuxiliar, "ET", MinMax.MIN);
                        }
                    }
                    else
                        oAsistencia.EntradaTurno = ObtenerConceptoAsistencia(lstAuxiliar, "ET", MinMax.MIN);
                }
                
                oAsistencia.InicioDescanso = ObtenerConceptoAsistencia(lstAuxiliar, "DE", MinMax.MIN);
                oAsistencia.TerminoDescanso = ObtenerConceptoAsistencia(lstAuxiliar,"DE", MinMax.MAX);

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

        private DateTime? ObtenerConceptoAsistencia(
            List<Checada> lstChecadas, string clave_concepto, MinMax MM)
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

        private void PreararFormulario()
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
            lblIdInterno.Text = oEmpleado.id_interno.ToString();
            lblNombre.Text = oEmpleado.nombre;
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

                    imgLoading.Visible = true;

                    oAsistencia = (Asistencia)gvReporte.GetFocusedRow();

                    Application.DoEvents();

                    new FrmJustificar(oAsistencia.Fecha, oEmpleado).ShowDialog();

                    bkgCalcular.RunWorkerAsync();

                    break;
                case 'c':
                case 'C':
                    // Ver Checadas

                    imgLoading.Visible = true;
                    Application.DoEvents();

                    oAsistencia = (Asistencia)gvReporte.GetFocusedRow();
                    new FrmConsultarChecadas(oAsistencia.Fecha, oEmpleado.id_interno).ShowDialog();

                    imgLoading.Visible = false;

                    break;
            }
        }        

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                FormaOpenExcel(oReporte.lstAsistencias);
                //if (gvReporte.RowCount != 0)
                //{
                //    DateTime fechaInicial = dtpInicial.Value.Date;
                //    DateTime fechaFinal = dtpFinal.Value.Date;
                //    List<Asistencia> lstAsistencias = (List<Asistencia>)gridReporte.DataSource;
                //    ExcelExporter oExporter = new ExcelExporter();
                //    bool bExito = oExporter.ExportarReporte(oReporte, fechaInicial, fechaFinal);
                //    if (bExito)
                //    {
                //        MessageBox.Show("El reporte se ha exportado correctamente.",
                //                        "",
                //                        MessageBoxButtons.OK,
                //                        MessageBoxIcon.Exclamation);
                //        if (oExporter.PATH != string.Empty)
                //        {
                //            System.Diagnostics.Process.Start(oExporter.PATH);
                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("Ocurrio un error al exportar el reporte.",
                //                        "",
                //                        MessageBoxButtons.OK,
                //                        MessageBoxIcon.Error);
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message,
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;
            imgLoading.Visible = true;
            Application.DoEvents();

            bkgCalcular.RunWorkerAsync();

            oReporte = new ReporteAsistencia();
            oReporte.oEmpleado = oEmpleado;
            //calcula minutos
            MinutosEx = new ChecadasDAL().MinutosExcedido(oReporte.oEmpleado.id_interno, dtpInicial.Value.Date, dtpFinal.Value.AddDays(1).Date);  
            lblMinEx.Text = MinutosEx.ToString();

            //CrearReporte();

            //gvReporte.BestFitColumns();
            //btnCalcular.Enabled = true;
            //imgLoading.Visible = false;
            //Application.DoEvents();
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

        private void bkgCalcular_DoWork(object sender, DoWorkEventArgs e)
        {
            CrearReporte();            
        }

        private void bkgCalcular_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gridReporte.DataSource = oReporte.lstAsistencias;
            gridReporte.Refresh();
            gvReporte.BestFitColumns();
            btnCalcular.Enabled = true;
            imgLoading.Visible = false;
            
        }

        public string CopyFile(string source, string dest)
        {
            string result = "Copied file";
            try
            {
                // Overwrites existing files
                File.Copy(source, dest, true);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        private void FormaOpenExcel(List<Asistencia> lstAsistencia)
        {
            try{
                //Crea el nuevo documento .xlsx para llenarlo con los datos y no afectar el documento Original
                path = Environment.CurrentDirectory; 
                archivoNuevo = @"\ReporteAsistencias" + DateTime.Now.ToString("yyyyMMddhhmmssss") + ".xlsx";
                path_Destino = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                CopyFile(path + "\\ReporteAsistencias.xlsx", path_Destino + archivoNuevo);

                //CARGA EL ARCHIVO .xlsx en el formulario
                sscReport.LoadDocument(path_Destino + archivoNuevo);

                DateTime fechaInicial = dtpInicial.Value.Date;
                DateTime fechaFinal = dtpFinal.Value.Date;
                InsertaEncabezado(sscReport.Document, fechaInicial, fechaFinal);
                InsertaLinea(sscReport.Document, oReporte, MinutosEx);

                sscReport.SaveDocument(path_Destino + archivoNuevo);
                MessageBox.Show("El documento se ha creado con exito", "OK",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(path_Destino + archivoNuevo);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message,
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void InsertaEncabezado(IWorkbook workbook, DateTime fi, DateTime ff)
        {
            workbook.BeginUpdate();
            try
            {
                Worksheet worksheet = workbook.Worksheets["Hoja1"];

                worksheet.Cells["B2"].Value = "DEL  " + fi.ToString("dd/MMMM/yyyy").ToUpper() + "  AL  " + ff.ToString("dd/MMMM/yyyy").ToUpper();
                worksheet.Cells["B2"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                //worksheet.Cells["B2"].Font.FontStyle = SpreadsheetFontStyle.Bold;
                worksheet.Cells["B2"].Font.Size = 10;
                //worksheet.Cells["B2"].FillColor = Color.Coral;

                worksheet.Cells["E3"].Value = DateTime.Now.ToString("dd/MMMM/yyyy").ToUpper();
                worksheet.Cells["E3"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Right;
                worksheet.Cells["E3"].Font.FontStyle = SpreadsheetFontStyle.Bold;
                worksheet.Cells["E3"].Font.Size = 10;
                //worksheet.Cells["F3"].FillColor = Color.LightGray;

                sscReport.Document.Worksheets[0].FreezeRows(0);
                sscReport.Document.Worksheets[0].FreezeRows(1);
            }
            catch (Exception x)
            { throw x; }
            finally
            {
                workbook.EndUpdate();
            }
        }

        private void InsertaLinea(IWorkbook Libro, ReporteAsistencia oReporte, int minutosExcedido)
        {
            try
            {
                Libro.BeginUpdate();
                try
                {
                    Worksheet Hoja = Libro.Worksheets[0];
                    Hoja.Cells["C4"].Value = oReporte.oEmpleado.id_interno;
                    Hoja.Cells["C4"].FillColor = Color.LightGray;
                    //Hoja.Cells["C4"].Font.FontStyle = SpreadsheetFontStyle.Bold;
                    Hoja.Cells["C4"].Font.Size = 10;

                    Hoja.Cells["C5"].Value = oReporte.oEmpleado.nombre;
                    Hoja.Cells["C5"].FillColor = Color.LightGray;
                    Hoja.Cells["C5"].Font.FontStyle = SpreadsheetFontStyle.Bold;
                    Hoja.Cells["C5"].Font.Size = 10;

                    int i; int iMinutosRetraso = 0; int iFaltas = 0; Asistencia oAsistencia;
                    for (i = 0; i < oReporte.lstAsistencias.Count; i++)
                    {
                        //if ((i % 2) != 0)
                        //{ Hoja.Cells["B" + (8 + i).ToString()].FillColor = Color.FromArgb(235, 235, 235); }

                        oAsistencia = oReporte.lstAsistencias[i];
                        Cell cellB = Hoja.Cells["B" + (8 + i).ToString()];
                        cellB.Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Dashed);
                        cellB.Value = oAsistencia.Fecha.ToString("dd/MM/yyyy").ToString();

                        #region **** Titulo Encabezado Entrada de turno
                        Cell cellC = Hoja.Cells["C" + (8 + i).ToString()];
                        cellC.Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Dashed);
                        if (oAsistencia.EntradaTurno != null)
                        {
                            if (oAsistencia.EntradaTurno.Value.TimeOfDay > oAsistencia.EntradaTurnoOficial.TimeOfDay)
                            {
                                cellC.Font.Color = Color.Red;
                                iMinutosRetraso += Convert.ToInt32((oAsistencia.EntradaTurno.Value.TimeOfDay
                                                    - oAsistencia.EntradaTurnoOficial.TimeOfDay).TotalMinutes);
                            }
                            else if (oAsistencia.JustificacionET == true)
                            {
                                cellC.Font.Color = Color.DarkBlue;
                            }

                            if (oAsistencia.Fecha == oAsistencia.EntradaTurno)
                                cellC.Value = oAsistencia.sEntradaTurno;
                            else
                            {
                                if (oAsistencia.EntradaTurno == new DateTime())
                                {
                                    cellC.FillColor = Color.DarkGray;
                                    cellC.Value = "Descanso";
                                }
                                else
                                {
                                    cellC.Value = oAsistencia.EntradaTurno.Value.ToString("dd/MM/yyyy HH:mm");
                                }
                            }
                        }
                        else
                        {
                            cellC.Font.Color = Color.Red;
                            cellC.Value = oAsistencia.sEntradaTurno;
                        }
                        #endregion

                        #region**** Titulo Encabezado Inicio Descanso
                        Cell cellD = Hoja.Cells["D" + (8 + i).ToString()];
                        cellD.Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Dashed);
                        cellD.NumberFormat = "@";
                        if (oAsistencia.InicioDescanso != null)
                        {
                            if (oAsistencia.Fecha == oAsistencia.InicioDescanso)
                                cellD.Value = oAsistencia.sInicioDescanso;
                            else
                            {
                                if (oAsistencia.InicioDescanso == new DateTime())
                                {
                                    cellD.FillColor = Color.DarkGray;
                                    cellD.Value = "Descanso";
                                }
                                else
                                {
                                    cellD.Value = oAsistencia.InicioDescanso.Value.ToString("dd/MM/yyyy HH:mm");
                                }
                            }
                        }
                        #endregion

                        #region **** Titulo Encabezado Termino Descanso
                        Cell cellE = Hoja.Cells["E" + (8 + i).ToString()];
                        cellE.Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Dashed);
                        cellE.NumberFormat = "@";
                        if (oAsistencia.TerminoDescanso != null)
                        {
                            if (oAsistencia.Fecha == oAsistencia.TerminoDescanso)
                                cellE.Value = oAsistencia.sTerminoDescanso;
                            else
                                if (oAsistencia.TerminoDescanso == new DateTime())
                                {
                                    cellE.FillColor = Color.DarkGray;
                                    cellE.Value = "Descanso";
                                }
                                else
                                {
                                    cellE.Value = oAsistencia.TerminoDescanso.Value.ToString("dd/MM/yyyy HH:mm");
                                }
                        }
                        #endregion

                        #region ****Titulo Encabezado Salida de turno
                        Cell cellF = Hoja.Cells["F" + (8 + i).ToString()];
                        cellF.Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Dashed);
                        cellF.NumberFormat = "@";
                        if (oAsistencia.SalidaTurno != null)
                        {
                            if (oAsistencia.SalidaTurno.Value.TimeOfDay < oAsistencia.SalidaTurnoOficial.TimeOfDay)
                            {
                                cellF.Font.Color = Color.Red;
                                iMinutosRetraso += Convert.ToInt32((oAsistencia.SalidaTurnoOficial.TimeOfDay
                                                    - oAsistencia.SalidaTurno.Value.TimeOfDay).TotalMinutes);
                            }
                            else if (oAsistencia.JustificacionST == true)
                            {
                                cellF.Font.Color = Color.DarkBlue;
                            }

                            if (oAsistencia.Fecha == oAsistencia.SalidaTurno)
                                cellF.Value = oAsistencia.sSalidaTurno;
                            else
                            {
                                if (oAsistencia.SalidaTurno == new DateTime())
                                {
                                    cellF.FillColor = Color.DarkGray;
                                    cellF.Value = "Descanso";
                                }
                                else
                                {
                                    cellF.Value = oAsistencia.SalidaTurno.Value.ToString("dd/MM/yyyy HH:mm");
                                }
                            }
                        }
                        else
                        {
                            cellF.Font.Color = Color.Red;
                            cellF.Value = oAsistencia.sSalidaTurno;
                        }
                        #endregion

                        if (oAsistencia.EntradaTurno.HasValue == false)
                        {
                            if (oAsistencia.SalidaTurno.HasValue == false)
                            {
                                iFaltas++;
                            }
                        }
                    }

                    /* Minutos de retraso */
                    Hoja.MergeCells(Hoja.Range["B" + (9 + i).ToString() + ":E" + (9 + i).ToString()]);
                    Hoja.Cells["B" + (9 + i).ToString()].Value = "Minutos de retraso acumulados en el período:";
                    Hoja.Cells["F" + (9 + i).ToString()].Font.Bold = true;
                    Hoja.Cells["F" + (9 + i).ToString()].Value = iMinutosRetraso;
                    /* Faltas */
                    Hoja.MergeCells(Hoja.Range["B" + (10 + i).ToString() + ":E" + (10 + i).ToString()]);
                    Hoja.Cells["B" + (10 + i).ToString()].Value = "Faltas en el período:";
                    Hoja.Cells["F" + (10 + i).ToString()].Font.Bold = true;
                    Hoja.Cells["F" + (10 + i).ToString()].Value = iFaltas;
                }
                finally
                {
                    Libro.EndUpdate();
                }
            }
            catch (Exception x)
            { throw x; }
        }
    }
}
