namespace AccNominas.Formularios.Usuarios
{
    partial class FrmChecadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChecadores));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAltaCancelar = new System.Windows.Forms.Button();
            this.btnAltasGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAltaNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbBajaNombre = new System.Windows.Forms.ComboBox();
            this.btnBajaCancelar = new System.Windows.Forms.Button();
            this.btnBajaEliminar = new System.Windows.Forms.Button();
            this.cbBajaBase = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.cbModifNombreAnterior = new System.Windows.Forms.ComboBox();
            this.btnModifCancelar = new System.Windows.Forms.Button();
            this.btnModifGuardar = new System.Windows.Forms.Button();
            this.txbModifNuevoNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbAltaBase = new System.Windows.Forms.TextBox();
            this.txbModifBase = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(464, 283);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txbAltaBase);
            this.tabPage1.Controls.Add(this.btnAltaCancelar);
            this.tabPage1.Controls.Add(this.btnAltasGuardar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txbAltaNombre);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(456, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAltaCancelar
            // 
            this.btnAltaCancelar.Image = global::AccNominas.Properties.Resources.cancelar;
            this.btnAltaCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaCancelar.Location = new System.Drawing.Point(348, 203);
            this.btnAltaCancelar.Name = "btnAltaCancelar";
            this.btnAltaCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnAltaCancelar.TabIndex = 3;
            this.btnAltaCancelar.Text = "Cancelar";
            this.btnAltaCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltaCancelar.UseVisualStyleBackColor = true;
            this.btnAltaCancelar.Click += new System.EventHandler(this.btnAltaCancelar_Click);
            // 
            // btnAltasGuardar
            // 
            this.btnAltasGuardar.Image = global::AccNominas.Properties.Resources.guardar;
            this.btnAltasGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltasGuardar.Location = new System.Drawing.Point(242, 203);
            this.btnAltasGuardar.Name = "btnAltasGuardar";
            this.btnAltasGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnAltasGuardar.TabIndex = 2;
            this.btnAltasGuardar.Text = "Guardar";
            this.btnAltasGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltasGuardar.UseVisualStyleBackColor = true;
            this.btnAltasGuardar.Click += new System.EventHandler(this.btnAltasGuardar_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nuevo Checador";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txbAltaNombre
            // 
            this.txbAltaNombre.Location = new System.Drawing.Point(129, 97);
            this.txbAltaNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txbAltaNombre.MaxLength = 100;
            this.txbAltaNombre.Name = "txbAltaNombre";
            this.txbAltaNombre.Size = new System.Drawing.Size(304, 26);
            this.txbAltaNombre.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Base de datos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbBajaNombre);
            this.tabPage2.Controls.Add(this.btnBajaCancelar);
            this.tabPage2.Controls.Add(this.btnBajaEliminar);
            this.tabPage2.Controls.Add(this.cbBajaBase);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(456, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Baja";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbBajaNombre
            // 
            this.cbBajaNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbBajaNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBajaNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBajaNombre.FormattingEnabled = true;
            this.cbBajaNombre.Location = new System.Drawing.Point(129, 97);
            this.cbBajaNombre.Name = "cbBajaNombre";
            this.cbBajaNombre.Size = new System.Drawing.Size(304, 26);
            this.cbBajaNombre.TabIndex = 4;
            this.cbBajaNombre.SelectedIndexChanged += new System.EventHandler(this.cbBajaNombre_SelectedIndexChanged);
            // 
            // btnBajaCancelar
            // 
            this.btnBajaCancelar.Image = global::AccNominas.Properties.Resources.cancelar;
            this.btnBajaCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaCancelar.Location = new System.Drawing.Point(348, 203);
            this.btnBajaCancelar.Name = "btnBajaCancelar";
            this.btnBajaCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnBajaCancelar.TabIndex = 7;
            this.btnBajaCancelar.Text = "Cancelar";
            this.btnBajaCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBajaCancelar.UseVisualStyleBackColor = true;
            this.btnBajaCancelar.Click += new System.EventHandler(this.btnBajaCancelar_Click);
            // 
            // btnBajaEliminar
            // 
            this.btnBajaEliminar.Image = global::AccNominas.Properties.Resources.guardar;
            this.btnBajaEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaEliminar.Location = new System.Drawing.Point(242, 203);
            this.btnBajaEliminar.Name = "btnBajaEliminar";
            this.btnBajaEliminar.Size = new System.Drawing.Size(100, 40);
            this.btnBajaEliminar.TabIndex = 6;
            this.btnBajaEliminar.Text = "Eliminar";
            this.btnBajaEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBajaEliminar.UseVisualStyleBackColor = true;
            this.btnBajaEliminar.Click += new System.EventHandler(this.btnBajaEliminar_Click);
            // 
            // cbBajaBase
            // 
            this.cbBajaBase.BackColor = System.Drawing.Color.White;
            this.cbBajaBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbBajaBase.Enabled = false;
            this.cbBajaBase.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBajaBase.FormattingEnabled = true;
            this.cbBajaBase.Location = new System.Drawing.Point(129, 130);
            this.cbBajaBase.Name = "cbBajaBase";
            this.cbBajaBase.Size = new System.Drawing.Size(304, 26);
            this.cbBajaBase.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Base de datos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(448, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Eliminar Checador";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txbModifBase);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.cbModifNombreAnterior);
            this.tabPage3.Controls.Add(this.btnModifCancelar);
            this.tabPage3.Controls.Add(this.btnModifGuardar);
            this.tabPage3.Controls.Add(this.txbModifNuevoNombre);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(456, 252);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cambios";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 83);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nombre Anterior:";
            // 
            // cbModifNombreAnterior
            // 
            this.cbModifNombreAnterior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModifNombreAnterior.FormattingEnabled = true;
            this.cbModifNombreAnterior.Location = new System.Drawing.Point(139, 80);
            this.cbModifNombreAnterior.Name = "cbModifNombreAnterior";
            this.cbModifNombreAnterior.Size = new System.Drawing.Size(304, 26);
            this.cbModifNombreAnterior.TabIndex = 16;
            // 
            // btnModifCancelar
            // 
            this.btnModifCancelar.Image = global::AccNominas.Properties.Resources.cancelar;
            this.btnModifCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifCancelar.Location = new System.Drawing.Point(348, 203);
            this.btnModifCancelar.Name = "btnModifCancelar";
            this.btnModifCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnModifCancelar.TabIndex = 15;
            this.btnModifCancelar.Text = "Cancelar";
            this.btnModifCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifCancelar.UseVisualStyleBackColor = true;
            this.btnModifCancelar.Click += new System.EventHandler(this.btnModifCancelar_Click);
            // 
            // btnModifGuardar
            // 
            this.btnModifGuardar.Image = global::AccNominas.Properties.Resources.guardar;
            this.btnModifGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifGuardar.Location = new System.Drawing.Point(242, 203);
            this.btnModifGuardar.Name = "btnModifGuardar";
            this.btnModifGuardar.Size = new System.Drawing.Size(100, 40);
            this.btnModifGuardar.TabIndex = 14;
            this.btnModifGuardar.Text = "Guardar";
            this.btnModifGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifGuardar.UseVisualStyleBackColor = true;
            this.btnModifGuardar.Click += new System.EventHandler(this.btnModifGuardar_Click);
            // 
            // txbModifNuevoNombre
            // 
            this.txbModifNuevoNombre.Location = new System.Drawing.Point(139, 113);
            this.txbModifNuevoNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txbModifNuevoNombre.MaxLength = 100;
            this.txbModifNuevoNombre.Name = "txbModifNuevoNombre";
            this.txbModifNuevoNombre.Size = new System.Drawing.Size(304, 26);
            this.txbModifNuevoNombre.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Base de datos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 116);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nuevo Nombre:";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(456, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Modificar Datos de Checador";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txbAltaBase
            // 
            this.txbAltaBase.Location = new System.Drawing.Point(128, 130);
            this.txbAltaBase.Name = "txbAltaBase";
            this.txbAltaBase.Size = new System.Drawing.Size(304, 26);
            this.txbAltaBase.TabIndex = 1;
            // 
            // txbModifBase
            // 
            this.txbModifBase.Location = new System.Drawing.Point(139, 146);
            this.txbModifBase.Name = "txbModifBase";
            this.txbModifBase.Size = new System.Drawing.Size(304, 26);
            this.txbModifBase.TabIndex = 18;
            // 
            // FrmChecadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 282);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(480, 320);
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "FrmChecadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checadores";
            this.Load += new System.EventHandler(this.FrmChecadores_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txbAltaNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAltaCancelar;
        private System.Windows.Forms.Button btnAltasGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBajaCancelar;
        private System.Windows.Forms.Button btnBajaEliminar;
        private System.Windows.Forms.ComboBox cbBajaBase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModifCancelar;
        private System.Windows.Forms.Button btnModifGuardar;
        private System.Windows.Forms.TextBox txbModifNuevoNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBajaNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbModifNombreAnterior;
        private System.Windows.Forms.TextBox txbAltaBase;
        private System.Windows.Forms.TextBox txbModifBase;
    }
}