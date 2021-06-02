Public Class changename1
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
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents dell As System.Windows.Forms.Button
    Friend WithEvents add1 As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nametxt As System.Windows.Forms.TextBox
    Friend WithEvents notetxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents car2_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents dat_txt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents notxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.dell = New System.Windows.Forms.Button
        Me.add1 = New System.Windows.Forms.Button
        Me.save = New System.Windows.Forms.Button
        Me.edit = New System.Windows.Forms.Button
        Me.search = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.nametxt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.notetxt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.car2_no_txt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dat_txt = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.notxt = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Simplified Arabic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(256, 160)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(152, 24)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.Text = "„Œ’’… ·Â «·⁄—»…"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Simplified Arabic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(88, 160)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(152, 32)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "”«∆‹‹‹‹ﬁ ··⁄—»… "
        '
        'dell
        '
        Me.dell.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dell.Location = New System.Drawing.Point(56, 328)
        Me.dell.Name = "dell"
        Me.dell.Size = New System.Drawing.Size(72, 32)
        Me.dell.TabIndex = 8
        Me.dell.Text = "Õ–›"
        '
        'add1
        '
        Me.add1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.add1.Location = New System.Drawing.Point(384, 328)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(72, 32)
        Me.add1.TabIndex = 5
        Me.add1.Text = "ÃœÌœ"
        '
        'save
        '
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.save.Location = New System.Drawing.Point(304, 328)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(72, 32)
        Me.save.TabIndex = 4
        Me.save.Text = "Õ›Ÿ"
        '
        'edit
        '
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.edit.Location = New System.Drawing.Point(144, 328)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(72, 32)
        Me.edit.TabIndex = 7
        Me.edit.Text = " ⁄œÌ·"
        '
        'search
        '
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.search.Location = New System.Drawing.Point(224, 328)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(72, 32)
        Me.search.TabIndex = 6
        Me.search.Text = "»ÕÀ"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Location = New System.Drawing.Point(24, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(456, 64)
        Me.Label9.TabIndex = 77
        '
        'nametxt
        '
        Me.nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nametxt.Location = New System.Drawing.Point(80, 128)
        Me.nametxt.Name = "nametxt"
        Me.nametxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.nametxt.Size = New System.Drawing.Size(320, 20)
        Me.nametxt.TabIndex = 1
        Me.nametxt.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(416, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "«·«”‹‹‹‹„"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Andalus", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(528, 56)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = " ⁄œÌ· »Ì«‰«  «·⁄—»… «·”«∆ﬁ «Ê «·‘Œ’ «·„Œ’’ ·Â"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'notetxt
        '
        Me.notetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.notetxt.Location = New System.Drawing.Point(80, 232)
        Me.notetxt.Multiline = True
        Me.notetxt.Name = "notetxt"
        Me.notetxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.notetxt.Size = New System.Drawing.Size(320, 48)
        Me.notetxt.TabIndex = 3
        Me.notetxt.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(408, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "„·«ÕŸ‹‹‹« "
        '
        'car2_no_txt
        '
        Me.car2_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.car2_no_txt.Location = New System.Drawing.Point(256, 96)
        Me.car2_no_txt.Name = "car2_no_txt"
        Me.car2_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.car2_no_txt.Size = New System.Drawing.Size(144, 20)
        Me.car2_no_txt.TabIndex = 0
        Me.car2_no_txt.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(408, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 24)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "—ﬁ‹‹„ «·⁄—»…"
        '
        'dat_txt
        '
        Me.dat_txt.CustomFormat = "yyyy/MM/dd"
        Me.dat_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dat_txt.Location = New System.Drawing.Point(280, 192)
        Me.dat_txt.Name = "dat_txt"
        Me.dat_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dat_txt.Size = New System.Drawing.Size(112, 20)
        Me.dat_txt.TabIndex = 85
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(408, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 24)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "«· ‹‹‹«—ÌŒ"
        '
        'notxt
        '
        Me.notxt.BackColor = System.Drawing.SystemColors.HighlightText
        Me.notxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.notxt.Enabled = False
        Me.notxt.Location = New System.Drawing.Point(288, 64)
        Me.notxt.Name = "notxt"
        Me.notxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.notxt.Size = New System.Drawing.Size(112, 20)
        Me.notxt.TabIndex = 87
        Me.notxt.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(416, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "„ ”‹·”‹·"
        '
        'changename1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(528, 405)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.notxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dat_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.car2_no_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.notetxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nametxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dell)
        Me.Controls.Add(Me.add1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Name = "changename1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " ⁄œÌ· »Ì«‰«  «·⁄—»… «·”«∆ﬁ «Ê «·‘Œ’ «·„Œ’’ ·Â"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add1.Click
        notxt.Text = ""
        car2_no_txt.Text = ""
        nametxt.Text = ""
        notetxt.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        bt_add1(edit, add1, save, search, dell)
    End Sub
    Private Sub num()
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim DS As New DataSet
        Dim t As DataTable
        Dim cmd2 As New SqlClient.SqlCommand("select max(no) no from chngename  ", Con)
        Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        dr.Read()
        notxt.Text = dr.Item("no")
        dr.Close()
        Try
        Catch er As Exception
            MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√
        End Try
        Con.Close()
    End Sub
    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If car2_no_txt.Text = "" Or nametxt.Text = "" Then
            MsgBox("√ﬂ„· ≈œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim Cmd1 As New SqlClient.SqlCommand("SELECT * FROM car2_DATA where car2_NO='" & car2_no_txt.Text & "'", Con)
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd1)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count < 1 Then
            MsgBox("·«  ÊÃœ ⁄—»…  Õ„· «·—ﬁ„ «·„œŒ· :-" + "  " + car2_no_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            Exit Sub
        End If
        '***********************************************************************************************
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("Õœœ «–«ﬂ«‰ ”«∆ﬁ √Ê „Œ’’… ·Â «·⁄—»…")
            Exit Sub
        End If
        Dim chec, drivern, onern As String
        If RadioButton1.Checked = True Then
            '„Œ’’… ·Â «·⁄—»…
            chec = 1
            onern = dt.Rows(0).Item("car2_owner")
            Dim cmdString As String = "INSERT INTO chngename " + _
                                              "(car2_no,name,classfi,note,dat) " + _
                                              "VALUES('" & car2_no_txt.Text.Trim & "','" & onern & "','" & chec.Trim & "','" & notetxt.Text.Trim & "','" & dat_txt.Text & "')"
            Dim cmd3 As New SqlClient.SqlCommand(cmdString, Con)
            cmd3.ExecuteNonQuery()
            Dim cmdString1 As String = "UPDATE car2_data " + _
                                               "SET car2_owner= '" & nametxt.Text & "' " + _
                                               "WHERE car2_no = '" & car2_no_txt.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(cmdString1, Con)
            'MsgBox("well22")
            cmd.ExecuteNonQuery()
            Try
                'cmd.ExecuteNonQuery()
                MsgBox("·ﬁœ  „ Õ›Ÿ «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            'Con.Close()
        Else
            '”«∆ﬁ
            chec = 0
            drivern = dt.Rows(0).Item("driver")
            Dim cmdString As String = "INSERT INTO chngename " + _
                                              "(car2_no,name,classfi,note,dat) " + _
                                              "VALUES('" & car2_no_txt.Text.Trim & "','" & drivern & "','" & chec.Trim & "','" & notetxt.Text.Trim & "','" & dat_txt.Text & "')"
            Dim cmd3 As New SqlClient.SqlCommand(cmdString, Con)
            cmd3.ExecuteNonQuery()
            Dim cmdString1 As String = "UPDATE car2_data " + _
                                                           "SET driver= '" & nametxt.Text & "' " + _
                                                           "WHERE car2_no = '" & car2_no_txt.Text & "'"
            Dim cmd As New SqlClient.SqlCommand(cmdString1, Con)
            'MsgBox("well22")
            cmd.ExecuteNonQuery()
            Con.Close()
            Call num()
            Try
                'cmd.ExecuteNonQuery()
                MsgBox("·ﬁœ  „ Õ›Ÿ «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            'Con.Close()
        End If

        bt_save(edit, add1, save, search, dell)
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        Dim txtc As New Boolean
        Dim o, d As String
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim dt1 As New DataTable
        Dim dt5 As New DataTable
        Dim dt2 As New DataTable
        'Dim dt2 As New DataTable
        Dim message, title, defaultValue, m, x, txt, txt2 As String
        message = "«œŒ· «·«”„ «·„—«œ «·»ÕÀ ⁄‰Â"
        defaultValue = 0
        title = "»ÕÀ"
        nametxt.Text = InputBox(message, title, defaultValue, MsgBoxStyle.OKOnly)
        If Trim(nametxt.Text) = "" Then
            MsgBox("«œŒ· «·«”„ «·„—«œ «·»ÕÀ ⁄‰Â")
            Exit Sub
        End If
        '**********************************************************and  tk_tkleef like '" & Txt_tekleef.Text & "'+'%'"
        Dim Cmd1 As New SqlClient.SqlCommand("SELECT * FROM chngename where name like '" & nametxt.Text & "'+'%'", Con)
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
        car2_no_txt.Text = dt1.Rows(0).Item("car2_no")
        nametxt.Text = dt1.Rows(0).Item("name")
        notxt.Text = dt1.Rows(0).Item("no")
        txt = dt1.Rows(0).Item("classfi")
        'MsgBox(Str("„Œ’’… ·Â"))
        'Dim MyString As String = "Hello World"
        'Dim OtherString As String = "Hello World!"
        'Dim MyInt As Integer = MyString.CompareTo(OtherString)
        'Console.WriteLine(MyInt)

        'Dim txts As String = "”«∆ﬁ"
        'Dim txtm As String = "„Œ’’… ·Â"
        If txt = 1 Then
            RadioButton1.Checked = True
            RadioButton2.Checked = False

        End If
        If txt = 0 Then
            RadioButton2.Checked = True
            RadioButton1.Checked = False
        End If
        dat_txt.Value = dt1.Rows(0).Item("dat")

        If dt1.Rows(0).Item("NOTE") Is DBNull.Value Then
            notetxt.Text = ""
        Else
            notetxt.Text = dt1.Rows(0).Item("NOTE")
        End If
        bt_search(edit, add1, save, search, dell)
        '***********************************
        'car2_name_txt.Text = dt.Rows(0).Item("car2_name")
        Try

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        If car2_no_txt.Text = "" Or nametxt.Text = "" Then
            MsgBox("√ﬂ„· ≈œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim Cmd1 As New SqlClient.SqlCommand("SELECT * FROM car2_DATA where car2_NO='" & car2_no_txt.Text & "'", Con)
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd1)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count < 1 Then
            MsgBox("·«  ÊÃœ ⁄—»…  Õ„· «·—ﬁ„ «·„œŒ· :-" + "  " + car2_no_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            Exit Sub
        End If
        '***********************************************************************************************
        If (RadioButton1.Checked = False) And (RadioButton2.Checked) = False Then
            MsgBox("Õœœ «–«ﬂ«‰ ”«∆ﬁ √Ê „Œ’’… ·Â «·⁄—»…")
            Exit Sub
        End If
        Dim chec, drivern, onern As String
        If RadioButton1.Checked = True Then
            '„Œ’’… ·Â «·⁄—»…
            chec = 1
            'onern = dt.Rows(0).Item("car2_owner")
            Dim cmdString As String = "UPDATE chngename " + _
                                               "SET name = '" & nametxt.Text & "',classfi= '" & chec & "',NOTE='" & notetxt.Text.Trim & "'" + _
                                               "WHERE  no = '" & notxt.Text & "'"
            Dim cmd3 As New SqlClient.SqlCommand(cmdString, Con)
            cmd3.ExecuteNonQuery()
        End If
        '************************************************************************
        'Dim cmdString1 As String = "UPDATE car2_data " + _
        '                                   "SET car2_owner= '" & nametxt.Text & "' " + _
        '                                   "WHERE car2_no = '" & car2_no_txt.Text & "'"
        'Dim cmd As New SqlClient.SqlCommand(cmdString1, Con)
        'cmd.ExecuteNonQuery()
        If RadioButton2.Checked = True Then
            '
            chec = 0
            'drivern = dt.Rows(0).Item("driver")
            Dim cmdString As String = "UPDATE chngename " + _
                                               "SET name = '" & nametxt.Text & "',classfi= '" & chec & "',NOTE='" & notetxt.Text.Trim & "'" + _
                                               "WHERE no = '" & notxt.Text & "'"
            Dim cmd3 As New SqlClient.SqlCommand(cmdString, Con)
            cmd3.ExecuteNonQuery()
        End If
        Try
            MsgBox("·ﬁœ  „  ⁄œÌ· «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
            bt_edit(edit, add1, save, search, dell)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()



    End Sub

    Private Sub dell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dell.Click
        If notxt.Text = "" Then
            MsgBox("ﬁ„ »«·»ÕÀ «Ê·« ⁄‰ «·”Ã· «·„—«œ Õ–›Â")
            Exit Sub
        End If

        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim str As String
        str = MsgBox("·ﬁœ  —Ìœ Õ–› «·”Ã· «·–Ï ÌÕÊÏ «·«”„  :-" + "  " + nametxt.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Information, " ‰»ÌÂ")
        If str = vbYes Then
            Dim cmd3 As New SqlClient.SqlCommand("DELETE FROM chngename WHERE no =  '" & notxt.Text & "'", Con)

            Dim da3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd3)
            cmd3.ExecuteNonQuery()
        End If
        Try
            bt_add1(edit, add1, save, search, dell)
            MsgBox("·ﬁœ  „ Õ–› «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
            bt_dell(edit, add1, save, search, dell)
            notxt.Text = ""
            car2_no_txt.Text = ""
            nametxt.Text = ""
            notetxt.Text = ""
            RadioButton1.Checked = False
            RadioButton2.Checked = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
    End Sub

    Private Sub changename_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bt_low(edit, add1, save, search, dell)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


End Class
