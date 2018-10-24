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
    public partial class FrmEmpleados : Form
    {
        public int id_original;

        public FrmEmpleados(int id, string nombre, Departamento depto)
        {
            InitializeComponent();
            EmpleadosDAL registro = new EmpleadosDAL();
            txtId.Enabled = false;
            txtId.TextAlign = HorizontalAlignment.Center;
            txtId.BackColor = Color.White;
            txtId.ForeColor = Color.Black;
            ModificarEmpleado(id, nombre, depto, registro);
        }

        public FrmEmpleados()
        {
            InitializeComponent();
            EmpleadosDAL depto = new EmpleadosDAL();
            NuevoEmpleado(depto);
        }

        public void NuevoEmpleado(EmpleadosDAL depto)
        {
            List<Departamento> depa = depto.ObtenerDepartamentos();
            comboBox1.DataSource = depa;
            comboBox1.DisplayMember = "d_nombre";
            label1.Text = "Nuevo Empleado";
        }

        public void ModificarEmpleado(int id, string nombre, Departamento depto, EmpleadosDAL registro)
        {
            id_original = id;
            label1.Text = "Modificar empleado";
            txtId.Text = "" + id;
            txtNombre.Text = nombre;
            List<Departamento> depa = registro.ObtenerDepartamentos();
            comboBox1.DataSource = depa;
            comboBox1.Text = depto.Nombre;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL();

                if (label1.Text.Equals("Nuevo Empleado"))
                {
                    int id_empleado = Convert.ToInt32(txtId.Text);
                    int id_depto = Convert.ToInt32(comboBox1.SelectedValue);
                    string nombre = txtNombre.Text;

                    if (Configuracion.oChecador.DataBase == Configuracion.dbTodos)
                    {
                        oEmpleadosDAL.InsertarEmpleadoTodosLosChecadores(id_empleado, id_depto, nombre);
                    }
                    else
                    {
                        oEmpleadosDAL.InsertarEmpleado(id_empleado, id_depto, nombre);
                    }

                    MessageBox.Show("¡Se ha creado un registro con exito!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    Empleado oEmpleado = new Empleado();
                    oEmpleado.id_interno = Convert.ToInt32(txtId.Text);
                    oEmpleado.nombre = txtNombre.Text;
                    oEmpleado.departamento = (Departamento)comboBox1.SelectedItem;

                    if (Configuracion.oChecador.DataBase == Configuracion.dbTodos)
                    {
                        oEmpleadosDAL.ModificarEmpleadoTodosLosChecadores(oEmpleado);
                    }
                    else
                    {
                        oEmpleadosDAL.ModificarEmpleado(oEmpleado);
                    }

                    MessageBox.Show("¡Se ha modificado el registro con exito!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("duplicate"))
                {
                    MessageBox.Show("Error: El ID Interno le pertenece a otro empleado..."
                                    , "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ocurrio un error: " + ex.Message + "..."
                                    , "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;
        }
    }
}
