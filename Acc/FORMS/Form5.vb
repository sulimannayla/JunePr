Public Class repcar2_type

    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Viewer1 As DataDynamics.ActiveReports.Viewer.Viewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Viewer1 = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.SuspendLayout()
        '
        'Viewer1
        '
        Me.Viewer1.BackColor = System.Drawing.SystemColors.Control
        Me.Viewer1.Location = New System.Drawing.Point(0, 8)
        Me.Viewer1.Name = "Viewer1"
        Me.Viewer1.ReportViewer.CurrentPage = 0
        Me.Viewer1.ReportViewer.MultiplePageCols = 3
        Me.Viewer1.ReportViewer.MultiplePageRows = 2
        Me.Viewer1.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.Viewer1.Size = New System.Drawing.Size(808, 584)
        Me.Viewer1.TabIndex = 0
        Me.Viewer1.TableOfContents.Text = "Table Of Contents"
        Me.Viewer1.TableOfContents.Width = 200
        Me.Viewer1.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'repcar2_type
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(804, 585)
        Me.Controls.Add(Me.Viewer1)
        Me.Name = "repcar2_type"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "ÇäæÇÚ ÇáÚÑÈÇÊ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object)

    End Sub

    Private Sub repcar2_type_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim df As New SECURITY
        Try
            Dim _tmp As Cursor
            _tmp = Me.Cursor
            Me.Cursor = Cursors.WaitCursor
            Dim _rpt = New ActiveRepcar2type
            'Dim _rpt = New ActiveReport2
            Dim _DS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource
            _DS.ConnectionString = "User ID= '" & sect & "';" & _
        "Password='" & pass & "';" & _
        "Initial Catalog=car2;" & _
        "Data Source=pc;" & _
        "Connection TimeOut=30;"
            '*************************************************************************
            Dim _sqlString As String = "SELECT COUNT(car2_data.type_no)as coun,car2_data.type_no,car2_type.car2_name FROM car2_data, car2_type WHERE car2_data.theweel <>1 and car2_data.type_no = car2_type.type_no GROUP BY car2_type.car2_name, car2_data.type_no"
            '_sqlString = _sqlString + " , car2_data"
            '_sqlString = _sqlString + " WHERE car2_data.type_no = car2_type.type_no AND car2_data.car2_no = '" & car2_n0_txt.Text & "'"
            '_sqlString = _sqlString + 62 + "'"
            _DS.SQL = _sqlString
            _rpt.DataSource = _DS
            Me.Viewer1.Document = _rpt.Document
            _rpt.Run(False)
            Me.Cursor = _tmp
        Catch ex As DataDynamics.ActiveReports.ReportException
            MessageBox.Show(Me, "Error fired while running the report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Viewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Viewer1.Load

    End Sub
End Class
