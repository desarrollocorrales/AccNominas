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
using AccSettings;
using AccAsistencia.Utilerias;

namespace AccNominas.Formularios.Reportes
{
    public partial class FrmConsultarTodo : Form
    {
        private Empleado oEmpleado;
        
        public FrmConsultarTodo(Empleado pEmpleado)
        {
            InitializeComponent();
            oEmpleado = pEmpleado;
        }

        public void LlenarGrid()
        { 
            gridControl1.DataSource = null;
            gridControl1.DataSource = ObtenerTodasLasChecadas();
        }
        private List<Checada> ObtenerTodasLasChecadas()
        {
            ChecadasDAL checada = new ChecadasDAL();
            List<Checada> lChecada = new List<Checada>();

            DateTime dtInicial = dtpInicial.Value.Date;
            DateTime dtFinal = dtpFinal.Value.Date.AddDays(1);

            if (Configuracion.oChecador.DataBase == Configuracion.dbTodos)
            {
                lChecada = checada.ObtenerChecadasTodosChecadores(oEmpleado.id_interno, dtInicial, dtFinal);
            }
            else
            {
                lChecada = checada.ObtenerChecadasReales(oEmpleado.id_interno, dtInicial, dtFinal);
            }

            return lChecada;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultarTodo_Load(object sender, EventArgs e)
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
            lblIdInterno.Text = oEmpleado.id_interno.ToString();
            lblNombre.Text = oEmpleado.nombre.ToString();

            DateTime hoy = DateTime.Now;
            dtpInicial.Value = new DateTime(hoy.Year, hoy.Month, 1);
            dtpFinal.Value = new DateTime(hoy.Year, hoy.Month, hoy.Day);
        }

        private void gridView1_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            LlenarGrid();
        }
    }
}
