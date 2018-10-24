namespace AccNominas.Formularios.Horarios
{
    partial class FrmCambiarPrioridad
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
            this.gridHorarios = new DevExpress.XtraGrid.GridControl();
            this.horarioVigenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvHorarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colprioridad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvigencia_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvigencia_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnBajar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.imgLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioVigenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // gridHorarios
            // 
            this.gridHorarios.DataSource = this.horarioVigenciaBindingSource;
            this.gridHorarios.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridHorarios.Location = new System.Drawing.Point(25, 102);
            this.gridHorarios.MainView = this.gvHorarios;
            this.gridHorarios.Margin = new System.Windows.Forms.Padding(4);
            this.gridHorarios.Name = "gridHorarios";
            this.gridHorarios.Size = new System.Drawing.Size(538, 299);
            this.gridHorarios.TabIndex = 2;
            this.gridHorarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHorarios});
            // 
            // horarioVigenciaBindingSource
            // 
            this.horarioVigenciaBindingSource.DataSource = typeof(AccAsistencia.HorarioVigencia);
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
            this.colprioridad,
            this.coldescripcion,
            this.colvigencia_inicio,
            this.colvigencia_fin});
            this.gvHorarios.GridControl = this.gridHorarios;
            this.gvHorarios.Name = "gvHorarios";
            this.gvHorarios.OptionsBehavior.Editable = false;
            this.gvHorarios.OptionsCustomization.AllowFilter = false;
            this.gvHorarios.OptionsCustomization.AllowGroup = false;
            this.gvHorarios.OptionsView.EnableAppearanceEvenRow = true;
            this.gvHorarios.OptionsView.EnableAppearanceOddRow = true;
            this.gvHorarios.OptionsView.ShowGroupPanel = false;
            this.gvHorarios.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colprioridad, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvHorarios.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvHorarios_RowClick);
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
            this.colvigencia_inicio.Caption = "Inicio Vigencia";
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
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(571, 102);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(70, 30);
            this.btnSubir.TabIndex = 3;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnBajar
            // 
            this.btnBajar.Location = new System.Drawing.Point(571, 140);
            this.btnBajar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBajar.Name = "btnBajar";
            this.btnBajar.Size = new System.Drawing.Size(70, 30);
            this.btnBajar.TabIndex = 4;
            this.btnBajar.Text = "Bajar";
            this.btnBajar.UseVisualStyleBackColor = true;
            this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cambiar Prioridad de Horarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(102, 58);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(461, 26);
            this.cbEmpleados.TabIndex = 1;
            this.cbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cbEmpleados_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Empleado:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::AccNominas.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(541, 409);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::AccNominas.Properties.Resources.guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(433, 409);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // imgLoading
            // 
            this.imgLoading.Image = global::AccNominas.Properties.Resources.cargando;
            this.imgLoading.Location = new System.Drawing.Point(243, 184);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(169, 94);
            this.imgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLoading.TabIndex = 7;
            this.imgLoading.TabStop = false;
            this.imgLoading.Visible = false;
            // 
            // FrmCambiarPrioridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 462);
            this.Controls.Add(this.imgLoading);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEmpleados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBajar);
            this.Controls.Add(this.btnSubir);
            this.Controls.Add(this.gridHorarios);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCambiarPrioridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Prioridad de Horarios";
            this.Load += new System.EventHandler(this.Frm_CambiarPrioridad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioVigenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridHorarios;
        private System.Windows.Forms.BindingSource horarioVigenciaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHorarios;
        private DevExpress.XtraGrid.Columns.GridColumn colprioridad;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colvigencia_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colvigencia_fin;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button btnBajar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox imgLoading;
    }
}