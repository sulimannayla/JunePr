Public Class tamandate
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
        Me.Viewer1.Location = New System.Drawing.Point(0, 0)
        Me.Viewer1.Name = "Viewer1"
        Me.Viewer1.ReportViewer.CurrentPage = 0
        Me.Viewer1.ReportViewer.MultiplePageCols = 3
        Me.Viewer1.ReportViewer.MultiplePageRows = 2
        Me.Viewer1.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.Viewer1.Size = New System.Drawing.Size(808, 568)
        Me.Viewer1.TabIndex = 0
        Me.Viewer1.TableOfContents.Text = "Table Of Contents"
        Me.Viewer1.TableOfContents.Width = 200
        Me.Viewer1.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'tamandate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 557)
        Me.Controls.Add(Me.Viewer1)
        Me.Name = "tamandate"
        Me.Text = "⁄—»«  ﬁ«—»  «—ÌŒ «‰ Â«¡  «„Ì‰Â«"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Viewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Viewer1.Load
        Dim DS3 As New DataSet
        Dim str As String = "Select DATEDIFF(day,insurance_date,'" & DateValue(Date.Now) & "') from car2_data where DATEDIFF(day, insurance_date,'" & DateValue(Date.Now) & "')< 5 "
        Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        ADP.Fill(DS3)
        Dim i As Integer
        If DS3.Tables(0).Rows.Count >= 1 Then
            'MsgBox("  Â‰«·ﬂ »⁄÷ «·⁄—»«  ﬁœ ﬁ«—»  «—ÌŒ «‰ Â«¡  √„Ì‰Â« " + "  " + issa, MsgBoxStyle.Information, " ‰»ÌÂ")
        End If
        '**********************************************
        Dim df As New SECURITY
        Try
            Dim _tmp As Cursor
            _tmp = Me.Cursor
            Me.Cursor = Cursors.WaitCursor
            Dim _rpt = New insudatecal
            Dim _DS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource
            _DS.ConnectionString = "User ID= '" & sect & "';" & _
        "Password='" & pass & "';" & _
        "Initial Catalog=car2;" & _
        "Data Source=pc;" & _
        "Connection TimeOut=30;"
            '*************************************************************************
            Dim _sqlString As String = "Select car2_data.insudatstard,DATEDIFF(day,'" & DateValue(Date.Now) & "',car2_data.insurance_date)as issa,car2_data.reg_no,car2_data.privet_no,sites.site_name,car2_data.car2_no, car2_data.model, car2_data.type_no, car2_data.no_type,car2_data.shase_no,car2_data.machine_no,car2_data.car2_owner,car2_data.insurance_date,car2_data.insurance_no,car2_data.driver,car2_type.type_no,car2_type.car2_name"
            _sqlString = _sqlString + " FROM car2_type, car2_data,sites"
            _sqlString = _sqlString + " WHERE theweel <>1 and DATEDIFF(day,'" & DateValue(Date.Now) & "', car2_data.insurance_date)< 5 and sites.site_id=car2_data.site_id and car2_data.type_no = car2_type.type_no "
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
End Class
