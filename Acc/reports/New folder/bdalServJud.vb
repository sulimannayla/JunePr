Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class bdalServJud
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
	Private TextBox86 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox81 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox72 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox9 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox47 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox1 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox2 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox3 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox5 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox33 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox35 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox14 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox38 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox54 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox62 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox61 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox26 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox73 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox30 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox85 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox77 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox32 As DataDynamics.ActiveReports.TextBox = Nothing
	Private hj As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox31 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox52 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox6 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox42 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox63 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox64 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox71 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox10 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox48 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox8 As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtemp_name As DataDynamics.ActiveReports.TextBox = Nothing
	Private tot_sum As DataDynamics.ActiveReports.TextBox = Nothing
	Private tot_sum5 As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtnet As DataDynamics.ActiveReports.TextBox = Nothing
	Private tot_sum3 As DataDynamics.ActiveReports.TextBox = Nothing
	Private tot_sum4 As DataDynamics.ActiveReports.TextBox = Nothing
	Private tot_sum6 As DataDynamics.ActiveReports.TextBox = Nothing
	Private tot_sum7 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox55 As DataDynamics.ActiveReports.TextBox = Nothing
	Private tot_sum2 As DataDynamics.ActiveReports.TextBox = Nothing
	Private tot As DataDynamics.ActiveReports.TextBox = Nothing
	Private tot_sum8 As DataDynamics.ActiveReports.TextBox = Nothing
	Private est_jud As DataDynamics.ActiveReports.TextBox = Nothing
	Private est_jud1 As DataDynamics.ActiveReports.TextBox = Nothing
	Private alsafy As DataDynamics.ActiveReports.TextBox = Nothing
	Private tot_sum13 As DataDynamics.ActiveReports.TextBox = Nothing
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
	Private TextBox39 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox40 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox41 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox34 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox18 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox37 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox49 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox53 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox70 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox78 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox79 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox80 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox59 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox66 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox68 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox44 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox46 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox50 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox82 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox84 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox88 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox90 As DataDynamics.ActiveReports.TextBox = Nothing
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
	Private TextBox43 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox45 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox36 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox51 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox74 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox67 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox56 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox57 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox58 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox83 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox89 As DataDynamics.ActiveReports.TextBox = Nothing
	Public Sub InitializeReport()
		Me.LoadLayout(Me.GetType, "carwin.bdalServJud.rpx")
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
		Me.TextBox86 = CType(Me.PageHeader.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox81 = CType(Me.PageHeader.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.TextBox72 = CType(Me.PageHeader.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.TextBox9 = CType(Me.PageHeader.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox47 = CType(Me.PageHeader.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.TextBox = CType(Me.PageHeader.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.TextBox1 = CType(Me.PageHeader.Controls(6),DataDynamics.ActiveReports.TextBox)
		Me.TextBox2 = CType(Me.PageHeader.Controls(7),DataDynamics.ActiveReports.TextBox)
		Me.TextBox3 = CType(Me.PageHeader.Controls(8),DataDynamics.ActiveReports.TextBox)
		Me.TextBox5 = CType(Me.PageHeader.Controls(9),DataDynamics.ActiveReports.TextBox)
		Me.TextBox33 = CType(Me.PageHeader.Controls(10),DataDynamics.ActiveReports.TextBox)
		Me.TextBox35 = CType(Me.PageHeader.Controls(11),DataDynamics.ActiveReports.TextBox)
		Me.TextBox14 = CType(Me.PageHeader.Controls(12),DataDynamics.ActiveReports.TextBox)
		Me.TextBox38 = CType(Me.PageHeader.Controls(13),DataDynamics.ActiveReports.TextBox)
		Me.TextBox54 = CType(Me.PageHeader.Controls(14),DataDynamics.ActiveReports.TextBox)
		Me.TextBox62 = CType(Me.PageHeader.Controls(15),DataDynamics.ActiveReports.TextBox)
		Me.TextBox61 = CType(Me.PageHeader.Controls(16),DataDynamics.ActiveReports.TextBox)
		Me.TextBox26 = CType(Me.PageHeader.Controls(17),DataDynamics.ActiveReports.TextBox)
		Me.TextBox73 = CType(Me.PageHeader.Controls(18),DataDynamics.ActiveReports.TextBox)
		Me.TextBox30 = CType(Me.PageHeader.Controls(19),DataDynamics.ActiveReports.TextBox)
		Me.TextBox85 = CType(Me.PageHeader.Controls(20),DataDynamics.ActiveReports.TextBox)
		Me.TextBox77 = CType(Me.PageHeader.Controls(21),DataDynamics.ActiveReports.TextBox)
		Me.TextBox32 = CType(Me.PageHeader.Controls(22),DataDynamics.ActiveReports.TextBox)
		Me.hj = CType(Me.PageHeader.Controls(23),DataDynamics.ActiveReports.TextBox)
		Me.TextBox31 = CType(Me.PageHeader.Controls(24),DataDynamics.ActiveReports.TextBox)
		Me.TextBox52 = CType(Me.PageHeader.Controls(25),DataDynamics.ActiveReports.TextBox)
		Me.TextBox6 = CType(Me.PageHeader.Controls(26),DataDynamics.ActiveReports.TextBox)
		Me.TextBox42 = CType(Me.PageHeader.Controls(27),DataDynamics.ActiveReports.TextBox)
		Me.TextBox63 = CType(Me.PageHeader.Controls(28),DataDynamics.ActiveReports.TextBox)
		Me.TextBox64 = CType(Me.PageHeader.Controls(29),DataDynamics.ActiveReports.TextBox)
		Me.TextBox71 = CType(Me.PageHeader.Controls(30),DataDynamics.ActiveReports.TextBox)
		Me.TextBox10 = CType(Me.PageHeader.Controls(31),DataDynamics.ActiveReports.TextBox)
		Me.TextBox48 = CType(Me.PageHeader.Controls(32),DataDynamics.ActiveReports.TextBox)
		Me.TextBox8 = CType(Me.Detail.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.txtemp_name = CType(Me.Detail.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.tot_sum = CType(Me.Detail.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.tot_sum5 = CType(Me.Detail.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.txtnet = CType(Me.Detail.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.tot_sum3 = CType(Me.Detail.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.tot_sum4 = CType(Me.Detail.Controls(6),DataDynamics.ActiveReports.TextBox)
		Me.tot_sum6 = CType(Me.Detail.Controls(7),DataDynamics.ActiveReports.TextBox)
		Me.tot_sum7 = CType(Me.Detail.Controls(8),DataDynamics.ActiveReports.TextBox)
		Me.TextBox55 = CType(Me.Detail.Controls(9),DataDynamics.ActiveReports.TextBox)
		Me.tot_sum2 = CType(Me.Detail.Controls(10),DataDynamics.ActiveReports.TextBox)
		Me.tot = CType(Me.Detail.Controls(11),DataDynamics.ActiveReports.TextBox)
		Me.tot_sum8 = CType(Me.Detail.Controls(12),DataDynamics.ActiveReports.TextBox)
		Me.est_jud = CType(Me.Detail.Controls(13),DataDynamics.ActiveReports.TextBox)
		Me.est_jud1 = CType(Me.Detail.Controls(14),DataDynamics.ActiveReports.TextBox)
		Me.alsafy = CType(Me.Detail.Controls(15),DataDynamics.ActiveReports.TextBox)
		Me.tot_sum13 = CType(Me.Detail.Controls(16),DataDynamics.ActiveReports.TextBox)
		Me.TextBox11 = CType(Me.PageFooter.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox13 = CType(Me.PageFooter.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.TextBox15 = CType(Me.PageFooter.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.TextBox16 = CType(Me.PageFooter.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox17 = CType(Me.PageFooter.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.TextBox27 = CType(Me.PageFooter.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.TextBox28 = CType(Me.PageFooter.Controls(6),DataDynamics.ActiveReports.TextBox)
		Me.Label14 = CType(Me.PageFooter.Controls(7),DataDynamics.ActiveReports.Label)
		Me.Label15 = CType(Me.PageFooter.Controls(8),DataDynamics.ActiveReports.Label)
		Me.Label16 = CType(Me.PageFooter.Controls(9),DataDynamics.ActiveReports.Label)
		Me.TextBox29 = CType(Me.PageFooter.Controls(10),DataDynamics.ActiveReports.TextBox)
		Me.TextBox4 = CType(Me.PageFooter.Controls(11),DataDynamics.ActiveReports.TextBox)
		Me.TextBox7 = CType(Me.PageFooter.Controls(12),DataDynamics.ActiveReports.TextBox)
		Me.TextBox12 = CType(Me.PageFooter.Controls(13),DataDynamics.ActiveReports.TextBox)
		Me.TextBox39 = CType(Me.PageFooter.Controls(14),DataDynamics.ActiveReports.TextBox)
		Me.TextBox40 = CType(Me.PageFooter.Controls(15),DataDynamics.ActiveReports.TextBox)
		Me.TextBox41 = CType(Me.PageFooter.Controls(16),DataDynamics.ActiveReports.TextBox)
		Me.TextBox34 = CType(Me.PageFooter.Controls(17),DataDynamics.ActiveReports.TextBox)
		Me.TextBox18 = CType(Me.PageFooter.Controls(18),DataDynamics.ActiveReports.TextBox)
		Me.TextBox37 = CType(Me.PageFooter.Controls(19),DataDynamics.ActiveReports.TextBox)
		Me.TextBox49 = CType(Me.PageFooter.Controls(20),DataDynamics.ActiveReports.TextBox)
		Me.TextBox53 = CType(Me.PageFooter.Controls(21),DataDynamics.ActiveReports.TextBox)
		Me.TextBox70 = CType(Me.PageFooter.Controls(22),DataDynamics.ActiveReports.TextBox)
		Me.TextBox78 = CType(Me.PageFooter.Controls(23),DataDynamics.ActiveReports.TextBox)
		Me.TextBox79 = CType(Me.PageFooter.Controls(24),DataDynamics.ActiveReports.TextBox)
		Me.TextBox80 = CType(Me.PageFooter.Controls(25),DataDynamics.ActiveReports.TextBox)
		Me.TextBox59 = CType(Me.PageFooter.Controls(26),DataDynamics.ActiveReports.TextBox)
		Me.TextBox66 = CType(Me.PageFooter.Controls(27),DataDynamics.ActiveReports.TextBox)
		Me.TextBox68 = CType(Me.PageFooter.Controls(28),DataDynamics.ActiveReports.TextBox)
		Me.TextBox44 = CType(Me.PageFooter.Controls(29),DataDynamics.ActiveReports.TextBox)
		Me.TextBox46 = CType(Me.PageFooter.Controls(30),DataDynamics.ActiveReports.TextBox)
		Me.TextBox50 = CType(Me.PageFooter.Controls(31),DataDynamics.ActiveReports.TextBox)
		Me.TextBox82 = CType(Me.PageFooter.Controls(32),DataDynamics.ActiveReports.TextBox)
		Me.TextBox84 = CType(Me.PageFooter.Controls(33),DataDynamics.ActiveReports.TextBox)
		Me.TextBox88 = CType(Me.PageFooter.Controls(34),DataDynamics.ActiveReports.TextBox)
		Me.TextBox90 = CType(Me.PageFooter.Controls(35),DataDynamics.ActiveReports.TextBox)
		Me.TextBox19 = CType(Me.ReportFooter.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox20 = CType(Me.ReportFooter.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.TextBox21 = CType(Me.ReportFooter.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.TextBox23 = CType(Me.ReportFooter.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox24 = CType(Me.ReportFooter.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.TextBox25 = CType(Me.ReportFooter.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.Label4 = CType(Me.ReportFooter.Controls(6),DataDynamics.ActiveReports.Label)
		Me.Label13 = CType(Me.ReportFooter.Controls(7),DataDynamics.ActiveReports.Label)
		Me.Shape1 = CType(Me.ReportFooter.Controls(8),DataDynamics.ActiveReports.Shape)
		Me.Label5 = CType(Me.ReportFooter.Controls(9),DataDynamics.ActiveReports.Label)
		Me.Label6 = CType(Me.ReportFooter.Controls(10),DataDynamics.ActiveReports.Label)
		Me.Shape2 = CType(Me.ReportFooter.Controls(11),DataDynamics.ActiveReports.Shape)
		Me.Shape6 = CType(Me.ReportFooter.Controls(12),DataDynamics.ActiveReports.Shape)
		Me.TextBox22 = CType(Me.ReportFooter.Controls(13),DataDynamics.ActiveReports.TextBox)
		Me.TextBox43 = CType(Me.ReportFooter.Controls(14),DataDynamics.ActiveReports.TextBox)
		Me.TextBox45 = CType(Me.ReportFooter.Controls(15),DataDynamics.ActiveReports.TextBox)
		Me.TextBox36 = CType(Me.ReportFooter.Controls(16),DataDynamics.ActiveReports.TextBox)
		Me.TextBox51 = CType(Me.ReportFooter.Controls(17),DataDynamics.ActiveReports.TextBox)
		Me.TextBox74 = CType(Me.ReportFooter.Controls(18),DataDynamics.ActiveReports.TextBox)
		Me.TextBox67 = CType(Me.ReportFooter.Controls(19),DataDynamics.ActiveReports.TextBox)
		Me.TextBox56 = CType(Me.ReportFooter.Controls(20),DataDynamics.ActiveReports.TextBox)
		Me.TextBox57 = CType(Me.ReportFooter.Controls(21),DataDynamics.ActiveReports.TextBox)
		Me.TextBox58 = CType(Me.ReportFooter.Controls(22),DataDynamics.ActiveReports.TextBox)
		Me.TextBox83 = CType(Me.ReportFooter.Controls(23),DataDynamics.ActiveReports.TextBox)
		Me.TextBox89 = CType(Me.ReportFooter.Controls(24),DataDynamics.ActiveReports.TextBox)
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

        If tot_sum.Value = 0 Then
            tot_sum.Value = ""
        End If
        If tot_sum2.Value = 0 Then
            tot_sum2.Value = ""
        End If
        If tot_sum3.Value = 0 Then
            tot_sum3.Value = ""
        End If
        If tot_sum4.Value = 0 Then
            tot_sum4.Value = ""
        End If
        If tot_sum5.Value = 0 Then
            tot_sum5.Value = ""
        End If
        If tot_sum6.Value = 0 Then
            tot_sum6.Value = ""
        End If
        If tot_sum7.Value = 0 Then
            tot_sum7.Value = ""
        End If
        If tot_sum8.Value = 0 Then
            tot_sum8.Value = ""
        End If
        If tot_sum13.Value = 0 Then
            tot_sum13.Value = ""
        End If
        If tot.Value = 0 Then
            tot.Value = ""
        End If
        If alsafy.Value = 0 Then
            alsafy.Value = ""
        End If
        If est_jud.Value = 0 Then
            est_jud.Value = ""
        End If
        If est_jud1.Value = 0 Then
            est_jud1.Value = ""
        End If
        If txtnet.Value <= 0 Then
            txtnet.Value = ""
        End If
    End Sub
    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        If (Me.PageNumber() = 1) Then
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox5.Visible = True
            TextBox9.Visible = True
            TextBox14.Visible = True
            TextBox26.Visible = True
            TextBox38.Visible = True
            TextBox47.Visible = True
            TextBox61.Visible = True
            TextBox62.Visible = True
            TextBox72.Visible = True
            TextBox73.Visible = True
            TextBox81.Visible = True
            TextBox86.Visible = True
            '---------  
            TextBox6.Visible = False
            TextBox10.Visible = False
            TextBox31.Visible = False
            TextBox32.Visible = False
            TextBox42.Visible = False
            TextBox30.Visible = False
            TextBox48.Visible = False
            TextBox52.Visible = False
            TextBox63.Visible = False
            TextBox64.Visible = False
            TextBox71.Visible = False
            TextBox77.Visible = False
            TextBox85.Visible = False
            hj.Visible = False
        Else
            '---------
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox5.Visible = False
            TextBox9.Visible = False
            TextBox14.Visible = False
            TextBox26.Visible = False
            TextBox38.Visible = False
            TextBox47.Visible = False
            TextBox61.Visible = False
            TextBox61.Visible = False
            TextBox62.Visible = False
            TextBox72.Visible = False
            TextBox73.Visible = False
            TextBox81.Visible = False
            TextBox86.Visible = False
            '---------
            TextBox6.Visible = True
            TextBox6.Visible = True
            TextBox10.Visible = True
            TextBox31.Visible = True
            TextBox32.Visible = True
            TextBox42.Visible = True
            TextBox30.Visible = True
            TextBox48.Visible = True
            TextBox52.Visible = True
            TextBox63.Visible = True
            TextBox64.Visible = True
            TextBox71.Visible = True
            TextBox77.Visible = True
            TextBox85.Visible = True
            hj.Visible = True
        End If
        TextBox32.Value = TextBox32.Value - TextBox12.Value
        TextBox63.Value = TextBox63.Value - TextBox78.Value
        hj.Value = hj.Value - TextBox41.Value
        TextBox52.Value = TextBox52.Value - TextBox79.Value
        TextBox31.Value = TextBox31.Value - TextBox7.Value
        TextBox6.Value = TextBox6.Value - TextBox37.Value
        TextBox42.Value = TextBox42.Value - TextBox53.Value
        TextBox71.Value = TextBox71.Value - TextBox80.Value
        TextBox64.Value = TextBox64.Value - TextBox68.Value
        TextBox10.Value = TextBox10.Value - TextBox39.Value
        TextBox48.Value = TextBox48.Value - TextBox59.Value
        TextBox30.Value = TextBox30.Value - TextBox4.Value
        TextBox77.Value = TextBox77.Value - TextBox84.Value
        TextBox85.Value = TextBox85.Value - TextBox90.Value
    End Sub

    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format
        Label13.Text = Horof(y)
        TextBox16.Visible = False
        TextBox17.Visible = False
        TextBox15.Visible = False
        TextBox13.Visible = False
        TextBox11.Visible = False
        TextBox18.Visible = False
        TextBox46.Visible = False
        TextBox44.Visible = False
        TextBox40.Visible = False
        TextBox50.Visible = False
        TextBox49.Visible = False
        TextBox34.Visible = False
        TextBox70.Visible = False
        TextBox66.Visible = False
        TextBox82.Visible = False
        TextBox88.Visible = False
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        TextBox29.Text = Date.Now

    End Sub
End Class
