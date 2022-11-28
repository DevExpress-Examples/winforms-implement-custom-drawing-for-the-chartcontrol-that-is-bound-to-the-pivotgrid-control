Namespace WindowsFormsApplication8

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

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.gSPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gspDataSet = New WindowsFormsApplication8.gspDataSet()
            Me.fieldGSP = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldRegion = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldID = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.gSPTableAdapter = New WindowsFormsApplication8.gspDataSetTableAdapters.GSPTableAdapter()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gSPBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gspDataSet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.DataSource = Me.gSPBindingSource
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldGSP, Me.fieldYear, Me.fieldRegion, Me.fieldID})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 174)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(717, 251)
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
            ' fieldGSP
            ' 
            Me.fieldGSP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldGSP.AreaIndex = 0
            Me.fieldGSP.FieldName = "GSP"
            Me.fieldGSP.Name = "fieldGSP"
            ' 
            ' fieldYear
            ' 
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.FieldName = "Year"
            Me.fieldYear.Name = "fieldYear"
            ' 
            ' fieldRegion
            ' 
            Me.fieldRegion.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldRegion.AreaIndex = 0
            Me.fieldRegion.FieldName = "Region"
            Me.fieldRegion.Name = "fieldRegion"
            ' 
            ' fieldID
            ' 
            Me.fieldID.AreaIndex = 0
            Me.fieldID.FieldName = "ID"
            Me.fieldID.Name = "fieldID"
            ' 
            ' gSPTableAdapter
            ' 
            Me.gSPTableAdapter.ClearBeforeFill = True
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.DataSource = Me.pivotGridControl1
            xyDiagram1.AxisX.Title.Text = "Region"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Title.Text = "GSP"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.MaxHorizontalPercentage = 30R
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.SeriesDataMember = "Series"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
            Me.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            Me.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.chartControl1.Size = New System.Drawing.Size(717, 174)
            Me.chartControl1.TabIndex = 1
            AddHandler Me.chartControl1.CustomDrawSeries, New DevExpress.XtraCharts.CustomDrawSeriesEventHandler(AddressOf Me.chartControl1_CustomDrawSeries)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(717, 425)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gSPBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gspDataSet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private gspDataSet As WindowsFormsApplication8.gspDataSet

        Private gSPBindingSource As System.Windows.Forms.BindingSource

        Private gSPTableAdapter As WindowsFormsApplication8.gspDataSetTableAdapters.GSPTableAdapter

        Private fieldGSP As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldRegion As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldID As DevExpress.XtraPivotGrid.PivotGridField

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
