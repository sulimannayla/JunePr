Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class ActiveReport4
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
	Private TextBox As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label7 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox1 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox2 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox5 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox6 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox8 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox26 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox31 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox32 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox33 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox34 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox35 As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtname_1 As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtzida1 As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtngsan1 As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtemp_name As DataDynamics.ActiveReports.TextBox = Nothing
	Private txtemp_no As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox12 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox9 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox10 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox13 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox15 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox16 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox17 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox27 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox28 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label4 As DataDynamics.ActiveReports.Label = Nothing
	Private Label5 As DataDynamics.ActiveReports.Label = Nothing
	Private Label6 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox29 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label16 As DataDynamics.ActiveReports.Label = Nothing
	Private zida_txt1 As DataDynamics.ActiveReports.TextBox = Nothing
	Private ngsan_txt1 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label10 As DataDynamics.ActiveReports.Label = Nothing
	Private TextBox3 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox4 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label3 As DataDynamics.ActiveReports.Label = Nothing
	Private Line As DataDynamics.ActiveReports.Line = Nothing
	Private Label11 As DataDynamics.ActiveReports.Label = Nothing
	Private Label12 As DataDynamics.ActiveReports.Label = Nothing
	Private diff As DataDynamics.ActiveReports.TextBox = Nothing
	Private Line5 As DataDynamics.ActiveReports.Line = Nothing
	Private Line6 As DataDynamics.ActiveReports.Line = Nothing
	Private Line7 As DataDynamics.ActiveReports.Line = Nothing
	Private alsafy2 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label As DataDynamics.ActiveReports.Label = Nothing
	Private diff2 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label13 As DataDynamics.ActiveReports.Label = Nothing
	Private Line8 As DataDynamics.ActiveReports.Line = Nothing
	Private Label14 As DataDynamics.ActiveReports.Label = Nothing
	Private diff3 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Label15 As DataDynamics.ActiveReports.Label = Nothing
	Private Shape1 As DataDynamics.ActiveReports.Shape = Nothing
	Private TextBox18 As DataDynamics.ActiveReports.TextBox = Nothing
	Private ngsan_txt As DataDynamics.ActiveReports.TextBox = Nothing
	Private zida_txt As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox24 As DataDynamics.ActiveReports.TextBox = Nothing
	Private TextBox25 As DataDynamics.ActiveReports.TextBox = Nothing
	Private Line1 As DataDynamics.ActiveReports.Line = Nothing
	Private Line2 As DataDynamics.ActiveReports.Line = Nothing
	Public Sub InitializeReport()
		Me.LoadLayout(Me.GetType, "carwin.mowazna.rpx")
		Me.ds = CType(Me.DataSource,DataDynamics.ActiveReports.DataSources.SqlDBDataSource)
		Me.ReportHeader = CType(Me.Sections("ReportHeader"),DataDynamics.ActiveReports.ReportHeader)
		Me.PageHeader = CType(Me.Sections("PageHeader"),DataDynamics.ActiveReports.PageHeader)
		Me.Detail = CType(Me.Sections("Detail"),DataDynamics.ActiveReports.Detail)
		Me.PageFooter = CType(Me.Sections("PageFooter"),DataDynamics.ActiveReports.PageFooter)
		Me.ReportFooter = CType(Me.Sections("ReportFooter"),DataDynamics.ActiveReports.ReportFooter)
		Me.Label1 = CType(Me.ReportHeader.Controls(0),DataDynamics.ActiveReports.Label)
		Me.Label2 = CType(Me.ReportHeader.Controls(1),DataDynamics.ActiveReports.Label)
		Me.Label9 = CType(Me.ReportHeader.Controls(2),DataDynamics.ActiveReports.Label)
		Me.TextBox = CType(Me.ReportHeader.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.Label7 = CType(Me.ReportHeader.Controls(4),DataDynamics.ActiveReports.Label)
		Me.TextBox1 = CType(Me.PageHeader.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox2 = CType(Me.PageHeader.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.TextBox5 = CType(Me.PageHeader.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.TextBox6 = CType(Me.PageHeader.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox8 = CType(Me.PageHeader.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.TextBox26 = CType(Me.PageHeader.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.TextBox31 = CType(Me.PageHeader.Controls(6),DataDynamics.ActiveReports.TextBox)
		Me.TextBox32 = CType(Me.PageHeader.Controls(7),DataDynamics.ActiveReports.TextBox)
		Me.TextBox33 = CType(Me.PageHeader.Controls(8),DataDynamics.ActiveReports.TextBox)
		Me.TextBox34 = CType(Me.PageHeader.Controls(9),DataDynamics.ActiveReports.TextBox)
		Me.TextBox35 = CType(Me.PageHeader.Controls(10),DataDynamics.ActiveReports.TextBox)
		Me.txtname_1 = CType(Me.Detail.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.txtzida1 = CType(Me.Detail.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.txtngsan1 = CType(Me.Detail.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.txtemp_name = CType(Me.Detail.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.txtemp_no = CType(Me.Detail.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.TextBox12 = CType(Me.PageFooter.Controls(0),DataDynamics.ActiveReports.TextBox)
		Me.TextBox9 = CType(Me.PageFooter.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.TextBox10 = CType(Me.PageFooter.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.TextBox13 = CType(Me.PageFooter.Controls(3),DataDynamics.ActiveReports.TextBox)
		Me.TextBox15 = CType(Me.PageFooter.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.TextBox16 = CType(Me.PageFooter.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.TextBox17 = CType(Me.PageFooter.Controls(6),DataDynamics.ActiveReports.TextBox)
		Me.TextBox27 = CType(Me.PageFooter.Controls(7),DataDynamics.ActiveReports.TextBox)
		Me.TextBox28 = CType(Me.PageFooter.Controls(8),DataDynamics.ActiveReports.TextBox)
		Me.Label4 = CType(Me.PageFooter.Controls(9),DataDynamics.ActiveReports.Label)
		Me.Label5 = CType(Me.PageFooter.Controls(10),DataDynamics.ActiveReports.Label)
		Me.Label6 = CType(Me.PageFooter.Controls(11),DataDynamics.ActiveReports.Label)
		Me.TextBox29 = CType(Me.PageFooter.Controls(12),DataDynamics.ActiveReports.TextBox)
		Me.Label16 = CType(Me.ReportFooter.Controls(0),DataDynamics.ActiveReports.Label)
		Me.zida_txt1 = CType(Me.ReportFooter.Controls(1),DataDynamics.ActiveReports.TextBox)
		Me.ngsan_txt1 = CType(Me.ReportFooter.Controls(2),DataDynamics.ActiveReports.TextBox)
		Me.Label10 = CType(Me.ReportFooter.Controls(3),DataDynamics.ActiveReports.Label)
		Me.TextBox3 = CType(Me.ReportFooter.Controls(4),DataDynamics.ActiveReports.TextBox)
		Me.TextBox4 = CType(Me.ReportFooter.Controls(5),DataDynamics.ActiveReports.TextBox)
		Me.Label3 = CType(Me.ReportFooter.Controls(6),DataDynamics.ActiveReports.Label)
		Me.Line = CType(Me.ReportFooter.Controls(7),DataDynamics.ActiveReports.Line)
		Me.Label11 = CType(Me.ReportFooter.Controls(8),DataDynamics.ActiveReports.Label)
		Me.Label12 = CType(Me.ReportFooter.Controls(9),DataDynamics.ActiveReports.Label)
		Me.diff = CType(Me.ReportFooter.Controls(10),DataDynamics.ActiveReports.TextBox)
		Me.Line5 = CType(Me.ReportFooter.Controls(11),DataDynamics.ActiveReports.Line)
		Me.Line6 = CType(Me.ReportFooter.Controls(12),DataDynamics.ActiveReports.Line)
		Me.Line7 = CType(Me.ReportFooter.Controls(13),DataDynamics.ActiveReports.Line)
		Me.alsafy2 = CType(Me.ReportFooter.Controls(14),DataDynamics.ActiveReports.TextBox)
		Me.Label = CType(Me.ReportFooter.Controls(15),DataDynamics.ActiveReports.Label)
		Me.diff2 = CType(Me.ReportFooter.Controls(16),DataDynamics.ActiveReports.TextBox)
		Me.Label13 = CType(Me.ReportFooter.Controls(17),DataDynamics.ActiveReports.Label)
		Me.Line8 = CType(Me.ReportFooter.Controls(18),DataDynamics.ActiveReports.Line)
		Me.Label14 = CType(Me.ReportFooter.Controls(19),DataDynamics.ActiveReports.Label)
		Me.diff3 = CType(Me.ReportFooter.Controls(20),DataDynamics.ActiveReports.TextBox)
		Me.Label15 = CType(Me.ReportFooter.Controls(21),DataDynamics.ActiveReports.Label)
		Me.Shape1 = CType(Me.ReportFooter.Controls(22),DataDynamics.ActiveReports.Shape)
		Me.TextBox18 = CType(Me.ReportFooter.Controls(23),DataDynamics.ActiveReports.TextBox)
		Me.ngsan_txt = CType(Me.ReportFooter.Controls(24),DataDynamics.ActiveReports.TextBox)
		Me.zida_txt = CType(Me.ReportFooter.Controls(25),DataDynamics.ActiveReports.TextBox)
		Me.TextBox24 = CType(Me.ReportFooter.Controls(26),DataDynamics.ActiveReports.TextBox)
		Me.TextBox25 = CType(Me.ReportFooter.Controls(27),DataDynamics.ActiveReports.TextBox)
		Me.Line1 = CType(Me.ReportFooter.Controls(28),DataDynamics.ActiveReports.Line)
		Me.Line2 = CType(Me.ReportFooter.Controls(29),DataDynamics.ActiveReports.Line)
	End Sub

	#End Region

    Private Sub ReportHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.Format
        TextBox.Text = clas
        Label7.Text = clasG
        t1 = 0
        t2 = 0
        t3 = 0
        t4 = 0
    End Sub

    Private Sub ReportFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.Format
        'zida_txt.Text = t2
        'ngsan_txt.Text = t3
        TextBox3.Text = t2
        TextBox4.Text = t3
        'Math.Round(6.69696969 - 0.005, 2)
        diff.Text = Math.Round(t2 - t3, 2)
        alsafy2.Text = alsafy_total2
        'alsafy1.Text = alsafy_total1
        diff2.Text = Math.Round(t2 - t3, 2) 'diff.Value
        diff3.Text = Math.Round(Val(alsafy2.Text) + Val(diff2.Text), 2)        
        'Dim yyy As Double = Math.Round(Val(alsafy2.Text) + Val(diff2.Text), 2)
        Label16.Text = Horof(Math.Round(Val(alsafy2.Text) + Val(diff2.Text), 2))

        '........................
       
        TextBox17.Visible = False
        TextBox16.Visible = False
        TextBox15.Visible = False
        TextBox13.Visible = False
        TextBox10.Visible = False
        '''''''''''''''''''''''''''''''''''''''''
        'If ((TextBox15.Value <> zida_txt.Value) Or (TextBox13.Value <> ngsan_txt.Value)) And Me.PageNumber() <> 1 Then
        '    TextBox33.Visible = False

        'End If
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        t1 = 2
        t2 = t2 + Me.Fields("zida").Value() 'txtzida1.Text + t2
        t3 = t3 + Me.Fields("ngsan").Value() 'txtngsan1.Text + t3
        't1 = t1 + 1
        't4 = TextBox2.Text + t4
        'TextBox33.Visible = True
        'MsgBox("detalse")

        'If (lnCount Mod 16) = 0 Then
        '    Detail.NewPage. = NewPage.After
        'Else
        '    Detail.NewPage = NewPage.None
        'End If

        'lnCount = lnCount + 1

    End Sub

    Private Sub ReportHeader_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader.BeforePrint

    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        'TextBox33.Visible = False
        't1 = 0
        'If t1 <> 0 Then

        'End If
        'MsgBox("PageHeader")
        If (Me.PageNumber() = 1) Then

            TextBox1.Visible = True
            TextBox2.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox8.Visible = True
            'TextBox6.Visible = True
            '---------
            TextBox34.Visible = False
            TextBox33.Visible = False
            TextBox32.Visible = False
            TextBox31.Visible = False
            TextBox26.Visible = False

        Else
            '---------
            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = False
            TextBox8.Visible = False
            'TextBox6.Visible = True
            '---------
            TextBox34.Visible = True
            TextBox33.Visible = True
            TextBox32.Visible = True
            TextBox31.Visible = True
            TextBox26.Visible = True
        End If

        TextBox32.Value = TextBox32.Value - TextBox12.Value
        TextBox31.Value = TextBox31.Value - TextBox9.Value
        '=========
        ''TextBox33.Visible = False
        'TextBox33.Visible = False
        ''If Me.Detail.NewPage. =  True Then

        ''    TextBox33.Visible = False
        ''End If

        'If (t1 = 0) Then
        '    TextBox33.Visible = False
        '    TextBox34.Visible = False
        '    TextBox32.Visible = False
        '    TextBox31.Visible = False
        '    TextBox26.Visible = False
        'End If
        'TextBox15.Value TextBox13.Value  
        'If ((t2 <> TextBox32.Value) Or (t3 <> TextBox31.Value)) Then
        '    TextBox33.Visible = False
        '    TextBox34.Visible = False
        '    TextBox32.Visible = False
        '    TextBox31.Visible = False
        '    TextBox26.Visible = False
        'Else
        '    TextBox33.Visible = True
        '    TextBox34.Visible = True
        '    TextBox32.Visible = True
        '    TextBox31.Visible = True
        '    TextBox26.Visible = True
        'End If
        'If t1 = 0 Then
        '    TextBox33.Visible = False
        '    MsgBox("1")
        'End If
    End Sub

    Private Sub PageHeader_AfterPrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.AfterPrint

    End Sub

    Private Sub PageHeader_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.BeforePrint

    End Sub

    Private Sub PageHeader_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Disposed

    End Sub

    Private Sub Detail_AfterPrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.AfterPrint

    End Sub

    Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.BeforePrint

    End Sub

    Private Sub Detail_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Disposed

    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        TextBox29.Text = Date.Now      

    End Sub

    Private Sub ReportFooter_AfterPrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.AfterPrint
        
    End Sub

    Private Sub ReportFooter_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter.BeforePrint
        
    End Sub

    Private Sub ActiveReport4_NoData(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.NoData

    End Sub

    Private Sub ActiveReport4_PageEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PageEnd
        t1 = 0
    End Sub

    Private Sub ActiveReport4_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        lnCount = 1

    End Sub

    Private Sub ActiveReport4_ReportEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ReportEnd
        'If Detail = False Then
        '    TextBox33.Visible = False
        '    MsgBox("1")
        'End If
    End Sub
End Class
