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

namespace AccNominas.Formularios.Horarios
{
    public partial class FrmCambiarPrioridad : Form
    {
        public FrmCambiarPrioridad()
        {
            InitializeComponent();
        }

        private void Frm_CambiarPrioridad_Load(object sender, EventArgs e)
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

            lstEmpleadosSource = lstEmpleadosSource.OrderBy(o => o.nombre).ToList();
            cbEmpleados.DataSource = lstEmpleadosSource;
            cbEmpleados.DisplayMember = "nombre";
            cbEmpleados.Refresh();
        }

        private void ActualizarEmpleado()
        {
            EmpleadosDAL EDAL = new EmpleadosDAL();
            Empleado oEmp = (Empleado)cbEmpleados.SelectedItem;

            List<HorarioVigencia> lstHorarios;
            lstHorarios = EDAL.ObtenerHorariosVigencias(oEmp.id_interno);

            gridHorarios.DataSource = lstHorarios;
            gvHorarios.BestFitColumns();
            gridHorarios.Refresh();
            ActualizarBotones();
        }

        private void cbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEmpleado();
        }

        private void gvHorarios_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ActualizarBotones();
        }

        private void ActualizarBotones()
        {
            int iIndiceFila = gvHorarios.GetFocusedDataSourceRowIndex();
            if (gvHorarios.DataRowCount <= 1)
            {
                btnSubir.Enabled = false;
                btnBajar.Enabled = false;
            }
            else
            {
                if (iIndiceFila == 0)
                {
                    btnSubir.Enabled = false;
                    btnBajar.Enabled = true;
                }
                else if ((iIndiceFila + 1) == gvHorarios.DataRowCount)
                {
                    btnSubir.Enabled = true;
                    btnBajar.Enabled = false;
                }
                else
                {
                    btnSubir.Enabled = true;
                    btnBajar.Enabled = true;
                }
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            subirPrioridad();
        }
        private void subirPrioridad()
        {
            int iIndiceFila = gvHorarios.GetFocusedDataSourceRowIndex();
            int iFilaAnterior = gvHorarios.GetFocusedDataSourceRowIndex() - 1;

            List<HorarioVigencia> lstHorarios = new List<HorarioVigencia>();
            lstHorarios.AddRange((List<HorarioVigencia>)gridHorarios.DataSource);

            HorarioVigencia horario = lstHorarios[iIndiceFila];
            HorarioVigencia horarioAnt = lstHorarios[iFilaAnterior];

            int prioridad, prioridadAnt, prioridadAux;

            prioridadAux = horario.prioridad;
            prioridad = horarioAnt.prioridad;
            prioridadAnt = prioridadAux;

            horario.prioridad = prioridad;
            horarioAnt.prioridad = prioridadAnt;

            lstHorarios[iIndiceFila] = horarioAnt;
            lstHorarios[iFilaAnterior] = horario;

            lstHorarios = lstHorarios.OrderByDescending(o => o.prioridad).ToList();
            gridHorarios.DataSource = lstHorarios;
            gvHorarios.RefreshData();
            gridHorarios.Refresh();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea guardar los cambios?", string.Empty,
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                Guardar();

                imgLoading.Visible = false;
            }
        }
        private void Guardar()
        {
            try
            {           
                Empleado oEmp = (Empleado)cbEmpleados.SelectedItem;
                List<Empleado> lstEmpleados = new List<Empleado>();
                lstEmpleados.Add(oEmp);

                HorarioDAL HoraDAL = new HorarioDAL();
                List<HorarioVigencia> lstHorarios = new List<HorarioVigencia>();
                lstHorarios.AddRange((List<HorarioVigencia>)gridHorarios.DataSource);
                lstHorarios = lstHorarios.OrderBy(o => o.prioridad).ToList();

                HoraDAL.BorrarAsignaciones(oEmp.id_interno);
                foreach (HorarioVigencia oHorario in lstHorarios)
                {
                    HoraDAL.AsignarHorario(lstEmpleados, oHorario);
                }

                MessageBox.Show("Los cambios se guardaron con exito!!!", string.Empty,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, string.Empty,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            bajarPrioridar();
        }
        private void bajarPrioridar()
        {
            int iIndiceFila = gvHorarios.GetFocusedDataSourceRowIndex();
            int iFilaSiguiente = gvHorarios.GetFocusedDataSourceRowIndex() + 1;

            List<HorarioVigencia> lstHorarios = new List<HorarioVigencia>();
            lstHorarios.AddRange((List<HorarioVigencia>)gridHorarios.DataSource);

            HorarioVigencia horario = lstHorarios[iIndiceFila];
            HorarioVigencia horarioAnt = lstHorarios[iFilaSiguiente];

            int prioridad, prioridadAnt, prioridadAux;

            prioridadAux = horario.prioridad;
            prioridad = horarioAnt.prioridad;
            prioridadAnt = prioridadAux;

            horario.prioridad = prioridad;
            horarioAnt.prioridad = prioridadAnt;

            lstHorarios[iIndiceFila] = horarioAnt;
            lstHorarios[iFilaSiguiente] = horario;

            lstHorarios = lstHorarios.OrderByDescending(o => o.prioridad).ToList();
            gridHorarios.DataSource = lstHorarios;
            gvHorarios.RefreshData();
            gridHorarios.Refresh();
        }
    }
}
