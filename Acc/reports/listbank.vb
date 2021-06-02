Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class listbank
Inherits ActiveReport
	Public Sub New()
	MyBase.New()
		InitializeReport()
	End Sub
	#Region "ActiveReports Designer generated code"
    Private WithEvents ReportHeader As DataDynamics.ActiveReports.ReportHeader = Nothing
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader = Nothing
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail = Nothing
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter = Nothing
    Private WithEvents ReportFooter As DataDynamics.ActiveReports.ReportFooter = Nothing
	Public ds As DataDynamics.ActiveReports.DataSources.SqlDBDataSource = Nothing
	Private Label1 As DataDynamics.ActiveReports.Label = Nothing
	Private Label2 As DataDynamics.ActiveReports.Label = Nothing
	Private Label9 As DataDynamics.ActiveReports.Label = Nothing
	Private Label8 As DataDynamics.ActiveReports.Label = Nothing
	Private Picture As DataDynamics.ActiveReports.Picture = Nothing
	Private TextBox As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox1 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label3 As DataDynamics.ActiveReports.Label = Nothing
	Private Label4 As DataDynamics.ActiveReports.Label = Nothing
	Private Label5 As DataDynamics.ActiveReports.Label = Nothing
	Private Label6 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox2 As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtemp_name As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtaccount_no As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtnote As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox3 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Line As DataDynamics.ActiveReports.Line = Nothing
	Private net As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label7 As DataDynamics.ActiveReports.Label = Nothing
	Private Label10 As DataDynamics.ActiveReports.Label = Nothing
	Private Label11 As DataDynamics.ActiveReports.Label = Nothing
	Public Sub InitializeReport()
		Me.LoadLayout(Me.GetType, "carwin.listbank.rpx")
		Me.ds = CType(Me.DataSource,DataDynamics.ActiveReports.DataSources.SqlDBDataSource)
		Me.ReportHeader = CType(Me.Sections("ReportHeader"),DataDynamics.ActiveReports.ReportHeader)
		Me.PageHeader = CType(Me.Sections("PageHeader"),DataDynamics.ActiveReports.PageHeader)
		Me.Detail = CType(Me.Sections("Detail"),DataDynamics.ActiveReports.Detail)
		Me.PageFooter = CType(Me.Sections("PageFooter"),DataDynamics.ActiveReports.PageFooter)
		Me.ReportFooter = CType(Me.Sections("ReportFooter"),DataDynamics.ActiveReports.ReportFooter)
		Me.Label1 = CType(Me.ReportHeader.Controls(0),DataDynamics.ActiveReports.Label)
		Me.Label2 = CType(Me.ReportHeader.Controls(1),DataDynamics.ActiveReports.Label)
		Me.Label9 = CType(Me.ReportHeader.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label8 = CType(Me.ReportHeader.Controls(3),DataDynamics.ActiveReports.Label)
		Me.Picture = CType(Me.ReportHeader.Controls(4),DataDynamics.ActiveReports.Picture)
		Me.TextBox = CType(Me.ReportHeader.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.Label = CType(Me.ReportHeader.Controls(6),DataDynamics.ActiveReports.Label)
		Me.TextBox1 = CType(Me.PageHeader.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.Label3 = CType(Me.PageHeader.Controls(1),DataDynamics.ActiveReports.Label)
		Me.Label4 = CType(Me.PageHeader.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label5 = CType(Me.PageHeader.Controls(3),DataDynamics.ActiveReports.Label)
		Me.Label6 = CType(Me.PageHeader.Controls(4),DataDynamics.ActiveReports.Label)
		Me.TextBox2 = CType(Me.Detail.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.txtemp_name = CType(Me.Detail.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.txtaccount_no = CType(Me.Detail.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.txtnote = CType(Me.Detail.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox3 = CType(Me.Detail.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.Line = CType(Me.Detail.Controls(5),DataDynamics.ActiveReports.Line)
		Me.net = CType(Me.PageFooter.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.Label7 = CType(Me.PageFooter.Controls(1),DataDynamics.ActiveReports.Label)
		Me.Label10 = CType(Me.PageFooter.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label11 = CType(Me.PageFooter.Controls(3),DataDynamics.ActiveReports.Label)
	End Sub

	#End Region

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        t1 = 1 + t1
        t2 = Val(net.Text) + t2
        TextBox2.Text = t1
    End Sub

    Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
        TextBox.Text = datshake
        Label8.Text = classname
        t1 = 0
        t2 = 0
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        'Label7.Text = Horof(Me.Fields("net").Value)
    End Sub
End Class
