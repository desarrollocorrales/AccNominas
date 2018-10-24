namespace AccNominas.Formularios.Empleados
{
    partial class FrmAsignarChecador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsignarChecador));
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstChecadores = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId_interno = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grdEmpleadoChecador = new DevExpress.XtraGrid.GridControl();
            this.empleadoChecadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvEmpleadoChecador = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_interno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsChecador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleadoChecador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoChecadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleadoChecador)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "Checadores:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::AccNominas.Properties.Resources.guardar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(363, 408);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aceptar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::AccNominas.Properties.Resources.cancelar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(471, 408);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lstChecadores);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtId_interno);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.grdEmpleadoChecador);
            this.groupBox1.Controls.Add(this.cbEmpleados);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(16, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(560, 355);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(522, 165);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(30, 30);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstChecadores
            // 
            this.lstChecadores.FormattingEnabled = true;
            this.lstChecadores.ItemHeight = 18;
            this.lstChecadores.Location = new System.Drawing.Point(99, 51);
            this.lstChecadores.Name = "lstChecadores";
            this.lstChecadores.Size = new System.Drawing.Size(417, 76);
            this.lstChecadores.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 18);
            this.label3.TabIndex = 39;
            this.label3.Text = "Id del empleado en el checador:";
            // 
            // txtId_interno
            // 
            this.txtId_interno.Location = new System.Drawing.Point(469, 133);
            this.txtId_interno.MaxLength = 5;
            this.txtId_interno.Name = "txtId_interno";
            this.txtId_interno.Size = new System.Drawing.Size(47, 26);
            this.txtId_interno.TabIndex = 3;
            this.txtId_interno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtId_interno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_interno_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(522, 201);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(30, 30);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "-";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grdEmpleadoChecador
            // 
            this.grdEmpleadoChecador.DataSource = this.empleadoChecadorBindingSource;
            this.grdEmpleadoChecador.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.grdEmpleadoChecador.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.grdEmpleadoChecador.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.grdEmpleadoChecador.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.grdEmpleadoChecador.EmbeddedNavigator.Buttons.First.Visible = false;
            this.grdEmpleadoChecador.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.grdEmpleadoChecador.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.grdEmpleadoChecador.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.grdEmpleadoChecador.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.grdEmpleadoChecador.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.grdEmpleadoChecador.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.grdEmpleadoChecador.EmbeddedNavigator.ShowToolTips = false;
            this.grdEmpleadoChecador.Location = new System.Drawing.Point(99, 165);
            this.grdEmpleadoChecador.MainView = this.gvEmpleadoChecador;
            this.grdEmpleadoChecador.Name = "grdEmpleadoChecador";
            this.grdEmpleadoChecador.Size = new System.Drawing.Size(417, 183);
            this.grdEmpleadoChecador.TabIndex = 4;
            this.grdEmpleadoChecador.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmpleadoChecador});
            // 
            // empleadoChecadorBindingSource
            // 
            this.empleadoChecadorBindingSource.DataSource = typeof(AccAsistencia.EmpleadoChecador);
            // 
            // gvEmpleadoChecador
            // 
            this.gvEmpleadoChecador.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoChecador.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEmpleadoChecador.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoChecador.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoChecador.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEmpleadoChecador.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvEmpleadoChecador.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvEmpleadoChecador.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvEmpleadoChecador.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvEmpleadoChecador.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoChecador.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEmpleadoChecador.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvEmpleadoChecador.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvEmpleadoChecador.Appearance.Empty.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvEmpleadoChecador.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoChecador.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoChecador.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEmpleadoChecador.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoChecador.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoChecador.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEmpleadoChecador.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvEmpleadoChecador.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvEmpleadoChecador.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvEmpleadoChecador.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvEmpleadoChecador.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvEmpleadoChecador.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoChecador.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvEmpleadoChecador.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvEmpleadoChecador.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoChecador.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEmpleadoChecador.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoChecador.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoChecador.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEmpleadoChecador.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvEmpleadoChecador.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEmpleadoChecador.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEmpleadoChecador.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoChecador.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvEmpleadoChecador.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEmpleadoChecador.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEmpleadoChecador.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoChecador.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvEmpleadoChecador.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvEmpleadoChecador.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoChecador.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEmpleadoChecador.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvEmpleadoChecador.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvEmpleadoChecador.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoChecador.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvEmpleadoChecador.Appearance.GroupRow.Options.UseFont = true;
            this.gvEmpleadoChecador.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoChecador.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvEmpleadoChecador.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvEmpleadoChecador.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoChecador.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvEmpleadoChecador.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvEmpleadoChecador.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvEmpleadoChecador.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvEmpleadoChecador.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvEmpleadoChecador.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvEmpleadoChecador.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoChecador.Appearance.OddRow.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.OddRow.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvEmpleadoChecador.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvEmpleadoChecador.Appearance.Preview.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.Preview.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvEmpleadoChecador.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvEmpleadoChecador.Appearance.Row.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.Row.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvEmpleadoChecador.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvEmpleadoChecador.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvEmpleadoChecador.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvEmpleadoChecador.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvEmpleadoChecador.Appearance.VertLine.Options.UseBackColor = true;
            this.gvEmpleadoChecador.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_interno,
            this.colsChecador});
            this.gvEmpleadoChecador.GridControl = this.grdEmpleadoChecador;
            this.gvEmpleadoChecador.Name = "gvEmpleadoChecador";
            this.gvEmpleadoChecador.OptionsBehavior.Editable = false;
            this.gvEmpleadoChecador.OptionsCustomization.AllowGroup = false;
            this.gvEmpleadoChecador.OptionsView.EnableAppearanceEvenRow = true;
            this.gvEmpleadoChecador.OptionsView.EnableAppearanceOddRow = true;
            this.gvEmpleadoChecador.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.gvEmpleadoChecador.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvEmpleadoChecador.OptionsView.ShowGroupPanel = false;
            // 
            // colid_interno
            // 
            this.colid_interno.Caption = "Id Interno";
            this.colid_interno.FieldName = "id_interno";
            this.colid_interno.Name = "colid_interno";
            this.colid_interno.Visible = true;
            this.colid_interno.VisibleIndex = 0;
            // 
            // colsChecador
            // 
            this.colsChecador.Caption = "Checador";
            this.colsChecador.FieldName = "sChecador";
            this.colsChecador.Name = "colsChecador";
            this.colsChecador.Visible = true;
            this.colsChecador.VisibleIndex = 1;
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleados.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(99, 18);
            this.cbEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(417, 26);
            this.cbEmpleados.TabIndex = 1;
            this.cbEmpleados.SelectedIndexChanged += new System.EventHandler(this.cbEmpleados_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Empleado:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 40);
            this.label1.TabIndex = 28;
            this.label1.Text = "Asignar Checadores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FrmAsignarChecador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAsignarChecador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Checadores";
            this.Load += new System.EventHandler(this.FrmAsignarChecador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleadoChecador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoChecadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleadoChecador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private DevExpress.XtraGrid.GridControl grdEmpleadoChecador;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmpleadoChecador;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstChecadores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId_interno;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.BindingSource empleadoChecadorBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_interno;
        private DevExpress.XtraGrid.Columns.GridColumn colsChecador;
    }
}