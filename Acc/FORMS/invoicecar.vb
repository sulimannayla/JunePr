Public Class invoicecar2
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Private Sub clear()
        invoice_sitetxt.Text = ""
        invoice_no.Text = ""
        maintenance_id.Text = ""
        cost_notes_txt.Text = ""
        namemesdg_txt.Text = ""
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dell As System.Windows.Forms.Button
    Friend WithEvents add1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents invoice_no As System.Windows.Forms.TextBox
    Friend WithEvents maintenance_id As System.Windows.Forms.TextBox
    Friend WithEvents date_txt As System.Windows.Forms.DateTimePicker
    Friend WithEvents car2_no_txt As System.Windows.Forms.ComboBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cost_notes_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents invoice_sitetxt As System.Windows.Forms.TextBox
    Friend WithEvents namemesdg_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.invoice_no = New System.Windows.Forms.TextBox
        Me.maintenance_id = New System.Windows.Forms.TextBox
        Me.date_txt = New System.Windows.Forms.DateTimePicker
        Me.dell = New System.Windows.Forms.Button
        Me.add1 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.save = New System.Windows.Forms.Button
        Me.edit = New System.Windows.Forms.Button
        Me.search = New System.Windows.Forms.Button
        Me.car2_no_txt = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cost_notes_txt = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.invoice_sitetxt = New System.Windows.Forms.TextBox
        Me.namemesdg_txt = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 80)
        Me.Panel1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Andalus", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(424, 40)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "»Ì‹‹‹‹«‰«  «·›« ‹‹‹‹‹‹Ê—…"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(382, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "—ﬁ‹‹‹„ «·›« Ê—…"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(384, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "„·«ÕŸ‹‹‹« "
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(385, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = " ‹«—ÌŒ «· ’œÌﬁ"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(384, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 32)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "—ﬁ‹‹‹„ «·’Ì«‰…"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 32)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "—ﬁ‹„ «·⁄—»…"
        Me.Label6.Visible = False
        '
        'invoice_no
        '
        Me.invoice_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.invoice_no.Location = New System.Drawing.Point(208, 128)
        Me.invoice_no.Name = "invoice_no"
        Me.invoice_no.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.invoice_no.Size = New System.Drawing.Size(168, 20)
        Me.invoice_no.TabIndex = 1
        Me.invoice_no.Text = ""
        '
        'maintenance_id
        '
        Me.maintenance_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.maintenance_id.Location = New System.Drawing.Point(208, 200)
        Me.maintenance_id.Name = "maintenance_id"
        Me.maintenance_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.maintenance_id.Size = New System.Drawing.Size(168, 20)
        Me.maintenance_id.TabIndex = 3
        Me.maintenance_id.Text = ""
        '
        'date_txt
        '
        Me.date_txt.CustomFormat = "yyyy/MM/dd"
        Me.date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_txt.Location = New System.Drawing.Point(240, 267)
        Me.date_txt.Name = "date_txt"
        Me.date_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.date_txt.Size = New System.Drawing.Size(136, 20)
        Me.date_txt.TabIndex = 6
        '
        'dell
        '
        Me.dell.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dell.Location = New System.Drawing.Point(56, 424)
        Me.dell.Name = "dell"
        Me.dell.Size = New System.Drawing.Size(72, 32)
        Me.dell.TabIndex = 12
        Me.dell.Text = "Õ–›"
        '
        'add1
        '
        Me.add1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.add1.Location = New System.Drawing.Point(384, 424)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(72, 32)
        Me.add1.TabIndex = 0
        Me.add1.Text = "ÃœÌœ"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Location = New System.Drawing.Point(32, 408)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(441, 64)
        Me.Label9.TabIndex = 71
        '
        'save
        '
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.save.Location = New System.Drawing.Point(304, 424)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(72, 32)
        Me.save.TabIndex = 8
        Me.save.Text = "Õ›Ÿ"
        '
        'edit
        '
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.edit.Location = New System.Drawing.Point(144, 424)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(72, 32)
        Me.edit.TabIndex = 11
        Me.edit.Text = " ⁄œÌ·"
        '
        'search
        '
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.search.Location = New System.Drawing.Point(224, 424)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(72, 32)
        Me.search.TabIndex = 10
        Me.search.Text = "»ÕÀ"
        '
        'car2_no_txt
        '
        Me.car2_no_txt.Location = New System.Drawing.Point(-24, 192)
        Me.car2_no_txt.Name = "car2_no_txt"
        Me.car2_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.car2_no_txt.Size = New System.Drawing.Size(168, 21)
        Me.car2_no_txt.TabIndex = 4
        Me.car2_no_txt.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PeachPuff
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Button1.Location = New System.Drawing.Point(24, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 24)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "«÷‹‹‹«›… «”»Ì‹‹—"
        '
        'cost_notes_txt
        '
        Me.cost_notes_txt.Location = New System.Drawing.Point(80, 312)
        Me.cost_notes_txt.Multiline = True
        Me.cost_notes_txt.Name = "cost_notes_txt"
        Me.cost_notes_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cost_notes_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.cost_notes_txt.Size = New System.Drawing.Size(296, 80)
        Me.cost_notes_txt.TabIndex = 7
        Me.cost_notes_txt.Text = ""
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(382, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 24)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "ÃÂ… «·›« ‹‹Ê—…"
        '
        'invoice_sitetxt
        '
        Me.invoice_sitetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.invoice_sitetxt.Location = New System.Drawing.Point(136, 168)
        Me.invoice_sitetxt.Name = "invoice_sitetxt"
        Me.invoice_sitetxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.invoice_sitetxt.Size = New System.Drawing.Size(240, 20)
        Me.invoice_sitetxt.TabIndex = 2
        Me.invoice_sitetxt.Text = ""
        '
        'namemesdg_txt
        '
        Me.namemesdg_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.namemesdg_txt.Location = New System.Drawing.Point(136, 232)
        Me.namemesdg_txt.Name = "namemesdg_txt"
        Me.namemesdg_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.namemesdg_txt.Size = New System.Drawing.Size(240, 20)
        Me.namemesdg_txt.TabIndex = 5
        Me.namemesdg_txt.Text = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(384, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 32)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "«·‘Œ’ «·„’œﬁ"
        '
        'invoicecar2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(536, 493)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.invoice_sitetxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cost_notes_txt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.car2_no_txt)
        Me.Controls.Add(Me.dell)
        Me.Controls.Add(Me.add1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.date_txt)
        Me.Controls.Add(Me.maintenance_id)
        Me.Controls.Add(Me.invoice_no)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.namemesdg_txt)
        Me.Name = "invoicecar2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "invoicecar2"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub invoicecar2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        bt_low(edit, add1, save, search, dell)
        Button1.Visible = False
        'Dim df As New SECURITY
        'Dim user As String = df.UserID.Text
        'Dim password1 As String = df.Password.Text
        'Dim lsPassword, lsUserId As String
        'Con.ConnectionString = "User ID= '" & df.UserID.Text & "';" & _
        '"Password='" & df.Password.Text & "';" & _
        '"Initial Catalog=car2;" & _
        '"Data Source=pc;" & _
        '"Connection TimeOut=30;"

        Con.Open()

        Dim DS As New DataSet
        Dim str As String = "SELECT  DISTINCT car2_no FROM maintenance"
        Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        ADP.Fill(DS)
        Dim i As Integer
        For i = 0 To DS.Tables(0).Rows.Count - 1
            Me.car2_no_txt.Items.Add(DS.Tables(0).Rows(i).Item(0))

        Next
        Try

            ADP.Dispose()
        Catch er As Exception
            MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√

        End Try
        Con.Close()
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        If Trim(invoice_no.Text) = "" Or Trim(maintenance_id.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        '****************************************
        Dim Cmd2 As New SqlClient.SqlCommand("mintnancemaintenance_SelectOne", Con)

        With Cmd2
            .CommandType = CommandType.StoredProcedure
            .Parameters.Add("@imaintenance_id", Val(maintenance_id.Text.Trim))
        End With
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd2)
        Dim dt As New DataTable
        da.Fill(dt)
        Cmd2.ExecuteNonQuery()
        If dt.Rows.Count < 1 Then
            MsgBox("·«ÌÊÃœ ÿ·» ’Ì«‰… ÌÕ„· «·—ﬁ„   :-" + "  " + maintenance_id.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            maintenance_id.Text = ""
            Exit Sub
        End If
        Dim d2 As String
        d2 = dt.Rows(0).Item("car2_no")

        '*******************************************************************
        '9999999999999999999
        Dim DS As New DataSet
        Dim dt3 As New DataTable
        Dim invo As Integer = Val(invoice_no.Text.Trim)
        Dim cmd3 As New SqlClient.SqlCommand("SELECT * FROM invoice where invoice_no='" & invo & "'", Con)
        Dim da3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd3)
        da3.Fill(dt3)
        cmd3.ExecuteNonQuery()
        If dt3.Rows.Count >= 1 Then
            MsgBox("Â–Â «·›« Ê—…  „ «œŒ«·Â«  :-" + "  " + invoice_no.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            invoice_no.Text = ""
            Exit Sub
        End If
        '999999999999999999999999999999999999999999999999999
        '''Dim Cmd3 As New SqlClient.SqlCommand("inviceinvoice_SelectOne", Con)
        '''With Cmd3
        '''    .CommandType = CommandType.StoredProcedure
        '''    .Parameters.Add("@iinvoice_no", invoice_no.Text)
        '''End With
        '''Dim da3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd3)
        '''Dim dt3 As New DataTable
        '''da.Fill(dt)
        '''Cmd3.ExecuteNonQuery()
        '''If dt.Rows.Count >= 1 Then
        '''    MsgBox("Â–Â «·›« Ê—…  „ «œŒ«·Â«  :-" + "  " + maintenance_id.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
        '''    'maintenance_id.Text = ""
        '''    Exit Sub
        '''End If
        '****************************************************************
        Button1.Visible = True
        bt_save(edit, add1, save, search, dell)
        '''Dim Cmd As New SqlClient.SqlCommand("inviceinvoice_Insert", Con)
        '''With Cmd
        '''    .CommandType = CommandType.StoredProcedure
        '''    .Parameters.Add("@iinvoice_no", invoice_no.Text.Trim)
        '''    .Parameters.Add("@imaintenance_id", maintenance_id.Text.Trim)
        '''    .Parameters.Add("@scost_notes", cost_notes_txt.Text.Trim)
        '''    .Parameters.Add("@icar2_no", car2_no_txt.Text.Trim)
        '''    .Parameters.Add("@dadate", date_txt.Text)
        '''    Try
        '''        Cmd.ExecuteNonQuery()
        '''        MsgBox("·ﬁœ  „ Õ›Ÿ «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        '''    Catch ex As Exception
        '''        MsgBox(ex.ToString)
        '''    End Try
        '''    Con.Close()
        '''End With
        Dim cmdString As String = "INSERT INTO invoice " + _
                                                  "(namemesdg,invoice_no,invoice_site,maintenance_id,car2_no,date,cost_notes)" + _
                                                  "VALUES('" & namemesdg_txt.Text.Trim & "' ,'" & invoice_no.Text.Trim & "','" & invoice_sitetxt.Text & "','" & maintenance_id.Text.Trim & "','" & d2 & "','" & date_txt.Text.Trim & "','" & cost_notes_txt.Text.Trim & "')"

        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)

        cmd.ExecuteNonQuery()
        Try
            MsgBox("·ﬁœ  „ Õ›Ÿ «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
    End Sub

    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add1.Click
        Call clear()
        bt_add1(edit, add1, save, search, dell)
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        If Trim(invoice_no.Text) = "" Or Trim(maintenance_id.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()


        Dim Cmd2 As New SqlClient.SqlCommand("mintnancemaintenance_SelectOne", Con)
        With Cmd2
            .CommandType = CommandType.StoredProcedure
            .Parameters.Add("@imaintenance_id", Val(maintenance_id.Text))
        End With
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd2)
        Dim dt As New DataTable
        da.Fill(dt)
        Cmd2.ExecuteNonQuery()
        If dt.Rows.Count < 1 Then
            MsgBox("·«ÌÊÃœ ÿ·» ’Ì«‰… ÌÕ„· «·—ﬁ„   :-" + "  " + maintenance_id.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            maintenance_id.Text = ""
            Exit Sub
        End If
        Dim d2 As String
        d2 = dt.Rows(0).Item("car2_no")

        'Dim Cmd As New SqlClient.SqlCommand("inviceinvoice_Update", Con)
        'With Cmd
        '    .CommandType = CommandType.StoredProcedure
        '    .Parameters.Add("@iinvoice_no", invoice_no.Text.Trim)
        '    .Parameters.Add("@imaintenance_id", maintenance_id.Text.Trim)
        '    .Parameters.Add("@scost_notes", cost_notes_txt.Text.Trim)
        '    .Parameters.Add("@icar2_no", car2_no_txt.Text.Trim)
        '    .Parameters.Add("@dadate", date_txt.Text)

        'End With
        '----------------------------------------------------
        'Dim x As Integer
        'x = type_no_txt.Value
        'oconnection.Open()
        Dim cmdString As String = "UPDATE invoice " + _
                                    "SET namemesdg= '" & namemesdg_txt.Text.Trim & "',invoice_no='" & invoice_no.Text.Trim & "',invoice_site='" & invoice_sitetxt.Text & "',maintenance_id= '" & maintenance_id.Text.Trim & "' ,car2_no= '" & d2 & "',date= '" & date_txt.Value & "',cost_notes= '" & cost_notes_txt.Text.Trim & "' " + _
                                    "WHERE invoice_no='" & invoice_no.Text.Trim & "'"
        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        cmd.ExecuteNonQuery()
        Con.Close()
        '---------------------------------------------------------


        bt_edit(edit, add1, save, search, dell)
        Try
            'Cmd.ExecuteNonQuery()
            MsgBox("·ﬁœ  „  ⁄œÌ· «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
            Call clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()

    End Sub

    Private Sub dell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dell.Click
        bt_dell(edit, add1, save, search, dell)
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim str As String
        str = MsgBox("·ﬁœ  —Ìœ Õ–› «·”Ã· «·–Ï ÌÕ„· «·—ﬁ„  :-" + "  " + invoice_no.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Information, " ‰»ÌÂ")
        If str = vbYes Then
            'Dim Cmd As New SqlClient.SqlCommand("partinviceinvoice_Delete", Con)
            'With Cmd
            '    .CommandType = CommandType.StoredProcedure
            '    .Parameters.Add("@iinvoice_no", invoice_no.Text)
            '    '.Parameters.Add("@ierrorcode", "")
            '    Cmd.ExecuteNonQuery()
            Dim cmd2 As New SqlClient.SqlCommand("DELETE FROM parts WHERE invoice_no =  '" & invoice_no.Text & "'", Con)
            Dim da2 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
            'da3.Fill(dt3)
            cmd2.ExecuteNonQuery()
            Dim cmd3 As New SqlClient.SqlCommand("DELETE FROM invoice WHERE invoice_no =  '" & invoice_no.Text & "'", Con)
            Dim da3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd3)
                'da3.Fill(dt3)
            cmd3.ExecuteNonQuery()
            Call clear()
            MsgBox("·ﬁœ  „ Õ–› «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        End If
        Try
            

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Con.Close()
        'End With

    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim message, title, defaultValue As String
        Dim m As Integer
        message = " «œŒ· —ﬁ„ «·›« Ê—… «·„—«œ «·»ÕÀ ⁄‰Â« "
        title = "»ÕÀ"
        invoice_no.Text = InputBox(message, title, defaultValue, MsgBoxStyle.OKOnly)
        If Trim(invoice_no.Text) = "" Then
            MsgBox("ÌÃ» «œŒ· —ﬁ„ «·›« Ê—… «·„—«œ «·»ÕÀ ⁄‰Â«√Ê·«")
            Exit Sub
        End If

        '****************************************************



        Dim DS As New DataSet
        Dim t As DataTable
        Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM invoice where invoice_no='" & invoice_no.Text.Trim & "'", Con)
        'Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        'dr.Read()
        'Dim x As Integer = dr.Item("type_no")



        '****************************************************************


        'Dim Cmd As New SqlClient.SqlCommand("inviceinvoice_SelectOne", Con)
        'With Cmd
        '    .CommandType = CommandType.StoredProcedure
        '    .Parameters.Add("@iinvoice_no", invoice_no.Text)
        '    '.Parameters.Add("@ierrorcode", "")
        'End With
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        Dim dt As New DataTable
        da.Fill(dt)
        cmd2.ExecuteNonQuery()
        If dt.Rows.Count < 1 Then
            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «·—ﬁ„  :-" + "  " + invoice_no.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            invoice_no.Text = ""
            Exit Sub
        End If
        bt_search(edit, add1, save, search, dell)
        Button1.Visible = True
        Button1.Enabled = True
        invoice_no.Text = dt.Rows(0).Item("invoice_no")
        maintenance_id.Text = dt.Rows(0).Item("maintenance_id")
        If dt.Rows(0).Item("cost_notes") Is DBNull.Value Then
            cost_notes_txt.Text = ""
        Else
            cost_notes_txt.Text = dt.Rows(0).Item("cost_notes")
        End If
        'cost_notes_txt.Text = dt.Rows(0).Item("cost_notes")
        'car2_no_txt.Text = dt.Rows(0).Item("car2_no")
        date_txt.Text = dt.Rows(0).Item("date")
        invoice_sitetxt.Text = dt.Rows(0).Item("invoice_site")
        namemesdg_txt.Text = dt.Rows(0).Item("namemesdg")
        Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
       
        Con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            ad = Me.invoice_no.Text
            Dim Fa8 As New parts
            Fa8.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub cost_notes_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cost_notes_txt.TextChanged

    End Sub
End Class
