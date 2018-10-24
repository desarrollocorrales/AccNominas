using System;
using System.Linq;
using System.Windows.Forms;
using AccAsistencia;
using AccAsistencia.DAL;
using AccAsistencia.Utilerias;
using AccNominas.Formularios.Departamentos;
using AccNominas.Formularios.Empleados;
using AccNominas.Formularios.Horarios;
using AccNominas.Formularios.Reportes;
using AccNominas.Formularios.Usuarios;
using AccSettings;
using System.Configuration;
using System.Collections.Generic;

namespace AccNominas
{
    public partial class FrmPrincipal : Form
    {
        #region Variables
        string msj = string.Empty;
        private bool bTodos;
        private int RegistrosGrid = 18; private int pagina; private int iTotalPaginas; private int iTotalRegistros;
        private DBMSSettings DBSettings; private AsistenciaSettings ChecadoresSettings;
        frmMsj frmMensaje; frmHistorialC frmH;
        #endregion

        #region Constructor
        public FrmPrincipal(DBMSSettings DBSettings, AsistenciaSettings ChecadoresSettings)
        {
            InitializeComponent();
            this.DBSettings = DBSettings;
            this.ChecadoresSettings = ChecadoresSettings;

            ChecadoresSettings.Checadores = ChecadoresSettings.Checadores.OrderBy(o => o.Nombre).ToList();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
            llenarComboChecadores();
            pictLogo.ImageLocation = ".\\Pict\\LOGO.gif";
            btnDescarga.Focus();
        }
        #endregion

