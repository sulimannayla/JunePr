Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class repcardatareco
Inherits ActiveReport
	Public Sub New()
	MyBase.New()
		InitializeReport()
	End Sub
	#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
	Public ds As DataDynamics.ActiveReports.DataSources.SqlDBDataSource = Nothing
	Private Label As DataDynamics.ActiveReports.Label = Nothing
	Private Label1 As DataDynamics.ActiveReports.Label = Nothing
	Private Label2 As DataDynamics.ActiveReports.Label = Nothing
	Private Label3 As DataDynamics.ActiveReports.Label = Nothing
	Private Picture As DataDynamics.ActiveReports.Picture = Nothing
	Private Label15 As DataDynamics.ActiveReports.Label = Nothing
	Private txtcar_no As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtmodel As DataDynamics.ActiveReports.TextBox = Nothing
	Private txttype_no As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtno_type As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtshase_no As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtmachine_no As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtcar_owner As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtinsurance_date As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtinsurance_no As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtdriver As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label4 As DataDynamics.ActiveReports.Label = Nothing
	Private Label5 As DataDynamics.ActiveReports.Label = Nothing
	Private Label6 As DataDynamics.ActiveReports.Label = Nothing
	Private Label7 As DataDynamics.ActiveReports.Label = Nothing
	Private Label8 As DataDynamics.ActiveReports.Label = Nothing
	Private Label9 As DataDynamics.ActiveReports.Label = Nothing
	Private Label10 As DataDynamics.ActiveReports.Label = Nothing
	Private Label11 As DataDynamics.ActiveReports.Label = Nothing
	Private Label12 As DataDynamics.ActiveReports.Label = Nothing
	Private Label13 As DataDynamics.ActiveReports.Label = Nothing
	Private Label14 As DataDynamics.ActiveReports.Label = Nothing
	Private txtsite_name As DataDynamics.ActiveReports.TextBox = Nothing
	Public Sub InitializeReport()
		Me.LoadLayout(Me.GetType, "carwin.repcardatareco.rpx")
		Me.ds = CType(Me.DataSource,DataDynamics.ActiveReports.DataSources.SqlDBDataSource)
		Me.ReportHeader = CType(Me.Sections("ReportHeader"),DataDynamics.ActiveReports.ReportHeader)
		Me.PageHeader = CType(Me.Sections("PageHeader"),DataDynamics.ActiveReports.PageHeader)
		Me.GroupHeader1 = CType(Me.Sections("GroupHeader1"),DataDynamics.ActiveReports.GroupHeader)
		Me.Detail = CType(Me.Sections("Detail"),DataDynamics.ActiveReports.Detail)
		Me.GroupFooter1 = CType(Me.Sections("GroupFooter1"),DataDynamics.ActiveReports.GroupFooter)
		Me.PageFooter = CType(Me.Sections("PageFooter"),DataDynamics.ActiveReports.PageFooter)
		Me.ReportFooter = CType(Me.Sections("ReportFooter"),DataDynamics.ActiveReports.ReportFooter)
		Me.Label = CType(Me.ReportHeader.Controls(0),DataDynamics.ActiveReports.Label)
		Me.Label1 = CType(Me.ReportHeader.Controls(1),DataDynamics.ActiveReports.Label)
		Me.Label2 = CType(Me.ReportHeader.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label3 = CType(Me.ReportHeader.Controls(3),DataDynamics.ActiveReports.Label)
		Me.Picture = CType(Me.ReportHeader.Controls(4),DataDynamics.ActiveReports.Picture)
		Me.Label15 = CType(Me.ReportHeader.Controls(5),DataDynamics.ActiveReports.Label)
		Me.txtcar_no = CType(Me.Detail.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.txtmodel = CType(Me.Detail.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.txttype_no = CType(Me.Detail.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.txtno_type = CType(Me.Detail.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.txtshase_no = CType(Me.Detail.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.txtmachine_no = CType(Me.Detail.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.txtcar_owner = CType(Me.Detail.Controls(6),DataDynamics.ActiveReports.TextBox)
		Me.txtinsurance_date = CType(Me.Detail.Controls(7),DataDynamics.ActiveReports.TextBox)
		Me.txtinsurance_no = CType(Me.Detail.Controls(8),DataDynamics.ActiveReports.TextBox)
		Me.txtdriver = CType(Me.Detail.Controls(9),DataDynamics.ActiveReports.TextBox)
		Me.Label4 = CType(Me.Detail.Controls(10),DataDynamics.ActiveReports.Label)
		Me.Label5 = CType(Me.Detail.Controls(11),DataDynamics.ActiveReports.Label)
		Me.Label6 = CType(Me.Detail.Controls(12),DataDynamics.ActiveReports.Label)
		Me.Label7 = CType(Me.Detail.Controls(13),DataDynamics.ActiveReports.Label)
		Me.Label8 = CType(Me.Detail.Controls(14),DataDynamics.ActiveReports.Label)
		Me.Label9 = CType(Me.Detail.Controls(15),DataDynamics.ActiveReports.Label)
		Me.Label10 = CType(Me.Detail.Controls(16),DataDynamics.ActiveReports.Label)
		Me.Label11 = CType(Me.Detail.Controls(17),DataDynamics.ActiveReports.Label)
		Me.Label12 = CType(Me.Detail.Controls(18),DataDynamics.ActiveReports.Label)
		Me.Label13 = CType(Me.Detail.Controls(19),DataDynamics.ActiveReports.Label)
		Me.Label14 = CType(Me.Detail.Controls(20),DataDynamics.ActiveReports.Label)
		Me.txtsite_name = CType(Me.Detail.Controls(21),DataDynamics.ActiveReports.TextBox)
	End Sub

	#End Region
End Class
