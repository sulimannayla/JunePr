Public Class pritmentenance1
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
        Me.Viewer1.Location = New System.Drawing.Point(-48, 0)
        Me.Viewer1.Name = "Viewer1"
        Me.Viewer1.ReportViewer.CurrentPage = 0
        Me.Viewer1.ReportViewer.MultiplePageCols = 3
        Me.Viewer1.ReportViewer.MultiplePageRows = 2
        Me.Viewer1.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.Viewer1.Size = New System.Drawing.Size(800, 528)
        Me.Viewer1.TabIndex = 0
        Me.Viewer1.TableOfContents.Text = "Table Of Contents"
        Me.Viewer1.TableOfContents.Width = 200
        Me.Viewer1.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'pritmentenance1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(752, 525)
        Me.Controls.Add(Me.Viewer1)
        Me.Name = "pritmentenance1"
        Me.Text = "ÿ»«⁄… ÿ·» «·’Ì«‰…"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub pritmentenance1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim df As New SECURITY
        Dim _tmp As Cursor
            _tmp = Me.Cursor
            Me.Cursor = Cursors.WaitCursor
        Dim _rpt = New ActiveReport1
            Dim _DS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource
        _DS.ConnectionString = "User ID= '" & sect & "';" & _
    "Password='" & pass & "';" & _
    "Initial Catalog=car2;" & _
    "Data Source=pc;" & _
    "Connection TimeOut=30;"
        Dim _sqlString As String = "Select sites.site_name,maintenance.chec1,maintenance.chec2,maintenance.medn,maintenance.car2_no,maintenance.maintenance_id, maintenance.apply_person,maintenance.apply_date,maintenance.main_req,maintenance.shop_report,maintenance.notes,car2_type.car2_name,car2_type.type_no"
        _sqlString = _sqlString + " FROM sites,car2_type,maintenance,car2_data"
        _sqlString = _sqlString + " WHERE maintenance.car2_no=car2_data.car2_no and sites.site_id=car2_data.site_id and maintenance.type_no = car2_type.type_no  AND maintenance.maintenance_id = '" & ad2 & "'"
            '_sqlString = _sqlString + 62 + "'"
            _DS.SQL = _sqlString
            _rpt.DataSource = _DS
        '******************************************************
            Me.Viewer1.Document = _rpt.Document
            _rpt.Run(False)
        Me.Cursor = _tmp
    End Sub

    Private Sub Viewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Viewer1.Load

    End Sub
End Class
