# How to implement custom drawing for a ChartControl that is bound to the PivotGrid control


<p>This example demonstrates how to show color description for the pivot grid rows and color graph line according to the selected cells. To accomplish this task, it's only required to handle the <a href="http://help.devexpress.com/#XtraCharts/DevExpressXtraChartsChartControl_CustomDrawSeriestopic"><u>ChartControl.CustomDrawSeries</u></a> event and change the drawing parameters for a chart's series in the desired way and use pivotGridControl1.ValueImages to set images that are displayed within field values.</p>

<br/>


