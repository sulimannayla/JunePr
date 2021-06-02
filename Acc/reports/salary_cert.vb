Imports System
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class salary_cert
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
    Private Shape5 As DataDynamics.ActiveReports.Shape = Nothing
    Private txtdate_ As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label3 As DataDynamics.ActiveReports.Label = Nothing
    Private Label1 As DataDynamics.ActiveReports.Label = Nothing
    Private Label2 As DataDynamics.ActiveReports.Label = Nothing
    Private Label9 As DataDynamics.ActiveReports.Label = Nothing
    Private Picture As DataDynamics.ActiveReports.Picture = Nothing
    Private Label8 As DataDynamics.ActiveReports.Label = Nothing
    Private Line5 As DataDynamics.ActiveReports.Line = Nothing
    Private Label11 As DataDynamics.ActiveReports.Label = Nothing
    Private Label12 As DataDynamics.ActiveReports.Label = Nothing
    Private Label13 As DataDynamics.ActiveReports.Label = Nothing
    Private txtdgree_name As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label As DataDynamics.ActiveReports.Label = Nothing
    Private txtemp_name As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtemp_no As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label4 As DataDynamics.ActiveReports.Label = Nothing
    Private Shape1 As DataDynamics.ActiveReports.Shape = Nothing
    Private Line4 As DataDynamics.ActiveReports.Line = Nothing
    Private Line3 As DataDynamics.ActiveReports.Line = Nothing
    Private Shape2 As DataDynamics.ActiveReports.Shape = Nothing
    Private Line6 As DataDynamics.ActiveReports.Line = Nothing
    Private Line9 As DataDynamics.ActiveReports.Line = Nothing
    Private txtnot_conbdle_val As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtest_ok_val As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtest_ok_name As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtcon_est_val As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtcon_est_name As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtcon_bdl_val As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtcon_bdl_name As DataDynamics.ActiveReports.TextBox = Nothing
    Private txtnot_conbdel_name As DataDynamics.ActiveReports.TextBox = Nothing
    Private Shape4 As DataDynamics.ActiveReports.Shape = Nothing
    Private Shape As DataDynamics.ActiveReports.Shape = Nothing
    Private Line8 As DataDynamics.ActiveReports.Line = Nothing
    Private Line7 As DataDynamics.ActiveReports.Line = Nothing
    Private TextBox4 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label7 As DataDynamics.ActiveReports.Label = Nothing
    Private txtest_sum As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label10 As DataDynamics.ActiveReports.Label = Nothing
    Private txtbdl_sum As DataDynamics.ActiveReports.TextBox = Nothing
    Private safy As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label5 As DataDynamics.ActiveReports.Label = Nothing
    Private Label6 As DataDynamics.ActiveReports.Label = Nothing
    Private Line2 As DataDynamics.ActiveReports.Line = Nothing
    Private Line As DataDynamics.ActiveReports.Line = Nothing
    Private Line1 As DataDynamics.ActiveReports.Line = Nothing
    Private Shape3 As DataDynamics.ActiveReports.Shape = Nothing
    Private TextBox As DataDynamics.ActiveReports.TextBox = Nothing
    Private TextBox1 As DataDynamics.ActiveReports.TextBox = Nothing
    Private Label14 As DataDynamics.ActiveReports.Label = Nothing
    Private Label15 As DataDynamics.ActiveReports.Label = Nothing
    Private Label16 As DataDynamics.ActiveReports.Label = Nothing
    Private TextBox2 As DataDynamics.ActiveReports.TextBox = Nothing
    Public Sub InitializeReport()
        Me.LoadLayout(Me.GetType, "carwin.ActiveReport3.rpx")
        Me.ds = CType(Me.DataSource, DataDynamics.ActiveReports.DataSources.SqlDBDataSource)
        Me.ReportHeader = CType(Me.Sections("ReportHeader"), DataDynamics.ActiveReports.ReportHeader)
        Me.PageHeader = CType(Me.Sections("PageHeader"), DataDynamics.ActiveReports.PageHeader)
        Me.GroupHeader1 = CType(Me.Sections("GroupHeader1"), DataDynamics.ActiveReports.GroupHeader)
        Me.Detail = CType(Me.Sections("Detail"), DataDynamics.ActiveReports.Detail)
        Me.GroupFooter1 = CType(Me.Sections("GroupFooter1"), DataDynamics.ActiveReports.GroupFooter)
        Me.PageFooter = CType(Me.Sections("PageFooter"), DataDynamics.ActiveReports.PageFooter)
        Me.ReportFooter = CType(Me.Sections("ReportFooter"), DataDynamics.ActiveReports.ReportFooter)
        Me.Shape5 = CType(Me.ReportHeader.Controls(0), DataDynamics.ActiveReports.Shape)
        Me.txtdate_ = CType(Me.ReportHeader.Controls(1), DataDynamics.ActiveReports.TextBox)
        Me.Label3 = CType(Me.ReportHeader.Controls(2), DataDynamics.ActiveReports.Label)
        Me.Label1 = CType(Me.ReportHeader.Controls(3), DataDynamics.ActiveReports.Label)
        Me.Label2 = CType(Me.ReportHeader.Controls(4), DataDynamics.ActiveReports.Label)
        Me.Label9 = CType(Me.ReportHeader.Controls(5), DataDynamics.ActiveReports.Label)
        Me.Picture = CType(Me.ReportHeader.Controls(6), DataDynamics.ActiveReports.Picture)
        Me.Label8 = CType(Me.ReportHeader.Controls(7), DataDynamics.ActiveReports.Label)
        Me.Line5 = CType(Me.ReportHeader.Controls(8), DataDynamics.ActiveReports.Line)
        Me.Label11 = CType(Me.GroupHeader1.Controls(0), DataDynamics.ActiveReports.Label)
        Me.Label12 = CType(Me.GroupHeader1.Controls(1), DataDynamics.ActiveReports.Label)
        Me.Label13 = CType(Me.GroupHeader1.Controls(2), DataDynamics.ActiveReports.Label)
        Me.txtdgree_name = CType(Me.GroupHeader1.Controls(3), DataDynamics.ActiveReports.TextBox)
        Me.Label = CType(Me.GroupHeader1.Controls(4), DataDynamics.ActiveReports.Label)
        Me.txtemp_name = CType(Me.GroupHeader1.Controls(5), DataDynamics.ActiveReports.TextBox)
        Me.txtemp_no = CType(Me.GroupHeader1.Controls(6), DataDynamics.ActiveReports.TextBox)
        Me.Label4 = CType(Me.GroupHeader1.Controls(7), DataDynamics.ActiveReports.Label)
        Me.Shape1 = CType(Me.GroupHeader1.Controls(8), DataDynamics.ActiveReports.Shape)
        Me.Line4 = CType(Me.GroupHeader1.Controls(9), DataDynamics.ActiveReports.Line)
        Me.Line3 = CType(Me.GroupHeader1.Controls(10), DataDynamics.ActiveReports.Line)
        Me.Shape2 = CType(Me.GroupHeader1.Controls(11), DataDynamics.ActiveReports.Shape)
        Me.Line6 = CType(Me.GroupHeader1.Controls(12), DataDynamics.ActiveReports.Line)
        Me.Line9 = CType(Me.GroupHeader1.Controls(13), DataDynamics.ActiveReports.Line)
        Me.txtnot_conbdle_val = CType(Me.Detail.Controls(0), DataDynamics.ActiveReports.TextBox)
        Me.txtest_ok_val = CType(Me.Detail.Controls(1), DataDynamics.ActiveReports.TextBox)
        Me.txtest_ok_name = CType(Me.Detail.Controls(2), DataDynamics.ActiveReports.TextBox)
        Me.txtcon_est_val = CType(Me.Detail.Controls(3), DataDynamics.ActiveReports.TextBox)
        Me.txtcon_est_name = CType(Me.Detail.Controls(4), DataDynamics.ActiveReports.TextBox)
        Me.txtcon_bdl_val = CType(Me.Detail.Controls(5), DataDynamics.ActiveReports.TextBox)
        Me.txtcon_bdl_name = CType(Me.Detail.Controls(6), DataDynamics.ActiveReports.TextBox)
        Me.txtnot_conbdel_name = CType(Me.Detail.Controls(7), DataDynamics.ActiveReports.TextBox)
        Me.Shape4 = CType(Me.Detail.Controls(8), DataDynamics.ActiveReports.Shape)
        Me.Shape = CType(Me.Detail.Controls(9), DataDynamics.ActiveReports.Shape)
        Me.Line8 = CType(Me.Detail.Controls(10), DataDynamics.ActiveReports.Line)
        Me.Line7 = CType(Me.Detail.Controls(11), DataDynamics.ActiveReports.Line)
        Me.TextBox4 = CType(Me.GroupFooter1.Controls(0), DataDynamics.ActiveReports.TextBox)
        Me.Label7 = CType(Me.GroupFooter1.Controls(1), DataDynamics.ActiveReports.Label)
        Me.txtest_sum = CType(Me.GroupFooter1.Controls(2), DataDynamics.ActiveReports.TextBox)
        Me.Label10 = CType(Me.GroupFooter1.Controls(3), DataDynamics.ActiveReports.Label)
        Me.txtbdl_sum = CType(Me.GroupFooter1.Controls(4), DataDynamics.ActiveReports.TextBox)
        Me.safy = CType(Me.GroupFooter1.Controls(5), DataDynamics.ActiveReports.TextBox)
        Me.Label5 = CType(Me.GroupFooter1.Controls(6), DataDynamics.ActiveReports.Label)
        Me.Label6 = CType(Me.GroupFooter1.Controls(7), DataDynamics.ActiveReports.Label)
        Me.Line2 = CType(Me.GroupFooter1.Controls(8), DataDynamics.ActiveReports.Line)
        Me.Line = CType(Me.GroupFooter1.Controls(9), DataDynamics.ActiveReports.Line)
        Me.Line1 = CType(Me.GroupFooter1.Controls(10), DataDynamics.ActiveReports.Line)
        Me.Shape3 = CType(Me.GroupFooter1.Controls(11), DataDynamics.ActiveReports.Shape)
        Me.TextBox = CType(Me.PageFooter.Controls(0), DataDynamics.ActiveReports.TextBox)
        Me.TextBox1 = CType(Me.PageFooter.Controls(1), DataDynamics.ActiveReports.TextBox)
        Me.Label14 = CType(Me.PageFooter.Controls(2), DataDynamics.ActiveReports.Label)
        Me.Label15 = CType(Me.PageFooter.Controls(3), DataDynamics.ActiveReports.Label)
        Me.Label16 = CType(Me.PageFooter.Controls(4), DataDynamics.ActiveReports.Label)
        Me.TextBox2 = CType(Me.PageFooter.Controls(5), DataDynamics.ActiveReports.TextBox)
    End Sub

#End Region
End Class
