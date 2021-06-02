Public Class cartype
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dell As System.Windows.Forms.Button
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents add1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents car_name_txt As System.Windows.Forms.TextBox
    Friend WithEvents type_no_txt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.type_no_txt = New System.Windows.Forms.TextBox
        Me.car_name_txt = New System.Windows.Forms.TextBox
        Me.dell = New System.Windows.Forms.Button
        Me.search = New System.Windows.Forms.Button
        Me.edit = New System.Windows.Forms.Button
        Me.save = New System.Windows.Forms.Button
        Me.add1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(-76, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 66)
        Me.Panel1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Andalus", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(424, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "«‰‹‹‹‹Ê«⁄ «·⁄—»‹‹‹‹« "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(384, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "«”„ «·⁄—»‹‹…"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(392, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "«·—ﬁ‹„ «·„ ”·”·"
        '
        'type_no_txt
        '
        Me.type_no_txt.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.type_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.type_no_txt.Enabled = False
        Me.type_no_txt.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.type_no_txt.Location = New System.Drawing.Point(232, 96)
        Me.type_no_txt.Name = "type_no_txt"
        Me.type_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.type_no_txt.Size = New System.Drawing.Size(152, 20)
        Me.type_no_txt.TabIndex = 4
        Me.type_no_txt.Text = ""
        '
        'car_name_txt
        '
        Me.car_name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.car_name_txt.Location = New System.Drawing.Point(128, 144)
        Me.car_name_txt.Name = "car_name_txt"
        Me.car_name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.car_name_txt.Size = New System.Drawing.Size(256, 20)
        Me.car_name_txt.TabIndex = 1
        Me.car_name_txt.Text = ""
        '
        'dell
        '
        Me.dell.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dell.Location = New System.Drawing.Point(80, 200)
        Me.dell.Name = "dell"
        Me.dell.Size = New System.Drawing.Size(72, 32)
        Me.dell.TabIndex = 5
        Me.dell.Text = "Õ–›"
        '
        'search
        '
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.search.Location = New System.Drawing.Point(168, 200)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(72, 32)
        Me.search.TabIndex = 4
        Me.search.Text = "»ÕÀ"
        '
        'edit
        '
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.edit.Location = New System.Drawing.Point(248, 200)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(80, 32)
        Me.edit.TabIndex = 3
        Me.edit.Text = " ⁄œÌ·"
        '
        'save
        '
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.save.Location = New System.Drawing.Point(336, 200)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(88, 32)
        Me.save.TabIndex = 2
        Me.save.Text = "Õ›Ÿ"
        '
        'add1
        '
        Me.add1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.add1.Location = New System.Drawing.Point(432, 200)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(88, 32)
        Me.add1.TabIndex = 0
        Me.add1.Text = "ÃœÌœ"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(56, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(480, 64)
        Me.Label3.TabIndex = 65
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(424, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "ÃœÌœ"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(328, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "Õ›Ÿ"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.Location = New System.Drawing.Point(312, 200)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 32)
        Me.Button3.TabIndex = 63
        Me.Button3.Text = "Õ›Ÿ"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.Location = New System.Drawing.Point(152, 200)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 32)
        Me.Button4.TabIndex = 66
        Me.Button4.Text = "»ÕÀ"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button5.Location = New System.Drawing.Point(232, 200)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 32)
        Me.Button5.TabIndex = 64
        Me.Button5.Text = " ⁄œÌ·"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button6.Location = New System.Drawing.Point(408, 200)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 32)
        Me.Button6.TabIndex = 62
        Me.Button6.Text = "ÃœÌœ"
        '
        'cartype
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(584, 285)
        Me.Controls.Add(Me.dell)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.add1)
        Me.Controls.Add(Me.car_name_txt)
        Me.Controls.Add(Me.type_no_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Name = "cartype"
        Me.Text = "cartype"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Sub num()
        Con.Open()
        'Dim aql As Integer
        'aql = "select * from maintenance order by men_id DESC  "
        'aql = "select max(men_id) men_id from maintenance  "
        'Con.Close()
        'Dim DS As New DataSet
        ''Dim aql As String = "SELECT  DISTINCT type_no FROM car_type"
        'Dim aql As String = "select max(type_no) type_no from car_type  "
        'Dim ADP As New SqlClient.SqlDataAdapter(aql, Con)
        'ADP.Fill(DS)
        'type_no_txt.Text = DS.Tables(0).Rows.Count - 1
        ''ADP.ExecuteNonQuery()
        'ADP.Dispose()
        '**********************************************************
        Dim DS As New DataSet
        Dim t As DataTable
        Dim cmd2 As New SqlClient.SqlCommand("select max(type_no) type_no from car_type  ", Con)
        Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        dr.Read()
        type_no_txt.Text = dr.Item("type_no")
        dr.Close()
        Try
        Catch er As Exception
            MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√
        End Try
    End Sub
    Private Sub cartype_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        bt_low(edit, add1, save, search, dell)
        Dim df As New SECURITY
        Dim user As String = df.UserID.Text
        Dim password1 As String = df.Password.Text
        Dim lsPassword, lsUserId As String
        Con.ConnectionString = "User ID= '" & df.UserID.Text & "';" & _
        "Password='" & df.Password.Text & "';" & _
        "Initial Catalog=car;" & _
        "Data Source=pc;" & _
        "Connection TimeOut=30;"
    End Sub
    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        If Trim(car_name_txt.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        bt_save(edit, add1, save, search, dell)
        Dim Cmd As New SqlClient.SqlCommand("partscar_type_Insert", Con)
        With Cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.Add("@scar_name", car_name_txt.Text.Trim)
            .Parameters.Add("@itype_no", "")
            Try
                Cmd.ExecuteNonQuery()
                MsgBox("·ﬁœ  „ Õ›Ÿ «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Con.Close()
            num()
        End With
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        If Trim(type_no_txt.Text) = "" Then
            MsgBox("«œŒ· —ﬁ„ «·”Ã·")
            Exit Sub
        End If
        bt_edit(edit, add1, save, search, dell)
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim cmdString As String = "UPDATE CAR_TYPE " + _
                                            "SET CAR_name = '" & car_name_txt.Text & "' " + _
                                            "WHERE type_no = '" & type_no_txt.Text & "'"
        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("·ﬁœ  „  ⁄œÌ· «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
    End Sub

    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add1.Click
        bt_add1(edit, add1, save, search, dell)
        car_name_txt.Text = ""
        type_no_txt.Text = ""
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        'Dim m, Message, title As Object
        Dim message, title, defaultValue As String
        Dim m As Integer
        message = " «œŒ· «·—ﬁ„ «·„ ”·”· «·„—«œ «·»ÕÀ ⁄‰Â "
        title = "»ÕÀ"
        type_no_txt.Text = Val(InputBox(message, title, defaultValue, MsgBoxStyle.OKOnly))
        If Trim(type_no_txt.Text) = "" Then
            MsgBox("ÌÃ» «Œ Ì«— «·—ﬁ„ «·„ ”·”· √Ê·«")
            Exit Sub
        End If
        Dim Cmd As New SqlClient.SqlCommand("partscar_type_SelectOne", Con)
        With Cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.Add("@itype_no", type_no_txt.Text)
            '.Parameters.Add("@ierrorcode", "")
        End With
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        If dt.Rows.Count < 1 Then
            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «·—ﬁ„  :-" + "  " + type_no_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            type_no_txt.Text = ""
            Exit Sub
        End If
        bt_search(edit, add1, save, search, dell)
        'If dt.Rows(0).Item("CAR_name") Is DBNull.Value Then
        car_name_txt.Text = dt.Rows(0).Item("car_name")
        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
    End Sub

    Private Sub dell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dell.Click
        bt_dell(edit, add1, save, search, dell)
        Dim str As String
        str = MsgBox("·ﬁœ  —Ìœ Õ–› «·”Ã· «·–Ï ÌÕ„· «·—ﬁ„  :-" + "  " + type_no_txt.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Information, " ‰»ÌÂ")
        If str = vbYes Then
            Dim Cmd As New SqlClient.SqlCommand("partscar_type_Delete", Con)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@itype_no", type_no_txt.Text)
                '.Parameters.Add("@ierrorcode", "")
                If Con.State = ConnectionState.Broken = False Then
                    Con.Close()
                End If
                Con.Open()
                Try
                    Cmd.ExecuteNonQuery()
                    car_name_txt.Text = ""
                    type_no_txt.Text = ""
                    MsgBox("·ﬁœ  „ Õ–› «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

                Con.Close()
            End With
        End If
        car_name_txt.Text = ""
        type_no_txt.Text = ""
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
End Class
