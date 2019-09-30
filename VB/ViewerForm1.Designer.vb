Namespace DataCounterExample
	Partial Public Class ViewerForm1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.layoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.dashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
			Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.simpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
			Me.simpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.simpleLabelItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.simpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.dashboardViewer1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(974, 473, 650, 400)
			Me.layoutControl1.Root = Me.Root
			Me.layoutControl1.Size = New System.Drawing.Size(638, 448)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' dashboardViewer1
			' 
			Me.dashboardViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(160)))), (CInt((CByte(160)))), (CInt((CByte(160)))))
			Me.dashboardViewer1.Appearance.Options.UseBackColor = True
			Me.dashboardViewer1.AsyncMode = True
			Me.dashboardViewer1.DashboardSource = GetType(DataCounterExample.SampleDashboard)
			Me.dashboardViewer1.Location = New System.Drawing.Point(12, 29)
			Me.dashboardViewer1.Name = "dashboardViewer1"
			Me.dashboardViewer1.Size = New System.Drawing.Size(614, 407)
			Me.dashboardViewer1.TabIndex = 5
			' 
			' Root
			' 
			Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.Root.GroupBordersVisible = False
			Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.simpleLabelItem2, Me.simpleLabelItem1})
			Me.Root.Name = "Root"
			Me.Root.Size = New System.Drawing.Size(638, 448)
			Me.Root.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.dashboardViewer1
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 17)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1
			Me.layoutControlItem2.Size = New System.Drawing.Size(618, 411)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextVisible = False
			' 
			' simpleLabelItem2
			' 
			Me.simpleLabelItem2.AllowHotTrack = False
			Me.simpleLabelItem2.Location = New System.Drawing.Point(309, 0)
			Me.simpleLabelItem2.Name = "simpleLabelItem2"
			Me.simpleLabelItem2.Size = New System.Drawing.Size(309, 17)
			Me.simpleLabelItem2.TextSize = New System.Drawing.Size(107, 13)
			' 
			' simpleLabelItem1
			' 
			Me.simpleLabelItem1.AllowHotTrack = False
			Me.simpleLabelItem1.Location = New System.Drawing.Point(0, 0)
			Me.simpleLabelItem1.Name = "simpleLabelItem1"
			Me.simpleLabelItem1.Size = New System.Drawing.Size(309, 17)
			Me.simpleLabelItem1.TextSize = New System.Drawing.Size(107, 13)
			' 
			' ViewerForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(638, 448)
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "ViewerForm1"
			Me.Text = "Dashboard Viewer"
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.simpleLabelItem2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.simpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private Root As DevExpress.XtraLayout.LayoutControlGroup
		Private dashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private simpleLabelItem2 As DevExpress.XtraLayout.SimpleLabelItem
		Private simpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
	End Class
End Namespace

