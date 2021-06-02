Public Class taswia
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents notetxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents car2_no As System.Windows.Forms.TextBox
    Friend WithEvents no_blag As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents isur_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents blag_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents tswia_dat_txt As System.Windows.Forms.DateTimePicker
    Friend WithEvents hadsdate_txt As System.Windows.Forms.DateTimePicker
    Friend WithEvents insurecom_txt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dell = New System.Windows.Forms.Button
        Me.search = New System.Windows.Forms.Button
        Me.edit = New System.Windows.Forms.Button
        Me.save = New System.Windows.Forms.Button
        Me.add1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.isur_no_txt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.blag_date = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.notetxt = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.car2_no = New System.Windows.Forms.TextBox
        Me.no_blag = New System.Windows.Forms.TextBox
        Me.tswia_dat_txt = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.hadsdate_txt = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.insurecom_txt = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dell
        '
        Me.dell.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dell.Location = New System.Drawing.Point(48, 344)
        Me.dell.Name = "dell"
        Me.dell.Size = New System.Drawing.Size(72, 32)
        Me.dell.TabIndex = 12
        Me.dell.Text = "Õ–›"
        '
        'search
        '
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.search.Location = New System.Drawing.Point(136, 344)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(72, 32)
        Me.search.TabIndex = 11
        Me.search.Text = "»ÕÀ"
        '
        'edit
        '
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.edit.Location = New System.Drawing.Point(216, 344)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(80, 32)
        Me.edit.TabIndex = 10
        Me.edit.Text = " ⁄œÌ·"
        '
        'save
        '
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.save.Location = New System.Drawing.Point(304, 344)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(88, 32)
        Me.save.TabIndex = 8
        Me.save.Text = "Õ›Ÿ"
        '
        'add1
        '
        Me.add1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.add1.Location = New System.Drawing.Point(400, 344)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(88, 32)
        Me.add1.TabIndex = 9
        Me.add1.Text = "ÃœÌœ"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(32, 328)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(480, 64)
        Me.Label3.TabIndex = 88
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Andalus", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(472, 40)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "„‹‹‹·› «· ”‹‹‹‹‹‹‹‹‹‹‹ÊÌ…"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(-10, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(594, 72)
        Me.Panel1.TabIndex = 90
        '
        'isur_no_txt
        '
        Me.isur_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.isur_no_txt.Location = New System.Drawing.Point(224, 208)
        Me.isur_no_txt.Name = "isur_no_txt"
        Me.isur_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.isur_no_txt.Size = New System.Drawing.Size(200, 20)
        Me.isur_no_txt.TabIndex = 4
        Me.isur_no_txt.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(429, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 32)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "‰„‹‹—… «·»·«€"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(430, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "—ﬁ„ ÊÀÌﬁ… «· «„Ì‰"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(164, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 32)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = " «—ÌŒ «·»·«€"
        '
        'blag_date
        '
        Me.blag_date.CustomFormat = "yyyy/MM/dd"
        Me.blag_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.blag_date.Location = New System.Drawing.Point(32, 110)
        Me.blag_date.Name = "blag_date"
        Me.blag_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.blag_date.Size = New System.Drawing.Size(120, 20)
        Me.blag_date.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(430, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 24)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "„·«ÕŸ‹‹‹‹« "
        '
        'notetxt
        '
        Me.notetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.notetxt.Location = New System.Drawing.Point(96, 240)
        Me.notetxt.Multiline = True
        Me.notetxt.Name = "notetxt"
        Me.notetxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.notetxt.Size = New System.Drawing.Size(328, 56)
        Me.notetxt.TabIndex = 5
        Me.notetxt.Text = ""
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(430, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 32)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "—ﬁ‹„ «·⁄‹—»…"
        '
        'car2_no
        '
        Me.car2_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.car2_no.Location = New System.Drawing.Point(272, 80)
        Me.car2_no.Name = "car2_no"
        Me.car2_no.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.car2_no.Size = New System.Drawing.Size(152, 20)
        Me.car2_no.TabIndex = 0
        Me.car2_no.Text = ""
        '
        'no_blag
        '
        Me.no_blag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.no_blag.Location = New System.Drawing.Point(272, 110)
        Me.no_blag.Name = "no_blag"
        Me.no_blag.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.no_blag.Size = New System.Drawing.Size(152, 20)
        Me.no_blag.TabIndex = 1
        Me.no_blag.Text = ""
        '
        'tswia_dat_txt
        '
        Me.tswia_dat_txt.CustomFormat = "yyyy/MM/dd"
        Me.tswia_dat_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tswia_dat_txt.Location = New System.Drawing.Point(302, 144)
        Me.tswia_dat_txt.Name = "tswia_dat_txt"
        Me.tswia_dat_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tswia_dat_txt.Size = New System.Drawing.Size(120, 20)
        Me.tswia_dat_txt.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(427, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 24)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = " ‹«—ÌŒ «· ”ÊÌ…"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(430, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 24)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "«·‘—ﬂ… «·„ƒ„‰…"
        '
        'hadsdate_txt
        '
        Me.hadsdate_txt.CustomFormat = "yyyy/MM/dd"
        Me.hadsdate_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.hadsdate_txt.Location = New System.Drawing.Point(32, 80)
        Me.hadsdate_txt.Name = "hadsdate_txt"
        Me.hadsdate_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.hadsdate_txt.Size = New System.Drawing.Size(120, 20)
        Me.hadsdate_txt.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(160, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 32)
        Me.Label10.TabIndex = 107
        Me.Label10.Text = " «—ÌŒ «·Õ«œÀ"
        '
        'insurecom_txt
        '
        Me.insurecom_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.insurecom_txt.Location = New System.Drawing.Point(160, 176)
        Me.insurecom_txt.Name = "insurecom_txt"
        Me.insurecom_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.insurecom_txt.Size = New System.Drawing.Size(264, 20)
        Me.insurecom_txt.TabIndex = 3
        Me.insurecom_txt.Text = ""
        '
        'taswia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(560, 421)
        Me.Controls.Add(Me.insurecom_txt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.hadsdate_txt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tswia_dat_txt)
        Me.Controls.Add(Me.no_blag)
        Me.Controls.Add(Me.car2_no)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.notetxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.blag_date)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.isur_no_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dell)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.add1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "taswia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "„·› «· ”ÊÌ…"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub clear()
        no_blag.Text = ""
        isur_no_txt.Text = ""
        notetxt.Text = ""
        car2_no.Text = ""
        insurecom_txt.Text = ""
    End Sub
    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add1.Click
        bt_add1(edit, add1, save, search, dell)
        Call clear()
    End Sub

    Private Sub taswia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bt_low(edit, add1, save, search, dell)
        'Dim df As New SECURITY
        'Dim user As String = df.UserID.Text
        'Dim password1 As String = df.Password.Text
        'Dim lsPassword, lsUserId As String
        'Con.ConnectionString = "User ID= '" & df.UserID.Text & "';" & _
        '"Password='" & df.Password.Text & "';" & _
        '"Initial Catalog=car2;" & _
        '"Data Source=pc;" & _
        '"Connection TimeOut=30;"
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If Trim(no_blag.Text.Trim) = "" Or Trim(isur_no_txt.Text) = "" Or Trim(car2_no.Text) = "" Or Trim(insurecom_txt.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim Cmd1 As New SqlClient.SqlCommand("SELECT * FROM car2_DATA where car2_NO='" & car2_no.Text.Trim & "'", Con)
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd1)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count < 1 Then
            MsgBox("·« ÊÃœ ⁄—»…  Õ„· «·—ﬁ„ «·„œŒ· -" + "  " + car2_no.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            Exit Sub
        End If
        '*******************************************
        bt_save(edit, add1, save, search, dell)
        'hadsdate_txt()
        'blag_date()
        'tswia_dat_txt()
        'no_blag.Text = ""
        'isur_no_txt.Text = ""
        'notetxt.Text = ""
        'car2_no.Text = ""
        'insurecom_txt.Text = ""
        Dim cmdString As String = "INSERT INTO tswiat " + _
                    "(NOTE,no_blag,isur_no,car2_no,insurecom,hadsdate,blag_date, tswia_dat) " + _
                    "VALUES('" & notetxt.Text.Trim & "','" & no_blag.Text.Trim & "','" & isur_no_txt.Text.Trim & "','" & car2_no.Text.Trim & "','" & insurecom_txt.Text & "','" & hadsdate_txt.Text.Trim & "','" & blag_date.Text.Trim & "','" & tswia_dat_txt.Text.Trim & "')"
        Dim cmd3 As New SqlClient.SqlCommand(cmdString, Con)
        cmd3.ExecuteNonQuery()

        Call clear()
        Try

            MsgBox("·ﬁœ  „ Õ›Ÿ «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Con.Close()



        
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim dt1 As New DataTable
        Dim dt5 As New DataTable
        Dim dt2 As New DataTable
        'Dim dt2 As New DataTable
        Dim message, title, defaultValue, m, x, txt, txt2 As String
        message = "«œŒ· —ﬁ„ «·⁄—»…"
        defaultValue = 0
        title = "»ÕÀ"
        car2_no.Text = InputBox(message, title, defaultValue, MsgBoxStyle.OKOnly)
        If Trim(car2_no.Text) = "" Then
            MsgBox("ÌÃ» «Œ Ì«— «·—ﬁ„ «·„ ”·”· «Ê·«")
            Exit Sub
        End If
        '**********************************************************
        Dim Cmd1 As New SqlClient.SqlCommand("SELECT * FROM tswiat where car2_no='" & car2_no.Text.Trim & "'", Con)
        Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd1)
        da1.Fill(dt1)
        Cmd1.ExecuteNonQuery()
        '***********************************************************************
        If dt1.Rows.Count < 1 Then
            MsgBox("·« ÊÃœ ⁄—»…  Õ„· «·—ﬁ„  :-" + "  " + car2_no.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            Call clear()
            car2_no.Text = ""
            Exit Sub
        End If

        'notetxt.Text = dt1.Rows(0).Item("NOTE")
        no_blag.Text = dt1.Rows(0).Item("no_blag")
        car2_no.Text = dt1.Rows(0).Item("car2_no")
        insurecom_txt.Text = dt1.Rows(0).Item("insurecom")
        hadsdate_txt.Text = dt1.Rows(0).Item("hadsdate")
        blag_date.Text = dt1.Rows(0).Item("blag_date")
        tswia_dat_txt.Text = dt1.Rows(0).Item("tswia_dat")
        isur_no_txt.Text = dt1.Rows(0).Item("isur_no")
        '****************************************************************************
        bt_search(edit, add1, save, search, dell)
        If dt1.Rows(0).Item("NOTE") Is DBNull.Value Then
            notetxt.Text = ""
        Else
            notetxt.Text = dt1.Rows(0).Item("NOTE")
        End If
        Try

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Con.Close()
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        bt_edit(edit, add1, save, search, dell)
        If Trim(no_blag.Text.Trim) = "" Or Trim(isur_no_txt.Text) = "" Or Trim(car2_no.Text) = "" Or Trim(insurecom_txt.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim Cmd1 As New SqlClient.SqlCommand("SELECT * FROM tswiat where car2_NO='" & car2_no.Text & "'", Con)
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd1)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count < 1 Then
            MsgBox("·« ÊÃœ ⁄—»…  Õ„· «·—ﬁ„ «·„œŒ· -" + "  " + car2_no.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            Exit Sub
        End If

        '"(NOTE,no_blag,isur_no,car2_no,insurecom,hadsdate,blag_date, tswia_dat) " + _
        '                   "VALUES('" & notetxt.Text.Trim & "','" & no_blag.Text.Trim & "','" & isur_no_txt.Text.Trim & "','" & car2_no.Text.Trim & "','" & insurecom_txt.Text & "','" & hadsdate_txt.Text.Trim & "','" & blag_date.Text.Trim & "','" & tswia_dat_txt.Text.Trim & "')"
        '   
        '********************************************************************
        'Dim cmdString As String = "UPDATE car2_data " + _
        '                                    "SET theweel = '" & dd & "',model = '" & model_txt.Text & "',MARKET_COS= '" & MARKET_COSTXT.Text.Trim & "',NOTE='" & notetxt.Text.Trim & "', reg_no='" & reg_no_txt.Text.Trim & "',privet_no='" & privet_no_txt.Text.Trim & "',site_id ='" & x4 & "', car2_no='" & car2_no_txt.Text & "',insurance_date='" & insurance_date.Text & "',type_no='" & x & "', shase_no='" & shase_no_txt.Text & "',car2_owner='" & car2_owner_txt.Text & "',machine_no='" & machine_no_txt.Text & "',insurance_no='" & insurance_no_txt.Text & "', driver= '" & driver_txt.Text & "', no_type='" & no_type_txt.Text & "' " + _
        '                                    "WHERE car2_no = '" & car2_no_txt.Text & "'"
        ',no_blag = '" & no_blag.Text.Trim & "',isur_no= '" & isur_no_txt.Text.Trim & "',car2_no='" & car2_no.Text.Trim & "',insurecom='" & insurecom_txt.Text & "',hadsdate='" & hadsdate_txt.Text & "',blag_date ='" & blag_date.Text & "',tswia_dat='" & tswia_dat_txt.Text & "'
        '''Dim cmdString As String = "UPDATE parts " + _
        '''                                                    "SET  totel = '" & totall & "',invoice_no = '" & invoice_no_txt.Text & "', part_name= '" & part_txt.Text & "', cost= '" & cost_txt.Text & "', QUNTETY='" & count_txt.Text & "' " + _
        '''                                                    "WHERE invoice_no = '" + invoice_no_txt.Text + "'"
        '''Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        Dim cmdString As String = "UPDATE tswiat " + _
                                    "SET NOTE='" & notetxt.Text & "',no_blag = '" & no_blag.Text.Trim & "',isur_no= '" & isur_no_txt.Text.Trim & "',car2_no='" & car2_no.Text.Trim & "',insurecom='" & insurecom_txt.Text & "',hadsdate='" & hadsdate_txt.Text & "',blag_date ='" & blag_date.Text & "',tswia_dat='" & tswia_dat_txt.Text & "' " + _
                                    "WHERE car2_no ='" & car2_no.Text & "'"
        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        'MsgBox("well22")
        cmd.ExecuteNonQuery()
        Try
            'cmd.ExecuteNonQuery()
            MsgBox("·ﬁœ  „  ⁄œÌ· «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
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
        str = MsgBox("·ﬁœ  —Ìœ Õ–› «·⁄—»… »«·—ﬁ„  :-" + "  " + car2_no.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Information, " ‰»ÌÂ")

        Dim Cmd1 As New SqlClient.SqlCommand("SELECT * FROM tswiat where car2_NO='" & car2_no.Text & "'", Con)
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd1)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count < 1 Then
            MsgBox("·« ÊÃœ ⁄—»…  Õ„· «·—ﬁ„ «·„œŒ· -" + "  " + car2_no.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            Exit Sub
        End If

        If str = vbYes Then
            Dim cmd3 As New SqlClient.SqlCommand("DELETE FROM tswiat WHERE car2_no =  '" & car2_no.Text & "'", Con)

            Dim da3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd3)
            cmd3.ExecuteNonQuery()
        Else
            Exit Sub
        End If
        Try
            bt_add1(edit, add1, save, search, dell)
            MsgBox("·ﬁœ  „ Õ–› «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
            Call clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Con.Close()
    End Sub
End Class
