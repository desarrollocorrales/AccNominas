using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AccSettings;
using AccAsistencia.Utilerias;
using AccAsistencia.DAL;
using AccAsistencia;
using System.IO;
using DevExpress.Spreadsheet;

namespace AccNominas.Formularios.Reportes
{
    public partial class frmHistorialC : Form
    {
        #region Variables
        private DBMSSettings DBSettings;
        private AsistenciaSettings ChecadoresSettings;
        private ChecadoresDAL obj_Checadores = new ChecadoresDAL(); List<Checadas> lstCh; List<Empleado> lstEmp = new List<Empleado>();
        string path = string.Empty; string archivoNuevo = string.Empty; string path_Destino = string.Empty;
        #endregion

        #region Constructor
        public frmHistorialC()
        {
            InitializeComponent();
        }

        public frmHistorialC(DBMSSettings DBSettings, AsistenciaSettings ChecadoresSettings)
        {
            InitializeComponent();
            this.DBSettings = DBSettings;
            this.ChecadoresSettings = ChecadoresSettings;

            ChecadoresSettings.Checadores = ChecadoresSettings.Checadores.OrderBy(o => o.Nombre).ToList();

            cbChecadores.DataSource = ChecadoresSettings.Checadores;
            cbChecadores.DisplayMember = "Nombre";
            
        }
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // fechas
                string fechaIni = this.dtpFechaInicio.Value.ToString("yyyy-MM-dd");
                string fechaFin = this.dtpFechaFin.Value.AddHours(24).ToString("yyyy-MM-dd");

                int nombre = -1, depto = -1;
                if (cbPorEmpl.Checked && cmbNombre.SelectedIndex > -1) nombre = ((Empleado)cmbNombre.SelectedItem).id_interno; ;
                if (cbDepto.Checked && cmbDpto.SelectedIndex > -1) depto = ((Departamento)cmbDpto.SelectedItem).Id;

