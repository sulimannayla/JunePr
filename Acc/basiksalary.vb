Public Class basiksalary
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents dell As System.Windows.Forms.Button
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents add1 As System.Windows.Forms.Button
    Friend WithEvents degree As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents degree_txt As System.Windows.Forms.ComboBox
    Friend WithEvents basic_sal_txt As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Protected WithEvents section_count As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dell = New System.Windows.Forms.Button
        Me.search = New System.Windows.Forms.Button
        Me.edit = New System.Windows.Forms.Button
        Me.save = New System.Windows.Forms.Button
        Me.add1 = New System.Windows.Forms.Button
        Me.degree = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.section_count = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.basic_sal_txt = New System.Windows.Forms.TextBox
        Me.degree_txt = New System.Windows.Forms.ComboBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.DataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.Silver
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGrid1.CaptionForeColor = System.Drawing.SystemColors.Info
        Me.DataGrid1.CaptionText = "fgfdgfdgfdgdf222"
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Font = New System.Drawing.Font("Simplified Arabic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGrid1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.DataGrid1.GridLineColor = System.Drawing.SystemColors.AppWorkspace
        Me.DataGrid1.HeaderBackColor = System.Drawing.SystemColors.Desktop
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGrid1.LinkColor = System.Drawing.SystemColors.HighlightText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 256)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGrid1.RowHeaderWidth = 30
        Me.DataGrid1.Size = New System.Drawing.Size(592, 232)
        Me.DataGrid1.TabIndex = 119
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.SystemColors.Desktop
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridTableStyle1.MappingName = ""
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.Silver
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "«·„ ”·”·"
        Me.DataGridTextBoxColumn1.MappingName = "ser"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "«”„ «·œ—Ã…"
        Me.DataGridTextBoxColumn2.MappingName = "dgree_name"
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "«·ﬁÿ«⁄"
        Me.DataGridTextBoxColumn4.MappingName = "section_count"
        Me.DataGridTextBoxColumn4.Width = 110
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "«·«”«”Ì"
        Me.DataGridTextBoxColumn3.MappingName = "basic_sal"
        Me.DataGridTextBoxColumn3.Width = 200
        '
        'dell
        '
        Me.dell.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dell.Location = New System.Drawing.Point(75, 196)
        Me.dell.Name = "dell"
        Me.dell.Size = New System.Drawing.Size(72, 32)
        Me.dell.TabIndex = 7
        Me.dell.Text = "Õ–›"
        '
        'search
        '
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.search.Location = New System.Drawing.Point(159, 196)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(72, 32)
        Me.search.TabIndex = 6
        Me.search.Text = "»ÕÀ"
        '
        'edit
        '
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.edit.Location = New System.Drawing.Point(242, 196)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(80, 32)
        Me.edit.TabIndex = 5
        Me.edit.Text = " ⁄œÌ·"
        '
        'save
        '
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.save.Location = New System.Drawing.Point(331, 196)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(88, 32)
        Me.save.TabIndex = 3
        Me.save.Text = "Õ›Ÿ"
        '
        'add1
        '
        Me.add1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.add1.Location = New System.Drawing.Point(427, 196)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(88, 32)
        Me.add1.TabIndex = 4
        Me.add1.Text = "ÃœÌœ"
        '
        'degree
        '
        Me.degree.BackColor = System.Drawing.Color.DarkGray
        Me.degree.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.degree.Location = New System.Drawing.Point(376, 22)
        Me.degree.Name = "degree"
        Me.degree.Size = New System.Drawing.Size(88, 24)
        Me.degree.TabIndex = 107
        Me.degree.Text = "«·œ—Ã… «·ÊŸÌ›…"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(59, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(471, 56)
        Me.Label3.TabIndex = 116
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(427, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 111
        Me.Button1.Text = "ÃœÌœ"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(331, 191)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 114
        Me.Button2.Text = "Õ›Ÿ"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.Location = New System.Drawing.Point(315, 191)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 32)
        Me.Button3.TabIndex = 113
        Me.Button3.Text = "Õ›Ÿ"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.Location = New System.Drawing.Point(155, 191)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 32)
        Me.Button4.TabIndex = 117
        Me.Button4.Text = "»ÕÀ"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button5.Location = New System.Drawing.Point(235, 191)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 32)
        Me.Button5.TabIndex = 115
        Me.Button5.Text = " ⁄œÌ·"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button6.Location = New System.Drawing.Point(411, 191)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 32)
        Me.Button6.TabIndex = 112
        Me.Button6.Text = "ÃœÌœ"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.section_count)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.basic_sal_txt)
        Me.GroupBox1.Controls.Add(Me.degree_txt)
        Me.GroupBox1.Controls.Add(Me.degree)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(593, 168)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        '
        'section_count
        '
        Me.section_count.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.section_count.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.section_count.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.section_count.Location = New System.Drawing.Point(256, 112)
        Me.section_count.Name = "section_count"
        Me.section_count.Size = New System.Drawing.Size(104, 21)
        Me.section_count.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(376, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 24)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "«·ﬁÿ«⁄"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(368, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "«·—« » «·«”«”Ì"
        '
        'basic_sal_txt
        '
        Me.basic_sal_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.basic_sal_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.basic_sal_txt.Location = New System.Drawing.Point(192, 64)
        Me.basic_sal_txt.Name = "basic_sal_txt"
        Me.basic_sal_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.basic_sal_txt.Size = New System.Drawing.Size(176, 20)
        Me.basic_sal_txt.TabIndex = 1
        Me.basic_sal_txt.Text = ""
        '
        'degree_txt
        '
        Me.degree_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.degree_txt.Location = New System.Drawing.Point(136, 24)
        Me.degree_txt.Name = "degree_txt"
        Me.degree_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.degree_txt.Size = New System.Drawing.Size(232, 21)
        Me.degree_txt.TabIndex = 0
        '
        'basiksalary
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(608, 501)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.dell)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.add1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "basiksalary"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "«·—« » «·«”«”Ï"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
    
    Private Sub basiksalary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bt_low(edit, add1, save, search, dell)
        save.Enabled = True
        Dim DS As New DataSet
        Dim str As String = "SELECT DISTINCT  dgree_name  FROM dgree_base"
        Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        ADP.Fill(DS)
        Dim i As Integer
        For i = 0 To DS.Tables(0).Rows.Count - 1
            Me.degree_txt.Items.Add(DS.Tables(0).Rows(i).Item(0))
        Next
        ADP.Dispose()
        'Dim ADPt22 As SqlClient.SqlDataAdapter
        'Dim cmd121 = "SELECT * FROM basic_salary_emp,dgree_base where basic_salary_emp.degree_id=dgree_base.dgree_id  "
        'Dim dt1 As New DataTable
        'ADPt22 = New SqlClient.SqlDataAdapter(cmd121, Con)
        'ADPt22.Fill(dt1)
        'DataGrid1.DataSource = dt1
        dell.Enabled = False

    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        If Trim(degree_txt.Text) = "" Or Trim(basic_sal_txt.Text) = "" Or Trim(section_count.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        '===
        If Not IsNumeric(basic_sal_txt.Text) Then
            MsgBox("«œŒ· «—ﬁ«„ ›ﬁÿ ›Ï «·—« » «·«”«”Ì ")
            Exit Sub
        End If
        '===
        bt_save(edit, add1, save, search, dell)
        Dim DS5 As New DataSet
        Dim t5 As DataTable
        Dim cmd5 As New SqlClient.SqlCommand("SELECT dgree_base.dgree_id,degrees_classes.class_id FROM dgree_base,degrees_classes where dgree_base.dgree_id=degrees_classes.degree_id  and dgree_base.dgree_name  ='" & degree_txt.Text & "'", Con)
        Dim dr5 As SqlClient.SqlDataReader = cmd5.ExecuteReader()
        dr5.Read()
        Dim dgree_i_d As String = dr5.Item("dgree_id")
        Dim class_i_d As Integer = dr5.Item("class_id")
        dr5.Close()
        '=======================================================================================

        'Dim ADPt1 As SqlClient.SqlDataAdapter
        'Dim cmdt = "SELECT * FROM basic_salary_emp,dgree_base where basic_salary_emp.degree_id=dgree_base.dgree_id and basic_salary_emp.degree_id= '" & dgree_i_d & "'"
        'ADPt1 = New SqlClient.SqlDataAdapter(cmdt, Con)
        'Dim dt4 As New DataTable
        'ADPt1.Fill(dt4)
        'If dt4.Rows.Count >= 1 Then
        '    MsgBox("Â–Â «·œ—Ã… ·ﬁœ  „ ≈œŒ«·Â«")
        '    Exit Sub
        'End If

        '------------------------------------------------------------------------
        Dim cmdString As String = "INSERT INTO basic_salary_emp " + _
                           "(degree_id,basic_sal,section_count,class_id) " + _
                           "VALUES('" & dgree_i_d & "','" & basic_sal_txt.Text.Trim & "','" & section_count.Text.Trim & "','" & class_i_d & "')"
        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("·ﬁœ  „ Õ›Ÿ «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
        edit.Enabled = False

        Dim ADPt22 As SqlClient.SqlDataAdapter
        'Dim cmd121 = "SELECT * FROM basic_salary_emp,dgree_base where basic_salary_emp.degree_id=dgree_base.dgree_id  "

        Dim cmd121 = "SELECT * FROM basic_salary_emp,dgree_base where basic_salary_emp.degree_id=dgree_base.dgree_id and dgree_base.dgree_name='" & degree_txt.Text & "'"
        Dim dt1 As New DataTable
        ADPt22 = New SqlClient.SqlDataAdapter(cmd121, Con)
        ADPt22.Fill(dt1)
        DataGrid1.DataSource = dt1
        dell.Enabled = False


    End Sub


    Private Sub class_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'degree_txt.Items.Clear()
        'degree_txt.Text = ""
        'If Con.State = ConnectionState.Broken = False Then
        '    Con.Close()
        'End If
        'Con.Open()

        'Dim dt1 As New DataTable
        'Dim dt2 As New DataTable
        'Dim DS As New DataSet
        'Dim t As DataTable
        'Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM classes where class_name='" & class_txt.Text & "'", Con)
        'Dim da2 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        'da2.Fill(dt1)
        'cmd2.ExecuteNonQuery()
        'If dt1.Rows.Count < 1 Then
        '    MsgBox(" :-" + "  " + class_txt.Text, MsgBoxStyle.Information, "Note")
        '    'class_txt.Text = ""
        '    Exit Sub
        'End If
        'Dim mainid = dt1.Rows(0).Item("class_id")
        ''------------------------------------------------
        'Try
        '    Dim DS1 As New DataSet
        '    Dim str As String = "SELECT DISTINCT degree_name FROM degrees,classes where degrees.class_id = classes.class_id and degrees.class_id='" & mainid & "'"
        '    Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        '    ADP.Fill(DS1)
        '    Dim i As Integer
        '    For i = 0 To DS1.Tables(0).Rows.Count - 1
        '        Me.degree_txt.Items.Add(DS1.Tables(0).Rows(i).Item(0))
        '    Next
        '    ADP.Dispose()
        'Catch er As Exception
        '    MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√
        'End Try

    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        Dim DS As New DataSet
        Dim t As DataTable

        Dim message, title, defaultValue As String
        Dim m As Integer
        'message = " «œŒ· «”„ «·œ—Ã… «·„—«œ «·»ÕÀ ⁄‰Â "
        'title = "»ÕÀ"
        'degree_txt.Text = InputBox(message, title, defaultValue, MsgBoxStyle.OKOnly)
        If Trim(degree_txt.Text) = "" Then
            MsgBox("ÌÃ» «Œ Ì«— «·«”„  √Ê·«")
            edit.Enabled = False
            dell.Enabled = False
            Exit Sub
        End If
        Dim x As String
        Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM basic_salary_emp,dgree_base where basic_salary_emp.degree_id=dgree_base.dgree_id  and dgree_base.dgree_name='" & degree_txt.Text & "'", Con)
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count < 1 Then
            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «·«”„  :-" + "  " + degree_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            degree_txt.Text = ""
            edit.Enabled = False
            dell.Enabled = False
            Exit Sub
        End If
        bt_search(edit, add1, save, search, dell)
        '====================================================
        Dim ADPt22 As SqlClient.SqlDataAdapter
        Dim cmd121 = "SELECT * FROM basic_salary_emp,dgree_base where basic_salary_emp.degree_id=dgree_base.dgree_id and dgree_base.dgree_name='" & degree_txt.Text & "'"
        Dim dt1 As New DataTable
        ADPt22 = New SqlClient.SqlDataAdapter(cmd121, Con)
        ADPt22.Fill(dt1)
        DataGrid1.DataSource = dt
        '====================================================
        'degree_txt.Text = dt.Rows(0).Item("dgree_name")
        'basic_sal_txt.Text = dt.Rows(0).Item("basic_sal")
        'section_count.Text = dt.Rows(0).Item("section_count")

        Try
            'cmd2.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
        edit.Enabled = False
        dell.Enabled = False

    End Sub

    Private Sub degree_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles degree_txt.SelectedIndexChanged
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()


        Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM dgree_base where dgree_name='" & degree_txt.Text & "'", Con)
        Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        dr.Read()
        If dr.Item("sec_count") Is DBNull.Value = True Then
            MsgBox("ﬁ„ » ÕœÌœ ⁄œœ ﬁÿ«⁄«  Â–Â «·œ—Ã… «Ê·«")
            Con.Close()
            Exit Sub
        ElseIf dr.Item("sec_count") = 0 Then
            MsgBox("ﬁ„ » ÕœÌœ ⁄œœ ﬁÿ«⁄«  Â–Â «·œ—Ã… «Ê·«")
            Exit Sub
        End If
        section_count.Text = ""
        section_count.Items.Clear()
        Dim deg_id = dr.Item("sec_count")
        Dim i As Integer
        For i = 1 To deg_id
            Me.section_count.Items.Add(i)
        Next
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
    End Sub

    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add1.Click
        basic_sal_txt.Text = ""
        section_count.Text = ""
        'degree_txt.Text = ""
        add1.Enabled = True
        save.Enabled = True
        edit.Enabled = False
        dell.Enabled = False
    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
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
            'Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM basic_salary_emp where    degree_id='" & DataGrid1.Item(row, 1) & "'", Con)
            Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM basic_salary_emp,dgree_base where basic_salary_emp.degree_id=dgree_base.dgree_id  and basic_salary_emp.ser='" & DataGrid1.Item(row, 0) & "'", Con)
            Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
            If dr.HasRows = False Then

                Exit Sub
            End If
            dr.Read()
            bt_search(edit, add1, save, search, dell)
            'id = ""
            sryal = dr.Item("ser")
            dg_id = dr.Item("degree_id")
            degree_txt.Text = dr.Item("dgree_name")
            basic_sal_txt.Text = dr.Item("basic_sal")
            section_count.Text = dr.Item("section_count")
            dr.Close()
            edit.Enabled = True
            dell.Enabled = True
            Try
            Catch er As Exception
                MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√
            End Try
            Con.Close()
        End If
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        If Trim(degree_txt.Text) = "" Or Trim(basic_sal_txt.Text) = "" Or Trim(section_count.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        bt_edit(edit, add1, save, search, dell)
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If

        Con.Open()
        '-----------------------------------------------------------

        Dim DS5 As New DataSet
        Dim t5 As DataTable
        Dim cmd5 As New SqlClient.SqlCommand("SELECT dgree_id FROM dgree_base where dgree_name ='" & degree_txt.Text & "'", Con)
        Dim dr5 As SqlClient.SqlDataReader = cmd5.ExecuteReader()
        dr5.Read()
        Dim dgree_i_d As Integer = dr5.Item("dgree_id")
        dr5.Close()
        '-----------------------------------------------------------------------



        Dim cmdString As String = "UPDATE basic_salary_emp " + _
                                            "SET degree_id = '" & dgree_i_d & "',basic_sal = '" & basic_sal_txt.Text & "',section_count = '" & section_count.Text & "' " + _
                                            "WHERE ser = '" & sryal & "'"
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






        Dim ADPt22 As SqlClient.SqlDataAdapter
        'Dim cmd121 = "SELECT * FROM basic_salary_emp,dgree_base where basic_salary_emp.degree_id=dgree_base.dgree_id and basic_salary_emp.degree_id='" & dgree_i_d & "'  "
        Dim cmd121 = "SELECT * FROM basic_salary_emp,dgree_base where basic_salary_emp.degree_id=dgree_base.dgree_id and dgree_base.dgree_name='" & degree_txt.Text & "'"
        Dim dt1 As New DataTable
        ADPt22 = New SqlClient.SqlDataAdapter(cmd121, Con)
        ADPt22.Fill(dt1)
        DataGrid1.DataSource = dt1
        dell.Enabled = False

    End Sub

    Private Sub dell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dell.Click
        bt_dell(edit, add1, save, search, dell)
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim str As String
        str = MsgBox("Â·  —Ìœ Õ–› «·”Ã·" + "  ", MsgBoxStyle.YesNo + MsgBoxStyle.Information, " ‰»ÌÂ")
        If str = vbYes Then
            '--------            
            Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM dgree_base where dgree_name='" & degree_txt.Text & "'", Con)
            Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
            dr.Read()
            Dim deg_id = dr.Item("dgree_id")
            dr.Close()
            '--------

            'Dim cmd3 As New SqlClient.SqlCommand("DELETE FROM  basic_salary_emp WHERE degree_id =  '" & deg_id & "'", Con)
            Dim cmd3 As New SqlClient.SqlCommand("DELETE FROM  basic_salary_emp WHERE ser =  '" & sryal & "'", Con)
            Dim da3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd3)
            cmd3.ExecuteNonQuery()
        Else
            Exit Sub
        End If
        Try
            bt_add1(edit, add1, save, search, dell)
            'degree_txt.Text = ""

            MsgBox("·ﬁœ  „ Õ–› «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
            sryal = 0
            basic_sal_txt.Text = ""
            section_count.Text = ""
            'degree_txt.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dell.Enabled = False
        edit.Enabled = False
        add1.Enabled = True

        '----------------------------------------------------------


        Dim ADPt22 As SqlClient.SqlDataAdapter
        'Dim cmd121 = "SELECT * FROM basic_salary_emp,dgree_base where basic_salary_emp.degree_id=dgree_base.dgree_id   "        
        Dim cmd121 = "SELECT * FROM basic_salary_emp,dgree_base where basic_salary_emp.degree_id=dgree_base.dgree_id and dgree_base.dgree_name='" & degree_txt.Text & "'"
        Dim dt1 As New DataTable
        ADPt22 = New SqlClient.SqlDataAdapter(cmd121, Con)
        ADPt22.Fill(dt1)
        DataGrid1.DataSource = dt1


    End Sub

    Private Sub degree_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles degree_txt.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub basic_sal_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles basic_sal_txt.TextChanged

    End Sub

    Private Sub basic_sal_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles basic_sal_txt.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub section_count_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles section_count.SelectedIndexChanged

    End Sub

    Private Sub section_count_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles section_count.KeyPress


        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
