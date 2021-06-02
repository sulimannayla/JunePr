Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class bdeel4
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
	Private Label1 As DataDynamics.ActiveReports.Label = Nothing
	Private Label2 As DataDynamics.ActiveReports.Label = Nothing
	Private Label As DataDynamics.ActiveReports.Label = Nothing
	Private Label9 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox1 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox2 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox3 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox5 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox6 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox26 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox30 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox32 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox33 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox35 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox14 As DataDynamics.ActiveReports.TextBox = Nothing
	Private hj As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox36 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox37 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox48 As DataDynamics.ActiveReports.TextBox = Nothing
	Private dartxt As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox31 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox8 As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtemp_name As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtmblg As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtdmga As DataDynamics.ActiveReports.TextBox = Nothing
	Private txttot As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtnet As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox9 As DataDynamics.ActiveReports.TextBox = Nothing
	Private txthj As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtdar As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox10 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox11 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox13 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox15 As DataDynamics.ActiveReports.TextBox = Nothing
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
	Private TextBox38 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox39 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox40 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox41 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox46 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox49 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox50 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox18 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox19 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox20 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox21 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox23 As DataDynamics.ActiveReports.TextBox = Nothing
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
	Private TextBox42 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox43 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox51 As DataDynamics.ActiveReports.TextBox = Nothing
	Public Sub InitializeReport()
		Me.LoadLayout(Me.GetType, "carwin.bdeel4.rpx")
		Me.ds = CType(Me.DataSource,DataDynamics.ActiveReports.DataSources.OleDBDataSource)
		Me.ReportHeader = CType(Me.Sections("ReportHeader"),DataDynamics.ActiveReports.ReportHeader)
		Me.PageHeader = CType(Me.Sections("PageHeader"),DataDynamics.ActiveReports.PageHeader)
		Me.Detail = CType(Me.Sections("Detail"),DataDynamics.ActiveReports.Detail)
		Me.PageFooter = CType(Me.Sections("PageFooter"),DataDynamics.ActiveReports.PageFooter)
		Me.ReportFooter = CType(Me.Sections("ReportFooter"),DataDynamics.ActiveReports.ReportFooter)
		Me.Label1 = CType(Me.ReportHeader.Controls(0),DataDynamics.ActiveReports.Label)
		Me.Label2 = CType(Me.ReportHeader.Controls(1),DataDynamics.ActiveReports.Label)
		Me.Label = CType(Me.ReportHeader.Controls(2),DataDynamics.ActiveReports.Label)
		Me.Label9 = CType(Me.ReportHeader.Controls(3),DataDynamics.ActiveReports.Label)
		Me.TextBox = CType(Me.PageHeader.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox1 = CType(Me.PageHeader.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.TextBox2 = CType(Me.PageHeader.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.TextBox3 = CType(Me.PageHeader.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox5 = CType(Me.PageHeader.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.TextBox6 = CType(Me.PageHeader.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.TextBox26 = CType(Me.PageHeader.Controls(6),DataDynamics.ActiveReports.TextBox)
		Me.TextBox30 = CType(Me.PageHeader.Controls(7),DataDynamics.ActiveReports.TextBox)
		Me.TextBox32 = CType(Me.PageHeader.Controls(8),DataDynamics.ActiveReports.TextBox)
		Me.TextBox33 = CType(Me.PageHeader.Controls(9),DataDynamics.ActiveReports.TextBox)
		Me.TextBox35 = CType(Me.PageHeader.Controls(10),DataDynamics.ActiveReports.TextBox)
		Me.TextBox14 = CType(Me.PageHeader.Controls(11),DataDynamics.ActiveReports.TextBox)
		Me.hj = CType(Me.PageHeader.Controls(12),DataDynamics.ActiveReports.TextBox)
		Me.TextBox36 = CType(Me.PageHeader.Controls(13),DataDynamics.ActiveReports.TextBox)
		Me.TextBox37 = CType(Me.PageHeader.Controls(14),DataDynamics.ActiveReports.TextBox)
		Me.TextBox48 = CType(Me.PageHeader.Controls(15),DataDynamics.ActiveReports.TextBox)
		Me.dartxt = CType(Me.PageHeader.Controls(16),DataDynamics.ActiveReports.TextBox)
		Me.TextBox31 = CType(Me.PageHeader.Controls(17),DataDynamics.ActiveReports.TextBox)
		Me.TextBox8 = CType(Me.Detail.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.txtemp_name = CType(Me.Detail.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.txtmblg = CType(Me.Detail.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.txtdmga = CType(Me.Detail.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.txttot = CType(Me.Detail.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.txtnet = CType(Me.Detail.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.TextBox9 = CType(Me.Detail.Controls(6),DataDynamics.ActiveReports.TextBox)
		Me.txthj = CType(Me.Detail.Controls(7),DataDynamics.ActiveReports.TextBox)
		Me.txtdar = CType(Me.Detail.Controls(8),DataDynamics.ActiveReports.TextBox)
		Me.TextBox10 = CType(Me.PageFooter.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox11 = CType(Me.PageFooter.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.TextBox13 = CType(Me.PageFooter.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.TextBox15 = CType(Me.PageFooter.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox16 = CType(Me.PageFooter.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.TextBox17 = CType(Me.PageFooter.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.TextBox27 = CType(Me.PageFooter.Controls(6),DataDynamics.ActiveReports.TextBox)
		Me.TextBox28 = CType(Me.PageFooter.Controls(7),DataDynamics.ActiveReports.TextBox)
		Me.Label14 = CType(Me.PageFooter.Controls(8),DataDynamics.ActiveReports.Label)
		Me.Label15 = CType(Me.PageFooter.Controls(9),DataDynamics.ActiveReports.Label)
		Me.Label16 = CType(Me.PageFooter.Controls(10),DataDynamics.ActiveReports.Label)
		Me.TextBox29 = CType(Me.PageFooter.Controls(11),DataDynamics.ActiveReports.TextBox)
		Me.TextBox4 = CType(Me.PageFooter.Controls(12),DataDynamics.ActiveReports.TextBox)
		Me.TextBox7 = CType(Me.PageFooter.Controls(13),DataDynamics.ActiveReports.TextBox)
		Me.TextBox12 = CType(Me.PageFooter.Controls(14),DataDynamics.ActiveReports.TextBox)
		Me.TextBox38 = CType(Me.PageFooter.Controls(15),DataDynamics.ActiveReports.TextBox)
		Me.TextBox39 = CType(Me.PageFooter.Controls(16),DataDynamics.ActiveReports.TextBox)
		Me.TextBox40 = CType(Me.PageFooter.Controls(17),DataDynamics.ActiveReports.TextBox)
		Me.TextBox41 = CType(Me.PageFooter.Controls(18),DataDynamics.ActiveReports.TextBox)
		Me.TextBox46 = CType(Me.PageFooter.Controls(19),DataDynamics.ActiveReports.TextBox)
		Me.TextBox49 = CType(Me.PageFooter.Controls(20),DataDynamics.ActiveReports.TextBox)
		Me.TextBox50 = CType(Me.PageFooter.Controls(21),DataDynamics.ActiveReports.TextBox)
		Me.TextBox18 = CType(Me.ReportFooter.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox19 = CType(Me.ReportFooter.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.TextBox20 = CType(Me.ReportFooter.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.TextBox21 = CType(Me.ReportFooter.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox23 = CType(Me.ReportFooter.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.TextBox24 = CType(Me.ReportFooter.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.TextBox25 = CType(Me.ReportFooter.Controls(6),DataDynamics.ActiveReports.TextBox)
		Me.Label4 = CType(Me.ReportFooter.Controls(7),DataDynamics.ActiveReports.Label)
		Me.Label13 = CType(Me.ReportFooter.Controls(8),DataDynamics.ActiveReports.Label)
		Me.Shape1 = CType(Me.ReportFooter.Controls(9),DataDynamics.ActiveReports.Shape)
		Me.Label5 = CType(Me.ReportFooter.Controls(10),DataDynamics.ActiveReports.Label)
		Me.Label6 = CType(Me.ReportFooter.Controls(11),DataDynamics.ActiveReports.Label)
		Me.Shape2 = CType(Me.ReportFooter.Controls(12),DataDynamics.ActiveReports.Shape)
		Me.Shape6 = CType(Me.ReportFooter.Controls(13),DataDynamics.ActiveReports.Shape)
		Me.TextBox22 = CType(Me.ReportFooter.Controls(14),DataDynamics.ActiveReports.TextBox)
		Me.TextBox42 = CType(Me.ReportFooter.Controls(15),DataDynamics.ActiveReports.TextBox)
		Me.TextBox43 = CType(Me.ReportFooter.Controls(16),DataDynamics.ActiveReports.TextBox)
		Me.TextBox51 = CType(Me.ReportFooter.Controls(17),DataDynamics.ActiveReports.TextBox)
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
        'y2 = y2 + Me.Fields("dmga").Value()
        'ytot = ytot + Me.Fields("dmga").Value()
        'y = y + txtnet.Value

    End Sub



    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        If (Me.PageNumber() = 1) Then
            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox14.Visible = True
            TextBox36.Visible = True
            '---------  
            TextBox33.Visible = False
            TextBox32.Visible = False
            TextBox31.Visible = False
            TextBox30.Visible = False
            TextBox26.Visible = False
            hj.Visible = False
            TextBox37.Visible = False
            dartxt.Visible = False
        Else
            '---------
            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = False
            TextBox14.Visible = False
            TextBox36.Visible = False
            '---------
            TextBox33.Visible = True
            TextBox32.Visible = True
            TextBox31.Visible = True
            TextBox30.Visible = True
            TextBox26.Visible = True
            hj.Visible = True
            TextBox37.Visible = True
            dartxt.Visible = True
        End If
        TextBox32.Value = TextBox32.Value - TextBox12.Value
        TextBox31.Value = TextBox31.Value - TextBox7.Value
        TextBox30.Value = TextBox30.Value - TextBox4.Value
        hj.Value = hj.Value - TextBox41.Value
        dartxt.Value = dartxt.Value - TextBox50.Value
        TextBox37.Value = TextBox37.Value - TextBox39.Value
    End Sub

    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format
        'TextBox21.Text = ytot
        Label13.Text = Horof(y)
        TextBox16.Visible = False
        TextBox17.Visible = False
        TextBox15.Visible = False
        TextBox13.Visible = False
        TextBox11.Visible = False
        TextBox10.Visible = False
        TextBox40.Visible = False
        TextBox38.Visible = False
        'TextBox45.Visible = False
        TextBox49.Visible = False
        'Label7.Text = Horof(y)
        'MsgBox(Val(TextBox19.Text))
        'TextBox19.SummaryFunc = SummaryFunc.Sum
        'TextBox19.SummaryType = SummaryType.GrandTotal
        'MsgBox(TextBox19.Text)
        'TextBox2.Text = Date.Now
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        TextBox29.Text = Date.Now

        'TextBox13.Text = y2
        'y2 = 0.0

    End Sub
End Class
