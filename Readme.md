<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574873/13.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1268)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to implement custom drawing for a ChartControl that is bound to the PivotGrid control


<p>This example demonstrates how to show color description for the pivot grid rows and color graph line according to the selected cells. To accomplish this task, it's only required to handle the <a href="http://help.devexpress.com/#XtraCharts/DevExpressXtraChartsChartControl_CustomDrawSeriestopic"><u>ChartControl.CustomDrawSeries</u></a> event and change the drawing parameters for a chart's series in the desired way and use pivotGridControl1.ValueImages to set images that are displayed within field values.</p>

<br/>


