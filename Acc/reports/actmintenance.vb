Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class etmad_mon
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
	Private txtdate_ As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label8 As DataDynamics.ActiveReports.Label = Nothing
	Private Label9 As DataDynamics.ActiveReports.Label = Nothing
	Private Label1 As DataDynamics.ActiveReports.Label = Nothing
	Private Label2 As DataDynamics.ActiveReports.Label = Nothing
	Private Picture As DataDynamics.ActiveReports.Picture = Nothing
	Private Shape5 As DataDynamics.ActiveReports.Shape = Nothing
	Private Line5 As DataDynamics.ActiveReports.Line = Nothing
	Private TextBox As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label As DataDynamics.ActiveReports.Label = Nothing
	Private Label4 As DataDynamics.ActiveReports.Label = Nothing
	Private Label5 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox1 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox2 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox3 As DataDynamics.ActiveReports.TextBox = Nothing
	Public Sub InitializeReport()
		Me.LoadLayout(Me.GetType, "carwin.actmintenance.rpx")
		Me.ds = CType(Me.DataSource,DataDynamics.ActiveReports.DataSources.SqlDBDataSource)
		Me.ReportHeader = CType(Me.Sections("ReportHeader"),DataDynamics.ActiveReports.ReportHeader)
		Me.PageHeader = CType(Me.Sections("PageHeader"),DataDynamics.ActiveReports.PageHeader)
		Me.GroupHeader1 = CType(Me.Sections("GroupHeader1"),DataDynamics.ActiveReports.GroupHeader)
		Me.Detail = CType(Me.Sections("Detail"),DataDynamics.ActiveReports.Detail)
		Me.GroupFooter1 = CType(Me.Sections("GroupFooter1"),DataDynamics.ActiveReports.GroupFooter)
		Me.PageFooter = CType(Me.Sections("PageFooter"),DataDynamics.ActiveReports.PageFooter)
		Me.ReportFooter = CType(Me.Sections("ReportFooter"),DataDynamics.ActiveReports.ReportFooter)
		Me.txtdate_ = CType(Me.ReportHeader.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.Label8 = CType(Me.ReportHeader.Controls(1),DataDynamics.ActiveReports.Label)
		Me.Label9 = CType(Me.ReportHeader.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label1 = CType(Me.ReportHeader.Controls(3),DataDynamics.ActiveReports.Label)
		Me.Label2 = CType(Me.ReportHeader.Controls(4),DataDynamics.ActiveReports.Label)
		Me.Picture = CType(Me.ReportHeader.Controls(5),DataDynamics.ActiveReports.Picture)
		Me.Shape5 = CType(Me.ReportHeader.Controls(6),DataDynamics.ActiveReports.Shape)
		Me.Line5 = CType(Me.ReportHeader.Controls(7),DataDynamics.ActiveReports.Line)
		Me.TextBox = CType(Me.ReportHeader.Controls(8),DataDynamics.ActiveReports.TextBox)
		Me.Label = CType(Me.PageHeader.Controls(0),DataDynamics.ActiveReports.Label)
		Me.Label4 = CType(Me.PageHeader.Controls(1),DataDynamics.ActiveReports.Label)
		Me.Label5 = CType(Me.PageHeader.Controls(2),DataDynamics.ActiveReports.Label)
		Me.TextBox1 = CType(Me.Detail.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox2 = CType(Me.Detail.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.TextBox3 = CType(Me.Detail.Controls(2),DataDynamics.ActiveReports.TextBox)
	End Sub

#End Region

    Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
        TextBox.Text = classname

        txtdate_.Text = Date.Now
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
       
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        txtdate_.Text = Date.Now.Date
    End Sub
End Class
