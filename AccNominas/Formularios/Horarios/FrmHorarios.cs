using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccAsistencia.DAL;
using AccAsistencia;
using AccAsistencia.Utilerias;

namespace AccNominas.Formularios.Horarios
{
    public partial class FrmHorarios : Form
    {
        private StringBuilder sbMensaje;
        private List<HorariosDetalles> lstHorarioDetalles;
        private Horario HorarioExistente;

        public FrmHorarios()
        {
            InitializeComponent();
            lstHorarioDetalles = new List<HorariosDetalles>();
            HorarioExistente = null;
        }

        public FrmHorarios(Horario pHorario)
        {
            InitializeComponent();
            lstHorarioDetalles = new List<HorariosDetalles>();
            HorarioExistente = pHorario;
        }

        private void FrmHorarios_Load(object sender, EventArgs e)
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
            prepararFormulario();
            llenarComboConcepto();
            llenarComboHoras(cbHoraMin);
            llenarComboHoras(cbHoraChec);
            llenarComboHoras(cbHoraMax);
            llenarComboMinutos(cbMinutMin);
            llenarComboMinutos(cbMinutChec);
            llenarComboMinutos(cbMinutMax);  
        }

        private void prepararFormulario()
        {
            if (this.HorarioExistente != null)
            {
                btnGuardar.Text = "Modificar";
                lblTitulo.Text = "Modificar Horario";
                HorarioDAL oHorariosDAL = new HorarioDAL();
                List<Horario> lstHorarios = oHorariosDAL.ObtenerHorarios();
                lstHorarios = lstHorarios.OrderBy(o => o.descripcion).ToList();
                cbDescripcion.DataSource = lstHorarios;
                cbDescripcion.DisplayMember = "descripcion";
                cbDescripcion.ValueMember = "id_horario";
                cbDescripcion.DropDownStyle = ComboBoxStyle.DropDownList;
                cbDescripcion.Refresh();
            }
        }
        private void llenarComboHoras(ComboBox cb)
        {
            List<string> lstHoras = new List<string>();
            for (int i = 0; i <= 23; i++)
            {
                lstHoras.Add(i.ToString().PadLeft(2, '0'));
            }
            cb.DataSource = lstHoras;
            cb.SelectedIndex = 0;
            cb.Refresh();
        }
        private void llenarComboMinutos(ComboBox cb)
        {
            List<string> lstHoras = new List<string>();
            for (int i = 0; i <= 59; i++)
            {
                lstHoras.Add(i.ToString().PadLeft(2, '0'));
            }
            cb.DataSource = lstHoras;
            cb.SelectedIndex = 0;
            cb.Refresh();
        }
        private void llenarComboConcepto()
        {
            Concepto oConcepto;
            List<Concepto> lstConceptos = new List<Concepto>();
            oConcepto = new Concepto();
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
            cbConcepto.Refresh();
        }
        private string obtenerDiasQueAplica()
        {
            string dias_que_aplica=string.Empty;

            if (chbDiaSiguiente.Checked)
            {
                dias_que_aplica =
                        Convert.ToInt32(chbDomingo.Checked).ToString() +
                        Convert.ToInt32(chbLunes.Checked).ToString() +
                        Convert.ToInt32(chbMartes.Checked).ToString() +
                        Convert.ToInt32(chbMiercoles.Checked).ToString() +
                        Convert.ToInt32(chbJueves.Checked).ToString() +
                        Convert.ToInt32(chbViernes.Checked).ToString() +
                        Convert.ToInt32(chbSabado.Checked).ToString();
                char []diasQueAplicaSiguiente =
                    new char[] { '0', '0', '0', '0', '0', '0', '0'};

                for (int i = 0; i < dias_que_aplica.Length; i++)
                {
                    if (dias_que_aplica[i] == '1')
                    {
                        if (i < 6)
                        {
                            diasQueAplicaSiguiente[i] = '1';
                            diasQueAplicaSiguiente[i + 1] = '1';
                        }
                        else
                        {
                            diasQueAplicaSiguiente[i] = '1';
                            diasQueAplicaSiguiente[0] = '1';
                        }
                    }
                }

                dias_que_aplica=string.Empty;
                foreach (char c in diasQueAplicaSiguiente)
                {
                    dias_que_aplica += c.ToString();
                }
            }
            else
            {
                dias_que_aplica =
                        Convert.ToInt32(chbDomingo.Checked).ToString() +
                        Convert.ToInt32(chbLunes.Checked).ToString() +
                        Convert.ToInt32(chbMartes.Checked).ToString() +
                        Convert.ToInt32(chbMiercoles.Checked).ToString() +
                        Convert.ToInt32(chbJueves.Checked).ToString() +
                        Convert.ToInt32(chbViernes.Checked).ToString() +
                        Convert.ToInt32(chbSabado.Checked).ToString();
            }
            return dias_que_aplica;
        }
        private string obtenerDiasQueNoAplica()
        {
            string dias_que_no_aplica =
                Convert.ToInt32(!chbDomingo.Checked).ToString() +
                Convert.ToInt32(!chbLunes.Checked).ToString() +
                Convert.ToInt32(!chbMartes.Checked).ToString() +
                Convert.ToInt32(!chbMiercoles.Checked).ToString() +
                Convert.ToInt32(!chbJueves.Checked).ToString() +
                Convert.ToInt32(!chbViernes.Checked).ToString() +
                Convert.ToInt32(!chbSabado.Checked).ToString();

            return dias_que_no_aplica;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                try
                {
                    if (HorarioExistente == null)
                    {
                        if (MessageBox.Show("¿Los datos son correctos?","", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            try
                            {
                                imgLoading.Visible = true;
                                Application.DoEvents();

                                GuardarHorario();

                                imgLoading.Visible = false;
                                MessageBox.Show("Se ha guardado el horario con exito.");
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ocurrio un error: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("¿Los datos son correctos?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            imgLoading.Visible = true;
                            Application.DoEvents();

                            ModificarHorario();

                            imgLoading.Visible = false;
                            MessageBox.Show("Se ha modificado el horario con exito.");
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex.Message);
                }        
            }
            else
            {
                MessageBox.Show(sbMensaje.ToString());
            }
        }
        private void GuardarHorario()
        {
            HorarioDAL oHorariosDAL = new HorarioDAL();
            Horario oHorario = new Horario();
            oHorario.descripcion = cbDescripcion.Text;
            oHorario.dias_que_aplica = obtenerDiasQueAplica();
            oHorario.dias_que_no_aplica = obtenerDiasQueNoAplica();
            oHorario.fecha_actualizacion = DateTime.Now;
            oHorario.checa_dia_siguiente = chbDiaSiguiente.Checked;
            oHorario.lstDetalles = lstHorarioDetalles;

            oHorariosDAL.GuardarHorario(oHorario);
        }
        private void ModificarHorario()
        {
            HorarioDAL oHorariosDAL = new HorarioDAL();
            HorarioExistente.dias_que_aplica = obtenerDiasQueAplica();
            HorarioExistente.dias_que_no_aplica = obtenerDiasQueNoAplica();
            HorarioExistente.fecha_actualizacion = DateTime.Now;
            HorarioExistente.checa_dia_siguiente = chbDiaSiguiente.Checked;
            oHorariosDAL.ModificarHorario(HorarioExistente);
        }
        private bool ValidarFormulario()
        {
            bool bExito=true;
            sbMensaje = new StringBuilder();

            if (cbDescripcion.Text.Trim() == string.Empty)
            {
                sbMensaje.Append("Debe agregar una descripcion para el horario." + Environment.NewLine + Environment.NewLine);
                bExito=false;
            }

            if (!chbDomingo.Checked &&
                !chbLunes.Checked &&
                !chbMartes.Checked &&
                !chbMiercoles.Checked &&
                !chbJueves.Checked &&
                !chbViernes.Checked &&
                !chbSabado.Checked)
            {
                sbMensaje.Append("Debe elegir al menos un dia para el horario." + Environment.NewLine + Environment.NewLine);
                bExito=false;
            }

            if (gvDetalles.DataRowCount == 0)
            {
                sbMensaje.Append("Debe agregar el detalle de Entrada de Turno para el horario." + Environment.NewLine + Environment.NewLine);
                sbMensaje.Append("Debe agregar el detalle de Salida de Turno para el horario." + Environment.NewLine + Environment.NewLine);
                bExito = false;
            }
            else
            {
                HorariosDetalles EntradaDeTurno = lstHorarioDetalles.Find(o => o.oConcepto.clave == "ET");
                HorariosDetalles SalidaDeTurno = lstHorarioDetalles.Find(o => o.oConcepto.clave == "ST");
                if (EntradaDeTurno == null)
                {
                    sbMensaje.Append("Debe agregar el detalle de Entrada de Turno para el horario." + Environment.NewLine + Environment.NewLine);
                    bExito = false;
                }
                if (SalidaDeTurno == null)
                {
                    sbMensaje.Append("Debe agregar el detalle de Salida de Turno para el horario." + Environment.NewLine + Environment.NewLine);
                    bExito = false;
                }
            }

            return bExito;
        }
        private void btnAgregarDetalle_Click(object sender, EventArgs e)
        {
            HorariosDetalles oDetalle = CrearDetalle();

            if (ValidarDetalle(oDetalle))
            {
                lstHorarioDetalles.Add(oDetalle);
                gridDetalles.DataSource = null;
                gridDetalles.DataSource = lstHorarioDetalles;
                gridDetalles.Refresh();
            }
            else
            {
                MessageBox.Show(sbMensaje.ToString());
            }
        }
        private bool ValidarDetalle(HorariosDetalles pDetalle)
        {         
            bool bExito = true;
            string hora = string.Empty;
            sbMensaje = new StringBuilder();

            List<HorariosDetalles> lstDetalles = new List<HorariosDetalles>();
            if (gvDetalles.DataRowCount != 0)
            {
                lstDetalles = (List<HorariosDetalles>)gridDetalles.DataSource;
            }

            HorariosDetalles oDetalle = 
                lstDetalles.Find(o => (o.id_horario == pDetalle.id_horario) && 
                                      (o.oConcepto.clave == pDetalle.oConcepto.clave));
            if (oDetalle != null)
            {
                //***** El Detalle ya existe
                sbMensaje.Append("El Detalle para el concepto: [" + oDetalle.oConcepto.descripcion.ToUpper() +"] ya existe");
                sbMensaje.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }

            if (pDetalle.hora_minima >= pDetalle.hora_maxima)
            {
                sbMensaje.Append("La HORA MINIMA DE CHECADA debe ser menor a la HORA MAXIMA DE CHECADA");
                sbMensaje.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }

            if (pDetalle.hora_checada != null)
            {
                if (pDetalle.hora_checada < pDetalle.hora_minima)
                {
                    sbMensaje.Append("La HORA DE CHECADA debe ser mayor a la HORA MINIMA DE CHECADA");
                    sbMensaje.Append(Environment.NewLine + Environment.NewLine);
                    bExito = false;
                }
                if (pDetalle.hora_checada > pDetalle.hora_maxima)
                {
                    sbMensaje.Append("La HORA DE CHECADA debe ser menor a la HORA MAXIMA DE CHECADA");
                    sbMensaje.Append(Environment.NewLine + Environment.NewLine);
                    bExito = false;
                }
            }

            oDetalle = lstDetalles.Find(o => (pDetalle.hora_minima >= o.hora_minima) &&
                                             (pDetalle.hora_minima <= o.hora_maxima));
            if (oDetalle != null)
            {
                sbMensaje.Append("No se permite solapar intervalos de tiempo...");
                sbMensaje.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }
            else
            {
                oDetalle = lstDetalles.Find(o => (pDetalle.hora_maxima >= o.hora_minima) &&
                                                 (pDetalle.hora_maxima <= o.hora_maxima));
                if (oDetalle != null)
                {
                    sbMensaje.Append("No se permite solapar intervalos de tiempo...");
                    sbMensaje.Append(Environment.NewLine + Environment.NewLine);
                    bExito = false;
                }
            }

            if (validarCBHora(cbHoraMin) == false || validarCBMinutos(cbMinutMin) == false)
            {
                sbMensaje.Append("La HORA MINIMA DE CHECADA es incorrecta.");
                sbMensaje.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }
            if (cbHoraChec.Enabled)
            {
                if (validarCBHora(cbHoraChec) == false || validarCBMinutos(cbMinutChec) == false)
                {
                    sbMensaje.Append("La HORA DE CHECADA es incorrecta.");
                    sbMensaje.Append(Environment.NewLine + Environment.NewLine);
                    bExito = false;
                }
            }
            if (validarCBHora(cbHoraMax) == false || validarCBMinutos(cbMinutMax) == false)
            {
                sbMensaje.Append("La HORA MAXIMA DE CHECADA es incorrecta.");
                bExito = false;
            }

            return bExito;
        }
        private HorariosDetalles CrearDetalle()
        {
            HorariosDetalles oDetalle = new HorariosDetalles();
            if (HorarioExistente != null)
            {
                oDetalle.id_horario = HorarioExistente.id_horario;
            }
            else
            {
                oDetalle.id_horario = 1;
            }
            oDetalle.oConcepto = (Concepto)cbConcepto.SelectedItem;
            oDetalle.hora_minima = new TimeSpan(Convert.ToInt32(cbHoraMin.Text), Convert.ToInt32(cbMinutMin.Text), 0);
            if (oDetalle.oConcepto.clave != "DE")
            {
                oDetalle.hora_checada = new TimeSpan(Convert.ToInt32(cbHoraChec.Text), Convert.ToInt32(cbMinutChec.Text), 0);
            }
            else
            {
                oDetalle.hora_checada = null;
            }
            oDetalle.hora_maxima = new TimeSpan(Convert.ToInt32(cbHoraMax.Text), Convert.ToInt32(cbMinutMax.Text), 0);
            return oDetalle;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Concepto)cbConcepto.SelectedItem).clave == "DE")
            {
                cbHoraChec.Enabled = false;
                cbMinutChec.Enabled = false;
            }
            else
            {
                cbHoraChec.Enabled = true;
                cbMinutChec.Enabled = true;
            }
        }
        private void cbDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            HorarioExistente = (Horario)cbDescripcion.SelectedItem;
            CargarHorario(HorarioExistente);
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
            llenarComboConcepto();
            lstHorarioDetalles = oHorario.lstDetalles;
            gridDetalles.DataSource = lstHorarioDetalles;
            gridDetalles.Refresh();
        }
        private void btnQuitarDetalle_Click(object sender, EventArgs e)
        {
            if (gvDetalles.GetFocusedRow() != null)
            {
                HorariosDetalles oQuitarDetalle = (HorariosDetalles)gvDetalles.GetFocusedRow();
                lstHorarioDetalles.Remove(oQuitarDetalle);
                gridDetalles.DataSource = null;
                gridDetalles.DataSource = lstHorarioDetalles;
                gridDetalles.Refresh();
            }
        }
        private void cbHoraMin_KeyPress(object sender, KeyPressEventArgs e)
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
        private bool validarCBHora(ComboBox cb)
        {
            int hora = Convert.ToInt32(cb.Text);
            if (hora > 23)
            {
                return false;
            }
            return true;
        }
        private bool validarCBMinutos(ComboBox cb)
        {
            int minutos = Convert.ToInt32(cb.Text);
            if (minutos > 59)
            {
                return false;
            }
            return true;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void chbDiaSiguiente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbHoraMin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
