<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ViewerForm1.cs) (VB: [Form1.vb](./VB/ViewerForm1.vb))
<!-- default file list end -->

# Dashboard for WinForms - How to get dashboard item data asynchronously

This example demonstrates how to get the data displayed in the specified dashboard item asynchronously when the dashboard is loaded.

The labels at the top display the data row count for the specified dashboard item.

![screenshot](/images/screenshot.png)

API in this example:

* [DashboardViewer.AsyncMode](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.AsyncMode). Switches to the asynchronous mode. The property is set in the **InitializeComponent** method.
* [DashboardViewer.GetItemDataAsync](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.GetItemDataAsync(System.String)) method. Gets data displayed within a dashboard item, asynchronously.
* [DashboardViewer.Initialized](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.Initialized) event. Handle this event to perform asynchronous tasks on the first load.

## Documentation

* [Asynchronous Mode](https://docs.devexpress.com/Dashboard/401305)

## More Examples

- [Dashboard Viewer: How to Get FIlter Values and Set Master Filter Asynchronously](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-random-filter)
- [Dashboard Viewer: How to Invoke the Data Inspector Asynchronously When the Dashboard is Loaded](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-show-data-inspector)
- [Dashboard Viewer: How to Create a Slide Show with Asynchronous Maximize and Restore Methods](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-maximize-slide-show)
