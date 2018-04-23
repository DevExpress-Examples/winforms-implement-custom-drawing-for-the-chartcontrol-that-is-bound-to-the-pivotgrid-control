namespace CustomDrawChartWithPivot
{
    partial class Form1
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.gSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gspDataSet = new CustomDrawChartWithPivot.gspDataSet();
            this.fieldID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRegion = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGSP = new DevExpress.XtraPivotGrid.PivotGridField();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.gSPTableAdapter = new CustomDrawChartWithPivot.gspDataSetTableAdapters.GSPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataSource = this.gSPBindingSource;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldID,
            this.fieldRegion,
            this.fieldYear,
            this.fieldGSP});
            this.pivotGridControl1.Location = new System.Drawing.Point(12, 359);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText;
            this.pivotGridControl1.OptionsChartDataSource.ProvideDataByColumns = false;
            this.pivotGridControl1.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl1.OptionsView.ShowRowGrandTotals = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(641, 230);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.FieldValueImageIndex += new DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(this.pivotGridControl1_FieldValueImageIndex);
            // 
            // gSPBindingSource
            // 
            this.gSPBindingSource.DataMember = "GSP";
            this.gSPBindingSource.DataSource = this.gspDataSet;
            // 
            // gspDataSet
            // 
            this.gspDataSet.DataSetName = "gspDataSet";
            this.gspDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldID
            // 
            this.fieldID.AreaIndex = 0;
            this.fieldID.Caption = "ID";
            this.fieldID.FieldName = "ID";
            this.fieldID.Name = "fieldID";
            // 
            // fieldRegion
            // 
            this.fieldRegion.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldRegion.AreaIndex = 0;
            this.fieldRegion.Caption = "Region";
            this.fieldRegion.FieldName = "Region";
            this.fieldRegion.Name = "fieldRegion";
            // 
            // fieldYear
            // 
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            this.fieldYear.FieldName = "Year";
            this.fieldYear.Name = "fieldYear";
            // 
            // fieldGSP
            // 
            this.fieldGSP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldGSP.AreaIndex = 0;
            this.fieldGSP.Caption = "GSP";
            this.fieldGSP.FieldName = "GSP";
            this.fieldGSP.Name = "fieldGSP";
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.DataAdapter = this.gSPTableAdapter;
            this.chartControl1.DataSource = this.pivotGridControl1;
            xyDiagram1.AxisX.Label.Staggered = true;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.MaxHorizontalPercentage = 30;
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Series";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments";
            pointSeriesLabel1.LineVisible = true;
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default;
            this.chartControl1.SeriesTemplate.Label = pointSeriesLabel1;
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl1.SeriesTemplate.View = lineSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(641, 329);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.CustomDrawSeries += new DevExpress.XtraCharts.CustomDrawSeriesEventHandler(this.chartControl1_CustomDrawSeries);
            // 
            // gSPTableAdapter
            // 
            this.gSPTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 601);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.pivotGridControl1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gspDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private CustomDrawChartWithPivot.gspDataSetTableAdapters.GSPTableAdapter gSPTableAdapter;
        private gspDataSet gspDataSet;
        private System.Windows.Forms.BindingSource gSPBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRegion;
        private DevExpress.XtraPivotGrid.PivotGridField fieldYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGSP;

    }
}

