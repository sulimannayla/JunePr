Public Class viwe_est_bdl
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents class_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents date_1 As System.Windows.Forms.ComboBox
    Friend WithEvents est_name_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents site_txt As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Viewer1 = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.class_txt = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.date_1 = New System.Windows.Forms.ComboBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.site_txt = New System.Windows.Forms.ComboBox
        Me.est_name_txt = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Viewer1
        '
        Me.Viewer1.BackColor = System.Drawing.SystemColors.Control
        Me.Viewer1.Location = New System.Drawing.Point(0, 104)
        Me.Viewer1.Name = "Viewer1"
        Me.Viewer1.ReportViewer.CurrentPage = 0
        Me.Viewer1.ReportViewer.MultiplePageCols = 3
        Me.Viewer1.ReportViewer.MultiplePageRows = 2
        Me.Viewer1.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.Viewer1.Size = New System.Drawing.Size(992, 568)
        Me.Viewer1.TabIndex = 0
        Me.Viewer1.TableOfContents.Text = "Table Of Contents"
        Me.Viewer1.TableOfContents.Width = 200
        Me.Viewer1.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Simplified Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(728, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 32)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "⁄—÷ «· ﬁ—Ì—"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Font = New System.Drawing.Font("Simplified Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(552, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 32)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Œ‹‹‹‹‹‹‹‹—ÊÃ"
        '
        'class_txt
        '
        Me.class_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.class_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.class_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.class_txt.Location = New System.Drawing.Point(392, 16)
        Me.class_txt.Name = "class_txt"
        Me.class_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.class_txt.Size = New System.Drawing.Size(232, 24)
        Me.class_txt.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(624, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 24)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "«· ’‰Ì›"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.date_1)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(976, 104)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.DarkGray
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(472, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 24)
        Me.Label9.TabIndex = 784
        Me.Label9.Text = "«· «—ÌŒ"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(352, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 26)
        Me.DateTimePicker1.TabIndex = 783
        Me.DateTimePicker1.Value = New Date(2020, 9, 7, 0, 0, 0, 0)
        '
        'date_1
        '
        Me.date_1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.date_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.date_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.date_1.Items.AddRange(New Object() {"Ì‰«Ì—", "›»—«Ì—", "„«—”", "«»—Ì·", "„«ÌÊ", "ÌÊ‰ÌÊ", "ÌÊ·ÌÊ", "√€”ÿ”", "”» „»—", "√ﬂ Ê»—", "‰Ê›„»—", "œÌ”„»—"})
        Me.date_1.Location = New System.Drawing.Point(16, 24)
        Me.date_1.Name = "date_1"
        Me.date_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.date_1.Size = New System.Drawing.Size(88, 24)
        Me.date_1.TabIndex = 8
        '
        'RadioButton1
        '
        Me.RadioButton1.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.RadioButton1.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.RadioButton1.Location = New System.Drawing.Point(32, -128)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton1.Size = New System.Drawing.Size(96, 59)
        Me.RadioButton1.TabIndex = 131
        Me.RadioButton1.Text = "ﬁ«∆„…"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.site_txt)
        Me.GroupBox2.Controls.Add(Me.est_name_txt)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.class_txt)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(960, 48)
        Me.GroupBox2.TabIndex = 141
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(912, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 24)
        Me.Label3.TabIndex = 800
        Me.Label3.Text = "«·„Êﬁ⁄"
        '
        'site_txt
        '
        Me.site_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.site_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.site_txt.Location = New System.Drawing.Point(680, 16)
        Me.site_txt.Name = "site_txt"
        Me.site_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.site_txt.Size = New System.Drawing.Size(224, 28)
        Me.site_txt.TabIndex = 799
        '
        'est_name_txt
        '
        Me.est_name_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.est_name_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.est_name_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.est_name_txt.Location = New System.Drawing.Point(144, 16)
        Me.est_name_txt.Name = "est_name_txt"
        Me.est_name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.est_name_txt.Size = New System.Drawing.Size(160, 24)
        Me.est_name_txt.TabIndex = 140
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DarkGray
        Me.Label8.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(304, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 28)
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "«”„ «·«” ﬁÿ«⁄"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(96, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 24)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "«·‘Â—"
        '
        'viwe_est_bdl
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(992, 674)
        Me.Controls.Add(Me.Viewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "viwe_est_bdl"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "—∆«”… «·ÃÂ«“ «·ﬁ÷«∆Ï Ê·«Ì… «·Ã“Ì“…- ﬁ«∆„… «·«” ﬁÿ«⁄« "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Exit Sub
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        ' 'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX 

        '***************************** ÕœÌœ  —ﬁ„ «·„Êﬁ⁄
        Dim cmd51s As New SqlClient.SqlCommand("SELECT site_id FROM sites where site_name ='" & site_txt.Text & "'", Con)
        Dim dr51s As SqlClient.SqlDataReader = cmd51s.ExecuteReader()
        dr51s.Read()
        Dim site_id As Integer = dr51s.Item("site_id")
        dr51s.Close()

        '***************************** ÕœÌœ —ﬁ„ «· ’‰Ì› 
        Dim cmd51 As New SqlClient.SqlCommand("SELECT class_id FROM classes where class_name ='" & class_txt.Text & "'", Con)
        Dim dr51 As SqlClient.SqlDataReader = cmd51.ExecuteReader()
        dr51.Read()
        Dim class_id As String = dr51.Item("class_id")
        dr51.Close()

        Dim i, k As Integer
        Dim df As New SECURITY
        Dim _tmp As Cursor
        _tmp = Me.Cursor
        Me.Cursor = Cursors.WaitCursor
        Dim _rpt = New EstNameRep 'repestname

        Dim _DS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource
        _DS.ConnectionString = "User ID= '" & df.UserID.Text & "';" & _
        "Password='" & df.Password.Text & "';" & _
        "Initial Catalog=accoun;" & _
       "Data Source=main2;" & _
        "Connection TimeOut=30;"
        '**********************************************************
        If (site_txt.Text.Trim) = "" Or (class_txt.Text.Trim) = "" Or (est_name_txt.Text.Trim) = "" Or (date_1.Text.Trim) = "" Then
            MsgBox("·«»œ „‰  ÕœÌœ «·„Êﬁ⁄ Ê«· ’‰Ì› Ê«·«” ﬁÿ«⁄ Ê«·‘Â— ", MsgBoxStyle.Information + vbMsgBoxRight, "—∆«”… «·ÃÂ«“ «·ﬁ÷«∆Ï «·Ã“Ì—…... «·”‹‹‹‹œ«œ")
            Exit Sub
        End If
        '**********************************************************
        month_est = date_1.Text
        clas_name = " ’‰Ì›" + "/" + class_txt.Text
        clas_name1 = "·‘Â— " + " " + date_1.Text
        clas_name2 = site_txt.Text
        datshake = DateTimePicker1.Text
        Dim _sqlString As String = "SELECT employees.emp_name emp_name, archief.con_est_name est_ok_name, archief.con_est_val est_ok_val FROM archief,employees,classes where  archief.site_id = employees.site_id and archief.emp_id = employees.emp_id and  employees.stop_flag=2 and classes.class_name='" & class_txt.Text & "'  and employees.class_id=classes.class_id and archief.class_id=classes.class_id and employees.class_id=archief.class_id and   (archief.con_est_name = '" & est_name_txt.Text & "'  ) and archief.eyer='" & EYER & "' and archief.date_='" & date_1.Text & "' and archief.site_id='" & site_id & "'  union SELECT employees.emp_name emp_name, archief.est_ok_name est_ok_name, archief.est_ok_val est_ok_val FROM archief,employees,classes where archief.emp_id = employees.emp_id and  employees.stop_flag=2 and classes.class_name='" & class_txt.Text & "'  and employees.class_id=classes.class_id and archief.class_id=classes.class_id and employees.class_id=archief.class_id and   (archief.est_ok_name = '" & est_name_txt.Text & "'  ) and archief.eyer='" & EYER & "' and archief.site_id='" & site_id & "' and archief.date_='" & date_1.Text & "'"

        _DS.SQL = _sqlString
        _rpt.DataSource = _DS
        Me.Viewer1.Document = _rpt.Document
        _rpt.Run(False)
        Me.Cursor = _tmp
    End Sub

    Private Sub mencard2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        '==============================

        Dim DS01 As New DataSet
        Dim str01 As String = "SELECT DISTINCT  site_name  FROM sites"
        Dim ADP01 As New SqlClient.SqlDataAdapter(str01, Con)
        ADP01.Fill(DS01)
        Dim j As Integer
        For j = 0 To DS01.Tables(0).Rows.Count - 1
            Me.site_txt.Items.Add(DS01.Tables(0).Rows(j).Item(0))
        Next
        ADP01.Dispose()

        '==============================
        Dim DS02 As New DataSet
        Dim str02 As String = "SELECT DISTINCT  classes.class_name  FROM classes "
        Dim ADP02 As New SqlClient.SqlDataAdapter(str02, Con)
        ADP02.Fill(DS02)
        Dim k As Integer
        For k = 0 To DS02.Tables(0).Rows.Count - 1
            Me.class_txt.Items.Add(DS02.Tables(0).Rows(k).Item(0))
        Next
        ADP02.Dispose()
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()

        '----------------------------------------------------------------------

        Dim DS As New DataSet
        Dim str As String = "SELECT DISTINCT  name  FROM base_bdl where est_akh='" & tru & "' or est_cons='" & tru & "' or est_not_con='" & tru & "' union (select '«· Õ”Ì‰' as name)union(select '«·„⁄«‘' as name) order by name  "
        Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        ADP.Fill(DS)
        Dim i As Integer
        For i = 0 To DS.Tables(0).Rows.Count - 1
            Me.est_name_txt.Items.Add(DS.Tables(0).Rows(i).Item(0))
        Next
        ADP.Dispose()
        '--------------------------------------------------------------------------------
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
    End Sub

    Private Sub site_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub date__KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles date_1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub class_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles class_txt.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
