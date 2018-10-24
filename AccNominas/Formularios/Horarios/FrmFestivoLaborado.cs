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
using System.Configuration;

namespace AccNominas.Formularios.Horarios
{
    public partial class FrmFestivoLaborado : Form
    {
        private List<Empleado> lstEmpleadosSource;
        StringBuilder sbMensaje;

        public FrmFestivoLaborado()
        {
            InitializeComponent();
            prepararFrm();
        }

        private void prepararFrm()
        {
            llenarComboEmpleados();
        }

        private void llenarComboEmpleados()
        {
            EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL();
            lstEmpleadosSource = new List<Empleado>();
            if (Configuracion.oChecador.DataBase == ConfigurationManager.AppSettings["db_todos"])
            {
                lstEmpleadosSource = oEmpleadosDAL.ObtenerEmpleadosSencillosTodosLosChecadores();
            }
            else
            {
                lstEmpleadosSource = oEmpleadosDAL.ObtenerEmpleados();
            }

            cbEmpleados.DataSource = lstEmpleadosSource.OrderBy(o => o.nombre).ToList();
            cbEmpleados.DisplayMember = "nombre";
            cbEmpleados.ValueMember = "id_interno";
            cbEmpleados.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                DialogResult dr = MessageBox.Show("¿Los datos son correctos?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    Ingresar();
                }
            }
            else
            {
                MessageBox.Show(sbMensaje.ToString(), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validacion()
        {
            sbMensaje = new StringBuilder();
            bool validado = true;
            if (cbEmpleados.Text.Trim() == string.Empty)
            {
                sbMensaje.Append("Debe elegir un Empleado y un Día Inhabil...");
                sbMensaje.Append(Environment.NewLine + Environment.NewLine);
                validado = false;
            }
            return validado;
        }

        public void Ingresar()
        {
            try
            {
                JustificacionesDAL oJustificacion = new JustificacionesDAL();
                Empleado oEmp = (Empleado)cbEmpleados.SelectedItem;

                oJustificacion.PermisoLaboral(oEmp.id_interno, dtpDia.Value);
                MessageBox.Show("¡El permiso se ingreso con exito!"
                                 , "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error: " + e.Message);
            }
        }
    }
}
