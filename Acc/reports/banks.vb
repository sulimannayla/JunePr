Public Class banks
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
    Friend WithEvents dell As System.Windows.Forms.Button
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents add1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents site_name_txt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dell = New System.Windows.Forms.Button
        Me.search = New System.Windows.Forms.Button
        Me.edit = New System.Windows.Forms.Button
        Me.save = New System.Windows.Forms.Button
        Me.add1 = New System.Windows.Forms.Button
        Me.site_name_txt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dell
        '
        Me.dell.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dell.Location = New System.Drawing.Point(72, 141)
        Me.dell.Name = "dell"
        Me.dell.Size = New System.Drawing.Size(72, 32)
        Me.dell.TabIndex = 5
        Me.dell.Text = "Õ–›"
        '
        'search
        '
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.search.Location = New System.Drawing.Point(152, 141)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(72, 32)
        Me.search.TabIndex = 4
        Me.search.Text = "»ÕÀ"
        '
        'edit
        '
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.edit.Location = New System.Drawing.Point(232, 141)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(80, 32)
        Me.edit.TabIndex = 3
        Me.edit.Text = " ⁄œÌ·"
        '
        'save
        '
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.save.Location = New System.Drawing.Point(320, 141)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(88, 32)
        Me.save.TabIndex = 2
        Me.save.Text = "Õ›Ÿ"
        '
        'add1
        '
        Me.add1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.add1.Location = New System.Drawing.Point(416, 141)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(88, 32)
        Me.add1.TabIndex = 0
        Me.add1.Text = "ÃœÌœ"
        '
        'site_name_txt
        '
        Me.site_name_txt.BackColor = System.Drawing.Color.WhiteSmoke
        Me.site_name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.site_name_txt.Location = New System.Drawing.Point(88, 69)
        Me.site_name_txt.Name = "site_name_txt"
        Me.site_name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.site_name_txt.Size = New System.Drawing.Size(384, 20)
        Me.site_name_txt.TabIndex = 1
        Me.site_name_txt.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(476, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "«”‹‹‹„ «·»‰ﬂ"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(48, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(480, 64)
        Me.Label3.TabIndex = 82
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(408, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "ÃœÌœ"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(312, 141)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 80
        Me.Button2.Text = "Õ›Ÿ"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.Location = New System.Drawing.Point(296, 141)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 32)
        Me.Button3.TabIndex = 79
        Me.Button3.Text = "Õ›Ÿ"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.Location = New System.Drawing.Point(136, 141)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 32)
        Me.Button4.TabIndex = 83
        Me.Button4.Text = "»ÕÀ"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button5.Location = New System.Drawing.Point(216, 141)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 32)
        Me.Button5.TabIndex = 81
        Me.Button5.Text = " ⁄œÌ·"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button6.Location = New System.Drawing.Point(392, 141)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 32)
        Me.Button6.TabIndex = 78
        Me.Button6.Text = "ÃœÌœ"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Location = New System.Drawing.Point(16, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 200)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button7.Location = New System.Drawing.Point(232, 141)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 32)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = " ⁄œÌ·"
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button8.Location = New System.Drawing.Point(320, 141)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(88, 32)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "Õ›Ÿ"
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button9.Location = New System.Drawing.Point(416, 141)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(88, 32)
        Me.Button9.TabIndex = 0
        Me.Button9.Text = "ÃœÌœ"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(40, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(480, 64)
        Me.Label2.TabIndex = 82
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button10.Location = New System.Drawing.Point(312, 141)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(88, 32)
        Me.Button10.TabIndex = 3
        Me.Button10.Text = "Õ›Ÿ"
        '
        'Button11
        '
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button11.Location = New System.Drawing.Point(152, 149)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(72, 32)
        Me.Button11.TabIndex = 5
        Me.Button11.Text = "»ÕÀ"
        '
        'Button12
        '
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button12.Location = New System.Drawing.Point(224, 141)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(80, 32)
        Me.Button12.TabIndex = 4
        Me.Button12.Text = " ⁄œÌ·"
        '
        'Button13
        '
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button13.Location = New System.Drawing.Point(408, 141)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(88, 32)
        Me.Button13.TabIndex = 0
        Me.Button13.Text = "ÃœÌœ"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(40, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(480, 64)
        Me.Label4.TabIndex = 82
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGrid1.CaptionText = "fgfdgfdgfdgdf222"
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Font = New System.Drawing.Font("Simplified Arabic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGrid1.GridLineColor = System.Drawing.SystemColors.Highlight
        Me.DataGrid1.HeaderBackColor = System.Drawing.SystemColors.Desktop
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 229)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGrid1.Size = New System.Drawing.Size(584, 144)
        Me.DataGrid1.TabIndex = 86
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.GridLineColor = System.Drawing.SystemColors.Desktop
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.SystemColors.Desktop
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridTableStyle1.MappingName = ""
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "—ﬁ„ «·»‰ﬂ"
        Me.DataGridTextBoxColumn1.MappingName = "bank_id"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "«”„ «·»‰ﬂ"
        Me.DataGridTextBoxColumn2.MappingName = "bank_name"
        Me.DataGridTextBoxColumn2.Width = 250
        '
        'banks
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(608, 381)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.dell)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.add1)
        Me.Controls.Add(Me.site_name_txt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Label4)
        Me.Name = "banks"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "«·»‰‹‹‹Êﬂ"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        If Trim(site_name_txt.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        bt_save(edit, add1, save, search, dell)
        Dim cmdString As String = "INSERT INTO banks " + _
                           "(bank_name) " + _
                           "VALUES('" & site_name_txt.Text & "')"

        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("·ﬁœ  „ Õ›Ÿ «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        'cmd.ExecuteNonQuery()
        'Call num()
        Con.Close()



        edit.Enabled = False

        edit.Enabled = False
        Dim ADPt As SqlClient.SqlDataAdapter
        Dim cmd12 = "SELECT * FROM banks"
        Dim dt As New DataTable
        ADPt = New SqlClient.SqlDataAdapter(cmd12, Con)
        ADPt.Fill(dt)
        DataGrid1.DataSource = dt
        dell.Enabled = False
        'add1.Enabled = True
    End Sub

    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add1.Click
        bt_add1(edit, add1, save, search, dell)
        site_name_txt.Text = ""
        edit.Enabled = False
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click

        bt_edit(edit, add1, save, search, dell)
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim cmdString As String = "UPDATE banks " + _
                                            "SET bank_name = '" & site_name_txt.Text & "' " + _
                                            "WHERE bank_id = '" & id & "'"
        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("·ﬁœ  „  ⁄œÌ· «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
        edit.Enabled = False
        edit.Enabled = False
        Dim ADPt As SqlClient.SqlDataAdapter
        Dim cmd12 = "SELECT * FROM banks"
        Dim dt As New DataTable
        ADPt = New SqlClient.SqlDataAdapter(cmd12, Con)
        ADPt.Fill(dt)
        DataGrid1.DataSource = dt
        dell.Enabled = False
        'add1.Enabled = True
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        Dim DS As New DataSet
        Dim t As DataTable

        Dim message, title, defaultValue As String
        Dim m As Integer
        message = " «œŒ· «”„ «·»‰ﬂ «·„—«œ «·»ÕÀ ⁄‰Â "
        title = "»ÕÀ"
        site_name_txt.Text = InputBox(message, title, defaultValue, MsgBoxStyle.OKOnly)
        If Trim(site_name_txt.Text) = "" Then
            MsgBox("ÌÃ» «Œ Ì«— «·«”„  √Ê·«")
            edit.Enabled = False
            dell.Enabled = False
            Exit Sub
        End If
        Dim x As String
        Dim cmd2 As New SqlClient.SqlCommand("select * from banks WHERE bank_name = '" & site_name_txt.Text & "'", Con)
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count < 1 Then
            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «·«”„  :-" + "  " + site_name_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            site_name_txt.Text = ""
            edit.Enabled = False
            dell.Enabled = False
            Exit Sub
        End If
        'bt_search(edit, add1, save, search, dell)
        site_name_txt.Text = dt.Rows(0).Item("bank_name")
        Try
            'cmd2.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
        edit.Enabled = False
    End Sub

    Private Sub dell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dell.Click
        bt_dell(edit, add1, save, search, dell)
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim str As String
        str = MsgBox("·ﬁœ  —Ìœ Õ–› «·”Ã·   :-" + "  " + site_name_txt.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Information, " ‰»ÌÂ")
        If str = vbYes Then
            Dim cmd3 As New SqlClient.SqlCommand("DELETE FROM banks WHERE bank_id =  '" & id & "'", Con)

            Dim da3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd3)
            cmd3.ExecuteNonQuery()
        End If
        Try
            bt_add1(edit, add1, save, search, dell)
            site_name_txt.Text = ""

            MsgBox("·ﬁœ  „ Õ–› «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dell.Enabled = False
        edit.Enabled = False
        edit.Enabled = False
        Dim ADPt As SqlClient.SqlDataAdapter
        Dim cmd12 = "SELECT * FROM banks"
        Dim dt As New DataTable
        ADPt = New SqlClient.SqlDataAdapter(cmd12, Con)
        ADPt.Fill(dt)
        DataGrid1.DataSource = dt
        dell.Enabled = False
        'add1.Enabled = True
        Con.Close()
    End Sub
    Private Sub num()
        'If Con.State = ConnectionState.Broken = False Then
        '    Con.Close()
        'End If
        'Con.Open()
        'Dim DS As New DataSet
        'Dim t As DataTable
        'Dim cmd2 As New SqlClient.SqlCommand("select max(site_id) site_id from sites  ", Con)
        'Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        'dr.Read()
        'site_id_txt.Text = dr.Item("site_id")
        'dr.Close()
        'Try
        'Catch er As Exception
        '    MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√
        'End Try
        'Con.Close()
    End Sub
    Private Sub depet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        edit.Enabled = False
        Dim ADPt As SqlClient.SqlDataAdapter
        Dim cmd12 = "SELECT * FROM banks"
        Dim dt As New DataTable
        ADPt = New SqlClient.SqlDataAdapter(cmd12, Con)
        ADPt.Fill(dt)
        DataGrid1.DataSource = dt
        dell.Enabled = False
        add1.Enabled = True
    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)

    End Sub

    Private Sub DataGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim col As Int16 = DataGrid1.CurrentCell.ColumnNumber
        'Dim row As Int16 = DataGrid1.CurrentCell.RowNumber

        'Dim i As Integer
        ''i.GetType.IsValueType.ToString()
        'If IsNumeric(DataGrid1.Item(row, 0)) Then
        '    'MsgBox(DataGrid1.Item(row, 0))
        '    '===============================================
        '    If Con.State = ConnectionState.Broken = False Then
        '        Con.Close()
        '    End If
        '    Con.Open()
        '    Dim message, title, defaultValue As String
        '    Dim m As Integer
        '    Dim DS As New DataSet
        '    Dim t As DataTable
        '    Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM  sites where serial='" & DataGrid1.Item(row, 0) & "'", Con)
        '    Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        '    If dr.HasRows = False Then

        '        Exit Sub
        '    End If
        '    dr.Read()
        '    Dim c_oper As Integer = dr.Item("code_oper")

        '    If dr.HasRows = False Then

        '        Exit Sub
        '    End If
        '    bt_search(edit, add1, save, search, dell)
        '    'serial_txt.Text = dr.Item("serial")
        '    'jobe_no_txt.Text = dr.Item("jobe_no")
        '    'Technician_txt.Text = dr.Item("Technician")


        '    dr.Close()
        '    Dim DS7 As New DataSet
        '    Dim t7 As DataTable
        '    Dim s1 As String
        '    Dim cmd7 As New SqlClient.SqlCommand("select * from main_oper where code_oper='" & c_oper & "'", Con)
        '    Dim dr7 As SqlClient.SqlDataReader = cmd7.ExecuteReader()
        '    dr7.Read()
        '    'code_oper_txt.Text = dr7.Item("desc_oper")
        '    Con.Close()
        '    dr7.Close()
        '    Try
        '    Catch er As Exception
        '        MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√
        '    End Try

        '    '=============================================
        '    bt_search(edit, add1, save, search, dell)


        'End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DataGrid1_Navigate_1(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub DataGrid1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
        Dim col As Int16 = DataGrid1.CurrentCell.ColumnNumber
        Dim row As Int16 = DataGrid1.CurrentCell.RowNumber

        Dim i As Integer

        If IsNumeric(DataGrid1.Item(row, 0)) Then
            If Con.State = ConnectionState.Broken = False Then
                Con.Close()
            End If
            Con.Open()
            Dim message, title, defaultValue As String
            Dim m As Integer
            Dim DS As New DataSet
            Dim t As DataTable
            Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM  banks where bank_id='" & DataGrid1.Item(row, 0) & "'", Con)
            Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
            If dr.HasRows = False Then
                Exit Sub
            End If
            dr.Read()
            bt_search(edit, add1, save, search, dell)
            'id = ""
            id = dr.Item("bank_id")

            site_name_txt.Text = dr.Item("bank_name")

            dr.Close()
            edit.Enabled = True
            Try
            Catch er As Exception
                MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√
            End Try
            Con.Close()

        End If
    End Sub


    Private Sub site_name_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles site_name_txt.TextChanged

    End Sub

    Private Sub site_name_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles site_name_txt.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
