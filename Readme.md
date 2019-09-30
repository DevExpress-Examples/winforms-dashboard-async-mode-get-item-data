<!-- default file list -->
*Files to look at*:
* [Form1.cs](./CS/ViewerForm1.cs) (VB: [Form1.vb](./VB/ViewerForm1.vb))
<!-- default file list end -->

# How to Get Dashboard Item Data Asynchronously

This example demonstrates how to get the data displayed in the specified dashboard item asynchronously when the dashboard is loaded.

The labels at the top display the data row count for the specified dashboard item.

![screenshot](/images/screenshot.png)

API in this example:

* [DashboardViewer.AsyncMode](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.AsyncMode). Switch to asynchronous mode. The property is set in the **InitializeComponent** method.
* [DashboardViewer.GetItemDataAsync](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.GetItemDataAsync(System.String)) method. Gets data displayed within a dashboard item, asynchronously.
* [DashboardViewer.Initialized](https:/docs.devexpress.devx/Dashboard/DevExpress.DashboardWin.DashboardViewer.Initialized) event. Handle this event to perform asynchronous tasks on the first load.


See also:

* [Asynchronous Mode](https://docs.devexpress.com/Dashboard/401305)