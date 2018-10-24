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

namespace AccNominas.Formularios.Reportes
{
    public partial class FrmReporteJusticifaciones : Form
    {
        public FrmReporteJusticifaciones()
        {
            InitializeComponent();
        }

        private void FrmReporteJusticifaciones_Load(object sender, EventArgs e)
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
            llenarComboEmpleados();
        }

        private void llenarComboEmpleados()
        {
            EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL();
            List<Empleado> lstEmpleadosSource = new List<Empleado>();

            if (Configuracion.oChecador.DataBase == Configuracion.dbTodos)
            {
                lstEmpleadosSource = oEmpleadosDAL.ObtenerEmpleadosSencillosTodosLosChecadores();
            }
            else
            {
                lstEmpleadosSource = oEmpleadosDAL.ObtenerEmpleadosSencillo();
            }

            cbEmpleados.DataSource = lstEmpleadosSource.OrderBy(o => o.nombre).ToList(); 
            cbEmpleados.DisplayMember = "nombre";
            cbEmpleados.Refresh();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_interno = ((Empleado)cbEmpleados.SelectedItem).id_interno;
                DateTime dtInicio = dtpInicio.Value.Date;
                DateTime dtFinal = dtpFinal.Value.Date.AddDays(1);
                JustificacionesDAL jDAL = new JustificacionesDAL();
                
                gridJustificaciones.DataSource = jDAL.ObtenerJustificaciones(id_interno, dtInicio, dtFinal);
                gvJustificaciones.BestFitColumns();
                gridJustificaciones.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            /*string sPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            gridJustificaciones.ShowPrintPreview();
            gvJustificaciones.ExportToXlsx(sPath + "\\Tremesco.xlsx");*/

            ReporteJustificaciones oReporte = new ReporteJustificaciones();
            oReporte.oEmpleado = (Empleado)cbEmpleados.SelectedItem;
            oReporte.dtInicio = dtpInicio.Value;
            oReporte.dtFin = dtpFinal.Value;
            oReporte.lstJustificaciones = (List<Justificacion>)gridJustificaciones.DataSource;
            ExcelExporter oExcel = new ExcelExporter();
            oExcel.ExportarReporteJustificaciones(oReporte);
            
        }
    }
}
