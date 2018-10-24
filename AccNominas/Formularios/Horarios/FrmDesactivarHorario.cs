using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccAsistencia.Utilerias;
using AccAsistencia.DAL;
using AccAsistencia;

namespace AccNominas.Formularios.Horarios
{
    public partial class FrmDesactivarHorario : Form
    {
        public FrmDesactivarHorario()
        {
            InitializeComponent();
        }

        private void FrmDesactivarHorario_Load(object sender, EventArgs e)
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
            llenarComboHorarios();
        }

        private void llenarComboHorarios()
        {
            HorarioDAL Dal = new HorarioDAL();
            List<Horario> LstHorarios = new List<Horario>();
            LstHorarios = Dal.ObtenerHorarios();

            cbDescripcion.DataSource = LstHorarios.OrderBy(o=>o.descripcion).ToList();
            cbDescripcion.DisplayMember = "descripcion";
            cbDescripcion.Refresh();
        }

        private void cbDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            Horario oHorario = (Horario)cbDescripcion.SelectedItem;
            CargarHorario(oHorario);
        }
        private void CargarHorario(Horario oHorario)
        {
            chbDomingo.Checked = oHorario.dias_que_aplica[0] == '0' ? false : true;
            chbLunes.Checked = oHorario.dias_que_aplica[1] == '0' ? false : true;
            chbMartes.Checked = oHorario.dias_que_aplica[2] == '0' ? false : true;
            chbMiercoles.Checked = oHorario.dias_que_aplica[3] == '0' ? false : true;
            chbJueves.Checked = oHorario.dias_que_aplica[4] == '0' ? false : true;
            chbViernes.Checked = oHorario.dias_que_aplica[5] == '0' ? false : true;
            chbSabado.Checked = oHorario.dias_que_aplica[6] == '0' ? false : true;
            chbDiaSiguiente.Checked = oHorario.checa_dia_siguiente;

            gridDetalles.DataSource = oHorario.lstDetalles;
            gridDetalles.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            Desactivar();
        }
        private void Desactivar()
        {
            try
            {                               
                Horario oHorario = (Horario)cbDescripcion.SelectedItem;
                DialogResult dr = MessageBox.Show("Desea desactivar el horario: " + oHorario.descripcion,
                                                    string.Empty,
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    HorarioDAL Dal = new HorarioDAL();
                    Dal.DesactivarHorario(oHorario.id_horario);
                    MessageBox.Show("Horario desactivado con exito!!!",
                                        string.Empty,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception e)
            {
                string Mensaje = "Error:" + e.Message;
                MessageBox.Show(Mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbDomingo_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
