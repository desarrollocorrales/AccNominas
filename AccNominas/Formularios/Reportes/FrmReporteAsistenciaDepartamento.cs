using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccAsistencia;
using AccAsistencia.DAL;
using AccAsistencia.Utilerias;
using System.IO;
using DevExpress.Spreadsheet;

namespace AccNominas.Formularios.Reportes
{
    public partial class FrmReporteAsistenciaDepartamento : Form
    {
        string path = string.Empty; string archivoNuevo = string.Empty; string path_Destino = string.Empty;
        private enum MinMax
        {
            MIN = 0,
            MAX = 1
        }

        public FrmReporteAsistenciaDepartamento()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            btnGenerar.Enabled = false;
            btnCancelar.Enabled = false;
            Generar();
            btnGenerar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void Generar()
        {
            StringBuilder sbMensaje = new StringBuilder();
            Departamento oDepartamento = (Departamento)cbDepartamentos.SelectedItem;
            DateTime dtInicio = dtpInicial.Value.Date;
            DateTime dtFinal = dtpFinal.Value.AddDays(1).Date;

            if (oDepartamento != null)
            {
                ExcelExporter oExporter = new ExcelExporter();

                EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL();

                List<Empleado> lstEmpleados = oEmpleadosDAL.ObtenerEmpleados();
                lstEmpleados = lstEmpleados.FindAll(o => o.departamento.Id == oDepartamento.Id);

                //Crea el nuevo documento .xlsx para llenarlo con los datos y no afectar el documento Original
                path = Environment.CurrentDirectory;
                archivoNuevo = @"\ReporteAsistencias" + DateTime.Now.ToString("yyyyMMddhhmmssss") + ".xlsx";
                path_Destino = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                CopyFile(path + "\\ReporteAsistencias.xlsx", path_Destino + archivoNuevo);

                if (lstEmpleados.Count != 0 && lstEmpleados != null)
                {
                    ReporteAsistencia oReporte;
                    progressBar1.Maximum = lstEmpleados.Count;
                    progressBar1.Value = 0;                  

                    foreach (Empleado oEmpleado in lstEmpleados)
                    {
                        progressBar1.Value++;
                        Application.DoEvents();

                        lblAccion.Text = (progressBar1.Value) + " / " + lstEmpleados.Count;
                        lblAccion.Text += " [" + oEmpleado.nombre + "]";
                        oReporte = CrearReporte(oEmpleado);
  
                        FormaOpenExcel(oReporte, dtInicio, dtFinal);
                    }

                    if (sbMensaje.ToString() != string.Empty)
                    {
                        MessageBox.Show(sbMensaje.ToString());
                    }

                    MessageBox.Show("Los reportes se han generado correctamente.",
                                    "",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);

                    sscReport.LoadDocument(path_Destino + archivoNuevo);
                    sscReport.Document.Worksheets["Hoja1"].Visible = false;
                    sscReport.SaveDocument(path_Destino + archivoNuevo);

                    lblAccion.Text = string.Empty;
                    progressBar1.Value = 0;

                    System.Diagnostics.Process.Start(path_Destino + archivoNuevo);

                    //if (oExporter.PATH != string.Empty)
                    //{
                    //    System.Diagnostics.Process.Start(oExporter.PATH);
                    //}
                }
                else
                {
                    MessageBox.Show("No hay empleados en el departamento: " + oDepartamento.Nombre);
                }              
            }
        }

