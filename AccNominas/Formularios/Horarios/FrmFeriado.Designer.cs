namespace AccNominas.Formularios.Horarios
{
    partial class FrmFeriado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFeriado));
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.rbPorDepto = new System.Windows.Forms.RadioButton();
            this.rbPorNombre = new System.Windows.Forms.RadioButton();
            this.cbDeptos = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbPersonaAutoriza = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.imgCargando = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCargando)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleados.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(198, 69);
            this.cbEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(350, 26);
            this.cbEmpleados.TabIndex = 3;
            // 
            // rbPorDepto
            // 
            this.rbPorDepto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPorDepto.Location = new System.Drawing.Point(36, 105);
            this.rbPorDepto.Margin = new System.Windows.Forms.Padding(4);
            this.rbPorDepto.Name = "rbPorDepto";
            this.rbPorDepto.Size = new System.Drawing.Size(154, 27);
            this.rbPorDepto.TabIndex = 2;
            this.rbPorDepto.Text = "Por Departamento:";
            this.rbPorDepto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPorDepto.UseVisualStyleBackColor = true;
            this.rbPorDepto.CheckedChanged += new System.EventHandler(this.rbPorDepto_CheckedChanged);
            // 
            // rbPorNombre
            // 
            this.rbPorNombre.Checked = true;
            this.rbPorNombre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPorNombre.Location = new System.Drawing.Point(36, 68);
            this.rbPorNombre.Margin = new System.Windows.Forms.Padding(4);
            this.rbPorNombre.Name = "rbPorNombre";
            this.rbPorNombre.Size = new System.Drawing.Size(154, 27);
            this.rbPorNombre.TabIndex = 1;
            this.rbPorNombre.TabStop = true;
            this.rbPorNombre.Text = "Por Empleado:";
            this.rbPorNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPorNombre.UseVisualStyleBackColor = true;
            this.rbPorNombre.CheckedChanged += new System.EventHandler(this.rbPorNombre_CheckedChanged);
            // 
            // cbDeptos
            // 
            this.cbDeptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDeptos.Enabled = false;
            this.cbDeptos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDeptos.FormattingEnabled = true;
            this.cbDeptos.Location = new System.Drawing.Point(198, 105);
            this.cbDeptos.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbDeptos.Name = "cbDeptos";
            this.cbDeptos.Size = new System.Drawing.Size(349, 26);
            this.cbDeptos.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(584, 40);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Justificacion Vacacional o Feriado";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txbPersonaAutoriza
            // 
            this.txbPersonaAutoriza.BackColor = System.Drawing.Color.White;
            this.txbPersonaAutoriza.Enabled = false;
            this.txbPersonaAutoriza.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPersonaAutoriza.Location = new System.Drawing.Point(198, 389);
            this.txbPersonaAutoriza.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txbPersonaAutoriza.Name = "txbPersonaAutoriza";
            this.txbPersonaAutoriza.Size = new System.Drawing.Size(335, 26);
            this.txbPersonaAutoriza.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 392);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Persona que autoriza:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(198, 207);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(335, 170);
            this.txtDetalle.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Detalle:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Concepto:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::AccNominas.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(471, 429);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Image = global::AccNominas.Properties.Resources.guardar;
            this.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignar.Location = new System.Drawing.Point(363, 429);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(100, 40);
            this.btnAsignar.TabIndex = 10;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // dtpInicial
            // 
            this.dtpInicial.CustomFormat = "yyyy/MM/dd";
            this.dtpInicial.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpInicial.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicial.Location = new System.Drawing.Point(198, 140);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(147, 26);
            this.dtpInicial.TabIndex = 5;
            this.dtpInicial.ValueChanged += new System.EventHandler(this.dtpInicial_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fecha:";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(198, 172);
            this.txtConcepto.MaxLength = 20;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(182, 26);
            this.txtConcepto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "al";
            // 
            // dtpFinal
            // 
            this.dtpFinal.CustomFormat = "yyyy/MM/dd";
            this.dtpFinal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFinal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinal.Location = new System.Drawing.Point(378, 140);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(147, 26);
            this.dtpFinal.TabIndex = 6;
            this.dtpFinal.ValueChanged += new System.EventHandler(this.dtpFinal_ValueChanged);
            // 
            // imgCargando
            // 
            this.imgCargando.Image = global::AccNominas.Properties.Resources.cargando;
            this.imgCargando.Location = new System.Drawing.Point(208, 194);
            this.imgCargando.Name = "imgCargando";
            this.imgCargando.Size = new System.Drawing.Size(169, 94);
            this.imgCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgCargando.TabIndex = 31;
            this.imgCargando.TabStop = false;
            this.imgCargando.Visible = false;
            // 
            // FrmFeriado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 482);
            this.Controls.Add(this.imgCargando);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.txbPersonaAutoriza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbEmpleados);
            this.Controls.Add(this.rbPorDepto);
            this.Controls.Add(this.rbPorNombre);
            this.Controls.Add(this.cbDeptos);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 520);
            this.MinimumSize = new System.Drawing.Size(600, 520);
            this.Name = "FrmFeriado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacaciones o Feriado";
            this.Load += new System.EventHandler(this.FrmFeriado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCargando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.RadioButton rbPorDepto;
        private System.Windows.Forms.RadioButton rbPorNombre;
        private System.Windows.Forms.ComboBox cbDeptos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbPersonaAutoriza;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.PictureBox imgCargando;
    }
}