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
using System.Xml;
using AccAsistencia.Utilerias;

namespace AccNominas.Formularios.Departamentos
{
    public partial class FrmDepartamentos : Form
    {
        public int id_original;
        public FrmDepartamentos()
        {
            InitializeComponent();
        }
        public FrmDepartamentos(int id, string nombre)
        {
            InitializeComponent();
            id_original = id;
            txtNombre.Text = nombre;
            lblTitulo.Text = "Modificar Departamento";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Text.Contains("Nuevo"))
            {
                try
                {
                    DepartamentosDAL nuevo = new DepartamentosDAL();
                    nuevo.InsertarDepartamento(txtNombre.Text);
                    MessageBox.Show("¡Se ha creado un nuevo departamento exitosamente!",
                                    "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    if (ex.Message.ToLower().Contains("duplicate"))
                    {
                        MessageBox.Show("Error: El Departamento ya fue dado de alta...",
                                        "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error: " + ex.Message,
                                        "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else 
            {
                DepartamentosDAL modificar = new DepartamentosDAL();
                modificar.ModificarDepartamento(id_original,txtNombre.Text);
                MessageBox.Show("¡Se ha modificado el departamento con exito!",
                                "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
        }
    }
}
