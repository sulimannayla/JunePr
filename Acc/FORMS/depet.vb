Public Class depet
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents site_name_txt As System.Windows.Forms.TextBox
    Friend WithEvents site_id_txt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dell = New System.Windows.Forms.Button
        Me.search = New System.Windows.Forms.Button
        Me.edit = New System.Windows.Forms.Button
        Me.save = New System.Windows.Forms.Button
        Me.add1 = New System.Windows.Forms.Button
        Me.site_name_txt = New System.Windows.Forms.TextBox
        Me.site_id_txt = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
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
        'dell
        '
        Me.dell.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dell.Location = New System.Drawing.Point(80, 216)
        Me.dell.Name = "dell"
        Me.dell.Size = New System.Drawing.Size(72, 32)
        Me.dell.TabIndex = 6
        Me.dell.Text = "Õ–›"
        '
        'search
        '
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.search.Location = New System.Drawing.Point(80, 216)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(72, 32)
        Me.search.TabIndex = 5
        Me.search.Text = "»ÕÀ"
        '
        'edit
        '
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.edit.Location = New System.Drawing.Point(192, 216)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(80, 32)
        Me.edit.TabIndex = 4
        Me.edit.Text = " ⁄œÌ·"
        '
        'save
        '
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.save.Location = New System.Drawing.Point(304, 216)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(88, 32)
        Me.save.TabIndex = 3
        Me.save.Text = "Õ›Ÿ"
        '
        'add1
        '
        Me.add1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.add1.Location = New System.Drawing.Point(416, 216)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(88, 32)
        Me.add1.TabIndex = 0
        Me.add1.Text = "ÃœÌœ"
        '
        'site_name_txt
        '
        Me.site_name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.site_name_txt.Location = New System.Drawing.Point(142, 157)
        Me.site_name_txt.Name = "site_name_txt"
        Me.site_name_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.site_name_txt.Size = New System.Drawing.Size(256, 20)
        Me.site_name_txt.TabIndex = 1
        Me.site_name_txt.Text = ""
        '
        'site_id_txt
        '
        Me.site_id_txt.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.site_id_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.site_id_txt.Enabled = False
        Me.site_id_txt.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.site_id_txt.Location = New System.Drawing.Point(246, 109)
        Me.site_id_txt.Name = "site_id_txt"
        Me.site_id_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.site_id_txt.Size = New System.Drawing.Size(152, 20)
        Me.site_id_txt.TabIndex = 75
        Me.site_id_txt.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(406, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 32)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "«·—ﬁ‹„ «·„ ”·”·"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(403, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 32)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "«”‹‹‹„ «·ÃÂ«“"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(-62, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 66)
        Me.Panel1.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Andalus", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(424, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "«·√ÃÂ“… «·ﬁ÷«∆Ì…"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(56, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(480, 64)
        Me.Label3.TabIndex = 82
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(438, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "ÃœÌœ"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(342, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 80
        Me.Button2.Text = "Õ›Ÿ"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.Location = New System.Drawing.Point(326, 213)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 32)
        Me.Button3.TabIndex = 79
        Me.Button3.Text = "Õ›Ÿ"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.Location = New System.Drawing.Point(166, 213)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 32)
        Me.Button4.TabIndex = 83
        Me.Button4.Text = "»ÕÀ"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button5.Location = New System.Drawing.Point(246, 213)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 32)
        Me.Button5.TabIndex = 81
        Me.Button5.Text = " ⁄œÌ·"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button6.Location = New System.Drawing.Point(422, 213)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 32)
        Me.Button6.TabIndex = 78
        Me.Button6.Text = "ÃœÌœ"
        '
        'depet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(600, 285)
        Me.Controls.Add(Me.dell)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.add1)
        Me.Controls.Add(Me.site_name_txt)
        Me.Controls.Add(Me.site_id_txt)
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
        Me.Name = "depet"
        Me.Text = "«·«ÃÂ“…"
        Me.Panel1.ResumeLayout(False)
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
        Dim cmdString As String = "INSERT INTO sites " + _
                           "(site_name) " + _
                           "VALUES('" & site_name_txt.Text & "')"

        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        Try
            cmd.ExecuteNonQuery()
            Con.Close()
            Call num()

            MsgBox("·ﬁœ  „ Õ›Ÿ «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        'cmd.ExecuteNonQuery()


        'Response.Redirect(Request.Path, False)

    End Sub

    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add1.Click
        bt_add1(edit, add1, save, search, dell)
        site_name_txt.Text = ""
        site_id_txt.Text = ""
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        If Trim(site_id_txt.Text) = "" Then
            MsgBox("«œŒ· —ﬁ„ «·”Ã·")
            Exit Sub
        End If
        bt_edit(edit, add1, save, search, dell)
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim cmdString As String = "UPDATE sites " + _
                                            "SET site_name = '" & site_name_txt.Text & "' " + _
                                            "WHERE site_id = '" & site_id_txt.Text & "'"
        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("·ﬁœ  „  ⁄œÌ· «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        Dim DS As New DataSet
        Dim t As DataTable

        Dim message, title, defaultValue As String
        Dim m As Integer
        message = " «œŒ· «·—ﬁ„ «·„ ”·”· «·„—«œ «·»ÕÀ ⁄‰Â "
        title = "»ÕÀ"
        site_id_txt.Text = Val(InputBox(message, title, defaultValue, MsgBoxStyle.OKOnly))
        If Trim(site_id_txt.Text) = "" Then
            MsgBox("ÌÃ» «Œ Ì«— «·—ﬁ„ «·„ ”·”· √Ê·«")
            Exit Sub
        End If
        Dim cmd2 As New SqlClient.SqlCommand("select * from sites WHERE site_id = '" & site_id_txt.Text & "'", Con)
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count < 1 Then
            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «·—ﬁ„  :-" + "  " + site_id_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            site_id_txt.Text = ""
            Exit Sub
        End If
        bt_search(edit, add1, save, search, dell)
        site_id_txt.Text = dt.Rows(0).Item("site_id")
        site_name_txt.Text = dt.Rows(0).Item("site_name")
        Try
            'cmd2.ExecuteNonQuery()
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
        str = MsgBox("·ﬁœ  —Ìœ Õ–› «·”Ã· «·–Ï ÌÕ„· «·—ﬁ„  :-" + "  " + site_id_txt.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Information, " ‰»ÌÂ")
        If str = vbYes Then
            Dim cmd3 As New SqlClient.SqlCommand("DELETE FROM sites WHERE site_id =  '" & site_id_txt.Text & "'", Con)

            Dim da3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd3)
            cmd3.ExecuteNonQuery()
        End If
        Try
            bt_add1(edit, add1, save, search, dell)
            site_name_txt.Text = ""
            site_id_txt.Text = ""
            MsgBox("·ﬁœ  „ Õ–› «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Con.Close()
    End Sub
    Private Sub num()
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim DS As New DataSet
        Dim t As DataTable
        Dim cmd2 As New SqlClient.SqlCommand("select max(site_id) site_id from sites  ", Con)
        Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        dr.Read()
        site_id_txt.Text = dr.Item("site_id")
        dr.Close()
        Try
        Catch er As Exception
            MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√
        End Try
        Con.Close()
    End Sub
    Private Sub depet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
