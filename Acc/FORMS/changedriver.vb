Public Class changedriver
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents car2_n0_txt As System.Windows.Forms.TextBox
    Friend WithEvents nametxt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Viewer1 = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.car2_n0_txt = New System.Windows.Forms.TextBox
        Me.nametxt = New System.Windows.Forms.TextBox
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
        Me.Viewer1.Size = New System.Drawing.Size(808, 528)
        Me.Viewer1.TabIndex = 25
        Me.Viewer1.TableOfContents.Text = "Table Of Contents"
        Me.Viewer1.TableOfContents.Width = 200
        Me.Viewer1.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Location = New System.Drawing.Point(32, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 24)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Œ‹‹‹‹‹‹‹—ÊÃ"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.Location = New System.Drawing.Point(144, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 24)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "⁄‹—÷ «· ﬁ—Ì‹—"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Simplified Arabic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(576, 29)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(160, 24)
        Me.RadioButton2.TabIndex = 29
        Me.RadioButton2.Text = "«·»Õ‹À »«·«”‹‹„"
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Simplified Arabic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(576, 0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(152, 24)
        Me.RadioButton1.TabIndex = 28
        Me.RadioButton1.Text = "«·»ÕÀ »—ﬁ„ «·⁄—»…"
        '
        'car2_n0_txt
        '
        Me.car2_n0_txt.Location = New System.Drawing.Point(440, 8)
        Me.car2_n0_txt.Name = "car2_n0_txt"
        Me.car2_n0_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.car2_n0_txt.Size = New System.Drawing.Size(128, 20)
        Me.car2_n0_txt.TabIndex = 27
        Me.car2_n0_txt.Text = ""
        '
        'nametxt
        '
        Me.nametxt.Location = New System.Drawing.Point(328, 32)
        Me.nametxt.Name = "nametxt"
        Me.nametxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.nametxt.Size = New System.Drawing.Size(240, 20)
        Me.nametxt.TabIndex = 26
        Me.nametxt.Text = ""
        '
        'changedriver
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(804, 581)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.car2_n0_txt)
        Me.Controls.Add(Me.nametxt)
        Me.Controls.Add(Me.Viewer1)
        Me.Name = "changedriver"
        Me.Text = "changedriver"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim str As New changename
        'str.
        'classfication()
        Dim df As New SECURITY
        Try
            Dim _tmp As Cursor
            _tmp = Me.Cursor
            Me.Cursor = Cursors.WaitCursor
            Dim _rpt = New changename
            Dim _DS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource
            _DS.ConnectionString = "User ID= '" & sect & "';" & _
        "Password='" & pass & "';" & _
        "Initial Catalog=car2;" & _
        "Data Source=pc;" & _
        "Connection TimeOut=30;"
            If Con.State = ConnectionState.Broken = False Then
                Con.Close()
            End If

            Con.Open()
            '****************************************
            Dim dt1 As New DataTable
            Dim Cmd1 As New SqlClient.SqlCommand("SELECT * FROM chngename where  name like '" & nametxt.Text & "'+'%'", Con)
            'Dim Cmd1 As New SqlClient.SqlCommand("SELECT * FROM chngename where car2_no='" & car2_no_txt.Text.Trim & "'", Con)
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd1)
            da1.Fill(dt1)
            Cmd1.ExecuteNonQuery()
            '***********************************************************************
            If dt1.Rows.Count < 1 Then
                MsgBox("·«ÌÊÃœ «·«”„  :-" + "  " + nametxt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                nametxt.Text = ""
                Exit Sub
            End If
            Dim txt As String = dt1.Rows(0).Item("classfi")
            'TextBox.Text = classfication
           
            If RadioButton1.Checked = True Then
                Dim _sqlString As String = "Select * "
                _sqlString = _sqlString + " FROM chngename,calsstype"
                _sqlString = _sqlString + " WHERE chngename.classfi=calsstype.classnum and car2_no= '" & car2_n0_txt.Text & "'"
                '_sqlString = _sqlString + 62 + "'"
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS
            End If
            '***************************************************************************
            If RadioButton2.Checked = True Then
                car2_n0_txt.Enabled = False
                nametxt.Enabled = True
                Dim _sqlString As String = "Select *"
                _sqlString = _sqlString + " FROM calsstype,chngename"
                _sqlString = _sqlString + " WHERE chngename.classfi=calsstype.classnum  and name like '" & nametxt.Text & "'+'%'"
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS
            End If
            'If txt = True Then
            '    RadioButton1.Checked = True
            '    RadioButton2.Checked = False
            'End If
            'If txt = False Then
            '    RadioButton2.Checked = True
            '    RadioButton1.Checked = False
            'End If
            Me.Viewer1.Document = _rpt.Document
            _rpt.Run(False)
            Me.Cursor = _tmp
        Catch ex As DataDynamics.ActiveReports.ReportException
            MessageBox.Show(Me, "Error fired while running the report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'Dim fff As New changename
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub changedriver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'If Con.State = ConnectionState.Broken = False Then
        '    Con.Close()
        'End If


        'Dim df As New SECURITY
        'Dim user As String = df.UserID.Text
        'Dim password1 As String = df.Password.Text
        'Dim lsPassword, lsUserId As String
        'Con.ConnectionString = "User ID= '" & sect & "';" & _
        '"Password='" & pass & "';" & _
        '"Initial Catalog=car2;" & _
        '"Data Source=pc;" & _
        '"Connection TimeOut=30;"

        ''Con.Open()



        car2_n0_txt.Enabled = False
        nametxt.Enabled = False
    End Sub

    Private Sub Viewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Viewer1.Load

    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        car2_n0_txt.Enabled = True
        nametxt.Enabled = False
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        car2_n0_txt.Enabled = False
        nametxt.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