        #region Eventos
        private void btnRegistroAsistencia_Click(object sender, EventArgs e)
        {
            if (validarPermiso("reporte_asistencias_empleado") == false)
            {
                return;
            }

            try
            {
                if (bTodos)
                {
                    porEmpleadoToolStripMenuItem.Enabled = true;
                    MostrarAsistenciasTodos();
                }
                else
                {
                    porEmpleadoToolStripMenuItem.Enabled = true;
                    MostrarAsistencias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            imgLoading.Visible = true;
            Application.DoEvents();

            GridPrincipal.Visible = true;
            gridControl1.Visible = false;
            gridHorarios.Visible = false;
            pagina = 0;
            LlenarGridEmpleados(pagina);
            LlenarComboEmpleados();
            toolStrip1.Visible = true;
            toolStripButton4.Visible = true;
            btnRegistroAsistencia.Enabled = true;
            porEmpleadoToolStripMenuItem.Enabled = true;
            //btnNuevoID.Visible = true;

            imgLoading.Visible = false;
            Application.DoEvents();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                gridHorarios.Height = 439;
                gridHorarios.Visible = true;

                HorarioDAL DAL = new HorarioDAL();

                gridHorarios.DataSource = null;
                gridHorarios.DataSource = DAL.ObtenerHorariosParaGrid();

                btnRegistroAsistencia.Enabled = false;
                toolStrip1.Visible = false;
                GridPrincipal.Visible = false;
                gridControl1.Visible = false;
                txbPaginacion.Text = string.Empty;
                porEmpleadoToolStripMenuItem.Enabled = false;

                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
                //btnNuevoID.Visible = false;

                DAL = null;
                System.GC.Collect();

                imgLoading.Visible = false;
                LimpiarComboEmpleados();

                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                LlenarGridDepartamentos();
                GridPrincipal.Visible = false;
                gridHorarios.Visible = false;
                gridControl1.Height = 439;
                gridControl1.Visible = true;
                toolStrip1.Visible = true;
                toolStripButton4.Visible = false;
                btnRegistroAsistencia.Enabled = false;
                porEmpleadoToolStripMenuItem.Enabled = false;
                txbPaginacion.Text = string.Empty;
                btnSiguiente.Enabled = false;
                btnAnterior.Enabled = false;

                imgLoading.Visible = false;
                LimpiarComboEmpleados();
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChecadores_Click(object sender, EventArgs e)
        {
            try
            {
                if (Configuracion.oUsuario.username == "administrador")
                {
                    imgLoading.Visible = true;
                    Application.DoEvents();
                    LimpiarComboEmpleados();

                    new FrmChecadores().ShowDialog();

                    imgLoading.Visible = false;
                }
                else
                {

                    imgLoading.Visible = true;
                    Application.DoEvents();

                    new FrmAsignarChecador(ChecadoresSettings).ShowDialog();

                    imgLoading.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDescarga_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarComboEmpleados();
                if (cbChecadores.SelectedIndex == -1) return;

                Checador oChecador = (Checador)cbChecadores.SelectedItem;

                // ***** Obtener el servidor de base de datos
                DBMS oServidor = DBSettings.Dbms.Where(o => o.Nombre == oChecador.Dbms).SingleOrDefault();
                Configuracion.oChecador = oChecador;
                Configuracion.oServidor = oServidor;

                GenericDAL DAL = new GenericDAL();

                if (DAL.ProbarConexion() != true)
                {
                    frmMensaje = new frmMsj("No es posible conectarse a la base de datos del checador " + oChecador.Nombre);
                    frmMensaje.FormClosed += new FormClosedEventHandler(confirmaAG);
                    frmMensaje.ShowDialog();

                    LogManager.AgregarLog("No es posible conectarse a la base de datos del checador " + oChecador.Nombre);
                }
                /*******************************************/

                // ***** Obtener Checadas sin concepto

                Cursor = Cursors.WaitCursor;
                /*lblAccion.Text*/
                msj = "Obteniendo checadas sin concepto de " + oChecador.Nombre.ToUpper() + "..." + Environment.NewLine;
                //LogManager.AgregarLog(lblAccion.Text);
                Application.DoEvents();
                ChecadasDAL oChecadasDAL = new ChecadasDAL();
                List<Checada> lstChecadasSinConcepto = oChecadasDAL.ObtenerChecadasSinConcepto();

                // ***** Obtener Lista de empleados y sus horarios
                /*lblAccion.Text*/
                msj = msj + "Obteniendo lista de empleados de " + oChecador.Nombre.ToUpper() + "..." + Environment.NewLine;
                //LogManager.AgregarLog(lblAccion.Text);
                Application.DoEvents();
                EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL();
                List<Empleado> lstEmpleados = oEmpleadosDAL.ObtenerEmpleados();

                // ***** Asignar Conceptos a las checadas
                //lblAccion.Text = "Asignando conceptos a "+ lstChecadasSinConcepto.Count +" registros de la sucursal" + oChecador.Nombre.ToUpper() + "...";
                msj = msj + "Asignando conceptos a sucursal: " + oChecador.Nombre.ToUpper() + Environment.NewLine;
                LogManager.AgregarLog("Asignando conceptos a sucursal: " + oChecador.Nombre.ToUpper());
                Application.DoEvents();
                AsignarConceptos(lstChecadasSinConcepto, lstEmpleados);
                frmMensaje = new frmMsj(msj);
                frmMensaje.FormClosed += new FormClosedEventHandler(confirmaAG);
                frmMensaje.ShowDialog();

            }
            // ** Termina Try
            catch (Exception ex)
            {
                LogManager.AgregarLog("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                LogManager.AgregarLog(MensajeGlobal.Texto);
                LogManager.AgregarLog("Ocurrio Una Excepcion: " + e.ToString());
                LogManager.AgregarLog("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                MessageBox.Show("Ocurrio un error en el modulo: " + MensajeGlobal.Texto + Environment.NewLine + ex, ToString());
            }
            // ** Termina Catch
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                frmH = new frmHistorialC(DBSettings, ChecadoresSettings);
                frmH.FormClosed += new FormClosedEventHandler(frmHClosed);
                frmH.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //
        private void cbChecadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txbPaginacion.Text = string.Empty;
                btnRegistroAsistencia.Enabled = false;
                GridPrincipal.DataSource = null;
                gridControl1.DataSource = null;
                gridHorarios.DataSource = null;
                Configuracion.oChecador = (Checador)cbChecadores.SelectedItem;
                Configuracion.oServidor = DBSettings.Dbms.Where(o => o.Nombre == Configuracion.oChecador.Dbms).SingleOrDefault();

                CambiarBanderaTodos();
                LimpiarComboEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void asistenciaMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (GridPrincipal.Visible == true)
            {
                if (validarPermiso("alta_empleado") == false)
                {
                    return;
                }

                new FrmEmpleados().ShowDialog();

                imgLoading.Visible = true;
                Application.DoEvents();

                LlenarGridEmpleados(pagina);

                imgLoading.Visible = false;
            }
            if (gridControl1.Visible == true)
            {
                if (validarPermiso("alta_depto") == false)
                {
                    return;
                }

                new FrmDepartamentos().ShowDialog();

                imgLoading.Visible = true;
                Application.DoEvents();

                LlenarGridDepartamentos();

                imgLoading.Visible = false;
            }
            LimpiarComboEmpleados();
            LlenarComboEmpleados();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (GridPrincipal.Visible == true)
            {
                try
                {
                    if (validarPermiso("baja_empleado") == false)
                    {
                        return;
                    }

                    if (GridViewPrincipal.SelectedRowsCount == 1)
                    {
                        Empleado oEmpleado = (Empleado)GridViewPrincipal.GetFocusedRow();
                        DialogResult dr = MessageBox.Show("¿Esta seguro que desea borrar al siguiente empleado?" + Environment.NewLine + Environment.NewLine
                                                            + "ID Empleado: " + oEmpleado.id_interno + Environment.NewLine
                                                            + "Nombre: " + oEmpleado.nombre, "",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            new EmpleadosDAL().BorrarEmpleado(oEmpleado.id_interno);

                            imgLoading.Visible = true;
                            Application.DoEvents();

                            LlenarGridEmpleados(pagina);

                            imgLoading.Visible = false;
                        }
                    }
                }
                catch (Exception d)
                {
                    MessageBox.Show("Ocurrio un error: " + d.Message);
                }
            }
            if (gridControl1.Visible == true)
            {
                try
                {
                    if (validarPermiso("baja_depto") == false)
                    {
                        return;
                    }

                    if (GridViewDepartamentos.SelectedRowsCount == 1)
                    {
                        Departamento oDepartamento = (Departamento)GridViewDepartamentos.GetFocusedRow();
                        DialogResult dr = MessageBox.Show("Esta seguro que desea borrar al siguiente Departamento" + Environment.NewLine + Environment.NewLine +
                                                          "ID Departamento: " + oDepartamento.Id + Environment.NewLine +
                                                          "Nombre del Departamento: " + oDepartamento.Nombre, "",
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            new DepartamentosDAL().BorrarDepartamento(oDepartamento.Id);

                            imgLoading.Visible = true;
                            Application.DoEvents();

                            LlenarGridDepartamentos();

                            imgLoading.Visible = false;
                        }
                    }
                }
                catch (Exception d)
                {
                    MessageBox.Show("Ocurrio un error: " + d.Message);
                }
            }
            LimpiarComboEmpleados();
            LlenarComboEmpleados();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (GridPrincipal.Visible == true)
            {
                if (validarPermiso("cambio_empleado") == false)
                {
                    return;
                }

                Checador oChecador = (Checador)cbChecadores.SelectedItem;
                DBMS oServidor = DBSettings.Dbms.Where(o => o.Nombre == oChecador.Dbms).SingleOrDefault();
                if (GridViewPrincipal.SelectedRowsCount == 1)
                {
                    Empleado oEmpleado = (Empleado)GridViewPrincipal.GetFocusedRow();
                    FrmEmpleados modificar = new FrmEmpleados(oEmpleado.id_interno, oEmpleado.nombre, oEmpleado.departamento);
                    modificar.ShowDialog();

                    imgLoading.Visible = true;
                    Application.DoEvents();

                    LlenarGridEmpleados(pagina);

                    imgLoading.Visible = false;
                }
            }
            if (gridControl1.Visible == true)
            {
                if (validarPermiso("cambio_depto") == false)
                {
                    return;
                }
                Checador oChecador = (Checador)cbChecadores.SelectedItem;
                DBMS oServidor = DBSettings.Dbms.Where(o => o.Nombre == oChecador.Dbms).SingleOrDefault();
                if (GridViewDepartamentos.SelectedRowsCount == 1)
                {
                    Departamento oDepartamento = (Departamento)GridViewDepartamentos.GetFocusedRow();
                    FrmDepartamentos modificar = new FrmDepartamentos(oDepartamento.Id, oDepartamento.Nombre);
                    modificar.ShowDialog();
                    LlenarGridDepartamentos();
                }
            }
            LimpiarComboEmpleados();
            LlenarComboEmpleados();
        }

        private void nuevoHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validarPermiso("alta_horario") == false)
            {
                return;
            }

            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                new FrmHorarios().ShowDialog();

                imgLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modificarHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validarPermiso("cambio_horario") == false)
            {
                return;
            }

            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                new FrmHorarios(new Horario()).ShowDialog();

                imgLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void asignarHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validarPermiso("asignar_horario") == false)
            {
                return;
            }

            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                new FrmAsignarHorario().ShowDialog();
                imgLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void desasignarHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validarPermiso("desasignar_horario") == false)
            {
                return;
            }

            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                new FrmDesasignarHorario().ShowDialog();
                imgLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void desasignarHorarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (validarPermiso("desasignar_horario") == false)
            {
                return;
            }

            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();
                new FrmDesasignarHorario().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void porDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validarPermiso("reporte_asistencias_depto") == false)
            {
                return;
            }

            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                new FrmReporteAsistenciaDepartamento().ShowDialog();

                imgLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (validarPermiso("consultar_checadas_reales") == false)
            {
                return;
            }

            Empleado oEmpleado = (Empleado)GridViewPrincipal.GetFocusedRow();

            FrmConsultarTodo todo = new FrmConsultarTodo(oEmpleado);
            todo.ShowDialog();
        }

