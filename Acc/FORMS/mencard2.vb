Public Class mencar2d2
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents car2_n0_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents apply_date_txt As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Viewer1 = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.car2_n0_txt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.apply_date_txt = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Viewer1
        '
        Me.Viewer1.BackColor = System.Drawing.SystemColors.Control
        Me.Viewer1.Location = New System.Drawing.Point(0, 72)
        Me.Viewer1.Name = "Viewer1"
        Me.Viewer1.ReportViewer.CurrentPage = 0
        Me.Viewer1.ReportViewer.MultiplePageCols = 3
        Me.Viewer1.ReportViewer.MultiplePageRows = 2
        Me.Viewer1.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.Viewer1.Size = New System.Drawing.Size(768, 464)
        Me.Viewer1.TabIndex = 0
        Me.Viewer1.TableOfContents.Text = "Table Of Contents"
        Me.Viewer1.TableOfContents.Width = 200
        Me.Viewer1.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(656, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "—ﬁ„ «·⁄—»…"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(608, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "⁄—÷ «· ﬁ—Ì—"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(448, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 24)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Œ‹‹‹‹‹‹‹‹—ÊÃ"
        '
        'car2_n0_txt
        '
        Me.car2_n0_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.car2_n0_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.car2_n0_txt.ForeColor = System.Drawing.Color.Black
        Me.car2_n0_txt.Location = New System.Drawing.Point(512, 8)
        Me.car2_n0_txt.Name = "car2_n0_txt"
        Me.car2_n0_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.car2_n0_txt.Size = New System.Drawing.Size(136, 20)
        Me.car2_n0_txt.TabIndex = 18
        Me.car2_n0_txt.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 24)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "≈·Ì"
        '
        'apply_date_txt
        '
        Me.apply_date_txt.CustomFormat = "yyyy/MM/dd"
        Me.apply_date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.apply_date_txt.Location = New System.Drawing.Point(192, 24)
        Me.apply_date_txt.Name = "apply_date_txt"
        Me.apply_date_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.apply_date_txt.Size = New System.Drawing.Size(96, 20)
        Me.apply_date_txt.TabIndex = 33
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(48, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 48)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Simplified Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(272, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 24)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "„‰ «·› —…"
        '
        'mencar2d2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(768, 533)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.apply_date_txt)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.car2_n0_txt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Viewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "mencar2d2"
        Me.Text = "mencar2d2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim df As New SECURITY
            Dim _tmp As Cursor
            _tmp = Me.Cursor
            Me.Cursor = Cursors.WaitCursor
            Dim _rpt = New ActiveReport2
            Dim _DS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource
            _DS.ConnectionString = "User ID= '" & sect & "';" & _
            "Password='" & pass & "';" & _
            "Initial Catalog=car2;" & _
           "Data Source=pc;" & _
            "Connection TimeOut=30;"
            ''''maintenance.car2_no = car2_data.car2_no And maintenance.type_no = car2_type.type_no And maintenance.maintenance_id = invoice.maintenance_id And parts.invoice_no = invoice.invoice_no
            ''''Dim _sqlString As String = "maintenance.menmsdg,parts.part_name,car2_type.car2_name,parts.quntety,parts.totel,car2_data.car2_owner,invoice.car2_no"
            ''''_sqlString = _sqlString + "FROM parts,invoice,maintenance,car2_data,car2_type"
            ''''_sqlString = _sqlString + " WHERE maintenance.car2_no = car2_data.car2_no AND maintenance.type_no = car2_type.type_no AND maintenance.maintenance_id = invoice.maintenance_id AND parts.invoice_no =invoice.invoice_no"
            ''''_sqlString = _sqlString + 62 + "'"
            ''''_DS.SQL = _sqlString
            ''''_rpt.DataSource = _DS
            '******************************************************
            'Dim _sqlString As String = " *"
            '_sqlString = _sqlString + " FROM invoice, parts"
            ''_sqlString = _sqlString + " WHERE invoice.invoice_no = parts.invoice_no AND invoice.car2_no =  '" & 12 & "';"
            ''_sqlString = _sqlString + 62 + "'"
            '_DS.SQL = _sqlString
            '_rpt.DataSource = _DS
            '******************************************************************
            If CheckBox1.Checked = True Then
                Dim _sqlString1 As String = "Select invoice.namemesdg, parts.part_name,invoice.date,invoice.invoice_no, car2_type.car2_name, parts.quntety, parts.totel, car2_data.car2_owner, invoice.car2_no"
                _sqlString1 = _sqlString1 + " FROM parts, invoice, maintenance, car2_data, car2_type"
                _sqlString1 = _sqlString1 + " WHERE maintenance.car2_no = car2_data.car2_no and  invoice.date between '" & apply_date_txt.Text & "' and '" & DateTimePicker1.Text & "' AND maintenance.type_no = car2_type.type_no AND  maintenance.maintenance_id = invoice.maintenance_id AND parts.invoice_no = invoice.invoice_no AND invoice.car2_no = '" & car2_n0_txt.Text & "' order by invoice.invoice_no"
                '_sqlString = _sqlString + 62 + "'"
                _DS.SQL = _sqlString1
                _rpt.DataSource = _DS
            End If
            '**********************************************************************
            If CheckBox1.Checked = False Then
                Dim _sqlString As String = "Select invoice.namemesdg, parts.part_name,invoice.date,invoice.invoice_no, car2_type.car2_name, parts.quntety, parts.totel, car2_data.car2_owner, invoice.car2_no"
                _sqlString = _sqlString + " FROM parts, invoice, maintenance, car2_data, car2_type"
                _sqlString = _sqlString + " WHERE maintenance.car2_no = car2_data.car2_no AND maintenance.type_no = car2_type.type_no AND  maintenance.maintenance_id = invoice.maintenance_id AND parts.invoice_no = invoice.invoice_no AND invoice.car2_no = '" & car2_n0_txt.Text & "' order by invoice.invoice_no"
                '_sqlString = _sqlString + 62 + "'"
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS
                '******************************************************************************
            End If
            Me.Viewer1.Document = _rpt.Document
            _rpt.Run(False)
            Me.Cursor = _tmp
        Catch ex As DataDynamics.ActiveReports.ReportException
            MessageBox.Show(Me, "Error fired while running the report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mencar2d2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        apply_date_txt.Enabled = False
        DateTimePicker1.Enabled = False

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'apply_date_txt.Enabled = False
        'DateTimePicker1.Enabled = False

    End Sub

    Private Sub CheckBox1_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckStateChanged
        If CheckBox1.Checked = True Then
            apply_date_txt.Enabled = True
            DateTimePicker1.Enabled = True
        Else
            apply_date_txt.Enabled = False
            DateTimePicker1.Enabled = False
        End If

    End Sub

    Private Sub CheckBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        'apply_date_txt.Enabled = True
        'DateTimePicker1.Enabled = True
    End Sub
End Class
