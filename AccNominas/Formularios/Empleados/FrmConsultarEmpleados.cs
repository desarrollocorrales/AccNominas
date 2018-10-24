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

namespace AccNominas.Formularios.Empleados
{
    public partial class FrmConsultarEmpleados : Form
    {
        int horario;

        public FrmConsultarEmpleados()
        {
            InitializeComponent();
            this.Height = 275;
            EmpleadosDAL emp = new EmpleadosDAL();
            LlenarCb(emp);
        }
        public void LlenarCb(EmpleadosDAL emp)
        {
            List<Empleado> empleado = new List<Empleado>();

            if (Configuracion.oChecador.DataBase == Configuracion.dbTodos)
            {
                empleado = emp.ObtenerEmpleadosSencillosTodosLosChecadores().OrderBy(o => o.id_interno).ToList();
            }
            else
            {
                empleado = emp.ObtenerEmpleadosSencillo().OrderBy(o => o.id_interno).ToList();
            }

            empleado = empleado.OrderBy(o => o.nombre).ToList();
            cbNombre.DataSource = empleado;
            cbNombre.DisplayMember = "nombre";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                imgLoading.Visible = true;
                bkgConsultar.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió una excepción: " + ex.Message);
            }
        }

        private void cbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void FrmConsultarEmpleados_Load(object sender, EventArgs e)
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
        }

        private void gridView1_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }

        /********** Background Worker ****************************************************************/
        List<EmpleadoHorario> empleado_horario;
        List<EmpleadoHorarioDetalle> lstGridSource;
        private void bkgConsultar_DoWork(object sender, DoWorkEventArgs e)
        {        
            empleado_horario = new EmpleadosDAL().ObtenerRelacionHorarios(horario);

            if (empleado_horario.Count != 0)
            {
                lstGridSource = new EmpleadosDAL().ObtenerDetalleHorario(horario);
            }
        }

        private void bkgConsultar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (empleado_horario.Count == 0)
            {
                label4.Visible = true;
                gridControl1.Visible = false;
            }
            else
            {
                label4.Visible = false;

                gridControl1.DataSource = lstGridSource;
                gridControl1.Visible = true;
                gridView1.BestFitColumns();
                gridControl1.Refresh();
            }

            imgLoading.Visible = false;
        }

        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            horario = ((Empleado)cbNombre.SelectedItem).id_interno;
        }
        /***********************************************************************************************/
    }
}
