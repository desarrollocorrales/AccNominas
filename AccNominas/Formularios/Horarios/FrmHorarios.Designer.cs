namespace AccNominas.Formularios.Horarios
{
    partial class FrmHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHorarios));
            this.label2 = new System.Windows.Forms.Label();
            this.chbLunes = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chbMartes = new System.Windows.Forms.CheckBox();
            this.chbMiercoles = new System.Windows.Forms.CheckBox();
            this.chbJueves = new System.Windows.Forms.CheckBox();
            this.chbViernes = new System.Windows.Forms.CheckBox();
            this.chbSabado = new System.Windows.Forms.CheckBox();
            this.chbDomingo = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.chbDiaSiguiente = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDescripcion = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuitarDetalle = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHoraMax = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMinutMax = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbHoraChec = new System.Windows.Forms.ComboBox();
            this.cbMinutChec = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHoraMin = new System.Windows.Forms.ComboBox();
            this.cbMinutMin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.gridDetalles = new DevExpress.XtraGrid.GridControl();
            this.horariosDetallesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvDetalles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_horario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_minima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_checada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhora_maxima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbConcepto = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horariosDetallesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            this.SuspendLayout();
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
            this.chbLunes.AutoSize = true;
            this.chbLunes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLunes.Location = new System.Drawing.Point(132, 104);
            this.chbLunes.Margin = new System.Windows.Forms.Padding(4);
            this.chbLunes.Name = "chbLunes";
            this.chbLunes.Size = new System.Drawing.Size(63, 22);
            this.chbLunes.TabIndex = 3;
            this.chbLunes.Text = "Lunes";
            this.chbLunes.UseVisualStyleBackColor = true;
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
            // chbMartes
            // 
            this.chbMartes.AutoSize = true;
            this.chbMartes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMartes.Location = new System.Drawing.Point(203, 104);
            this.chbMartes.Margin = new System.Windows.Forms.Padding(4);
            this.chbMartes.Name = "chbMartes";
            this.chbMartes.Size = new System.Drawing.Size(70, 22);
            this.chbMartes.TabIndex = 4;
            this.chbMartes.Text = "Martes";
            this.chbMartes.UseVisualStyleBackColor = true;
            // 
            // chbMiercoles
            // 
            this.chbMiercoles.AutoSize = true;
            this.chbMiercoles.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMiercoles.Location = new System.Drawing.Point(281, 104);
            this.chbMiercoles.Margin = new System.Windows.Forms.Padding(4);
            this.chbMiercoles.Name = "chbMiercoles";
            this.chbMiercoles.Size = new System.Drawing.Size(88, 22);
            this.chbMiercoles.TabIndex = 5;
            this.chbMiercoles.Text = "Miercoles";
            this.chbMiercoles.UseVisualStyleBackColor = true;
            // 
            // chbJueves
            // 
            this.chbJueves.AutoSize = true;
            this.chbJueves.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbJueves.Location = new System.Drawing.Point(377, 104);
            this.chbJueves.Margin = new System.Windows.Forms.Padding(4);
            this.chbJueves.Name = "chbJueves";
            this.chbJueves.Size = new System.Drawing.Size(69, 22);
            this.chbJueves.TabIndex = 6;
            this.chbJueves.Text = "Jueves";
            this.chbJueves.UseVisualStyleBackColor = true;
            // 
            // chbViernes
            // 
            this.chbViernes.AutoSize = true;
            this.chbViernes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbViernes.Location = new System.Drawing.Point(452, 104);
            this.chbViernes.Margin = new System.Windows.Forms.Padding(4);
            this.chbViernes.Name = "chbViernes";
            this.chbViernes.Size = new System.Drawing.Size(75, 22);
            this.chbViernes.TabIndex = 7;
            this.chbViernes.Text = "Viernes";
            this.chbViernes.UseVisualStyleBackColor = true;
            // 
            // chbSabado
            // 
            this.chbSabado.AutoSize = true;
            this.chbSabado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSabado.Location = new System.Drawing.Point(535, 104);
            this.chbSabado.Margin = new System.Windows.Forms.Padding(4);
            this.chbSabado.Name = "chbSabado";
            this.chbSabado.Size = new System.Drawing.Size(72, 22);
            this.chbSabado.TabIndex = 8;
            this.chbSabado.Text = "Sabado";
            this.chbSabado.UseVisualStyleBackColor = true;
            // 
            // chbDomingo
            // 
            this.chbDomingo.AutoSize = true;
            this.chbDomingo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDomingo.Location = new System.Drawing.Point(41, 104);
            this.chbDomingo.Margin = new System.Windows.Forms.Padding(4);
            this.chbDomingo.Name = "chbDomingo";
            this.chbDomingo.Size = new System.Drawing.Size(83, 22);
            this.chbDomingo.TabIndex = 2;
            this.chbDomingo.Text = "Domingo";
            this.chbDomingo.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(659, 30);
            this.lblTitulo.TabIndex = 27;
            this.lblTitulo.Text = "Nuevo Horario";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // chbDiaSiguiente
            // 
            this.chbDiaSiguiente.AutoSize = true;
            this.chbDiaSiguiente.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDiaSiguiente.Location = new System.Drawing.Point(41, 134);
            this.chbDiaSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.chbDiaSiguiente.Name = "chbDiaSiguiente";
            this.chbDiaSiguiente.Size = new System.Drawing.Size(160, 22);
            this.chbDiaSiguiente.TabIndex = 9;
            this.chbDiaSiguiente.Text = "Checa al día siguiente";
            this.chbDiaSiguiente.UseVisualStyleBackColor = true;
            this.chbDiaSiguiente.CheckedChanged += new System.EventHandler(this.chbDiaSiguiente_CheckedChanged);
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 187);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horario";
            // 
            // cbDescripcion
            // 
            this.cbDescripcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbDescripcion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDescripcion.FormattingEnabled = true;
            this.cbDescripcion.Location = new System.Drawing.Point(31, 51);
            this.cbDescripcion.Name = "cbDescripcion";
            this.cbDescripcion.Size = new System.Drawing.Size(397, 21);
            this.cbDescripcion.TabIndex = 1;
            this.cbDescripcion.SelectedIndexChanged += new System.EventHandler(this.cbDescripcion_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuitarDetalle);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.btnAgregarDetalle);
            this.groupBox2.Controls.Add(this.gridDetalles);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbConcepto);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 213);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del horario";
            // 
            // btnQuitarDetalle
            // 
            this.btnQuitarDetalle.AutoSize = true;
            this.btnQuitarDetalle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarDetalle.Location = new System.Drawing.Point(593, 94);
            this.btnQuitarDetalle.Name = "btnQuitarDetalle";
            this.btnQuitarDetalle.Size = new System.Drawing.Size(35, 28);
            this.btnQuitarDetalle.TabIndex = 17;
            this.btnQuitarDetalle.Text = "-";
            this.btnQuitarDetalle.UseVisualStyleBackColor = true;
            this.btnQuitarDetalle.Click += new System.EventHandler(this.btnQuitarDetalle_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.cbHoraMax);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.cbMinutMax);
            this.panel4.Location = new System.Drawing.Point(462, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 63);
            this.panel4.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora Maxima";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cbHoraMax
            // 
            this.cbHoraMax.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbHoraMax.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbHoraMax.DropDownHeight = 75;
            this.cbHoraMax.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoraMax.FormattingEnabled = true;
            this.cbHoraMax.IntegralHeight = false;
            this.cbHoraMax.ItemHeight = 18;
            this.cbHoraMax.Location = new System.Drawing.Point(13, 32);
            this.cbHoraMax.MaxLength = 2;
            this.cbHoraMax.Name = "cbHoraMax";
            this.cbHoraMax.Size = new System.Drawing.Size(44, 26);
            this.cbHoraMax.TabIndex = 14;
            this.cbHoraMax.Text = "99";
            this.cbHoraMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbHoraMin_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = ":";
            // 
            // cbMinutMax
            // 
            this.cbMinutMax.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbMinutMax.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cbMinutMax.DropDownHeight = 75;
            this.cbMinutMax.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinutMax.FormattingEnabled = true;
            this.cbMinutMax.IntegralHeight = false;
            this.cbMinutMax.ItemHeight = 18;
            this.cbMinutMax.Location = new System.Drawing.Point(65, 32);
            this.cbMinutMax.MaxLength = 2;
            this.cbMinutMax.Name = "cbMinutMax";
            this.cbMinutMax.Size = new System.Drawing.Size(44, 26);
            this.cbMinutMax.TabIndex = 15;
            this.cbMinutMax.Text = "99";
            this.cbMinutMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbHoraMin_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cbHoraChec);
            this.panel3.Controls.Add(this.cbMinutChec);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(331, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 63);
            this.panel3.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Hora de Checada";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cbHoraChec
            // 
            this.cbHoraChec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbHoraChec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbHoraChec.DropDownHeight = 75;
            this.cbHoraChec.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoraChec.FormattingEnabled = true;
            this.cbHoraChec.IntegralHeight = false;
            this.cbHoraChec.ItemHeight = 18;
            this.cbHoraChec.Location = new System.Drawing.Point(13, 32);
            this.cbHoraChec.MaxLength = 2;
            this.cbHoraChec.Name = "cbHoraChec";
            this.cbHoraChec.Size = new System.Drawing.Size(44, 26);
            this.cbHoraChec.TabIndex = 12;
            this.cbHoraChec.Text = "99";
            this.cbHoraChec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbHoraMin_KeyPress);
            // 
            // cbMinutChec
            // 
            this.cbMinutChec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbMinutChec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMinutChec.DropDownHeight = 75;
            this.cbMinutChec.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinutChec.FormattingEnabled = true;
            this.cbMinutChec.IntegralHeight = false;
            this.cbMinutChec.ItemHeight = 18;
            this.cbMinutChec.Location = new System.Drawing.Point(65, 32);
            this.cbMinutChec.MaxLength = 2;
            this.cbMinutChec.Name = "cbMinutChec";
            this.cbMinutChec.Size = new System.Drawing.Size(44, 26);
            this.cbMinutChec.TabIndex = 13;
            this.cbMinutChec.Text = "99";
            this.cbMinutChec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbHoraMin_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 18);
            this.label8.TabIndex = 31;
            this.label8.Text = ":";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbHoraMin);
            this.panel2.Controls.Add(this.cbMinutMin);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(200, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 63);
            this.panel2.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora Minima";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cbHoraMin
            // 
            this.cbHoraMin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbHoraMin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbHoraMin.DropDownHeight = 75;
            this.cbHoraMin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoraMin.FormattingEnabled = true;
            this.cbHoraMin.IntegralHeight = false;
            this.cbHoraMin.ItemHeight = 18;
            this.cbHoraMin.Location = new System.Drawing.Point(13, 32);
            this.cbHoraMin.MaxLength = 2;
            this.cbHoraMin.Name = "cbHoraMin";
            this.cbHoraMin.Size = new System.Drawing.Size(44, 26);
            this.cbHoraMin.TabIndex = 10;
            this.cbHoraMin.Text = "99";
            this.cbHoraMin.SelectedIndexChanged += new System.EventHandler(this.cbHoraMin_SelectedIndexChanged);
            this.cbHoraMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbHoraMin_KeyPress);
            // 
            // cbMinutMin
            // 
            this.cbMinutMin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbMinutMin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMinutMin.DropDownHeight = 75;
            this.cbMinutMin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinutMin.FormattingEnabled = true;
            this.cbMinutMin.IntegralHeight = false;
            this.cbMinutMin.ItemHeight = 18;
            this.cbMinutMin.Location = new System.Drawing.Point(65, 32);
            this.cbMinutMin.MaxLength = 2;
            this.cbMinutMin.Name = "cbMinutMin";
            this.cbMinutMin.Size = new System.Drawing.Size(44, 26);
            this.cbMinutMin.TabIndex = 11;
            this.cbMinutMin.Text = "99";
            this.cbMinutMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbHoraMin_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = ":";
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.AutoSize = true;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.Location = new System.Drawing.Point(593, 60);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(35, 28);
            this.btnAgregarDetalle.TabIndex = 16;
            this.btnAgregarDetalle.Text = "+";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // gridDetalles
            // 
            this.gridDetalles.DataSource = this.horariosDetallesBindingSource;
            this.gridDetalles.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridDetalles.Location = new System.Drawing.Point(7, 94);
            this.gridDetalles.MainView = this.gvDetalles;
            this.gridDetalles.Name = "gridDetalles";
            this.gridDetalles.Size = new System.Drawing.Size(580, 113);
            this.gridDetalles.TabIndex = 13;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Concepto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cbConcepto
            // 
            this.cbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConcepto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConcepto.FormattingEnabled = true;
            this.cbConcepto.Location = new System.Drawing.Point(7, 62);
            this.cbConcepto.Name = "cbConcepto";
            this.cbConcepto.Size = new System.Drawing.Size(187, 26);
            this.cbConcepto.TabIndex = 10;
            this.cbConcepto.SelectedIndexChanged += new System.EventHandler(this.cbConcepto_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::AccNominas.Properties.Resources.guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(434, 470);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 40);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::AccNominas.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(547, 470);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 450);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(298, 18);
            this.label10.TabIndex = 33;
            this.label10.Text = "*El formato de tiempo esta basado en 24 horas.";
            // 
            // imgLoading
            // 
            this.imgLoading.Image = global::AccNominas.Properties.Resources.cargando;
            this.imgLoading.Location = new System.Drawing.Point(245, 214);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(169, 94);
            this.imgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLoading.TabIndex = 21;
            this.imgLoading.TabStop = false;
            this.imgLoading.Visible = false;
            // 
            // FrmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 522);
            this.Controls.Add(this.imgLoading);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(675, 560);
            this.MinimumSize = new System.Drawing.Size(675, 560);
            this.Name = "FrmHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horarios";
            this.Load += new System.EventHandler(this.FrmHorarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horariosDetallesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbLunes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chbMartes;
        private System.Windows.Forms.CheckBox chbMiercoles;
        private System.Windows.Forms.CheckBox chbJueves;
        private System.Windows.Forms.CheckBox chbViernes;
        private System.Windows.Forms.CheckBox chbSabado;
        private System.Windows.Forms.CheckBox chbDomingo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.CheckBox chbDiaSiguiente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbMinutMax;
        private System.Windows.Forms.ComboBox cbHoraMax;
        private System.Windows.Forms.ComboBox cbMinutChec;
        private System.Windows.Forms.ComboBox cbHoraChec;
        private System.Windows.Forms.ComboBox cbMinutMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHoraMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConcepto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private DevExpress.XtraGrid.GridControl gridDetalles;
        private System.Windows.Forms.BindingSource horariosDetallesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDetalles;
        private DevExpress.XtraGrid.Columns.GridColumn colid_detalle;
        private DevExpress.XtraGrid.Columns.GridColumn colid_horario;
        private DevExpress.XtraGrid.Columns.GridColumn coloConcepto;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_minima;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_checada;
        private DevExpress.XtraGrid.Columns.GridColumn colhora_maxima;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbDescripcion;
        private System.Windows.Forms.Button btnQuitarDetalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox imgLoading;

    }
}