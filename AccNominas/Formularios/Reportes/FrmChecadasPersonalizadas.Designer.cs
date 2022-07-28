namespace AccNominas.Formularios.Reportes
{
    partial class FrmChecadasPersonalizadas
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.reporteSelectivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_interno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchecada1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchecada2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchecada3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchecada4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.frmChecadasPersonalizadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSelectivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmChecadasPersonalizadasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.reporteSelectivoBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 78);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(770, 442);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // reporteSelectivoBindingSource
            // 
            this.reporteSelectivoBindingSource.DataSource = typeof(AccAsistencia.ReporteSelectivo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_interno,
            this.colnombre,
            this.colchecada1,
            this.colchecada2,
            this.colchecada3,
            this.colchecada4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colid_interno
            // 
            this.colid_interno.FieldName = "id_interno";
            this.colid_interno.Name = "colid_interno";
            this.colid_interno.Visible = true;
            this.colid_interno.VisibleIndex = 0;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            // 
            // colchecada1
            // 
            this.colchecada1.DisplayFormat.FormatString = "hh:mm:ss tt";
            this.colchecada1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colchecada1.FieldName = "checada1";
            this.colchecada1.Name = "colchecada1";
            this.colchecada1.Visible = true;
            this.colchecada1.VisibleIndex = 2;
            // 
            // colchecada2
            // 
            this.colchecada2.DisplayFormat.FormatString = "hh:mm:ss tt";
            this.colchecada2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colchecada2.FieldName = "checada2";
            this.colchecada2.Name = "colchecada2";
            this.colchecada2.Visible = true;
            this.colchecada2.VisibleIndex = 3;
            // 
            // colchecada3
            // 
            this.colchecada3.DisplayFormat.FormatString = "hh:mm:ss tt";
            this.colchecada3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colchecada3.FieldName = "checada3";
            this.colchecada3.Name = "colchecada3";
            this.colchecada3.Visible = true;
            this.colchecada3.VisibleIndex = 4;
            // 
            // colchecada4
            // 
            this.colchecada4.DisplayFormat.FormatString = "hh:mm:ss tt";
            this.colchecada4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colchecada4.FieldName = "checada4";
            this.colchecada4.Name = "colchecada4";
            this.colchecada4.Visible = true;
            this.colchecada4.VisibleIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(794, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reporte de Checadas Selectivas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione el día:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.CustomFormat = "ddd dd/MMM/yyyy";
            this.dtpFecha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(15, 49);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(707, 50);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 24);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmChecadasPersonalizadasBindingSource
            // 
            this.frmChecadasPersonalizadasBindingSource.DataSource = typeof(AccNominas.Formularios.Reportes.FrmChecadasPersonalizadas);
            // 
            // FrmChecadasPersonalizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 532);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmChecadasPersonalizadas";
            this.Text = "Checadas Selectivas";
            this.Load += new System.EventHandler(this.FrmChecadasPersonalizadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteSelectivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmChecadasPersonalizadasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.BindingSource frmChecadasPersonalizadasBindingSource;
        private System.Windows.Forms.BindingSource reporteSelectivoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_interno;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colchecada1;
        private DevExpress.XtraGrid.Columns.GridColumn colchecada2;
        private DevExpress.XtraGrid.Columns.GridColumn colchecada3;
        private DevExpress.XtraGrid.Columns.GridColumn colchecada4;
    }
}