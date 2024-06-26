<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574873/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1268)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms - How to Implement Custom Drawing for the Chart Control that is Bound to the Pivot Grid Control

<p>This example demonstrates how to show color description for the pivot grid rows and color graph line according to the selected cells. To accomplish this task, it's only required to handle the <a href="http://help.devexpress.com/#XtraCharts/DevExpressXtraChartsChartControl_CustomDrawSeriestopic"><u>ChartControl.CustomDrawSeries</u></a> event and change the drawing parameters for a chart's series in the desired way and use pivotGridControl1.ValueImages to set images that are displayed within field values.</p>

<br/>

![chart](./image/chart.png)

## Files to Review

* [Form1.cs](./CS/WindowsFormsApplication8/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication8/Form1.vb))

## Documentation

[Integrate the Pivot Grid with the Chart Control](https://docs.devexpress.com/WindowsForms/8748/controls-and-libraries/pivot-grid/data-analysis/integration-with-the-chart-control?v=22.2)


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-implement-custom-drawing-for-the-chartcontrol-that-is-bound-to-the-pivotgrid-control&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-implement-custom-drawing-for-the-chartcontrol-that-is-bound-to-the-pivotgrid-control&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
