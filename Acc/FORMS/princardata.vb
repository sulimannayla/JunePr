Public Class princar2data
    Inherits System.Windows.Forms.Form
    Public df As New SECURITY
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ff As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents driver_txt As System.Windows.Forms.TextBox
    Friend WithEvents car2_n0_txt As System.Windows.Forms.TextBox
    Friend WithEvents owner_txt As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Viewer1 = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.driver_txt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.car2_n0_txt = New System.Windows.Forms.TextBox
        Me.ff = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.owner_txt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Viewer1
        '
        Me.Viewer1.BackColor = System.Drawing.Color.FloralWhite
        Me.Viewer1.Location = New System.Drawing.Point(0, 64)
        Me.Viewer1.Name = "Viewer1"
        Me.Viewer1.ReportViewer.CurrentPage = 0
        Me.Viewer1.ReportViewer.MultiplePageCols = 3
        Me.Viewer1.ReportViewer.MultiplePageRows = 2
        Me.Viewer1.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.Viewer1.Size = New System.Drawing.Size(800, 472)
        Me.Viewer1.TabIndex = 0
        Me.Viewer1.TableOfContents.Text = "Table Of Contents"
        Me.Viewer1.TableOfContents.Width = 200
        Me.Viewer1.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'driver_txt
        '
        Me.driver_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.driver_txt.Enabled = False
        Me.driver_txt.Location = New System.Drawing.Point(406, 32)
        Me.driver_txt.Name = "driver_txt"
        Me.driver_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.driver_txt.Size = New System.Drawing.Size(240, 20)
        Me.driver_txt.TabIndex = 1
        Me.driver_txt.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(656, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "≈”„ «·”«∆ﬁ"
        '
        'car2_n0_txt
        '
        Me.car2_n0_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.car2_n0_txt.Enabled = False
        Me.car2_n0_txt.Location = New System.Drawing.Point(477, 6)
        Me.car2_n0_txt.Name = "car2_n0_txt"
        Me.car2_n0_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.car2_n0_txt.Size = New System.Drawing.Size(168, 20)
        Me.car2_n0_txt.TabIndex = 3
        Me.car2_n0_txt.Text = ""
        '
        'ff
        '
        Me.ff.Location = New System.Drawing.Point(648, 7)
        Me.ff.Name = "ff"
        Me.ff.Size = New System.Drawing.Size(72, 24)
        Me.ff.TabIndex = 4
        Me.ff.Text = "—ﬁ‹‹‹„ «·⁄—»‹‹‹‹…"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(720, 8)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(24, 16)
        Me.RadioButton1.TabIndex = 5
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(720, 32)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(24, 16)
        Me.RadioButton2.TabIndex = 6
        '
        'owner_txt
        '
        Me.owner_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.owner_txt.Enabled = False
        Me.owner_txt.Location = New System.Drawing.Point(40, 8)
        Me.owner_txt.Name = "owner_txt"
        Me.owner_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.owner_txt.Size = New System.Drawing.Size(232, 20)
        Me.owner_txt.TabIndex = 7
        Me.owner_txt.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(286, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "«· Œ’Ì’"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(151, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 24)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "⁄‹—÷ «· ﬁ—Ì‹—"
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(346, 8)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(32, 16)
        Me.RadioButton3.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(40, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 24)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Œ‹‹‹‹‹‹‹—ÊÃ"
        '
        'princar2data
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(804, 541)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.owner_txt)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ff)
        Me.Controls.Add(Me.car2_n0_txt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.driver_txt)
        Me.Controls.Add(Me.Viewer1)
        Me.Name = "princar2data"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = " ﬁ—Ì— »Ì«‰«  «·⁄—»«  „Œ’’…"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub princar2data_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim car2r As car2data
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim df As New SECURITY
        Try
            Dim _tmp As Cursor
            _tmp = Me.Cursor
            Me.Cursor = Cursors.WaitCursor
            '**************************************************
            'If car2datat = sd Then
            '    Dim _rpt = New car2datamk
            'Else
            '    Dim _rpt = New repcar2datareco
            'End If
            '*****************************************************************

            '**************************************************
            Dim _rpt = New repcar2datareco

            '*************************
            Dim _DS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource

            _DS.ConnectionString = "User ID= '" & sect & "';" & _
        "Password='" & pass & "';" & _
        "Initial Catalog=car2;" & _
        "Data Source=pc;" & _
        "Connection TimeOut=30;"
            '*************************************************************************
            If RadioButton1.Checked = True Then
                Dim _sqlString As String = "Select car2_data.insudatstard,car2_data.note,car2_data.reg_no,car2_data.privet_no,sites.site_name,car2_data.car2_no, car2_data.model, car2_data.type_no, car2_data.no_type,car2_data.shase_no,car2_data.machine_no,car2_data.car2_owner,car2_data.insurance_date,car2_data.insurance_no,car2_data.driver,car2_type.type_no,car2_type.car2_name"
                _sqlString = _sqlString + " FROM car2_type, car2_data,sites"
                _sqlString = _sqlString + " WHERE car2_data.theweel<>1 and sites.site_id=car2_data.site_id and car2_data.type_no = car2_type.type_no AND car2_data.car2_no = '" & car2_n0_txt.Text & "'"
                '_sqlString = _sqlString + 62 + "'"
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS
            End If
            '***************************************************************************
            If RadioButton2.Checked = True Then
                Dim _sqlString As String = "Select car2_data.insudatstard,car2_data.note,car2_data.reg_no,car2_data.privet_no,car2_data.car2_no, car2_data.model,  car2_data.no_type,car2_data.shase_no,car2_data.machine_no,car2_data.car2_owner,car2_data.insurance_date,car2_data.insurance_no,car2_data.driver,car2_type.type_no,car2_type.car2_name"
                _sqlString = _sqlString + " FROM car2_type, car2_data"
                _sqlString = _sqlString + " WHERE car2_data.theweel<>1 and car2_data.type_no = car2_type.type_no  AND car2_data.driver = '" & driver_txt.Text & "'"
                '_sqlString = _sqlString + 62 + "'"
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS
            End If
            '******************************

            If RadioButton3.Checked = True Then
                Dim _sqlString As String = "Select car2_data.insudatstard,car2_data.note,car2_data.reg_no,car2_data.privet_no,car2_data.car2_no, car2_data.model,  car2_data.no_type,car2_data.shase_no,car2_data.machine_no,car2_data.car2_owner,car2_data.insurance_date,car2_data.insurance_no,car2_data.driver,car2_type.type_no,car2_type.car2_name"
                _sqlString = _sqlString + " FROM car2_type, car2_data"
                _sqlString = _sqlString + " WHERE car2_data.theweel<>1 and car2_data.type_no = car2_type.type_no  AND car2_data.car2_owner = '" & owner_txt.Text & "'"
                '_sqlString = _sqlString + 62 + "'"
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS
            End If
            '******************************************************
            Me.Viewer1.Document = _rpt.Document
            _rpt.Run(False)
            Me.Cursor = _tmp

        Catch ex As DataDynamics.ActiveReports.ReportException
            MessageBox.Show(Me, "Error fired while running the report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        car2_n0_txt.Enabled = False
        driver_txt.Enabled = True
        owner_txt.Enabled = False
    End Sub
    Private Sub owner_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles owner_txt.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        car2_n0_txt.Enabled = True
        driver_txt.Enabled = False
        owner_txt.Enabled = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        car2_n0_txt.Enabled = False
        driver_txt.Enabled = False
        owner_txt.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
