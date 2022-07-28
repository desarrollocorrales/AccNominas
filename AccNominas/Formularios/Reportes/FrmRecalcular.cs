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

namespace AccNominas.Formularios.Reportes
{
    public partial class FrmRecalcular : Form
    {
        public FrmRecalcular()
        {
            InitializeComponent();
        }

        private void FrmRecalcular_Load(object sender, EventArgs e)
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
            llenarComboEmpleados();
            InicializarDateTimePickers();
            lblAccion.Text = string.Empty;
        }

        private void llenarComboEmpleados()
        {
            EmpleadosDAL DAL = new EmpleadosDAL();
            List<Empleado> lstEmpleados;

            if (Configuracion.oChecador.DataBase == Configuracion.dbTodos)
            {
                lstEmpleados = DAL.ObtenerEmpleadosSencillosTodosLosChecadores();
            }
            else
            {
                lstEmpleados = DAL.ObtenerEmpleadosSencillo();
            }

            cbEmpleados.DataSource = lstEmpleados.OrderBy(o => o.nombre).ToList();
            cbEmpleados.DisplayMember = "nombre";
            cbEmpleados.Refresh();
        }

        private void InicializarDateTimePickers()
        {
            DateTime hoy = DateTime.Now;
            DateTime dtInicial = new DateTime(hoy.Year, hoy.Month, 1);
            DateTime dtFinal = new DateTime(hoy.Year, hoy.Month, hoy.Day);

            dtpInicial.Value = dtInicial;
            dtpFinal.Value = dtFinal;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            Recalcular();
        }

        private void Recalcular()
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro que desea recalcular las asistencias?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Empleado oEmpleado = (Empleado)cbEmpleados.SelectedItem;
                oEmpleado.lstHorarios = new EmpleadosDAL().ObtenerHorarios(oEmpleado.id_interno);
                CalcularAsistencias(oEmpleado);
                this.Hide();
                FrmReporteAsistencia frmReporteAsistencias = new FrmReporteAsistencia(oEmpleado);
                frmReporteAsistencias.ShowDialog();
                this.Close();
            }
        }

        private void CalcularAsistencias(Empleado oEmpleado)
        {
            try
            {
                DateTime dtInicial = dtpInicial.Value.Date;
                DateTime dtFinal = dtpFinal.Value.Date.AddDays(1);
                ChecadasDAL chDAL = new ChecadasDAL();
                HorarioDAL HDAL = new HorarioDAL();
                chDAL.BorrarConceptosChecadas(oEmpleado.id_interno, dtInicial, dtFinal);
                List<Checada> lstChecadas = chDAL.ObtenerChecadasReales(oEmpleado.id_interno, dtInicial, dtFinal);

                progressBar1.Maximum=lstChecadas.Count;
                progressBar1.Minimum=0;
                progressBar1.Value=0;
                foreach (Checada oChecada in lstChecadas)
                {
                    oChecada.oConcepto = new Concepto();
                    oChecada.oConcepto.clave = "INV";
                    oChecada.oConcepto.descripcion = "Invalida";
                    progressBar1.Value++;
                    lblAccion.Text = progressBar1.Value + " / " + progressBar1.Maximum;
                    lblAccion.Text += " " + oChecada.fecha_hora.ToString("dd/MM/yyyy hh:mm:ss tt");
                    Application.DoEvents();

                    // ** Obtener Horario que aplica
                    int Dia_De_Checada = oChecada.fecha_hora.DayOfWeek.GetHashCode();
                    Horario oHorario = ObtenerHorarioDelDia(oChecada, oEmpleado);
                    if (oHorario != null)
                    {
                        foreach (HorariosDetalles oDetalle in oHorario.lstDetalles)
                        {
                            if (oHorario.checa_dia_siguiente)
                            {
                                if (oDetalle.oConcepto.clave == "ST")
                                {
                                    int diaDeSalida = Dia_De_Checada;
                                    diaDeSalida = (Dia_De_Checada == 6) ? 0 : Dia_De_Checada + 1;
                                    oHorario = oEmpleado.lstHorarios.Where(o => o.dias_que_aplica[diaDeSalida] == '1').FirstOrDefault();
                                    if (oChecada.fecha_hora.TimeOfDay >= oDetalle.hora_minima &&
                                    oChecada.fecha_hora.TimeOfDay <= oDetalle.hora_maxima)
                                    {
                                        oChecada.oConcepto.clave = oDetalle.oConcepto.clave;
                                        oChecada.oConcepto.descripcion = oDetalle.oConcepto.descripcion;
                                    }
                                }
                                else
                                {
                                    // ** Solo se realiza los dias que aplica el horario
                                    if (oHorario.dias_que_no_aplica[Dia_De_Checada].Equals('0'))
                                    {
                                        // ** Por cada detalle preguntar el intervalo y asignar clave.
                                        if (oChecada.fecha_hora.TimeOfDay >= oDetalle.hora_minima &&
                                            oChecada.fecha_hora.TimeOfDay <= oDetalle.hora_maxima)
                                        {
                                            oChecada.oConcepto.clave = oDetalle.oConcepto.clave;
                                            oChecada.oConcepto.descripcion = oDetalle.oConcepto.descripcion;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                // ** Por cada detalle preguntar el intervalo y asignar clave.
                                if (oChecada.fecha_hora.TimeOfDay >= oDetalle.hora_minima &&
                                    oChecada.fecha_hora.TimeOfDay <= oDetalle.hora_maxima)
                                {
                                    oChecada.oConcepto.clave = oDetalle.oConcepto.clave;
                                    oChecada.oConcepto.descripcion = oDetalle.oConcepto.descripcion;
                                }
                            }
                            chDAL.ActualizarChecada(oChecada);
                        }// Termina foreach (HorariosDetalles oDetalle in oHorario.lstDetalles)
                    }// Termina if (oHorario != null)
                }
                MessageBox.Show("¡El proceso a finalizado con exito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
        }

        private void cbEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Horario ObtenerHorarioDelDia(Checada oChec, Empleado oEmp)
        {
            Horario oHorario = null;
            try
            {
                int iDiaDeChecada = oChec.fecha_hora.DayOfWeek.GetHashCode();

                oEmp.lstHorarios = oEmp.lstHorarios.OrderByDescending(o => o.prioridad).ToList();

                Horario AuxHorario = 
                    oEmp.lstHorarios.Find(o => o.vigencia_inicio <= oChec.fecha_hora.Date
                                          && o.vigencia_fin >= oChec.fecha_hora.Date
                                          && o.dias_que_aplica[iDiaDeChecada] == '1');

                oHorario = AuxHorario;
            }
            catch (Exception ex)
            {
                LogManager.AgregarLog("Error: " + ex.Message);
            }
            return oHorario;
        }
    }
}