        private void FormaOpenExcel(ReporteAsistencia oReporte, DateTime fi, DateTime ff)
        {
            try            
            {
                string nombre = string.Empty;
                if (oReporte.oEmpleado.nombre == "<PENDIENTE>" || oReporte.oEmpleado.nombre.Length > 31)
                    nombre = oReporte.oEmpleado.id_interno.ToString();
                else
                    nombre = oReporte.oEmpleado.nombre;

                //CARGA EL ARCHIVO .xlsx en el formulario                
                sscReport.LoadDocument(path_Destino + archivoNuevo);

                sscReport.Document.Worksheets.Insert(sscReport.Document.Worksheets.Count, nombre);  //                 Add(oReporte.oEmpleado.nombre);
                sscReport.Document.Worksheets[nombre].CopyFrom(sscReport.Document.Worksheets["Hoja1"]);

                InsertaEncabezado(sscReport.Document, fi, ff, nombre);
                InsertaLinea(sscReport.Document, oReporte, nombre);
                //sscReport.Document.Worksheets[0].Move(sscReport.Document.Worksheets.Count);

                sscReport.SaveDocument(path_Destino + archivoNuevo);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message,
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
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

        private void InsertaEncabezado(IWorkbook workbook, DateTime fi, DateTime ff, string hojaN)
        {
            workbook.BeginUpdate();
            try
            {
                Worksheet worksheet = workbook.Worksheets[hojaN];

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

        private void InsertaLinea(IWorkbook Libro, ReporteAsistencia oReporte, string hojaN)
        {
            try
            {
                Libro.BeginUpdate();
                try
                {
                    Worksheet Hoja = Libro.Worksheets[hojaN];
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

        private void FrmReporteAsistenciaDepartamento_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
            EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL();
            List<Departamento> lstDepartamentos = oEmpleadosDAL.ObtenerDepartamentos();
            if (lstDepartamentos.Count != 0)
            {
                DateTime hoy = DateTime.Now;
                dtpInicial.Value = new DateTime(hoy.Year, hoy.Month, 1);
                dtpFinal.Value = new DateTime(hoy.Year, hoy.Month, hoy.Day);
                lblAccion.Text = string.Empty;
                cbDepartamentos.DataSource = lstDepartamentos;
                cbDepartamentos.DisplayMember = "Nombre";
                cbDepartamentos.Refresh();
            }
            else
            {
                MessageBox.Show("No se encontro ningun departamento...");
                this.Close();
            }
        }

        private List<Asistencia> ObtenerAsistencias(List<Checada> lstChecadas,
                                                    List<Horario> lstHorarios,
                                                    List<Justificacion> lstJustificaciones,
                                                    Empleado oEmp)
        {    
            int iDia = 0;
            List<Asistencia> lstAsistencias = new List<Asistencia>();
            DateTime fechaInicial = dtpInicial.Value.Date;
            DateTime fecha = new DateTime(fechaInicial.Year, fechaInicial.Month, fechaInicial.Day);
            Asistencia oAsistencia = new Asistencia();
            Justificacion oJustificacion = new Justificacion();
            DateTime fechaFinal = dtpFinal.Value.Date;
            fechaFinal = fechaFinal.AddDays(1);
            List<VacacionFeriado> lFeriados = ObtenerJustificacionesMasivas(oEmp.id_interno);
            VacacionFeriado oFeriado;
            HorarioDAL HDAL = new HorarioDAL();

            while (fecha < fechaFinal)
            {
                /* Dia Completo Justificado */
                oFeriado = lFeriados.Find(o => o.fecha.Date == fecha && o.id_interno == oEmp.id_interno);
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
                Horario oHorarioDelDia = HDAL.obtenerHorarioDelDia(fecha, oEmp.id_interno);

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
                        if (oHorario.dias_que_no_aplica[Dia_De_Checada].Equals('0') == true)
                        {
                            oAsistencia.EntradaTurno = ObtenerConceptoAsistencia(lstAuxiliar, "ET", MinMax.MIN);
                        }
                    }
                    else
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

        private ReporteAsistencia CrearReporte(Empleado oEmpleado)
        {
            ReporteAsistencia oReporte = new ReporteAsistencia();
            oReporte.oEmpleado = oEmpleado;

            List<Horario> lstHorarios = oReporte.oEmpleado.lstHorarios;

            int id = oReporte.oEmpleado.id_interno;
            DateTime dtInicio = dtpInicial.Value.Date;
            DateTime dtFinal = dtpFinal.Value.AddDays(1).Date;

            ChecadasDAL oChecadasDAL =  new ChecadasDAL();
            List<Checada> lstChecadas = oChecadasDAL.ObtenerChecadas(id, dtInicio, dtFinal);

            JustificacionesDAL oJustificacionesDAL = new JustificacionesDAL();
            List<Justificacion> lstJustificaciones = oJustificacionesDAL.ObtenerJustificaciones(id, dtInicio, dtFinal);

            oReporte.lstAsistencias = ObtenerAsistencias(lstChecadas, lstHorarios, lstJustificaciones, oEmpleado);
            
            return oReporte;
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

        private List<VacacionFeriado> ObtenerJustificacionesMasivas(int id_interno)
        {
            DateTime fechaInicial = dtpInicial.Value.Date;
            DateTime fechaFinal = dtpFinal.Value.Date.AddDays(1);

            JustificacionesDAL DAL = new JustificacionesDAL();
            List<VacacionFeriado> lJustificacionesMasivas = new List<VacacionFeriado>();
            lJustificacionesMasivas = DAL.ObtenerFeriados(id_interno, fechaInicial, fechaFinal);

            return lJustificacionesMasivas;
        }
    }
}
