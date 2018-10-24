using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccAsistencia.DAL;
using AccAsistencia.Utilerias;
using AccAsistencia;

namespace AccNominas.Formularios.Horarios
{
    public partial class FrmDesasignarHorario : Form
    {
        int ultimoIndexCombobox = 0;

        public FrmDesasignarHorario()
        {
            InitializeComponent();
        }

        private void FrmAsignarHorario_Load(object sender, EventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            Desasignar();
        }

        private void Desasignar()
        {
            Empleado oEmpleado = (Empleado)cbEmpleados.SelectedItem;
            HorarioVigencia oHorario = (HorarioVigencia)gvHorariosVigencias.GetFocusedRow();
            ultimoIndexCombobox = cbEmpleados.SelectedIndex;

            if (oEmpleado == null)
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }
            else
            {
                if (oHorario == null)
                {
                    MessageBox.Show("No se ha seleccionado un horario.");
                }
                else
                {
                    try
                    {
                        if (MessageBox.Show("¿Esta seguro de desasignar el horario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            HorarioDAL oHorarioDAL = new HorarioDAL();
                            oHorarioDAL.DesasignarHorario(oEmpleado, oHorario);
                            ActualizarEmpleado();
                            MessageBox.Show("El horario se a desasignado con exito!",
                                            "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Ocurrió un error: " + e.Message);
                    }
                }
            }
        }

        private void cbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEmpleado();
        }

        private void ActivacionBoton(int iCount)
        {
            if (iCount == 0)
            {
                btnDesasignar.Enabled = false;
            }
            else
            {
                btnDesasignar.Enabled = true;
            }
        }

        private void ActualizarEmpleado()
        {
            try
            {
                Empleado oEmpleado = (Empleado)cbEmpleados.SelectedItem;

                if (oEmpleado != null)
                {
                    List<HorarioVigencia> lstHorariosVigencias = new EmpleadosDAL().ObtenerHorariosVigencias(oEmpleado.id_interno);
                    HorariosVigenciasGrid.DataSource = lstHorariosVigencias;
                    HorariosVigenciasGrid.Refresh();
                    ActivacionBoton(lstHorariosVigencias.Count);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error: " + e.Message,
                                string.Empty, MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void HorariosVigenciasGrid_Click(object sender, EventArgs e)
        {

        }
    }
}
