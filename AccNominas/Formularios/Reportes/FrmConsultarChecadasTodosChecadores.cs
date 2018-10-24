using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AccAsistencia;
using AccAsistencia.DAL;

namespace AccNominas.Formularios.Reportes
{
    public partial class FrmConsultarChecadasTodosChecadores : Form
    {
        private int IdInterno;
        private DateTime Fecha;

        public FrmConsultarChecadasTodosChecadores(DateTime pFecha, int pIdInterno)
        {
            InitializeComponent();
            this.Fecha = pFecha;
            this.IdInterno = pIdInterno;
        }

        private void FrmConsultarChecadasTodosChecadores_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void gridView1_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }

        private void llenarGrid()
        {
            ChecadasDAL DAL = new ChecadasDAL();
            List<Checada> lstChecadas = new List<Checada>();
            lstChecadas = DAL.ObtenerChecadasTodosChecadores(IdInterno, Fecha, Fecha.AddDays(1));
            gridChecadas.DataSource = null;
            gridChecadas.DataSource = lstChecadas;
        }
    }
}
