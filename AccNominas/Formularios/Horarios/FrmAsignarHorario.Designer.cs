namespace AccNominas.Formularios.Horarios
{
    partial class FrmAsignarHorario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignarHorario));
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbDeptos = new System.Windows.Forms.ComboBox();
            this.rbPorNombre = new System.Windows.Forms.RadioButton();
            this.rbPorDepto = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gridDetalles = new DevExpress.XtraGrid.GridControl();
            this.horariosDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvDetalles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_horario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_minima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_checada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_maxima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpVigenciaIni = new System.Windows.Forms.DateTimePicker();
            this.dtpVigenciaFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHorarios = new System.Windows.Forms.ComboBox();
            this.EmpleadoHorariosGrid = new DevExpress.XtraGrid.GridControl();
            this.horarioVigenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEmpleadoHorarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colprioridad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvigencia_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvigencia_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horariosDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoHorariosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioVigenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleadoHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(AccAsistencia.Empleado);
            // 
            // cbDeptos
            // 
            this.cbDeptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeptos.FormattingEnabled = true;
            this.cbDeptos.Location = new System.Drawing.Point(177, 91);
            this.cbDeptos.Margin = new System.Windows.Forms.Padding(4);
            this.cbDeptos.Name = "cbDeptos";
            this.cbDeptos.Size = new System.Drawing.Size(384, 26);
            this.cbDeptos.TabIndex = 4;
            // 
            // rbPorNombre
            // 
            this.rbPorNombre.Checked = true;
            this.rbPorNombre.Location = new System.Drawing.Point(15, 57);
            this.rbPorNombre.Name = "rbPorNombre";
            this.rbPorNombre.Size = new System.Drawing.Size(155, 28);
            this.rbPorNombre.TabIndex = 1;
            this.rbPorNombre.TabStop = true;
            this.rbPorNombre.Text = "Por Empleado:";
            this.rbPorNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPorNombre.UseVisualStyleBackColor = true;
            this.rbPorNombre.CheckedChanged += new System.EventHandler(this.rbPorNombre_CheckedChanged);
            // 
            // rbPorDepto
            // 
            this.rbPorDepto.Location = new System.Drawing.Point(15, 91);
            this.rbPorDepto.Name = "rbPorDepto";
            this.rbPorDepto.Size = new System.Drawing.Size(155, 26);
            this.rbPorDepto.TabIndex = 2;
            this.rbPorDepto.Text = "Por Departamento:";
            this.rbPorDepto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPorDepto.UseVisualStyleBackColor = true;
            this.rbPorDepto.CheckedChanged += new System.EventHandler(this.rbPorDepto_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 40);
            this.panel1.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(574, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Asignar Horarios";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Horario: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Image = global::AccNominas.Properties.Resources.guardar;
            this.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignar.Location = new System.Drawing.Point(360, 461);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(95, 40);
            this.btnAsignar.TabIndex = 10;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::AccNominas.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(461, 461);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gridDetalles
            // 
            this.gridDetalles.DataSource = this.horariosDetallesBindingSource;
            this.gridDetalles.Location = new System.Drawing.Point(12, 301);
            this.gridDetalles.MainView = this.gvDetalles;
            this.gridDetalles.Name = "gridDetalles";
            this.gridDetalles.Size = new System.Drawing.Size(550, 92);
            this.gridDetalles.TabIndex = 7;
            this.gridDetalles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalles});
            // 
            // horariosDetallesBindingSource
            // 
            this.horariosDetallesBindingSource.DataSource = typeof(AccAsistencia.HorariosDetalles);
            // 
            // gvDetalles
            // 
            this.gvDetalles.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDetalles.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvDetalles.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDetalles.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvDetalles.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvDetalles.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvDetalles.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvDetalles.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvDetalles.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvDetalles.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvDetalles.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvDetalles.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvDetalles.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvDetalles.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvDetalles.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvDetalles.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvDetalles.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvDetalles.Appearance.Empty.Options.UseBackColor = true;
            this.gvDetalles.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvDetalles.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvDetalles.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDetalles.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvDetalles.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDetalles.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvDetalles.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDetalles.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvDetalles.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvDetalles.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvDetalles.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvDetalles.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvDetalles.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvDetalles.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvDetalles.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvDetalles.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvDetalles.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvDetalles.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvDetalles.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvDetalles.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvDetalles.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDetalles.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvDetalles.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvDetalles.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvDetalles.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDetalles.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvDetalles.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDetalles.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvDetalles.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDetalles.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDetalles.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvDetalles.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvDetalles.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvDetalles.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvDetalles.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvDetalles.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvDetalles.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvDetalles.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvDetalles.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvDetalles.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvDetalles.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvDetalles.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvDetalles.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvDetalles.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvDetalles.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvDetalles.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvDetalles.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvDetalles.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDetalles.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvDetalles.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvDetalles.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvDetalles.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvDetalles.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvDetalles.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvDetalles.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvDetalles.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvDetalles.Appearance.GroupRow.Options.UseFont = true;
            this.gvDetalles.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvDetalles.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDetalles.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvDetalles.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDetalles.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDetalles.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvDetalles.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvDetalles.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvDetalles.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvDetalles.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvDetalles.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvDetalles.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvDetalles.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvDetalles.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvDetalles.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvDetalles.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvDetalles.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvDetalles.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDetalles.Appearance.OddRow.Options.UseForeColor = true;
            this.gvDetalles.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvDetalles.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvDetalles.Appearance.Preview.Options.UseBackColor = true;
            this.gvDetalles.Appearance.Preview.Options.UseForeColor = true;
            this.gvDetalles.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvDetalles.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvDetalles.Appearance.Row.Options.UseBackColor = true;
            this.gvDetalles.Appearance.Row.Options.UseForeColor = true;
            this.gvDetalles.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvDetalles.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvDetalles.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvDetalles.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvDetalles.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvDetalles.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvDetalles.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvDetalles.Appearance.VertLine.Options.UseBackColor = true;
            this.gvDetalles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_detalle,
            this.colid_horario,
            this.coloConcepto,
            this.colhora_minima,
            this.colhora_checada,
            this.colhora_maxima});
            this.gvDetalles.GridControl = this.gridDetalles;
            this.gvDetalles.Name = "gvDetalles";
            this.gvDetalles.OptionsBehavior.Editable = false;
            this.gvDetalles.OptionsCustomization.AllowColumnMoving = false;
            this.gvDetalles.OptionsCustomization.AllowFilter = false;
            this.gvDetalles.OptionsCustomization.AllowGroup = false;
            this.gvDetalles.OptionsCustomization.AllowSort = false;
            this.gvDetalles.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDetalles.OptionsView.EnableAppearanceOddRow = true;
            this.gvDetalles.OptionsView.ShowGroupPanel = false;
            // 
            // colid_detalle
            // 
            this.colid_detalle.AppearanceHeader.Options.UseTextOptions = true;
            this.colid_detalle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid_detalle.FieldName = "id_detalle";
            this.colid_detalle.Name = "colid_detalle";
            // 
            // colid_horario
            // 
            this.colid_horario.AppearanceHeader.Options.UseTextOptions = true;
            this.colid_horario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colid_horario.FieldName = "id_horario";
            this.colid_horario.Name = "colid_horario";
            // 
            // coloConcepto
            // 
            this.coloConcepto.AppearanceHeader.Options.UseTextOptions = true;
            this.coloConcepto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coloConcepto.Caption = "Concepto";
            this.coloConcepto.FieldName = "oConcepto.descripcion";
            this.coloConcepto.Name = "coloConcepto";
            this.coloConcepto.Visible = true;
            this.coloConcepto.VisibleIndex = 0;
            // 
            // colhora_minima
            // 
            this.colhora_minima.AppearanceHeader.Options.UseTextOptions = true;
            this.colhora_minima.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhora_minima.Caption = "Hora Minima";
            this.colhora_minima.FieldName = "hora_minima";
            this.colhora_minima.Name = "colhora_minima";
            this.colhora_minima.Visible = true;
            this.colhora_minima.VisibleIndex = 1;
            // 
            // colhora_checada
            // 
            this.colhora_checada.AppearanceHeader.Options.UseTextOptions = true;
            this.colhora_checada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhora_checada.Caption = "Hora de Checada";
            this.colhora_checada.FieldName = "hora_checada";
            this.colhora_checada.Name = "colhora_checada";
            this.colhora_checada.Visible = true;
            this.colhora_checada.VisibleIndex = 2;
            // 
            // colhora_maxima
            // 
            this.colhora_maxima.AppearanceHeader.Options.UseTextOptions = true;
            this.colhora_maxima.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colhora_maxima.Caption = "Hora Maxima";
            this.colhora_maxima.FieldName = "hora_maxima";
            this.colhora_maxima.Name = "colhora_maxima";
            this.colhora_maxima.Visible = true;
            this.colhora_maxima.VisibleIndex = 3;
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbEmpleados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(177, 57);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(384, 26);
            this.cbEmpleados.TabIndex = 3;
            this.cbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cbEmpleados_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vigencia";
            // 
            // dtpVigenciaIni
            // 
            this.dtpVigenciaIni.CustomFormat = "dd/MMMM/yyyy";
            this.dtpVigenciaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVigenciaIni.Location = new System.Drawing.Point(74, 426);
            this.dtpVigenciaIni.Name = "dtpVigenciaIni";
            this.dtpVigenciaIni.Size = new System.Drawing.Size(210, 26);
            this.dtpVigenciaIni.TabIndex = 8;
            // 
            // dtpVigenciaFinal
            // 
            this.dtpVigenciaFinal.CustomFormat = "dd/MMMM/yyyy";
            this.dtpVigenciaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVigenciaFinal.Location = new System.Drawing.Point(327, 424);
            this.dtpVigenciaFinal.Name = "dtpVigenciaFinal";
            this.dtpVigenciaFinal.Size = new System.Drawing.Size(210, 26);
            this.dtpVigenciaFinal.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(290, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Al";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(37, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Del";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbHorarios
            // 
            this.cbHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorarios.FormattingEnabled = true;
            this.cbHorarios.Location = new System.Drawing.Point(81, 269);
            this.cbHorarios.Name = "cbHorarios";
            this.cbHorarios.Size = new System.Drawing.Size(480, 26);
            this.cbHorarios.TabIndex = 6;
            this.cbHorarios.SelectedIndexChanged += new System.EventHandler(this.cbHorarios_SelectedIndexChanged);
            // 
            // EmpleadoHorariosGrid
            // 
            this.EmpleadoHorariosGrid.DataSource = this.horarioVigenciaBindingSource;
            this.EmpleadoHorariosGrid.Location = new System.Drawing.Point(15, 124);
            this.EmpleadoHorariosGrid.MainView = this.gvEmpleadoHorarios;
            this.EmpleadoHorariosGrid.Name = "EmpleadoHorariosGrid";
            this.EmpleadoHorariosGrid.Size = new System.Drawing.Size(546, 134);
            this.EmpleadoHorariosGrid.TabIndex = 5;
            this.EmpleadoHorariosGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmpleadoHorarios});
            this.EmpleadoHorariosGrid.Click += new System.EventHandler(this.EmpleadoHorariosGrid_Click);
            // 
            // horarioVigenciaBindingSource
            // 
            this.horarioVigenciaBindingSource.DataSource = typeof(AccAsistencia.HorarioVigencia);
            // 
            // gvEmpleadoHorarios
            // 
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvEmpleadoHorarios.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvEmpleadoHorarios.Appearance.Empty.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvEmpleadoHorarios.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoHorarios.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoHorarios.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEmpleadoHorarios.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoHorarios.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoHorarios.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEmpleadoHorarios.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvEmpleadoHorarios.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvEmpleadoHorarios.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvEmpleadoHorarios.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvEmpleadoHorarios.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvEmpleadoHorarios.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoHorarios.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvEmpleadoHorarios.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvEmpleadoHorarios.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoHorarios.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEmpleadoHorarios.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoHorarios.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoHorarios.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEmpleadoHorarios.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvEmpleadoHorarios.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEmpleadoHorarios.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEmpleadoHorarios.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoHorarios.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvEmpleadoHorarios.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEmpleadoHorarios.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEmpleadoHorarios.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoHorarios.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvEmpleadoHorarios.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvEmpleadoHorarios.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoHorarios.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEmpleadoHorarios.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEmpleadoHorarios.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvEmpleadoHorarios.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoHorarios.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvEmpleadoHorarios.Appearance.GroupRow.Options.UseFont = true;
            this.gvEmpleadoHorarios.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoHorarios.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEmpleadoHorarios.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoHorarios.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoHorarios.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEmpleadoHorarios.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvEmpleadoHorarios.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvEmpleadoHorarios.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvEmpleadoHorarios.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvEmpleadoHorarios.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvEmpleadoHorarios.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoHorarios.Appearance.OddRow.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.OddRow.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvEmpleadoHorarios.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvEmpleadoHorarios.Appearance.Preview.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.Preview.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvEmpleadoHorarios.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoHorarios.Appearance.Row.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.Row.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvEmpleadoHorarios.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvEmpleadoHorarios.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvEmpleadoHorarios.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvEmpleadoHorarios.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvEmpleadoHorarios.Appearance.VertLine.Options.UseBackColor = true;
            this.gvEmpleadoHorarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colprioridad,
            this.coldescripcion,
            this.colvigencia_inicio,
            this.colvigencia_fin});
            this.gvEmpleadoHorarios.GridControl = this.EmpleadoHorariosGrid;
            this.gvEmpleadoHorarios.Name = "gvEmpleadoHorarios";
            this.gvEmpleadoHorarios.OptionsBehavior.Editable = false;
            this.gvEmpleadoHorarios.OptionsCustomization.AllowFilter = false;
            this.gvEmpleadoHorarios.OptionsCustomization.AllowGroup = false;
            this.gvEmpleadoHorarios.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEmpleadoHorarios.OptionsView.EnableAppearanceOddRow = true;
            this.gvEmpleadoHorarios.OptionsView.ShowGroupPanel = false;
            // 
            // colprioridad
            // 
            this.colprioridad.AppearanceCell.Options.UseTextOptions = true;
            this.colprioridad.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colprioridad.AppearanceHeader.Options.UseTextOptions = true;
            this.colprioridad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colprioridad.Caption = "Prioridad";
            this.colprioridad.FieldName = "prioridad";
            this.colprioridad.Name = "colprioridad";
            this.colprioridad.Visible = true;
            this.colprioridad.VisibleIndex = 0;
            // 
            // coldescripcion
            // 
            this.coldescripcion.AppearanceHeader.Options.UseTextOptions = true;
            this.coldescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            // 
            // colvigencia_inicio
            // 
            this.colvigencia_inicio.AppearanceCell.Options.UseTextOptions = true;
            this.colvigencia_inicio.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvigencia_inicio.AppearanceHeader.Options.UseTextOptions = true;
            this.colvigencia_inicio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvigencia_inicio.Caption = "Inicia Vigencia";
            this.colvigencia_inicio.DisplayFormat.FormatString = "dd/MMM/yyyy";
            this.colvigencia_inicio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colvigencia_inicio.FieldName = "vigencia_inicio";
            this.colvigencia_inicio.Name = "colvigencia_inicio";
            this.colvigencia_inicio.Visible = true;
            this.colvigencia_inicio.VisibleIndex = 2;
            // 
            // colvigencia_fin
            // 
            this.colvigencia_fin.AppearanceCell.Options.UseTextOptions = true;
            this.colvigencia_fin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvigencia_fin.AppearanceHeader.Options.UseTextOptions = true;
            this.colvigencia_fin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colvigencia_fin.Caption = "Termina Vigencia";
            this.colvigencia_fin.DisplayFormat.FormatString = "dd/MMM/yyyy";
            this.colvigencia_fin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colvigencia_fin.FieldName = "vigencia_fin";
            this.colvigencia_fin.Name = "colvigencia_fin";
            this.colvigencia_fin.Visible = true;
            this.colvigencia_fin.VisibleIndex = 3;
            // 
            // FrmAsignarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 513);
            this.Controls.Add(this.EmpleadoHorariosGrid);
            this.Controls.Add(this.cbHorarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpVigenciaFinal);
            this.Controls.Add(this.dtpVigenciaIni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEmpleados);
            this.Controls.Add(this.gridDetalles);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbPorDepto);
            this.Controls.Add(this.rbPorNombre);
            this.Controls.Add(this.cbDeptos);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(590, 510);
            this.Name = "FrmAsignarHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de Horarios";
            this.Load += new System.EventHandler(this.FrmAsignarHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horariosDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoHorariosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioVigenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleadoHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDeptos;
        private System.Windows.Forms.RadioButton rbPorNombre;
        private System.Windows.Forms.RadioButton rbPorDepto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnCancelar;
        private DevExpress.XtraGrid.GridControl gridDetalles;
        private System.Windows.Forms.BindingSource horariosDetallesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalles;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colid_horario;
        private DevExpress.XtraGrid.Columns.GridColumn coloConcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_minima;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_checada;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_maxima;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpVigenciaIni;
        private System.Windows.Forms.DateTimePicker dtpVigenciaFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHorarios;
        private DevExpress.XtraGrid.GridControl EmpleadoHorariosGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmpleadoHorarios;
        private System.Windows.Forms.BindingSource horarioVigenciaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colprioridad;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colvigencia_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colvigencia_fin;
    }
}