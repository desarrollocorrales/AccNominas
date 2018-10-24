namespace AccNominas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnDescarga = new System.Windows.Forms.Button();
            this.btnChecadores = new System.Windows.Forms.Button();
            this.btnDepartamentos = new System.Windows.Forms.Button();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.btnRegistroAsistencia = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.GridPrincipal = new DevExpress.XtraGrid.GridControl();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridViewPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_interno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvariado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbChecadores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarEmpleadoMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoHorarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarHorarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desactivarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.asignarHorarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desasignarHorarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prioridadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recalcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feriadosVacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisoLaboralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteMenusalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justificacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checadasPersonalizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridHorarios = new DevExpress.XtraGrid.GridControl();
            this.horarioGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvHorarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheca_dia_siguiente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colconcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_minima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_checada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_maxima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.txbPaginacion = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.GridViewDepartamentos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            this.panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPrincipal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioGridBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHorarios)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            this.panel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDepartamentos)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.Controls.Add(this.btnHistorial);
            this.panelSide.Controls.Add(this.btnDescarga);
            this.panelSide.Controls.Add(this.btnChecadores);
            this.panelSide.Controls.Add(this.btnDepartamentos);
            this.panelSide.Controls.Add(this.btnHorarios);
            this.panelSide.Controls.Add(this.btnRegistroAsistencia);
            this.panelSide.Controls.Add(this.btnEmpleados);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 125);
            this.panelSide.Margin = new System.Windows.Forms.Padding(4);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(137, 508);
            this.panelSide.TabIndex = 1;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnHistorial.Image = global::AccNominas.Properties.Resources.Fingerprint_Scan_48;
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHistorial.Location = new System.Drawing.Point(9, 424);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(118, 67);
            this.btnHistorial.TabIndex = 7;
            this.btnHistorial.Text = "Historial C.";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnDescarga
            // 
            this.btnDescarga.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDescarga.Image = global::AccNominas.Properties.Resources.download;
            this.btnDescarga.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDescarga.Location = new System.Drawing.Point(9, 3);
            this.btnDescarga.Margin = new System.Windows.Forms.Padding(4);
            this.btnDescarga.Name = "btnDescarga";
            this.btnDescarga.Size = new System.Drawing.Size(118, 67);
            this.btnDescarga.TabIndex = 6;
            this.btnDescarga.Text = "Obtener C.";
            this.btnDescarga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDescarga.UseVisualStyleBackColor = true;
            this.btnDescarga.Click += new System.EventHandler(this.btnDescarga_Click);
            // 
            // btnChecadores
            // 
            this.btnChecadores.Enabled = false;
            this.btnChecadores.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnChecadores.Image = global::AccNominas.Properties.Resources.checador;
            this.btnChecadores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChecadores.Location = new System.Drawing.Point(9, 356);
            this.btnChecadores.Margin = new System.Windows.Forms.Padding(4);
            this.btnChecadores.Name = "btnChecadores";
            this.btnChecadores.Size = new System.Drawing.Size(118, 67);
            this.btnChecadores.TabIndex = 5;
            this.btnChecadores.Text = "Checadores";
            this.btnChecadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChecadores.UseVisualStyleBackColor = true;
            this.btnChecadores.Click += new System.EventHandler(this.btnChecadores_Click);
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDepartamentos.Image = global::AccNominas.Properties.Resources.departamento;
            this.btnDepartamentos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDepartamentos.Location = new System.Drawing.Point(9, 285);
            this.btnDepartamentos.Margin = new System.Windows.Forms.Padding(4);
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.Size = new System.Drawing.Size(118, 67);
            this.btnDepartamentos.TabIndex = 4;
            this.btnDepartamentos.Text = "Departamentos";
            this.btnDepartamentos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartamentos.UseVisualStyleBackColor = true;
            this.btnDepartamentos.Click += new System.EventHandler(this.btnDepartamentos_Click);
            // 
            // btnHorarios
            // 
            this.btnHorarios.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnHorarios.Image = global::AccNominas.Properties.Resources.schedule_icon;
            this.btnHorarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHorarios.Location = new System.Drawing.Point(9, 145);
            this.btnHorarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(118, 67);
            this.btnHorarios.TabIndex = 3;
            this.btnHorarios.Text = "Horarios";
            this.btnHorarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHorarios.UseVisualStyleBackColor = true;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // btnRegistroAsistencia
            // 
            this.btnRegistroAsistencia.Enabled = false;
            this.btnRegistroAsistencia.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRegistroAsistencia.Image = global::AccNominas.Properties.Resources.reloj;
            this.btnRegistroAsistencia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistroAsistencia.Location = new System.Drawing.Point(9, 212);
            this.btnRegistroAsistencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistroAsistencia.Name = "btnRegistroAsistencia";
            this.btnRegistroAsistencia.Size = new System.Drawing.Size(118, 67);
            this.btnRegistroAsistencia.TabIndex = 2;
            this.btnRegistroAsistencia.Text = "Asistencia";
            this.btnRegistroAsistencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistroAsistencia.UseVisualStyleBackColor = true;
            this.btnRegistroAsistencia.Click += new System.EventHandler(this.btnRegistroAsistencia_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Image = global::AccNominas.Properties.Resources.user;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmpleados.Location = new System.Drawing.Point(9, 74);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(118, 67);
            this.btnEmpleados.TabIndex = 1;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // GridPrincipal
            // 
            this.GridPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridPrincipal.DataSource = this.empleadoBindingSource;
            this.GridPrincipal.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.GridPrincipal.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.GridPrincipal.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.GridPrincipal.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.GridPrincipal.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.GridPrincipal.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GridPrincipal.Location = new System.Drawing.Point(33, 28);
            this.GridPrincipal.MainView = this.GridViewPrincipal;
            this.GridPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.GridPrincipal.Name = "GridPrincipal";
            this.GridPrincipal.Size = new System.Drawing.Size(805, 460);
            this.GridPrincipal.TabIndex = 2;
            this.GridPrincipal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewPrincipal});
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(AccAsistencia.Empleado);
            // 
            // GridViewPrincipal
            // 
            this.GridViewPrincipal.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewPrincipal.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.GridViewPrincipal.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewPrincipal.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.GridViewPrincipal.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.GridViewPrincipal.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.GridViewPrincipal.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.GridViewPrincipal.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.GridViewPrincipal.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.GridViewPrincipal.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.GridViewPrincipal.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.GridViewPrincipal.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.GridViewPrincipal.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.GridViewPrincipal.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.GridViewPrincipal.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.GridViewPrincipal.Appearance.EvenRow.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.EvenRow.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewPrincipal.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.GridViewPrincipal.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewPrincipal.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.GridViewPrincipal.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.GridViewPrincipal.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.GridViewPrincipal.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.GridViewPrincipal.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.GridViewPrincipal.Appearance.FilterPanel.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.FilterPanel.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.GridViewPrincipal.Appearance.FixedLine.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.GridViewPrincipal.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.GridViewPrincipal.Appearance.FocusedCell.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.FocusedCell.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.GridViewPrincipal.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.GridViewPrincipal.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.FocusedRow.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewPrincipal.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.GridViewPrincipal.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewPrincipal.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.GridViewPrincipal.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.GridViewPrincipal.Appearance.FooterPanel.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.GridViewPrincipal.Appearance.FooterPanel.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.GridViewPrincipal.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.GridViewPrincipal.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.GridViewPrincipal.Appearance.GroupButton.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.GroupButton.Options.UseBorderColor = true;
            this.GridViewPrincipal.Appearance.GroupButton.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.GridViewPrincipal.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.GridViewPrincipal.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.GridViewPrincipal.Appearance.GroupFooter.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.GridViewPrincipal.Appearance.GroupFooter.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.GridViewPrincipal.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewPrincipal.Appearance.GroupPanel.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.GroupPanel.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.GridViewPrincipal.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.GridViewPrincipal.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.GridViewPrincipal.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.GridViewPrincipal.Appearance.GroupRow.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.GroupRow.Options.UseBorderColor = true;
            this.GridViewPrincipal.Appearance.GroupRow.Options.UseFont = true;
            this.GridViewPrincipal.Appearance.GroupRow.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewPrincipal.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.GridViewPrincipal.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewPrincipal.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.GridViewPrincipal.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.GridViewPrincipal.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.GridViewPrincipal.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.GridViewPrincipal.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.GridViewPrincipal.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.GridViewPrincipal.Appearance.HorzLine.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.GridViewPrincipal.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.GridViewPrincipal.Appearance.OddRow.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.OddRow.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.GridViewPrincipal.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.GridViewPrincipal.Appearance.Preview.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.Preview.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.GridViewPrincipal.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.GridViewPrincipal.Appearance.Row.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.Row.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.GridViewPrincipal.Appearance.RowSeparator.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.GridViewPrincipal.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.GridViewPrincipal.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridViewPrincipal.Appearance.SelectedRow.Options.UseForeColor = true;
            this.GridViewPrincipal.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.GridViewPrincipal.Appearance.VertLine.Options.UseBackColor = true;
            this.GridViewPrincipal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_interno,
            this.colnombre,
            this.coldepartamento,
            this.colactivado,
            this.colvariado});
            this.GridViewPrincipal.GridControl = this.GridPrincipal;
            this.GridViewPrincipal.Name = "GridViewPrincipal";
            this.GridViewPrincipal.OptionsBehavior.Editable = false;
            this.GridViewPrincipal.OptionsCustomization.AllowColumnMoving = false;
            this.GridViewPrincipal.OptionsCustomization.AllowFilter = false;
            this.GridViewPrincipal.OptionsView.EnableAppearanceEvenRow = true;
            this.GridViewPrincipal.OptionsView.EnableAppearanceOddRow = true;
            // 
            // colid_interno
            // 
            this.colid_interno.AppearanceCell.Options.UseTextOptions = true;
            this.colid_interno.AppearanceHeader.Options.UseTextOptions = true;
            this.colid_interno.Caption = "ID Interno";
            this.colid_interno.FieldName = "id_interno";
            this.colid_interno.Name = "colid_interno";
            this.colid_interno.Visible = true;
            this.colid_interno.VisibleIndex = 0;
            // 
            // colnombre
            // 
            this.colnombre.AppearanceHeader.Options.UseTextOptions = true;
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            // 
            // coldepartamento
            // 
            this.coldepartamento.AppearanceHeader.Options.UseTextOptions = true;
            this.coldepartamento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldepartamento.Caption = "Departamento";
            this.coldepartamento.FieldName = "departamento.Nombre";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 2;
            // 
            // colactivado
            // 
            this.colactivado.Caption = "Activado";
            this.colactivado.FieldName = "activado";
            this.colactivado.Name = "colactivado";
            // 
            // colvariado
            // 
            this.colvariado.FieldName = "variado";
            this.colvariado.Name = "colvariado";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(958, 53);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Control de Asistencias";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbChecadores
            // 
            this.cbChecadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChecadores.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChecadores.FormattingEnabled = true;
            this.cbChecadores.Location = new System.Drawing.Point(395, 66);
            this.cbChecadores.Margin = new System.Windows.Forms.Padding(4);
            this.cbChecadores.Name = "cbChecadores";
            this.cbChecadores.Size = new System.Drawing.Size(272, 26);
            this.cbChecadores.TabIndex = 4;
            this.cbChecadores.SelectedIndexChanged += new System.EventHandler(this.cbChecadores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Checador:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmpleadosToolStripMenuItem,
            this.horariosToolStripMenuItem,
            this.recalcularToolStripMenuItem,
            this.justificacionesToolStripMenuItem,
            this.reportesToolStripMenuItem1,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1009, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EmpleadosToolStripMenuItem
            // 
            this.EmpleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsultarEmpleadoMensualToolStripMenuItem});
            this.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem";
            this.EmpleadosToolStripMenuItem.Size = new System.Drawing.Size(77, 19);
            this.EmpleadosToolStripMenuItem.Text = "Empleados";
            // 
            // ConsultarEmpleadoMensualToolStripMenuItem
            // 
            this.ConsultarEmpleadoMensualToolStripMenuItem.Name = "ConsultarEmpleadoMensualToolStripMenuItem";
            this.ConsultarEmpleadoMensualToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.ConsultarEmpleadoMensualToolStripMenuItem.Text = "Consultar";
            this.ConsultarEmpleadoMensualToolStripMenuItem.Click += new System.EventHandler(this.ConsultarEmpleadoMensualToolStripMenuItem_Click);
            // 
            // horariosToolStripMenuItem
            // 
            this.horariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoHorarioToolStripMenuItem,
            this.modificarHorarioToolStripMenuItem,
            this.desactivarToolStripMenuItem,
            this.toolStripSeparator1,
            this.asignarHorarioToolStripMenuItem,
            this.desasignarHorarioToolStripMenuItem,
            this.prioridadesToolStripMenuItem});
            this.horariosToolStripMenuItem.Name = "horariosToolStripMenuItem";
            this.horariosToolStripMenuItem.Size = new System.Drawing.Size(64, 19);
            this.horariosToolStripMenuItem.Text = "Horarios";
            // 
            // nuevoHorarioToolStripMenuItem
            // 
            this.nuevoHorarioToolStripMenuItem.Name = "nuevoHorarioToolStripMenuItem";
            this.nuevoHorarioToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.nuevoHorarioToolStripMenuItem.Text = "Nuevo";
            this.nuevoHorarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoHorarioToolStripMenuItem_Click);
            // 
            // modificarHorarioToolStripMenuItem
            // 
            this.modificarHorarioToolStripMenuItem.Name = "modificarHorarioToolStripMenuItem";
            this.modificarHorarioToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.modificarHorarioToolStripMenuItem.Text = "Modificar";
            this.modificarHorarioToolStripMenuItem.Click += new System.EventHandler(this.modificarHorarioToolStripMenuItem_Click);
            // 
            // desactivarToolStripMenuItem
            // 
            this.desactivarToolStripMenuItem.Name = "desactivarToolStripMenuItem";
            this.desactivarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.desactivarToolStripMenuItem.Text = "Desactivar";
            this.desactivarToolStripMenuItem.Click += new System.EventHandler(this.desactivarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // asignarHorarioToolStripMenuItem
            // 
            this.asignarHorarioToolStripMenuItem.Name = "asignarHorarioToolStripMenuItem";
            this.asignarHorarioToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.asignarHorarioToolStripMenuItem.Text = "Asignar";
            this.asignarHorarioToolStripMenuItem.Click += new System.EventHandler(this.asignarHorarioToolStripMenuItem_Click);
            // 
            // desasignarHorarioToolStripMenuItem
            // 
            this.desasignarHorarioToolStripMenuItem.Name = "desasignarHorarioToolStripMenuItem";
            this.desasignarHorarioToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.desasignarHorarioToolStripMenuItem.Text = "Desasignar";
            this.desasignarHorarioToolStripMenuItem.Click += new System.EventHandler(this.desasignarHorarioToolStripMenuItem_Click);
            // 
            // prioridadesToolStripMenuItem
            // 
            this.prioridadesToolStripMenuItem.Name = "prioridadesToolStripMenuItem";
            this.prioridadesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.prioridadesToolStripMenuItem.Text = "Prioridades";
            this.prioridadesToolStripMenuItem.Click += new System.EventHandler(this.prioridadesToolStripMenuItem_Click);
            // 
            // recalcularToolStripMenuItem
            // 
            this.recalcularToolStripMenuItem.Name = "recalcularToolStripMenuItem";
            this.recalcularToolStripMenuItem.Size = new System.Drawing.Size(134, 19);
            this.recalcularToolStripMenuItem.Text = "Recalcular Asistencias";
            this.recalcularToolStripMenuItem.Click += new System.EventHandler(this.recalcularToolStripMenuItem_Click);
            // 
            // justificacionesToolStripMenuItem
            // 
            this.justificacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feriadosVacacionesToolStripMenuItem,
            this.permisoLaboralToolStripMenuItem});
            this.justificacionesToolStripMenuItem.Name = "justificacionesToolStripMenuItem";
            this.justificacionesToolStripMenuItem.Size = new System.Drawing.Size(95, 19);
            this.justificacionesToolStripMenuItem.Text = "Justificaciones";
            this.justificacionesToolStripMenuItem.Click += new System.EventHandler(this.justificacionesToolStripMenuItem_Click);
            // 
            // feriadosVacacionesToolStripMenuItem
            // 
            this.feriadosVacacionesToolStripMenuItem.Name = "feriadosVacacionesToolStripMenuItem";
            this.feriadosVacacionesToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.feriadosVacacionesToolStripMenuItem.Text = "Dias no laborados";
            this.feriadosVacacionesToolStripMenuItem.Click += new System.EventHandler(this.feriadosVacacionesToolStripMenuItem_Click);
            // 
            // permisoLaboralToolStripMenuItem
            // 
            this.permisoLaboralToolStripMenuItem.Name = "permisoLaboralToolStripMenuItem";
            this.permisoLaboralToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.permisoLaboralToolStripMenuItem.Text = "Excepciones a dias no laborados";
            this.permisoLaboralToolStripMenuItem.Click += new System.EventHandler(this.permisoLaboralToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem1
            // 
            this.reportesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteMenusalToolStripMenuItem,
            this.justificacionesToolStripMenuItem1,
            this.checadasPersonalizadasToolStripMenuItem});
            this.reportesToolStripMenuItem1.Name = "reportesToolStripMenuItem1";
            this.reportesToolStripMenuItem1.Size = new System.Drawing.Size(65, 19);
            this.reportesToolStripMenuItem1.Text = "Reportes";
            // 
            // reporteMenusalToolStripMenuItem
            // 
            this.reporteMenusalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porEmpleadoToolStripMenuItem,
            this.porDepartamentoToolStripMenuItem});
            this.reporteMenusalToolStripMenuItem.Name = "reporteMenusalToolStripMenuItem";
            this.reporteMenusalToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.reporteMenusalToolStripMenuItem.Text = "Asistencias";
            // 
            // porEmpleadoToolStripMenuItem
            // 
            this.porEmpleadoToolStripMenuItem.Enabled = false;
            this.porEmpleadoToolStripMenuItem.Name = "porEmpleadoToolStripMenuItem";
            this.porEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.porEmpleadoToolStripMenuItem.Text = "Por Empleado";
            this.porEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.porEmpleadoToolStripMenuItem_Click);
            // 
            // porDepartamentoToolStripMenuItem
            // 
            this.porDepartamentoToolStripMenuItem.Name = "porDepartamentoToolStripMenuItem";
            this.porDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.porDepartamentoToolStripMenuItem.Text = "Por Departamento";
            this.porDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.porDepartamentoToolStripMenuItem_Click);
            // 
            // justificacionesToolStripMenuItem1
            // 
            this.justificacionesToolStripMenuItem1.Name = "justificacionesToolStripMenuItem1";
            this.justificacionesToolStripMenuItem1.Size = new System.Drawing.Size(205, 22);
            this.justificacionesToolStripMenuItem1.Text = "Justificaciones";
            this.justificacionesToolStripMenuItem1.Click += new System.EventHandler(this.justificacionesToolStripMenuItem1_Click);
            // 
            // checadasPersonalizadasToolStripMenuItem
            // 
            this.checadasPersonalizadasToolStripMenuItem.Name = "checadasPersonalizadasToolStripMenuItem";
            this.checadasPersonalizadasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.checadasPersonalizadasToolStripMenuItem.Text = "Checadas personalizadas";
            this.checadasPersonalizadasToolStripMenuItem.Click += new System.EventHandler(this.checadasPersonalizadasToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 19);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataSource = typeof(AccAsistencia.Departamento);
            // 
            // gridHorarios
            // 
            this.gridHorarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridHorarios.DataSource = this.horarioGridBindingSource;
            this.gridHorarios.Location = new System.Drawing.Point(33, 28);
            this.gridHorarios.MainView = this.gvHorarios;
            this.gridHorarios.Name = "gridHorarios";
            this.gridHorarios.Size = new System.Drawing.Size(805, 209);
            this.gridHorarios.TabIndex = 9;
            this.gridHorarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHorarios});
            this.gridHorarios.Visible = false;
            // 
            // horarioGridBindingSource
            // 
            this.horarioGridBindingSource.DataSource = typeof(AccAsistencia.HorarioGrid);
            // 
            // gvHorarios
            // 
            this.gvHorarios.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorarios.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvHorarios.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorarios.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvHorarios.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvHorarios.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvHorarios.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvHorarios.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvHorarios.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvHorarios.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvHorarios.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvHorarios.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvHorarios.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvHorarios.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvHorarios.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvHorarios.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvHorarios.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvHorarios.Appearance.Empty.Options.UseBackColor = true;
            this.gvHorarios.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvHorarios.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvHorarios.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvHorarios.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvHorarios.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorarios.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvHorarios.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorarios.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvHorarios.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvHorarios.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvHorarios.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvHorarios.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvHorarios.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvHorarios.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvHorarios.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvHorarios.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvHorarios.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvHorarios.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvHorarios.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvHorarios.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvHorarios.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvHorarios.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvHorarios.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvHorarios.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvHorarios.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvHorarios.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvHorarios.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorarios.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvHorarios.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorarios.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvHorarios.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvHorarios.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvHorarios.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvHorarios.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvHorarios.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvHorarios.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvHorarios.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvHorarios.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvHorarios.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvHorarios.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvHorarios.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvHorarios.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvHorarios.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvHorarios.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvHorarios.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvHorarios.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvHorarios.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvHorarios.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorarios.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvHorarios.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvHorarios.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvHorarios.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvHorarios.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvHorarios.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvHorarios.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvHorarios.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvHorarios.Appearance.GroupRow.Options.UseFont = true;
            this.gvHorarios.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvHorarios.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorarios.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvHorarios.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorarios.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvHorarios.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvHorarios.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvHorarios.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvHorarios.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvHorarios.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvHorarios.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvHorarios.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvHorarios.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvHorarios.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvHorarios.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvHorarios.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvHorarios.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvHorarios.Appearance.OddRow.Options.UseBackColor = true;
            this.gvHorarios.Appearance.OddRow.Options.UseForeColor = true;
            this.gvHorarios.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvHorarios.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvHorarios.Appearance.Preview.Options.UseBackColor = true;
            this.gvHorarios.Appearance.Preview.Options.UseForeColor = true;
            this.gvHorarios.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvHorarios.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvHorarios.Appearance.Row.Options.UseBackColor = true;
            this.gvHorarios.Appearance.Row.Options.UseForeColor = true;
            this.gvHorarios.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvHorarios.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvHorarios.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvHorarios.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvHorarios.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvHorarios.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvHorarios.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvHorarios.Appearance.VertLine.Options.UseBackColor = true;
            this.gvHorarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion,
            this.colcheca_dia_siguiente,
            this.colconcepto,
            this.colhora_minima,
            this.colhora_checada,
            this.colhora_maxima});
            this.gvHorarios.GridControl = this.gridHorarios;
            this.gvHorarios.GroupCount = 1;
            this.gvHorarios.Name = "gvHorarios";
            this.gvHorarios.OptionsBehavior.Editable = false;
            this.gvHorarios.OptionsCustomization.AllowColumnMoving = false;
            this.gvHorarios.OptionsCustomization.AllowFilter = false;
            this.gvHorarios.OptionsView.EnableAppearanceEvenRow = true;
            this.gvHorarios.OptionsView.EnableAppearanceOddRow = true;
            this.gvHorarios.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coldescripcion, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvHorarios.EndGrouping += new System.EventHandler(this.gvHorarios_EndGrouping);
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // colcheca_dia_siguiente
            // 
            this.colcheca_dia_siguiente.Caption = "Checa al dia siguiente";
            this.colcheca_dia_siguiente.FieldName = "checa_dia_siguiente";
            this.colcheca_dia_siguiente.Name = "colcheca_dia_siguiente";
            this.colcheca_dia_siguiente.Visible = true;
            this.colcheca_dia_siguiente.VisibleIndex = 0;
            // 
            // colconcepto
            // 
            this.colconcepto.Caption = "Concepto";
            this.colconcepto.FieldName = "concepto";
            this.colconcepto.Name = "colconcepto";
            this.colconcepto.Visible = true;
            this.colconcepto.VisibleIndex = 1;
            // 
            // colhora_minima
            // 
            this.colhora_minima.Caption = "Hora Minima";
            this.colhora_minima.DisplayFormat.FormatString = "HH:mm";
            this.colhora_minima.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colhora_minima.FieldName = "hora_minima";
            this.colhora_minima.Name = "colhora_minima";
            this.colhora_minima.Visible = true;
            this.colhora_minima.VisibleIndex = 2;
            // 
            // colhora_checada
            // 
            this.colhora_checada.Caption = "Hora de Checada";
            this.colhora_checada.DisplayFormat.FormatString = "HH:mm";
            this.colhora_checada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colhora_checada.FieldName = "hora_checada";
            this.colhora_checada.Name = "colhora_checada";
            this.colhora_checada.Visible = true;
            this.colhora_checada.VisibleIndex = 3;
            // 
            // colhora_maxima
            // 
            this.colhora_maxima.Caption = "Hora Maxima";
            this.colhora_maxima.DisplayFormat.FormatString = "HH:mm";
            this.colhora_maxima.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colhora_maxima.FieldName = "hora_maxima";
            this.colhora_maxima.Name = "colhora_maxima";
            this.colhora_maxima.Visible = true;
            this.colhora_maxima.VisibleIndex = 4;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Font = new System.Drawing.Font("Wingdings 3", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnAnterior.Location = new System.Drawing.Point(0, 27);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(32, 455);
            this.btnAnterior.TabIndex = 10;
            this.btnAnterior.Text = "t";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.AutoSize = true;
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Font = new System.Drawing.Font("Wingdings 3", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnSiguiente.Location = new System.Drawing.Point(840, 27);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(32, 455);
            this.btnSiguiente.TabIndex = 12;
            this.btnSiguiente.Text = "u";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.imgLoading);
            this.panel2.Controls.Add(this.gridHorarios);
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.btnAnterior);
            this.panel2.Controls.Add(this.txbPaginacion);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Controls.Add(this.GridPrincipal);
            this.panel2.Location = new System.Drawing.Point(137, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(872, 508);
            this.panel2.TabIndex = 13;
            // 
            // imgLoading
            // 
            this.imgLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLoading.Image = global::AccNominas.Properties.Resources.cargando;
            this.imgLoading.Location = new System.Drawing.Point(352, 207);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(169, 94);
            this.imgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLoading.TabIndex = 15;
            this.imgLoading.TabStop = false;
            this.imgLoading.Visible = false;
            // 
            // txbPaginacion
            // 
            this.txbPaginacion.BackColor = System.Drawing.Color.White;
            this.txbPaginacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbPaginacion.Enabled = false;
            this.txbPaginacion.Location = new System.Drawing.Point(0, 482);
            this.txbPaginacion.Name = "txbPaginacion";
            this.txbPaginacion.Size = new System.Drawing.Size(872, 26);
            this.txbPaginacion.TabIndex = 13;
            this.txbPaginacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.lblEmpleados);
            this.panel4.Controls.Add(this.cmbEmpleados);
            this.panel4.Controls.Add(this.toolStrip1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(872, 27);
            this.panel4.TabIndex = 14;
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.Location = new System.Drawing.Point(36, 5);
            this.lblEmpleados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(74, 18);
            this.lblEmpleados.TabIndex = 9;
            this.lblEmpleados.Text = "Empleado:";
            this.lblEmpleados.Visible = false;
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleados.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(119, 1);
            this.cmbEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(272, 26);
            this.cmbEmpleados.TabIndex = 8;
            this.cmbEmpleados.Visible = false;
            this.cmbEmpleados.SelectionChangeCommitted += new System.EventHandler(this.cmbEmpleados_SelectionChangeCommitted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(734, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(104, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::AccNominas.Properties.Resources.add1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Nuevo";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::AccNominas.Properties.Resources.delete;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Borrar";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::AccNominas.Properties.Resources.pencil;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Modificar";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::AccNominas.Properties.Resources.checadas;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Checadas Reales";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.departamentoBindingSource;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.Location = new System.Drawing.Point(33, 28);
            this.gridControl1.MainView = this.GridViewDepartamentos;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(805, 347);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewDepartamentos});
            this.gridControl1.Visible = false;
            // 
            // GridViewDepartamentos
            // 
            this.GridViewDepartamentos.ActiveFilterEnabled = false;
            this.GridViewDepartamentos.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewDepartamentos.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.GridViewDepartamentos.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewDepartamentos.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.GridViewDepartamentos.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.GridViewDepartamentos.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.GridViewDepartamentos.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.GridViewDepartamentos.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.GridViewDepartamentos.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.GridViewDepartamentos.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.GridViewDepartamentos.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.GridViewDepartamentos.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.GridViewDepartamentos.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.GridViewDepartamentos.Appearance.Empty.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.GridViewDepartamentos.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.GridViewDepartamentos.Appearance.EvenRow.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.EvenRow.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewDepartamentos.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.GridViewDepartamentos.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewDepartamentos.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.GridViewDepartamentos.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.GridViewDepartamentos.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.GridViewDepartamentos.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.GridViewDepartamentos.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.GridViewDepartamentos.Appearance.FilterPanel.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.FilterPanel.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.GridViewDepartamentos.Appearance.FixedLine.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.GridViewDepartamentos.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.GridViewDepartamentos.Appearance.FocusedCell.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.FocusedCell.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.GridViewDepartamentos.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.GridViewDepartamentos.Appearance.FocusedRow.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.FocusedRow.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewDepartamentos.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.GridViewDepartamentos.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewDepartamentos.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.GridViewDepartamentos.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.GridViewDepartamentos.Appearance.FooterPanel.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.GridViewDepartamentos.Appearance.FooterPanel.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.GridViewDepartamentos.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.GridViewDepartamentos.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.GridViewDepartamentos.Appearance.GroupButton.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.GroupButton.Options.UseBorderColor = true;
            this.GridViewDepartamentos.Appearance.GroupButton.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.GridViewDepartamentos.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.GridViewDepartamentos.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.GridViewDepartamentos.Appearance.GroupFooter.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.GridViewDepartamentos.Appearance.GroupFooter.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.GridViewDepartamentos.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewDepartamentos.Appearance.GroupPanel.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.GroupPanel.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.GridViewDepartamentos.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.GridViewDepartamentos.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.GridViewDepartamentos.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.GridViewDepartamentos.Appearance.GroupRow.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.GroupRow.Options.UseBorderColor = true;
            this.GridViewDepartamentos.Appearance.GroupRow.Options.UseFont = true;
            this.GridViewDepartamentos.Appearance.GroupRow.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewDepartamentos.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.GridViewDepartamentos.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.GridViewDepartamentos.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.GridViewDepartamentos.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.GridViewDepartamentos.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.GridViewDepartamentos.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.GridViewDepartamentos.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.GridViewDepartamentos.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.GridViewDepartamentos.Appearance.HorzLine.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.GridViewDepartamentos.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.GridViewDepartamentos.Appearance.OddRow.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.OddRow.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.GridViewDepartamentos.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.GridViewDepartamentos.Appearance.Preview.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.Preview.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.GridViewDepartamentos.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.GridViewDepartamentos.Appearance.Row.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.Row.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.GridViewDepartamentos.Appearance.RowSeparator.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.GridViewDepartamentos.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.GridViewDepartamentos.Appearance.SelectedRow.Options.UseBackColor = true;
            this.GridViewDepartamentos.Appearance.SelectedRow.Options.UseForeColor = true;
            this.GridViewDepartamentos.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.GridViewDepartamentos.Appearance.VertLine.Options.UseBackColor = true;
            this.GridViewDepartamentos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNombre1,
            this.colEstatus});
            this.GridViewDepartamentos.GridControl = this.gridControl1;
            this.GridViewDepartamentos.Name = "GridViewDepartamentos";
            this.GridViewDepartamentos.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewDepartamentos.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GridViewDepartamentos.OptionsBehavior.Editable = false;
            this.GridViewDepartamentos.OptionsCustomization.AllowColumnMoving = false;
            this.GridViewDepartamentos.OptionsCustomization.AllowColumnResizing = false;
            this.GridViewDepartamentos.OptionsCustomization.AllowGroup = false;
            this.GridViewDepartamentos.OptionsFilter.AllowColumnMRUFilterList = false;
            this.GridViewDepartamentos.OptionsView.EnableAppearanceEvenRow = true;
            this.GridViewDepartamentos.OptionsView.EnableAppearanceOddRow = true;
            this.GridViewDepartamentos.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.AppearanceCell.Options.UseTextOptions = true;
            this.colId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.AppearanceHeader.Options.UseTextOptions = true;
            this.colId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colId.Caption = "ID Departamento";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colNombre1
            // 
            this.colNombre1.AppearanceCell.Options.UseTextOptions = true;
            this.colNombre1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombre1.AppearanceHeader.Options.UseTextOptions = true;
            this.colNombre1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNombre1.Caption = "Nombre del Departamento";
            this.colNombre1.FieldName = "Nombre";
            this.colNombre1.Name = "colNombre1";
            this.colNombre1.Visible = true;
            this.colNombre1.VisibleIndex = 1;
            // 
            // colEstatus
            // 
            this.colEstatus.FieldName = "Estatus";
            this.colEstatus.Name = "colEstatus";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictLogo);
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbChecadores);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 100);
            this.panel3.TabIndex = 14;
            // 
            // pictLogo
            // 
            this.pictLogo.Location = new System.Drawing.Point(12, 4);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(246, 92);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictLogo.TabIndex = 6;
            this.pictLogo.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 633);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Asistencia";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewPrincipal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioGridBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHorarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDepartamentos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Button btnHorarios;
        private System.Windows.Forms.Button btnRegistroAsistencia;
        private System.Windows.Forms.Button btnEmpleados;
        private DevExpress.XtraGrid.GridControl GridPrincipal;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewPrincipal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbChecadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultarEmpleadoMensualToolStripMenuItem;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_interno;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colactivado;
        private DevExpress.XtraGrid.Columns.GridColumn colvariado;
        private System.Windows.Forms.Button btnDepartamentos;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private System.Windows.Forms.ToolStripMenuItem horariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoHorarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarHorarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarHorarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reporteMenusalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desasignarHorarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porDepartamentoToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl gridHorarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHorarios;
        private System.Windows.Forms.BindingSource horarioGridBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcheca_dia_siguiente;
        private DevExpress.XtraGrid.Columns.GridColumn colconcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_minima;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_checada;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_maxima;
        private System.Windows.Forms.ToolStripMenuItem recalcularToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewDepartamentos;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colEstatus;
        private System.Windows.Forms.TextBox txbPaginacion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desactivarToolStripMenuItem;
        private System.Windows.Forms.Button btnChecadores;
        private System.Windows.Forms.ToolStripMenuItem prioridadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justificacionesToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictLogo;
        private System.Windows.Forms.ToolStripMenuItem feriadosVacacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisoLaboralToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgLoading;
        private System.Windows.Forms.ToolStripMenuItem checadasPersonalizadasToolStripMenuItem;
        private System.Windows.Forms.Button btnDescarga;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Button btnHistorial;
    }
}

