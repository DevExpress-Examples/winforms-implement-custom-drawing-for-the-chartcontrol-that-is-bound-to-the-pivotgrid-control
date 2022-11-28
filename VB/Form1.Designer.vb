Namespace CustomDrawChartWithPivot

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim pointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.gSPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gspDataSet = New CustomDrawChartWithPivot.gspDataSet()
            Me.fieldID = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldRegion = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldGSP = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.gSPTableAdapter = New CustomDrawChartWithPivot.gspDataSetTableAdapters.GSPTableAdapter()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gSPBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gspDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl1.DataSource = Me.gSPBindingSource
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldID, Me.fieldRegion, Me.fieldYear, Me.fieldGSP})
            Me.pivotGridControl1.Location = New System.Drawing.Point(12, 359)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
            Me.pivotGridControl1.OptionsChartDataSource.ProvideDataByColumns = False
            Me.pivotGridControl1.OptionsView.ShowColumnTotals = False
            Me.pivotGridControl1.OptionsView.ShowRowGrandTotals = False
            Me.pivotGridControl1.Size = New System.Drawing.Size(641, 230)
            Me.pivotGridControl1.TabIndex = 0
            AddHandler Me.pivotGridControl1.FieldValueImageIndex, New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(AddressOf Me.pivotGridControl1_FieldValueImageIndex)
            ' 
            ' gSPBindingSource
            ' 
            Me.gSPBindingSource.DataMember = "GSP"
            Me.gSPBindingSource.DataSource = Me.gspDataSet
            ' 
            ' gspDataSet
            ' 
            Me.gspDataSet.DataSetName = "gspDataSet"
            Me.gspDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' fieldID
            ' 
            Me.fieldID.AreaIndex = 0
            Me.fieldID.Caption = "ID"
            Me.fieldID.FieldName = "ID"
            Me.fieldID.Name = "fieldID"
            ' 
            ' fieldRegion
            ' 
            Me.fieldRegion.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldRegion.AreaIndex = 0
            Me.fieldRegion.Caption = "Region"
            Me.fieldRegion.FieldName = "Region"
            Me.fieldRegion.Name = "fieldRegion"
            ' 
            ' fieldYear
            ' 
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Year"
            Me.fieldYear.FieldName = "Year"
            Me.fieldYear.Name = "fieldYear"
            ' 
            ' fieldGSP
            ' 
            Me.fieldGSP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldGSP.AreaIndex = 0
            Me.fieldGSP.Caption = "GSP"
            Me.fieldGSP.FieldName = "GSP"
            Me.fieldGSP.Name = "fieldGSP"
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.DataAdapter = Me.gSPTableAdapter
            Me.chartControl1.DataSource = Me.pivotGridControl1
            xyDiagram1.AxisX.Label.Staggered = True
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
            xyDiagram1.AxisX.Range.SideMarginsEnabled = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
            xyDiagram1.AxisY.Range.SideMarginsEnabled = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Legend.MaxHorizontalPercentage = 30
            Me.chartControl1.Location = New System.Drawing.Point(12, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.SeriesDataMember = "Series"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
            pointSeriesLabel1.LineVisible = True
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
            Me.chartControl1.SeriesTemplate.Label = pointSeriesLabel1
            Me.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.chartControl1.SeriesTemplate.View = lineSeriesView1
            Me.chartControl1.Size = New System.Drawing.Size(641, 329)
            Me.chartControl1.TabIndex = 1
            AddHandler Me.chartControl1.CustomDrawSeries, New DevExpress.XtraCharts.CustomDrawSeriesEventHandler(AddressOf Me.chartControl1_CustomDrawSeries)
            ' 
            ' gSPTableAdapter
            ' 
            Me.gSPTableAdapter.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(675, 601)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.DoubleBuffered = True
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gSPBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gspDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private gSPTableAdapter As CustomDrawChartWithPivot.gspDataSetTableAdapters.GSPTableAdapter

        Private gspDataSet As CustomDrawChartWithPivot.gspDataSet

        Private gSPBindingSource As System.Windows.Forms.BindingSource

        Private fieldID As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldRegion As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldGSP As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace
