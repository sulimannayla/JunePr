Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class ActiveReport2
Inherits ActiveReport
	Public Sub New()
	MyBase.New()
		InitializeReport()
	End Sub
	#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
	Public ds As DataDynamics.ActiveReports.DataSources.SqlDBDataSource = Nothing
	Private Label1 As DataDynamics.ActiveReports.Label = Nothing
	Private Label2 As DataDynamics.ActiveReports.Label = Nothing
	Private Label3 As DataDynamics.ActiveReports.Label = Nothing
	Private Picture As DataDynamics.ActiveReports.Picture = Nothing
	Private Shape1 As DataDynamics.ActiveReports.Shape = Nothing
	Private Label9 As DataDynamics.ActiveReports.Label = Nothing
	Private txttotel As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtquntety As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtpart_name As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label7 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox3 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Line2 As DataDynamics.ActiveReports.Line = Nothing
	Private Line1 As DataDynamics.ActiveReports.Line = Nothing
	Public Sub InitializeReport()
		Me.LoadLayout(Me.GetType, "carwin.ActiveReport2.rpx")
		Me.ds = CType(Me.DataSource,DataDynamics.ActiveReports.DataSources.SqlDBDataSource)
		Me.ReportHeader = CType(Me.Sections("ReportHeader"),DataDynamics.ActiveReports.ReportHeader)
		Me.PageHeader = CType(Me.Sections("PageHeader"),DataDynamics.ActiveReports.PageHeader)
		Me.GroupHeader2 = CType(Me.Sections("GroupHeader2"),DataDynamics.ActiveReports.GroupHeader)
		Me.Detail = CType(Me.Sections("Detail"),DataDynamics.ActiveReports.Detail)
		Me.GroupFooter2 = CType(Me.Sections("GroupFooter2"),DataDynamics.ActiveReports.GroupFooter)
		Me.PageFooter = CType(Me.Sections("PageFooter"),DataDynamics.ActiveReports.PageFooter)
		Me.ReportFooter = CType(Me.Sections("ReportFooter"),DataDynamics.ActiveReports.ReportFooter)
		Me.Label1 = CType(Me.ReportHeader.Controls(0),DataDynamics.ActiveReports.Label)
		Me.Label2 = CType(Me.ReportHeader.Controls(1),DataDynamics.ActiveReports.Label)
		Me.Label3 = CType(Me.ReportHeader.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Picture = CType(Me.ReportHeader.Controls(3),DataDynamics.ActiveReports.Picture)
		Me.Shape1 = CType(Me.ReportHeader.Controls(4),DataDynamics.ActiveReports.Shape)
		Me.Label9 = CType(Me.ReportHeader.Controls(5),DataDynamics.ActiveReports.Label)
		Me.txttotel = CType(Me.Detail.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.txtquntety = CType(Me.Detail.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.txtpart_name = CType(Me.Detail.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.Label7 = CType(Me.GroupFooter2.Controls(0),DataDynamics.ActiveReports.Label)
		Me.TextBox3 = CType(Me.GroupFooter2.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.Line2 = CType(Me.GroupFooter2.Controls(2),DataDynamics.ActiveReports.Line)
		Me.Line1 = CType(Me.GroupFooter2.Controls(3),DataDynamics.ActiveReports.Line)
	End Sub

	#End Region

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format

    End Sub

    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format

    End Sub
End Class
