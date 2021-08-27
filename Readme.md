<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/211878404/19.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828304)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ViewerForm1.cs) (VB: [Form1.vb](./VB/ViewerForm1.vb))
<!-- default file list end -->

# Dashboard for WinForms - How to get dashboard item data asynchronously

This example demonstrates how to get the data displayed in the dashboard item asynchronously when the dashboard is loaded.

The labels at the top display the data row count for the specified dashboard item.

![screenshot](/images/screenshot.png)

## API

* [DashboardViewer.AsyncMode](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.AsyncMode). Switches to the asynchronous mode. The property is set in the **InitializeComponent** method.
* [DashboardViewer.GetItemDataAsync](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.GetItemDataAsync(System.String)) method. Gets data displayed within a dashboard item, asynchronously.
* [DashboardViewer.Initialized](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.Initialized) event. Handle this event to perform asynchronous tasks on the first load.

## Documentation

* [Asynchronous Mode](https://docs.devexpress.com/Dashboard/401305)

## More Examples

- [Dashboard for WinForms - How to get filter values and set Master Filter asynchronously](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-random-filter)
- [Dashboard for WinForms - How to invoke the Data Inspector asynchronously when the Dashboard is loaded](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-show-data-inspector)
- [Dashboard for WinForms - How to create a slide show with asynchronous Maximize and Restore methods](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-maximize-slide-show)
