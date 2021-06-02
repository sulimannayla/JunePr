Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class repestname
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
	Public ds As DataDynamics.ActiveReports.DataSources.OleDBDataSource = Nothing
	Private Picture As DataDynamics.ActiveReports.Picture = Nothing
	Private Label4 As DataDynamics.ActiveReports.Label = Nothing
	Private Label5 As DataDynamics.ActiveReports.Label = Nothing
	Private Label6 As DataDynamics.ActiveReports.Label = Nothing
	Private Label9 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox1 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox5 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox6 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox7 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label As DataDynamics.ActiveReports.Label = Nothing
	Private Label2 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox2 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox27 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox28 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label14 As DataDynamics.ActiveReports.Label = Nothing
	Private Label15 As DataDynamics.ActiveReports.Label = Nothing
	Private Label16 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox29 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label7 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox4 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label3 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox3 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label1 As DataDynamics.ActiveReports.Label = Nothing
	Private Label13 As DataDynamics.ActiveReports.Label = Nothing
	Private Shape1 As DataDynamics.ActiveReports.Shape = Nothing
	Public Sub InitializeReport()
		Me.LoadLayout(Me.GetType, "carwin.repestname.rpx")
		Me.ds = CType(Me.DataSource,DataDynamics.ActiveReports.DataSources.OleDBDataSource)
		Me.ReportHeader = CType(Me.Sections("ReportHeader"),DataDynamics.ActiveReports.ReportHeader)
		Me.PageHeader = CType(Me.Sections("PageHeader"),DataDynamics.ActiveReports.PageHeader)
		Me.Detail = CType(Me.Sections("Detail"),DataDynamics.ActiveReports.Detail)
		Me.PageFooter = CType(Me.Sections("PageFooter"),DataDynamics.ActiveReports.PageFooter)
		Me.ReportFooter = CType(Me.Sections("ReportFooter"),DataDynamics.ActiveReports.ReportFooter)
		Me.Picture = CType(Me.ReportHeader.Controls(0),DataDynamics.ActiveReports.Picture)
		Me.Label4 = CType(Me.ReportHeader.Controls(1),DataDynamics.ActiveReports.Label)
		Me.Label5 = CType(Me.ReportHeader.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label6 = CType(Me.ReportHeader.Controls(3),DataDynamics.ActiveReports.Label)
		Me.Label9 = CType(Me.ReportHeader.Controls(4),DataDynamics.ActiveReports.Label)
		Me.TextBox1 = CType(Me.ReportHeader.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.TextBox5 = CType(Me.ReportHeader.Controls(6),DataDynamics.ActiveReports.TextBox)
		Me.TextBox6 = CType(Me.ReportHeader.Controls(7),DataDynamics.ActiveReports.TextBox)
		Me.TextBox7 = CType(Me.ReportHeader.Controls(8),DataDynamics.ActiveReports.TextBox)
		Me.Label = CType(Me.PageHeader.Controls(0),DataDynamics.ActiveReports.Label)
		Me.Label2 = CType(Me.PageHeader.Controls(1),DataDynamics.ActiveReports.Label)
		Me.TextBox = CType(Me.Detail.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox2 = CType(Me.Detail.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.TextBox27 = CType(Me.PageFooter.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox28 = CType(Me.PageFooter.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.Label14 = CType(Me.PageFooter.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label15 = CType(Me.PageFooter.Controls(3),DataDynamics.ActiveReports.Label)
		Me.Label16 = CType(Me.PageFooter.Controls(4),DataDynamics.ActiveReports.Label)
		Me.TextBox29 = CType(Me.PageFooter.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.Label7 = CType(Me.PageFooter.Controls(6),DataDynamics.ActiveReports.Label)
		Me.TextBox4 = CType(Me.PageFooter.Controls(7),DataDynamics.ActiveReports.TextBox)
		Me.Label3 = CType(Me.ReportFooter.Controls(0),DataDynamics.ActiveReports.Label)
		Me.TextBox3 = CType(Me.ReportFooter.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.Label1 = CType(Me.ReportFooter.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label13 = CType(Me.ReportFooter.Controls(3),DataDynamics.ActiveReports.Label)
		Me.Shape1 = CType(Me.ReportFooter.Controls(4),DataDynamics.ActiveReports.Shape)
	End Sub

	#End Region

    Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
        TextBox7.Text = clas_name
        t1 = 0
        y = 0.0
        TextBox6.Text = EYER
        TextBox5.Text = "/" + month_est
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        t1 = TextBox2.Text + t1
        y = y + Me.Fields("est_ok_val").Value()
    End Sub

    'Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupFooter.Format

    'End Sub

    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format
        TextBox3.Text = t1
        Label13.Text = Horof(y)
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        TextBox29.Text = Date.Now
    End Sub
End Class
