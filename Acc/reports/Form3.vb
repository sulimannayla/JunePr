Public Class Form3
    Inherits System.Windows.Forms.Form
    'Dim dcument As actcartye
    'Dim constri As String = "data source=pc;initial catalog=car;uid=sa"
    'Dim con As New SqlClient.SqlConnection(constri)

    'Public dadb As New SqlClient.SqlDataAdapter

    'Public dset As New DataSet
    'Public sqlstr As New SqlClient.SqlCommand
    'Public myReport As New actcartye
    'Dim crReportDocument As CAR2.mrep = New CAR2.mrep
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents viwcartye As DataDynamics.ActiveReports.Viewer.Viewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.viwcartye = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.SuspendLayout()
        '
        'viwcartye
        '
        Me.viwcartye.BackColor = System.Drawing.SystemColors.Control
        Me.viwcartye.Location = New System.Drawing.Point(0, 0)
        Me.viwcartye.Name = "viwcartye"
        Me.viwcartye.ReportViewer.CurrentPage = 0
        Me.viwcartye.ReportViewer.MultiplePageCols = 3
        Me.viwcartye.ReportViewer.MultiplePageRows = 2
        Me.viwcartye.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.viwcartye.Size = New System.Drawing.Size(752, 552)
        Me.viwcartye.TabIndex = 3
        Me.viwcartye.TableOfContents.Text = "Table Of Contents"
        Me.viwcartye.TableOfContents.Width = 200
        Me.viwcartye.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'Form3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(752, 549)
        Me.Controls.Add(Me.viwcartye)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim df As New SECURITY
        Dim user As String = df.UserID.Text
        Dim password1 As String = df.Password.Text




        Dim lsPassword, lsUserId As String
        'con.ConnectionString = "User ID= '" & df.UserID.Text & "';" & _
        '"Password='" & df.Password.Text & "';" & _
        '"Initial Catalog=car;" & _
        '"Data Source=pc;" & _
        '"Connection TimeOut=30;"
        con.Open()
        con.Close()
        'Dim lsPassword, lsUserId As String
        'Con.ConnectionString = "User ID= '" & df.UserID.Text & "';" & _
        '"Password='" & df.Password.Text & "';" & _
        '"Initial Catalog=car;" & _
        '"Data Source=pc;" & _
        '"Connection TimeOut=30;"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



        'Dim sql As String
        'Con.Open()
        'sql = "select*from car_type "
        ''sqlstr = New SqlClient.SqlCommand(" select  *  from car_type where  type_no < '" + type_txt.Text + "'  ", Con)
        'Dim cmd As New SqlClient.SqlCommand(sql, con)

        'dadb.SelectCommand = cmd

        ''dset = New DataSet

        'dadb.Fill(dset)

        '''If dset.Tables(0).Rows.Count <> 0 Then


        ''myReport.DataSource = dadb.Fill(dset)

        'myReport.DataSource = dset




        'myReport.DataMember = "car_type"

        'viwcartye.Document = myReport.Document
        'myReport.Run()
        ''myReport.DataSource()
        ''myReport.car_typeTableAdapter.Tables(0).SetDataSource(dset.Tables(0))
        ''CrystalReportViewer1.ReportSource = crReportDocument
        ''CrystalReportViewer1.SeparatePages = False
        ''CrystalReportViewer1.DisplayGroupTree = False
        ''CrystalReportViewer1.DisplayToolbar = False

        'ReportViewer1.ReportSource = myReport
        'ReportViewer1.ReportName.Insert = k

        'Dim Cmd1 As New SqlCommand(sql, Con)
        'dadb.SelectCommand = sqlstr
        'Vcars_dis21.Clear()
        'SqlDataAdapter1.Fill(Vcars_dis21)
        'Dim rpt1 As New Crmon_amount2
        'rpt1.SetDataSource(Vcars_dis21)
        'CrystalReportViewer1.ReportSource = rpt1
        'CrystalReportViewer1.Show()


        'ReportViewer1.DataBind()

        'End If
        'con.Close()

    End Sub
End Class
