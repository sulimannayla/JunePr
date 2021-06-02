Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class ind
Inherits ActiveReport
	Public Sub New()
	MyBase.New()
		InitializeReport()
	End Sub
	#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
	Public ds As DataDynamics.ActiveReports.DataSources.SqlDBDataSource = Nothing
	Private Label1 As DataDynamics.ActiveReports.Label = Nothing
	Private Label2 As DataDynamics.ActiveReports.Label = Nothing
	Private Label As DataDynamics.ActiveReports.Label = Nothing
	Private Label3 As DataDynamics.ActiveReports.Label = Nothing
	Private Label7 As DataDynamics.ActiveReports.Label = Nothing
	Private Label8 As DataDynamics.ActiveReports.Label = Nothing
	Private Label4 As DataDynamics.ActiveReports.Label = Nothing
	Private Label5 As DataDynamics.ActiveReports.Label = Nothing
	Private txtemp_no As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtemp_name As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtbasic_sal As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox27 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox28 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label14 As DataDynamics.ActiveReports.Label = Nothing
	Private Label15 As DataDynamics.ActiveReports.Label = Nothing
	Private Label16 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox29 As DataDynamics.ActiveReports.TextBox = Nothing
	Public Sub InitializeReport()
		Me.LoadLayout(Me.GetType, "carwin.ind.rpx")
		Me.ds = CType(Me.DataSource,DataDynamics.ActiveReports.DataSources.SqlDBDataSource)
		Me.ReportHeader = CType(Me.Sections("ReportHeader"),DataDynamics.ActiveReports.ReportHeader)
		Me.PageHeader = CType(Me.Sections("PageHeader"),DataDynamics.ActiveReports.PageHeader)
		Me.GroupHeader1 = CType(Me.Sections("GroupHeader1"),DataDynamics.ActiveReports.GroupHeader)
		Me.GroupHeader2 = CType(Me.Sections("GroupHeader2"),DataDynamics.ActiveReports.GroupHeader)
		Me.Detail = CType(Me.Sections("Detail"),DataDynamics.ActiveReports.Detail)
		Me.GroupFooter2 = CType(Me.Sections("GroupFooter2"),DataDynamics.ActiveReports.GroupFooter)
		Me.GroupFooter1 = CType(Me.Sections("GroupFooter1"),DataDynamics.ActiveReports.GroupFooter)
		Me.PageFooter = CType(Me.Sections("PageFooter"),DataDynamics.ActiveReports.PageFooter)
		Me.ReportFooter = CType(Me.Sections("ReportFooter"),DataDynamics.ActiveReports.ReportFooter)
		Me.Label1 = CType(Me.ReportHeader.Controls(0),DataDynamics.ActiveReports.Label)
		Me.Label2 = CType(Me.ReportHeader.Controls(1),DataDynamics.ActiveReports.Label)
		Me.Label = CType(Me.ReportHeader.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label3 = CType(Me.ReportHeader.Controls(3),DataDynamics.ActiveReports.Label)
		Me.Label7 = CType(Me.PageHeader.Controls(0),DataDynamics.ActiveReports.Label)
		Me.Label8 = CType(Me.PageHeader.Controls(1),DataDynamics.ActiveReports.Label)
		Me.Label4 = CType(Me.PageHeader.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label5 = CType(Me.PageHeader.Controls(3),DataDynamics.ActiveReports.Label)
		Me.txtemp_no = CType(Me.Detail.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.txtemp_name = CType(Me.Detail.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.txtbasic_sal = CType(Me.Detail.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.TextBox = CType(Me.Detail.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox27 = CType(Me.PageFooter.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox28 = CType(Me.PageFooter.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.Label14 = CType(Me.PageFooter.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label15 = CType(Me.PageFooter.Controls(3),DataDynamics.ActiveReports.Label)
		Me.Label16 = CType(Me.PageFooter.Controls(4),DataDynamics.ActiveReports.Label)
		Me.TextBox29 = CType(Me.PageFooter.Controls(5),DataDynamics.ActiveReports.TextBox)
	End Sub

	#End Region

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format

    End Sub

    Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
        Label.Text = classname
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
       
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        TextBox29.Text = Date.Now
    End Sub
End Class
