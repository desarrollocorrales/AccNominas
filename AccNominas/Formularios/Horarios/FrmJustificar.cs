using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccSettings;
using AccAsistencia;
using AccAsistencia.DAL;
using AccAsistencia.Utilerias;

namespace AccNominas.Formularios.Horarios
{
    public partial class FrmJustificar : Form
    {
        private Empleado oEmpleado;
        private DateTime Fecha;
        StringBuilder sbMensaje;

        public FrmJustificar(DateTime pFecha, Empleado pEmpleado)
        {
            InitializeComponent();

            Fecha = pFecha;
            oEmpleado = pEmpleado;
        }

        private void PrepararFormulario()
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
            lblNombreEmpleado.Text = oEmpleado.nombre;
            txbFecha.Text = Fecha.ToShortDateString();
            cbHora.SelectedIndex = 0;
            cbMinutos.SelectedIndex = 0;
            LlenarComboConceptos();
            txbPersonaAutoriza.Text = Configuracion.oUsuario.nombre;
        }
        private void LlenarComboConceptos()
        {
            List<Concepto> lstConceptos = new List<Concepto>();
            Concepto oConcepto = new Concepto();
            oConcepto.clave = "ET";
            oConcepto.descripcion = "Entrada de Turno";
            lstConceptos.Add(oConcepto);

            oConcepto = new Concepto();
            oConcepto.clave = "DE";
            oConcepto.descripcion = "Descanso";
            lstConceptos.Add(oConcepto);

            oConcepto = new Concepto();
            oConcepto.clave = "ST";
            oConcepto.descripcion = "Salida de Turno";
            lstConceptos.Add(oConcepto);

            cbConcepto.DataSource = lstConceptos;
            cbConcepto.DisplayMember = "descripcion";
            cbConcepto.ValueMember = "clave";
            cbConcepto.Refresh();
        }

        private void FrmJustificar_Load(object sender, EventArgs e)
        {
            PrepararFormulario();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Justificar();
            }
            else
            {
                MessageBox.Show(sbMensaje.ToString());
            }
        }

        private void Justificar()
        {
            try
            {
                TimeSpan hora =
                    new TimeSpan(Convert.ToInt32(cbHora.Text), Convert.ToInt32(cbMinutos.Text), 0);
                Justificacion oJustificacion = new Justificacion();
                oJustificacion.id_interno = oEmpleado.id_interno;
                oJustificacion.fecha_hora =
                    new DateTime(Fecha.Year, Fecha.Month, Fecha.Day
                                , hora.Hours, hora.Minutes, hora.Seconds);
                oJustificacion.detalle = txbDetalle.Text;
                oJustificacion.oConcepto = ((Concepto)cbConcepto.SelectedItem);
                oJustificacion.autorizado_por = txbPersonaAutoriza.Text;

                JustificacionesDAL DAL = new JustificacionesDAL();
                DAL.GuardarJustificacion(oJustificacion);

                MessageBox.Show("La justificacion ha sido guardada con exito.");
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error: " + e.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private bool ValidarFormulario()
        {
            bool bExito = true;
            sbMensaje = new StringBuilder();
            int iHora = Convert.ToInt32(cbHora.Text);
            int iMinutos = Convert.ToInt32(cbMinutos.Text);
            
            if (iHora > 23)
            {
                sbMensaje.Append("El valor de la hora debe ser entre [00] y [23]...");
                sbMensaje.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }
            if (iMinutos > 59)
            {
                sbMensaje.Append("El valor de los minutos debe ser entre [00] y [59]...");
                sbMensaje.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }
            if (txbDetalle.Text.Trim() == string.Empty)
            {
                sbMensaje.Append("Debe agregar un detalle...");
                sbMensaje.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }
            if (txbDetalle.Text.Trim() == string.Empty)
            {
                sbMensaje.Append("Debe agregar que persona autoriza...");
                sbMensaje.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }

            return bExito;
        }
    }
}
