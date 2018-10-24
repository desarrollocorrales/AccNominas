namespace AccNominas
{
    partial class FrmReporteAsistencia
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTituloNombre = new System.Windows.Forms.Label();
            this.lblTituloID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdInterno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 79);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(750, 475);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(750, 31);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Reporte de Asistencias";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloNombre
            // 
            this.lblTituloNombre.AutoSize = true;
            this.lblTituloNombre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNombre.Location = new System.Drawing.Point(9, 58);
            this.lblTituloNombre.Name = "lblTituloNombre";
            this.lblTituloNombre.Size = new System.Drawing.Size(151, 18);
            this.lblTituloNombre.TabIndex = 2;
            this.lblTituloNombre.Text = "Nombre del Empleado:";
            // 
            // lblTituloID
            // 
            this.lblTituloID.AutoSize = true;
            this.lblTituloID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloID.Location = new System.Drawing.Point(86, 40);
            this.lblTituloID.Name = "lblTituloID";
            this.lblTituloID.Size = new System.Drawing.Size(74, 18);
            this.lblTituloID.TabIndex = 3;
            this.lblTituloID.Text = "ID Interno:";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(159, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(603, 18);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Guillermo Alvarado Montañez";
            // 
            // lblIdInterno
            // 
            this.lblIdInterno.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdInterno.Location = new System.Drawing.Point(159, 40);
            this.lblIdInterno.Name = "lblIdInterno";
            this.lblIdInterno.Size = new System.Drawing.Size(603, 18);
            this.lblIdInterno.TabIndex = 5;
            this.lblIdInterno.Text = "514";
            // 
            // FrmReporteAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 566);
            this.Controls.Add(this.lblIdInterno);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTituloID);
            this.Controls.Add(this.lblTituloNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmReporteAsistencia";
            this.Text = "FrmReporteAsistencia";
            this.Load += new System.EventHandler(this.FrmReporteAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTituloNombre;
        private System.Windows.Forms.Label lblTituloID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdInterno;
    }
}