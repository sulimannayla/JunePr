Public Class diff
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents site_txt As System.Windows.Forms.ComboBox
    Friend WithEvents degree As System.Windows.Forms.Label
    Friend WithEvents class_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents date_2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents eyer_txt1 As System.Windows.Forms.ComboBox
    Friend WithEvents date_1 As System.Windows.Forms.ComboBox
    Friend WithEvents eyer_txt2 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Viewer1 = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.site_txt = New System.Windows.Forms.ComboBox
        Me.degree = New System.Windows.Forms.Label
        Me.class_txt = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.eyer_txt1 = New System.Windows.Forms.ComboBox
        Me.date_1 = New System.Windows.Forms.ComboBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.date_2 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.eyer_txt2 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Viewer1
        '
        Me.Viewer1.BackColor = System.Drawing.SystemColors.Control
        Me.Viewer1.Location = New System.Drawing.Point(0, 176)
        Me.Viewer1.Name = "Viewer1"
        Me.Viewer1.ReportViewer.CurrentPage = 0
        Me.Viewer1.ReportViewer.MultiplePageCols = 3
        Me.Viewer1.ReportViewer.MultiplePageRows = 2
        Me.Viewer1.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.Viewer1.Size = New System.Drawing.Size(992, 600)
        Me.Viewer1.TabIndex = 0
        Me.Viewer1.TableOfContents.Text = "Table Of Contents"
        Me.Viewer1.TableOfContents.Width = 200
        Me.Viewer1.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(512, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 24)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "⁄—÷ «· ﬁ—Ì—"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(336, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 24)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Œ‹‹‹‹‹‹‹‹—ÊÃ"
        '
        'site_txt
        '
        Me.site_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.site_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.site_txt.Location = New System.Drawing.Point(552, 40)
        Me.site_txt.Name = "site_txt"
        Me.site_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.site_txt.Size = New System.Drawing.Size(248, 21)
        Me.site_txt.TabIndex = 7
        '
        'degree
        '
        Me.degree.BackColor = System.Drawing.Color.DarkGray
        Me.degree.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.degree.Location = New System.Drawing.Point(608, 13)
        Me.degree.Name = "degree"
        Me.degree.Size = New System.Drawing.Size(40, 24)
        Me.degree.TabIndex = 109
        Me.degree.Text = "«·„Êﬁ⁄"
        '
        'class_txt
        '
        Me.class_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.class_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.class_txt.Location = New System.Drawing.Point(216, 40)
        Me.class_txt.Name = "class_txt"
        Me.class_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.class_txt.Size = New System.Drawing.Size(160, 21)
        Me.class_txt.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(381, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 24)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "«· ’‰Ì›"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.eyer_txt1)
        Me.GroupBox1.Controls.Add(Me.date_1)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.class_txt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.site_txt)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(936, 160)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        '
        'eyer_txt1
        '
        Me.eyer_txt1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.eyer_txt1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.eyer_txt1.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035"})
        Me.eyer_txt1.Location = New System.Drawing.Point(552, 78)
        Me.eyer_txt1.Name = "eyer_txt1"
        Me.eyer_txt1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.eyer_txt1.Size = New System.Drawing.Size(84, 21)
        Me.eyer_txt1.TabIndex = 145
        '
        'date_1
        '
        Me.date_1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.date_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.date_1.Items.AddRange(New Object() {"Ì‰«Ì—", "›»—«Ì—", "„«—”", "«»—Ì·", "„«ÌÊ", "ÌÊ‰ÌÊ", "ÌÊ·ÌÊ", "√€”ÿ”", "”» „»—", "√ﬂ Ê»—", "‰Ê›„»—", "œÌ”„»—"})
        Me.date_1.Location = New System.Drawing.Point(712, 78)
        Me.date_1.Name = "date_1"
        Me.date_1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.date_1.Size = New System.Drawing.Size(88, 21)
        Me.date_1.TabIndex = 8
        '
        'RadioButton1
        '
        Me.RadioButton1.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.RadioButton1.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.RadioButton1.Location = New System.Drawing.Point(32, -128)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton1.Size = New System.Drawing.Size(96, 49)
        Me.RadioButton1.TabIndex = 131
        Me.RadioButton1.Text = "ﬁ«∆„…"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.date_2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.eyer_txt2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.degree)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(192, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(704, 88)
        Me.GroupBox2.TabIndex = 141
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(248, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 24)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = "«·‘Â— «·À«‰Ï"
        '
        'date_2
        '
        Me.date_2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.date_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.date_2.Items.AddRange(New Object() {"Ì‰«Ì—", "›»—«Ì—", "„«—”", "«»—Ì·", "„«ÌÊ", "ÌÊ‰ÌÊ", "ÌÊ·ÌÊ", "√€”ÿ”", "”» „»—", "√ﬂ Ê»—", "‰Ê›„»—", "œÌ”„»—"})
        Me.date_2.Location = New System.Drawing.Point(152, 56)
        Me.date_2.Name = "date_2"
        Me.date_2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.date_2.Size = New System.Drawing.Size(88, 21)
        Me.date_2.TabIndex = 148
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(112, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 24)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "«·”‰…"
        '
        'eyer_txt2
        '
        Me.eyer_txt2.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.eyer_txt2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.eyer_txt2.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035"})
        Me.eyer_txt2.Location = New System.Drawing.Point(24, 56)
        Me.eyer_txt2.Name = "eyer_txt2"
        Me.eyer_txt2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.eyer_txt2.Size = New System.Drawing.Size(84, 21)
        Me.eyer_txt2.TabIndex = 146
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(448, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 24)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "«·”‰…"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(616, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 24)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "«·‘Â— «·«Ê·"
        '
        'diff
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(992, 780)
        Me.Controls.Add(Me.Viewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "diff"
        Me.Text = "ﬂ‘› «·„— »«»"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Exit Sub
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim i, k As Integer
            Dim df As New SECURITY
            Dim _tmp As Cursor
            _tmp = Me.Cursor
            Me.Cursor = Cursors.WaitCursor
            Dim _rpt = New ActiveReport4

            Dim _DS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource
            _DS.ConnectionString = "User ID= '" & df.UserID.Text & "';" & _
            "Password='" & df.Password.Text & "';" & _
            "Initial Catalog=accoun;" & _
           "Data Source=main2;" & _
            "Connection TimeOut=30;"
            '==================================================list
            ' ''
            If Con.State = ConnectionState.Broken = False Then
                Con.Close()
            End If
            Con.Open()
            '=======================================================================================
            'Dim DS512 As New DataSet
            'Dim t512 As DataTable
            'Dim cmd512 As New SqlClient.SqlCommand("SELECT site_id  FROM sites where site_name ='" & site_txt.Text & "'", Con)
            'Dim dr512 As SqlClient.SqlDataReader = cmd512.ExecuteReader()
            'dr512.Read()
            'Dim siteid As String = dr512.Item("site_id")
            'dr512.Close()
            ''=======================================================================================
            'Dim DS51 As New DataSet
            'Dim t51 As DataTable
            'Dim cmd51 As New SqlClient.SqlCommand("SELECT class_id FROM classes where class_name ='" & class_txt.Text & "'", Con)
            'Dim dr51 As SqlClient.SqlDataReader = cmd51.ExecuteReader()
            'dr51.Read()
            'Dim class_id As String = dr51.Item("class_id")
            'dr51.Close()
            '================ 
            If (eyer_txt1.Text = "" Or eyer_txt2.Text = "" Or date_1.Text = "" Or date_2.Text = "" Or site_txt.Text = "" Or class_txt.Text = "") Then
                MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            End If


            If (eyer_txt1.SelectedIndex > eyer_txt2.SelectedIndex) Then
                MsgBox("ÌÃ» «‰  ﬂÊ‰ «·”‰… «·«Ê·Ï «ﬁ· „‰ √Ê  ”«ÊÌ «·”‰… «·À«‰Ì…")
                Exit Sub
            ElseIf (date_1.SelectedIndex >= date_2.SelectedIndex And eyer_txt1.SelectedIndex = eyer_txt2.SelectedIndex) Then
                MsgBox("ÌÃ» √‰ ÌﬂÊ‰ «·‘Â— «·«Ê· √ﬁ· „‰ «·‘Â— «·À«‰Ì")
                Exit Sub
            End If
            '====================

            Dim DS_archief As New DataSet
            Dim str_archief = "select * from archief,classes,sites where  archief.date_='" & date_1.Text & "' and  archief.class_id=classes.class_id and classes.class_name='" & class_txt.Text & "' and archief.eyer='" & eyer_txt1.Text & "' AND (sites.site_name='" & site_txt.Text & "')and(archief.site_id=sites.site_id)"
            Dim ADP_archief As New SqlClient.SqlDataAdapter(str_archief, Con)
            ADP_archief.Fill(DS_archief)
            Dim k_archief As Integer
            k_archief = DS_archief.Tables(0).Rows.Count
            Dim name_ As String
            If (k_archief < 1) Then
                MsgBox("·«ÌÊÃœ ≈⁄ „«œ  ··‘Â— «·«Ê·  ")
                Exit Sub
            End If

            '====================
            Dim DS_archief2 As New DataSet
            Dim str_archief2 = "select * from archief,classes,sites where  archief.date_='" & date_2.Text & "' and  archief.class_id=classes.class_id and classes.class_name='" & class_txt.Text & "' and archief.eyer='" & eyer_txt2.Text & "' AND (sites.site_name='" & site_txt.Text & "')and(archief.site_id=sites.site_id)"
            Dim ADP_archief2 As New SqlClient.SqlDataAdapter(str_archief2, Con)
            ADP_archief2.Fill(DS_archief2)
            Dim k_archief2 As Integer
            k_archief2 = DS_archief2.Tables(0).Rows.Count
            If (k_archief2 < 1) Then
                MsgBox("·«ÌÊÃœ ≈⁄ „«œ  ··‘Â— «·À«‰Ï  ")
                Exit Sub
            End If
            '--------------------------------------------------------------------------
            Dim safy1, safy2, RESLT, ZIDA, NGSAN, sabg, haly As Double
            'Dim name_ As String
            Dim DS1 As New DataSet
            Dim str1 As String = "SELECT DISTINCT emp_id, archief.class_id, emp_no,archief.site_id FROM archief,classes,sites WHERE ((date_ ='" & date_1.Text & "' and eyer = '" & eyer_txt1.Text & "' ) or ( date_ ='" & date_2.Text & "' and eyer='" & eyer_txt2.Text & "')) AND (classes.class_name='" & class_txt.Text & "')and(archief.class_id=classes.class_id)AND (sites.site_name='" & site_txt.Text & "')and(archief.site_id=sites.site_id) ORDER BY emp_no"
            Dim ADP1 As New SqlClient.SqlDataAdapter(str1, Con)
            ADP1.Fill(DS1)

            class_id = DS1.Tables(0).Rows(0).Item(1)
            Dim siteid As Integer = DS1.Tables(0).Rows(0).Item(3)
            '----------------------------------------------------------- ‰ŸÌ› «·ÃœÊ· „‰ ‰›” «·„Ê«“‰…
            'Dim cmd3 As New SqlClient.SqlCommand("DELETE FROM mwzna WHERE site_id='" & siteid & "' and class_id =  '" & class_id & "'  and eyer='" & eyer_txt2.Text & "' and  month_second='" & date_2.Text & "'", Con)
            Dim cmd3 As New SqlClient.SqlCommand("DELETE FROM mwzna ", Con)
            Dim da3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd3)
            cmd3.ExecuteNonQuery()

            '--------------------------------------------------------------- ‰ŸÌ› «·ÃœÊ· „‰ ‰›” «·„Ê«“‰…-

            For i = 0 To DS1.Tables(0).Rows.Count - 1
                '    '---------Õ”«» «·›—ﬁ ›Ï «·„— »
                Dim emp_id_ = DS1.Tables(0).Rows(i).Item(0)
                Dim emp_no_ = DS1.Tables(0).Rows(i).Item(2)

                'Dim emp_id As Integer
                Dim DS As New DataSet
                Dim DST As New DataSet
                'MsgBox("node1")
                '-----------------------------«·‘Â— «·«Ê·
                Dim str As String = "SELECT  sum(alsafy) as  alsafy,archief.emp_id,employees.emp_name,archief.stop_flag,archief.dgree_name  FROM  archief,employees  where archief.emp_id='" & emp_id_ & "' and archief.emp_id=employees.emp_id and archief.site_id='" & siteid & "' and  archief.class_id='" & class_id & "' and  date_ ='" & date_1.Text & "' and     eyer='" & eyer_txt1.Text & "' group by archief.emp_id,employees.emp_name,archief.stop_flag,archief.dgree_name"
                'Dim str As String = "SELECT sum(alsafy)as  alsafy,archief.emp_id   FROM   archief,employees  where   archief.emp_id='" & 348 & "' and   archief.emp_id=employees.emp_id and archief.class_id='" & class_id & "' and  archief.eyer in('" & eyer_txt1.Text & "','" & eyer_txt2.Text & "') and  date_  in('" & date_1.Text & "','" & date_2.Text & "') group by archief.date_,archief.emp_id  order by archief.emp_id "

                Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
                ADP.Fill(DS)
                If DS.Tables(0).Rows.Count < 1 Then
                    safy1 = 0
                Else
                    If DS.Tables(0).Rows(0).Item(3) = 1 Then
                        safy1 = 0
                    Else
                        safy1 = DS.Tables(0).Rows(0).Item(0)
                    End If
                End If

                '-----------------‰Â«Ì…---«·‘Â— «·«Ê·---------
                Dim strT As String = "SELECT   sum(alsafy) as  alsafy,archief.emp_id,employees.emp_name,archief.stop_flag,archief.dgree_name  FROM  archief,employees  where archief.emp_id='" & emp_id_ & "' and archief.emp_id=employees.emp_id and archief.site_id='" & siteid & "'  and archief.class_id= '" & class_id & "'   and  eyer='" & eyer_txt2.Text & "' and  date_ = '" & date_2.Text & "' group by archief.emp_id,employees.emp_name,archief.stop_flag,archief.dgree_name"
                Dim ADPT As New SqlClient.SqlDataAdapter(strT, Con)
                ADPT.Fill(DST)
                If DST.Tables(0).Rows.Count < 1 Then
                    safy2 = 0
                Else
                    If DST.Tables(0).Rows(0).Item(3) = 1 Then
                        safy2 = 0
                    Else
                        safy2 = DST.Tables(0).Rows(0).Item(0)
                    End If
                End If
                'MsgBox(safy2)
                RESLT = safy1 - safy2
                '-------------------------------------------------------isssssssssssssa
                If (safy1 <> safy2) Then      ' no diff between 2 months or he stoped in 2 months
                    If safy1 < safy2 Then
                        ZIDA = RESLT * -1
                        NGSAN = 0
                    Else
                        NGSAN = RESLT
                        ZIDA = 0
                    End If
                    haly = safy2
                    sabg = safy1
                    '-----------------------------«·‘Â— «·À«‰Ï

                    ' '---------Õ”«» «·›—ﬁ ›Ï «·„— »
                    Dim DSm As New DataSet
                    Dim strm As String = "select distinct  name_aa from  aa('" & emp_id_ & "','" & eyer_txt1.Text & "','" & date_1.Text & "'),bb('" & emp_id_ & "','" & eyer_txt2.Text & "','" & date_2.Text & "') where name_aa not in(select name_bb from bb('" & emp_id_ & "','" & eyer_txt2.Text & "','" & date_2.Text & "')) union  select distinct  name_bb from aa('" & emp_id_ & "','" & eyer_txt1.Text & "','" & date_1.Text & "'),bb('" & emp_id_ & "','" & eyer_txt2.Text & "','" & date_2.Text & "') where  name_bb not in(select name_aa from aa('" & emp_id_ & "' ,'" & eyer_txt1.Text & "','" & date_1.Text & "')) union select  name_aa  from  aa('" & emp_id_ & "','" & eyer_txt1.Text & "','" & date_1.Text & "'),bb('" & emp_id_ & "','" & eyer_txt2.Text & "','" & date_2.Text & "') where val_aa<>val_bb and name_aa like name_bb "
                    Dim ADPm As New SqlClient.SqlDataAdapter(strm, Con)
                    ADPm.Fill(DSm)
                    'End If '‰Â«Ì… „ﬁ«—‰… »Ì‰ ‘Â—Ì‰ ·€Ì— «·„ÊﬁÊ›Ì‰
                    '--------------------------------------------------------------
                    name_ = ""
                    If (DSm.Tables(0).Rows.Count >= 1) Then '«–«  „  «·„ﬁ«—‰… ÊÊÃœ ”Ã·« 
                        For k = 0 To DSm.Tables(0).Rows.Count - 1
                            If (k = DSm.Tables(0).Rows.Count - 1) Then
                                name_ = name_ + DSm.Tables(0).Rows(k).Item(0)
                            Else
                                name_ = name_ + DSm.Tables(0).Rows(k).Item(0) + " , "
                            End If
                        Next
                    End If

                    '------------------------------------------------
                    If DS.Tables(0).Rows.Count < 1 Then 'first month
                        name_ = " ⁄ÌÌ‰ ÃœÌœ"
                        ZIDA = haly
                        NGSAN = 0
                        sabg = 0

                    Else
                        If DS.Tables(0).Rows(0).Item(3) = 1 Then 'first month ·„ Ì’—›
                            sabg = 0
                            NGSAN = 0
                            ZIDA = haly
                            name_ = "›ﬂ „— »"
                        End If
                    End If
                    'second month«·‘Â— «·À«‰Ï ·„ Ì’—›
                    If (DST.Tables(0).Rows.Count < 1) Then
                        name_ = "≈Ìﬁ«› „— »"
                        haly = 0
                        NGSAN = sabg
                        ZIDA = 0
                    Else
                        If DST.Tables(0).Rows(0).Item(3) = 1 Then
                            name_ = "≈Ìﬁ«› „— »"
                            haly = 0
                            NGSAN = sabg
                            ZIDA = 0
                        End If
                    End If
                    '====================== «Œ »«— «· €ÌÌ— ›Ì «·œ—Ã…

                    Dim cmdString As String = "INSERT INTO mwzna " + _
                                               "(site_id,month_second,emp_no,eyer,emp_id,name_,zida,ngsan,safy_befor,safy_haly,class_id) " + _
                                               "VALUES('" & siteid & "','" & date_2.Text & "','" & emp_no_ & "','" & EYER & "','" & emp_id_ & "','" & name_ & "','" & ZIDA & "','" & NGSAN & "','" & sabg & "','" & haly & "','" & class_id & "')"
                    Dim cmd As New SqlClient.SqlCommand(cmdString, Con)

                    cmd.ExecuteNonQuery()
                    'End If
                End If 'if safy1<>sfy2         'Õ›Ÿ «·’«›Ï Ê«·»Ì«‰ ›Ï ÃœÊ· ··›—œ
            Next
            'MsgBox("end")
            month_mowz = date_2.Text
            clas = class_txt.Text + " / " + site_txt.Text + " / " + month_mowz + " " + eyer_txt2.Text
            '----------------------------------------------------------safy total month befor
            Dim DSw As New DataSet
            Dim strw As String = "SELECT  sum(alsafy_total) as alsafy_total  FROM  classes,total,sites where total.site_id=sites.site_id   and sites.site_name='" & site_txt.Text & "' and total.class_id=classes.class_id   and classes.class_name='" & class_txt.Text & "' and eyer='" & eyer_txt1.Text & "' and date_='" & date_1.Text & "'  group by total.class_id "
            Dim ADPw As New SqlClient.SqlDataAdapter(strw, Con)
            ADPw.Fill(DSw)
            alsafy_total2 = DSw.Tables(0).Rows(0).Item(0)
            '---------------------------------------------------------end safy total month befor
            '----------------------------------------------------------safy total month after
            Dim DSw2 As New DataSet
            Dim strw2 As String = "SELECT  sum(alsafy_total) as alsafy_total  FROM  classes,total,sites where total.site_id=sites.site_id   and sites.site_name='" & site_txt.Text & "' and total.class_id=classes.class_id   and classes.class_name='" & class_txt.Text & "' and eyer='" & eyer_txt2.Text & "' and date_='" & date_2.Text & "'  group by total.class_id "
            Dim ADPw2 As New SqlClient.SqlDataAdapter(strw2, Con)
            ADPw2.Fill(DSw2)
            alsafy_total1 = DSw2.Tables(0).Rows(0).Item(0)

            '---------------------------------------------------------end safy total month after
            Dim _sqlString As String = "Select mwzna.emp_no,mwzna.name_,mwzna.zida,mwzna.ngsan,employees.emp_name FROM  mwzna,employees WHERE    employees.emp_id=mwzna.emp_id and mwzna.eyer ='" & EYER & "' and mwzna.class_id='" & class_id & "' and mwzna.site_id='" & siteid & "' order by mwzna.emp_no" ',mwzna.safy_befor,mwzna.safy_haly,
            _DS.SQL = _sqlString
            _rpt.DataSource = _DS

            Me.Viewer1.Document = _rpt.Document

            _rpt.Run(False)

            Me.Cursor = _tmp

        Catch ex As DataDynamics.ActiveReports.ReportException
            MessageBox.Show(Me, "Error fired while running the report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub mencard2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        '==============================
        'Dim DS As New DataSet
        'Dim t As DataTable
        'Dim cmd2 As New SqlClient.SqlCommand("SELECT eyer FROM  eyers", Con)
        ''Dim cmd2 As New SqlClient.SqlCommand("SELECT est_akry.ser_ak,sites.site_name,classes.class_name,employees.emp_no,employees.emp_name,est_akry.est_name,est_akry.est_ok_val,est_akry.month_co FROM  sites,classes,employees,est_akry ", Con)
        'Dim dr44 As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        'dr44.Read()
        'If dr44.HasRows = False Then
        '    Con.Close()
        '    Exit Sub
        'End If
        'eyer_txt1.Text = dr44.Item("eyer")

        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        '==============================
        Dim DS02 As New DataSet
        Dim str02 As String = "SELECT DISTINCT  classes.class_name  FROM classes,degrees_classes where classes.class_id=degrees_classes.class_id"
        Dim ADP02 As New SqlClient.SqlDataAdapter(str02, Con)
        ADP02.Fill(DS02)
        Dim k As Integer
        For k = 0 To DS02.Tables(0).Rows.Count - 1
            Me.class_txt.Items.Add(DS02.Tables(0).Rows(k).Item(0))
        Next
        ADP02.Dispose()
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        '==========================================================
        Dim DS01 As New DataSet
        Dim str01 As String = "SELECT DISTINCT  site_name  FROM sites"
        Dim ADP01 As New SqlClient.SqlDataAdapter(str01, Con)
        ADP01.Fill(DS01)
        Dim j As Integer
        For j = 0 To DS01.Tables(0).Rows.Count - 1
            Me.site_txt.Items.Add(DS01.Tables(0).Rows(j).Item(0))
        Next
        ADP01.Dispose()
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'apply_date_txt.Enabled = False
        'DateTimePicker1.Enabled = False
    End Sub
    Private Sub CheckBox1_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub CheckBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'apply_date_txt.Enabled = True
        'DateTimePicker1.Enabled = True
    End Sub


    Private Sub site_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles site_txt.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub date__SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles date_1.SelectedIndexChanged

    End Sub

    Private Sub date__KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles date_1.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub class_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles class_txt.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub empname_txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim df As New SECURITY
            Dim _tmp As Cursor
            _tmp = Me.Cursor
            Me.Cursor = Cursors.WaitCursor
            Dim _rpt = New indexlist

            'Dim df As New SECURITY
            'Dim _tmp As Cursor
            '_tmp = Me.Cursor
            'Me.Cursor = Cursors.WaitCursor
            'Dim _rpt = New index1
            Dim _DS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource
            _DS.ConnectionString = "User ID= '" & df.UserID.Text & "';" & _
            "Password='" & df.Password.Text & "';" & _
            "Initial Catalog=accoun;" & _
               "Data Source=main2;" & _
            "Connection TimeOut=30;"
            '_rpt = New index1
            MsgBox("well1")
            Dim x As String
            Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no ,employees.emp_name,classes.class_name from employees ,classes where  employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'", Con)
            Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count < 1 Then
                MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                Exit Sub
            End If
            'classname = ""
            'classname = " ﬂ‘› »«”„«¡ " + dt.Rows(0).Item("class_name")
            Dim k As Integer
            'Dim id_em = dt.Rows(0).Item("emp_id")  employees.emp_no ,employees.emp_name,classes.class_name

            '********************************
            'Dim _sqlString As String = "Select basic_salary_emp.basic_sal,employees.emp_name,employees.emp_no"
            '_sqlString = _sqlString + "FROM employees,classes,basic_salary_emp"
            ''_sqlString = _sqlString + " WHERE  employees.dgree_id=basic_salary_emp.degree_id and employees.sections=basic_salary_emp.section_count and employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "' order by employees.emp_name"

            '************************************************
            Dim _sqlString As String = "Select * "
            _sqlString = _sqlString + "FROM employees"
            '_sqlString = _sqlString + " WHERE  employees.dgree_id=basic_salary_emp.degree_id and employees.sections=basic_salary_emp.section_count and employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "' order by employees.emp_name"
            _DS.SQL = _sqlString
            _rpt.DataSource = _DS
            MsgBox("well2")
            Me.Viewer1.Document = _rpt.Document
            MsgBox("well21")
            _rpt.Run(False)
            Me.Cursor = _tmp
        Catch ex As DataDynamics.ActiveReports.ReportException
            MessageBox.Show(Me, "Error fired while running the report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim df As New SECURITY
            Dim _tmp As Cursor
            _tmp = Me.Cursor
            Me.Cursor = Cursors.WaitCursor
            Dim _rpt = New ind
            Dim _DS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource
            _DS.ConnectionString = "User ID= '" & df.UserID.Text & "';" & _
            "Password='" & df.Password.Text & "';" & _
            "Initial Catalog=accoun;" & _
           "Data Source=main2;" & _
            "Connection TimeOut=30;"
            '--------------------------------------------------------------------------------------------

            '_rpt = New listrep
            Dim x As String
            Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no ,employees.emp_name,classes.class_name from employees ,classes where  employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'", Con)
            Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count < 1 Then
                MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                Exit Sub
            End If
            classname = ""
            classname = " ﬂ‘› »«”„«¡ " + dt.Rows(0).Item("class_name")
            Dim k As Integer
            'Dim id_em = dt.Rows(0).Item("emp_id")  employees.emp_no ,employees.emp_name,classes.class_name
            Dim _sqlString As String = "Select basic_salary_emp.basic_sal,employees.emp_name,employees.emp_no  "
            _sqlString = _sqlString + "FROM employees,classes,basic_salary_emp"
            _sqlString = _sqlString + " WHERE employees.dgree_id=basic_salary_emp.degree_id and employees.sections=basic_salary_emp.section_count and employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "' order by employees.emp_name"
            _DS.SQL = _sqlString
            _rpt.DataSource = _DS


            '--------------------------------------------------------------------------------------------

            Me.Viewer1.Document = _rpt.Document
            _rpt.Run(False)
            Me.Cursor = _tmp
        Catch ex As DataDynamics.ActiveReports.ReportException
            MessageBox.Show(Me, "Error fired while running the report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Viewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Viewer1.Load

    End Sub

    Private Sub Viewer1_LoadCompleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles Viewer1.LoadCompleted

    End Sub
End Class
