Public Class reptswia2
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
    Friend WithEvents insurecom_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents blag_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents car2_no As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Viewer1 As DataDynamics.ActiveReports.Viewer.Viewer
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents no_blagtxt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.insurecom_txt = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.blag_date = New System.Windows.Forms.DateTimePicker
        Me.no_blagtxt = New System.Windows.Forms.TextBox
        Me.car2_no = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Viewer1 = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'insurecom_txt
        '
        Me.insurecom_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.insurecom_txt.Location = New System.Drawing.Point(139, 4)
        Me.insurecom_txt.Name = "insurecom_txt"
        Me.insurecom_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.insurecom_txt.Size = New System.Drawing.Size(192, 20)
        Me.insurecom_txt.TabIndex = 106
        Me.insurecom_txt.Text = ""
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(335, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 24)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "«·‘—ﬂ… «·„ƒ„‰…"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(630, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 32)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "—ﬁ‹„ «·⁄‹—»…"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(336, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 32)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = " ‹‹«—ÌŒ «·»·«€"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(632, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 32)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "‰„‹‹—… «·»·«€"
        '
        'blag_date
        '
        Me.blag_date.CustomFormat = "yyyy/MM/dd"
        Me.blag_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.blag_date.Location = New System.Drawing.Point(211, 29)
        Me.blag_date.Name = "blag_date"
        Me.blag_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.blag_date.Size = New System.Drawing.Size(120, 20)
        Me.blag_date.TabIndex = 111
        '
        'no_blagtxt
        '
        Me.no_blagtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.no_blagtxt.Location = New System.Drawing.Point(472, 32)
        Me.no_blagtxt.Name = "no_blagtxt"
        Me.no_blagtxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.no_blagtxt.Size = New System.Drawing.Size(152, 20)
        Me.no_blagtxt.TabIndex = 113
        Me.no_blagtxt.Text = ""
        '
        'car2_no
        '
        Me.car2_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.car2_no.Location = New System.Drawing.Point(472, 8)
        Me.car2_no.Name = "car2_no"
        Me.car2_no.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.car2_no.Size = New System.Drawing.Size(152, 20)
        Me.car2_no.TabIndex = 112
        Me.car2_no.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Location = New System.Drawing.Point(8, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 24)
        Me.Button1.TabIndex = 114
        Me.Button1.Text = "⁄‹‹‹‹‹‹‹—÷"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Location = New System.Drawing.Point(8, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 24)
        Me.Button2.TabIndex = 115
        Me.Button2.Text = "Œ‹‹‹‹‹‹‹‹—ÊÃ"
        '
        'Viewer1
        '
        Me.Viewer1.BackColor = System.Drawing.SystemColors.Control
        Me.Viewer1.Location = New System.Drawing.Point(8, 64)
        Me.Viewer1.Name = "Viewer1"
        Me.Viewer1.ReportViewer.CurrentPage = 0
        Me.Viewer1.ReportViewer.MultiplePageCols = 3
        Me.Viewer1.ReportViewer.MultiplePageRows = 2
        Me.Viewer1.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.Viewer1.Size = New System.Drawing.Size(792, 472)
        Me.Viewer1.TabIndex = 116
        Me.Viewer1.TableOfContents.Text = "Table Of Contents"
        Me.Viewer1.TableOfContents.Width = 200
        Me.Viewer1.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(720, 10)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(40, 16)
        Me.RadioButton1.TabIndex = 117
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(720, 36)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(40, 16)
        Me.RadioButton2.TabIndex = 118
        '
        'RadioButton3
        '
        Me.RadioButton3.Location = New System.Drawing.Point(428, 7)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(16, 16)
        Me.RadioButton3.TabIndex = 119
        Me.RadioButton3.Text = "RadioButton3"
        '
        'RadioButton4
        '
        Me.RadioButton4.Location = New System.Drawing.Point(426, 32)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(32, 16)
        Me.RadioButton4.TabIndex = 120
        '
        'reptswia2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(800, 517)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Viewer1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.no_blagtxt)
        Me.Controls.Add(Me.car2_no)
        Me.Controls.Add(Me.blag_date)
        Me.Controls.Add(Me.insurecom_txt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Name = "reptswia2"
        Me.Text = "reptswia2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'SELECT * FROM tswiat where car2_no='" & car2_no.Text.Trim &
            Dim df As New SECURITY
            Dim _tmp As Cursor
            _tmp = Me.Cursor
            Me.Cursor = Cursors.WaitCursor
            Dim _rpt = New reptswia
            Dim _DS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource
            _DS.ConnectionString = "User ID= '" & sect & "';" & _
        "Password='" & pass & "';" & _
        "Initial Catalog=car2;" & _
        "Data Source=pc;" & _
        "Connection TimeOut=30;"
            '*******************************************************************
            If RadioButton1.Checked = True Then
                'and invoice_date between '" & DTPicker1.Value & "' and '" & DTPicker2.Value & "'
                Dim _sqlString As String = "Select * "
                _sqlString = _sqlString + " FROM tswiat"
                _sqlString = _sqlString + " WHERE   car2_no = '" & car2_no.Text.Trim & "'"
                '_sqlString = _sqlString + 62 + "'"
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS

            End If
            ''*********************************************************************
            If RadioButton2.Checked = True Then
                'and invoice_date between '" & DTPicker1.Value & "' and '" & DTPicker2.Value & "'
                Dim _sqlString As String = "Select * "
                _sqlString = _sqlString + " FROM tswiat"
                _sqlString = _sqlString + " WHERE  no_blag = '" & no_blagtxt.Text.Trim & "'"
                '_sqlString = _sqlString + 62 + "'"
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS
            End If
            '**************************************************************************

            If RadioButton3.Checked = True Then
                'and invoice_date between '" & DTPicker1.Value & "' and '" & DTPicker2.Value & "'
                Dim _sqlString As String = "Select * "
                _sqlString = _sqlString + " FROM tswiat"
                _sqlString = _sqlString + " WHERE  insurecom = '" & insurecom_txt.Text.Trim & "'"
                '_sqlString = _sqlString + 62 + "'"
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS
            End If

            '************************************************************


            If RadioButton4.Checked = True Then
                'and invoice_date between '" & DTPicker1.Value & "' and '" & DTPicker2.Value & "'
                Dim _sqlString As String = "Select * "
                _sqlString = _sqlString + " FROM tswiat"
                _sqlString = _sqlString + " WHERE  blag_date = '" & blag_date.Text.Trim & "'"
                '_sqlString = _sqlString + 62 + "'"
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS
            End If

            'If RadioButton2.Checked = True Then

            '    Dim _sqlString As String = "Select maintenance.car2_no,maintenance.maintenance_id, maintenance.apply_person,maintenance.apply_date,maintenance.main_req,maintenance.shop_report,maintenance.notes,car2_type.car2_name,car2_type.type_no"
            '    _sqlString = _sqlString + " FROM car2_type,maintenance"
            '    _sqlString = _sqlString + " WHERE maintenance.type_no = car2_type.type_no  AND maintenance.maintenance_id = '" & mentxt.Text.Trim & "'"
            '    '_sqlString = _sqlString + 62 + "'"
            '    _DS.SQL = _sqlString
            '    _rpt.DataSource = _DS
            'End If
            ''******************************************************************************
            Me.Viewer1.Document = _rpt.Document
            _rpt.Run(False)
            Me.Cursor = _tmp
        Catch ex As DataDynamics.ActiveReports.ReportException
            MessageBox.Show(Me, "Error fired while running the report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        no_blagtxt.Enabled = False
        car2_no.Enabled = True
        insurecom_txt.Enabled = False
        blag_date.Enabled = False
    End Sub

    Private Sub reptswia2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        no_blagtxt.Enabled = False
        car2_no.Enabled = False
        insurecom_txt.Enabled = False
        blag_date.Enabled = False
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        no_blagtxt.Enabled = True
        car2_no.Enabled = False
        insurecom_txt.Enabled = False
        blag_date.Enabled = False
    End Sub

    Private Sub RadioButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.Click
        no_blagtxt.Enabled = False
        car2_no.Enabled = False
        insurecom_txt.Enabled = True
        blag_date.Enabled = False
    End Sub

    Private Sub RadioButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.Click
        no_blagtxt.Enabled = False
        car2_no.Enabled = False
        insurecom_txt.Enabled = False
        blag_date.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
