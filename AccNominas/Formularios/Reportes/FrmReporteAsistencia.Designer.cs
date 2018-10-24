namespace AccNominas.Formularios.Reportes
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition5 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteAsistencia));
            this.colsEntradaTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsSalidaTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridReporte = new DevExpress.XtraGrid.GridControl();
            this.asistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvReporte = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsInicioDescanso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsTerminoDescanso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntradaTurnoOficial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalidaTurnoOficial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJustificacionET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJustificacionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJustificacionTD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJustificacionST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntradaTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInicioDescanso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalidaTurno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTerminoDescanso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJustificacionTodoElDia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTituloNombre = new System.Windows.Forms.Label();
            this.lblTituloID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdInterno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.bkgCalcular = new System.ComponentModel.BackgroundWorker();
            this.lblMinEx = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sscReport = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // colsEntradaTurno
            // 
            this.colsEntradaTurno.AppearanceCell.Options.UseTextOptions = true;
            this.colsEntradaTurno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsEntradaTurno.AppearanceHeader.Options.UseTextOptions = true;
            this.colsEntradaTurno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsEntradaTurno.Caption = "Entrada de Truno";
            this.colsEntradaTurno.FieldName = "sEntradaTurno";
            this.colsEntradaTurno.Name = "colsEntradaTurno";
            this.colsEntradaTurno.Visible = true;
            this.colsEntradaTurno.VisibleIndex = 2;
            this.colsEntradaTurno.Width = 103;
            // 
            // colsSalidaTurno
            // 
            this.colsSalidaTurno.AppearanceCell.Options.UseTextOptions = true;
            this.colsSalidaTurno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsSalidaTurno.AppearanceHeader.Options.UseTextOptions = true;
            this.colsSalidaTurno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsSalidaTurno.Caption = "Salida de Turno";
            this.colsSalidaTurno.FieldName = "sSalidaTurno";
            this.colsSalidaTurno.Name = "colsSalidaTurno";
            this.colsSalidaTurno.Visible = true;
            this.colsSalidaTurno.VisibleIndex = 5;
            this.colsSalidaTurno.Width = 93;
            // 
            // gridReporte
            // 
            this.gridReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReporte.DataSource = this.asistenciaBindingSource;
            this.gridReporte.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridReporte.Location = new System.Drawing.Point(18, 116);
            this.gridReporte.MainView = this.gvReporte;
            this.gridReporte.Margin = new System.Windows.Forms.Padding(4);
            this.gridReporte.Name = "gridReporte";
            this.gridReporte.Size = new System.Drawing.Size(803, 437);
            this.gridReporte.TabIndex = 0;
            this.gridReporte.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReporte});
            this.gridReporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridReporte_KeyPress);
            // 
            // asistenciaBindingSource
            // 
            this.asistenciaBindingSource.DataSource = typeof(AccAsistencia.Asistencia);
            // 
            // gvReporte
            // 
            this.gvReporte.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvReporte.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvReporte.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvReporte.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvReporte.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvReporte.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvReporte.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvReporte.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvReporte.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvReporte.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gvReporte.Appearance.Empty.Options.UseBackColor = true;
            this.gvReporte.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvReporte.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvReporte.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.EvenRow.Options.UseBorderColor = true;
            this.gvReporte.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvReporte.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvReporte.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvReporte.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvReporte.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvReporte.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvReporte.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvReporte.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvReporte.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvReporte.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(133)))), ((int)(((byte)(195)))));
            this.gvReporte.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvReporte.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvReporte.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvReporte.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(109)))), ((int)(((byte)(189)))));
            this.gvReporte.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(139)))), ((int)(((byte)(206)))));
            this.gvReporte.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gvReporte.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvReporte.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvReporte.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvReporte.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvReporte.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvReporte.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvReporte.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvReporte.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvReporte.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvReporte.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvReporte.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvReporte.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvReporte.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvReporte.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvReporte.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvReporte.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvReporte.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(216)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvReporte.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.gvReporte.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvReporte.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvReporte.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvReporte.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvReporte.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gvReporte.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvReporte.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.gvReporte.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvReporte.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvReporte.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvReporte.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvReporte.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.OddRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.OddRow.Options.UseBorderColor = true;
            this.gvReporte.Appearance.OddRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvReporte.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gvReporte.Appearance.Preview.Options.UseFont = true;
            this.gvReporte.Appearance.Preview.Options.UseForeColor = true;
            this.gvReporte.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvReporte.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.Row.Options.UseBackColor = true;
            this.gvReporte.Appearance.Row.Options.UseForeColor = true;
            this.gvReporte.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.gvReporte.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvReporte.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvReporte.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.gvReporte.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(184)))), ((int)(((byte)(251)))));
            this.gvReporte.Appearance.VertLine.Options.UseBackColor = true;
            this.gvReporte.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha1,
            this.colFecha,
            this.colsEntradaTurno,
            this.colsInicioDescanso,
            this.colsTerminoDescanso,
            this.colsSalidaTurno,
            this.colEntradaTurnoOficial,
            this.colSalidaTurnoOficial,
            this.colJustificacionET,
            this.colJustificacionID,
            this.colJustificacionTD,
            this.colJustificacionST,
            this.colEntradaTurno,
            this.colInicioDescanso,
            this.colSalidaTurno,
            this.colTerminoDescanso,
            this.colJustificacionTodoElDia});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.Column = this.colsEntradaTurno;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "GetTimeOfDay([EntradaTurno]) > GetTimeOfDay([EntradaTurnoOficial]) And [Justifica" +
    "cionTodoElDia] != True";
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.Column = this.colsSalidaTurno;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition2.Expression = "GetTimeOfDay([SalidaTurno]) < GetTimeOfDay([SalidaTurnoOficial]) And [Justificaci" +
    "onTodoElDia] != True";
            styleFormatCondition3.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            styleFormatCondition3.Appearance.Options.UseForeColor = true;
            styleFormatCondition3.Column = this.colsEntradaTurno;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition3.Expression = "[JustificacionET] == True";
            styleFormatCondition4.Appearance.ForeColor = System.Drawing.Color.DarkBlue;
            styleFormatCondition4.Appearance.Options.UseForeColor = true;
            styleFormatCondition4.Column = this.colsSalidaTurno;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition4.Expression = "[JustificacionST] == True";
            styleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition5.Appearance.Options.UseForeColor = true;
            styleFormatCondition5.Column = this.colsEntradaTurno;
            styleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition5.Expression = "[sEntradaTurno] == \'Sin Registro\'";
            this.gvReporte.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3,
            styleFormatCondition4,
            styleFormatCondition5});
            this.gvReporte.GridControl = this.gridReporte;
            this.gvReporte.Name = "gvReporte";
            this.gvReporte.OptionsBehavior.Editable = false;
            this.gvReporte.OptionsBehavior.ReadOnly = true;
            this.gvReporte.OptionsCustomization.AllowColumnMoving = false;
            this.gvReporte.OptionsCustomization.AllowGroup = false;
            this.gvReporte.OptionsView.EnableAppearanceEvenRow = true;
            this.gvReporte.OptionsView.EnableAppearanceOddRow = true;
            this.gvReporte.OptionsView.ShowGroupPanel = false;
            // 
            // colFecha1
            // 
            this.colFecha1.Caption = "Dia";
            this.colFecha1.DisplayFormat.FormatString = "dddd";
            this.colFecha1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFecha1.FieldName = "Fecha";
            this.colFecha1.Name = "colFecha1";
            this.colFecha1.Visible = true;
            this.colFecha1.VisibleIndex = 0;
            // 
            // colFecha
            // 
            this.colFecha.AppearanceCell.Options.UseTextOptions = true;
            this.colFecha.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFecha.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colFecha.AppearanceHeader.Options.UseTextOptions = true;
            this.colFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 1;
            // 
            // colsInicioDescanso
            // 
            this.colsInicioDescanso.AppearanceCell.Options.UseTextOptions = true;
            this.colsInicioDescanso.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsInicioDescanso.AppearanceHeader.Options.UseTextOptions = true;
            this.colsInicioDescanso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsInicioDescanso.Caption = "Inicio Descanso";
            this.colsInicioDescanso.FieldName = "sInicioDescanso";
            this.colsInicioDescanso.Name = "colsInicioDescanso";
            this.colsInicioDescanso.Visible = true;
            this.colsInicioDescanso.VisibleIndex = 3;
            this.colsInicioDescanso.Width = 93;
            // 
            // colsTerminoDescanso
            // 
            this.colsTerminoDescanso.AppearanceCell.Options.UseTextOptions = true;
            this.colsTerminoDescanso.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsTerminoDescanso.AppearanceHeader.Options.UseTextOptions = true;
            this.colsTerminoDescanso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colsTerminoDescanso.Caption = "Termino Descanso";
            this.colsTerminoDescanso.FieldName = "sTerminoDescanso";
            this.colsTerminoDescanso.Name = "colsTerminoDescanso";
            this.colsTerminoDescanso.Visible = true;
            this.colsTerminoDescanso.VisibleIndex = 4;
            this.colsTerminoDescanso.Width = 106;
            // 
            // colEntradaTurnoOficial
            // 
            this.colEntradaTurnoOficial.FieldName = "EntradaTurnoOficial";
            this.colEntradaTurnoOficial.Name = "colEntradaTurnoOficial";
            this.colEntradaTurnoOficial.Width = 110;
            // 
            // colSalidaTurnoOficial
            // 
            this.colSalidaTurnoOficial.FieldName = "SalidaTurnoOficial";
            this.colSalidaTurnoOficial.Name = "colSalidaTurnoOficial";
            this.colSalidaTurnoOficial.Width = 100;
            // 
            // colJustificacionET
            // 
            this.colJustificacionET.FieldName = "JustificacionET";
            this.colJustificacionET.Name = "colJustificacionET";
            this.colJustificacionET.Width = 82;
            // 
            // colJustificacionID
            // 
            this.colJustificacionID.FieldName = "JustificacionID";
            this.colJustificacionID.Name = "colJustificacionID";
            this.colJustificacionID.Width = 81;
            // 
            // colJustificacionTD
            // 
            this.colJustificacionTD.FieldName = "JustificacionTD";
            this.colJustificacionTD.Name = "colJustificacionTD";
            this.colJustificacionTD.Width = 83;
            // 
            // colJustificacionST
            // 
            this.colJustificacionST.FieldName = "JustificacionST";
            this.colJustificacionST.Name = "colJustificacionST";
            this.colJustificacionST.Width = 82;
            // 
            // colEntradaTurno
            // 
            this.colEntradaTurno.Caption = "EntradaTurnoDT";
            this.colEntradaTurno.FieldName = "EntradaTurno";
            this.colEntradaTurno.Name = "colEntradaTurno";
            this.colEntradaTurno.Width = 88;
            // 
            // colInicioDescanso
            // 
            this.colInicioDescanso.Caption = "InicioDescansoDT";
            this.colInicioDescanso.FieldName = "InicioDescanso";
            this.colInicioDescanso.Name = "colInicioDescanso";
            this.colInicioDescanso.Width = 93;
            // 
            // colSalidaTurno
            // 
            this.colSalidaTurno.Caption = "SalidaTurnoDT";
            this.colSalidaTurno.FieldName = "SalidaTurno";
            this.colSalidaTurno.Name = "colSalidaTurno";
            this.colSalidaTurno.Width = 78;
            // 
            // colTerminoDescanso
            // 
            this.colTerminoDescanso.Caption = "TerminoDescansoDT";
            this.colTerminoDescanso.FieldName = "TerminoDescanso";
            this.colTerminoDescanso.Name = "colTerminoDescanso";
            this.colTerminoDescanso.Width = 106;
            // 
            // colJustificacionTodoElDia
            // 
            this.colJustificacionTodoElDia.FieldName = "JustificacionTodoElDia";
            this.colJustificacionTodoElDia.Name = "colJustificacionTodoElDia";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(834, 40);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Reporte de Asistencias";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTituloNombre
            // 
            this.lblTituloNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloNombre.AutoSize = true;
            this.lblTituloNombre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNombre.Location = new System.Drawing.Point(15, 94);
            this.lblTituloNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloNombre.Name = "lblTituloNombre";
            this.lblTituloNombre.Size = new System.Drawing.Size(151, 18);
            this.lblTituloNombre.TabIndex = 2;
            this.lblTituloNombre.Text = "Nombre del Empleado:";
            // 
            // lblTituloID
            // 
            this.lblTituloID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloID.AutoSize = true;
            this.lblTituloID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloID.Location = new System.Drawing.Point(92, 76);
            this.lblTituloID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloID.Name = "lblTituloID";
            this.lblTituloID.Size = new System.Drawing.Size(74, 18);
            this.lblTituloID.TabIndex = 3;
            this.lblTituloID.Text = "ID Interno:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(170, 94);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(440, 18);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Guillermo Alvarado Montañez";
            // 
            // lblIdInterno
            // 
            this.lblIdInterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIdInterno.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdInterno.Location = new System.Drawing.Point(170, 76);
            this.lblIdInterno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdInterno.Name = "lblIdInterno";
            this.lblIdInterno.Size = new System.Drawing.Size(652, 18);
            this.lblIdInterno.TabIndex = 5;
            this.lblIdInterno.Text = "514";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Presione \"C\" para consultar dia.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Presione \"J\" para justificar.";
            // 
            // dtpInicial
            // 
            this.dtpInicial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpInicial.CustomFormat = "dd/MMMM/yyyy";
            this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicial.Location = new System.Drawing.Point(177, 47);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(201, 26);
            this.dtpInicial.TabIndex = 10;
            // 
            // dtpFinal
            // 
            this.dtpFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFinal.CustomFormat = "dd/MMMM/yyyy";
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinal.Location = new System.Drawing.Point(409, 47);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(201, 26);
            this.dtpFinal.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Location = new System.Drawing.Point(384, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "al";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Location = new System.Drawing.Point(142, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Del";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(716, 560);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(106, 40);
            this.btnExportar.TabIndex = 14;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalcular.Location = new System.Drawing.Point(617, 47);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 26);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // imgLoading
            // 
            this.imgLoading.Image = global::AccNominas.Properties.Resources.cargando;
            this.imgLoading.Location = new System.Drawing.Point(333, 259);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(169, 94);
            this.imgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLoading.TabIndex = 16;
            this.imgLoading.TabStop = false;
            this.imgLoading.Visible = false;
            // 
            // bkgCalcular
            // 
            this.bkgCalcular.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgCalcular_DoWork);
            this.bkgCalcular.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkgCalcular_RunWorkerCompleted);
            // 
            // lblMinEx
            // 
            this.lblMinEx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMinEx.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinEx.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMinEx.Location = new System.Drawing.Point(752, 94);
            this.lblMinEx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinEx.Name = "lblMinEx";
            this.lblMinEx.Size = new System.Drawing.Size(66, 18);
            this.lblMinEx.TabIndex = 18;
            this.lblMinEx.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(614, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Minutos Excedidos:";
            // 
            // sscReport
            // 
            this.sscReport.Location = new System.Drawing.Point(589, 560);
            this.sscReport.Name = "sscReport";
            this.sscReport.Size = new System.Drawing.Size(103, 72);
            this.sscReport.TabIndex = 19;
            this.sscReport.Visible = false;
            // 
            // FrmReporteAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 612);
            this.Controls.Add(this.sscReport);
            this.Controls.Add(this.lblMinEx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.imgLoading);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIdInterno);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTituloID);
            this.Controls.Add(this.lblTituloNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gridReporte);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(850, 650);
            this.Name = "FrmReporteAsistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Asistencia";
            this.Load += new System.EventHandler(this.FrmReporteAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridReporte;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReporte;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTituloNombre;
        private System.Windows.Forms.Label lblTituloID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdInterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.BindingSource asistenciaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colEntradaTurnoOficial;
        private DevExpress.XtraGrid.Columns.GridColumn colSalidaTurnoOficial;
        private DevExpress.XtraGrid.Columns.GridColumn colJustificacionET;
        private DevExpress.XtraGrid.Columns.GridColumn colJustificacionID;
        private DevExpress.XtraGrid.Columns.GridColumn colJustificacionTD;
        private DevExpress.XtraGrid.Columns.GridColumn colJustificacionST;
        private System.Windows.Forms.Button btnCalcular;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha1;
        private DevExpress.XtraGrid.Columns.GridColumn colsEntradaTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colsInicioDescanso;
        private DevExpress.XtraGrid.Columns.GridColumn colsTerminoDescanso;
        private DevExpress.XtraGrid.Columns.GridColumn colsSalidaTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colEntradaTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colInicioDescanso;
        private DevExpress.XtraGrid.Columns.GridColumn colSalidaTurno;
        private DevExpress.XtraGrid.Columns.GridColumn colTerminoDescanso;
        private DevExpress.XtraGrid.Columns.GridColumn colJustificacionTodoElDia;
        private System.Windows.Forms.PictureBox imgLoading;
        private System.ComponentModel.BackgroundWorker bkgCalcular;
        private System.Windows.Forms.Label lblMinEx;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl sscReport;
    }
}