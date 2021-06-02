Public Class mencard2
    Inherits System.Windows.Forms.Form
    Public bank_val As Integer

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
    Friend WithEvents empname_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents tswiat_tfseely As System.Windows.Forms.RadioButton
    Friend WithEvents tswiatejmaly As System.Windows.Forms.RadioButton
    Friend WithEvents alngdy As System.Windows.Forms.RadioButton
    Friend WithEvents cert_mrtb As System.Windows.Forms.RadioButton
    Friend WithEvents egmaly As System.Windows.Forms.RadioButton
    Friend WithEvents tfseely As System.Windows.Forms.RadioButton
    Friend WithEvents date_ As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents part_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents eyer_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents banck As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Button7 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Viewer1 = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.site_txt = New System.Windows.Forms.ComboBox
        Me.degree = New System.Windows.Forms.Label
        Me.class_txt = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.empname_txt = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.eyer_txt = New System.Windows.Forms.ComboBox
        Me.part_txt = New System.Windows.Forms.ComboBox
        Me.egmaly = New System.Windows.Forms.RadioButton
        Me.date_ = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.banck = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tswiat_tfseely = New System.Windows.Forms.RadioButton
        Me.tswiatejmaly = New System.Windows.Forms.RadioButton
        Me.alngdy = New System.Windows.Forms.RadioButton
        Me.cert_mrtb = New System.Windows.Forms.RadioButton
        Me.tfseely = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        Me.Button1.Location = New System.Drawing.Point(512, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 24)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "⁄—÷ «· ﬁ—Ì—"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(424, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 24)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Œ‹‹‹‹‹‹‹‹—ÊÃ"
        '
        'site_txt
        '
        Me.site_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.site_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.site_txt.Location = New System.Drawing.Point(613, 56)
        Me.site_txt.Name = "site_txt"
        Me.site_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.site_txt.Size = New System.Drawing.Size(248, 21)
        Me.site_txt.TabIndex = 7
        '
        'degree
        '
        Me.degree.BackColor = System.Drawing.Color.DarkGray
        Me.degree.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.degree.Location = New System.Drawing.Point(863, 48)
        Me.degree.Name = "degree"
        Me.degree.Size = New System.Drawing.Size(40, 24)
        Me.degree.TabIndex = 109
        Me.degree.Text = "«·„Êﬁ⁄"
        '
        'class_txt
        '
        Me.class_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.class_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.class_txt.Location = New System.Drawing.Point(360, 56)
        Me.class_txt.Name = "class_txt"
        Me.class_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.class_txt.Size = New System.Drawing.Size(169, 21)
        Me.class_txt.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(536, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 24)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "«· ’‰Ì›"
        '
        'empname_txt
        '
        Me.empname_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.empname_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.empname_txt.Location = New System.Drawing.Point(296, 128)
        Me.empname_txt.Name = "empname_txt"
        Me.empname_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.empname_txt.Size = New System.Drawing.Size(232, 21)
        Me.empname_txt.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(536, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 24)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "«·«”„"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.eyer_txt)
        Me.GroupBox1.Controls.Add(Me.part_txt)
        Me.GroupBox1.Controls.Add(Me.egmaly)
        Me.GroupBox1.Controls.Add(Me.date_)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.empname_txt)
        Me.GroupBox1.Controls.Add(Me.class_txt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.site_txt)
        Me.GroupBox1.Controls.Add(Me.degree)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.tswiat_tfseely)
        Me.GroupBox1.Controls.Add(Me.tswiatejmaly)
        Me.GroupBox1.Controls.Add(Me.alngdy)
        Me.GroupBox1.Controls.Add(Me.cert_mrtb)
        Me.GroupBox1.Controls.Add(Me.tfseely)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(944, 176)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(40, 128)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 780
        Me.DateTimePicker1.Value = New Date(2020, 8, 25, 0, 0, 0, 0)
        '
        'RadioButton4
        '
        Me.RadioButton4.BackColor = System.Drawing.Color.DarkGray
        Me.RadioButton4.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton4.Location = New System.Drawing.Point(152, 128)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton4.Size = New System.Drawing.Size(88, 24)
        Me.RadioButton4.TabIndex = 781
        Me.RadioButton4.Text = " «—ÌŒ «·‘Ìﬂ"
        '
        'RadioButton2
        '
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.RadioButton2.Location = New System.Drawing.Point(184, 21)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton2.Size = New System.Drawing.Size(80, 24)
        Me.RadioButton2.TabIndex = 777
        Me.RadioButton2.Text = "«·›Â—”"
        '
        'eyer_txt
        '
        Me.eyer_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.eyer_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.eyer_txt.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035"})
        Me.eyer_txt.Location = New System.Drawing.Point(612, 88)
        Me.eyer_txt.Name = "eyer_txt"
        Me.eyer_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.eyer_txt.Size = New System.Drawing.Size(84, 21)
        Me.eyer_txt.TabIndex = 145
        '
        'part_txt
        '
        Me.part_txt.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.part_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.part_txt.ForeColor = System.Drawing.Color.Black
        Me.part_txt.Items.AddRange(New Object() {"«·√Ê·", "«·À«‰Ì", "«·À«·À", "«·—«»⁄", "«·Œ«„”", "«·”«œ”", "„‰Õ… ⁄Ìœ «·›ÿ—", "„‰Õ… ⁄Ìœ «·«÷ÕÏ"})
        Me.part_txt.Location = New System.Drawing.Point(24, 80)
        Me.part_txt.Name = "part_txt"
        Me.part_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.part_txt.Size = New System.Drawing.Size(96, 21)
        Me.part_txt.TabIndex = 10
        '
        'egmaly
        '
        Me.egmaly.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.egmaly.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.egmaly.Location = New System.Drawing.Point(808, 13)
        Me.egmaly.Name = "egmaly"
        Me.egmaly.Size = New System.Drawing.Size(96, 24)
        Me.egmaly.TabIndex = 0
        Me.egmaly.Text = " ﬁ—Ì— ≈Ã„«·Ì"
        Me.egmaly.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'date_
        '
        Me.date_.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.date_.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.date_.Items.AddRange(New Object() {"Ì‰«Ì—", "›»—«Ì—", "„«—”", "«»—Ì·", "„«ÌÊ", "ÌÊ‰ÌÊ", "ÌÊ·ÌÊ", "√€”ÿ”", "”» „»—", "√ﬂ Ê»—", "‰Ê›„»—", "œÌ”„»—"})
        Me.date_.Location = New System.Drawing.Point(772, 88)
        Me.date_.Name = "date_"
        Me.date_.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.date_.Size = New System.Drawing.Size(88, 21)
        Me.date_.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(863, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 24)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "«·‘Â—"
        '
        'RadioButton1
        '
        Me.RadioButton1.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.RadioButton1.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.RadioButton1.Location = New System.Drawing.Point(32, -128)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton1.Size = New System.Drawing.Size(96, 60)
        Me.RadioButton1.TabIndex = 131
        Me.RadioButton1.Text = "ﬁ«∆„…"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.banck)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(288, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(616, 128)
        Me.GroupBox2.TabIndex = 141
        Me.GroupBox2.TabStop = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button7.Location = New System.Drawing.Point(296, 88)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(120, 24)
        Me.Button7.TabIndex = 167
        Me.Button7.Text = "Excel Sheet"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(248, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "«·»‰ﬂ"
        '
        'banck
        '
        Me.banck.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.banck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.banck.Location = New System.Drawing.Point(8, 54)
        Me.banck.Name = "banck"
        Me.banck.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.banck.Size = New System.Drawing.Size(232, 21)
        Me.banck.TabIndex = 141
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(424, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 24)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "«·”‰…"
        '
        'tswiat_tfseely
        '
        Me.tswiat_tfseely.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.tswiat_tfseely.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.tswiat_tfseely.Location = New System.Drawing.Point(448, 12)
        Me.tswiat_tfseely.Name = "tswiat_tfseely"
        Me.tswiat_tfseely.Size = New System.Drawing.Size(112, 24)
        Me.tswiat_tfseely.TabIndex = 3
        Me.tswiat_tfseely.Text = " ”ÊÌ«   ›’Ì·Ì"
        Me.tswiat_tfseely.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tswiatejmaly
        '
        Me.tswiatejmaly.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.tswiatejmaly.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.tswiatejmaly.Location = New System.Drawing.Point(568, 12)
        Me.tswiatejmaly.Name = "tswiatejmaly"
        Me.tswiatejmaly.TabIndex = 2
        Me.tswiatejmaly.Text = " ”ÊÌ«  ≈Ã„«·Ì"
        Me.tswiatejmaly.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'alngdy
        '
        Me.alngdy.BackColor = System.Drawing.Color.Transparent
        Me.alngdy.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.alngdy.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.alngdy.ForeColor = System.Drawing.Color.Brown
        Me.alngdy.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.alngdy.Location = New System.Drawing.Point(28, 28)
        Me.alngdy.Name = "alngdy"
        Me.alngdy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.alngdy.Size = New System.Drawing.Size(88, 24)
        Me.alngdy.TabIndex = 6
        Me.alngdy.Text = "«·»œÌ· «·‰ﬁœÌ"
        Me.alngdy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cert_mrtb
        '
        Me.cert_mrtb.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.cert_mrtb.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cert_mrtb.Location = New System.Drawing.Point(352, 14)
        Me.cert_mrtb.Name = "cert_mrtb"
        Me.cert_mrtb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cert_mrtb.Size = New System.Drawing.Size(90, 24)
        Me.cert_mrtb.TabIndex = 4
        Me.cert_mrtb.Text = "‘Â«œ… „— »"
        Me.cert_mrtb.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tfseely
        '
        Me.tfseely.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.tfseely.Checked = True
        Me.tfseely.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.tfseely.Location = New System.Drawing.Point(696, 12)
        Me.tfseely.Name = "tfseely"
        Me.tfseely.Size = New System.Drawing.Size(96, 27)
        Me.tfseely.TabIndex = 1
        Me.tfseely.TabStop = True
        Me.tfseely.Text = " ﬁ—Ì—  ›’Ì·Ï"
        Me.tfseely.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(144, 104)
        Me.GroupBox3.TabIndex = 144
        Me.GroupBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Firebrick
        Me.Label7.Location = New System.Drawing.Point(40, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 144
        Me.Label7.Text = "«·Ã“¡"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.Location = New System.Drawing.Point(-48, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 24)
        Me.Button3.TabIndex = 146
        Me.Button3.Text = "«·›Â‹‹—”"
        Me.Button3.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox4.Location = New System.Drawing.Point(160, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox4.Size = New System.Drawing.Size(120, 104)
        Me.GroupBox4.TabIndex = 148
        Me.GroupBox4.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(44, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "«· — Ì»"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.ComboBox1.Items.AddRange(New Object() {"Õ”» «·—ﬁ„ ", "Õ”» «·«”„", "Õ”» «·œ—Ã…"})
        Me.ComboBox1.Location = New System.Drawing.Point(8, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(-72, 32)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(136, 32)
        Me.Button5.TabIndex = 130
        Me.Button5.Text = "Button5"
        Me.Button5.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RadioButton3.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton3.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.RadioButton3.Location = New System.Drawing.Point(296, 16)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton3.Size = New System.Drawing.Size(49, 24)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.Text = "ﬁ«∆„…"
        '
        'Button4
        '
        Me.Button4.AllowDrop = True
        Me.Button4.BackColor = System.Drawing.SystemColors.Desktop
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(-32, 112)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 24)
        Me.Button4.TabIndex = 147
        Me.Button4.Text = "«·›Â‹‹—”"
        Me.Button4.Visible = False
        '
        'mencard2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(992, 780)
        Me.Controls.Add(Me.Viewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mencard2"
        Me.Text = "ﬂ‘› «·„— »«»"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Exit Sub
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim df As New SECURITY
            Dim _tmp As Cursor
            _tmp = Me.Cursor
            Me.Cursor = Cursors.WaitCursor
            Dim _rpt = New ActiveReport3

            Dim _DS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource
            _DS.ConnectionString = "User ID= '" & df.UserID.Text & "';" & _
            "Password='" & df.Password.Text & "';" & _
            "Initial Catalog=accoun;" & _
           "Data Source=main2;" & _
            "Connection TimeOut=30;"
            '=================================================banck
            If RadioButton4.Checked = True Then
                If Trim(date_.Text) = "" Or Trim(eyer_txt.Text) = "" Or Trim(banck.Text) = "" Then
                    MsgBox(" «ﬂœ „‰ «œŒ«· «·»Ì«‰«  «·„ÿ·Ê»… ·ﬁ«∆„… «·»‰ﬂ")
                    Exit Sub
                End If
                _rpt = New listbank
                'Dim x As String
                'Dim cmd2 As New SqlClient.SqlCommand("SELECT bank from employees ,classes where  employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'", Con)
                'Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
                'Dim dt As New DataTable
                'da.Fill(dt)
                'If dt.Rows.Count < 1 Then
                '    MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                '    Exit Sub
                'End If


                Dim message, title, defaultValue As String
                Dim m As Integer
                message = " «œŒ· —ﬁ„ «·‘Ìﬂ "
                title = "—ﬁ„ «·‘Ìﬂ"
                shack_no = InputBox(message, title, defaultValue, MsgBoxStyle.OKOnly)


                Dim bank_name As String = "·« ÌÊÃœ"
                classname = ""
                classname = " «·”Ìœ/ „œÌ—  " + banck.Text + " " + "‰—ÃÊ  €–Ì… „— »«  «·”«œ… «·„“ﬂÊ—Ì‰ «œ‰«Â"
                Dim k As Integer
                'Dim id_em = dt.Rows(0).Item("emp_id")  employees.emp_no ,employees.emp_name,classes.class_name
                datshake = DateTimePicker1.Text
                'Dim _sqlString As String = "Select  bank_name,emp_name,account_no,note,sum(archief.alsafy)as alsafy FROM sites,employees,banks,archief WHERE    employees.stop_flag='" & 2 & "' and employees.emp_id=archief.emp_id and employees.bank_id=banks.bank_id  and archief.eyer='" & eyer_txt.Text & "'  and  archief.date_='" & date_.Text & "' and  banks.bank_name='" & banck.Text & "' and banks.bank_name<>'" & bank_name & "' group by archief.emp_id , bank_name,emp_name,account_no,note order by employees.emp_name" 'sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and  lasttttttttttttttt
                Dim _sqlString As String = "Select  archief.emp_id,employees.emp_name,account_no,note,sum(archief.alsafy)as alsafy FROM employees,banks,archief WHERE   employees.class_id=archief.class_id and employees.stop_flag='" & 2 & "' and employees.emp_id=archief.emp_id and employees.bank_id=banks.bank_id  and archief.eyer='" & eyer_txt.Text & "'  and  archief.date_='" & date_.Text & "' and  banks.bank_name='" & banck.Text & "' and banks.bank_name='" & banck.Text & "' group by archief.emp_id ,emp_name,account_no,note order by employees.emp_name"  'sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and
                '_sqlString = _sqlString + "FROM employees,banks,archief"
                '_sqlString = _sqlString + " WHERE  employees.stop_flag='" & 2 & "' and employees.emp_id=archief.emp_id and employees.bank_id=banks.bank_id  and archief.eyer='" & eyer_txt.Text & "'  and  archief.date_='" & date_.Text & "' and  banks.bank_name='" & banck.Text & "'  order by employees.emp_name"
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS


            End If
            '==================================================list

            If RadioButton3.Checked = True Then 'list
                _rpt = New listrep
                Dim x As String
                Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no ,employees.emp_name,classes.class_name,sites.site_name from employees ,classes,sites where  sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and  employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'", Con)
                Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
                Dim dt As New DataTable
                da.Fill(dt)
                If dt.Rows.Count < 1 Then
                    MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                    Exit Sub
                End If
                classname = ""
                classname = " ﬂ‘› »«”„«¡ " + dt.Rows(0).Item("class_name") + " / " + dt.Rows(0).Item("site_name")
                Dim k As Integer
                'Dim id_em = dt.Rows(0).Item("emp_id")  employees.emp_no ,employees.emp_name,classes.class_name
                Dim _sqlString As String = "Select *"
                _sqlString = _sqlString + "FROM employees,classes,sites"
                _sqlString = _sqlString + " WHERE  sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "' order by employees.emp_name"
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS
            End If
            '=====================================================================
            If tfseely.Checked = True Then

                MsgBox(" ›’Ì·Ï", MsgBoxStyle.Information + vbMsgBoxRight, "—∆«”… «·ÃÂ«“ «·ﬁ÷«∆Ï  Ê·«Ì… «·Ã“Ì—… ...»—‰«„Ã «·„— »« ")
                If banck.Text = "" Or banck.Text = "·« ÌÊÃœ" Then
                    Dim x As String
                    Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_id,classes.class_name ,classes.class_id ,sites.site_name from employees ,sites,classes where  employees.stop_flag='" & 2 & "' and  sites.site_name='" & site_txt.Text & "' and employees.site_id=sites.site_id and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'", Con)
                    Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    If dt.Rows.Count < 1 Then
                        MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                        Exit Sub
                    End If
                    Dim class_i_d = dt.Rows(0).Item("class_id")
                    'MsgBox(class_i_d)
                    Dim k As Integer
                    'Dim id_em = dt.Rows(0).Item("emp_id")

                    classname = " ﬂ‘› „— »«  " + dt.Rows(0).Item("class_name") + " / " + dt.Rows(0).Item("site_name")
                    '"ﬂ‘› „— »«  " + "" + classname
                    Dim _sqlString As String = "Select banks.bank_name,archief.emp_no, archief.con_bdl_name,archief.con_bdl_val, archief.not_conbdel_name,archief.not_conbdle_val,archief.basic_sal,employees.emp_name,archief.date_ ,archief.con_est_name ,archief.con_est_val,archief.est_ok_name ,archief.est_ok_val ,archief.est_sum ,archief.bdl_sum ,archief.alsafy ,archief.dgree_name ,archief.stop_flag,archief.eyer "
                    _sqlString = _sqlString + "FROM  archief,employees,sites,banks"
                    _sqlString = _sqlString + " WHERE   employees.bank_id=banks.bank_id and sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and employees.emp_id=archief.emp_id and archief.eyer ='" & eyer_txt.Text & "' and archief.date_ ='" & date_.Text & "'  and archief.class_id='" & class_i_d & "' and archief.stop_flag=2 ORDER BY employees.dgree_id ,archief.emp_no,archief.con_bdl_name"  'archief.emp_id---archief.emp_no= employees.emp_no and
                    _DS.SQL = _sqlString
                    _rpt.DataSource = _DS
                Else
                    Dim x As String
                    Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_id,classes.class_name ,classes.class_id,sites.site_name from employees ,sites,classes where  employees.stop_flag='" & 2 & "' and employees.site_id=sites.site_id and sites.site_name='" & site_txt.Text & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'", Con)
                    Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count < 1 Then
                        MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                        Exit Sub
                    End If
                    Dim class_i_d = dt.Rows(0).Item("class_id")
                    Dim k As Integer
                    Dim id_em = dt.Rows(0).Item("emp_id")

                    classname = " ﬂ‘› „— »«  " + dt.Rows(0).Item("class_name") + " / " + dt.Rows(0).Item("site_name") + " / " + banck.Text
                    '"ﬂ‘› „— »«  " + "" + classname
                    Dim _sqlString As String = "Select archief.emp_no, archief.con_bdl_name,archief.con_bdl_val, archief.not_conbdel_name,archief.not_conbdle_val,archief.basic_sal,employees.emp_name,archief.date_ ,archief.con_est_name ,archief.con_est_val,archief.est_ok_name ,archief.est_ok_val ,archief.est_sum ,archief.bdl_sum ,archief.alsafy ,archief.dgree_name ,archief.stop_flag,archief.eyer,banks.bank_name "
                    _sqlString = _sqlString + "FROM  archief,employees,banks,sites"
                    _sqlString = _sqlString + " WHERE    sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and employees.emp_id=archief.emp_id and archief.eyer ='" & eyer_txt.Text & "' and archief.date_ ='" & date_.Text & "' and banks.bank_name='" & banck.Text & "' and archief.class_id='" & class_i_d & "' and banks.bank_id=employees.bank_id and banks.bank_name='" & banck.Text & "' and archief.stop_flag=2 ORDER BY employees.dgree_id ,archief.emp_no,archief.con_bdl_name"  'archief.emp_id---archief.emp_no= employees.emp_no and
                    _DS.SQL = _sqlString
                    _rpt.DataSource = _DS
                End If
            End If

            '///////////////////////////////////////////////////////////////////////‘Â«œ… „— »
            If cert_mrtb.Checked = True Then
                MsgBox("‘Â«œ… „— »", MsgBoxStyle.Information + vbMsgBoxRight, "—∆«”… «·ÃÂ«“ «·ﬁ÷«∆Ï  Ê·«Ì… «·Ã“Ì—… ...»—‰«„Ã «·„— »« ")
                If empname_txt.Text = "" Then
                    MsgBox("«Œ — «”„ «·„ÊŸ›")
                    Exit Sub
                End If
                _rpt = New salary_cert1  'salary_cert
                Dim x As String
                Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_id ,classes.class_id,classes.class_name,sites.site_name from employees ,sites,classes where   sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and employees.stop_flag='" & 2 & "' and employees.site_id=sites.site_id and employees.class_id=classes.class_id and classes.class_name='" & class_txt.Text & "' and employees.emp_name='" & empname_txt.Text & "'", Con)
                Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
                Dim dt As New DataTable
                da.Fill(dt)
                If dt.Rows.Count < 1 Then
                    MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «·«”„  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                    Exit Sub
                End If
                Dim class_i_d = dt.Rows(0).Item("class_id")
                'Dim emp_id = dt.Rows(0).Item("emp_id")
                classname = dt.Rows(0).Item("class_name") + " / " + dt.Rows(0).Item("site_name") + " / " + "  ‘Â«œ… „— »  "
                Dim k As Integer
                Dim id_em = dt.Rows(0).Item("emp_id")
                Dim _sqlString As String = "Select * "
                _sqlString = _sqlString + "FROM archief,employees"
                _sqlString = _sqlString + " WHERE  archief.eyer ='" & eyer_txt.Text & "' and archief.date_ ='" & date_.Text & "' and employees.emp_id=archief.emp_id  and archief.emp_id='" & id_em & "'"
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS
                empname_txt.Enabled = False
            End If

            If egmaly.Checked = True Then '«Ã„«·Ï
                If banck.Text = "" Or banck.Text = "·« ÌÊÃœ" Then
                    MsgBox("«Ã„«·Ï", MsgBoxStyle.Information + vbMsgBoxRight, "—∆«”… «·ÃÂ«“ «·ﬁ÷«∆Ï  Ê·«Ì… «·Ã“Ì—… ...»—‰«„Ã «·„— »« ")
                    _rpt = New totalsal
                    Dim x As String
                    Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_id,classes.class_name ,classes.class_id,sites.site_name from employees ,sites,classes where   sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and employees.stop_flag='" & 2 & "' and employees.site_id=sites.site_id and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'", Con)
                    Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count < 1 Then
                        MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                        Exit Sub
                    End If
                    Dim class_i_d = dt.Rows(0).Item("class_id")
                    'MsgBox(class_i_d)
                    Dim k As Integer
                    Dim id_em = dt.Rows(0).Item("emp_id")

                    classname = " ﬂ‘› ≈Ã„«·Ì „— »«  " + dt.Rows(0).Item("class_name") + " / " + dt.Rows(0).Item("site_name")
                    '"ﬂ‘› „— »«  " + "" + classname
                    Dim mo As String = "Ì‰«Ì—"
                    Dim _sqlString As String = "Select * "
                    _sqlString = _sqlString + "FROM total,sites"
                    _sqlString = _sqlString + " WHERE  sites.site_id=total.site_id and sites.site_name='" & site_txt.Text & "' and eyer='" & eyer_txt.Text & "' and total.date_ ='" & date_.Text & "'  and total.class_id='" & class_i_d & "' order by con_bdl_name"
                    _DS.SQL = _sqlString
                    _rpt.DataSource = _DS
                Else
                    MsgBox("«Ã„«·Ï", MsgBoxStyle.Information + vbMsgBoxRight, "—∆«”… «·ÃÂ«“ «·ﬁ÷«∆Ï  Ê·«Ì… «·Ã“Ì—… ...»—‰«„Ã «·„— »« ")
                    _rpt = New totalsal
                    Dim x As String
                    Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_id,classes.class_name ,classes.class_id,sites.site_name from employees ,sites,classes where   sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and employees.stop_flag='" & 2 & "' and employees.site_id=sites.site_id and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'", Con)
                    Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    If dt.Rows.Count < 1 Then
                        MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                        Exit Sub
                    End If
                    Dim class_i_d = dt.Rows(0).Item("class_id")
                    'MsgBox(class_i_d)
                    Dim k As Integer
                    Dim id_em = dt.Rows(0).Item("emp_id")

                    classname = " ﬂ‘› ≈Ã„«·Ì „— »«  " + dt.Rows(0).Item("class_name") + " / " + dt.Rows(0).Item("site_name")
                    '"ﬂ‘› „— »«  " + "" + classname
                    Dim mo As String = "Ì‰«Ì—"
                    Dim _sqlString As String = "Select * "
                    _sqlString = _sqlString + "FROM total,sites"
                    _sqlString = _sqlString + " WHERE  sites.site_id=total.site_id and sites.site_name='" & site_txt.Text & "' and eyer='" & eyer_txt.Text & "' and total.date_ ='" & date_.Text & "'  and total.class_id='" & class_i_d & "' order by con_bdl_name"
                    _DS.SQL = _sqlString
                    _rpt.DataSource = _DS

                End If
            End If

            '-------------«·›Â—” -------------------------------------------------------------------«·›Â—”

            If RadioButton2.Checked = True Then

                _rpt = New ind
                '--------------------------------------------------------------------------------------------

                Dim ord_by As String
                Select Case ComboBox1.SelectedIndex
                    Case 0
                        ord_by = "employees.emp_no"
                    Case 1
                        ord_by = "employees.emp_name"
                    Case 2
                        ord_by = "dgree_base.dgree_id"
                    Case Else
                        ord_by = "employees.emp_name"
                End Select
                '_rpt = New listrep
                Dim x As String
                Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no ,employees.emp_name,classes.class_name,sites.site_name from employees ,classes ,sites where  sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'", Con)
                Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
                Dim dt As New DataTable
                da.Fill(dt)
                If dt.Rows.Count < 1 Then
                    MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                    Exit Sub
                End If
                classname = ""
                classname = " ›Â—”  " + dt.Rows(0).Item("class_name") + " / " + dt.Rows(0).Item("site_name")
                Dim k As Integer
                Dim _sqlString As String = "Select dgree_base.dgree_name,basic_salary_emp.basic_sal,employees.emp_name,employees.emp_no  "
                _sqlString = _sqlString + "FROM employees,classes,basic_salary_emp,dgree_base,sites"
                _sqlString = _sqlString + " WHERE sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and dgree_base.dgree_id=employees.dgree_id  and    employees.dgree_id=basic_salary_emp.degree_id and employees.sections=basic_salary_emp.section_count and employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "' order by  " + ord_by + " "
                _DS.SQL = _sqlString
                _rpt.DataSource = _DS

            End If

            '================«·»œÌ·

            If alngdy.Checked = True Then '«·»œÌ·
                Dim xx As Integer
                Dim ss As String = banck.Text
                If (part_txt.Text = "„‰Õ… ⁄Ìœ «·«÷ÕÏ") Then
                    xx = 2
                Else
                    xx = 1
                End If
                If (class_txt.Text <> "«·„ ⁄«ﬁœÌ‰" And class_txt.Text <> "⁄„«· «·„ÿ»⁄…" And class_txt.Text <> "«·ﬁ÷«… «·„ ⁄«ﬁœÌ‰" And class_txt.Text <> "„ ⁄«ﬁœÌ‰/«·Ê—‘Â") Then
                    '*********
                    If (class_txt.Text = "÷»«ÿ" Or class_txt.Text = "÷»«ÿ «·’›" Or class_txt.Text = "«·Ã‰Êœ" Or class_txt.Text = "‘—ÿ… »‰Êﬂ" Or class_txt.Text = "‘—ÿ… Œ“Ì‰…" Or class_txt.Text = "«·ﬁ÷«…" Or class_txt.Text = "ﬁ÷«… »‰Êﬂ" Or class_txt.Text = "ﬁ÷«… Œ“Ì‰…") Then '«·ﬁ÷«… Ê«·‘—ÿ…
                        _rpt = New bdeelrep  'bdeelrep2 '

                        Dim x As String
                        Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no ,employees.emp_name,employees.bank_id,classes.class_id,classes.class_name,sites.site_name,sites.site_id from employees ,classes,sites where sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id and classes.class_name='" & class_txt.Text & "' and employees.bdeel_flag='" & 0 & "' ", Con)
                        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count < 1 Then

                            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                            Exit Sub
                        End If
                        Dim clas_id = dt.Rows(0).Item("class_id")
                        Dim bank_id = dt.Rows(0).Item("bank_id")
                        Dim site_id = dt.Rows(0).Item("site_id")

                        Dim dmga As String = "œ„€…"
                        Dim egtmaya As String = "«Ã „«⁄Ì…"
                        Dim minha As String = "„‰Õ…"
                        Dim Had_adna As String = "«·Õœ «·√œ‰Ï"
                        Dim Alawa_khasa As String = "⁄·«Ê… Œ«’…"
                        Dim Sh_amal_ga As String = "‘»Â ⁄„·"
                        Dim Alawa_amniya As String = "⁄·«Ê… «„‰Ì…"


                        classname = ""
                        If (part_txt.Text = "„‰Õ… ⁄Ìœ «·›ÿ—" Or part_txt.Text = "„‰Õ… ⁄Ìœ «·«÷ÕÏ") Then
                            classname = "(" + " ⁄»«—… ⁄‰   " + part_txt.Text + " " + "··⁄«„ «·„«·Ì" + Str(EYER) + "„ " + " " + "( " + dt.Rows(0).Item("class_name") + "/" + dt.Rows(0).Item("site_name")
                        Else
                            classname = "(" + " ⁄»«—… ⁄‰ «·»œÌ· «·‰ﬁœÌ «·Ã“¡  " + part_txt.Text + " " + "··⁄«„ «·„«·Ì" + Str(EYER) + "„ " + " " + "( " + dt.Rows(0).Item("class_name") + "/" + ss + "/" + dt.Rows(0).Item("site_name")
                        End If

                        Dim k As Integer
                        Dim _sqlString As String
                        If (class_txt.Text = "÷»«ÿ" Or class_txt.Text = "÷»«ÿ «·’›" Or class_txt.Text = "«·Ã‰Êœ" Or class_txt.Text = "‘—ÿ… »‰Êﬂ" Or class_txt.Text = "‘—ÿ… Œ“Ì‰…") Then
                            If (part_txt.Text = "„‰Õ… ⁄Ìœ «·›ÿ—") Then
                                xx = 2
                                _sqlString = "select  emp_no, emp_name,(tot_sum * " & xx & ") as mblg,(1) as hj,(1)as tot,((tot_sum * " & xx & ")-1) as net from Badeel  where  site_id= '" & site_id & "'  and class_id='" & clas_id & "' and date_='" & date_.Text & "' and eyer='" & eyer_txt.Text & "'   and stop_flag='" & 2 & "' and bdeel_flag='" & 0 & "' order by emp_no"
                                _rpt = New bdeelrep 'bdeel5
                            ElseIf (part_txt.Text = "„‰Õ… ⁄Ìœ «·«÷ÕÏ") Then
                                xx = 3
                                _sqlString = "select  emp_no, emp_name,(tot_sum * " & xx & ") as mblg,(1) as hj,(1)as tot,((tot_sum * " & xx & ")-1) as net from Badeel  where  site_id= '" & site_id & "'  and class_id='" & clas_id & "' and date_='" & date_.Text & "' and eyer='" & eyer_txt.Text & "'   and stop_flag='" & 2 & "' and bdeel_flag='" & 0 & "' order by emp_no"
                                _rpt = New bdeelrep 'bdeel5
                            Else
                                xx = 1
                                _sqlString = "select  emp_no, emp_name,(tot_sum * " & xx & ") as mblg,(est_hj * " & xx & ") as hj,(1) as dmga,((est_hj * " & xx & ")+1)as tot,((tot_sum * " & xx & ")-(est_hj *" & xx & ")-1) as net from Badeel  where  site_id= '" & site_id & "'  and class_id='" & clas_id & "' and date_='" & date_.Text & "' and eyer='" & eyer_txt.Text & "' and  stop_flag='" & 2 & "' and bdeel_flag='" & 0 & "' order by emp_no"
                                _rpt = New bdeel5
                            End If
                        Else
                            'ﬁ÷«…
                            If (part_txt.Text = "„‰Õ… ⁄Ìœ «·›ÿ—") Then
                                xx = 2
                                _sqlString = "select  emp_no, emp_name,(tot_sum * " & xx & ") as mblg,(100) as hj,(1) as dmga,(101)as tot,((tot_sum * " & xx & ")-101) as net from Badeel  where  site_id= '" & site_id & "'  and class_id='" & clas_id & "' and date_='" & date_.Text & "' and eyer='" & eyer_txt.Text & "' and  stop_flag='" & 2 & "' and bdeel_flag='" & 0 & "' order by emp_no"
                                _rpt = New bdeel6
                            ElseIf (part_txt.Text = "„‰Õ… ⁄Ìœ «·«÷ÕÏ") Then
                                xx = 3
                                _sqlString = "select  emp_no, emp_name,(tot_sum * " & xx & ") as mblg,(100) as hj,(1) as dmga,(101)as tot,((tot_sum * " & xx & ")-101) as net from Badeel  where  site_id= '" & site_id & "'  and class_id='" & clas_id & "' and date_='" & date_.Text & "' and eyer='" & eyer_txt.Text & "' and  stop_flag='" & 2 & "' and bdeel_flag='" & 0 & "' order by emp_no"
                                _rpt = New bdeel6
                            Else
                                xx = 1
                                _sqlString = "select  emp_no, emp_name,(tot_sum * " & xx & ") as mblg,(est_hj * " & xx & ") as hj,(100) as dar,(1) as dmga,((est_hj * " & xx & ")+101)as tot,((tot_sum * " & xx & ")-(est_hj *" & xx & ")-101) as net from Badeel  where  site_id= '" & site_id & "'  and class_id='" & clas_id & "' and date_='" & date_.Text & "' and eyer='" & eyer_txt.Text & "' and  stop_flag='" & 2 & "' and bdeel_flag='" & 0 & "' order by emp_no"
                                _rpt = New bdeel4
                            End If
                        End If
                        _DS.SQL = _sqlString
                        _rpt.DataSource = _DS
                    Else '«·„ÊŸ›Ì‰ „« ⁄œ« «·„ ⁄«ﬁœÌ‰ /«·‘—ÿ… / «·ﬁ÷«…
                        _rpt = New bdeelrep2
                        Dim x As String
                        Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no ,employees.emp_name,classes.class_id,classes.class_name,sites.site_id,sites.site_name from employees ,classes,sites where sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id and classes.class_name='" & class_txt.Text & "' and employees.bdeel_flag='" & 0 & "' ", Con)
                        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
                        Dim dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count < 1 Then
                            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                            Exit Sub
                        End If
                        Dim clas_id = dt.Rows(0).Item("class_id")
                        Dim site_id = dt.Rows(0).Item("site_id")
                        Dim dmga As String = "œ„€…"
                        Dim egtmaya As String = "«Ã „«⁄Ì…"
                        Dim momyza As String = "„„Ì“Â"
                        Dim Had_adna As String = "«·Õœ «·√œ‰Ï"
                        Dim Alawa_khasa As String = "⁄·«Ê… Œ«’…"
                        Dim Sh_amal_ga As String = "‘»Â ⁄„·"

                        classname = ""
                        If (part_txt.Text = "„‰Õ… ⁄Ìœ «·›ÿ—" Or part_txt.Text = "„‰Õ… ⁄Ìœ «·«÷ÕÏ") Then
                            classname = "(" + " ⁄»«—… ⁄‰   " + part_txt.Text + " " + "··⁄«„ «·„«·Ì" + Str(EYER) + "„ " + " " + "( " + dt.Rows(0).Item("class_name") + "/" + dt.Rows(0).Item("site_name")
                        Else
                            classname = "(" + " ⁄»«—… ⁄‰ «·»œÌ· «·‰ﬁœÌ «·Ã“¡  " + part_txt.Text + " " + "··⁄«„ «·„«·Ì" + Str(EYER) + "„ " + " " + "( " + dt.Rows(0).Item("class_name") + "/" + dt.Rows(0).Item("site_name")
                        End If
                        Dim k As Integer
                        Dim _sqlString As String
                        If (part_txt.Text = "„‰Õ… ⁄Ìœ «·›ÿ—") Then
                            xx = 2
                            _sqlString = "select  emp_no, emp_name,(tot_sum * " & xx & ") as mblg,(0) as hj,(1) as dmga,((tot_sum * " & xx & ")-1) as net from Badeel  where  site_id= '" & site_id & "'  and class_id='" & clas_id & "' and date_='" & date_.Text & "' and eyer='" & eyer_txt.Text & "' and stop_flag='" & 2 & "' and bdeel_flag='" & 0 & "' order by emp_no"
                        ElseIf (part_txt.Text = "„‰Õ… ⁄Ìœ «·«÷ÕÏ") Then
                            xx = 3
                            _sqlString = "select  emp_no, emp_name,(tot_sum * " & xx & ") as mblg,(0) as hj,(1) as dmga,((tot_sum * " & xx & ")-1) as net from Badeel  where  site_id= '" & site_id & "'  and class_id='" & clas_id & "' and date_='" & date_.Text & "' and eyer='" & eyer_txt.Text & "' and stop_flag='" & 2 & "' and bdeel_flag='" & 0 & "' order by emp_no"
                        Else
                            xx = 1
                            _sqlString = "select  emp_no, emp_name,(tot_sum * " & xx & ") as mblg,(est_hj * " & xx & ") as hj,(1) as dmga,((tot_sum * " & xx & ")-(est_hj *" & xx & ")-1) as net from Badeel  where  site_id= '" & site_id & "'  and class_id='" & clas_id & "' and date_='" & date_.Text & "' and eyer='" & eyer_txt.Text & "' and stop_flag='" & 2 & "' and bdeel_flag='" & 0 & "' order by emp_no"

                        End If
                        '======================================================
                        _DS.SQL = _sqlString
                        _rpt.DataSource = _DS
                    End If
                    '********
                Else
                '«·„ ⁄«ﬁœÌ‰ / «·ﬁ÷«… «·„ ⁄«ﬁœÌ‰ / ⁄„«· «·„ÿ»⁄…/„ ⁄«ﬁœÌ‰ «·Ê—‘Â
                _rpt = New bdeelrep  'bdeelrep2 '
                Dim x As String
                Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no ,employees.emp_name,classes.class_id,classes.class_name,sites.site_name from employees ,classes,sites where sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id and classes.class_name='" & class_txt.Text & "' and employees.bdeel_flag='" & 0 & "'", Con)
                Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
                Dim dt As New DataTable
                da.Fill(dt)
                If dt.Rows.Count < 1 Then
                    MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                    Exit Sub
                End If
                Dim clas_id = dt.Rows(0).Item("class_id")
                Dim site_id = dt.Rows(0).Item("site_id")
                Dim dmga As String = "œ„€…"
                Dim mgmd As String = "«·„Ã„œ"
                Dim egtmaya As String = "«Ã „«⁄Ì…"
                Dim Had_adna As String = "«·Õœ «·√œ‰Ï"
                Dim Alawa_khasa As String = "⁄·«Ê… Œ«’…"
                Dim Sh_amal_ga As String = "‘»Â ⁄„·"

                classname = ""
                If (part_txt.Text = "„‰Õ… ⁄Ìœ «·›ÿ—" Or part_txt.Text = "„‰Õ… ⁄Ìœ «·«÷ÕÏ") Then
                    classname = "(" + " ⁄»«—… ⁄‰   " + part_txt.Text + " " + "··⁄«„ «·„«·Ì" + Str(EYER) + "„ " + " " + "( " + dt.Rows(0).Item("class_name") + "/" + dt.Rows(0).Item("site_name")
                Else
                    classname = "(" + " ⁄»«—… ⁄‰ «·»œÌ· «·‰ﬁœÌ «·Ã“¡  " + part_txt.Text + " " + "··⁄«„ «·„«·Ì" + Str(EYER) + "„ " + " " + "( " + dt.Rows(0).Item("class_name") + "/" + dt.Rows(0).Item("site_name")
                End If
                Dim k As Integer
                'Dim id_em = dt.Rows(0).Item("emp_id")  employees.emp_no ,employees.emp_name,classes.class_name
                'Dim _sqlString As String = "select employees.emp_no,employees.emp_id,employees.emp_name,archief.not_conbdle_val mblg,archief.con_est_val dmga,(archief.not_conbdle_val-archief.con_est_val) net from employees,archief,classes where employees.bdeel_flag='" & 0 & "' and employees.emp_id=archief.emp_id and archief.class_id=classes.class_id and classes.class_id='" & clas_id & "' and archief.not_conbdel_name='" & mgmd & "' and archief.con_est_name='" & dmga & "' and archief.date_='" & date_.Text & "' order by employees.emp_no"
                Dim _sqlString As String
                If (part_txt.Text = "„‰Õ… ⁄Ìœ «·«÷ÕÏ" Or part_txt.Text = "„‰Õ… ⁄Ìœ «·›ÿ—") Then
                    _sqlString = "select employees.emp_no,employees.emp_id,employees.emp_name,archief.not_conbdle_val* " & xx & " mblg,1  dmga,((archief.not_conbdle_val* " & xx & ") -1) net from employees,archief,classes,sites where sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and employees.bdeel_flag='" & 0 & "' and employees.emp_id=archief.emp_id and archief.class_id=classes.class_id and classes.class_id='" & clas_id & "' and archief.not_conbdel_name='" & mgmd & "' and archief.date_='" & date_.Text & "' and eyer='" & EYER & "' order by employees.emp_no" 'and archief.con_est_name='" & dmga & "'
                Else
                    _sqlString = "select employees.emp_no,employees.emp_id,employees.emp_name,archief.not_conbdle_val* " & xx & " mblg,1  dmga,((archief.not_conbdle_val* " & xx & ") -1) net from employees,archief,classes,sites where sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and employees.bdeel_flag='" & 0 & "' and archief.con_bdl_name <> '" & Alawa_khasa & "' and archief.con_bdl_name <> '" & Sh_amal_ga & "' and archief.con_bdl_name <> '" & Had_adna & "' and employees.emp_id=archief.emp_id and archief.class_id=classes.class_id and classes.class_id='" & clas_id & "' and archief.not_conbdel_name='" & mgmd & "' and archief.date_='" & date_.Text & "' and eyer='" & EYER & "' order by employees.emp_no" 'and archief.con_est_name='" & dmga & "'
                End If
                _DS.SQL = _sqlString

                _rpt.DataSource = _DS
            End If ' If (class_txt.Text <> "«·„ ⁄«ﬁœÌ‰" And class_txt.Text <> "⁄„«· «·„ÿ»⁄…
            End If 'If 'If alngdy.Checked = True Then '«·»œÌ·
            '================


            '/////////////////////////list


            Me.Viewer1.Document = _rpt.Document
            _rpt.Run(False)
            Me.Cursor = _tmp

        Catch ex As DataDynamics.ActiveReports.ReportException
            MessageBox.Show(Me, "Error fired while running the report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mencard2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empname_txt.Enabled = False
        part_txt.Enabled = False

        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        '==============================
        Dim DS As New DataSet
        Dim t As DataTable
        Dim cmd2 As New SqlClient.SqlCommand("SELECT eyer FROM  eyers", Con)
        'Dim cmd2 As New SqlClient.SqlCommand("SELECT est_akry.ser_ak,sites.site_name,classes.class_name,employees.emp_no,employees.emp_name,est_akry.est_name,est_akry.est_ok_val,est_akry.month_co FROM  sites,classes,employees,est_akry ", Con)
        Dim dr44 As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        dr44.Read()
        If dr44.HasRows = False Then
            Con.Close()
            Exit Sub
        End If
        eyer_txt.Text = dr44.Item("eyer")
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
        '7777777777777777777777777777777777777777777777777777777777777777
        Dim DS022 As New DataSet
        Dim str022 As String = "SELECT DISTINCT  bank_name  FROM banks"
        Dim ADP022 As New SqlClient.SqlDataAdapter(str022, Con)
        ADP022.Fill(DS022)
        Dim k2 As Integer
        For k2 = 0 To DS022.Tables(0).Rows.Count - 1
            Me.banck.Items.Add(DS022.Tables(0).Rows(k2).Item(0))
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

    Private Sub class_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles class_txt.SelectedIndexChanged
        empname_txt.Text = ""
        empname_txt.Items.Clear()
        'Dim x As String
        'Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no,employees.emp_id,employees.emp_name,dgree_base.dgree_name,sites.site_name,classes.class_name,employees.sections from employees,dgree_base,sites,classes where (employees.site_id=sites.site_id and employees.class_id=classes.class_id and employees.dgree_id=dgree_base.dgree_id and employees.emp_name='" & emp_name_txt.Text & "' and classes.class_name='" & class_txt.Text & "') or  (employees.site_id=sites.site_id and employees.class_id=classes.class_id and employees.dgree_id=dgree_base.dgree_id and employees.emp_no='" & no_txt.Text & "' and classes.class_name='" & class_txt.Text & "')", Con)
        'Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        'Dim dt As New DataTable
        'da.Fill(dt)
        'and employees.emp_name='" & emp_name_txt.Text & "',dgree_base.dgree_name,sites.site_name,classes.class_name,employees.sectionsemployees.emp_no,employees.emp_id,
        Dim DS01 As New DataSet
        Dim str01 As String = "SELECT employees.emp_name from employees,dgree_base,sites,classes where employees.site_id=sites.site_id and employees.class_id=classes.class_id and employees.dgree_id=dgree_base.dgree_id     and sites.site_name='" & site_txt.Text & "'   and classes.class_name='" & class_txt.Text & "' and employees.stop_flag='" & 2 & "' "
        Dim ADP01 As New SqlClient.SqlDataAdapter(str01, Con)
        ADP01.Fill(DS01)
        Dim j As Integer

        If DS01.Tables(0).Rows.Count >= 1 Then
            For j = 0 To DS01.Tables(0).Rows.Count - 1
                Me.empname_txt.Items.Add(DS01.Tables(0).Rows(j).Item(0))
            Next
            ADP01.Dispose()
        End If
    End Sub
    Private Sub site_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles site_txt.SelectedIndexChanged

    End Sub
    Private Sub tfseely_Checked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        empname_txt.Enabled = False
    End Sub
    Private Sub tfseely_BindingContextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        empname_txt.Text = ""
        empname_txt.Enabled = False
        part_txt.Text = ""
        part_txt.Enabled = False
    End Sub
    Private Sub cert_mrtb_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cert_mrtb.CheckedChanged
        empname_txt.Text = ""
        empname_txt.Enabled = True
        part_txt.Text = ""
        part_txt.Enabled = False
    End Sub
    Private Sub egmaly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles egmaly.CheckedChanged
        empname_txt.Text = ""
        empname_txt.Enabled = False
        part_txt.Text = ""
        part_txt.Enabled = False
    End Sub
    Private Sub tfseely_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tfseely.CheckedChanged
        empname_txt.Text = ""
        empname_txt.Enabled = False
        part_txt.Text = ""
        part_txt.Enabled = False
    End Sub
    Private Sub tswiatejmaly_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tswiatejmaly.CheckedChanged
        empname_txt.Text = ""
        empname_txt.Enabled = False
        part_txt.Text = ""
        part_txt.Enabled = False
    End Sub
    Private Sub tswiat_tfseely_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tswiat_tfseely.CheckedChanged
        empname_txt.Text = ""
        empname_txt.Enabled = False
        part_txt.Text = ""
        part_txt.Enabled = False
    End Sub
    Private Sub alngdy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles alngdy.CheckedChanged
        empname_txt.Text = ""
        empname_txt.Enabled = False
        part_txt.Enabled = True
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub empname_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles empname_txt.SelectedIndexChanged

    End Sub

    Private Sub site_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles site_txt.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub date__SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles date_.SelectedIndexChanged

    End Sub

    Private Sub date__KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles date_.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub class_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles class_txt.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub empname_txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles empname_txt.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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
            Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no ,employees.emp_name,classes.class_name from employees ,classes,sites where sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id      and classes.class_name='" & class_txt.Text & "'", Con)
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Try
            'Dim ss As index22
            'ss.ShowDialog()
            'dim
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
            Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no ,employees.emp_name,classes.class_name from employees ,classesm,sites where sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'", Con)
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
            Dim _sqlString As String = "Select dgree_base.dgree_name,basic_salary_emp.basic_sal,employees.emp_name,employees.emp_no  "
            _sqlString = _sqlString + "FROM employees,classes,basic_salary_emp,dgree_base,sites"
            _sqlString = _sqlString + " WHERE sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and dgree_base.dgree_id=employees.dgree_id  and    employees.dgree_id=basic_salary_emp.degree_id and employees.sections=basic_salary_emp.section_count and employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "' order by employees.emp_name"
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Dim C = Format(Math.Abs(10000), "000000000000")
        'Dim C1 As String = Val(Mid(C, 7, 3))
        'MsgBox(C)
        'MsgBox(C1)
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub banck_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles banck.SelectedIndexChanged
        Dim cmd2 As New SqlClient.SqlCommand("SELECT bank_id from banks  where  bank_name='" & banck.Text & "' ", Con)
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count >= 1 Then
            bank_val = dt.Rows(0).Item("bank_id")
        End If

        empname_txt.Text = ""
        empname_txt.Items.Clear()
        'Dim x As String
        'Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no,employees.emp_id,employees.emp_name,dgree_base.dgree_name,sites.site_name,classes.class_name,employees.sections from employees,dgree_base,sites,classes where (employees.site_id=sites.site_id and employees.class_id=classes.class_id and employees.dgree_id=dgree_base.dgree_id and employees.emp_name='" & emp_name_txt.Text & "' and classes.class_name='" & class_txt.Text & "') or  (employees.site_id=sites.site_id and employees.class_id=classes.class_id and employees.dgree_id=dgree_base.dgree_id and employees.emp_no='" & no_txt.Text & "' and classes.class_name='" & class_txt.Text & "')", Con)
        'Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        'Dim dt As New DataTable
        'da.Fill(dt)
        'and employees.emp_name='" & emp_name_txt.Text & "',dgree_base.dgree_name,sites.site_name,classes.class_name,employees.sectionsemployees.emp_no,employees.emp_id,
        Dim DS01 As New DataSet
        Dim str01 As String = "SELECT employees.emp_name from employees,dgree_base,sites,classes where employees.site_id=sites.site_id and employees.class_id=classes.class_id and employees.dgree_id=dgree_base.dgree_id and employees.bank_id=" & bank_val & "  and sites.site_name='" & site_txt.Text & "'   and classes.class_name='" & class_txt.Text & "' and employees.stop_flag='" & 2 & "' "
        Dim ADP01 As New SqlClient.SqlDataAdapter(str01, Con)
        ADP01.Fill(DS01)
        Dim j As Integer

        If DS01.Tables(0).Rows.Count >= 1 Then
            For j = 0 To DS01.Tables(0).Rows.Count - 1
                Me.empname_txt.Items.Add(DS01.Tables(0).Rows(j).Item(0))
            Next
            ADP01.Dispose()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim SS As Integer
        Dim siteid, classid As Integer
        Dim T1, T2, T3, T4, T5, T6, T7 As Double
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        'ssssssssssssssssssssssssssssssssssssssssssssssssss
        Dim cmd51s As New SqlClient.SqlCommand("SELECT site_id FROM sites where site_name ='" & site_txt.Text & "'", Con)
        Dim dr51s As SqlClient.SqlDataReader = cmd51s.ExecuteReader()
        dr51s.Read()
        siteid = dr51s.Item("site_id")
        dr51s.Close()
        'ssssssssssssssssssssssssssssssssssssssssssssssssss
        Dim cmd51 As New SqlClient.SqlCommand("SELECT class_id FROM classes where class_name ='" & class_txt.Text & "'", Con)
        Dim dr51 As SqlClient.SqlDataReader = cmd51.ExecuteReader()
        dr51.Read()
        classid = dr51.Item("class_id")
        dr51.Close()
        'ssssssssssssssssssssssssssssssssssssssssssssssssss
        Dim Str0 As String = "»”„ «··Â «·—Õ„‰ «·—ÕÌ„"
        Dim Str1 As String = "—∆«”… «·ÃÂ«“ «·ﬁ÷«∆Ï Ê·«Ì… «·Ã“Ì—…"
        Dim Str2 As String = "≈œ«—… «·‘∆Ê‰ «·„«·Ì… Ê«·„Õ«”»Ì…"
        Dim Str3 As String = "ﬂ‘› «” Õﬁ«ﬁ " + " " + " " + date_.Text + "/" + eyer_txt.Text + "  " + " ’‰Ì›" + "/" + class_txt.Text
        classname = " ﬂ‘› «” Õﬁ«ﬁ  " + " " + site_txt.Text + " " + " ’‰Ì› " + " " + class_txt.Text + " " + "·‘Â—" + " " + date_.Text + " " + eyer_txt.Text

        Dim k As Integer
        datshake = DateTimePicker1.Text
        If alngdy.Checked = True Then
            If Trim(part_txt.Text) = "" Then
                MsgBox("Õœœ «·Ã“¡ ··»œÌ· „‰ «·ﬁ«∆„… ", MsgBoxStyle.Information + vbMsgBoxRight, "«·„Õﬂ„… «·⁄·Ì« œ«∆—… Ê·«Ì«  œ«—›Ê— «·ﬂ»—Ï... «·»œÌ· «·‰ﬁœÏ ")
                Exit Sub
            End If

            Dim _sqlString As String
            Dim xx As Integer
            If (part_txt.Text = "„‰Õ… ⁄Ìœ «·«÷ÕÏ") Then
                xx = 2
            Else
                xx = 1
            End If


            If (part_txt.Text = "„‰Õ… ⁄Ìœ «·›ÿ—" Or part_txt.Text = "„‰Õ… ⁄Ìœ «·«÷ÕÏ") Then
                Str3 = "„‰Õ… «·⁄Ìœ " + " " + " " + date_.Text + "/" + eyer_txt.Text + "  " + " ’‰Ì›" + "/" + class_txt.Text
                classname = " «·»œÌ· «·‰ﬁœÏ  " + " " + site_txt.Text + " " + " ’‰Ì› " + " " + class_txt.Text + " " + "·‘Â—" + " " + date_.Text + " " + eyer_txt.Text
                If (class_txt.Text = "«·‘—ÿ…" Or class_txt.Text = "÷»«ÿ" Or class_txt.Text = "÷»«ÿ «·’›" Or class_txt.Text = "«·Ã‰Êœ" Or class_txt.Text = "‘—ÿ… »‰Êﬂ" Or class_txt.Text = "‘—ÿ… Œ“Ì‰…") Then
                    SS = 0
                    _sqlString = "select  emp_name,acc_no,(tot_sum* " & xx & ")-1  as net from Badeel  where  site_id= '" & siteid & "'  and class_id='" & classid & "' and date_='" & date_.Text & "' and eyer='" & eyer_txt.Text & "' and bank_name = '" & banck.Text & "' and stop_flag='" & 2 & "' and bdeel_flag='" & 0 & "'  order by dgree_id"
                ElseIf (class_txt.Text = "ﬁ÷«… »‰Êﬂ" Or class_txt.Text = "ﬁ÷«… Œ“Ì‰…" Or class_txt.Text = "«·ﬁ÷«…") Then    'ﬁ÷«…
                    SS = 1
                    _sqlString = "select  emp_name,acc_no,(tot_sum* " & xx & ")-1  as net from Badeel  where  site_id= '" & siteid & "'  and class_id='" & classid & "' and date_='" & date_.Text & "' and eyer='" & eyer_txt.Text & "' and bank_name = '" & banck.Text & "' and stop_flag='" & 2 & "' and bdeel_flag='" & 0 & "'  order by dgree_id"
                Else
                    SS = 0
                    _sqlString = "select  emp_name,acc_no,((tot_sum* " & xx & ")-1)  as net from Badeel  where  site_id= '" & siteid & "'  and class_id='" & classid & "' and date_='" & date_.Text & "' and eyer='" & eyer_txt.Text & "' and bank_name = '" & banck.Text & "' and stop_flag='" & 2 & "' and bdeel_flag='" & 0 & "'  order by dgree_id"
                End If
            End If

            If (part_txt.Text <> "„‰Õ… ⁄Ìœ «·›ÿ—" And part_txt.Text <> "„‰Õ… ⁄Ìœ «·«÷ÕÏ") Then
                Str3 = " ⁄»«—… ⁄‰ «·»œÌ· «·‰ﬁœÌ «·Ã“¡ " + part_txt.Text + " " + " " + date_.Text + "/" + eyer_txt.Text + "  " + " ’‰Ì›" + "/" + class_txt.Text
                classname = " «·»œÌ· «·‰ﬁœÏ  " + " " + site_txt.Text + " " + " ’‰Ì› " + " " + class_txt.Text + " " + "·‘Â—" + " " + date_.Text + " " + eyer_txt.Text
                If (class_txt.Text = "«·‘—ÿ…" Or class_txt.Text = "÷»«ÿ" Or class_txt.Text = "÷»«ÿ «·’›" Or class_txt.Text = "«·Ã‰Êœ" Or class_txt.Text = "‘—ÿ… »‰Êﬂ" Or class_txt.Text = "‘—ÿ… Œ“Ì‰…") Then
                    SS = 0
                    _sqlString = "select  emp_name,(tot_sum * " & xx & ") as mblg,(est_hj *" & xx & ") as dar ,(1) as dmga,((est_hj *" & xx & ")+1)as tot,((tot_sum * " & xx & ")-(est_hj *" & xx & ")-1) as net from Badeel  where  site_id= '" & siteid & "'  and class_id='" & classid & "' and date_='" & date_.Text & "' and eyer='" & eyer_txt.Text & "'  and stop_flag='" & 2 & "' and bdeel_flag='" & 0 & "'  order by dgree_id"
                ElseIf (class_txt.Text = "ﬁ÷«… »‰Êﬂ" Or class_txt.Text = "ﬁ÷«… Œ“Ì‰…" Or class_txt.Text = "«·ﬁ÷«…") Then    'ﬁ÷«…
                    SS = 1
                    _sqlString = "select  emp_name,(tot_sum * " & xx & ") as mblg,(est_hj *" & xx & ") as dar ,(50) as zamala,(1) as dmga,((est_hj *" & xx & ")+51)as tot,((tot_sum * " & xx & ")-(est_hj *" & xx & ")-51) as net from Badeel  where  site_id= '" & siteid & "'  and class_id='" & classid & "' and date_='" & date_.Text & "' and eyer='" & eyer_txt.Text & "'  and stop_flag='" & 2 & "' and bdeel_flag='" & 0 & "'  order by dgree_id"
                Else
                    SS = 0
                    _sqlString = "select  emp_name,(tot_sum * " & xx & ") as mblg,(0) as dar ,(1) as dmga,(0)as tot,((tot_sum * " & xx & ")-1) as net from Badeel  where  site_id= '" & siteid & "'  and class_id='" & classid & "' and date_='" & date_.Text & "' and eyer='" & eyer_txt.Text & "'  and stop_flag='" & 2 & "' and bdeel_flag='" & 0 & "'  order by dgree_id"
                End If
            End If
            Dim ki As Integer
            Dim DS02 As New DataSet
            Dim ADP02 As New SqlClient.SqlDataAdapter(_sqlString, Con)
            ADP02.Fill(DS02)
            If (DS02.Tables(0).Rows.Count >= 1) Then
                Dim MsExcel = CreateObject("Excel.Application")
                Dim ExcelBook = MsExcel.Workbooks.Add
                If SS = 0 Then
                    Try
                        With MsExcel
                            .Cells(2, 1).Value = Str0
                            .Cells(4, 1).Value = Str1
                            .Cells(5, 1).Value = Str2
                            .Cells(6, 1).Value = Str3
                            .Cells(7, 1).Value = "«· «—ÌŒ" + " " + DateTimePicker1.Text
                            .Cells(8, 1).Value = classname
                            .Cells(10, 1).Value = "„"
                            .Cells(10, 2).Value = "«·«”‹‹‹‹‹‹‹„"
                            .Cells(10, 3).Value = "«·„»·€"
                            .Cells(10, 4).Value = "œ«—"
                            .Cells(10, 5).Value = "œ„€…"
                            .Cells(10, 6).Value = "«·Ã„·…"
                            .Cells(10, 7).Value = "«·’«›Ï"
                        End With

                        Dim Ser_no As Integer = 1
                        T1 = 0
                        For ki = 0 To DS02.Tables(0).Rows.Count - 1
                            MsExcel.Cells(ki + 11, 1).Value = Ser_no 'Ser_no „ ”·”·
                            MsExcel.Cells(ki + 11, 2).Value = DS02.Tables(0).Rows(ki).Item(0) 'emp_name «·«”„
                            MsExcel.Cells(ki + 11, 3).Value = DS02.Tables(0).Rows(ki).Item(1) 'tot_sum «·„»·€ 
                            MsExcel.Cells(ki + 11, 4).Value = DS02.Tables(0).Rows(ki).Item(2) '10 œ«—
                            MsExcel.Cells(ki + 11, 5).Value = DS02.Tables(0).Rows(ki).Item(3) '1 œ„€…
                            MsExcel.Cells(ki + 11, 6).Value = DS02.Tables(0).Rows(ki).Item(4) 'tot_sum+11 «·Ã„·…
                            MsExcel.Cells(ki + 11, 7).Value = DS02.Tables(0).Rows(ki).Item(5) 'tot_sum-11 «·’«›Ï

                            Ser_no = Ser_no + 1
                            T1 = T1 + DS02.Tables(0).Rows(ki).Item(1)
                            T2 = T2 + DS02.Tables(0).Rows(ki).Item(2)
                            T3 = T3 + DS02.Tables(0).Rows(ki).Item(3)
                            T4 = T4 + DS02.Tables(0).Rows(ki).Item(4)
                            T5 = T5 + DS02.Tables(0).Rows(ki).Item(5)
                        Next
                        With MsExcel
                            .Cells(ki + 11, 2).Value = "«·Ã„‹‹‹‹‹·… "
                            .Cells(ki + 11, 3).Value = T1
                            .Cells(ki + 11, 4).Value = T2
                            .Cells(ki + 11, 5).Value = T3
                            .Cells(ki + 11, 6).Value = T4
                            .Cells(ki + 11, 7).Value = T5

                        End With

                        MsExcel.Visible = True
                    Catch ex As Exception
                        ExcelBook.Close(False)
                        ExcelBook = Nothing
                        MsExcel.Quit()
                        MsExcel = Nothing
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
            If (DS02.Tables(0).Rows.Count >= 1) Then
                Dim MsExcel = CreateObject("Excel.Application")
                Dim ExcelBook = MsExcel.Workbooks.Add
                If SS = 1 Then
                    Try
                        With MsExcel
                            .Cells(2, 1).Value = Str0
                            .Cells(4, 1).Value = Str1
                            .Cells(5, 1).Value = Str2
                            .Cells(6, 1).Value = Str3
                            .Cells(7, 1).Value = "«· «—ÌŒ" + " " + DateTimePicker1.Text
                            .Cells(8, 1).Value = classname
                            .Cells(10, 1).Value = "„"
                            .Cells(10, 2).Value = "«·«”‹‹‹‹‹‹‹„"
                            .Cells(10, 3).Value = "«·„»·€"
                            .Cells(10, 4).Value = "ÕÃ"
                            .Cells(10, 5).Value = "“„«·…"
                            .Cells(10, 6).Value = "œ„€…"
                            .Cells(10, 7).Value = "«·Ã„·…"
                            .Cells(10, 8).Value = "«·’«›Ï"
                        End With

                        Dim Ser_no As Integer = 1
                        T1 = 0
                        For ki = 0 To DS02.Tables(0).Rows.Count - 1
                            MsExcel.Cells(ki + 11, 1).Value = Ser_no 'Ser_no „ ”·”·
                            MsExcel.Cells(ki + 11, 2).Value = DS02.Tables(0).Rows(ki).Item(0) 'emp_name «·«”„
                            MsExcel.Cells(ki + 11, 3).Value = DS02.Tables(0).Rows(ki).Item(1) 'tot_sum «·„»·€ 
                            MsExcel.Cells(ki + 11, 4).Value = DS02.Tables(0).Rows(ki).Item(2) '10 œ«—
                            MsExcel.Cells(ki + 11, 5).Value = DS02.Tables(0).Rows(ki).Item(3) '10 œ«—
                            MsExcel.Cells(ki + 11, 6).Value = DS02.Tables(0).Rows(ki).Item(4) '1 œ„€…
                            MsExcel.Cells(ki + 11, 7).Value = DS02.Tables(0).Rows(ki).Item(5) 'tot_sum+11 «·Ã„·…
                            MsExcel.Cells(ki + 11, 8).Value = DS02.Tables(0).Rows(ki).Item(6) 'tot_sum-11 «·’«›Ï

                            Ser_no = Ser_no + 1
                            T1 = T1 + DS02.Tables(0).Rows(ki).Item(1)
                            T2 = T2 + DS02.Tables(0).Rows(ki).Item(2)
                            T3 = T3 + DS02.Tables(0).Rows(ki).Item(3)
                            T4 = T4 + DS02.Tables(0).Rows(ki).Item(4)
                            T5 = T5 + DS02.Tables(0).Rows(ki).Item(5)
                            T6 = T6 + DS02.Tables(0).Rows(ki).Item(6)

                        Next
                        With MsExcel
                            .Cells(ki + 11, 2).Value = "«·Ã„‹‹‹‹‹·… "
                            .Cells(ki + 11, 3).Value = T1
                            .Cells(ki + 11, 4).Value = T2
                            .Cells(ki + 11, 5).Value = T3
                            .Cells(ki + 11, 6).Value = T4
                            .Cells(ki + 11, 7).Value = T5
                            .Cells(ki + 11, 8).Value = T6

                        End With

                        MsExcel.Visible = True
                    Catch ex As Exception
                        ExcelBook.Close(False)
                        ExcelBook = Nothing
                        MsExcel.Quit()
                        MsExcel = Nothing
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
        If RadioButton2.Checked = True Then
            Str0 = "»”„ «··Â «·—Õ„‰ «·—ÕÌ„"
            Str1 = "—∆«”… «·ÃÂ«“ «·ﬁ÷«∆Ï Ê·«Ì… «·Ã“Ì—…"
            Str2 = "≈œ«—… «·‘∆Ê‰ «·„«·Ì… Ê«·„Õ«”»Ì…"
            Str3 = "ﬂ‘›" + " " + " " + date_.Text + "/" + eyer_txt.Text + "  " + " ’‰Ì›" + "/" + class_txt.Text
            classname = " ﬂ‘› " + " " + site_txt.Text + " " + " ’‰Ì› " + " " + class_txt.Text + " " + "·‘Â—" + " " + date_.Text + " " + eyer_txt.Text
            '--------------------------------------------------------------------------------------------
            Dim ord_by As String
            Select Case ComboBox1.SelectedIndex
                Case 0
                    ord_by = "employees.emp_no"
                Case 1
                    ord_by = "employees.emp_name"
                Case 2
                    ord_by = "dgree_base.dgree_id"
                Case Else
                    ord_by = "employees.emp_name"
            End Select
            '_rpt = New listrep
            Dim x As String
            Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no ,employees.emp_name,classes.class_name,sites.site_name from employees ,classes ,sites where  sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'", Con)
            Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count < 1 Then
                MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
                Exit Sub
            End If
            classname = ""
            classname = " ›Â—”  " + dt.Rows(0).Item("class_name") + " / " + dt.Rows(0).Item("site_name")
            'Dim k As Integer
            Dim _sqlString As String = "Select employees.emp_no,employees.emp_name,dgree_base.dgree_name,basic_salary_emp.basic_sal  FROM employees,classes,basic_salary_emp,dgree_base,sites"
            _sqlString = _sqlString + " WHERE sites.site_id=employees.site_id and sites.site_name='" & site_txt.Text & "' and dgree_base.dgree_id=employees.dgree_id  and    employees.dgree_id=basic_salary_emp.degree_id and employees.sections=basic_salary_emp.section_count and employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "' order by  " + ord_by + " "
            '_DS.SQL = _sqlString
            '_rpt.DataSource = _DS
            Dim ki As Integer
            Dim DS02 As New DataSet
            Dim ADP02 As New SqlClient.SqlDataAdapter(_sqlString, Con)
            ADP02.Fill(DS02)
            If (DS02.Tables(0).Rows.Count >= 1) Then
                Dim MsExcel = CreateObject("Excel.Application")
                Dim ExcelBook = MsExcel.Workbooks.Add
                Try
                    With MsExcel
                        .Cells(2, 1).Value = Str0
                        .Cells(4, 1).Value = Str1
                        .Cells(5, 1).Value = Str2
                        .Cells(6, 1).Value = Str3
                        .Cells(7, 1).Value = "«· «—ÌŒ" + " " + DateTimePicker1.Text
                        .Cells(8, 1).Value = classname
                        .Cells(10, 1).Value = "«·—ﬁ„"
                        .Cells(10, 2).Value = "«·«”‹‹‹‹‹‹‹„"
                        .Cells(10, 3).Value = " «·œ—Ã…"
                        .Cells(10, 4).Value = "«·—« » «·«”«”Ï"
                    End With

                    Dim Ser_no As Integer = 1
                    T1 = 0
                    For ki = 0 To DS02.Tables(0).Rows.Count - 1
                        MsExcel.Cells(ki + 11, 1).Value = DS02.Tables(0).Rows(ki).Item(0)
                        MsExcel.Cells(ki + 11, 2).Value = DS02.Tables(0).Rows(ki).Item(1)
                        MsExcel.Cells(ki + 11, 3).Value = DS02.Tables(0).Rows(ki).Item(2)
                        MsExcel.Cells(ki + 11, 4).Value = DS02.Tables(0).Rows(ki).Item(3)
                    Next

                    MsExcel.Visible = True
                Catch ex As Exception
                    ExcelBook.Close(False)
                    ExcelBook = Nothing
                    MsExcel.Quit()
                    MsExcel = Nothing
                    MsgBox(ex.Message)
                End Try
            End If

        End If
    End Sub
End Class
