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

namespace AccNominas.Formularios.Usuarios
{
    public partial class FrmChecadores : Form
    {
        public FrmChecadores()
        {
            InitializeComponent();
        }

        private void FrmChecadores_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void LlenarComboNombre(ComboBox cb)
        {
            List<Checadores> lstChecadores = new ChecadoresDAL().ObtenerChecadores();
            lstChecadores = lstChecadores.OrderBy(o => o.descripcion).ToList();

            cb.DataSource = lstChecadores;
            cb.DisplayMember = "descripcion";
            cb.Refresh();
        }

        private void cbBajaNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Checadores oChecadores = (Checadores)cbBajaNombre.SelectedItem;
            
            cbBajaBase.Text = oChecadores.base_de_datos;
            cbBajaBase.Refresh();
        }

        private void btnBajaEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea realizar esta acción?", string.Empty,
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                Eliminar();

                Actualizar();
            }
        }

        private void btnBajaCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltasGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Son datos correctos?", string.Empty,
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                GuardarAlta();

                Actualizar();
            }
        }

        private void btnAltaCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifGuardar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Los datos son correctos?", string.Empty,
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                Modificar();

                Actualizar();
            }
        }

        private void btnModifCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarAlta()
        {
            try
            {
                Checadores oChecadores = new Checadores();
                oChecadores.descripcion = txbAltaNombre.Text;
                oChecadores.base_de_datos = txbAltaBase.Text;

                new ChecadoresDAL().Guardar(oChecadores);
                MessageBox.Show("¡¡El checador se ha agregado con exito!!",
                                string.Empty,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Modificar()
        {
            try
            {
                Checadores oChecadores = new Checadores();
                oChecadores.id_checador = ((Checadores)cbModifNombreAnterior.SelectedItem).id_checador;
                oChecadores.descripcion = txbModifNuevoNombre.Text;
                oChecadores.base_de_datos = txbModifBase.Text;

                new ChecadoresDAL().Modificar(oChecadores);
                MessageBox.Show("¡¡Los datos del checador se han modificado con exito!!",
                                string.Empty,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Eliminar()
        {
            try
            {
                Checadores oChecadores = (Checadores)cbBajaNombre.SelectedItem;

                new ChecadoresDAL().Eliminar(oChecadores.id_checador);
                MessageBox.Show("¡¡El checador se ha eliminado correctamente!!",
                                string.Empty,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Actualizar()
        {
            LlenarComboNombre(cbBajaNombre);
            LlenarComboNombre(cbModifNombreAnterior);
        }
    }
}
