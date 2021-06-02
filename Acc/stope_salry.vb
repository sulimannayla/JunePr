Public Class stpe
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


    Function getdiff()
        Dim ww As Date
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If

        Con.Open()

        'DATEDIFF(day,'" & DateValue(Date.Now) & "', sys_date ) as datediff 
        'DATEDIFF(day,'" & DateValue(Date.Now) & "',sys_date) as diff
        Dim cmd55 As New SqlClient.SqlCommand("Select *  from est_akry where   est_flag =0 and  ser_ak ='" & serial & "' ", Con)
        Dim dr55 As SqlClient.SqlDataReader = cmd55.ExecuteReader()

        dr55.Read()

        ww = dr55.Item("sys_date")
        Dim www As Integer = DateDiff(DateInterval.Month, ww, DateValue(Date.Now))

        'dim str as d
        MsgBox("⁄œœ «·‘ÂÊ— «·„ »ﬁÌ… ·Â–« «·«” ﬁÿ«⁄  =" + "  " & www, MsgBoxStyle.Information, " ‰»ÌÂ")

        'MsgBox(DateDiff(DateInterval.Month, ww, DateValue(Date.Now)))
        'ww = DateValue(Date.Now)
        'ext(-DateValue(Date.Now))
        'ww = ext - ww
        If dr55.HasRows = False Then


        End If
        Con.Close()
    End Function
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents site_txt As System.Windows.Forms.ComboBox
    Friend WithEvents empname_txt As System.Windows.Forms.ComboBox
    Friend WithEvents emp_id_txt As System.Windows.Forms.ComboBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents class_txt4 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents letter_no As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents freez As System.Windows.Forms.RadioButton
    Friend WithEvents defreez As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents letter_date As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
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
        Me.letter_date = New System.Windows.Forms.DateTimePicker
        Me.defreez = New System.Windows.Forms.RadioButton
        Me.freez = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.letter_no = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.empname_txt = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.emp_id_txt = New System.Windows.Forms.ComboBox
        Me.class_txt4 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.site_txt = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dell
        '
        Me.dell.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dell.Location = New System.Drawing.Point(226, 360)
        Me.dell.Name = "dell"
        Me.dell.Size = New System.Drawing.Size(72, 32)
        Me.dell.TabIndex = 11
        Me.dell.Text = "Õ–›"
        '
        'search
        '
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.search.Location = New System.Drawing.Point(136, 360)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(72, 32)
        Me.search.TabIndex = 12
        Me.search.Text = "«” ⁄—«÷"
        '
        'edit
        '
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.edit.Location = New System.Drawing.Point(328, 360)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(80, 32)
        Me.edit.TabIndex = 10
        Me.edit.Text = " ⁄œÌ·"
        '
        'save
        '
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.save.Location = New System.Drawing.Point(440, 360)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(88, 32)
        Me.save.TabIndex = 8
        Me.save.Text = "Õ›Ÿ"
        '
        'add1
        '
        Me.add1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.add1.Location = New System.Drawing.Point(544, 360)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(88, 32)
        Me.add1.TabIndex = 9
        Me.add1.Text = "ÃœÌœ"
        '
        'degree
        '
        Me.degree.BackColor = System.Drawing.Color.DarkGray
        Me.degree.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.degree.Location = New System.Drawing.Point(496, 75)
        Me.degree.Name = "degree"
        Me.degree.Size = New System.Drawing.Size(48, 24)
        Me.degree.TabIndex = 107
        Me.degree.Text = "«·„Êﬁ⁄"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(104, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(544, 64)
        Me.Label3.TabIndex = 116
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(496, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 111
        Me.Button1.Text = "ÃœÌœ"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(400, 360)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 114
        Me.Button2.Text = "Õ›Ÿ"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.Location = New System.Drawing.Point(384, 360)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 32)
        Me.Button3.TabIndex = 113
        Me.Button3.Text = "Õ›Ÿ"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.Location = New System.Drawing.Point(224, 360)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 32)
        Me.Button4.TabIndex = 117
        Me.Button4.Text = "»ÕÀ"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button5.Location = New System.Drawing.Point(304, 360)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 32)
        Me.Button5.TabIndex = 115
        Me.Button5.Text = " ⁄œÌ·"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button6.Location = New System.Drawing.Point(480, 360)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 32)
        Me.Button6.TabIndex = 112
        Me.Button6.Text = "ÃœÌœ"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.letter_date)
        Me.GroupBox1.Controls.Add(Me.defreez)
        Me.GroupBox1.Controls.Add(Me.freez)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.letter_no)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.empname_txt)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.emp_id_txt)
        Me.GroupBox1.Controls.Add(Me.class_txt4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.site_txt)
        Me.GroupBox1.Controls.Add(Me.degree)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(722, 320)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        '
        'letter_date
        '
        Me.letter_date.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.letter_date.Location = New System.Drawing.Point(136, 232)
        Me.letter_date.Name = "letter_date"
        Me.letter_date.Size = New System.Drawing.Size(104, 20)
        Me.letter_date.TabIndex = 127
        '
        'defreez
        '
        Me.defreez.Location = New System.Drawing.Point(264, 34)
        Me.defreez.Name = "defreez"
        Me.defreez.Size = New System.Drawing.Size(56, 24)
        Me.defreez.TabIndex = 1
        Me.defreez.Text = " ›⁄Ì·"
        '
        'freez
        '
        Me.freez.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.freez.Location = New System.Drawing.Point(368, 38)
        Me.freez.Name = "freez"
        Me.freez.Size = New System.Drawing.Size(56, 16)
        Me.freez.TabIndex = 0
        Me.freez.Text = "«Ìﬁ«›"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DarkGray
        Me.Label6.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(240, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 28)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "«· «—ÌŒ"
        '
        'letter_no
        '
        Me.letter_no.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.letter_no.Location = New System.Drawing.Point(296, 232)
        Me.letter_no.Name = "letter_no"
        Me.letter_no.Size = New System.Drawing.Size(192, 20)
        Me.letter_no.TabIndex = 6
        Me.letter_no.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(8, 20)
        Me.TextBox1.TabIndex = 120
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Visible = False
        '
        'empname_txt
        '
        Me.empname_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.empname_txt.Location = New System.Drawing.Point(136, 192)
        Me.empname_txt.Name = "empname_txt"
        Me.empname_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.empname_txt.Size = New System.Drawing.Size(352, 21)
        Me.empname_txt.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkGray
        Me.Label5.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(496, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 24)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "«·—ﬁ„"
        '
        'emp_id_txt
        '
        Me.emp_id_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.emp_id_txt.Location = New System.Drawing.Point(360, 152)
        Me.emp_id_txt.Name = "emp_id_txt"
        Me.emp_id_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.emp_id_txt.Size = New System.Drawing.Size(128, 21)
        Me.emp_id_txt.TabIndex = 4
        '
        'class_txt4
        '
        Me.class_txt4.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.class_txt4.ItemHeight = 13
        Me.class_txt4.Location = New System.Drawing.Point(240, 120)
        Me.class_txt4.Name = "class_txt4"
        Me.class_txt4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.class_txt4.Size = New System.Drawing.Size(248, 21)
        Me.class_txt4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(488, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "«· ’‰Ì›"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(496, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 24)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "«·«”„"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(496, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 28)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "‰„—… «·Œÿ«»"
        '
        'site_txt
        '
        Me.site_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.site_txt.Location = New System.Drawing.Point(192, 80)
        Me.site_txt.Name = "site_txt"
        Me.site_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.site_txt.Size = New System.Drawing.Size(296, 21)
        Me.site_txt.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(249, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 48)
        Me.GroupBox2.TabIndex = 126
        Me.GroupBox2.TabStop = False
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.Green
        Me.DataGrid1.CaptionText = "fgfdgfdgfdgdf222"
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Font = New System.Drawing.Font("Simplified Arabic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGrid1.GridLineColor = System.Drawing.SystemColors.Highlight
        Me.DataGrid1.HeaderBackColor = System.Drawing.SystemColors.Desktop
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(48, 424)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Brown
        Me.DataGrid1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Size = New System.Drawing.Size(632, 128)
        Me.DataGrid1.TabIndex = 119
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.DataGrid1.Visible = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.SystemColors.Desktop
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridTableStyle1.LinkColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.Silver
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "—ﬁ„ «·„ÊŸ›"
        Me.DataGridTextBoxColumn5.MappingName = "emp_no"
        Me.DataGridTextBoxColumn5.Width = 103
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "«”„ «·„ÊŸ›"
        Me.DataGridTextBoxColumn6.MappingName = "emp_name"
        Me.DataGridTextBoxColumn6.Width = 339
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "«· «—ÌŒ"
        Me.DataGridTextBoxColumn9.MappingName = "letter_date"
        Me.DataGridTextBoxColumn9.Width = 150
        '
        'stpe
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(752, 565)
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
        Me.Name = "stpe"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "«Ìﬁ«› „— »"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub basiksalary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        'Dim issa As String
        'Dim DS3 As New DataSet
        'Dim str As String = "Select DATEDIFF(m,sys_date,'" & DateValue(Date.Now) & "') from est_akry where est_flag =0 and DATEDIFF(m, sys_date,'" & DateValue(Date.Now) & "')<1 "
        'Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        'ADP.Fill(DS3)
        'Dim i As Integer
        'If DS3.Tables(0).Rows.Count < 1 Then

        'Dim cmdString As String = "UPDATE est_akry " + _
        '                                          "SET est_flag = '" & 1 & "' " + _
        '                                          "WHERE est_flag =0 and DATEDIFF(m, sys_date,'" & DateValue(Date.Now) & "'<1"
        'Dim cmd As New SqlClient.SqlCommand(cmdString, Con)

        ''End If
        'Con.Close()

        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If

        Con.Open()
        bt_low(edit, add1, save, search, dell)
        save.Enabled = True
        edit.Enabled = False
        'Dim ADPt As SqlClient.SqlDataAdapter
        'Dim cmd12 = "SELECT est_akry.ser_ak,employees.emp_no,employees.emp_name,est_akry.est_name,est_akry.est_ok_val,est_akry.month_co,est_akry.sys_date FROM employees,est_akry where est_akry.emp_id=employees.emp_id and est_akry.est_flag=0"
        'Dim dt As New DataTable
        'ADPt = New SqlClient.SqlDataAdapter(cmd12, Con)
        'ADPt.Fill(dt)
        'DataGrid1.DataSource = dt
        dell.Enabled = False
        add1.Enabled = True
        search.Enabled = False

        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If

        Con.Open()
        ''''.......................
        Dim DS01 As New DataSet
        Dim str01 As String = "SELECT DISTINCT  site_name  FROM sites"
        Dim ADP01 As New SqlClient.SqlDataAdapter(str01, Con)
        ADP01.Fill(DS01)
        Dim j As Integer
        For j = 0 To DS01.Tables(0).Rows.Count - 1
            Me.site_txt.Items.Add(DS01.Tables(0).Rows(j).Item(0))
        Next
        ADP01.Dispose()
        '............................
        
        '.......................
        Con.Close()
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Dim da As Date
        'emp_id_txt.Text = ""
        'emp_id_txt.Items.Clear()
        'empname_txt.Text = ""
        'empname_txt.Items.Clear()
        'est_name_txt.Text = ""
        'est_ok_val_txt.Text = ""

        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()

        If Trim(letter_no.Text) = "" Or Trim(emp_id_txt.Text) = "" Or Trim(site_txt.Text) = "" Or Trim(empname_txt.Text) = "" Or Trim(class_txt4.Text) = "" Or Trim(letter_date.Text) = "" Or (freez.Checked = False And defreez.Checked = False) Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        bt_save(edit, add1, save, search, dell)
        '-----------------------------------------------------------------------------
       
        '=======================================================================================
        'MsgBox(Date.Now)
        Dim DS51 As New DataSet
        Dim t51 As DataTable
        Dim cmd51 As New SqlClient.SqlCommand("SELECT class_id FROM classes where class_name ='" & class_txt4.Text & "'", Con)
        Dim dr51 As SqlClient.SqlDataReader = cmd51.ExecuteReader()
        dr51.Read()
        Dim class_i_d As String = dr51.Item("class_id")
        dr51.Close()
        '=======================================================================================

        Dim DS512 As New DataSet
        Dim t512 As DataTable
        Dim cmd512 As New SqlClient.SqlCommand("SELECT site_id  FROM sites where site_name ='" & site_txt.Text & "'", Con)
        Dim dr512 As SqlClient.SqlDataReader = cmd512.ExecuteReader()
        dr512.Read()
        Dim site_i_d As String = dr512.Item("site_id")
        dr512.Close()
        '=======================================================================================
        Dim DS5 As New DataSet
        Dim t5 As DataTable
        Dim cmd5 As New SqlClient.SqlCommand("SELECT emp_id FROM employees where site_id='" & site_i_d & "' and class_id='" & class_i_d & "' and emp_name ='" & empname_txt.Text & "'", Con)
        Dim dr5 As SqlClient.SqlDataReader = cmd5.ExecuteReader()
        dr5.Read()
        Dim emp_id_i As String = dr5.Item("emp_id")
        dr5.Close()

        '======================================================
        'Dim DS5123 As New DataSet
        'Dim t5123 As DataTable
        'Dim cmd5123 As New SqlClient.SqlCommand("SELECT site_id  FROM sites where site_name ='" & site_txt.Text & "'", Con)
        'Dim dr5123 As SqlClient.SqlDataReader = cmd512.ExecuteReader()
        'dr5123.Read()
        'Dim site_i_d As String = dr512.Item("site_id")
        'dr51.Close()
        '=======================================================================================
        'Dim stop_flag_ As Integer
        If (freez.Checked = True) Then
            stop_flag_ = 1
        End If
        If (defreez.Checked = True) Then
            stop_flag_ = 2
        End If

        '=======================================================================================
        da = Date.Now
        '...
        Dim cmdString As String = "INSERT INTO stope_salry " + _
                           "(site_id,class_id,emp_id,letter_no,letter_date,stop_flag) " + _
                           "VALUES('" & site_i_d & "','" & class_i_d & "','" & emp_id_i & "','" & letter_no.Text & "' ,'" & letter_date.Text & "','" & stop_flag_ & "')"
        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        '.....
        'If (freez.Checked = True) Then
        '    stop_flag_ = 1
        'End If
        'If (defreez.Checked = True) Then
        '    stop_flag_ = 2
        'End If
        Dim cmdString2 As String = "UPDATE employees " + _
                                            "SET stop_flag='" & stop_flag_ & "' " + _
                                            "WHERE emp_id = '" & emp_id_i & "'"
        Dim cmd2 As New SqlClient.SqlCommand(cmdString2, Con)
        '.....
        Try
            cmd.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            MsgBox("·ﬁœ  „ Õ›Ÿ «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
            Call clear()
            '.....
            Dim ADPt As SqlClient.SqlDataAdapter
            Dim cmd12 = "SELECT employees.emp_no,employees.emp_name,stope_salry.letter_date FROM employees,stope_salry WHERE employees.emp_id=stope_salry.emp_id and stope_salry.letter_date=(select max(letter_date) from stope_salry where emp_id='" & emp_id_i & "' and stop_flag='" & stop_flag_ & "') and employees.emp_id='" & emp_id_i & "' "
            Dim dt As New DataTable
            ADPt = New SqlClient.SqlDataAdapter(cmd12, Con)
            ADPt.Fill(dt)
            DataGrid1.DataSource = dt
            '.....
            emp_id_txt.Text = ""
            'emp_id_txt.Items.Clear()
            empname_txt.Text = ""
            'empname_txt.Items.Clear()
            letter_no.Text = ""
            letter_date.Text = ""

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
        edit.Enabled = False
        dell.Enabled = False
        search.Enabled = False

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
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        If Trim(site_txt.Text) = "" Or Trim(class_txt4.Text) = "" Or Trim(emp_id_txt.Text) = "" Or Trim(empname_txt.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        '==============
        Dim DS5 As New DataSet
        Dim t5 As DataTable
        Dim cmd5 As New SqlClient.SqlCommand("SELECT emp_id FROM employees,sites,classes where sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and classes.class_id=employees.class_id and classes.class_name='" & class_txt4.Text & "' and emp_name ='" & empname_txt.Text & "'", Con)
        Dim dr5 As SqlClient.SqlDataReader = cmd5.ExecuteReader()
        dr5.Read()
        Dim emp_id_ As Integer = dr5.Item("emp_id")
        dr5.Close()
        '=================================
        'select employees.emp_id,employees.emp_no,employees.emp_name,stope_salry.letter_date,stope_salry.letter_no from employees,stope_salry where employees.emp_id=stope_salry.emp_id and employees.stop_flag=1 and stope_salry.letter_date=(select max(letter_date) from stope_salry where emp_id=16 and stop_flag=1)  
        'Dim DS55 As New DataSet
        'Dim t55 As DataTable
        'Dim cmd55 As New SqlClient.SqlCommand("select employees.emp_id,employees.emp_no,employees.emp_name,stope_salry.letter_date,stope_salry.letter_no from employees,stope_salry where employees.emp_id=stope_salry.emp_id and employees.stop_flag='" & 1 & "' and stope_salry.letter_date=(select max(letter_date) from stope_salry where emp_id='" & emp_id_i & "' and stop_flag='" & 1 & "')", Con)
        'Dim dr55 As SqlClient.SqlDataReader = cmd55.ExecuteReader()
        'dr55.Read()
        'letter_no.Text = dr55.Item("letter_no")
        'letter_date.Text = dr55.Item("letter_date")
        'dr55.Close()
        '==================================
        Dim ADPt As SqlClient.SqlDataAdapter
        Dim cmd12 = "select employees.emp_id,employees.emp_no,employees.emp_name,stope_salry.letter_date,stope_salry.letter_no from employees,stope_salry where employees.emp_id=stope_salry.emp_id and employees.stop_flag='" & 1 & "' and stope_salry.letter_date=(select max(letter_date) from stope_salry where emp_id='" & emp_id_ & "' and stop_flag='" & 1 & "')and stope_salry.emp_id='" & emp_id_ & "'"
        Dim dt As New DataTable
        ADPt = New SqlClient.SqlDataAdapter(cmd12, Con)
        ADPt.Fill(dt)
        DataGrid1.DataSource = dt
        Dim myTable As DataTable
        myTable = CType(DataGrid1.DataSource, DataTable)
        If myTable.Rows.Count < 1 Then
            MsgBox("·«ÌÊÃœ «Ìﬁ«› „— » ·Â–« «·„ÊŸ›")
            Exit Sub
        End If
        '=================================
        'select employees.emp_id,employees.emp_no,employees.emp_name,stope_salry.letter_date,stope_salry.letter_no from employees,stope_salry where employees.emp_id=stope_salry.emp_id and employees.stop_flag=1 and stope_salry.letter_date=(select max(letter_date) from stope_salry where emp_id=16 and stop_flag=1)  
        Dim DS55 As New DataSet
        Dim t55 As DataTable
        Dim cmd55 As New SqlClient.SqlCommand("select employees.emp_id,employees.emp_no,employees.emp_name,stope_salry.letter_date,stope_salry.letter_no,stope_salry.ser from employees,stope_salry where employees.emp_id=stope_salry.emp_id and employees.stop_flag='" & 1 & "' and stope_salry.letter_date=(select max(letter_date) from stope_salry where emp_id='" & emp_id_ & "' and stop_flag='" & 1 & "') and stope_salry.emp_id='" & emp_id_ & "'", Con)
        Dim dr55 As SqlClient.SqlDataReader = cmd55.ExecuteReader()
        dr55.Read()
        letter_no.Text = dr55.Item("letter_no")
        letter_date.Text = dr55.Item("letter_date")
        sel_golb = dr55.Item("ser")
        emp_id_glob = dr55.Item("emp_id")
        emp_no_glob = dr55.Item("emp_no")
        dr55.Close()
        '..
        edit.Enabled = True
        dell.Enabled = True
        save.Enabled = False

        Con.Close()
    End Sub

    Private Sub degree_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles site_txt.SelectedIndexChanged
        Call clear()
    End Sub

    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add1.Click
        'basic_sal_txt.Text = ""
        'class_txt4.Text = ""
        emp_id_txt.Text = ""
        'emp_id_txt.Items.Clear()
        empname_txt.Text = ""
        'empname_txt.Items.Clear()
        letter_no.Text = ""
        letter_date.Text = ""
        'month_txt.Text = ""
        add1.Enabled = True
        save.Enabled = True
        edit.Enabled = False
        dell.Enabled = False
        '======
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        '..
        Dim ADPt As SqlClient.SqlDataAdapter
        Dim cmd12 = "SELECT employees.emp_no,employees.emp_name,stope_salry.letter_date FROM employees,stope_salry WHERE employees.emp_id=stope_salry.emp_id and stope_salry.letter_date=(select max(letter_date) from stope_salry where emp_id='" & -999 & "' and stop_flag='" & stop_flag_ & "') and employees.emp_id='" & -999 & "' "
        Dim dt As New DataTable
        ADPt = New SqlClient.SqlDataAdapter(cmd12, Con)
        ADPt.Fill(dt)
        DataGrid1.DataSource = dt
        '======
        Con.Close()
    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)

    End Sub

    Private Sub DataGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim col As Int16 = DataGrid1.CurrentCell.ColumnNumber
        'Dim row As Int16 = DataGrid1.CurrentCell.RowNumber

        'Dim i As Integer

        'If IsNumeric(DataGrid1.Item(row, 0)) Then
        '    If Con.State = ConnectionState.Broken = False Then
        '        Con.Close()
        '    End If
        '    Con.Open()
        '    Dim message, title, defaultValue As String
        '    Dim m As Integer
        '    Dim DS As New DataSet
        '    Dim t As DataTable
        '    'Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM basic_salary_emp where    degree_id='" & DataGrid1.Item(row, 1) & "'", Con)
        '    Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM basic_salary_emp,dgree_base where basic_salary_emp.degree_id=dgree_base.dgree_id  and basic_salary_emp.ser='" & DataGrid1.Item(row, 0) & "'", Con)
        '    Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        '    If dr.HasRows = False Then

        '        Exit Sub
        '    End If
        '    dr.Read()
        '    bt_search(edit, add1, save, search, dell)
        '    'id = ""
        '    dg_id = dr.Item("degree_id")
        '    degree_txt.Text = dr.Item("dgree_name")
        '    basic_sal_txt.Text = dr.Item("basic_sal")
        '    section_count.Text = dr.Item("section_count")
        '    dr.Close()
        '    edit.Enabled = True
        '    Try
        '    Catch er As Exception
        '        MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√
        '    End Try
        '    Con.Close()
        'End If
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click

        'If Trim(est_name_txt.Text) = "" Or Trim(emp_id_txt.Text) = "" Or Trim(site_txt.Text) = "" Or Trim(empname_txt.Text) = "" Or Trim(class_txt4.Text) = "" Or Trim(est_ok_val_txt.Text) = "" Then
        If Trim(letter_no.Text) = "" Or Trim(emp_id_txt.Text) = "" Or Trim(site_txt.Text) = "" Or Trim(empname_txt.Text) = "" Or Trim(class_txt4.Text) = "" Or Trim(letter_date.Text) = "" Or (freez.Checked = False And defreez.Checked = False) Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        bt_edit(edit, add1, save, search, dell)
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        '..................
       
        '''=======================================================================================
        Dim DS51 As New DataSet
        Dim t51 As DataTable
        Dim cmd51 As New SqlClient.SqlCommand("SELECT class_id FROM classes where class_name ='" & class_txt4.Text & "'", Con)
        Dim dr51 As SqlClient.SqlDataReader = cmd51.ExecuteReader()
        dr51.Read()
        Dim class_i_d As String = dr51.Item("class_id")
        dr51.Close()
        '''=======================================================================================
        Dim DS512 As New DataSet
        Dim t512 As DataTable
        Dim cmd512 As New SqlClient.SqlCommand("SELECT site_id  FROM sites where site_name ='" & site_txt.Text & "'", Con)
        Dim dr512 As SqlClient.SqlDataReader = cmd512.ExecuteReader()
        dr512.Read()
        Dim site_i_d As String = dr512.Item("site_id")
        dr512.Close()
        '''=======================================================================================
        Dim DS5 As New DataSet
        Dim t5 As DataTable
        Dim cmd5 As New SqlClient.SqlCommand("SELECT emp_id FROM employees where  class_id='" & class_i_d & "' and site_id='" & site_i_d & "' and emp_no ='" & emp_id_txt.Text & "'", Con)
        Dim dr5 As SqlClient.SqlDataReader = cmd5.ExecuteReader()
        dr5.Read()
        Dim emp_n_o As String = dr5.Item("emp_id")
        dr5.Close()

        Dim cmdString As String = "UPDATE stope_salry " + _
                                            "SET letter_no='" & letter_no.Text & "',letter_date = '" & letter_date.Text & "'" + _
                                            "WHERE ser = '" & sel_golb & "'"
        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("·ﬁœ  „  ⁄œÌ· «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
            Call clear()
            '.....
            'Dim ADPt As SqlClient.SqlDataAdapter
            'Dim cmd12 = "SELECT est_akry.ser_ak,emp_no,emp_name,est_akry.est_ok_name,est_akry.est_ok_val,est_akry.month_co,est_akry.month_select,est_akry.sys_date FROM employees,est_akry where est_akry.emp_id=employees.emp_id and est_akry.est_flag=0  and employees.emp_no='" & emp_id_txt.Text & "'"
            'Dim dt As New DataTable
            'ADPt = New SqlClient.SqlDataAdapter(cmd12, Con)
            'ADPt.Fill(dt)
            'DataGrid1.DataSource = dt
            '.....
            emp_id_txt.Text = ""
            'emp_id_txt.Items.Clear()
            empname_txt.Text = ""
            'empname_txt.Items.Clear()
            letter_no.Text = ""
            letter_date.Text = ""
            'est_name_txt.Text = ""
            'est_ok_val_txt.Text = ""

            '.....
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
        edit.Enabled = False
        dell.Enabled = False
        save.Enabled = True
        search.Enabled = False

        'Dim ADPt22 As SqlClient.SqlDataAdapter
        'Dim cmd121 = "SELECT * FROM basic_salary_emp,dgree_base where basic_salary_emp.degree_id=dgree_base.dgree_id  "
        'Dim dt1 As New DataTable
        'ADPt22 = New SqlClient.SqlDataAdapter(cmd121, Con)
        'ADPt22.Fill(dt1)
        'DataGrid1.DataSource = dt1
        'dell.Enabled = False

    End Sub

    Private Sub dell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dell.Click
        bt_dell(edit, add1, save, search, dell)
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim str As String
        TextBox1.Text = emp_no_glob
        str = MsgBox("Â·  —Ìœ Õ–› «·”Ã· «·“Ï ÌÕ„· «·—ﬁ„    :-" + "  " + TextBox1.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Information, " ‰»ÌÂ")
        If str = vbYes Then
            '--------
            'Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM dgree_base where dgree_name='" & degree_txt.Text & "'", Con)
            'Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
            'dr.Read()
            'Dim deg_id = dr.Item("dgree_id")
            'dr.Close()
            '--------

            Dim cmd3 As New SqlClient.SqlCommand("DELETE FROM  stope_salry WHERE ser =  '" & sel_golb & "'", Con)

            Dim da3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd3)
            cmd3.ExecuteNonQuery()
            '.....
            Dim cmdString2 As String = "UPDATE employees " + _
                                                "SET stop_flag='" & stop_flag_ & "' " + _
                                                "WHERE emp_id = '" & emp_id_glob & "'"
            Dim cmd2 As New SqlClient.SqlCommand(cmdString2, Con)
            cmd2.ExecuteNonQuery()
            '.....
        Else
            Exit Sub
        End If
        Try
            bt_add1(edit, add1, save, search, dell)
            'emp_name_txt.Text = ""

            MsgBox("·ﬁœ  „ Õ–› «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
            Call clear()
            'site_txt.Text = ""
            emp_id_txt.Text = ""
            'emp_id_txt.Items.Clear()
            empname_txt.Text = ""
            'empname_txt.Items.Clear()
            class_txt4.Text = ""
            letter_no.Text = ""
            letter_date.Text = ""
            'est_name_txt.Text = ""
            'est_ok_val_txt.Text = ""

            If Con.State = ConnectionState.Broken = False Then
                Con.Close()
            End If

            Con.Open()

            'bt_low(edit, add1, save, search, dell)
            'save.Enabled = True
            'edit.Enabled = False
            'Dim ADPt As SqlClient.SqlDataAdapter
            'Dim cmd12 = "SELECT est_akry.ser_ak,employees.emp_no,employees.emp_name,est_akry.est_ok_name,est_akry.est_ok_val,est_akry.month_co,est_akry.month_select,est_akry.sys_date FROM employees,est_akry where est_akry.emp_id=employees.emp_id and est_akry.est_flag=0  and employees.emp_no='" & emp_id_txt.Text & "'"
            'Dim dt As New DataTable
            'ADPt = New SqlClient.SqlDataAdapter(cmd12, Con)
            'ADPt.Fill(dt)
            'DataGrid1.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dell.Enabled = False
        edit.Enabled = False
        add1.Enabled = True
        search.Enabled = False
        Con.Close()
        ''----------------------------------------------------------
        Dim ADPt As SqlClient.SqlDataAdapter
        Dim cmd12 = "SELECT employees.emp_no,employees.emp_name,stope_salry.letter_date FROM employees,stope_salry WHERE employees.emp_id=stope_salry.emp_id and stope_salry.letter_date=(select max(letter_date) from stope_salry where emp_id='" & -999 & "' and stop_flag='" & stop_flag_ & "') and employees.emp_id='" & -999 & "' "
        Dim dt As New DataTable
        ADPt = New SqlClient.SqlDataAdapter(cmd12, Con)
        ADPt.Fill(dt)
        DataGrid1.DataSource = dt

        ''Dim ADPt22 As SqlClient.SqlDataAdapter
        ''Dim cmd121 = "SELECT * FROM basic_salary_emp,dgree_base where basic_salary_emp.degree_id=dgree_base.dgree_id  "
        ''Dim dt1 As New DataTable
        ''ADPt22 = New SqlClient.SqlDataAdapter(cmd121, Con)
        ''ADPt22.Fill(dt1)
        ''DataGrid1.DataSource = dt1


    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub class_txt_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles class_txt4.SelectedIndexChanged
        '.............
        If (freez.Checked = False And defreez.Checked = False) Then
            MsgBox("ÌÃ» «Œ Ì«— «Ìﬁ«› √Ê  ›⁄Ì· √Ê·«")
            Exit Sub
        End If
        '.........
        If (freez.Checked = True) Then
            stop_flag_ = 2
        End If
        If (defreez.Checked = True) Then
            stop_flag_ = 1
        End If
        '...
        emp_id_txt.Text = ""
        emp_id_txt.Items.Clear()
        empname_txt.Text = ""
        empname_txt.Items.Clear()
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()

        End If
        Con.Open()
        'If defreez.Checked = True Then
        Dim DS As New DataSet
        Dim str As String = "SELECT  employees.emp_no  FROM  employees,classes,sites where employees.stop_flag = '" & stop_flag_ & "'  and  sites.site_name='" & site_txt.Text & "' and sites.site_id=employees.site_id and classes.class_id=employees.class_id and classes.class_name='" & class_txt4.Text & "' "
        Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        ADP.Fill(DS)
        Dim i As Integer
        For i = 0 To DS.Tables(0).Rows.Count - 1
            Me.emp_id_txt.Items.Add(DS.Tables(0).Rows(i).Item(0))
        Next
        ADP.Dispose()
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If

        Con.Open()
        '-------------------------------------------
        Dim DS01 As New DataSet
        Dim str01 As String = "SELECT  employees.emp_name  FROM  employees,classes,sites where  employees.stop_flag = '" & stop_flag_ & "' and sites.site_name='" & site_txt.Text & "' and sites.site_id=employees.site_id and  classes.class_id=employees.class_id and classes.class_name='" & class_txt4.Text & "'"
        Dim ADP01 As New SqlClient.SqlDataAdapter(str01, Con)
        ADP01.Fill(DS01)
        Dim j As Integer
        For j = 0 To DS01.Tables(0).Rows.Count - 1
            Me.empname_txt.Items.Add(DS01.Tables(0).Rows(j).Item(0))
        Next
        ADP01.Dispose()
        'End If


        Con.Close()

    End Sub
    Public Sub clear()
        If (freez.Checked = False And defreez.Checked = False) Then
            MsgBox("ÌÃ» «Œ Ì«— «Ìﬁ«› √Ê  ›⁄Ì· √Ê·«")
            Exit Sub
        End If
        '.........
        If (freez.Checked = True) Then
            stop_flag_ = 2
        End If
        If (defreez.Checked = True) Then
            stop_flag_ = 1
        End If
        '...
        emp_id_txt.Text = ""
        emp_id_txt.Items.Clear()
        empname_txt.Text = ""
        empname_txt.Items.Clear()
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()

        Dim DS As New DataSet
        Dim str As String = "SELECT  employees.emp_no  FROM  employees,classes,sites where employees.stop_flag='" & stop_flag_ & "' and sites.site_name='" & site_txt.Text & "' and sites.site_id=employees.site_id and classes.class_id=employees.class_id and classes.class_name='" & class_txt4.Text & "' "
        Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        ADP.Fill(DS)
        Dim i As Integer
        For i = 0 To DS.Tables(0).Rows.Count - 1
            Me.emp_id_txt.Items.Add(DS.Tables(0).Rows(i).Item(0))
        Next
        ADP.Dispose()
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If

        Con.Open()
        '-------------------------------------------
        Dim DS01 As New DataSet
        Dim str01 As String = "SELECT  employees.emp_name  FROM  employees,classes,sites where  employees.stop_flag='" & stop_flag_ & "' and sites.site_name='" & site_txt.Text & "' and sites.site_id=employees.site_id and  classes.class_id=employees.class_id and classes.class_name='" & class_txt4.Text & "'"
        Dim ADP01 As New SqlClient.SqlDataAdapter(str01, Con)
        ADP01.Fill(DS01)
        Dim j As Integer
        For j = 0 To DS01.Tables(0).Rows.Count - 1
            Me.empname_txt.Items.Add(DS01.Tables(0).Rows(j).Item(0))
        Next
        ADP01.Dispose()



        Con.Close()

    End Sub
    Private Sub dgree_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emp_id_txt.SelectedIndexChanged
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        '==
        'Dim DS51 As New DataSet
        'Dim t51 As DataTable
        'Dim cmd51 As New SqlClient.SqlCommand("SELECT emp_name,emp_id  FROM  employees where  emp_no='" & emp_id_txt.Text & "'", Con)
        'Dim dr51 As SqlClient.SqlDataReader = cmd51.ExecuteReader()
        'dr51.Read()
        'empname_txt.Text = dr51.Item("emp_name")
        'Dim emp_id_i As Integer = dr51.Item("emp_id")
        'dr51.Close()
        '==
        Dim cmd2 As New SqlClient.SqlCommand("SELECT emp_name,emp_id  FROM  sites,employees,classes where     sites.site_name= '" & site_txt.Text & "' and sites.site_id=employees.site_id and  classes.class_name= '" & class_txt4.Text & "' and classes.class_id=employees.class_id and emp_no='" & emp_id_txt.Text & "'", Con)
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        Dim dt As New DataTable
        da.Fill(dt)
        empname_txt.Text = dt.Rows(0).Item("emp_name")
        Dim emp_id_i As Integer = dt.Rows(0).Item("emp_id")
        If (freez.Checked = True) Then
            search.Enabled = False
        End If
        If (defreez.Checked = True) Then
            search.Enabled = True
        End If
        'MsgBox("2")
        '...............
        'Dim ADPt As SqlClient.SqlDataAdapter
        'Dim cmd12 = "SELECT employees.emp_no,employees.emp_name,stope_salry.letter_date FROM employees,stope_salry WHERE employees.emp_id=stope_salry.emp_id and stope_salry.letter_date=(select max(letter_date) from stope_salry where emp_id='" & emp_id_i & "' and stop_flag = '" & stop_flag_ & "' "
        'Dim dt3 As New DataTable
        'ADPt = New SqlClient.SqlDataAdapter(cmd12, Con)
        'ADPt.Fill(dt3)
        'DataGrid1.DataSource = dt3
        '.....
        If (stop_flag_ = 2) Then
            search.Enabled = True
            Dim ADPt1 As SqlClient.SqlDataAdapter
            Dim cmd121 = "SELECT employees.emp_no,employees.emp_name,stope_salry.letter_date FROM employees,stope_salry WHERE employees.emp_id=stope_salry.emp_id and stope_salry.letter_date=(select max(letter_date) from stope_salry where emp_id='" & emp_id_i & "' and stop_flag = '" & 1 & "') and stope_salry.emp_id='" & emp_id_i & "' "
            Dim dt1 As New DataTable
            ADPt1 = New SqlClient.SqlDataAdapter(cmd121, Con)
            ADPt1.Fill(dt1)
            DataGrid1.DataSource = dt1
        End If
        '......
        Con.Close()
    End Sub

    Private Sub empname_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empname_txt.SelectedIndexChanged

        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If

        Con.Open()

        'Dim DS01 As New DataSet
        'Dim str01 As String = "SELECT  employees.emp_name  FROM  employees,classes where  classes.class_id=employees.class_id and classes.class_name='" & class_txt4.Text & "'"
        'Dim ADP01 As New SqlClient.SqlDataAdapter(str01, Con)
        'ADP01.Fill(DS01)
        'Dim j As Integer
        'For j = 0 To DS01.Tables(0).Rows.Count - 1
        '    Me.empname_txt.Items.Add(DS01.Tables(0).Rows(j).Item(0))
        'Next
        'ADP01.Dispose()
        '..
        Dim cmd2 As New SqlClient.SqlCommand("SELECT  employees.emp_no,employees.emp_id  FROM  employees,sites,classes where  classes.class_id=employees.class_id and classes.class_name='" & class_txt4.Text & "' and sites.site_name= '" & site_txt.Text & "' and sites.site_id=employees.site_id  and employees.emp_name='" & empname_txt.Text & "'", Con)
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        Dim dt As New DataTable
        da.Fill(dt)
        emp_id_txt.Text = dt.Rows(0).Item("emp_no")
        Dim emp_id_i As Integer = dt.Rows(0).Item("emp_id")
        'ADP01.Dispose()
        If (freez.Checked = True) Then
            search.Enabled = False
        End If
        If (defreez.Checked = True) Then
            search.Enabled = True
        End If
        '===============================
        If (stop_flag_ = 2) Then
            search.Enabled = True
            Dim ADPt As SqlClient.SqlDataAdapter
            Dim cmd12 = "SELECT employees.emp_no,employees.emp_name,stope_salry.letter_date FROM employees,stope_salry WHERE employees.emp_id=stope_salry.emp_id and stope_salry.letter_date=(select max(letter_date) from stope_salry where emp_id='" & emp_id_i & "' and stop_flag='" & 1 & "') and stope_salry.emp_id='" & emp_id_i & "'"
            Dim dt3 As New DataTable
            ADPt = New SqlClient.SqlDataAdapter(cmd12, Con)
            ADPt.Fill(dt3)
            DataGrid1.DataSource = dt3
        End If
        '===============================
        Con.Close()
    End Sub

    Private Sub month_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGrid1_Navigate_1(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub DataGrid1_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
        Dim col As Int16 = DataGrid1.CurrentCell.ColumnNumber
        Dim row As Int16 = DataGrid1.CurrentCell.RowNumber

        Dim i As Integer

        If IsNumeric(DataGrid1.Item(row, 0)) Then
            If Con.State = ConnectionState.Broken = False Then
                Con.Close()
            End If

            Con.Open()
            'MsgBox(1)
            Dim message, title, defaultValue As String
            Dim m As Integer
            Dim DS As New DataSet
            Dim t As DataTable
            Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM  sites,classes,employees,est_akry where    sites.site_id=employees.site_id And employees.class_id=classes.class_id And est_akry.emp_id=employees.emp_id and est_akry.ser_ak='" & DataGrid1.Item(row, 0) & "' ", Con)
            'Dim cmd2 As New SqlClient.SqlCommand("SELECT est_akry.ser_ak,sites.site_name,classes.class_name,employees.emp_no,employees.emp_name,est_akry.est_name,est_akry.est_ok_val,est_akry.month_co FROM  sites,classes,employees,est_akry ", Con)
            Dim dr44 As SqlClient.SqlDataReader = cmd2.ExecuteReader()
            If dr44.HasRows = False Then
                Con.Close()
                Exit Sub
            End If
            'MsgBox(2)
            dr44.Read()
            MsgBox("2222")
            'MsgBox(3)
            class_txt4.Text = ""
            class_txt4.Items.Clear()
            emp_id_txt.Text = ""
            emp_id_txt.Items.Clear()
            empname_txt.Text = ""
            empname_txt.Items.Clear()
            bt_search(edit, add1, save, search, dell)

            serial = dr44.Item("ser_ak")

            empname_txt.Text = dr44.Item("emp_name")
            'site_txt.Text = dr44.Item("est_name")
            class_txt4.Text = dr44.Item("class_name")

            site_txt.Text = dr44.Item("site_name")
            'MsgBox(dr44.Item("class_name"))

            'Me.class_txt4.Text = dr44.Item("class_name")
            emp_id_txt.Text = dr44.Item("emp_no")


            'est_name_txt.Text = dr44.Item("est_ok_name")

            'est_ok_val_txt.Text = dr44.Item("est_ok_val")

            'month_select.Text = dr44.Item("month_select")
            dr44.Close()

            '-----------------------------------------
            Dim diff As String
            Dim DS3 As New DataSet
            ''''Dim str As String = "Select DATEDIFF(m,sys_date,'" & DateValue(Date.Now) & "') as diff from est_akry where est_flag =0 and DATEDIFF(m, sys_date,'" & DateValue(Date.Now) & "')<1 "
            '''Dim str As String = "Select DATEDIFF(m,sys_date,'" & DateValue(Date.Now) & "') as diff from est_akry where est_flag =0 and est_akry.ser_ak ='" & serial & "'"

            '''Dim ADP As New SqlClient.SqlDataAdapter(Str, Con)
            '''ADP.Fill(DS3)
            'day,'" & DateValue(Date.Now) & "',car2_data.insurance_date)as issa
            'Dim cmd55 As New SqlClient.SqlCommand("Select DATEDIFF(m,sys_date,'" & DateValue(Date.Now) & "') as diff from est_akry where est_flag =0 and  ser_ak ='" & serial & "' ", Con)

            'If Con.State = ConnectionState.Broken = False Then
            '    Con.Close()
            'End If

            'Con.Open()
            ''where est_flag =0 and  ser_ak ='" & serial & "'
            '''DATEDIFF(day,'" & DateValue(Date.Now) & "',sys_date) as diff
            'Dim cmd55 As New SqlClient.SqlCommand("Select DATEDIFF(day,'" & DateValue(Date.Now) & "',sys_date) as diff  from est_akry where   est_flag =0 and  ser_ak ='" & serial & "' ", Con)
            'Dim dr55 As SqlClient.SqlDataReader = cmd55.ExecuteReader()

            'dr55.Read()
            'If dr55.HasRows = False Then

            '    MsgBox("test")
            'End If

            'Call getdiff()

            'MsgBox(dr55.Item("diff"))
            'If DS3.Tables(0).Rows.Count < 1 Then
            '    '------------------------------------------------


            'End If
            edit.Enabled = True
            Try
            Catch er As Exception
                MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√
            End Try

            'dr55.Close()
        End If

    End Sub

    Private Sub class_txt_SelectedIndexChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'emp_id_txt.Text = ""
        'emp_id_txt.Items.Clear()
        'empname_txt.Text = ""
        'empname_txt.Items.Clear()
        'If Con.State = ConnectionState.Broken = False Then
        '    Con.Close()
        'End If

        'Con.Open()
        'Dim DS As New DataSet
        'Dim str As String = "SELECT  employees.emp_no  FROM  employees,classes where  classes.class_id=employees.class_id and classes.class_name='" & class_txt.Text & "' "
        'Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        'ADP.Fill(DS)
        'Dim i As Integer
        'For i = 0 To DS.Tables(0).Rows.Count - 1
        '    Me.emp_id_txt.Items.Add(DS.Tables(0).Rows(i).Item(0))
        'Next
        'ADP.Dispose()
        'If Con.State = ConnectionState.Broken = False Then
        '    Con.Close()
        'End If

        'Con.Open()
        ''-------------------------------------------
        'Dim DS01 As New DataSet
        'Dim str01 As String = "SELECT  employees.emp_name  FROM  employees,classes where  classes.class_id=employees.class_id and classes.class_name='" & class_txt.Text & "'"
        'Dim ADP01 As New SqlClient.SqlDataAdapter(str01, Con)
        'ADP01.Fill(DS01)
        'Dim j As Integer
        'For j = 0 To DS01.Tables(0).Rows.Count - 1
        '    Me.empname_txt.Items.Add(DS01.Tables(0).Rows(j).Item(0))
        'Next
        'ADP01.Dispose()
    End Sub

    Private Sub class_txt4_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles class_txt4.SelectionChangeCommitted
        '''emp_id_txt.Text = ""
        '''emp_id_txt.Items.Clear()
        '''empname_txt.Text = ""
        '''empname_txt.Items.Clear()
        '''If Con.State = ConnectionState.Broken = False Then
        '''    Con.Close()
        '''End If

        '''Con.Open()
        '''Dim DS As New DataSet
        '''Dim str As String = "SELECT  employees.emp_no  FROM  employees,classes where  classes.class_id=employees.class_id and classes.class_name='" & class_txt4.Text & "' "
        '''Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        '''ADP.Fill(DS)
        '''Dim i As Integer
        '''For i = 0 To DS.Tables(0).Rows.Count - 1
        '''    Me.emp_id_txt.Items.Add(DS.Tables(0).Rows(i).Item(0))
        '''Next
        '''ADP.Dispose()
        '''If Con.State = ConnectionState.Broken = False Then
        '''    Con.Close()
        '''End If

        '''Con.Open()
        ''''-------------------------------------------
        '''Dim DS01 As New DataSet
        '''Dim str01 As String = "SELECT  employees.emp_name  FROM  employees,classes where  classes.class_id=employees.class_id and classes.class_name='" & class_txt4.Text & "'"
        '''Dim ADP01 As New SqlClient.SqlDataAdapter(str01, Con)
        '''ADP01.Fill(DS01)
        '''Dim j As Integer
        '''For j = 0 To DS01.Tables(0).Rows.Count - 1
        '''    Me.empname_txt.Items.Add(DS01.Tables(0).Rows(j).Item(0))
        '''Next
        '''ADP01.Dispose()
        '''Con.Close()
        '............................
    End Sub

    Private Sub class_txt4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles class_txt4.LostFocus
        'emp_id_txt.Text = ""
        'emp_id_txt.Items.Clear()
        'empname_txt.Text = ""
        'empname_txt.Items.Clear()
        'If Con.State = ConnectionState.Broken = False Then
        '    Con.Close()
        'End If

        'Con.Open()
        'Dim DS As New DataSet
        'Dim str As String = "SELECT  employees.emp_no  FROM  employees,classes where  classes.class_id=employees.class_id and classes.class_name='" & class_txt4.Text & "' "
        'Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        'ADP.Fill(DS)
        'Dim i As Integer
        'For i = 0 To DS.Tables(0).Rows.Count - 1
        '    Me.emp_id_txt.Items.Add(DS.Tables(0).Rows(i).Item(0))
        'Next
        'ADP.Dispose()
        ''If Con.State = ConnectionState.Broken = False Then
        ''    Con.Close()
        ''End If

        ''Con.Open()
        ''-------------------------------------------
        'Dim DS01 As New DataSet
        'Dim str01 As String = "SELECT  employees.emp_name  FROM  employees,classes where  classes.class_id=employees.class_id and classes.class_name='" & class_txt4.Text & "'"
        'Dim ADP01 As New SqlClient.SqlDataAdapter(str01, Con)
        'ADP01.Fill(DS01)
        'Dim j As Integer
        'For j = 0 To DS01.Tables(0).Rows.Count - 1
        '    Me.empname_txt.Items.Add(DS01.Tables(0).Rows(j).Item(0))
        'Next
        'ADP01.Dispose()
        'If Con.State = ConnectionState.Broken = False Then
        '    Con.Close()
        'End If
        'Con.Open()
    End Sub

    Private Sub empname_txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles empname_txt.LostFocus
        'If Con.State = ConnectionState.Broken = False Then
        '    Con.Close()
        'End If

        'Con.Open()
        'Dim cmd2 As New SqlClient.SqlCommand("SELECT  employees.emp_no  FROM  employees where  employees.emp_name='" & empname_txt.Text & "'", Con)
        'Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        'Dim dt As New DataTable
        'da.Fill(dt)
        'emp_id_txt.Text = dt.Rows(0).Item("emp_no")
        'Con.Close()
    End Sub

    Private Sub emp_id_txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles emp_id_txt.LostFocus


    End Sub

    Private Sub class_txt4_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles class_txt4.DropDown
        class_txt4.Text = ""
        class_txt4.Items.Clear()
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If

        Con.Open()
        Dim DS02 As New DataSet
        Dim str02 As String = "SELECT DISTINCT  class_name  FROM classes"
        Dim ADP02 As New SqlClient.SqlDataAdapter(str02, Con)
        ADP02.Fill(DS02)
        Dim k As Integer
        For k = 0 To DS02.Tables(0).Rows.Count - 1
            Me.class_txt4.Items.Add(DS02.Tables(0).Rows(k).Item(0))
        Next
        ADP02.Dispose()
        Con.Close()
    End Sub

    Private Sub emp_id_txt_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles emp_id_txt.DropDown
        'emp_id_txt.Text = ""
        'emp_id_txt.Items.Clear()
        ''empname_txt.Text = ""
        ''empname_txt.Items.Clear()
        'If Con.State = ConnectionState.Broken = False Then
        '    Con.Close()
        'End If

        'Con.Open()
        'Dim DS As New DataSet
        'Dim str As String = "SELECT  employees.emp_no  FROM  employees,classes where  classes.class_id=employees.class_id and classes.class_name='" & class_txt4.Text & "' "
        'Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        'ADP.Fill(DS)
        'Dim i As Integer
        'For i = 0 To DS.Tables(0).Rows.Count - 1
        '    Me.emp_id_txt.Items.Add(DS.Tables(0).Rows(i).Item(0))
        'Next
        'ADP.Dispose()
        'If Con.State = ConnectionState.Broken = False Then
        '    Con.Close()
        'End If

        'Con.Close()
        ''''-------------------------------------------
        '''Dim DS01 As New DataSet
        '''Dim str01 As String = "SELECT  employees.emp_name  FROM  employees,classes where  classes.class_id=employees.class_id and classes.class_name='" & class_txt.Text & "'"
        '''Dim ADP01 As New SqlClient.SqlDataAdapter(str01, Con)
        '''ADP01.Fill(DS01)
        '''Dim j As Integer
        '''For j = 0 To DS01.Tables(0).Rows.Count - 1
        '''    Me.empname_txt.Items.Add(DS01.Tables(0).Rows(j).Item(0))
        '''Next
        '''ADP01.Dispose()
        '............................
        'Dim DS02 As New DataSet
        'Dim str02 As String = "SELECT DISTINCT  class_name  FROM classes"
        'Dim ADP02 As New SqlClient.SqlDataAdapter(str02, Con)
        'ADP02.Fill(DS02)
        'Dim k As Integer
        'For k = 0 To DS02.Tables(0).Rows.Count - 1
        '    Me.class_txt.Items.Add(DS02.Tables(0).Rows(k).Item(0))
        'Next
        'ADP02.Dispose()

    End Sub

    Private Sub empname_txt_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles empname_txt.DropDown
        '''emp_id_txt.Text = ""
        '''emp_id_txt.Items.Clear()
        'empname_txt.Text = ""
        'empname_txt.Items.Clear()
        'If Con.State = ConnectionState.Broken = False Then
        '    Con.Close()
        'End If

        Con.Open()
        '''Dim DS As New DataSet
        '''Dim str As String = "SELECT  employees.emp_no  FROM  employees,classes where  classes.class_id=employees.class_id and classes.class_name='" & class_txt.Text & "' "
        '''Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        '''ADP.Fill(DS)
        '''Dim i As Integer
        '''For i = 0 To DS.Tables(0).Rows.Count - 1
        '''    Me.emp_id_txt.Items.Add(DS.Tables(0).Rows(i).Item(0))
        '''Next
        '''ADP.Dispose()
        '''If Con.State = ConnectionState.Broken = False Then
        '''    Con.Close()
        '''End If

        '''Con.Open()
        ''''-------------------------------------------

        'Dim DS01 As New DataSet
        'Dim str01 As String = "SELECT  DISTINCT employees.emp_name  FROM  employees,est_akry where  est_akry.emp_id=employees.emp_id and employees.emp_no='" & emp_id_txt.Text & "'"
        'Dim ADP01 As New SqlClient.SqlDataAdapter(str01, Con)
        'ADP01.Fill(DS01)
        'Dim j As Integer
        'For j = 0 To DS01.Tables(0).Rows.Count - 1
        '    Me.empname_txt.Items.Add(DS01.Tables(0).Rows(j).Item(0))
        'Next
        'ADP01.Dispose()

        '............................
        'Dim DS02 As New DataSet
        'Dim str02 As String = "SELECT DISTINCT  class_name  FROM classes"
        'Dim ADP02 As New SqlClient.SqlDataAdapter(str02, Con)
        'ADP02.Fill(DS02)
        'Dim k As Integer
        'For k = 0 To DS02.Tables(0).Rows.Count - 1
        '    Me.class_txt.Items.Add(DS02.Tables(0).Rows(k).Item(0))
        'Next
        'ADP02.Dispose()

        'If Con.State = ConnectionState.Broken = False Then
        '    Con.Close()
        'End If

        'Con.Open()

        'Dim DS01 As New DataSet
        'Dim str01 As String = "SELECT  employees.emp_name  FROM  employees,classes where  classes.class_id=employees.class_id and classes.class_name='" & class_txt4.Text & "'"
        'Dim ADP01 As New SqlClient.SqlDataAdapter(str01, Con)
        'ADP01.Fill(DS01)
        'Dim j As Integer
        'For j = 0 To DS01.Tables(0).Rows.Count - 1
        '    Me.empname_txt.Items.Add(DS01.Tables(0).Rows(j).Item(0))
        'Next
        'ADP01.Dispose()

        'Con.Close()



    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub freez_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles freez.CheckedChanged
        search.Enabled = False
        edit.Enabled = False
        dell.Enabled = False
        Call clear()
    End Sub

    Private Sub defreez_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defreez.CheckedChanged
        Call clear()
    End Sub

    Private Sub letter_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles letter_no.TextChanged

    End Sub

    Private Sub freez_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles freez.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub defreez_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles defreez.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub site_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles site_txt.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub class_txt4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles class_txt4.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub emp_id_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles emp_id_txt.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub empname_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles empname_txt.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub letter_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles letter_no.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub letter_date_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub letter_date_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class

