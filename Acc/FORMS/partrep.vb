Public Class partrep
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents car2_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Viewer1 = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.Label1 = New System.Windows.Forms.Label
        Me.car2_no_txt = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.CheckedListBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Viewer1
        '
        Me.Viewer1.BackColor = System.Drawing.SystemColors.Control
        Me.Viewer1.Location = New System.Drawing.Point(0, 128)
        Me.Viewer1.Name = "Viewer1"
        Me.Viewer1.ReportViewer.CurrentPage = 0
        Me.Viewer1.ReportViewer.MultiplePageCols = 3
        Me.Viewer1.ReportViewer.MultiplePageRows = 2
        Me.Viewer1.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.Viewer1.Size = New System.Drawing.Size(808, 464)
        Me.Viewer1.TabIndex = 0
        Me.Viewer1.TableOfContents.Text = "Table Of Contents"
        Me.Viewer1.TableOfContents.Width = 200
        Me.Viewer1.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(672, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 22)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "—ﬁ‹‹„ «·⁄‹‹—»…"
        '
        'car2_no_txt
        '
        Me.car2_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.car2_no_txt.Location = New System.Drawing.Point(536, 32)
        Me.car2_no_txt.Name = "car2_no_txt"
        Me.car2_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.car2_no_txt.Size = New System.Drawing.Size(128, 20)
        Me.car2_no_txt.TabIndex = 34
        Me.car2_no_txt.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(512, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 64)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Simplified Arabic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 24)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "«Œ— «·√”»Ì‹‹—«  «· Ì  „ ’—›Â«"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Miriam Fixed", 11.25!)
        Me.Button2.Location = New System.Drawing.Point(336, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 24)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "»Õ‹‹‹‹‹‹‹À"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Miriam Fixed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Button1.Location = New System.Drawing.Point(340, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 24)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "⁄—÷ «· ﬁ—Ì—"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(80, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox1.ScrollAlwaysVisible = True
        Me.ComboBox1.Size = New System.Drawing.Size(192, 89)
        Me.ComboBox1.TabIndex = 80
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Miriam Fixed", 11.25!)
        Me.Button3.Location = New System.Drawing.Point(341, 80)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 24)
        Me.Button3.TabIndex = 81
        Me.Button3.Text = "≈‰Â‹‹‹‹‹‹‹‹‹‹«¡"
        '
        'partrep
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(804, 549)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.car2_no_txt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Viewer1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "partrep"
        Me.Text = "«¯Œ—  «—ÌŒ ·’—› «·«”»Ì—«  «·„Õœœ…"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Viewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Viewer1.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Trim(car2_no_txt.Text) = "" Then
            MsgBox("√œŒ· —ﬁ„ «·⁄—»… ")
            ComboBox1.Text = ""
            ComboBox1.Items.Clear()
            Exit Sub
        End If
        Dim i As Integer
        Try
            Dim DS6 As New DataSet
            Dim str6 As String = "SELECT DISTINCT parts.part_name FROM parts , invoice where invoice.invoice_no = parts.invoice_no and invoice.car2_no= '" & car2_no_txt.Text & "' "
            Dim ADP6 As New SqlClient.SqlDataAdapter(str6, Con)
            ADP6.Fill(DS6)
            Dim i6 As Integer
            'If DS.Rows(0).Item("group_no") Is DBNull.Value Then
            If DS6.Tables(0).Rows.Count < 1 Then
                MsgBox("·„ Ì’—› «”»Ì— „‰ ﬁ»· ")
                ComboBox1.Text = ""
                ComboBox1.Items.Clear()
                Exit Sub
            Else

                ComboBox1.Items.Clear()
                For i = 0 To DS6.Tables(0).Rows.Count - 1
                    Me.ComboBox1.Items.Add(DS6.Tables(0).Rows(i).Item(0))
                Next
                ADP6.Dispose()
            End If
            '///////////////////////////////////////////////////////
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Trim(car2_no_txt.Text) = "" Then
            MsgBox("√œŒ· —ﬁ„ «·⁄—»… ")
            ComboBox1.Text = ""
            ComboBox1.Items.Clear()
            Exit Sub
        End If
        '****************************
        'Dim DS As New DataSet
        'Dim str As String = "SELECT DISTINCT parts.part_name FROM parts , invoice where invoice.invoice_no = parts.invoice_no and invoice.car2_no= '" & car2_no_txt.Text & "' "
        'Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        'ADP.Fill(DS)
        'Dim i As Integer
        'If DS.Rows(0).Item("group_no") Is DBNull.Value Then
        'If DS.Tables(0).Rows.Count < 1 Then
        '    Label4.Text = "·„ Ì’—› «”»Ì— „‰ ﬁ»· "
        '    Con.Close()
        '    Exit Sub
        Dim qunt As Integer
        '**********************
        Dim indexChecked As Integer
        Dim itemChecked As Object
        Const quote As String = """"
        Dim _sqlString As String
        Dim _sqlString1 As String = ""
        Dim df As New SECURITY
        Dim _tmp As Cursor
        _tmp = Me.Cursor
        Me.Cursor = Cursors.WaitCursor
        Dim _rpt = New partreport

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
        '**************************

        For Each itemChecked In ComboBox1.CheckedItems
            Dim cmd11 As New SqlClient.SqlCommand("SELECT invoice.date,parts.quntety FROM invoice,parts WHERE date=(select max(date) FROM invoice , parts where invoice.invoice_no = parts.invoice_no and invoice.car2_no= '" & car2_no_txt.Text & "' and parts.part_name = '" & itemChecked & "') ", Con)
            'Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
            Dim da11 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd11)
            Dim dt As New DataTable
            da11.Fill(dt)
            If Con.State = ConnectionState.Broken = False Then
                Con.Close()
            End If
            Con.Open()
            If dt.Rows.Count < 1 Then
                MsgBox("·„ Ì „ ’—› ≈”»Ì— „‰ ﬁ»· ")
                'MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «·—ﬁ„  :-" + "  " + maintenance_id_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                ComboBox1.Text = ""
                ComboBox1.Items.Clear()
                Con.Close()
                Exit Sub
            End If
            Dim dq = dt.Rows(0).Item("date")
            qunt = dt.Rows(0).Item("quntety")
            Dim cmdString As String = "INSERT INTO tb1 " + _
                                       "(part_name,date,car2_no,quntety) " + _
                                       "VALUES('" & itemChecked & "','" & dq & "','" & car2_no_txt.Text & "','" & qunt & "')"
            Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
            cmd.ExecuteNonQuery()
        Next
        '***************************'" & ComboBox1. & "'******************* parts,invoice.car2_no,invoice.date,parts.quntety
        'Dim arrListQuery As New ArrayList

        'Â‰« Õ·ﬁ… ›Ê— ‰ﬂ”  · Õœœ «·ﬁÌ„ «·„Œ «—… „‰ «··”  »Êﬂ”

        '·« Ì‰»€Ì ⁄·Ìﬂ «” Œœ«„ ›Â—” «·ﬁ«∆„… ⁄‰œ «Œ Ì«— «·ﬁÌ„… 
        'Value ... SelectedIndices(i)

        'For i As Integer = 0 To Me.ComboBox1.Items.Count - 1

        '    If Me.ComboBox1.GetSelected(i) Then
        'Â‰« „ €Ì— · ⁄»∆… «·ﬁÌ„… √À‰«¡ «·‰ﬁ— ⁄·Ï √Õœ ﬁÌ„ «··”  »Êﬂ”
        '· ÕœÌœ ﬁÌ„… «·’› «·„Œ «— „‰ ﬁ«⁄œ… «·»Ì«‰«  Ê«·„⁄»√ ›Ì «··”  »Êﬂ”
        'rr'arrListQuery.Add("SELECT  invoice.car2_no,invoice.date ,parts.quntety  from invoice,parts where date=(select max(date) FROM invoice , parts where  parts.part_name= '" & itemChecked & "' and invoice.invoice_no = parts.invoice_no and invoice.car2_no= '" & car2_no_txt.Text & "')")

        'arrListQuery.Add("SELECT   parts.part_name  from parts,invoice where   parts.part_name= '" & itemChecked & "' and invoice.invoice_no = parts.invoice_no and invoice.car2_no= '" & car2_no_txt.Text & "'")
        '"INNER JOIN Asnaf  ON  Bekalh.ID = Asnaf.IDTypeE " & _
        '"WHERE date=(select max(date) FROM invoice , parts where invoice.invoice_no = parts.invoice_no and invoice.car2_no= '" & car2_no_txt.Text & "') and parts.part_name in(SELECT part_name from tb1 uonion  (select DISTINCT parts.part_name from parts) ))
        '        End If
        'Next

        'Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        'ADP.Fill(DS)
        '999999999999999999999999999999
        Dim DS6 As New DataSet
        'ssssssssssssssssssssssssssssssssssssssssssssss
        ''Dim str6 As String = "SELECT date FROM invoice,parts WHERE date=(select max(date) FROM invoice , parts where invoice.invoice_no = parts.invoice_no and invoice.car2_no= '" & car2_no_txt.Text & "') and  parts.part_name in(SELECT part_name from tb1)"
        Dim str6 As String = "SELECT * from tb1"
        'Dim str6 As String = "SELECT  parts.part_name , invoice.car2_no,invoice.date ,parts.quntety  from invoice,parts where date=(select max(date) FROM invoice , parts where    invoice.car2_no= '" & car2_no_txt.Text & "'    and invoice.invoice_no = parts.invoice_no )  and parts.part_name in(SELECT part_name from tb1 ) "
        ' last Dim str6 As String = "SELECT  invoice.car2_no,invoice.date ,parts.quntety,parts.part_name  from invoice,parts where date=(select max(date) FROM invoice , parts where invoice.invoice_no = parts.invoice_no and invoice.car2_no='" & car2_no_txt.Text & "' and parts.part_name in(SELECT part_name from tb1)) "
        'qqqqqq Dim str6 As String = "SELECT  invoice.car2_no,invoice.date ,parts.quntety,parts.part_name  from invoice,parts  where invoice.date = max(invoice.date) and  invoice.invoice_no = parts.invoice_no and invoice.car2_no='" & car2_no_txt.Text & "' and parts.part_name in(SELECT part_name from tb1)"

        'date=(select max(date) FROM invoice , parts where invoice.invoice_no = parts.invoice_no and invoice.car2_no= '" & car2_no_txt.Text & "' and parts.part_name = '" & ComboBox1.Text & "'
        'invoice,parts and ( SELECT  invoice.car2_no,invoice.date,parts.quntety ,parts.quntety from invoice,parts where   invoice.invoice_no = parts.invoice_no)  and parts.part_name in(SELECT part_name from tb1) and  invoice.car2_no= '" & car2_no_txt.Text & "'
        '6666666666666666666666666666
        'Dim da As SqlClient.SqlDataAdapter
        'Dim da = New SqlClient.SqlDataAdapter(Nothing, Con)
        'Dim da As SqlClient.SqlDataAdapter
        'Dim da As OleDb.OleDbDataAdapter
        Dim ADP6 As New SqlClient.SqlDataAdapter(str6, Con)
        ADP6.Fill(DS6)
        'da = New SqlClient.SqlDataAdapter(Nothing, Con)

        'da = New OleDb.OleDbDataAdapter(Nothing, Con)

        'Dim ds As New DataSet
        'MsgBox("3")



        'da.SelectCommand.CommandText = arrListQuery(1).ToString

        'For i As Integer = 0 To arrListQuery.Count - 1
        '    If Not IsNothing(arrListQuery(i)) Then
        '        'da.Fill(DS)
        '        'Assign the query string.
        '        'da.SelectCommand.CommandText = arrListQuery(i).ToString
        '        'da.Fill(ds)
        '        Dim ADP As New SqlClient.SqlDataAdapter(arrListQuery(i).ToString, Con)
        '        ADP.Fill(ds)
        '        '_DS.SQL =
        '        ' ⁄»∆… „Œ“‰ «·»Ì«‰«  „‰ «·«” ⁄·«„ «·„Õœœ
        '        'ADP.ex()
        '    End If
        'Next

        '_DS.SQL = da.Fill(DS, "sqldatagrid")
        '_DS.SQL = da.SelectCommand

        ''555555555555
        'Dim da As New SqlClient.SqlDataAdapter(DS6, Con)
        'ADP6.Fill(DS6)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '_DS.SQL = "SELECT DISTINCT parts.part_name from parts union SELECT  invoice.car2_no,invoice.date,parts.quntety ,parts.quntety from invoice,parts where parts.part_name in(SELECT part_name from tb1) and  invoice.invoice_no = parts.invoice_no  and invoice.car2_no= '" & car2_no_txt.Text & "',con"
        _DS.SQL = ADP6.SelectCommand.CommandText
        '(SELECT date FROM invoice WHERE date=(select max(date) FROM invoice)
        'Next
        '_DS.SQL = _sqlString
        'ComboBox1.DataSource = _DS.SQL
        'ComboBox1.DataSource = itemChecked.ToString()
        '_rpt.DataSource = ComboBox1.DataSource
        'MsgBox(itemChecked.ToString())
        'MessageBox.Show("Item with title: " + quote + itemChecked.ToString() + quote + _
        '                            ", is checked. Checked state is: " + _
        'ComboBox1.GetItemCheckState(ComboBox1.Items.IndexOf(itemChecked)).ToString() + ".")
        'ComboBox1.GetItemCheckState(ComboBox1.Items.IndexOf(itemChecked)).ToString() + ".")
        '_DS.SQL = _sqlString
        'Dim _sqlString As String = "SELECT invoice.date,invoice.car2_no,parts.quntety ,parts.part_name FROM invoice,parts WHERE date=(select max(date) FROM invoice , parts) where invoice.invoice_no = parts.invoice_no and invoice.car2_no= '" & car2_no_txt.Text & "' and parts.part_name = '" & ComboBox1.Text & "'"
        _rpt.DataSource = _DS
        '***************************************************,parts.quntety,parts.part_name
        Me.Viewer1.Document = _rpt.Document
        _rpt.Run(False)
        Me.Cursor = _tmp
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        For Each itemChecked In ComboBox1.CheckedItems
            Dim cmd3 As New SqlClient.SqlCommand("DELETE FROM tb1 WHERE part_name =  '" & itemChecked & "'", Con)

            Dim da3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd3)
            cmd3.ExecuteNonQuery()

        Next

        Con.Close()
    End Sub

    Private Sub car2_no_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles car2_no_txt.TextChanged

    End Sub

    Private Sub car2_no_txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles car2_no_txt.LostFocus


    End Sub

    Private Sub car2_no_txt_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles car2_no_txt.MouseEnter

    End Sub

    Private Sub ComboBox1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)

    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)


    End Sub

    Private Sub partrep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim indexChecked As Integer
        Dim itemChecked As Object
        Const quote As String = """"

        For Each itemChecked In ComboBox1.CheckedItems
            Dim cmd3 As New SqlClient.SqlCommand("DELETE FROM tb1 WHERE part_name =  '" & itemChecked & "'", Con)

            Dim da3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd3)
            cmd3.ExecuteNonQuery()

        Next


        'Dim indexChecked As Integer
        'Dim itemChecked As Object
        'Const quote As String = """"
        'For Each itemChecked In ComboBox1.CheckedItems
        '    ' Use the IndexOf method to get the index of an item.
        '    MessageBox.Show("Item with title: " + quote + itemChecked.ToString() + quote + _
        '                    ", is checked. Checked state is: " + _
        '                    ComboBox1.GetItemCheckState(ComboBox1.Items.IndexOf(itemChecked)).ToString() + ".")
        'Next

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
