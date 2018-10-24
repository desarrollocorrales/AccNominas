namespace AccNominas.Formularios.Horarios
{
    partial class FrmDesasignarHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDesasignarHorario));
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HorariosVigenciasGrid = new DevExpress.XtraGrid.GridControl();
            this.horarioVigenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvHorariosVigencias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colprioridad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvigencia_inicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvigencia_fin = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.HorariosVigenciasGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioVigenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHorariosVigencias)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEmpleados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(106, 56);
            this.cbEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmpleados.MaxLength = 100;
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(503, 26);
            this.cbEmpleados.TabIndex = 1;
            this.cbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cbEmpleados_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(634, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Desasignar Horarios";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Horario:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.Image = global::AccNominas.Properties.Resources.guardar;
            this.btnDesasignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesasignar.Location = new System.Drawing.Point(400, 260);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(115, 40);
            this.btnDesasignar.TabIndex = 3;
            this.btnDesasignar.Text = "Desasignar";
            this.btnDesasignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesasignar.UseVisualStyleBackColor = true;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::AccNominas.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(521, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 40);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Empleado:";
            // 
            // HorariosVigenciasGrid
            // 
            this.HorariosVigenciasGrid.DataSource = this.horarioVigenciaBindingSource;
            this.HorariosVigenciasGrid.Location = new System.Drawing.Point(106, 90);
            this.HorariosVigenciasGrid.MainView = this.gvHorariosVigencias;
            this.HorariosVigenciasGrid.Name = "HorariosVigenciasGrid";
            this.HorariosVigenciasGrid.Size = new System.Drawing.Size(504, 164);
            this.HorariosVigenciasGrid.TabIndex = 2;
            this.HorariosVigenciasGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHorariosVigencias});
            this.HorariosVigenciasGrid.Click += new System.EventHandler(this.HorariosVigenciasGrid_Click);
            // 
            // horarioVigenciaBindingSource
            // 
            this.horarioVigenciaBindingSource.DataSource = typeof(AccAsistencia.HorarioVigencia);
            // 
            // gvHorariosVigencias
            // 
            this.gvHorariosVigencias.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorariosVigencias.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvHorariosVigencias.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorariosVigencias.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvHorariosVigencias.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvHorariosVigencias.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvHorariosVigencias.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvHorariosVigencias.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvHorariosVigencias.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvHorariosVigencias.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvHorariosVigencias.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvHorariosVigencias.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvHorariosVigencias.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvHorariosVigencias.Appearance.Empty.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvHorariosVigencias.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvHorariosVigencias.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorariosVigencias.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvHorariosVigencias.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorariosVigencias.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvHorariosVigencias.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvHorariosVigencias.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvHorariosVigencias.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvHorariosVigencias.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvHorariosVigencias.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvHorariosVigencias.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvHorariosVigencias.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvHorariosVigencias.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvHorariosVigencias.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvHorariosVigencias.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorariosVigencias.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvHorariosVigencias.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorariosVigencias.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvHorariosVigencias.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvHorariosVigencias.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvHorariosVigencias.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvHorariosVigencias.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvHorariosVigencias.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvHorariosVigencias.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvHorariosVigencias.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvHorariosVigencias.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvHorariosVigencias.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvHorariosVigencias.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvHorariosVigencias.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvHorariosVigencias.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorariosVigencias.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvHorariosVigencias.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvHorariosVigencias.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvHorariosVigencias.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvHorariosVigencias.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvHorariosVigencias.Appearance.GroupRow.Options.UseFont = true;
            this.gvHorariosVigencias.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorariosVigencias.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvHorariosVigencias.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvHorariosVigencias.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvHorariosVigencias.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvHorariosVigencias.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvHorariosVigencias.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvHorariosVigencias.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvHorariosVigencias.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvHorariosVigencias.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvHorariosVigencias.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvHorariosVigencias.Appearance.OddRow.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.OddRow.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvHorariosVigencias.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvHorariosVigencias.Appearance.Preview.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.Preview.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvHorariosVigencias.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvHorariosVigencias.Appearance.Row.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.Row.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvHorariosVigencias.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvHorariosVigencias.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvHorariosVigencias.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvHorariosVigencias.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvHorariosVigencias.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvHorariosVigencias.Appearance.VertLine.Options.UseBackColor = true;
            this.gvHorariosVigencias.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colprioridad,
            this.coldescripcion,
            this.colvigencia_inicio,
            this.colvigencia_fin});
            this.gvHorariosVigencias.GridControl = this.HorariosVigenciasGrid;
            this.gvHorariosVigencias.Name = "gvHorariosVigencias";
            this.gvHorariosVigencias.OptionsBehavior.Editable = false;
            this.gvHorariosVigencias.OptionsCustomization.AllowFilter = false;
            this.gvHorariosVigencias.OptionsCustomization.AllowGroup = false;
            this.gvHorariosVigencias.OptionsView.EnableAppearanceEvenRow = true;
            this.gvHorariosVigencias.OptionsView.EnableAppearanceOddRow = true;
            this.gvHorariosVigencias.OptionsView.ShowGroupPanel = false;
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
            this.coldescripcion.Caption = "Descripción";
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
            // FrmDesasignarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 314);
            this.Controls.Add(this.HorariosVigenciasGrid);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDesasignar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEmpleados);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(650, 350);
            this.MinimumSize = new System.Drawing.Size(650, 350);
            this.Name = "FrmDesasignarHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desasignacion de Horarios";
            this.Load += new System.EventHandler(this.FrmAsignarHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HorariosVigenciasGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioVigenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHorariosVigencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDesasignar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl HorariosVigenciasGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHorariosVigencias;
        private System.Windows.Forms.BindingSource horarioVigenciaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colprioridad;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colvigencia_inicio;
        private DevExpress.XtraGrid.Columns.GridColumn colvigencia_fin;
    }
}