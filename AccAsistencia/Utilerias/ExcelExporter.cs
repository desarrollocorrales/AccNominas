using System;
using System.Drawing;
using System.IO;
using System.Text;
using Microsoft.Office.Interop.Excel;

namespace AccAsistencia.Utilerias
{
    public class ExcelExporter
    {
        private enum TipoAsistencia
        {
            EntradaTurno=0, InicioDescanso=1, 
        }
        private Application ExcelApp;
        private Workbook oWorkbook;
        private Worksheet oWorksheet;
        public string PATH;

        public bool ExportarReporte(ReporteAsistencia oReporte, DateTime dtInicio, DateTime dtFinal)
        {
            try
            {
                AbrirAplicacion();
                PrepararDocumento(dtInicio, dtFinal);
                GenerarReporte(oReporte);
                GuardarDocumento(oReporte);
                CerrarAplicacion();
                return true;
            }
            catch(Exception e)
            {
                CerrarAplicacion();
                return false;
            }      
        }

        private void AbrirAplicacion()
        {
            ExcelApp = new Application();
            if (ExcelApp == null)
            {
                LogManager.AgregarLog("Ocurrio un error con excel. No es posible crear la aplicacion");
                return;
            }

            oWorkbook = ExcelApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            oWorksheet = (Worksheet)oWorkbook.Worksheets[1];
            if (oWorksheet == null)
            {
                LogManager.AgregarLog("Ocurrio un error con excel. No es posible crear la Hoja");
            }
        }
        private void CerrarAplicacion()
        {
            if (oWorkbook != null)
            {
                oWorkbook.Close();
                ExcelApp.Workbooks.Close();
                ExcelApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(oWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(ExcelApp.Workbooks);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(ExcelApp);
            }
            oWorkbook = null;
            ExcelApp = null;

            System.GC.Collect();

        }
        private void PrepararDocumento(DateTime dtInicio, DateTime dtFin)
        {
            //**** Hacer la primer columna  de un ancho de 40 pixeles
            Range oCeldasExcel = oWorksheet.Cells[1, 1];
            oCeldasExcel.EntireColumn.ColumnWidth = 5;

            //**** Titulo REPORTE DE ASISTENCIAS
            oCeldasExcel = oWorksheet.Range[oWorksheet.Cells[1, 2], oWorksheet.Cells[1, 6]];
            oCeldasExcel.Merge();
            oCeldasExcel.Font.Bold = true;
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            oCeldasExcel.Value2 = "REPORTE DE ASISTENCIAS";

            //**** Titulo REPORTE DE ASISTENCIAS
            oCeldasExcel = oWorksheet.Range[oWorksheet.Cells[2, 2], oWorksheet.Cells[2, 6]];
            oCeldasExcel.Merge();
            oCeldasExcel.Font.Bold = true;
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            oCeldasExcel.Value2 =
                "DEL  " + dtInicio.ToString("dd/MMMM/yyyy").ToUpper() +
                "  AL  " + dtFin.ToString("dd/MMMM/yyyy").ToUpper();

            //** Fecha del reporte
            oCeldasExcel = oWorksheet.Cells[3, 6];
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignRight;
            oCeldasExcel.Value2 = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            //**** Titulo ID Interno:
            oCeldasExcel = oWorksheet.Cells[4, 2];
            oCeldasExcel.Font.Bold = true;
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignRight;
            oCeldasExcel.Value2 = "ID Interno:";

            //**** Titulo Nombre:
            oCeldasExcel = oWorksheet.Cells[5, 2];
            oCeldasExcel.Font.Bold = true;
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignRight;
            oCeldasExcel.Value2 = "Nombre:";

            //**** Titulo Encabezado Fecha
            oCeldasExcel = oWorksheet.Cells[7, 2];
            oCeldasExcel.BorderAround();
            oCeldasExcel.Value2 = "Fecha";
            //**** Titulo Encabezado Entrada de turno
            oCeldasExcel = oWorksheet.Cells[7, 3];
            oCeldasExcel.BorderAround();
            oCeldasExcel.ColumnWidth = 16.71;
            oCeldasExcel.Value2 = "Entrada de turno";
            //**** Titulo Encabezado Inicio Descanso
            oCeldasExcel = oWorksheet.Cells[7, 4];
            oCeldasExcel.BorderAround();
            oCeldasExcel.ColumnWidth = 16.71;
            oCeldasExcel.Value2 = "Inicio Descanso";
            //**** Titulo Encabezado Termino Descanso
            oCeldasExcel = oWorksheet.Cells[7, 5];
            oCeldasExcel.BorderAround();
            oCeldasExcel.ColumnWidth = 16.71;
            oCeldasExcel.Value2 = "Termino Descanso";
            //**** Titulo Encabezado Salida de turno
            oCeldasExcel = oWorksheet.Cells[7, 6];
            oCeldasExcel.BorderAround();
            oCeldasExcel.ColumnWidth = 16.71;
            oCeldasExcel.Value2 = "Salida de turno";
            //**** Formato a Encabezados
            oCeldasExcel = oWorksheet.Range[oWorksheet.Cells[7, 2], oWorksheet.Cells[7, 6]];
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            oCeldasExcel.Font.Bold = true;
            oCeldasExcel.Font.Color = Color.White;
            oCeldasExcel.Interior.Color = Color.FromArgb(190, 0, 0);
        }
        private void GuardarDocumento(ReporteAsistencia oReporte)
        {
            StringBuilder sPath = new StringBuilder();
            sPath.Append(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            sPath.Append("\\ReportesAsistencia\\" + Configuracion.oChecador.Nombre);
            sPath.Append("\\" + oReporte.oEmpleado.departamento.Nombre);
            PATH = sPath.ToString();

            if (Directory.Exists(sPath.ToString()) == false)
            {
                Directory.CreateDirectory(sPath.ToString());
            }
            if (File.Exists(PATH + "\\" + oReporte.oEmpleado.nombre.Replace("/", " ") + ".xlsx"))
            {
                File.Delete(PATH + "\\" + oReporte.oEmpleado.nombre.Replace("/"," ") + ".xlsx");
            }

            oWorkbook.SaveAs(PATH + "\\" + oReporte.oEmpleado.nombre.Replace("/", " ") + ".xlsx");
        }
        private void GenerarReporte(ReporteAsistencia oReporte)
        {
            Range oCeldasExcel;

            //**** Id interno del empleado.
            oCeldasExcel = oWorksheet.Range[oWorksheet.Cells[4, 3], oWorksheet.Cells[4, 6]];
            oCeldasExcel.Merge();
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignLeft;
            oCeldasExcel.Value2 = oReporte.oEmpleado.id_interno;

            //**** Nombre del empleado.
            oCeldasExcel = oWorksheet.Range[oWorksheet.Cells[5, 3], oWorksheet.Cells[5, 6]];
            oCeldasExcel.Merge();
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignLeft;
            oCeldasExcel.Value2 = oReporte.oEmpleado.nombre;

            int i;
            int iMinutosRetraso = 0;
            int iFaltas = 0;
            Asistencia oAsistencia;
            for (i = 0; i < oReporte.lstAsistencias.Count; i++)
            {
                //**** Formato renglon
                oCeldasExcel = oWorksheet.Range[oWorksheet.Cells[8 + i, 2], oWorksheet.Cells[8 + i, 6]];
                oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                if ((i % 2) != 0)
                {
                    oCeldasExcel.Interior.Color = Color.FromArgb(235, 235, 235);
                }

                oAsistencia = oReporte.lstAsistencias[i];
                //**** Titulo Encabezado Fecha
                oCeldasExcel = oWorksheet.Cells[i + 8, 2];
                oCeldasExcel.BorderAround();
                oCeldasExcel.NumberFormat = "@";
                oCeldasExcel.Value2 = oAsistencia.Fecha.ToString("dd/MM/yyyy").ToString();
                //**** Titulo Encabezado Entrada de turno
                oCeldasExcel = oWorksheet.Cells[i + 8, 3];
                oCeldasExcel.BorderAround();
                oCeldasExcel.NumberFormat = "@";
                if (oAsistencia.EntradaTurno != null)
                {
                    if (oAsistencia.EntradaTurno.Value.TimeOfDay > oAsistencia.EntradaTurnoOficial.TimeOfDay)
                    {
                        oCeldasExcel.Font.Color = Color.Red;
                        iMinutosRetraso += Convert.ToInt32((oAsistencia.EntradaTurno.Value.TimeOfDay
                                            - oAsistencia.EntradaTurnoOficial.TimeOfDay).TotalMinutes);
                    }
                    else if (oAsistencia.JustificacionET == true)
                    {
                        oCeldasExcel.Font.Color = Color.DarkBlue;
                    }

                    if (oAsistencia.Fecha == oAsistencia.EntradaTurno)
                        oCeldasExcel.Value2 = oAsistencia.sEntradaTurno;
                    else
                        oCeldasExcel.Value2 = ObtenerValor(oAsistencia.EntradaTurno, ref oCeldasExcel);
                }
                else
                {
                    oCeldasExcel.Font.Color = Color.Red;
                    oCeldasExcel.Value2 = oAsistencia.sEntradaTurno;
                }
                //**** Titulo Encabezado Inicio Descanso
                oCeldasExcel = oWorksheet.Cells[i + 8, 4];
                oCeldasExcel.BorderAround();
                oCeldasExcel.NumberFormat = "@";
                if (oAsistencia.InicioDescanso != null)
                {
                    if (oAsistencia.Fecha == oAsistencia.InicioDescanso)
                        oCeldasExcel.Value2 = oAsistencia.sInicioDescanso;
                    else
                        oCeldasExcel.Value2 = ObtenerValor(oAsistencia.InicioDescanso, ref oCeldasExcel);
                }
                //**** Titulo Encabezado Termino Descanso
                oCeldasExcel = oWorksheet.Cells[i + 8, 5];
                oCeldasExcel.BorderAround();
                oCeldasExcel.NumberFormat = "@";
                if (oAsistencia.TerminoDescanso != null)
                {
                    if (oAsistencia.Fecha == oAsistencia.TerminoDescanso)
                        oCeldasExcel.Value2 = oAsistencia.sTerminoDescanso;
                    else
                        oCeldasExcel.Value2 = ObtenerValor(oAsistencia.TerminoDescanso, ref oCeldasExcel);
                }
                //**** Titulo Encabezado Salida de turno
                oCeldasExcel = oWorksheet.Cells[i + 8, 6];
                oCeldasExcel.BorderAround();
                oCeldasExcel.NumberFormat = "@";
                if (oAsistencia.SalidaTurno != null)
                {
                    if (oAsistencia.SalidaTurno.Value.TimeOfDay < oAsistencia.SalidaTurnoOficial.TimeOfDay)
                    {
                        oCeldasExcel.Font.Color = Color.Red;
                        iMinutosRetraso += Convert.ToInt32((oAsistencia.SalidaTurnoOficial.TimeOfDay
                                            - oAsistencia.SalidaTurno.Value.TimeOfDay).TotalMinutes);
                    }
                    else if (oAsistencia.JustificacionST == true)
                    {
                        oCeldasExcel.Font.Color = Color.DarkBlue;
                    }

                    if (oAsistencia.Fecha == oAsistencia.SalidaTurno)
                        oCeldasExcel.Value2 = oAsistencia.sSalidaTurno;
                    else
                        oCeldasExcel.Value2 = ObtenerValor(oAsistencia.SalidaTurno, ref oCeldasExcel);
                }
                else
                {
                    oCeldasExcel.Font.Color = Color.Red;
                    oCeldasExcel.Value2 = oAsistencia.sSalidaTurno;
                }
                
                if (oAsistencia.EntradaTurno.HasValue == false)
                {
                    if (oAsistencia.SalidaTurno.HasValue == false)
                    {
                        iFaltas++;
                    }
                }
            }

            /* Minutos de retraso */

            oCeldasExcel = oWorksheet.Range[oWorksheet.Cells[9 + i, 2], oWorksheet.Cells[9 + i, 5]];
            oCeldasExcel.Merge();
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignRight;
            oCeldasExcel.Value2 = "Minutos de retraso acumulados en el período:";
            oCeldasExcel = oWorksheet.Cells[9 + i, 6];
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignLeft;
            oCeldasExcel.Font.Bold = true;
            oCeldasExcel.Value2 = iMinutosRetraso;

            /* Faltas */
            oCeldasExcel = oWorksheet.Range[oWorksheet.Cells[10 + i, 2], oWorksheet.Cells[10 + i, 5]];
            oCeldasExcel.Merge();
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignRight;
            oCeldasExcel.Value2 = "Faltas en el período:";
            oCeldasExcel = oWorksheet.Cells[10 + i, 6];
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignLeft;
            oCeldasExcel.Font.Bold = true;
            oCeldasExcel.Value2 = iFaltas;
        }

        private string ObtenerValor(DateTime? parametro, ref Range oCeldasExcel)
        {
            if (parametro == new DateTime())
            {
                oCeldasExcel.Interior.Color = Color.DarkGray;
                return "Descanso";
            }
            else
            {
                return parametro.Value.ToString("dd/MM/yyyy HH:mm");
            }
        }

        public bool ExportarReporteJustificaciones(ReporteJustificaciones oRepor)
        {
            try
            {
                AbrirAplicacion();
                PrepararDocumento(oRepor);
                GenerarReporte(oRepor);
                GuardarDocumento(oRepor);
                CerrarAplicacion();
                return true;
            }
            catch
            {
                CerrarAplicacion();
                return false;
            } 
        }
        private void PrepararDocumento(ReporteJustificaciones oRepor)
        {
            oWorksheet.PageSetup.PaperSize = XlPaperSize.xlPaperLetter;
            oWorksheet.PageSetup.Orientation = XlPageOrientation.xlLandscape;

            Range oCeldasExcel;
            //**** Hacer la primer columna  de un ancho de 115 pixeles
            oCeldasExcel = oWorksheet.Cells[1, 1];
            oCeldasExcel.EntireColumn.ColumnWidth = 15.71;
            //**** Hacer la segunda columna  de un ancho de 75 pixeles
            oCeldasExcel = oWorksheet.Cells[1, 2];
            oCeldasExcel.EntireColumn.ColumnWidth = 10;
            //**** Hacer la tercera columna  de un ancho de 70 pixeles
            oCeldasExcel = oWorksheet.Cells[1, 3];
            oCeldasExcel.EntireColumn.ColumnWidth = 9.29;
            //**** Hacer la cuarta columna  de un ancho de 430 pixeles
            oCeldasExcel = oWorksheet.Cells[1, 4];
            oCeldasExcel.EntireColumn.ColumnWidth = 60.71;
            //**** Hacer la quinta columna  de un ancho de 175 pixeles
            oCeldasExcel = oWorksheet.Cells[1, 5];
            oCeldasExcel.EntireColumn.ColumnWidth = 24.29;

            //**** Titulo
            oCeldasExcel = oWorksheet.Range[oWorksheet.Cells[1, 1], oWorksheet.Cells[1, 5]];
            oCeldasExcel.Merge();
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            oCeldasExcel.Font.Bold = true;
            oCeldasExcel.Value2 = "REPORTE DE JUSTIFICACIONES";
            //**** Periodo
            oCeldasExcel = oWorksheet.Range[oWorksheet.Cells[2, 1], oWorksheet.Cells[2, 5]];
            oCeldasExcel.Merge();
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            oCeldasExcel.Font.Bold = true;
            oCeldasExcel.Value2 = 
                string.Format("DEL  {0}  AL  {1}", 
                              oRepor.dtInicio.ToString("dd/MMMM/yyyy"),
                              oRepor.dtFin.ToString("dd/MMMM/yyyy")).ToUpper();
            //**** Fecha
            oCeldasExcel = oWorksheet.Range[oWorksheet.Cells[3, 1], oWorksheet.Cells[3, 5]];
            oCeldasExcel.Merge();
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignRight;
            oCeldasExcel.Value2 = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");

            //**** Id Interno
            oCeldasExcel = oWorksheet.Cells[4, 1];
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignRight;
            oCeldasExcel.Font.Bold = true;
            oCeldasExcel.Value2 = "Id Interno:";
            //**** Id Interno Valor
            oCeldasExcel = oWorksheet.Range[oWorksheet.Cells[4, 2], oWorksheet.Cells[4, 5]];
            oCeldasExcel.Merge();
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignLeft;
            oCeldasExcel.Value2 = oRepor.oEmpleado.id_interno;

            //**** Nombre
            oCeldasExcel = oWorksheet.Cells[5, 1];
            oCeldasExcel.Font.Bold = true;
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignRight;
            oCeldasExcel.Value2 = "Nombre:";
            //****  Nombre Valor
            oCeldasExcel = oWorksheet.Range[oWorksheet.Cells[5, 2], oWorksheet.Cells[5, 5]];
            oCeldasExcel.Merge();
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignLeft;
            oCeldasExcel.Value2 = oRepor.oEmpleado.nombre;
        }
        private void GuardarDocumento(ReporteJustificaciones oRepor)
        {
            StringBuilder sPath = new StringBuilder();
            sPath.Append(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            sPath.Append("\\ReportesJustificaciones\\" + Configuracion.oChecador.Nombre);
            sPath.Append("\\" + oRepor.oEmpleado.departamento.Nombre);
            PATH = sPath.ToString();

            if (Directory.Exists(sPath.ToString()) == false)
            {
                Directory.CreateDirectory(sPath.ToString());
            }
            if (File.Exists(sPath + "\\Justificaciones_" + oRepor.oEmpleado.nombre + ".xlsx"))
            {
                File.Delete(sPath + "\\Justificaciones_" + oRepor.oEmpleado.nombre + ".xlsx");
            }

            oWorkbook.SaveAs(sPath + "\\Justificaciones_" + oRepor.oEmpleado.nombre + ".xlsx");
        }
        private void GenerarReporte(ReporteJustificaciones oRepor)
        {
            Range oCeldasExcel;
            //**** Titulo Tabla ****
            oCeldasExcel = oWorksheet.Cells[7, 1];
            oCeldasExcel.Font.Size = 10;
            oCeldasExcel.Value2 = "Concepto";
            //**** Titulo Tabla ****
            oCeldasExcel = oWorksheet.Cells[7, 2];
            oCeldasExcel.Font.Size = 10;
            oCeldasExcel.Value2 = "Fecha";
            //**** Titulo Tabla ****
            oCeldasExcel = oWorksheet.Cells[7, 3];
            oCeldasExcel.Font.Size = 10;
            oCeldasExcel.Value2 = "Hora";
            //**** Titulo Tabla ****
            oCeldasExcel = oWorksheet.Cells[7, 4];
            oCeldasExcel.Font.Size = 10;
            oCeldasExcel.Value2 = "Detalles";
            //**** Titulo Tabla ****
            oCeldasExcel = oWorksheet.Cells[7, 5];
            oCeldasExcel.Font.Size = 10;
            oCeldasExcel.Value2 = "Autorizado por";
            //**** Formato a titulos de tabla
            int i;
            for (i = 1; i <= 5; i++)
            {
                oCeldasExcel = oWorksheet.Cells[7, i];
                oCeldasExcel.BorderAround();   
            }
            oCeldasExcel = oWorksheet.Range[oWorksheet.Cells[7, 1], oWorksheet.Cells[7, 5]];
            oCeldasExcel.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            oCeldasExcel.Interior.Color = Color.FromArgb(190, 0, 0);
            oCeldasExcel.Font.Color = Color.White;
            oCeldasExcel.Font.Bold = true;

            i = 0;
            foreach (Justificacion j in oRepor.lstJustificaciones)
            {
                if ((i % 2) == 1)
                {
                    oCeldasExcel = oWorksheet.Range[oWorksheet.Cells[8 + i, 1], oWorksheet.Cells[8 + i, 5]];
                    oCeldasExcel.Interior.Color = Color.FromArgb(235, 235, 235);
                }
                //***** Concepto
                oCeldasExcel = oWorksheet.Cells[8 + i, 1];                
                oCeldasExcel.Value2 = j.oConcepto.descripcion;
                oCeldasExcel.Font.Size = 10;
                oCeldasExcel.BorderAround();

                //***** Fecha
                oCeldasExcel = oWorksheet.Cells[8 + i, 2];
                oCeldasExcel.Value2 = j.fecha_hora.ToString("dd/MM/yyyy");
                oCeldasExcel.Font.Size = 10;
                oCeldasExcel.BorderAround();

                //***** Hora
                oCeldasExcel = oWorksheet.Cells[8 + i, 3];
                oCeldasExcel.Value2 = j.fecha_hora.ToString("hh:mm tt");
                oCeldasExcel.Font.Size = 10;
                oCeldasExcel.BorderAround();

                //***** Detalles
                oCeldasExcel = oWorksheet.Cells[8 + i, 4];
                oCeldasExcel.Value2 = j.detalle;
                oCeldasExcel.Font.Size = 10;
                oCeldasExcel.BorderAround();

                //***** Autorizado Por
                oCeldasExcel = oWorksheet.Cells[8 + i, 5];
                oCeldasExcel.Value2 = j.autorizado_por;
                oCeldasExcel.Font.Size = 10;
                oCeldasExcel.BorderAround();
                i++;
            }
        }
    }
}
