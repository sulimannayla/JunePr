Public Class estbad
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents car2_notxt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Viewer1 = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.Button2 = New System.Windows.Forms.Button
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.car2_notxt = New System.Windows.Forms.TextBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'Viewer1
        '
        Me.Viewer1.BackColor = System.Drawing.SystemColors.Control
        Me.Viewer1.Location = New System.Drawing.Point(0, 56)
        Me.Viewer1.Name = "Viewer1"
        Me.Viewer1.ReportViewer.CurrentPage = 0
        Me.Viewer1.ReportViewer.MultiplePageCols = 3
        Me.Viewer1.ReportViewer.MultiplePageRows = 2
        Me.Viewer1.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.Viewer1.Size = New System.Drawing.Size(792, 544)
        Me.Viewer1.TabIndex = 0
        Me.Viewer1.TableOfContents.Text = "Table Of Contents"
        Me.Viewer1.TableOfContents.Width = 200
        Me.Viewer1.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(64, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 24)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Œ‹‹‹‹‹‹‹‹‹‹‹‹‹‹‹‹‹‹‹‹—ÊÃ"
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton3.Location = New System.Drawing.Point(658, 1)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(120, 32)
        Me.RadioButton3.TabIndex = 18
        Me.RadioButton3.Text = "«·ﬂ‹‹‹‹‹‹‹‹‹‹·"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(192, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 24)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "⁄‹—÷ «· ﬁ—Ì‹—"
        '
        'car2_notxt
        '
        Me.car2_notxt.Enabled = False
        Me.car2_notxt.Location = New System.Drawing.Point(480, 32)
        Me.car2_notxt.Name = "car2_notxt"
        Me.car2_notxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.car2_notxt.Size = New System.Drawing.Size(168, 20)
        Me.car2_notxt.TabIndex = 12
        Me.car2_notxt.Text = ""
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(656, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(112, 32)
        Me.RadioButton1.TabIndex = 14
        Me.RadioButton1.Text = "«·⁄—»… »«·—ﬁ„"
        '
        'estbad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 585)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.car2_notxt)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Viewer1)
        Me.Name = "estbad"
        Me.Text = "estbad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Viewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Viewer1.Load
        car2_notxt.Enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim _rpt = New estbin
        Dim df As New SECURITY
        Try
            Dim _tmp As Cursor
            _tmp = Me.Cursor
            Me.Cursor = Cursors.WaitCursor
            Dim _DS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource
            _DS.ConnectionString = "User ID= '" & sect & "';" & _
        "Password='" & pass & "';" & _
        "Initial Catalog=car2;" & _
        "Data Source=pc;" & _
        "Connection TimeOut=30;"
            '*************************************************************************
            If RadioButton1.Checked = True Then
                Dim _sqlString As String = "Select date_th,insudatstard,car2_data.note,car2_data.reg_no,car2_data.privet_no,sites.site_name,car2_data.car2_no, car2_data.model, car2_data.type_no, car2_data.no_type,car2_data.shase_no,car2_data.machine_no,car2_data.car2_owner,car2_data.insurance_date,car2_data.insurance_no,car2_data.driver,car2_type.type_no,car2_type.car2_name"
                _sqlString = _sqlString + " FROM car2_type, car2_data,sites"
                _sqlString = _sqlString + " WHERE sites.site_id=car2_data.site_id and car2_data.type_no = car2_type.type_no AND car2_data.car2_no='" & car2_notxt.Text.Trim & "' and  car2_data.theweel= '" & 1 & "'"
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS
            End If

            If RadioButton3.Checked = True Then
                Dim _sqlString As String = "Select date_th,insudatstard,car2_data.note,car2_data.reg_no,car2_data.privet_no,sites.site_name,car2_data.car2_no, car2_data.model, car2_data.type_no, car2_data.no_type,car2_data.shase_no,car2_data.machine_no,car2_data.car2_owner,car2_data.insurance_date,car2_data.insurance_no,car2_data.driver,car2_type.type_no,car2_type.car2_name"
                _sqlString = _sqlString + " FROM car2_type, car2_data,sites"
                _sqlString = _sqlString + " WHERE sites.site_id=car2_data.site_id and car2_data.type_no = car2_type.type_no  and  car2_data.theweel= '" & 1 & "' "
                '_sqlString = _sqlString + 62 + "'"
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS
            End If
            Me.Viewer1.Document = _rpt.Document
            _rpt.Run(False)
            Me.Cursor = _tmp

        Catch ex As DataDynamics.ActiveReports.ReportException
            MessageBox.Show(Me, "Error fired while running the report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        car2_notxt.Enabled = True
    End Sub

    Private Sub RadioButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.Click
        car2_notxt.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
