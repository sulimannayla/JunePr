Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class bdalServ
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
	Private Label As DataDynamics.ActiveReports.Label = Nothing
	Private Label3 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox1 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox2 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox5 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox6 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox26 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox33 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox34 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox35 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox30 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox8 As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtemp_name As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtmblg As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtnet As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox9 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox10 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox11 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox16 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox17 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox27 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox28 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label14 As DataDynamics.ActiveReports.Label = Nothing
	Private Label15 As DataDynamics.ActiveReports.Label = Nothing
	Private Label16 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox29 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox4 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox7 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox12 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox42 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox43 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox18 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox19 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox20 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox24 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox25 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label4 As DataDynamics.ActiveReports.Label = Nothing
	Private Label13 As DataDynamics.ActiveReports.Label = Nothing
	Private Shape1 As DataDynamics.ActiveReports.Shape = Nothing
	Private Label5 As DataDynamics.ActiveReports.Label = Nothing
	Private Label6 As DataDynamics.ActiveReports.Label = Nothing
	Private Shape2 As DataDynamics.ActiveReports.Shape = Nothing
	Private Shape6 As DataDynamics.ActiveReports.Shape = Nothing
	Private TextBox22 As DataDynamics.ActiveReports.TextBox = Nothing
	Public Sub InitializeReport()
		Me.LoadLayout(Me.GetType, "carwin.bdalServ.rpx")
		Me.ds = CType(Me.DataSource,DataDynamics.ActiveReports.DataSources.SqlDBDataSource)
		Me.ReportHeader = CType(Me.Sections("ReportHeader"),DataDynamics.ActiveReports.ReportHeader)
		Me.PageHeader = CType(Me.Sections("PageHeader"),DataDynamics.ActiveReports.PageHeader)
		Me.Detail = CType(Me.Sections("Detail"),DataDynamics.ActiveReports.Detail)
		Me.PageFooter = CType(Me.Sections("PageFooter"),DataDynamics.ActiveReports.PageFooter)
		Me.ReportFooter = CType(Me.Sections("ReportFooter"),DataDynamics.ActiveReports.ReportFooter)
		Me.Label1 = CType(Me.ReportHeader.Controls(0),DataDynamics.ActiveReports.Label)
		Me.Label2 = CType(Me.ReportHeader.Controls(1),DataDynamics.ActiveReports.Label)
		Me.Label = CType(Me.ReportHeader.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label3 = CType(Me.ReportHeader.Controls(3),DataDynamics.ActiveReports.Label)
		Me.TextBox = CType(Me.PageHeader.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox1 = CType(Me.PageHeader.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.TextBox2 = CType(Me.PageHeader.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.TextBox5 = CType(Me.PageHeader.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox6 = CType(Me.PageHeader.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.TextBox26 = CType(Me.PageHeader.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.TextBox33 = CType(Me.PageHeader.Controls(6),DataDynamics.ActiveReports.TextBox)
		Me.TextBox34 = CType(Me.PageHeader.Controls(7),DataDynamics.ActiveReports.TextBox)
		Me.TextBox35 = CType(Me.PageHeader.Controls(8),DataDynamics.ActiveReports.TextBox)
		Me.TextBox30 = CType(Me.PageHeader.Controls(9),DataDynamics.ActiveReports.TextBox)
		Me.TextBox8 = CType(Me.Detail.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.txtemp_name = CType(Me.Detail.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.txtmblg = CType(Me.Detail.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.txtnet = CType(Me.Detail.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox9 = CType(Me.Detail.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.TextBox10 = CType(Me.PageFooter.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox11 = CType(Me.PageFooter.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.TextBox16 = CType(Me.PageFooter.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.TextBox17 = CType(Me.PageFooter.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox27 = CType(Me.PageFooter.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.TextBox28 = CType(Me.PageFooter.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.Label14 = CType(Me.PageFooter.Controls(6),DataDynamics.ActiveReports.Label)
		Me.Label15 = CType(Me.PageFooter.Controls(7),DataDynamics.ActiveReports.Label)
		Me.Label16 = CType(Me.PageFooter.Controls(8),DataDynamics.ActiveReports.Label)
		Me.TextBox29 = CType(Me.PageFooter.Controls(9),DataDynamics.ActiveReports.TextBox)
		Me.TextBox4 = CType(Me.PageFooter.Controls(10),DataDynamics.ActiveReports.TextBox)
		Me.TextBox7 = CType(Me.PageFooter.Controls(11),DataDynamics.ActiveReports.TextBox)
		Me.TextBox12 = CType(Me.PageFooter.Controls(12),DataDynamics.ActiveReports.TextBox)
		Me.TextBox42 = CType(Me.PageFooter.Controls(13),DataDynamics.ActiveReports.TextBox)
		Me.TextBox43 = CType(Me.PageFooter.Controls(14),DataDynamics.ActiveReports.TextBox)
		Me.TextBox18 = CType(Me.ReportFooter.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox19 = CType(Me.ReportFooter.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.TextBox20 = CType(Me.ReportFooter.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.TextBox24 = CType(Me.ReportFooter.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox25 = CType(Me.ReportFooter.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.Label4 = CType(Me.ReportFooter.Controls(5),DataDynamics.ActiveReports.Label)
		Me.Label13 = CType(Me.ReportFooter.Controls(6),DataDynamics.ActiveReports.Label)
		Me.Shape1 = CType(Me.ReportFooter.Controls(7),DataDynamics.ActiveReports.Shape)
		Me.Label5 = CType(Me.ReportFooter.Controls(8),DataDynamics.ActiveReports.Label)
		Me.Label6 = CType(Me.ReportFooter.Controls(9),DataDynamics.ActiveReports.Label)
		Me.Shape2 = CType(Me.ReportFooter.Controls(10),DataDynamics.ActiveReports.Shape)
		Me.Shape6 = CType(Me.ReportFooter.Controls(11),DataDynamics.ActiveReports.Shape)
		Me.TextBox22 = CType(Me.ReportFooter.Controls(12),DataDynamics.ActiveReports.TextBox)
	End Sub

	#End Region

    Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
        Label.Text = classname
        count = 0

        y = 0.0
        y2 = 0.0
        ytot = 0.0

    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        TextBox8.Text = count + 1
        count = count + 1
        y = y + Me.Fields("net").Value()

    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        If (Me.PageNumber() = 1) Then
            TextBox.Visible = True
            TextBox1.Visible = True
            'TextBox2.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            '---------
            TextBox34.Visible = False
            TextBox33.Visible = False
            'TextBox32.Visible = False
            TextBox30.Visible = False
            TextBox26.Visible = False
        Else
            '---------
            TextBox.Visible = False
            TextBox1.Visible = False
            'TextBox2.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = False
            '---------
            TextBox34.Visible = True
            TextBox33.Visible = True
            'TextBox32.Visible = True
            TextBox30.Visible = True
            TextBox26.Visible = True
        End If
        'TextBox32.Value = TextBox32.Value - TextBox12.Value
        TextBox30.Value = TextBox30.Value - TextBox4.Value
    End Sub

    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format
        Label13.Text = Horof(y)
        TextBox16.Visible = False
        TextBox17.Visible = False
        'TextBox15.Visible = False
        TextBox11.Visible = False
        TextBox10.Visible = False
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        TextBox29.Text = Date.Now
    End Sub
End Class
