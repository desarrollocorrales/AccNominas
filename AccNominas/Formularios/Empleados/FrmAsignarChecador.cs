using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AccAsistencia;
using AccAsistencia.DAL;
using AccAsistencia.Utilerias;
using AccSettings;

namespace AccNominas.Formularios.Empleados
{
    public partial class FrmAsignarChecador : Form
    {
        private EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL();
        private AsistenciaSettings ChecadoresSettings;
        private int id;

        public FrmAsignarChecador(AsistenciaSettings checadores)
        {
            InitializeComponent();
            ChecadoresSettings = checadores;
            ChecadoresSettings.Checadores.RemoveAll(o => o.DataBase == Configuracion.dbTodos);
        }

        private void llenarComboChecadores()
        {
            lstChecadores.DataSource = oEmpleadosDAL.ObtenerChecadores().OrderBy(o=>o.sChecador).ToList();
            lstChecadores.DisplayMember = "sChecador";
            lstChecadores.ValueMember = "id_checador";
        }

        private void lstChecadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void llenarComboEmpleados()
        {        
            List<Empleado> lstEmpleadosSource = new List<Empleado>();           
            lstEmpleadosSource = oEmpleadosDAL.ObtenerEmpleadosSencillosTodosLosChecadores();

            cbEmpleados.DataSource = lstEmpleadosSource;
            cbEmpleados.DisplayMember = "nombre";
            cbEmpleados.ValueMember = "id_interno";
            cbEmpleados.Refresh();
        }

        private void ActualizarEmpleado()
        {
            Empleado oEmp = (Empleado)cbEmpleados.SelectedItem;
            id = oEmp.id_interno;
            List<EmpleadoChecador> lstChecadores = 
                oEmpleadosDAL.ObtenerRelacionEmpleadoChecador(oEmp.id_interno);
            
            grdEmpleadoChecador.DataSource = lstChecadores;
            gvEmpleadoChecador.BestFitColumns();
            grdEmpleadoChecador.Refresh();
        }

        private void cbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarEmpleado();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAsignarChecador_Load(object sender, EventArgs e)
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
            llenarComboChecadores();
            llenarComboEmpleados();
            llenarGridEmpleado_Checador();
        }

        public void llenarGridEmpleado_Checador()
        {
            grdEmpleadoChecador.DataSource = oEmpleadosDAL.ObtenerRelacionEmpleadoChecador(id);
        }

        private void txtId_interno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gvEmpleadoChecador.GetFocusedRow() != null)
            {
                try
                {
                    DialogResult dr = MessageBox.Show("¿Esta seguro que desea eliminar el registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        oEmpleadosDAL.BorrarRelacionEmpleadoChecador(id, Convert.ToInt32(gvEmpleadoChecador.GetFocusedRowCellValue("id_checador")));
                        MessageBox.Show("¡El regirstro ha sido eliminado exitosamente!"
                                            , "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarEmpleado();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message + "..."
                                    , "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                oEmpleadosDAL.InsertarEmpleadoChecador(id, Convert.ToInt32(lstChecadores.SelectedValue), Convert.ToInt32(txtId_interno.Text));
                MessageBox.Show("¡Se ha registrado el checador exitosamente!",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarEmpleado();
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("duplicate"))
                {
                    MessageBox.Show("Error: El empleado ya fue dado de alta en este checador...",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message,
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
