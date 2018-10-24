namespace AccNominas.Formularios.Reportes
{
    partial class FrmConsultarChecadasTodosChecadores
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
            this.gridChecadas = new DevExpress.XtraGrid.GridControl();
            this.checadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvChecadas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid_interno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_hora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_hora1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coloConcepto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collugar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridChecadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChecadas)).BeginInit();
            this.SuspendLayout();
            // 
            // gridChecadas
            // 
            this.gridChecadas.DataSource = this.checadaBindingSource;
            this.gridChecadas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridChecadas.Location = new System.Drawing.Point(13, 39);
            this.gridChecadas.MainView = this.gvChecadas;
            this.gridChecadas.Margin = new System.Windows.Forms.Padding(4);
            this.gridChecadas.Name = "gridChecadas";
            this.gridChecadas.Size = new System.Drawing.Size(467, 333);
            this.gridChecadas.TabIndex = 5;
            this.gridChecadas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChecadas});
            // 
            // checadaBindingSource
            // 
            this.checadaBindingSource.DataSource = typeof(AccAsistencia.Checada);
            // 
            // gvChecadas
            // 
            this.gvChecadas.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvChecadas.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvChecadas.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvChecadas.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvChecadas.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvChecadas.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvChecadas.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvChecadas.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvChecadas.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvChecadas.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvChecadas.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvChecadas.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvChecadas.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvChecadas.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvChecadas.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvChecadas.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvChecadas.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvChecadas.Appearance.Empty.Options.UseBackColor = true;
            this.gvChecadas.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvChecadas.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvChecadas.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvChecadas.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvChecadas.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvChecadas.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvChecadas.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvChecadas.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvChecadas.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvChecadas.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvChecadas.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvChecadas.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvChecadas.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvChecadas.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvChecadas.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvChecadas.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvChecadas.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvChecadas.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvChecadas.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvChecadas.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvChecadas.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvChecadas.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvChecadas.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvChecadas.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvChecadas.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvChecadas.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvChecadas.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvChecadas.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvChecadas.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvChecadas.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvChecadas.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvChecadas.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvChecadas.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvChecadas.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvChecadas.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvChecadas.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvChecadas.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvChecadas.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvChecadas.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvChecadas.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvChecadas.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvChecadas.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvChecadas.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvChecadas.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvChecadas.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvChecadas.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvChecadas.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvChecadas.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvChecadas.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvChecadas.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvChecadas.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvChecadas.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvChecadas.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvChecadas.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvChecadas.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvChecadas.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvChecadas.Appearance.GroupRow.Options.UseFont = true;
            this.gvChecadas.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvChecadas.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvChecadas.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvChecadas.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvChecadas.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvChecadas.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvChecadas.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvChecadas.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvChecadas.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvChecadas.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvChecadas.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvChecadas.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvChecadas.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvChecadas.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvChecadas.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvChecadas.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvChecadas.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvChecadas.Appearance.OddRow.Options.UseBackColor = true;
            this.gvChecadas.Appearance.OddRow.Options.UseForeColor = true;
            this.gvChecadas.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvChecadas.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvChecadas.Appearance.Preview.Options.UseBackColor = true;
            this.gvChecadas.Appearance.Preview.Options.UseForeColor = true;
            this.gvChecadas.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvChecadas.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvChecadas.Appearance.Row.Options.UseBackColor = true;
            this.gvChecadas.Appearance.Row.Options.UseForeColor = true;
            this.gvChecadas.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvChecadas.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvChecadas.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvChecadas.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvChecadas.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvChecadas.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvChecadas.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvChecadas.Appearance.VertLine.Options.UseBackColor = true;
            this.gvChecadas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid_interno,
            this.colfecha_hora,
            this.colfecha_hora1,
            this.coloConcepto,
            this.collugar});
            this.gvChecadas.GridControl = this.gridChecadas;
            this.gvChecadas.GroupCount = 1;
            this.gvChecadas.Name = "gvChecadas";
            this.gvChecadas.OptionsBehavior.Editable = false;
            this.gvChecadas.OptionsBehavior.ReadOnly = true;
            this.gvChecadas.OptionsCustomization.AllowColumnMoving = false;
            this.gvChecadas.OptionsView.EnableAppearanceEvenRow = true;
            this.gvChecadas.OptionsView.EnableAppearanceOddRow = true;
            this.gvChecadas.OptionsView.ShowGroupPanel = false;
            this.gvChecadas.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colfecha_hora, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvChecadas.EndGrouping += new System.EventHandler(this.gridView1_EndGrouping);
            // 
            // colid_interno
            // 
            this.colid_interno.FieldName = "id_interno";
            this.colid_interno.Name = "colid_interno";
            // 
            // colfecha_hora
            // 
            this.colfecha_hora.Caption = "Fecha";
            this.colfecha_hora.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colfecha_hora.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_hora.FieldName = "fecha_hora";
            this.colfecha_hora.Name = "colfecha_hora";
            // 
            // colfecha_hora1
            // 
            this.colfecha_hora1.Caption = "Hora";
            this.colfecha_hora1.DisplayFormat.FormatString = "HH:mm";
            this.colfecha_hora1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colfecha_hora1.FieldName = "fecha_hora";
            this.colfecha_hora1.Name = "colfecha_hora1";
            this.colfecha_hora1.Visible = true;
            this.colfecha_hora1.VisibleIndex = 0;
            // 
            // coloConcepto
            // 
            this.coloConcepto.Caption = "Concepto";
            this.coloConcepto.FieldName = "oConcepto.descripcion";
            this.coloConcepto.Name = "coloConcepto";
            this.coloConcepto.Visible = true;
            this.coloConcepto.VisibleIndex = 1;
            // 
            // collugar
            // 
            this.collugar.Caption = "Lugar";
            this.collugar.FieldName = "lugar";
            this.collugar.Name = "collugar";
            this.collugar.Visible = true;
            this.collugar.VisibleIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(57, 9);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(76, 18);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "99/99/9999";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha:";
            // 
            // FrmConsultarChecadasTodosChecadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 385);
            this.Controls.Add(this.gridChecadas);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsultarChecadasTodosChecadores";
            this.Text = "Consultar fecha";
            this.Load += new System.EventHandler(this.FrmConsultarChecadasTodosChecadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridChecadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChecadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridChecadas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChecadas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource checadaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_interno;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_hora;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_hora1;
        private DevExpress.XtraGrid.Columns.GridColumn coloConcepto;
        private DevExpress.XtraGrid.Columns.GridColumn collugar;
    }
}