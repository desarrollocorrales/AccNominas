using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccAsistencia;
using AccAsistencia.DAL;
using AccAsistencia.Utilerias;
using AccSettings;

namespace AccNominas
{
    public partial class Splash : Form
    {
        private DBMSSettings DBSettings;
        private AsistenciaSettings ChecadoresSettings;

        public Splash()
        {
            InitializeComponent();
        }

        private void InicializarDatos()
        {
            foreach (Checador oChecador in ChecadoresSettings.Checadores)
            {
                try
                {
                    // ***** Obtener el servidor de base de datos
                    DBMS oServidor = DBSettings.Dbms.Where(o => o.Nombre == oChecador.Dbms).SingleOrDefault();
                    
                    // ***** Obtener Checadas sin concepto
                    lblAccion.Text = "Obteniendo checadas sin concepto de " + oChecador.Nombre.ToUpper() + "...";
                    LogManager.AgregarLog(lblAccion.Text);
                    Application.DoEvents();
                    ChecadasDAL oChecadasDAL = new ChecadasDAL();
                    List<Checada> lstChecadasSinConcepto = oChecadasDAL.ObtenerChecadasSinConcepto();

                    // ***** Obtener Lista de empleados y sus horarios
                    lblAccion.Text = "Obteniendo lista de empleados de " + oChecador.Nombre.ToUpper() + "...";
                    LogManager.AgregarLog(lblAccion.Text);
                    Application.DoEvents();
                    EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL();
                    List<Empleado> lstEmpleados = oEmpleadosDAL.ObtenerEmpleados();

                    // ***** Asignar Conceptos a las checadas
                    //lblAccion.Text = "Asignando conceptos a "+ lstChecadasSinConcepto.Count +" registros de la sucursal" + oChecador.Nombre.ToUpper() + "...";
                    LogManager.AgregarLog("Asignando conceptos a sucursal: " + oChecador.Nombre.ToUpper());
                    Application.DoEvents();
                    AsignarConceptos(lstChecadasSinConcepto, lstEmpleados);
                }
                // ** Termina Try
                catch (Exception e)
                {
                    LogManager.AgregarLog("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    LogManager.AgregarLog(MensajeGlobal.Texto);
                    LogManager.AgregarLog("Ocurrio Una Excepcion: " + e.ToString());
                    LogManager.AgregarLog("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    MessageBox.Show("Ocurrio un error en el modulo: " + MensajeGlobal.Texto + Environment.NewLine + e,ToString());
                }
                // ** Termina Catch
            }
            // ** Termina ForEach  
        }
        private void CargarConfiguraciones()
        {
            //Obtener la ruta del archivo de configuraciones de Asistencia y la SettingsKey*
            ChecadoresSettings = new AsistenciaSettings();
            ChecadoresSettings.FileName = Environment.CurrentDirectory + "\\asistencia.set";
            ChecadoresSettings.Key = "C0RR4L35";

            //Obtener la ruta del archivo de configuraciones de Servidores y la SettingsKey*
            StringBuilder sbMensaje = new StringBuilder();
            DBSettings = new DBMSSettings();
            DBSettings.FileName = Environment.CurrentDirectory + "\\dbms.set";
            DBSettings.Key = "C0RR4L35";

            try
            {
                bool ExisteServidorSettings = System.IO.File.Exists(DBSettings.FileName);
                bool ExisteChecadoresSettings = System.IO.File.Exists(ChecadoresSettings.FileName);

                if (ExisteServidorSettings == false && ExisteChecadoresSettings == false)
                {
                    StringBuilder Mensaje = new StringBuilder();
                    Mensaje.Append("No se encontraron los archivos de configuración." + Environment.NewLine);
                    Mensaje.Append("Por favor, ejecute el modulo AdminACC, genere los archivos de configuración y peguelos en la ruta:" + Environment.NewLine);
                    Mensaje.Append(Environment.NewLine + Environment.CurrentDirectory);
                    MessageBox.Show(Mensaje.ToString());
                    Application.Exit();
                    return;
                }

                if (!System.IO.Directory.Exists(Environment.CurrentDirectory + "\\LOGS\\"))
                    System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\LOGS\\");

                LogManager.AgregarLog("Inicia Carga de Configuraciones...");

                DBSettings = DBSettings.Deserialize<DBMSSettings>(true);
                ChecadoresSettings = ChecadoresSettings.Deserialize<AsistenciaSettings>(true);

                LogManager.AgregarLog("Las configuraciones fueron cargadas con exito.");
            }
            catch (Exception ex)
            {
                LogManager.AgregarLog("Ocurrio un eror al cargar los archivos de configuración");
                LogManager.AgregarLog();
                LogManager.AgregarLog(string.Format("Exception: {0}", ex.Message));

                sbMensaje.Append("Ocurrio un eror al cargar los archivos de configuración");
                sbMensaje.Append(Environment.NewLine);
                sbMensaje.Append(string.Format("Exception: {0}", ex.Message));

                MessageBox.Show(sbMensaje.ToString());

                Application.Exit();
            }
        }
        private void AsignarConceptos(List<Checada> lstChecada, List<Empleado> lstEmpleados)
        {
            int index = 0;
            string ClaveConcepto = string.Empty;
            ChecadasDAL oChecadasDAL = new ChecadasDAL();

            foreach (Checada oChecada in lstChecada)
            {
                // ** Obtener el empleado 
                Empleado oEmpleado = lstEmpleados.Where(o => o.id_interno == oChecada.id_interno).FirstOrDefault();
                if (oEmpleado != null && oEmpleado.activado)
                {
                    // ** Obtener Horario que aplica
                    int Dia_De_Checada = oChecada.fecha_hora.DayOfWeek.GetHashCode();
                    Horario oHorario = oEmpleado.lstHorarios.Where(o => o.dias_que_aplica[Dia_De_Checada] == '1').FirstOrDefault();
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
                                    // ** Por cada detalle preguntar el intervalo y asignar clave.
                                    if (oChecada.fecha_hora.TimeOfDay >= oDetalle.hora_minima &&
                                        oChecada.fecha_hora.TimeOfDay <= oDetalle.hora_maxima)
                                    {
                                        oChecada.oConcepto.clave = oDetalle.oConcepto.clave;
                                        oChecada.oConcepto.descripcion = oDetalle.oConcepto.descripcion;
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
                        }// Termina foreach (HorariosDetalles oDetalle in oHorario.lstDetalles)

                        oChecadasDAL.ActualizarChecada(oChecada);

                    }// Termina if (oHorario != null)
                }

                index++;
                lblAccion.Text = "Procesando registro número: (" + index + ") de un total de " + lstChecada.Count;
                Application.DoEvents();
            }

        }
        private bool ValidarConfiguraciones()
        {
            List<Checador> lstRemover = new List<Checador>();

            foreach (Checador oChecador in ChecadoresSettings.Checadores)
            {
                DBMS oServidor = DBSettings.Dbms.Find(o => o.Nombre == oChecador.Dbms);
                Configuracion.oChecador = oChecador;
                Configuracion.oServidor = oServidor;

                GenericDAL DAL = new GenericDAL();

                if (DAL.ProbarConexion() != true)
                {
                    LogManager.AgregarLog("No es posible conectarse a la base de datos del checador " + oChecador.Nombre);
                    lstRemover.Add(oChecador);
                }
            }

            foreach (Checador oChecador in lstRemover)
            {
                ChecadoresSettings.Checadores.Remove(oChecador);
                DBSettings.Dbms.RemoveAll(o => o.Nombre == oChecador.Dbms);
            }

            if (ChecadoresSettings.Checadores.Count == 0)
            {
                MessageBox.Show("No se pudo acceder a ningun checador", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return false;
            }

            return true;
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            if (!System.IO.Directory.Exists(Environment.CurrentDirectory + "\\LOGS\\"))
                System.IO.Directory.CreateDirectory(Environment.CurrentDirectory + "\\LOGS\\");

            LogManager.AgregarLog("Inicializando el sistema...");
            Application.DoEvents();

            CargarConfiguraciones();

            if (ValidarConfiguraciones() == true)
            {
                InicializarDatos();

                this.Hide();
                FrmPrincipal oFrmPrincipal = new FrmPrincipal(this.DBSettings, this.ChecadoresSettings);
                oFrmPrincipal.ShowDialog();

                this.Close();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void lblAccion_Click(object sender, EventArgs e)
        {

        }
    }
}
