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
    public partial class FrmAsignarHorario : Form
    {
        private List<Horario> LstTodosHorarios;
        private int iUltimoIndexComboBoxEmpleado = 0;

        public FrmAsignarHorario()
        {
            InitializeComponent();
        }

        private void FrmAsignarHorario_Load(object sender, EventArgs e)
        {
            cbEmpleados.Enabled = rbPorNombre.Checked;
            cbDeptos.Enabled = rbPorDepto.Checked;

            llenarComboEmpleados();
            llenarComboDeptos();
            llenarComboHorarios();
            inicializarDateTimePickers();
        }

        private void PrepararFormulario()
        {
            ActualizarEmpleado();
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

        private void llenarComboDeptos()
        {
            DepartamentosDAL DAL = new DepartamentosDAL();
            List<Departamento> lstDeptosSource = new List<Departamento>();

            lstDeptosSource = DAL.ObtenerDepartamentos();

            cbDeptos.DataSource = null;
            cbDeptos.DataSource = lstDeptosSource;
            cbDeptos.DisplayMember = "Nombre";
        }

        private void llenarComboHorarios()
        {
            HorarioDAL DAL = new HorarioDAL();
            LstTodosHorarios = new List<Horario>();

            LstTodosHorarios = DAL.ObtenerHorarios();

            cbHorarios.DataSource = LstTodosHorarios;
            cbHorarios.DisplayMember = "descripcion"; 
            cbHorarios.Refresh();
        }

        private void inicializarDateTimePickers()
        {
            dtpVigenciaIni.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpVigenciaFinal.Value = new DateTime(DateTime.Now.Year, 12, 31);
        }

        private void rbPorNombre_CheckedChanged(object sender, EventArgs e)
        {
            EmpleadoHorariosGrid.Visible = true;
            cbEmpleados.Enabled = rbPorNombre.Checked;
            cbDeptos.Enabled = rbPorDepto.Checked;
            ActualizarEmpleado();
        }

        private void rbPorDepto_CheckedChanged(object sender, EventArgs e)
        {
            cbEmpleados.Enabled = rbPorNombre.Checked;
            cbDeptos.Enabled = rbPorDepto.Checked;
            EmpleadoHorariosGrid.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Asignar();
        }

        private void Asignar()
        {
            if (rbPorNombre.Checked)
            {
                AsignarPorEmpleado();
            }
            else
            {
                AsignarPorDepartamento();
            }
        }

        private void cbHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Horario oHorario = (Horario) cbHorarios.SelectedItem;
            gridDetalles.DataSource = oHorario.lstDetalles;
            gridDetalles.Refresh();
        }

        private void cbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

            iUltimoIndexComboBoxEmpleado = cbEmpleados.SelectedIndex;
            ActualizarEmpleado();
        }

        private void AsignarPorEmpleado()
        {
            Horario oHorario = (Horario)cbHorarios.SelectedItem;
            Empleado oEmpleado = (Empleado)cbEmpleados.SelectedItem;
            
            iUltimoIndexComboBoxEmpleado = cbEmpleados.SelectedIndex;

            if (oEmpleado == null)
            {
                MessageBox.Show("Seleccione un empleado.");
                return;
            }
            else
            {
                if (oHorario == null)
                {
                    MessageBox.Show("Ocurrio un error al asignar horario.");
                }
                else
                {
                    try
                    {
                        DialogResult dr = MessageBox.Show("¿Los datos son correctos?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            HorarioVigencia oHorarioVigencia = new HorarioVigencia();
                            oHorarioVigencia.id_horario = oHorario.id_horario;
                            oHorarioVigencia.vigencia_inicio = dtpVigenciaIni.Value;
                            oHorarioVigencia.vigencia_fin = dtpVigenciaFinal.Value;
                            List<Empleado> lstEmpleados = new List<Empleado>();
                            lstEmpleados.Add(oEmpleado);

                            HorarioDAL oHorarioDAL = new HorarioDAL();
                            oHorarioDAL.AsignarHorario(lstEmpleados, oHorarioVigencia);

                            PrepararFormulario();
                            MessageBox.Show("¡La asignacion ha concluido con exito!"
                                            , "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Ocurrió un error: " + e.Message+"..."
                                        , "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        
        private void AsignarPorDepartamento()
        {
            Horario oHorario = (Horario)cbHorarios.SelectedItem;
            Departamento oDepartamento = (Departamento)cbDeptos.SelectedItem;
            
            if (oDepartamento == null)
            {
                MessageBox.Show("Seleccione un departamento.");
                return;
            }
            else
            {
                if (oHorario == null)
                {
                    MessageBox.Show("Ocurrio un error al asignar horario.");
                }
                else
                {
                    try
                    {
                        DialogResult dr = MessageBox.Show("¿Los datos son correctos?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            HorarioVigencia oHorarioVigencia = new HorarioVigencia();
                            oHorarioVigencia.id_horario=oHorario.id_horario;
                            oHorarioVigencia.vigencia_inicio = dtpVigenciaIni.Value;
                            oHorarioVigencia.vigencia_fin = dtpVigenciaFinal.Value;

                            List<Empleado> lstEmpleados = new List<Empleado>();
                            EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL();
                            lstEmpleados = oEmpleadosDAL.ObtenerEmpleados();
                            lstEmpleados = lstEmpleados.FindAll(o => o.departamento.Id == oDepartamento.Id);
                            
                            HorarioDAL oHorarioDAL = new HorarioDAL();
                            oHorarioDAL.AsignarHorario(lstEmpleados, oHorarioVigencia);

                            PrepararFormulario();
                            MessageBox.Show("¡La asignacion ha concluido con exito!"
                                            , "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Ocurrió un error: " + e.Message + "..."
                                        , "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ActualizarEmpleado()
        {
            try
            {
                cbEmpleados.SelectedIndex = iUltimoIndexComboBoxEmpleado;
                Empleado oEmpleado = (Empleado)cbEmpleados.SelectedItem;
                EmpleadosDAL DAL = new EmpleadosDAL();
                List<HorarioVigencia> lstHorariosVigencias = DAL.ObtenerHorariosVigencias(oEmpleado.id_interno);

                EmpleadoHorariosGrid.DataSource = lstHorariosVigencias;
                EmpleadoHorariosGrid.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error: " + e.Message + "..."
                , "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmpleadoHorariosGrid_Click(object sender, EventArgs e)
        {

        }
    }
}
