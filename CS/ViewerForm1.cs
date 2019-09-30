using DevExpress.DashboardCommon;
using DevExpress.XtraEditors;
using System;
using System.Threading.Tasks;

namespace DataCounterExample
{
    public partial class ViewerForm1 : XtraForm {
        public ViewerForm1() {
            InitializeComponent();
            dashboardViewer1.Initialized += OnDashboardViewerInitialized;
            dashboardViewer1.MasterFilterSet += OnDashboardViewerMasterFilterSet;
            dashboardViewer1.MasterFilterCleared += OnDashboardViewerMasterFilterCleared;
        }

        async void OnDashboardViewerInitialized(object sender, EventArgs e) {
            simpleLabelItem1.Text = await GetLabelText("choroplethMapDashboardItem1", "Map");
            simpleLabelItem2.Text = await GetLabelText("gridDashboardItem1", "Grid");
        }

        async void OnDashboardViewerMasterFilterSet(object sender, MasterFilterSetEventArgs e) {
            simpleLabelItem2.Text = await GetLabelText("gridDashboardItem1", "Grid");
        }

        async void OnDashboardViewerMasterFilterCleared(object sender, MasterFilterClearedEventArgs e) {
            simpleLabelItem2.Text = await GetLabelText("gridDashboardItem1", "Grid");
        }

        async Task<string> GetLabelText(string itemName, string itemCaption) {
            var data = await dashboardViewer1.GetItemDataAsync(itemName);
            int count = data.GetAxisPoints(data.GetAxisNames()[0]).Count;
            return string.Format("{0}: {1}", itemCaption, count);
        }
    }
}