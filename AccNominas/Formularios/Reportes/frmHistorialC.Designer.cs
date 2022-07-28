namespace AccNominas.Formularios.Reportes
{
    partial class frmHistorialC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialC));
            this.label1 = new System.Windows.Forms.Label();
            this.pn1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNumChecador = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDepto = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDpto = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbPorEmpl = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImpresion = new System.Windows.Forms.Button();
            this.sscHistorial = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.gcChecadas = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidInterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colempleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidDepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.pnEdita = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbActivos = new System.Windows.Forms.ComboBox();
            this.tbIdInterno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardaCambios = new System.Windows.Forms.Button();
            this.cmbDepto = new System.Windows.Forms.ComboBox();
            this.tbEmpleado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBusqueda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnActEmpl = new System.Windows.Forms.Button();
            this.pnInicio = new System.Windows.Forms.Panel();
            this.cbChecadores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pn1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChecadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnEdita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.pnInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F);
            this.label1.Location = new System.Drawing.Point(138, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historial de Checadas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.label1);
            this.pn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn1.Location = new System.Drawing.Point(0, 0);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(616, 51);
            this.pn1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.Location = new System.Drawing.Point(566, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Núm. Checador";
            this.label4.Visible = false;
            // 
            // cmbNumChecador
            // 
            this.cmbNumChecador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumChecador.DropDownWidth = 93;
            this.cmbNumChecador.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.cmbNumChecador.FormattingEnabled = true;
            this.cmbNumChecador.Location = new System.Drawing.Point(542, 58);
            this.cmbNumChecador.Name = "cmbNumChecador";
            this.cmbNumChecador.Size = new System.Drawing.Size(22, 23);
            this.cmbNumChecador.TabIndex = 29;
            this.cmbNumChecador.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cbDepto);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbDpto);
            this.panel2.Location = new System.Drawing.Point(8, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 44);
            this.panel2.TabIndex = 27;
            // 
            // cbDepto
            // 
            this.cbDepto.AutoSize = true;
            this.cbDepto.Location = new System.Drawing.Point(14, 12);
            this.cbDepto.Name = "cbDepto";
            this.cbDepto.Size = new System.Drawing.Size(112, 17);
            this.cbDepto.TabIndex = 21;
            this.cbDepto.Text = "Por Departamento";
            this.cbDepto.UseVisualStyleBackColor = true;
            this.cbDepto.CheckedChanged += new System.EventHandler(this.cbDepto_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label7.Location = new System.Drawing.Point(161, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Depto.";
            // 
            // cmbDpto
            // 
            this.cmbDpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDpto.DropDownWidth = 400;
            this.cmbDpto.Enabled = false;
            this.cmbDpto.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cmbDpto.FormattingEnabled = true;
            this.cmbDpto.Location = new System.Drawing.Point(212, 10);
            this.cmbDpto.Name = "cmbDpto";
            this.cmbDpto.Size = new System.Drawing.Size(249, 24);
            this.cmbDpto.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbPorEmpl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbNombre);
            this.panel1.Location = new System.Drawing.Point(8, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 44);
            this.panel1.TabIndex = 26;
            // 
            // cbPorEmpl
            // 
            this.cbPorEmpl.AutoSize = true;
            this.cbPorEmpl.Location = new System.Drawing.Point(14, 12);
            this.cbPorEmpl.Name = "cbPorEmpl";
            this.cbPorEmpl.Size = new System.Drawing.Size(92, 17);
            this.cbPorEmpl.TabIndex = 20;
            this.cbPorEmpl.Text = "Por Empleado";
            this.cbPorEmpl.UseVisualStyleBackColor = true;
            this.cbPorEmpl.CheckedChanged += new System.EventHandler(this.cbPorEmpl_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.Location = new System.Drawing.Point(153, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre";
            // 
            // cmbNombre
            // 
            this.cmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombre.DropDownWidth = 400;
            this.cmbNombre.Enabled = false;
            this.cmbNombre.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(212, 10);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(249, 23);
            this.cmbNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Fecha Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(210, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha Inicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(210, 121);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(91, 20);
            this.dtpFechaInicio.TabIndex = 23;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(352, 121);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(91, 20);
            this.dtpFechaFin.TabIndex = 22;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::AccNominas.Properties.Resources.consultar;
            this.btnBuscar.Location = new System.Drawing.Point(493, 153);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 44);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar Checada";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImpresion
            // 
            this.btnImpresion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpresion.Image = global::AccNominas.Properties.Resources.Excel_34x34;
            this.btnImpresion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImpresion.Location = new System.Drawing.Point(498, 391);
            this.btnImpresion.Name = "btnImpresion";
            this.btnImpresion.Size = new System.Drawing.Size(102, 40);
            this.btnImpresion.TabIndex = 32;
            this.btnImpresion.Text = "Exporta";
            this.btnImpresion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImpresion.UseVisualStyleBackColor = true;
            this.btnImpresion.Click += new System.EventHandler(this.btnImpresion_Click);
            // 
            // sscHistorial
            // 
            this.sscHistorial.Location = new System.Drawing.Point(26, 411);
            this.sscHistorial.Name = "sscHistorial";
            this.sscHistorial.Size = new System.Drawing.Size(106, 71);
            this.sscHistorial.TabIndex = 33;
            this.sscHistorial.Visible = false;
            // 
            // gcChecadas
            // 
            this.gcChecadas.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcChecadas.Location = new System.Drawing.Point(10, 5);
            this.gcChecadas.MainView = this.gridView1;
            this.gcChecadas.Name = "gcChecadas";
            this.gcChecadas.Size = new System.Drawing.Size(590, 381);
            this.gcChecadas.TabIndex = 34;
            this.gcChecadas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidInterno,
            this.colempleado,
            this.colidDepto,
            this.coldepartamento,
            this.colfechaHora});
            this.gridView1.GridControl = this.gcChecadas;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Checadas";
            // 
            // colidInterno
            // 
            this.colidInterno.AppearanceCell.Options.UseTextOptions = true;
            this.colidInterno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colidInterno.AppearanceHeader.Options.UseTextOptions = true;
            this.colidInterno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colidInterno.Caption = "Id Interno";
            this.colidInterno.FieldName = "idInterno";
            this.colidInterno.Name = "colidInterno";
            this.colidInterno.Visible = true;
            this.colidInterno.VisibleIndex = 0;
            // 
            // colempleado
            // 
            this.colempleado.Caption = "Empleado";
            this.colempleado.FieldName = "empleado";
            this.colempleado.Name = "colempleado";
            this.colempleado.Visible = true;
            this.colempleado.VisibleIndex = 2;
            // 
            // colidDepto
            // 
            this.colidDepto.FieldName = "idDepto";
            this.colidDepto.Name = "colidDepto";
            // 
            // coldepartamento
            // 
            this.coldepartamento.Caption = "Departamento";
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            this.coldepartamento.Visible = true;
            this.coldepartamento.VisibleIndex = 3;
            this.coldepartamento.Width = 90;
            // 
            // colfechaHora
            // 
            this.colfechaHora.Caption = "Fecha y Hora";
            this.colfechaHora.FieldName = "fechaHora";
            this.colfechaHora.Name = "colfechaHora";
            this.colfechaHora.Visible = true;
            this.colfechaHora.VisibleIndex = 1;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Image = global::AccNominas.Properties.Resources.reloj;
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(493, 204);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(118, 45);
            this.btnHistorial.TabIndex = 35;
            this.btnHistorial.Text = "Busca Empleados";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // pnEdita
            // 
            this.pnEdita.Controls.Add(this.dgvEmpleados);
            this.pnEdita.Controls.Add(this.label12);
            this.pnEdita.Controls.Add(this.cmbActivos);
            this.pnEdita.Controls.Add(this.tbIdInterno);
            this.pnEdita.Controls.Add(this.label9);
            this.pnEdita.Controls.Add(this.btnGuardaCambios);
            this.pnEdita.Controls.Add(this.cmbDepto);
            this.pnEdita.Controls.Add(this.tbEmpleado);
            this.pnEdita.Controls.Add(this.label10);
            this.pnEdita.Controls.Add(this.label11);
            this.pnEdita.Controls.Add(this.tbBusqueda);
            this.pnEdita.Controls.Add(this.label8);
            this.pnEdita.Location = new System.Drawing.Point(2, 257);
            this.pnEdita.Name = "pnEdita";
            this.pnEdita.Size = new System.Drawing.Size(609, 434);
            this.pnEdita.TabIndex = 36;
            this.pnEdita.Visible = false;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(3, 39);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(596, 236);
            this.dgvEmpleados.TabIndex = 21;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(421, 350);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Activo";
            // 
            // cmbActivos
            // 
            this.cmbActivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivos.FormattingEnabled = true;
            this.cmbActivos.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbActivos.Location = new System.Drawing.Point(476, 347);
            this.cmbActivos.Name = "cmbActivos";
            this.cmbActivos.Size = new System.Drawing.Size(124, 21);
            this.cmbActivos.TabIndex = 19;
            // 
            // tbIdInterno
            // 
            this.tbIdInterno.Location = new System.Drawing.Point(111, 281);
            this.tbIdInterno.Name = "tbIdInterno";
            this.tbIdInterno.ReadOnly = true;
            this.tbIdInterno.Size = new System.Drawing.Size(75, 20);
            this.tbIdInterno.TabIndex = 18;
            this.tbIdInterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Departamento";
            // 
            // btnGuardaCambios
            // 
            this.btnGuardaCambios.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardaCambios.Image = global::AccNominas.Properties.Resources.aceptar;
            this.btnGuardaCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardaCambios.Location = new System.Drawing.Point(249, 377);
            this.btnGuardaCambios.Name = "btnGuardaCambios";
            this.btnGuardaCambios.Size = new System.Drawing.Size(112, 46);
            this.btnGuardaCambios.TabIndex = 16;
            this.btnGuardaCambios.Text = "Guardar Cambios";
            this.btnGuardaCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardaCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardaCambios.UseVisualStyleBackColor = true;
            this.btnGuardaCambios.Click += new System.EventHandler(this.btnGuardaCambios_Click);
            // 
            // cmbDepto
            // 
            this.cmbDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepto.FormattingEnabled = true;
            this.cmbDepto.Location = new System.Drawing.Point(133, 350);
            this.cmbDepto.Name = "cmbDepto";
            this.cmbDepto.Size = new System.Drawing.Size(261, 21);
            this.cmbDepto.TabIndex = 15;
            // 
            // tbEmpleado
            // 
            this.tbEmpleado.Location = new System.Drawing.Point(111, 312);
            this.tbEmpleado.Name = "tbEmpleado";
            this.tbEmpleado.Size = new System.Drawing.Size(491, 20);
            this.tbEmpleado.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "Empleado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Id Interno";
            // 
            // tbBusqueda
            // 
            this.tbBusqueda.Location = new System.Drawing.Point(127, 13);
            this.tbBusqueda.Name = "tbBusqueda";
            this.tbBusqueda.Size = new System.Drawing.Size(456, 20);
            this.tbBusqueda.TabIndex = 8;
            this.tbBusqueda.TextChanged += new System.EventHandler(this.tbBusqueda_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Búsqueda";
            // 
            // btnActEmpl
            // 
            this.btnActEmpl.Image = global::AccNominas.Properties.Resources.consultar;
            this.btnActEmpl.Location = new System.Drawing.Point(668, 61);
            this.btnActEmpl.Name = "btnActEmpl";
            this.btnActEmpl.Size = new System.Drawing.Size(44, 36);
            this.btnActEmpl.TabIndex = 9;
            this.btnActEmpl.UseVisualStyleBackColor = true;
            this.btnActEmpl.Visible = false;
            // 
            // pnInicio
            // 
            this.pnInicio.Controls.Add(this.gcChecadas);
            this.pnInicio.Controls.Add(this.btnImpresion);
            this.pnInicio.Controls.Add(this.sscHistorial);
            this.pnInicio.Location = new System.Drawing.Point(3, 255);
            this.pnInicio.Name = "pnInicio";
            this.pnInicio.Size = new System.Drawing.Size(605, 434);
            this.pnInicio.TabIndex = 37;
            this.pnInicio.Visible = false;
            // 
            // cbChecadores
            // 
            this.cbChecadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChecadores.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChecadores.FormattingEnabled = true;
            this.cbChecadores.Location = new System.Drawing.Point(190, 58);
            this.cbChecadores.Margin = new System.Windows.Forms.Padding(4);
            this.cbChecadores.Name = "cbChecadores";
            this.cbChecadores.Size = new System.Drawing.Size(272, 26);
            this.cbChecadores.TabIndex = 38;
            this.cbChecadores.SelectedIndexChanged += new System.EventHandler(this.cbChecadores_SelectedIndexChanged);
            this.cbChecadores.SelectionChangeCommitted += new System.EventHandler(this.cbChecadores_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Checador:";
            // 
            // frmHistorialC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 690);
            this.Controls.Add(this.cbChecadores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbNumChecador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnActEmpl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pnEdita);
            this.Controls.Add(this.pnInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorialC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checadas";
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChecadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnEdita.ResumeLayout(false);
            this.pnEdita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.pnInicio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNumChecador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbDepto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDpto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbPorEmpl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnImpresion;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl sscHistorial;
        private DevExpress.XtraGrid.GridControl gcChecadas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colidInterno;
        private DevExpress.XtraGrid.Columns.GridColumn colempleado;
        private DevExpress.XtraGrid.Columns.GridColumn colidDepto;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaHora;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Panel pnEdita;
        private System.Windows.Forms.TextBox tbIdInterno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardaCambios;
        private System.Windows.Forms.ComboBox cmbDepto;
        private System.Windows.Forms.TextBox tbEmpleado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnActEmpl;
        private System.Windows.Forms.TextBox tbBusqueda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnInicio;
        private System.Windows.Forms.ComboBox cbChecadores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbActivos;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}