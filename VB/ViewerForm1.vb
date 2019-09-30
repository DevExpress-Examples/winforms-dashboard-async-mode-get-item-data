Imports DevExpress.DashboardCommon
Imports DevExpress.XtraEditors
Imports System
Imports System.Threading.Tasks

Namespace DataCounterExample
	Partial Public Class ViewerForm1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			AddHandler dashboardViewer1.Initialized, AddressOf OnDashboardViewerInitialized
			AddHandler dashboardViewer1.MasterFilterSet, AddressOf OnDashboardViewerMasterFilterSet
			AddHandler dashboardViewer1.MasterFilterCleared, AddressOf OnDashboardViewerMasterFilterCleared
		End Sub

		Private Async Sub OnDashboardViewerInitialized(ByVal sender As Object, ByVal e As EventArgs)
			simpleLabelItem1.Text = Await GetLabelText("choroplethMapDashboardItem1", "Map")
			simpleLabelItem2.Text = Await GetLabelText("gridDashboardItem1", "Grid")
		End Sub

		Private Async Sub OnDashboardViewerMasterFilterSet(ByVal sender As Object, ByVal e As MasterFilterSetEventArgs)
			simpleLabelItem2.Text = Await GetLabelText("gridDashboardItem1", "Grid")
		End Sub

		Private Async Sub OnDashboardViewerMasterFilterCleared(ByVal sender As Object, ByVal e As MasterFilterClearedEventArgs)
			simpleLabelItem2.Text = Await GetLabelText("gridDashboardItem1", "Grid")
		End Sub

		Private Async Function GetLabelText(ByVal itemName As String, ByVal itemCaption As String) As Task(Of String)
			Dim data = Await dashboardViewer1.GetItemDataAsync(itemName)
			Dim count As Integer = data.GetAxisPoints(data.GetAxisNames()(0)).Count
			Return String.Format("{0}: {1}", itemCaption, count)
		End Function
	End Class
End Namespace