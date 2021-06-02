Public Class reportmantenance
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Viewer1 As DataDynamics.ActiveReports.Viewer.Viewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents apply_date_txt As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents mentxt As System.Windows.Forms.TextBox
    Friend WithEvents car2_notxt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Viewer1 = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.car2_notxt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.apply_date_txt = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.mentxt = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Miriam Fixed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button1.Location = New System.Drawing.Point(144, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "⁄—÷ «· ﬁ—Ì—"
        '
        'Viewer1
        '
        Me.Viewer1.BackColor = System.Drawing.SystemColors.Control
        Me.Viewer1.Location = New System.Drawing.Point(0, 96)
        Me.Viewer1.Name = "Viewer1"
        Me.Viewer1.ReportViewer.CurrentPage = 0
        Me.Viewer1.ReportViewer.MultiplePageCols = 3
        Me.Viewer1.ReportViewer.MultiplePageRows = 2
        Me.Viewer1.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.Viewer1.Size = New System.Drawing.Size(776, 464)
        Me.Viewer1.TabIndex = 1
        Me.Viewer1.TableOfContents.Text = "Table Of Contents"
        Me.Viewer1.TableOfContents.Width = 200
        Me.Viewer1.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'car2_notxt
        '
        Me.car2_notxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.car2_notxt.Location = New System.Drawing.Point(488, 12)
        Me.car2_notxt.Name = "car2_notxt"
        Me.car2_notxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.car2_notxt.Size = New System.Drawing.Size(128, 20)
        Me.car2_notxt.TabIndex = 2
        Me.car2_notxt.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(624, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "—ﬁ„ «·⁄—»…"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(704, 14)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(32, 24)
        Me.RadioButton1.TabIndex = 4
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(272, 12)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(48, 16)
        Me.RadioButton2.TabIndex = 5
        '
        'apply_date_txt
        '
        Me.apply_date_txt.CustomFormat = "yyyy/MM/dd"
        Me.apply_date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.apply_date_txt.Location = New System.Drawing.Point(224, 48)
        Me.apply_date_txt.Name = "apply_date_txt"
        Me.apply_date_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.apply_date_txt.Size = New System.Drawing.Size(96, 20)
        Me.apply_date_txt.TabIndex = 29
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(441, 48)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(192, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 24)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "≈·Ì"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 24)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "„‰"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.apply_date_txt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(352, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 88)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(191, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 24)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "—ﬁ„ «·’Ì«‰…"
        '
        'mentxt
        '
        Me.mentxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mentxt.Location = New System.Drawing.Point(67, 8)
        Me.mentxt.Name = "mentxt"
        Me.mentxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mentxt.Size = New System.Drawing.Size(120, 20)
        Me.mentxt.TabIndex = 35
        Me.mentxt.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(48, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 24)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "≈‰Â‹‹‹‹«¡"
        '
        'reportmantenance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(776, 557)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.mentxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.car2_notxt)
        Me.Controls.Add(Me.Viewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "reportmantenance"
        Me.Text = " ﬁ—Ì— «·’Ì«‰…"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub reportmantenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        car2_notxt.Enabled = False
        apply_date_txt.Enabled = False
        DateTimePicker1.Enabled = False
        mentxt.Enabled = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
        '*******************************************************************
        If RadioButton1.Checked = True Then
            Dim _sqlString As String = "Select maintenance.chec1,maintenance.chec2,maintenance.car2_no,maintenance.maintenance_id, maintenance.apply_person,maintenance.apply_date,maintenance.main_req,maintenance.shop_report,maintenance.notes,car2_type.car2_name,car2_type.type_no"
            _sqlString = _sqlString + " FROM car2_type,maintenance"
            _sqlString = _sqlString + " WHERE maintenance.type_no = car2_type.type_no and  maintenance.apply_date between '" & apply_date_txt.Text & "' and '" & DateTimePicker1.Text & "'  AND maintenance.car2_no = '" & car2_notxt.Text.Trim & "'"
            _DS.SQL = _sqlString
            _rpt.DataSource = _DS
        End If
        '*********************************************************************
        If RadioButton2.Checked = True Then
            Dim _sqlString As String = "Select maintenance.chec1,maintenance.chec2,maintenance.car2_no,maintenance.maintenance_id, maintenance.apply_person,maintenance.apply_date,maintenance.main_req,maintenance.shop_report,maintenance.notes,car2_type.car2_name,car2_type.type_no"
            _sqlString = _sqlString + " FROM car2_type,maintenance"
            _sqlString = _sqlString + " WHERE maintenance.type_no = car2_type.type_no  AND maintenance.maintenance_id = '" & mentxt.Text.Trim & "'"
            '_sqlString = _sqlString + 62 + "'"
            _DS.SQL = _sqlString
            _rpt.DataSource = _DS
        End If
        '******************************************************************************
        Me.Viewer1.Document = _rpt.Document
        _rpt.Run(False)
        Me.Cursor = _tmp
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        car2_notxt.Enabled = True
        apply_date_txt.Enabled = True
        DateTimePicker1.Enabled = True
        mentxt.Enabled = False
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        mentxt.Enabled = True
        car2_notxt.Enabled = False
        apply_date_txt.Enabled = False
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