        private void recalcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validarPermiso("recalcular_asistencias") == false)
            {
                return;
            }

            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                new FrmRecalcular().ShowDialog();
                imgLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gvHorarios_EndGrouping(object sender, EventArgs e)
        {
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).ExpandAllGroups();
        }

        private void porEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validarPermiso("reporte_asistencias_empleado") == false)
            {
                return;
            }

            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                if (Configuracion.oChecador.DataBase == ConfigurationManager.AppSettings["db_todos"])
                {
                    MostrarAsistenciasTodos();
                }
                else
                {
                    MostrarAsistencias();
                }

                imgLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            imgLoading.Visible = true;
            Application.DoEvents();

            LlenarGridEmpleados(--pagina);

            imgLoading.Visible = false;
            Application.DoEvents();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                LlenarGridEmpleados(++pagina);

                imgLoading.Visible = false;
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validarPermiso("usuarios") == false)
            {
                return;
            }

            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                new FrmUsuarios().ShowDialog();

                imgLoading.Visible = false;
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void justificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ConsultarEmpleadoMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                new FrmConsultarEmpleados().ShowDialog();
                imgLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void desactivarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validarPermiso("desactivar_horario") == false)
            {
                return;
            }

            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                new FrmDesactivarHorario().ShowDialog();
                imgLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void prioridadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarPermiso("prioridad_horario") == false)
                {
                    return;
                }

                imgLoading.Visible = true;
                Application.DoEvents();

                new FrmCambiarPrioridad().ShowDialog();
                imgLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void justificacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarPermiso("reporte_justificaciones_empleado") == false)
                {
                    return;
                }

                imgLoading.Visible = true;
                Application.DoEvents();

                new FrmReporteJusticifaciones().ShowDialog();

                imgLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void feriadosVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validarPermiso("justificar_masivas") == false)
            {
                return;
            }

            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                new FrmFeriado().ShowDialog();
                imgLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void permisoLaboralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validarPermiso("justificar_masivas") == false)
            {
                return;
            }

            try
            {
                imgLoading.Visible = true;
                Application.DoEvents();

                new FrmFestivoLaborado().ShowDialog();
                imgLoading.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checadasPersonalizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgLoading.Visible = true;
            Application.DoEvents();

            new FrmChecadasPersonalizadas().ShowDialog();
            imgLoading.Visible = false;
        }
        #endregion

        #region Metodos

        private void MostrarAsistenciasTodos()
        {
            try
            {
                if (GridViewPrincipal.SelectedRowsCount == 1)
                {
                    Empleado oEmpleado = (Empleado)GridViewPrincipal.GetFocusedRow();
                    oEmpleado.lstHorarios = new EmpleadosDAL().ObtenerHorarios(oEmpleado.id_interno);
                    FrmAsistenciaTodosChecadores frmReporte =
                        new FrmAsistenciaTodosChecadores(oEmpleado);
                    frmReporte.ShowDialog();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error: " + e.Message);
            }
        }

        private void MostrarAsistencias()
        {
            try
            {
                if (GridViewPrincipal.SelectedRowsCount == 1)
                {
                    Empleado oEmpleado = (Empleado)GridViewPrincipal.GetFocusedRow();
                    FrmReporteAsistencia frmReporte = new FrmReporteAsistencia(oEmpleado);
                    frmReporte.ShowDialog();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error: " + e.Message);
            }
        }

        public void LlenarGridEmpleados(int pagina)
        {
            try
            {
                iTotalPaginas = 0;
                iTotalRegistros = 0;

                EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL();

                if (Configuracion.oChecador.DataBase == ConfigurationManager.AppSettings["db_todos"])
                {
                    GridPrincipal.DataSource = oEmpleadosDAL.ObtenerEmpleadosSencillosTodosLosChecadores(pagina, RegistrosGrid, out iTotalRegistros, out iTotalPaginas);
                }
                else
                {
                    GridPrincipal.DataSource = oEmpleadosDAL.ObtenerEmpleadoPaginado(pagina, RegistrosGrid, out iTotalRegistros, out iTotalPaginas);
                }

                GridPrincipal.Refresh();
                GridViewPrincipal.BestFitColumns();

                txbPaginacion.Text =
                    string.Format("Pagina {0} de {1}     Registros por pagina: {2}     Total de Registros: {3}",
                                   pagina + 1, iTotalPaginas, 18, iTotalRegistros);
                ActualizarNavegador(pagina);

                oEmpleadosDAL = null;
                System.GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
        }

        public void LlenarComboEmpleados()
        {
            try
            {
                EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL();
                List<Empleado> lst = oEmpleadosDAL.ObtenerEmpleadosSencillo();

                cmbEmpleados.ValueMember = "idinterno";
                cmbEmpleados.DisplayMember = "nombre";
                cmbEmpleados.DataSource = lst;
                cmbEmpleados.SelectedIndex = -1;

                cmbEmpleados.Visible = lblEmpleados.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
        }
        public void LimpiarComboEmpleados()
        {
            try
            {
                cmbEmpleados.DataSource = null;
                cmbEmpleados.SelectedIndex = -1;

                cmbEmpleados.Visible = lblEmpleados.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
        }

        public void LlenarGridEmpleado(int pagina, int idinterno)
        {
            try
            {
                iTotalPaginas = 0;
                iTotalRegistros = 0;

                EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL();

                GridPrincipal.DataSource = oEmpleadosDAL.ObtenerEmpleado(pagina, RegistrosGrid, idinterno, out iTotalRegistros, out iTotalPaginas);

                GridPrincipal.Refresh();
                GridViewPrincipal.BestFitColumns();

                txbPaginacion.Text =
                    string.Format("Pagina {0} de {1}     Registros por pagina: {2}     Total de Registros: {3}",
                                   pagina + 1, iTotalPaginas, 18, iTotalRegistros);
                ActualizarNavegador(pagina);

                oEmpleadosDAL = null;
                System.GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message);
            }
        }

        private void ActualizarNavegador(int pagina)
        {
            if (iTotalPaginas != 0)
            {
                if ((pagina + 1) == 1)
                {
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = true;
                }
                if ((pagina + 1) == iTotalPaginas)
                {
                    btnAnterior.Enabled = true;
                    btnSiguiente.Enabled = false;
                }
                if ((pagina + 1) > 1 && (pagina + 1) < iTotalPaginas)
                {
                    btnAnterior.Enabled = true;
                    btnSiguiente.Enabled = true;
                }
            }
            else
            {
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
            }

            if (iTotalPaginas == 1)
            {
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
            }
        }

        public void LlenarGridDepartamentos()
        {
            DepartamentosDAL oDepartamentosDAL = new DepartamentosDAL();
            gridControl1.DataSource = oDepartamentosDAL.ObtenerDepartamentos();
            gridControl1.Refresh();

            oDepartamentosDAL = null;
            System.GC.Collect();
        }

        private void llenarComboChecadores()
        {
            cbChecadores.DataSource = ChecadoresSettings.Checadores;
            cbChecadores.DisplayMember = "Nombre";
        }

        private bool validarPermiso(string permiso)
        {
            if (Configuracion.oUsuario.permisos.Contains(permiso))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Este usuario no tiene permiso para realizar esta accion.",
                                "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
        }

        private void CambiarBanderaTodos()
        {
            if (Configuracion.oChecador.DataBase == ConfigurationManager.AppSettings["db_todos"])
            {
                bTodos = true;
                btnChecadores.Enabled = true;
            }
            else
            {
                bTodos = false;
                btnChecadores.Enabled = false;
            }
        }

        private void AsignarConceptos(List<Checada> lstChecada, List<Empleado> lstEmpleados)
        {
            int index = 0;
            string ClaveConcepto = string.Empty;
            ChecadasDAL oChecadasDAL = new ChecadasDAL();
            HorarioDAL oHorarioDAL = new HorarioDAL();
            foreach (Checada oChecada in lstChecada)
            {
                // ** Obtener el empleado 
                Empleado oEmpleado = lstEmpleados.Where(o => o.id_interno == oChecada.id_interno).FirstOrDefault();
                if (oEmpleado != null && oEmpleado.activado)
                {
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
                            oChecadasDAL.ActualizarChecada(oChecada);
                        }// Termina foreach (HorariosDetalles oDetalle in oHorario.lstDetalles)
                    }// Termina if (oHorario != null)
                }

                index++;
                Application.DoEvents();
            }
            msj = msj + "Se Procesaron de un total de " + lstChecada.Count + " Checadas";
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

        private void confirmaAG(Object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.Default;
                if (frmMensaje.DialogResult.ToString() == "OK")
                {

                    frmMensaje.Close();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void cmbEmpleados_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmpleados.SelectedIndex == -1) return;

                GridPrincipal.Visible = true;
                gridControl1.Visible = false;
                gridHorarios.Visible = false;
                pagina = 0;

                LlenarGridEmpleado(pagina, ((List<Empleado>)cmbEmpleados.DataSource)[cmbEmpleados.SelectedIndex].id_interno);

                toolStrip1.Visible = true;
                toolStripButton4.Visible = true;
                btnRegistroAsistencia.Enabled = true;
                porEmpleadoToolStripMenuItem.Enabled = true;
                //btnNuevoID.Visible = true;

                imgLoading.Visible = false;
                Application.DoEvents();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void frmHClosed(object sender, EventArgs e)
        {
            try
            {
                if (frmH.DialogResult.ToString() == "OK")
                {
                    FrmPrincipal frmCon = new FrmPrincipal(DBSettings, ChecadoresSettings);
                    var resultado = frmCon.ShowDialog();

                    //if (resultado == System.Windows.Forms.DialogResult.OK)
                    //    this.FrmPrincipal_Load(null, null);
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion     

    }
}
