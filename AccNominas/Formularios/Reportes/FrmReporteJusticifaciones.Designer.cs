namespace AccNominas.Formularios.Reportes
{
    partial class FrmReporteJusticifaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.gridJustificaciones = new DevExpress.XtraGrid.GridControl();
            this.justificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvJustificaciones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coloConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_hora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_hora1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colautorizado_por = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridJustificaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.justificacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJustificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repote de Justificaciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empleado:";
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(224, 33);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(517, 26);
            this.cbEmpleados.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Periodo:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "dd/MMMM/yyyy";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(224, 69);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(237, 26);
            this.dtpInicio.TabIndex = 4;
            // 
            // dtpFinal
            // 
            this.dtpFinal.CustomFormat = "dd/MMMM/yyyy";
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinal.Location = new System.Drawing.Point(504, 69);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(237, 26);
            this.dtpFinal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(467, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Al";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridJustificaciones
            // 
            this.gridJustificaciones.DataSource = this.justificacionBindingSource;
            this.gridJustificaciones.Location = new System.Drawing.Point(12, 101);
            this.gridJustificaciones.MainView = this.gvJustificaciones;
            this.gridJustificaciones.Name = "gridJustificaciones";
            this.gridJustificaciones.Size = new System.Drawing.Size(860, 303);
            this.gridJustificaciones.TabIndex = 7;
            this.gridJustificaciones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvJustificaciones});
            // 
            // justificacionBindingSource
            // 
            this.justificacionBindingSource.DataSource = typeof(AccAsistencia.Justificacion);
            // 
            // gvJustificaciones
            // 
            this.gvJustificaciones.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvJustificaciones.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvJustificaciones.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvJustificaciones.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvJustificaciones.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvJustificaciones.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvJustificaciones.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvJustificaciones.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvJustificaciones.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvJustificaciones.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvJustificaciones.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvJustificaciones.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvJustificaciones.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvJustificaciones.Appearance.Empty.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvJustificaciones.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvJustificaciones.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvJustificaciones.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvJustificaciones.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvJustificaciones.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvJustificaciones.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvJustificaciones.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvJustificaciones.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvJustificaciones.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvJustificaciones.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvJustificaciones.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvJustificaciones.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvJustificaciones.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvJustificaciones.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvJustificaciones.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvJustificaciones.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvJustificaciones.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvJustificaciones.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvJustificaciones.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvJustificaciones.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvJustificaciones.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvJustificaciones.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvJustificaciones.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvJustificaciones.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvJustificaciones.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvJustificaciones.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvJustificaciones.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvJustificaciones.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvJustificaciones.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvJustificaciones.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvJustificaciones.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvJustificaciones.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvJustificaciones.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvJustificaciones.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvJustificaciones.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvJustificaciones.Appearance.GroupRow.Options.UseFont = true;
            this.gvJustificaciones.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvJustificaciones.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvJustificaciones.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvJustificaciones.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvJustificaciones.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvJustificaciones.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvJustificaciones.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvJustificaciones.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvJustificaciones.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvJustificaciones.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvJustificaciones.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvJustificaciones.Appearance.OddRow.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.OddRow.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvJustificaciones.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvJustificaciones.Appearance.Preview.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.Preview.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvJustificaciones.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvJustificaciones.Appearance.Row.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.Row.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvJustificaciones.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvJustificaciones.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvJustificaciones.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvJustificaciones.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvJustificaciones.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvJustificaciones.Appearance.VertLine.Options.UseBackColor = true;
            this.gvJustificaciones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coloConcepto,
            this.colfecha_hora,
            this.colfecha_hora1,
            this.coldetalle,
            this.colautorizado_por});
            this.gvJustificaciones.GridControl = this.gridJustificaciones;
            this.gvJustificaciones.Name = "gvJustificaciones";
            this.gvJustificaciones.OptionsBehavior.Editable = false;
            this.gvJustificaciones.OptionsCustomization.AllowFilter = false;
            this.gvJustificaciones.OptionsCustomization.AllowGroup = false;
            this.gvJustificaciones.OptionsView.EnableAppearanceEvenRow = true;
            this.gvJustificaciones.OptionsView.EnableAppearanceOddRow = true;
            this.gvJustificaciones.OptionsView.ShowGroupPanel = false;
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
            // colfecha_hora
            // 
            this.colfecha_hora.AppearanceCell.Options.UseTextOptions = true;
            this.colfecha_hora.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfecha_hora.AppearanceHeader.Options.UseTextOptions = true;
            this.colfecha_hora.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfecha_hora.Caption = "Fecha";
            this.colfecha_hora.DisplayFormat.FormatString = "dd/MMMM/yyyy";
            this.colfecha_hora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_hora.FieldName = "fecha_hora";
            this.colfecha_hora.Name = "colfecha_hora";
            this.colfecha_hora.Visible = true;
            this.colfecha_hora.VisibleIndex = 1;
            // 
            // colfecha_hora1
            // 
            this.colfecha_hora1.AppearanceCell.Options.UseTextOptions = true;
            this.colfecha_hora1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfecha_hora1.AppearanceHeader.Options.UseTextOptions = true;
            this.colfecha_hora1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colfecha_hora1.Caption = "Hora";
            this.colfecha_hora1.DisplayFormat.FormatString = "hh:mm tt";
            this.colfecha_hora1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_hora1.FieldName = "fecha_hora";
            this.colfecha_hora1.Name = "colfecha_hora1";
            this.colfecha_hora1.Visible = true;
            this.colfecha_hora1.VisibleIndex = 2;
            // 
            // coldetalle
            // 
            this.coldetalle.AppearanceHeader.Options.UseTextOptions = true;
            this.coldetalle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldetalle.Caption = "Detalles";
            this.coldetalle.FieldName = "detalle";
            this.coldetalle.Name = "coldetalle";
            this.coldetalle.Visible = true;
            this.coldetalle.VisibleIndex = 3;
            // 
            // colautorizado_por
            // 
            this.colautorizado_por.AppearanceHeader.Options.UseTextOptions = true;
            this.colautorizado_por.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colautorizado_por.Caption = "Autorizado por";
            this.colautorizado_por.FieldName = "autorizado_por";
            this.colautorizado_por.Name = "colautorizado_por";
            this.colautorizado_por.Visible = true;
            this.colautorizado_por.VisibleIndex = 4;
            this.colautorizado_por.Width = 80;
            // 
            // btnExportar
            // 
            this.btnExportar.Image = global::AccNominas.Properties.Resources.Excel_34x34;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(766, 410);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(106, 40);
            this.btnExportar.TabIndex = 8;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::AccNominas.Properties.Resources.consultar;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(650, 410);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(110, 40);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // FrmReporteJusticifaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.gridJustificaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FrmReporteJusticifaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Justificaciones";
            this.Load += new System.EventHandler(this.FrmReporteJusticifaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridJustificaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.justificacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJustificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gridJustificaciones;
        private DevExpress.XtraGrid.Views.Grid.GridView gvJustificaciones;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.BindingSource justificacionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coloConcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_hora;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_hora1;
        private DevExpress.XtraGrid.Columns.GridColumn coldetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colautorizado_por;
        private System.Windows.Forms.Button btnConsultar;
    }
}