                //Busqueda
                lstCh = new ChecadasDAL().getChecadas(fechaIni, fechaFin, nombre, depto);
                if (lstCh.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados en la búsqueda.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.gcChecadas.DataSource = null;
                this.gcChecadas.DataSource = lstCh;

                this.gridView1.BestFitColumns();
                pnEdita.Visible = false; pnInicio.Visible = true;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                pnEdita.Visible = true; pnInicio.Visible = false;
                int idemp = -1, idDepto = -1;
                if (cbPorEmpl.Checked && cmbNombre.SelectedIndex > -1) idemp = ((Empleado)cmbNombre.SelectedItem).id_interno; ;
                if (cbDepto.Checked && cmbDpto.SelectedIndex > -1) idDepto = ((Departamento)cmbDpto.SelectedItem).Id;
                

                if(idDepto == -1)
                    if(idemp == -1)
                        lstEmp = new EmpleadosDAL().ObtenerEmpleadosALL();
                    else
                        lstEmp = new EmpleadosDAL().ObtenerEmpleadosALL(" where id_interno = " + idemp);
                else
                    if(idemp == -1)
                        lstEmp = new EmpleadosDAL().ObtenerEmpleadosALL(" where id_depto = " + idDepto);
                    else
                        lstEmp = new EmpleadosDAL().ObtenerEmpleadosALL(" where id_depto = " + idDepto + " AND id_interno = " + idemp);

                if (lstEmp.Count > 0)
                {
                    dgvEmpleados.DataSource = null;
                    dgvEmpleados.DataSource = lstEmp;
                    formatoGrid(dgvEmpleados);

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnImpresion_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstCh.Count != 0)
                {
                    DateTime fechaInicial = dtpFechaInicio.Value.Date;
                    DateTime fechaFinal = dtpFechaFin.Value.Date;

                    //Crea el nuevo documento .xlsx para llenarlo con los datos y no afectar el documento Original
                    path = Environment.CurrentDirectory;
                    archivoNuevo = @"\HistorialChecadas" + DateTime.Now.ToString("yyyyMMddhhmmssss") + ".xlsx";
                    path_Destino = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    CopyFile(path + "\\HistorialChecadas.xlsx", path_Destino + archivoNuevo);
                    List<Checadas> Aux = lstCh;

                    var emp = Aux.GroupBy(n => n.empleado).ToList();

                    foreach (var empleado in emp)
                    {
                        Aux = lstCh.FindAll(o => o.empleado == empleado.Key.ToString()).ToList();
                        FormaOpenExcel(Aux, fechaInicial, fechaFinal);
                    }

                    MessageBox.Show("Los reportes se han generado correctamente.",
                                    "",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);

                    sscHistorial.LoadDocument(path_Destino + archivoNuevo);
                    sscHistorial.Document.Worksheets["Hoja1"].Visible = false;
                    sscHistorial.SaveDocument(path_Destino + archivoNuevo);

                    System.Diagnostics.Process.Start(path_Destino + archivoNuevo);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //
        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView grid = (DataGridView)sender;
                if (e.ColumnIndex >= 0)
                {
                    if (grid.Columns[e.ColumnIndex].Name == "btnEdit")
                    {
                        if (dgvEmpleados.CurrentRow != null)
                        {
                            Empleado Datos = new Empleado();
                            Datos = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;

                            tbIdInterno.Text = Datos.id_interno.ToString();
                            tbEmpleado.Text = Datos.nombre.ToString();

                            LlenaComboDepto(cmbDepto, Datos.id_depto);
                            cmbActivos.SelectedIndex = Datos.activo == "SI" ? 0 : 1;

                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnGuardaCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.tbIdInterno.Text))
                    return;
                if (string.IsNullOrEmpty(this.tbEmpleado.Text))
                    return;
                if (this.cmbDepto.SelectedIndex == -1)
                    return;

                string empleado = this.tbEmpleado.Text;
                int depto = (int)this.cmbDepto.SelectedValue;
                int idInterno = Convert.ToInt32(this.tbIdInterno.Text);
                int activado = cmbActivos.SelectedItem.ToString() == "SI" ? 1 : 0;

                bool resultado = new EmpleadosDAL().actEmpleados(idInterno, depto, empleado, activado);

                if (resultado)
                    MessageBox.Show("Empleado Actualizado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                cbPorEmpl.Checked = cbDepto.Checked = false;
                tbIdInterno.Text = tbEmpleado.Text = ""; cmbDepto.SelectedIndex = cmbActivos.SelectedIndex = -1;
                btnHistorial_Click(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cbChecadores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cbChecadores.SelectedIndex == -1) return;
                Configuracion.oChecador = (Checador)cbChecadores.SelectedItem;
                Configuracion.oServidor = DBSettings.Dbms.Where(o => o.Nombre == Configuracion.oChecador.Dbms).SingleOrDefault();

                cmbNumChecador.DataSource = obj_Checadores.getNumChec();
                dgvEmpleados.DataSource = gcChecadas.DataSource = null;
                cbDepto.Checked = cbPorEmpl.Checked = pnEdita.Visible = pnInicio.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cbChecadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChecadores.SelectedIndex == -1) return;
            cbChecadores_SelectionChangeCommitted(null, null);
        }

        private void cbDepto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.label7.Enabled = this.cbDepto.Checked;
                this.cmbDpto.Enabled = this.cbDepto.Checked;
                if (cbDepto.Checked)
                {
                    DepartamentosDAL oDepto = new DepartamentosDAL();
                    List<Departamento> lst = oDepto.ObtenerDepartamentos();

                    cmbDpto.ValueMember = "id";
                    cmbDpto.DisplayMember = "Nombre";
                    cmbDpto.DataSource = lst;
                    cmbNombre.SelectedIndex = -1;
                }
                else
                {
                    cmbDpto.DataSource = null;
                    cmbNombre.SelectedIndex = -1;
                    //btnBuscar_Click(null, null);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cbPorEmpl_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPorEmpl.Checked)
                {
                    this.cmbNombre.Enabled = this.label6.Enabled = this.cbPorEmpl.Checked;
                    EmpleadosDAL oEmpleadosDAL = new EmpleadosDAL(); List<Empleado> lst = new List<Empleado>();

                    if (cbDepto.Checked)
                    {
                        if (cmbDpto.SelectedIndex > -1)
                        {
                            int idDepto = ((List<Departamento>)cmbDpto.DataSource)[cmbDpto.SelectedIndex].Id;
                            lst = oEmpleadosDAL.ObtenerEmpleadosALL(" where id_depto = " + idDepto);
                        }
                    }
                    else
                    {
                        lst = oEmpleadosDAL.ObtenerEmpleadosALL();
                    }

                    cmbNombre.ValueMember = "idinterno";
                    cmbNombre.DisplayMember = "nombre";
                    cmbNombre.DataSource = lst;
                    cmbNombre.SelectedIndex = -1;
                }
                else
                {
                    this.label6.Enabled = this.cbPorEmpl.Checked;
                    this.cmbNombre.Enabled = this.cbPorEmpl.Checked;
                    cmbNombre.DataSource = null;
                    cmbNombre.SelectedIndex = -1;

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tbBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstEmp.Count == 0)
                    return;

                List<Empleado> lstAuxiliar = new List<Empleado>();
                lstAuxiliar = lstEmp.FindAll(o => o.id_interno.ToString().Contains(tbBusqueda.Text.ToUpper())
                                       || o.nombre.Contains(tbBusqueda.Text.ToUpper()));

                if (lstAuxiliar.Count > 0)
                {
                    dgvEmpleados.DataSource = lstAuxiliar;
                    formatoGrid(dgvEmpleados);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Checadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Metodos
        public string CopyFile(string source, string dest)
        {
            string result = "Copied file";
            try
            {
                // Overwrites existing files
                File.Copy(source, dest, true);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
        private void FormaOpenExcel(List<Checadas> Aux, DateTime fi, DateTime ff)
        {
            try
            {
                string nombre = string.Empty;
                if (Aux[0].empleado == "<PENDIENTE>" || Aux[0].empleado.Length > 31)
                    nombre = Aux[0].idInterno.ToString();
                else
                    nombre = Aux[0].empleado;

                //CARGA EL ARCHIVO .xlsx en el formulario
                sscHistorial.LoadDocument(path_Destino + archivoNuevo);
                sscHistorial.Document.Worksheets.Insert(sscHistorial.Document.Worksheets.Count, nombre);  //                 Add(oReporte.oEmpleado.nombre);
                sscHistorial.Document.Worksheets[nombre].CopyFrom(sscHistorial.Document.Worksheets["Hoja1"]);

                InsertaEncabezado(sscHistorial.Document, fi, ff, nombre);
                InsertaLinea(sscHistorial.Document, Aux, nombre);

                sscHistorial.SaveDocument(path_Destino + archivoNuevo);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InsertaEncabezado(IWorkbook workbook, DateTime fi, DateTime ff, string hojaN)
        {
            workbook.BeginUpdate();
            try
            {
                Worksheet worksheet = workbook.Worksheets[hojaN];

                worksheet.Cells["F4"].Value = fi.ToString("dd/MM/yyyy").ToUpper() + "  al  " + ff.ToString("dd/MM/yyyy").ToUpper();
                worksheet.Cells["F4"].Font.Size = 9;
                worksheet.Cells["B2"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                //worksheet.Cells["B2"].Font.FontStyle = SpreadsheetFontStyle.Bold;
                worksheet.Cells["B2"].Font.Size = 10;
                //worksheet.Cells["B2"].FillColor = Color.Coral;

                sscHistorial.Document.Worksheets[0].FreezeRows(0);
                sscHistorial.Document.Worksheets[0].FreezeRows(1);
            }
            catch (Exception x)
            { throw x; }
            finally
            {
                workbook.EndUpdate();
            }
        }
        private void InsertaLinea(IWorkbook Libro, List<Checadas> Aux, string hojaN)
        {
            try
            {
                Libro.BeginUpdate();
                try
                {
                    Worksheet Hoja = Libro.Worksheets[hojaN];
                    Hoja.Cells["C4"].Value = Aux[0].idInterno;
                    Hoja.Cells["C4"].FillColor = Color.LightGray;
                    //Hoja.Cells["C4"].Font.FontStyle = SpreadsheetFontStyle.Bold;
                    Hoja.Cells["C4"].Font.Size = 10;

                    Hoja.Cells["C5"].Value = Aux[0].empleado;
                    Hoja.Cells["C5"].FillColor = Color.LightGray;
                    Hoja.Cells["C5"].Font.FontStyle = SpreadsheetFontStyle.Bold;
                    Hoja.Cells["C5"].Font.Size = 10;

                    Checadas objChe = new Checadas();
                    for (int i = 0; i < Aux.Count; i++)
                    {
                        objChe = Aux[i];
                        DateTime fecha = Convert.ToDateTime(objChe.fechaHora.ToString());
                        Cell cellC = Hoja.Cells["C" + (7 + i).ToString()];
                        cellC.Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Dashed);
                        cellC.Value = fecha.ToShortDateString();

                        TimeSpan hora = new TimeSpan(fecha.Hour, fecha.Minute, fecha.Second);
                        Cell cellD = Hoja.Cells["D" + (7 + i).ToString()];
                        cellD.Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Dashed);
                        cellD.Value = hora.ToString();

                        Cell cellE = Hoja.Cells["E" + (7 + i).ToString()];
                        cellE.Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Dashed);
                        cellE.Value = objChe.departamento.ToString();

                    }

                }
                finally
                {
                    Libro.EndUpdate();
                }
            }
            catch (Exception x)
            { throw x; }
        }

        private void formatoGrid(DataGridView dgv, bool imprime = false)
        {
            try
            {
                foreach (DataGridViewColumn column in dgv.Columns)
                    column.Visible = false;

                dgv.Columns["id_interno"].Visible = true;
                dgv.Columns["id_interno"].DisplayIndex = 0;
                dgv.Columns["id_interno"].HeaderText = "ID Interno";
                dgv.Columns["id_interno"].Width = 50;
                dgv.Columns["id_interno"].ReadOnly = true;

                dgv.Columns["nombre"].Visible = true;
                dgv.Columns["nombre"].DisplayIndex = 1;
                dgv.Columns["nombre"].HeaderText = "Empleado";
                dgv.Columns["nombre"].Width = 250;
                dgv.Columns["nombre"].ReadOnly = true;

                dgv.Columns["activo"].Visible = true;
                dgv.Columns["activo"].DisplayIndex = 5;
                dgv.Columns["activo"].HeaderText = "Activo";
                dgv.Columns["activo"].Width = 50;
                dgv.Columns["activo"].ReadOnly = true;

                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "btnEdit";
                btnEdit.HeaderText = "Editar";
                btnEdit.Text = " ... ";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.Width = 50;
                dgv.Columns.Insert(dgv.Columns["activo"].DisplayIndex + 1, btnEdit);

                dgv.CurrentCell = dgv.Rows[0].Cells["id_interno"];

            }
            catch (Exception x)
            {
                throw x;
            }
        }

        private void LlenaComboDepto(ComboBox cmb, int iddepto)
        {
            try
            {
                DepartamentosDAL oDepto = new DepartamentosDAL();
                List<Departamento> lst = oDepto.ObtenerDepartamentos();

                cmb.ValueMember = "id";
                cmb.DisplayMember = "Nombre";
                cmb.DataSource = lst;

                if (lst.Count > 0)
                {
                    int x = 0;
                    foreach (Departamento elemento in ((List<Departamento>)cmb.DataSource))
                    {
                        if (elemento.Id == iddepto)
                        {
                            cmb.SelectedIndex = x;
                            break;
                        }
                        x++;
                    }
                }

            }
            catch(Exception x)
            { throw x;  }
        }
        #endregion

     }
}
