Public Class parts
    Inherits System.Windows.Forms.Form
    Dim oconnection As New SqlClient.SqlConnection
    Dim cmdString As String
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents add1 As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents dell As System.Windows.Forms.Button
    Friend WithEvents invoice_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents part_txt As System.Windows.Forms.TextBox
    Friend WithEvents cost_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents count_txt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.add1 = New System.Windows.Forms.Button
        Me.save = New System.Windows.Forms.Button
        Me.edit = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.invoice_no_txt = New System.Windows.Forms.TextBox
        Me.part_txt = New System.Windows.Forms.TextBox
        Me.cost_txt = New System.Windows.Forms.TextBox
        Me.search = New System.Windows.Forms.Button
        Me.dell = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.count_txt = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(-15, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 72)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Andalus", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(424, 40)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "«·«”»Ì‹‹‹‹‹‹‹‹‹‹‹‹‹‹‹‹—« "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "—ﬁ‹„ «·›« Ê—…"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(360, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 40)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "”⁄— «·ÊÕœ…"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(352, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 32)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "«·«”»Ì‹‹‹—« "
        '
        'add1
        '
        Me.add1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.add1.Location = New System.Drawing.Point(360, 256)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(72, 32)
        Me.add1.TabIndex = 4
        Me.add1.Text = "ÃœÌœ"
        '
        'save
        '
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.save.Location = New System.Drawing.Point(280, 256)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(72, 32)
        Me.save.TabIndex = 3
        Me.save.Text = "Õ›Ÿ"
        '
        'edit
        '
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.edit.Location = New System.Drawing.Point(200, 256)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(72, 32)
        Me.edit.TabIndex = 5
        Me.edit.Text = " ⁄œÌ·"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Location = New System.Drawing.Point(32, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(440, 64)
        Me.Label9.TabIndex = 56
        '
        'invoice_no_txt
        '
        Me.invoice_no_txt.BackColor = System.Drawing.Color.White
        Me.invoice_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.invoice_no_txt.Location = New System.Drawing.Point(160, 104)
        Me.invoice_no_txt.Name = "invoice_no_txt"
        Me.invoice_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.invoice_no_txt.Size = New System.Drawing.Size(184, 20)
        Me.invoice_no_txt.TabIndex = 57
        Me.invoice_no_txt.Text = ""
        '
        'part_txt
        '
        Me.part_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.part_txt.Location = New System.Drawing.Point(120, 144)
        Me.part_txt.Name = "part_txt"
        Me.part_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.part_txt.Size = New System.Drawing.Size(224, 20)
        Me.part_txt.TabIndex = 0
        Me.part_txt.Text = ""
        '
        'cost_txt
        '
        Me.cost_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cost_txt.Location = New System.Drawing.Point(96, 184)
        Me.cost_txt.Name = "cost_txt"
        Me.cost_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cost_txt.Size = New System.Drawing.Size(248, 20)
        Me.cost_txt.TabIndex = 1
        Me.cost_txt.Text = ""
        '
        'search
        '
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.search.Location = New System.Drawing.Point(128, 256)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(64, 32)
        Me.search.TabIndex = 6
        Me.search.Text = "»ÕÀ"
        '
        'dell
        '
        Me.dell.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dell.Location = New System.Drawing.Point(56, 256)
        Me.dell.Name = "dell"
        Me.dell.Size = New System.Drawing.Size(64, 32)
        Me.dell.TabIndex = 7
        Me.dell.Text = "Õ–›"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(88, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "«·ﬂ„Ì…"
        '
        'count_txt
        '
        Me.count_txt.Location = New System.Drawing.Point(16, 143)
        Me.count_txt.Name = "count_txt"
        Me.count_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.count_txt.Size = New System.Drawing.Size(64, 20)
        Me.count_txt.TabIndex = 2
        Me.count_txt.Text = ""
        '
        'parts
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(528, 333)
        Me.Controls.Add(Me.count_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dell)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.cost_txt)
        Me.Controls.Add(Me.part_txt)
        Me.Controls.Add(Me.invoice_no_txt)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.add1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Name = "parts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "«·«”»Ì—« "
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add1.Click
        Call clear()
        bt_add1(edit, add1, save, search, dell)
    End Sub

    Private Sub dell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dell.Click
        bt_dell(edit, add1, save, search, dell)
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim str As String
        str = MsgBox("·ﬁœ  —Ìœ Õ–› «·”Ã· «·–Ï ÌÕ„· «·—ﬁ„  :-" + "  " + invoice_no_txt.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Information, " ‰»ÌÂ")
        If str = vbYes Then
            '**********************************

            Dim cmd3 As New SqlClient.SqlCommand("DELETE FROM parts WHERE invoice_no =  '" & invoice_no_txt.Text & "'", Con)
            Dim da3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd3)
            'da3.Fill(dt3)
            cmd3.ExecuteNonQuery()

            Call clear()
            MsgBox("·ﬁœ  „ Õ–› «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        End If
        'If str = vbNo Then
        '    Exit Sub
        'End If
        Try
            

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
        '***************************************
        Call clear()
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If IsNumeric(count_txt.Text) = False Then
            MsgBox("√œŒ«· «—ﬁ«„ ›ﬁÿ ›Ï Œ«‰… «·ﬂ„Ì…")
        End If
        If IsNumeric(cost_txt.Text) = False Then
            MsgBox("√œŒ«· «—ﬁ«„ ›ﬁÿ ›Ï Œ«‰… «·”⁄—")
        End If
        If Trim(invoice_no_txt.Text) = "" Or Trim(part_txt.Text) = "" Or Trim(cost_txt.Text) = "" Or Trim(count_txt.Text) = "" Then
            Exit Sub
        End If
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        If Trim(invoice_no_txt.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        bt_save(edit, add1, save, search, dell)
        Dim totall As Integer
        totall = Val(count_txt.Text * cost_txt.Text)
        '***********************************************************************************
        Dim cmdString As String = "INSERT INTO parts " + _
                                                         "(invoice_no,part_name,cost,quntety,totel)" + _
                                                         "VALUES('" & invoice_no_txt.Text.Trim & "','" & part_txt.Text.Trim & "','" & cost_txt.Text.Trim & "','" & count_txt.Text.Trim & "','" & totall & "')"

        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)

        cmd.ExecuteNonQuery()
        Try
            MsgBox("·ﬁœ  „ Õ›Ÿ «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
        '*****************************
        'Dim Cmd As New SqlClient.SqlCommand("txtparts_Insert", Con)
        'With Cmd
        '    .CommandType = CommandType.StoredProcedure
        '    .Parameters.Add("@sinvoice_no", invoice_no_txt.Text.Trim)
        '    .Parameters.Add("@spart_name", part_txt.Text.Trim)
        '    .Parameters.Add("@scost", cost_txt.Text.Trim)
        '    .Parameters.Add("@iquntety", count_txt.Text.Trim)
        '    .Parameters.Add("@itotal", total)

        '    Cmd.ExecuteNonQuery()
        'MsgBox("·ﬁœ  „ Õ›Ÿ «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        ''    Try
        ''    Catch ex As Exception
        ''        MsgBox(ex.ToString)
        ''    End Try
        ''    Con.Close()
        'End With
        'Call clear()
        'Dim cmdString As String = "INSERT INTO parts " + _
        '                           "(invoice_no,part_name,cost) " + _
        '                           "VALUES('" & invoice_no_txt.Text & "','" & part_txt.Text & "','" & cost_txt.Text & "')"
        'Dim cmd As New SqlClient.SqlCommand(cmdString, oconnection)
        ''MsgBox("well22")
        'cmd.ExecuteNonQuery()
        ''oconnection.Close()
        ''Response.Redirect(Request.Path, False)
    End Sub
    Private Sub clear()
        'invoice_no_txt.Text = ""
        part_txt.Text = ""
        cost_txt.Text = ""
        count_txt.Text = ""
    End Sub
    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim message, title, defaultValue As String
        message = " «œŒ· —ﬁ„ «·›« Ê—… «·„—«œ «·»ÕÀ ⁄‰Â "
        title = "»ÕÀ"
        invoice_no_txt.Text = InputBox(message, title, defaultValue, MsgBoxStyle.OKOnly)
        If Trim(invoice_no_txt.Text) = "" Then
            MsgBox("ÌÃ» «Œ Ì«— «·—ﬁ„ «·„ ”·”· √Ê·«")
            Exit Sub
        End If
        '*********************************************
        ''Dim Cmd1 As New SqlClient.SqlCommand("SELECT * FROM car2_data where car2_no='" & car2_no_txt.Text.Trim & "'", Con)
        '''With Cmd1
        '''    .CommandType = CommandType.StoredProcedure
        '''    .Parameters.Add("@icar2_no", car2_no_txt.Text)
        '''End With
        ''Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd1)
        ''da1.Fill(dt1)
        ''Cmd1.ExecuteNonQuery()
        '******************************
        Dim DS As New DataSet
        Dim t As DataTable
        Dim cmd2 As New SqlClient.SqlCommand("select * FROM parts WHERE invoice_no='" & invoice_no_txt.Text & "'", Con)
        Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        dr.Read()
        'If dr.Rows(0).Item("car2_name") Is DBNull.Value Then
        If dr.HasRows = False Then
            MsgBox("·« ÊÃœ ›« Ê—…  Õ„· «·—ﬁ„  :-" + "  " + invoice_no_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            invoice_no_txt.Text = ""
            Exit Sub
        End If
        bt_search(edit, add1, save, search, dell)
        invoice_no_txt.Text = dr.Item("invoice_no")
        part_txt.Text = dr.Item("part_name")
        cost_txt.Text = dr.Item("cost")
        count_txt.Text = dr.Item("quntety")
        dr.Close()
        Con.Close()
        Try
        Catch er As Exception
            MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√
        End Try
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bt_low(edit, add1, save, search, dell)
        Dim de As New invoicecar2
        Me.invoice_no_txt.Text = ad

        '" & df.UserID.Text & "'
        'Try
        '    Dim sd As New invoicecar2
        '    'Dim qq As String = sd.invoice_no.Text
        '     invoice_no_txt.Text = sd.invoice_no.Text
        '     MsgBox(sd.invoice_no)
        '    'Dim ww As New invoicecar2
        '    'Dim inv As String = ww.invoice_no.Text
        '    'invoice_no_txt.Text = ww.invoice_no.Text
        '      Catch er As Exception
        '     MessageBox.Show(er.Message)
        'End Try
    End Sub

    Private Sub invoice_no_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles invoice_no_txt.TextChanged

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        If IsNumeric(count_txt.Text) = False Then
            MsgBox("√œŒ«· «—ﬁ«„ ›ﬁÿ ›Ï Œ«‰… «·ﬂ„Ì…")
            Exit Sub
        End If
        If IsNumeric(cost_txt.Text) = False Then
            MsgBox("√œŒ«· «—ﬁ«„ ›ﬁÿ ›Ï Œ«‰… «·”⁄—")
            Exit Sub
        End If
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If

        Dim totall As New Int32
        totall = Val(count_txt.Text * cost_txt.Text)
        Con.Open()
        If Trim(invoice_no_txt.Text) = "" Or Trim(part_txt.Text) = "" Or Trim(cost_txt.Text) = "" Or Trim(count_txt.Text) = "" Then
            Exit Sub
        End If
        Dim cmdString As String = "UPDATE parts " + _
                                                    "SET  totel = '" & totall & "',invoice_no = '" & invoice_no_txt.Text & "', part_name= '" & part_txt.Text & "', cost= '" & cost_txt.Text & "', QUNTETY='" & count_txt.Text & "' " + _
                                                    "WHERE invoice_no = '" + invoice_no_txt.Text + "'"
        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        bt_edit(edit, add1, save, search, dell)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("·ﬁœ  „  ⁄œÌ· «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
    End Sub
End Class
