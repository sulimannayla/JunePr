Public Class car2_dataregra
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
    Friend WithEvents car2_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dell As System.Windows.Forms.Button
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents add1 As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents NOTETXT As System.Windows.Forms.TextBox
    Friend WithEvents device_no_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents insurance_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.car2_no_txt = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dell = New System.Windows.Forms.Button
        Me.search = New System.Windows.Forms.Button
        Me.add1 = New System.Windows.Forms.Button
        Me.edit = New System.Windows.Forms.Button
        Me.save = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.NOTETXT = New System.Windows.Forms.TextBox
        Me.device_no_txt = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.insurance_date = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'car2_no_txt
        '
        Me.car2_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.car2_no_txt.Location = New System.Drawing.Point(253, 72)
        Me.car2_no_txt.Name = "car2_no_txt"
        Me.car2_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.car2_no_txt.Size = New System.Drawing.Size(128, 20)
        Me.car2_no_txt.TabIndex = 9
        Me.car2_no_txt.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(398, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 32)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "—ﬁ„ «·⁄—»… «·ÕﬂÊ„Ï"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arabic Transparent", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(552, 48)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "⁄„‹‹‹· ≈Ã‹—«¡ ··⁄‹‹‹—»…"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dell
        '
        Me.dell.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dell.Location = New System.Drawing.Point(16, 328)
        Me.dell.Name = "dell"
        Me.dell.Size = New System.Drawing.Size(88, 32)
        Me.dell.TabIndex = 62
        Me.dell.Text = "Õ–›"
        '
        'search
        '
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.search.Location = New System.Drawing.Point(120, 328)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(88, 32)
        Me.search.TabIndex = 61
        Me.search.Text = "»ÕÀ"
        '
        'add1
        '
        Me.add1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.add1.Location = New System.Drawing.Point(432, 328)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(88, 32)
        Me.add1.TabIndex = 58
        Me.add1.Text = "ÃœÌœ"
        '
        'edit
        '
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.edit.Location = New System.Drawing.Point(216, 328)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(96, 32)
        Me.edit.TabIndex = 60
        Me.edit.Text = " ⁄œÌ·"
        '
        'save
        '
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.save.Location = New System.Drawing.Point(320, 328)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(104, 32)
        Me.save.TabIndex = 59
        Me.save.Text = "Õ›Ÿ"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Location = New System.Drawing.Point(0, 312)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(544, 64)
        Me.Label12.TabIndex = 63
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label17.Location = New System.Drawing.Point(386, 236)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 32)
        Me.Label17.TabIndex = 66
        Me.Label17.Text = "„·«ÕŸ‹‹‹‹« "
        '
        'NOTETXT
        '
        Me.NOTETXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NOTETXT.Location = New System.Drawing.Point(96, 229)
        Me.NOTETXT.Multiline = True
        Me.NOTETXT.Name = "NOTETXT"
        Me.NOTETXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NOTETXT.Size = New System.Drawing.Size(288, 56)
        Me.NOTETXT.TabIndex = 65
        Me.NOTETXT.Text = ""
        '
        'device_no_txt
        '
        Me.device_no_txt.Location = New System.Drawing.Point(146, 138)
        Me.device_no_txt.Name = "device_no_txt"
        Me.device_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.device_no_txt.Size = New System.Drawing.Size(232, 21)
        Me.device_no_txt.TabIndex = 67
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.Location = New System.Drawing.Point(384, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 32)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "≈”‹‹‹„ «·ÃÂ…"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Simplified Arabic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(88, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(432, 72)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " ÕÊÌ· «·Ï ÃÂ…"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(380, 37)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(24, 24)
        Me.RadioButton1.TabIndex = 0
        '
        'insurance_date
        '
        Me.insurance_date.CustomFormat = "yyyy/MM/dd"
        Me.insurance_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.insurance_date.Location = New System.Drawing.Point(232, 194)
        Me.insurance_date.Name = "insurance_date"
        Me.insurance_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.insurance_date.Size = New System.Drawing.Size(152, 20)
        Me.insurance_date.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(392, 189)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 32)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = " «—ÌŒ «·«Ã—«¡"
        '
        'car2_dataregra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(552, 389)
        Me.Controls.Add(Me.insurance_date)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.device_no_txt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.NOTETXT)
        Me.Controls.Add(Me.dell)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.add1)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.car2_no_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "car2_dataregra"
        Me.Text = "car2_dataregra"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If Trim(car2_no_txt.Text) = "" Or Trim(device_no_txt.Text) = "" Or Trim(NOTETXT.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        If Con.State = ConnectionState.Open = True Then
            Con.Close()
        End If
        '******************************************
        Con.Open()
        Dim Cmd1 As New SqlClient.SqlCommand("SELECT * FROM car2_DATA where car2_NO='" & car2_no_txt.Text & "'", Con)
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd1)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count < 1 Then
            MsgBox("·« ÊÃœ ⁄—»…  Õ„· «·—ﬁ„ «·„œŒ· :-" + "  " + car2_no_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            Exit Sub
        End If
        '*******************************************
        bt_save(edit, add1, save, search, dell)
        Dim DS As New DataSet
        Dim t As DataTable
        Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM car2_type where car2_name='" & car2_no_txt.Text & "'", Con)
        Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        dr.Read()
        Dim x As Integer = dr.Item("type_no")
        dr.Close()
        Dim x4 As Integer = 1
        '****************************************************************************
        Dim cmdString As String = "UPDATE car2_data " + _
                                     "SET theweel ='" & x4 & "'" + _
                                     "WHERE car2_no = '" & car2_no_txt.Text & "'"
        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        cmd.ExecuteNonQuery()
        '************************

        'Dim cmdString As String = "INSERT INTO car2_data " + _
        '                          "(NOTE,MARKET_COS,privet_no,reg_no,site_id,car2_no,model,type_no,no_type,shase_no,machine_no,car2_owner,insurance_date,insurance_no,driver) " + _
        '                          "VALUES('" & NOTETXT.Text.Trim & "','" & MARKET_COSTXT.Text.Trim & "','" & privet_no_txt.Text.Trim & "','" & reg_no_txt.Text.Trim & "','" & x4 & "','" & car2_no_txt.Text & "','" & model_txt.Text & "','" & x & "','" & no_type_txt.Text & "','" & shase_no_txt.Text & "' ,'" & machine_no_txt.Text & "' ,'" & car2_owner_txt.Text & "','" & insurance_date.Text & "','" & insurance_no_txt.Text & "','" & driver_txt.Text & "')"
        'Dim cmd3 As New SqlClient.SqlCommand(cmdString, Con)
        'cmd3.ExecuteNonQuery()

        'type_no_txt.Text = ""
        'no_type_txt.Text = ""
        'shase_no_txt.Text = ""
        'machine_no_txt.Text = ""
        'car2_owner_txt.Text = ""
        'insurance_date.Text = ""
        'insurance_no_txt.Text = ""
        'driver_txt.Text = ""
        'car2_no_txt.Text = ""
        'device_no_txt.Text = ""
        'device_no_txt.Text = ""
        'reg_no_txt.Text = ""
        'privet_no_txt.Text = ""
        'Call clear()
        Try
            'cmd.ExecuteNonQuery()
            MsgBox("·ﬁœ  „ Õ›Ÿ «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Con.Close()
    End Sub

    Private Sub car2_dataregra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
