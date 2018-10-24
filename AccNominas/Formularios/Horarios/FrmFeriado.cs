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
    public partial class FrmFeriado : Form
    {
        private List<Departamento> lstDeptosSource;
        private List<Empleado> lstEmpleadosSource;
        StringBuilder sbMensaje;

        public FrmFeriado()
        {
            InitializeComponent();
        }

        private void FrmFeriado_Load(object sender, EventArgs e)
        {
            prepararFormulario();
        }

        private void prepararFormulario()
        {
            llenarComboDeptos();
            llenarComboEmpleados();
            txbPersonaAutoriza.Text = Configuracion.oUsuario.nombre;
        }
        
        private void llenarComboDeptos()
        {
            lstDeptosSource = new DepartamentosDAL().ObtenerDepartamentos();

            Departamento dept = new Departamento();
            dept.Estatus = true;
            dept.Id = -1;
            dept.Nombre = "Todos";
            lstDeptosSource.Add(dept);

            cbDeptos.DataSource = lstDeptosSource;
            cbDeptos.DisplayMember = "Nombre";
            cbDeptos.ValueMember = "id";
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

        private void rbPorNombre_CheckedChanged(object sender, EventArgs e)
        {
            cbEmpleados.Enabled = true;
            cbDeptos.Enabled = false;
        }

        private void rbPorDepto_CheckedChanged(object sender, EventArgs e)
        {
            cbEmpleados.Enabled = false;
            cbDeptos.Enabled = true;
        }

        private bool Validacion()
        {
            sbMensaje = new StringBuilder();
            bool validado = true;
            if (cbEmpleados.Text.Trim() == string.Empty)
            {
                sbMensaje.Append("Debe elegir un empleado...");
                sbMensaje.Append(Environment.NewLine + Environment.NewLine);
                validado = false;
            }
            return validado;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                DialogResult dr = MessageBox.Show("¿Los datos son correctos?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    imgCargando.Visible = true;
                    Application.DoEvents();

                    Ingresar();

                    imgCargando.Visible = false;
                }
            }
            else
            {
                MessageBox.Show(sbMensaje.ToString(), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ingresar()
        {
            try
            {
                DateTime fecha = dtpInicial.Value.Date;
                DateTime dtFechaFinal = dtpFinal.Value.Date;

                VacacionFeriado oJustificacion;
                Empleado oEmpleado = new Empleado();
                EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL();
                List<Empleado> lstEmpleados = new List<Empleado>();                
                JustificacionesDAL DAL_VacacionFeriado = new JustificacionesDAL();
                
                while (fecha <= dtFechaFinal)
                {
                    oJustificacion = new VacacionFeriado();
                    oJustificacion.fecha = fecha;
                    oJustificacion.concepto = txtConcepto.Text;
                    oJustificacion.descripcion = txtDetalle.Text;

                    if (rbPorNombre.Checked == true)
                    {
                        oEmpleado = (Empleado)cbEmpleados.SelectedItem;
                        lstEmpleados.Add(oEmpleado);
                    }
                    else
                    {
                        int id_depto = Convert.ToInt32(cbDeptos.SelectedValue);
                        lstEmpleados = oEmpleadosDAL.ObtenerEmpleadosSencillo();

                        if (id_depto != -1)
                        {
                            lstEmpleados = lstEmpleados.FindAll(o => o.id_depto == id_depto);
                        }
                    }

                    DAL_VacacionFeriado.GuardarVacacionFeriado(lstEmpleados, oJustificacion);

                    fecha = fecha.AddDays(1);
                }
             
                MessageBox.Show("La justificacion ha sido guardada con exito.");
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error: " + e.Message);
            }
        }

        private void dtpInicial_ValueChanged(object sender, EventArgs e)
        {
            dtpFinal.Value = dtpInicial.Value;
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFinal.Value < dtpInicial.Value)
            {
                dtpInicial.Value = dtpFinal.Value;
            }
        }
    }
}