Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class EstNameRep
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
	Private TextBox As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label7 As DataDynamics.ActiveReports.Label = Nothing
	Private Label2 As DataDynamics.ActiveReports.Label = Nothing
	Private Label1 As DataDynamics.ActiveReports.Label = Nothing
	Private Label3 As DataDynamics.ActiveReports.Label = Nothing
	Private Picture As DataDynamics.ActiveReports.Picture = Nothing
	Private Label As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox7 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label8 As DataDynamics.ActiveReports.Label = Nothing
	Private Label9 As DataDynamics.ActiveReports.Label = Nothing
	Private lbemp_name As DataDynamics.ActiveReports.TextBox = Nothing
	Private lbnet As DataDynamics.ActiveReports.TextBox = Nothing
	Private lbpre As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox34 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox35 As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtnet As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtser As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtemp_name As DataDynamics.ActiveReports.TextBox = Nothing
	Private net As DataDynamics.ActiveReports.TextBox = Nothing
	Private tnet As DataDynamics.ActiveReports.TextBox = Nothing
	Private ttot As DataDynamics.ActiveReports.TextBox = Nothing
	Private tser As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox27 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox28 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label14 As DataDynamics.ActiveReports.Label = Nothing
	Private Label15 As DataDynamics.ActiveReports.Label = Nothing
	Private Label16 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox29 As DataDynamics.ActiveReports.TextBox = Nothing
	Private tmpnet As DataDynamics.ActiveReports.TextBox = Nothing
	Private gnet As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox20 As DataDynamics.ActiveReports.TextBox = Nothing
	Private gtot As DataDynamics.ActiveReports.TextBox = Nothing
	Private gser As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label4 As DataDynamics.ActiveReports.Label = Nothing
	Private Label13 As DataDynamics.ActiveReports.Label = Nothing
	Private Shape1 As DataDynamics.ActiveReports.Shape = Nothing
	Private Label5 As DataDynamics.ActiveReports.Label = Nothing
	Private Label6 As DataDynamics.ActiveReports.Label = Nothing
	Private Shape2 As DataDynamics.ActiveReports.Shape = Nothing
	Private Shape6 As DataDynamics.ActiveReports.Shape = Nothing
	Private TextBox22 As DataDynamics.ActiveReports.TextBox = Nothing
	Public Sub InitializeReport()
		Me.LoadLayout(Me.GetType, "carwin.EstNameRep.rpx")
		Me.ds = CType(Me.DataSource,DataDynamics.ActiveReports.DataSources.SqlDBDataSource)
		Me.ReportHeader = CType(Me.Sections("ReportHeader"),DataDynamics.ActiveReports.ReportHeader)
		Me.PageHeader = CType(Me.Sections("PageHeader"),DataDynamics.ActiveReports.PageHeader)
		Me.Detail = CType(Me.Sections("Detail"),DataDynamics.ActiveReports.Detail)
		Me.PageFooter = CType(Me.Sections("PageFooter"),DataDynamics.ActiveReports.PageFooter)
		Me.ReportFooter = CType(Me.Sections("ReportFooter"),DataDynamics.ActiveReports.ReportFooter)
		Me.TextBox = CType(Me.ReportHeader.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.Label7 = CType(Me.ReportHeader.Controls(1),DataDynamics.ActiveReports.Label)
		Me.Label2 = CType(Me.ReportHeader.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label1 = CType(Me.ReportHeader.Controls(3),DataDynamics.ActiveReports.Label)
		Me.Label3 = CType(Me.ReportHeader.Controls(4),DataDynamics.ActiveReports.Label)
		Me.Picture = CType(Me.ReportHeader.Controls(5),DataDynamics.ActiveReports.Picture)
		Me.Label = CType(Me.ReportHeader.Controls(6),DataDynamics.ActiveReports.Label)
		Me.TextBox7 = CType(Me.ReportHeader.Controls(7),DataDynamics.ActiveReports.TextBox)
		Me.Label8 = CType(Me.ReportHeader.Controls(8),DataDynamics.ActiveReports.Label)
		Me.Label9 = CType(Me.ReportHeader.Controls(9),DataDynamics.ActiveReports.Label)
		Me.lbemp_name = CType(Me.PageHeader.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.lbnet = CType(Me.PageHeader.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.lbpre = CType(Me.PageHeader.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.TextBox34 = CType(Me.PageHeader.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox35 = CType(Me.PageHeader.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.txtnet = CType(Me.PageHeader.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.txtser = CType(Me.Detail.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.txtemp_name = CType(Me.Detail.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.net = CType(Me.Detail.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.tnet = CType(Me.PageFooter.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.ttot = CType(Me.PageFooter.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.tser = CType(Me.PageFooter.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.TextBox27 = CType(Me.PageFooter.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox28 = CType(Me.PageFooter.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.Label14 = CType(Me.PageFooter.Controls(5),DataDynamics.ActiveReports.Label)
		Me.Label15 = CType(Me.PageFooter.Controls(6),DataDynamics.ActiveReports.Label)
		Me.Label16 = CType(Me.PageFooter.Controls(7),DataDynamics.ActiveReports.Label)
		Me.TextBox29 = CType(Me.PageFooter.Controls(8),DataDynamics.ActiveReports.TextBox)
		Me.tmpnet = CType(Me.PageFooter.Controls(9),DataDynamics.ActiveReports.TextBox)
		Me.gnet = CType(Me.ReportFooter.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox20 = CType(Me.ReportFooter.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.gtot = CType(Me.ReportFooter.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.gser = CType(Me.ReportFooter.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.Label4 = CType(Me.ReportFooter.Controls(4),DataDynamics.ActiveReports.Label)
		Me.Label13 = CType(Me.ReportFooter.Controls(5),DataDynamics.ActiveReports.Label)
		Me.Shape1 = CType(Me.ReportFooter.Controls(6),DataDynamics.ActiveReports.Shape)
		Me.Label5 = CType(Me.ReportFooter.Controls(7),DataDynamics.ActiveReports.Label)
		Me.Label6 = CType(Me.ReportFooter.Controls(8),DataDynamics.ActiveReports.Label)
		Me.Shape2 = CType(Me.ReportFooter.Controls(9),DataDynamics.ActiveReports.Shape)
		Me.Shape6 = CType(Me.ReportFooter.Controls(10),DataDynamics.ActiveReports.Shape)
		Me.TextBox22 = CType(Me.ReportFooter.Controls(11),DataDynamics.ActiveReports.TextBox)
	End Sub

#End Region

    Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
        TextBox.Text = datshake
        Label8.Text = clas_name
        Label9.Text = clas_name1
        count = 0

        y = 0.0
        y2 = 0.0
        ytot = 0.0

    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        txtser.Text = count + 1
        count = count + 1
        y = y + Me.Fields("est_ok_val").Value()

    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        If (Me.PageNumber() = 1) Then
            lbemp_name.Visible = True
            lbnet.Visible = True
            '---------
            lbpre.Visible = False
            txtnet.Visible = False
        Else
            '---------
            lbemp_name.Visible = False
            lbnet.Visible = False
            '---------
            lbpre.Visible = True
            txtnet.Visible = True
        End If
        txtnet.Value = txtnet.Value - tmpnet.Value
    End Sub

    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format
        Label13.Text = Horof(y)
        tser.Visible = False
        ttot.Visible = False
        tnet.Visible = False
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        TextBox29.Text = Date.Now
    End Sub
End Class
