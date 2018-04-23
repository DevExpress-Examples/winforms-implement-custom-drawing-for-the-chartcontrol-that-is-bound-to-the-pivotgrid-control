Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPivotGrid
' ...


Namespace CustomDrawChartWithPivot
	Partial Public Class Form1
		Inherits Form

		#Region "Constants & Variables"
		Private Shared imgList As New ImageList()

        Private Shared seriesNames() As String = { _
            "FAR WEST", "GREAT LAKES", "MIDEAST", "NEW ENGLAND", _
            "PLAINS", "ROCKY MOUNTAIN", "SOUTHEAST", "SOUTHWEST"}

        Private Shared seriesColors() As Color = { _
            Color.Aqua, Color.Aquamarine, Color.BlueViolet, Color.Crimson, _
            Color.DarkOrange, Color.DarkSeaGreen, Color.Green, Color.Indigo}
		#End Region

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.gSPTableAdapter.Fill(Me.gspDataSet.GSP)

			imgList.Images.AddRange(CreateImages(seriesColors))
			pivotGridControl1.ValueImages = imgList
		End Sub

        Private Sub pivotGridControl1_FieldValueImageIndex(ByVal sender As Object, ByVal e As _
        PivotFieldImageIndexEventArgs) Handles pivotGridControl1.FieldValueImageIndex
            If e.Field Is fieldRegion AndAlso e.ValueType = PivotGridValueType.Value Then
                e.ImageIndex = GetIndexByName(e.Value)
            End If
        End Sub

        Private Sub chartControl1_CustomDrawSeries(ByVal sender As Object, ByVal e As _
        CustomDrawSeriesEventArgs) Handles chartControl1.CustomDrawSeries
            UpdateDrawOptions(CType(e.SeriesDrawOptions, LineDrawOptions), e.Series.Name)
            UpdateDrawOptions(CType(e.LegendDrawOptions, LineDrawOptions), e.Series.Name)
        End Sub

		Private Sub UpdateDrawOptions(ByVal options As LineDrawOptions, ByVal seriesName As String)
			options.Color = seriesColors(GetIndexByName(seriesName))
			options.LineStyle.DashStyle = DashStyle.Solid
			options.Marker.FillStyle.FillMode = FillMode.Solid
		End Sub


		#Region "Auxilliary Methods"
		Private Function CreateImages(ByVal colors() As Color) As Image()
			Dim images(colors.Length - 1) As Image
			For i As Integer = 0 To colors.Length - 1
				images(i) = CreateImage(16, 16, colors(i))
			Next i

			Return images
		End Function

        Public Function CreateImage(ByVal width As Integer, ByVal height As Integer, _
        ByVal imageColor As Color) As Image
            Dim image As New Bitmap(width, height)

            Using gfx As Graphics = Graphics.FromImage(image)
                Using brush As New SolidBrush(imageColor)
                    gfx.FillRectangle(brush, 0, 0, width, height)
                End Using
            End Using

            Return CType(image, Image)
        End Function

		Private Shared Function GetIndexByName(ByVal name As Object) As Integer
			If name IsNot Nothing Then
				For i As Integer = 0 To seriesNames.Length - 1
					If seriesNames(i) = name.ToString() Then
						Return i
					End If
				Next i
			End If

			Return -1
		End Function
		#End Region

	End Class
End Namespace