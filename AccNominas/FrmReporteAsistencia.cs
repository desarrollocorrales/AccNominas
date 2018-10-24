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

namespace AccNominas
{
    public partial class FrmReporteAsistencia : Form
    {
        private Checador oChecador;
        private DBMS oServidor;

        public FrmReporteAsistencia(Checador oChecador, DBMS oServidor)
        {
            InitializeComponent();
            this.oChecador = oChecador;
            this.oServidor = oServidor;
        }

        private void FrmReporteAsistencia_Load(object sender, EventArgs e)
        {
            
        }

        private void CrearReporte()
        {
            ReporteAsistencia oReporte = new ReporteAsistencia();
            oReporte.id_interno = 514;
            oReporte.nombre_empleado = "Guillermo Alvarado Montañez";
            oReporte.lstAsistencias = new List<Asistencia>();
            Asistencia oAsistencia = new Asistencia();
            ChecadasDAL oChecadasDAL = new ChecadasDAL(oChecador, oServidor);
            List<Checada> lstChecadas = new List<Checada>();
            DateTime fechaInicial = new DateTime(2013, 3, 1);
            DateTime fechaFinal = new DateTime(2013, 4, 1);
            lstChecadas = oChecadasDAL.ObtenerChecadas(oReporte.id_interno, fechaInicial, fechaFinal);

        }
        private void ObtenerAsistencias(List<Checada> lstChecadas)
        {
            Asistencia oAsistencia = new Asistencia();
        }
    }
}
