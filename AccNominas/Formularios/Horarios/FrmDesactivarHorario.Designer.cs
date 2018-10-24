namespace AccNominas.Formularios.Horarios
{
    partial class FrmDesactivarHorario
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.horariosDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridDetalles = new DevExpress.XtraGrid.GridControl();
            this.gvDetalles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_horario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_minima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_checada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_maxima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chbLunes = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chbDomingo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbSabado = new System.Windows.Forms.CheckBox();
            this.chbMartes = new System.Windows.Forms.CheckBox();
            this.chbViernes = new System.Windows.Forms.CheckBox();
            this.chbMiercoles = new System.Windows.Forms.CheckBox();
            this.chbJueves = new System.Windows.Forms.CheckBox();
            this.chbDiaSiguiente = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDescripcion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.horariosDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalles)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(659, 40);
            this.lblTitulo.TabIndex = 36;
            this.lblTitulo.Text = "Desactivar Horario";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // horariosDetallesBindingSource
            // 
            this.horariosDetallesBindingSource.DataSource = typeof(AccAsistencia.HorariosDetalles);
            // 
            // gridDetalles
            // 
            this.gridDetalles.DataSource = this.horariosDetallesBindingSource;
            this.gridDetalles.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDetalles.Location = new System.Drawing.Point(7, 25);
            this.gridDetalles.MainView = this.gvDetalles;
            this.gridDetalles.Name = "gridDetalles";
            this.gridDetalles.Size = new System.Drawing.Size(622, 134);
            this.gridDetalles.TabIndex = 10;
            this.gridDetalles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetalles});
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
            this.gvDetalles.OptionsCustomization.AllowColumnMoving = false;
            this.gvDetalles.OptionsCustomization.AllowFilter = false;
            this.gvDetalles.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDetalles.OptionsView.EnableAppearanceOddRow = true;
            this.gvDetalles.OptionsView.ShowGroupPanel = false;
            // 
            // colid_detalle
            // 
            this.colid_detalle.FieldName = "id_detalle";
            this.colid_detalle.Name = "colid_detalle";
            // 
            // colid_horario
            // 
            this.colid_horario.FieldName = "id_horario";
            this.colid_horario.Name = "colid_horario";
            // 
            // coloConcepto
            // 
            this.coloConcepto.Caption = "Concepto";
            this.coloConcepto.FieldName = "oConcepto.descripcion";
            this.coloConcepto.Name = "coloConcepto";
            this.coloConcepto.OptionsColumn.AllowEdit = false;
            this.coloConcepto.OptionsColumn.AllowMove = false;
            this.coloConcepto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coloConcepto.Visible = true;
            this.coloConcepto.VisibleIndex = 0;
            // 
            // colhora_minima
            // 
            this.colhora_minima.Caption = "Hora Minima";
            this.colhora_minima.FieldName = "hora_minima";
            this.colhora_minima.Name = "colhora_minima";
            this.colhora_minima.OptionsColumn.AllowEdit = false;
            this.colhora_minima.Visible = true;
            this.colhora_minima.VisibleIndex = 1;
            // 
            // colhora_checada
            // 
            this.colhora_checada.Caption = "Hora de Checada";
            this.colhora_checada.FieldName = "hora_checada";
            this.colhora_checada.Name = "colhora_checada";
            this.colhora_checada.OptionsColumn.AllowEdit = false;
            this.colhora_checada.Visible = true;
            this.colhora_checada.VisibleIndex = 2;
            this.colhora_checada.Width = 92;
            // 
            // colhora_maxima
            // 
            this.colhora_maxima.Caption = "Hora Maxima";
            this.colhora_maxima.FieldName = "hora_maxima";
            this.colhora_maxima.Name = "colhora_maxima";
            this.colhora_maxima.OptionsColumn.AllowEdit = false;
            this.colhora_maxima.Visible = true;
            this.colhora_maxima.VisibleIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::AccNominas.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(547, 470);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Image = global::AccNominas.Properties.Resources.guardar;
            this.btnDesactivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesactivar.Location = new System.Drawing.Point(441, 470);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(100, 40);
            this.btnDesactivar.TabIndex = 11;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesactivar.UseVisualStyleBackColor = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descipcion:";
            // 
            // chbLunes
            // 
            this.chbLunes.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbLunes.Enabled = false;
            this.chbLunes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLunes.Location = new System.Drawing.Point(187, 109);
            this.chbLunes.Margin = new System.Windows.Forms.Padding(4);
            this.chbLunes.Name = "chbLunes";
            this.chbLunes.Size = new System.Drawing.Size(28, 28);
            this.chbLunes.TabIndex = 2;
            this.chbLunes.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 459);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(298, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "*El formato de tiempo esta basado en 24 horas.";
            // 
            // chbDomingo
            // 
            this.chbDomingo.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbDomingo.Enabled = false;
            this.chbDomingo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDomingo.Location = new System.Drawing.Point(417, 109);
            this.chbDomingo.Margin = new System.Windows.Forms.Padding(4);
            this.chbDomingo.Name = "chbDomingo";
            this.chbDomingo.Size = new System.Drawing.Size(28, 28);
            this.chbDomingo.TabIndex = 8;
            this.chbDomingo.UseVisualStyleBackColor = true;
            this.chbDomingo.CheckedChanged += new System.EventHandler(this.chbDomingo_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Dias que aplica:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridDetalles);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 165);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del horario";
            // 
            // chbSabado
            // 
            this.chbSabado.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbSabado.Enabled = false;
            this.chbSabado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSabado.Location = new System.Drawing.Point(297, 181);
            this.chbSabado.Margin = new System.Windows.Forms.Padding(4);
            this.chbSabado.Name = "chbSabado";
            this.chbSabado.Size = new System.Drawing.Size(28, 28);
            this.chbSabado.TabIndex = 7;
            this.chbSabado.UseVisualStyleBackColor = true;
            // 
            // chbMartes
            // 
            this.chbMartes.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbMartes.Enabled = false;
            this.chbMartes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMartes.Location = new System.Drawing.Point(187, 145);
            this.chbMartes.Margin = new System.Windows.Forms.Padding(4);
            this.chbMartes.Name = "chbMartes";
            this.chbMartes.Size = new System.Drawing.Size(28, 28);
            this.chbMartes.TabIndex = 3;
            this.chbMartes.UseVisualStyleBackColor = true;
            // 
            // chbViernes
            // 
            this.chbViernes.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbViernes.Enabled = false;
            this.chbViernes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbViernes.Location = new System.Drawing.Point(297, 145);
            this.chbViernes.Margin = new System.Windows.Forms.Padding(4);
            this.chbViernes.Name = "chbViernes";
            this.chbViernes.Size = new System.Drawing.Size(28, 28);
            this.chbViernes.TabIndex = 6;
            this.chbViernes.UseVisualStyleBackColor = true;
            // 
            // chbMiercoles
            // 
            this.chbMiercoles.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbMiercoles.Enabled = false;
            this.chbMiercoles.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMiercoles.Location = new System.Drawing.Point(187, 181);
            this.chbMiercoles.Margin = new System.Windows.Forms.Padding(4);
            this.chbMiercoles.Name = "chbMiercoles";
            this.chbMiercoles.Size = new System.Drawing.Size(28, 28);
            this.chbMiercoles.TabIndex = 4;
            this.chbMiercoles.UseVisualStyleBackColor = true;
            // 
            // chbJueves
            // 
            this.chbJueves.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbJueves.Enabled = false;
            this.chbJueves.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbJueves.Location = new System.Drawing.Point(297, 110);
            this.chbJueves.Margin = new System.Windows.Forms.Padding(4);
            this.chbJueves.Name = "chbJueves";
            this.chbJueves.Size = new System.Drawing.Size(28, 28);
            this.chbJueves.TabIndex = 5;
            this.chbJueves.UseVisualStyleBackColor = true;
            // 
            // chbDiaSiguiente
            // 
            this.chbDiaSiguiente.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbDiaSiguiente.Enabled = false;
            this.chbDiaSiguiente.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDiaSiguiente.Location = new System.Drawing.Point(500, 145);
            this.chbDiaSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.chbDiaSiguiente.Name = "chbDiaSiguiente";
            this.chbDiaSiguiente.Size = new System.Drawing.Size(28, 28);
            this.chbDiaSiguiente.TabIndex = 9;
            this.chbDiaSiguiente.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbDescripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chbDiaSiguiente);
            this.groupBox1.Controls.Add(this.chbLunes);
            this.groupBox1.Controls.Add(this.chbDomingo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chbSabado);
            this.groupBox1.Controls.Add(this.chbMartes);
            this.groupBox1.Controls.Add(this.chbViernes);
            this.groupBox1.Controls.Add(this.chbMiercoles);
            this.groupBox1.Controls.Add(this.chbJueves);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 235);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(346, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "Checa el dia siguiente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Domingo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Sabado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Viernes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Jueves:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Miercoles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Martes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Lunes:";
            // 
            // cbDescripcion
            // 
            this.cbDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDescripcion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDescripcion.FormattingEnabled = true;
            this.cbDescripcion.Location = new System.Drawing.Point(31, 51);
            this.cbDescripcion.Name = "cbDescripcion";
            this.cbDescripcion.Size = new System.Drawing.Size(397, 26);
            this.cbDescripcion.TabIndex = 1;
            this.cbDescripcion.SelectedIndexChanged += new System.EventHandler(this.cbDescripcion_SelectedIndexChanged);
            // 
            // FrmDesactivarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 524);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(675, 560);
            this.MinimumSize = new System.Drawing.Size(675, 560);
            this.Name = "FrmDesactivarHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desactivar Horario";
            this.Load += new System.EventHandler(this.FrmDesactivarHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.horariosDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.BindingSource horariosDetallesBindingSource;
        private DevExpress.XtraGrid.GridControl gridDetalles;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalles;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colid_horario;
        private DevExpress.XtraGrid.Columns.GridColumn coloConcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_minima;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_checada;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_maxima;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbLunes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chbDomingo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbSabado;
        private System.Windows.Forms.CheckBox chbMartes;
        private System.Windows.Forms.CheckBox chbViernes;
        private System.Windows.Forms.CheckBox chbMiercoles;
        private System.Windows.Forms.CheckBox chbJueves;
        private System.Windows.Forms.CheckBox chbDiaSiguiente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;

    }
}