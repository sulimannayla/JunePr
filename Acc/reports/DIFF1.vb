Public Class diffrep
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
    Friend WithEvents empname_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents tswiat_tfseely As System.Windows.Forms.RadioButton
    Friend WithEvents tswiatejmaly As System.Windows.Forms.RadioButton
    Friend WithEvents alngdy As System.Windows.Forms.RadioButton
    Friend WithEvents cert_mrtb As System.Windows.Forms.RadioButton
    Friend WithEvents egmaly As System.Windows.Forms.RadioButton
    Friend WithEvents tfseely As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents part_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
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
        Me.empname_txt = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.eyer_txt1 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.part_txt = New System.Windows.Forms.ComboBox
        Me.egmaly = New System.Windows.Forms.RadioButton
        Me.date_1 = New System.Windows.Forms.ComboBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.date_2 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.eyer_txt2 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tswiat_tfseely = New System.Windows.Forms.RadioButton
        Me.tswiatejmaly = New System.Windows.Forms.RadioButton
        Me.alngdy = New System.Windows.Forms.RadioButton
        Me.cert_mrtb = New System.Windows.Forms.RadioButton
        Me.tfseely = New System.Windows.Forms.RadioButton
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
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
        'empname_txt
        '
        Me.empname_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.empname_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.empname_txt.Location = New System.Drawing.Point(80, 48)
        Me.empname_txt.Name = "empname_txt"
        Me.empname_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.empname_txt.Size = New System.Drawing.Size(65, 21)
        Me.empname_txt.TabIndex = 9
        Me.empname_txt.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 24)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "«·«”„"
        Me.Label4.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.eyer_txt1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.part_txt)
        Me.GroupBox1.Controls.Add(Me.egmaly)
        Me.GroupBox1.Controls.Add(Me.date_1)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.empname_txt)
        Me.GroupBox1.Controls.Add(Me.class_txt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.site_txt)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.tswiat_tfseely)
        Me.GroupBox1.Controls.Add(Me.tswiatejmaly)
        Me.GroupBox1.Controls.Add(Me.alngdy)
        Me.GroupBox1.Controls.Add(Me.cert_mrtb)
        Me.GroupBox1.Controls.Add(Me.tfseely)
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(936, 160)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(16, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 24)
        Me.Button4.TabIndex = 147
        Me.Button4.Text = "«·›Â‹‹—”"
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.Location = New System.Drawing.Point(16, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 24)
        Me.Button3.TabIndex = 146
        Me.Button3.Text = "«·›Â‹‹—”"
        Me.Button3.Visible = False
        '
        'eyer_txt1
        '
        Me.eyer_txt1.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.eyer_txt1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.eyer_txt1.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035"})
        Me.eyer_txt1.Location = New System.Drawing.Point(552, 78)
        Me.eyer_txt1.Name = "eyer_txt1"
        Me.eyer_txt1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.eyer_txt1.Size = New System.Drawing.Size(84, 21)
        Me.eyer_txt1.TabIndex = 145
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(114, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "«·Ã“¡"
        Me.Label3.Visible = False
        '
        'part_txt
        '
        Me.part_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.part_txt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.part_txt.Items.AddRange(New Object() {"«·√Ê·", "«·À«‰Ì", "«·À«·À", "«·—«»⁄", "«·Œ«„”", "«·”«œ”", "„‰Õ… ⁄Ìœ «·›ÿ—", "„‰Õ… ⁄Ìœ «·«÷ÕÏ"})
        Me.part_txt.Location = New System.Drawing.Point(16, 66)
        Me.part_txt.Name = "part_txt"
        Me.part_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.part_txt.Size = New System.Drawing.Size(96, 21)
        Me.part_txt.TabIndex = 10
        Me.part_txt.Visible = False
        '
        'egmaly
        '
        Me.egmaly.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.egmaly.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.egmaly.Location = New System.Drawing.Point(24, 24)
        Me.egmaly.Name = "egmaly"
        Me.egmaly.Size = New System.Drawing.Size(96, 24)
        Me.egmaly.TabIndex = 0
        Me.egmaly.Text = " ﬁ—Ì— ≈Ã„«·Ì"
        Me.egmaly.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.egmaly.Visible = False
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
        Me.RadioButton1.Size = New System.Drawing.Size(96, 43)
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
        Me.Label7.Text = "«·‘Â— «·«Ê·"
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
        Me.eyer_txt2.Items.AddRange(New Object() {"2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035"})
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
        'tswiat_tfseely
        '
        Me.tswiat_tfseely.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.tswiat_tfseely.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.tswiat_tfseely.Location = New System.Drawing.Point(8, 40)
        Me.tswiat_tfseely.Name = "tswiat_tfseely"
        Me.tswiat_tfseely.Size = New System.Drawing.Size(112, 24)
        Me.tswiat_tfseely.TabIndex = 3
        Me.tswiat_tfseely.Text = " ”ÊÌ«   ›’Ì·Ì"
        Me.tswiat_tfseely.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tswiat_tfseely.Visible = False
        '
        'tswiatejmaly
        '
        Me.tswiatejmaly.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.tswiatejmaly.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.tswiatejmaly.Location = New System.Drawing.Point(40, 24)
        Me.tswiatejmaly.Name = "tswiatejmaly"
        Me.tswiatejmaly.TabIndex = 2
        Me.tswiatejmaly.Text = " ”ÊÌ«  ≈Ã„«·Ì"
        Me.tswiatejmaly.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tswiatejmaly.Visible = False
        '
        'alngdy
        '
        Me.alngdy.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.alngdy.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.alngdy.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.alngdy.Location = New System.Drawing.Point(28, 28)
        Me.alngdy.Name = "alngdy"
        Me.alngdy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.alngdy.Size = New System.Drawing.Size(88, 24)
        Me.alngdy.TabIndex = 6
        Me.alngdy.Text = "«·»œÌ· «·‰ﬁœÌ"
        Me.alngdy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.alngdy.Visible = False
        '
        'cert_mrtb
        '
        Me.cert_mrtb.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.cert_mrtb.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cert_mrtb.Location = New System.Drawing.Point(16, 32)
        Me.cert_mrtb.Name = "cert_mrtb"
        Me.cert_mrtb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cert_mrtb.Size = New System.Drawing.Size(90, 24)
        Me.cert_mrtb.TabIndex = 4
        Me.cert_mrtb.Text = "‘Â«œ… „— »"
        Me.cert_mrtb.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.cert_mrtb.Visible = False
        '
        'tfseely
        '
        Me.tfseely.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.tfseely.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.tfseely.Location = New System.Drawing.Point(24, 48)
        Me.tfseely.Name = "tfseely"
        Me.tfseely.Size = New System.Drawing.Size(96, 27)
        Me.tfseely.TabIndex = 1
        Me.tfseely.Text = " ﬁ—Ì—  ›’Ì·Ï"
        Me.tfseely.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.tfseely.Visible = False
        '
        'RadioButton7
        '
        Me.RadioButton7.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RadioButton7.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.RadioButton7.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.RadioButton7.Location = New System.Drawing.Point(40, 32)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton7.Size = New System.Drawing.Size(49, 24)
        Me.RadioButton7.TabIndex = 5
        Me.RadioButton7.Text = "ﬁ«∆„…"
        Me.RadioButton7.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 112)
        Me.GroupBox3.TabIndex = 144
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
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

        Dim i, k As Integer
        Dim df As New SECURITY
        ' Dim _tmp As Cursor
        ' _tmp = Me.Cursor
        ' Me.Cursor = Cursors.WaitCursor
        ' Dim _rpt = New ActiveReport3

        ' Dim _DS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource
        ' _DS.ConnectionString = "User ID= '" & df.UserID.Text & "';" & _
        ' "Password='" & df.Password.Text & "';" & _
        ' "Initial Catalog=accoun;" & _
        '"Data Source=main2;" & _
        ' "Connection TimeOut=30;"
        '==================================================list
        ' ''
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        '-----------------------------------------------------------
        Dim DS_archief As New DataSet
        Dim str_archief = "select * from archief,classes where  archief.date_='" & date_1.Text & "' and  archief.class_id=classes.class_id and classes.class_name='" & class_txt.Text & "' and archief.eyer='" & eyer_txt1.Text & "'"
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
        Dim str_archief2 = "select * from archief,classes where  archief.date_='" & date_2.Text & "' and  archief.class_id=classes.class_id and classes.class_name='" & class_txt.Text & "' and archief.eyer='" & eyer_txt2.Text & "'"
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
        Dim str1 As String = "SELECT  emp_id,employees.class_id   FROM  classes,employees where employees.class_id=classes.class_id   and classes.class_name='" & class_txt.Text & "'"
        Dim ADP1 As New SqlClient.SqlDataAdapter(str1, Con)
        ADP1.Fill(DS1)

        class_id = DS1.Tables(0).Rows(0).Item(1)

        'For i = 0 To DS1.Tables(0).Rows.Count - 1
        For i = 0 To DS1.Tables(0).Rows.Count - 1
            '    '---------Õ”«» «·›—ﬁ ›Ï «·„— »
            Dim emp_id_ = DS1.Tables(0).Rows(i).Item(0)


            'Dim emp_id As Integer
            Dim DS As New DataSet
            Dim DST As New DataSet
            'MsgBox("node1")
            '-----------------------------«·‘Â— «·«Ê·
            Dim str As String = "SELECT  sum(alsafy) as  alsafy,archief.emp_id,employees.emp_name,archief.stop_flag  FROM  archief,employees  where archief.emp_id='" & emp_id_ & "' and archief.emp_id=employees.emp_id and   archief.class_id='" & class_id & "' and  date_ ='" & date_1.Text & "' and     eyer='" & eyer_txt1.Text & "' group by archief.emp_id,employees.emp_name,archief.stop_flag"
            'Dim str As String = "SELECT sum(alsafy)as  alsafy,archief.emp_id   FROM   archief,employees  where   archief.emp_id='" & 348 & "' and   archief.emp_id=employees.emp_id and archief.class_id='" & class_id & "' and  archief.eyer in('" & eyer_txt1.Text & "','" & eyer_txt2.Text & "') and  date_  in('" & date_1.Text & "','" & date_2.Text & "') group by archief.date_,archief.emp_id  order by archief.emp_id "

            Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
            ADP.Fill(DS)
            If DS.Tables(0).Rows.Count < 1 Then
                safy1 = 0
            Else
                safy1 = DS.Tables(0).Rows(0).Item(0)
            End If

            'MsgBox(safy1)
            'safy1 = DS.Tables(0).Rows(0).Item(0)

            '-----------------‰Â«Ì…---«·‘Â— «·«Ê·---------
            Dim strT As String = "SELECT   sum(alsafy) as  alsafy,archief.emp_id,employees.emp_name,archief.stop_flag  FROM  archief,employees  where archief.emp_id='" & emp_id_ & "' and archief.emp_id=employees.emp_id and   archief.class_id= '" & class_id & "'   and  eyer='" & eyer_txt2.Text & "' and  date_ = '" & date_2.Text & "' group by archief.emp_id,employees.emp_name,archief.stop_flag"
            'Dim str As String = "SELECT sum(alsafy)as  alsafy,archief.emp_id   FROM   archief,employees  where   archief.emp_id='" & 348 & "' and   archief.emp_id=employees.emp_id and archief.class_id='" & class_id & "' and  archief.eyer in('" & eyer_txt1.Text & "','" & eyer_txt2.Text & "') and  date_  in('" & date_1.Text & "','" & date_2.Text & "') group by archief.date_,archief.emp_id  order by archief.emp_id "

            Dim ADPT As New SqlClient.SqlDataAdapter(strT, Con)
            ADPT.Fill(DST)
            If DST.Tables(0).Rows.Count < 1 Then
                safy2 = 0
            Else
                safy2 = DST.Tables(0).Rows(0).Item(0)
            End If
            'MsgBox(safy2)
            RESLT = safy1 - safy2
            If safy1 <> safy2 Then


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

                'safy2 = DS.Tables(0).Rows(1).Item(0)
                'safy2 = safy1 - DS.Tables(0).Rows(1).Item(0)



                ' '---------Õ”«» «·›—ﬁ ›Ï «·„— »
                ' '---------    ' '---------Õ›Ÿ «·»Ì«‰

                'If (DS.Tables(0).Rows.Count >= 1) Then '»œ«Ì… „ﬁ«—‰… »Ì‰ ‘Â—Ì‰ ·€Ì— «·„ÊﬁÊ›Ì‰
                Dim DSm As New DataSet
                Dim strm As String = "select distinct  name_aa from  aa('" & emp_id_ & "','" & eyer_txt1.Text & "','" & date_1.Text & "'),bb('" & emp_id_ & "','" & eyer_txt2.Text & "','" & date_2.Text & "') where name_aa not in(select name_bb from bb('" & emp_id_ & "','" & eyer_txt2.Text & "','" & date_2.Text & "')) union  select distinct  name_bb from aa('" & emp_id_ & "','" & eyer_txt1.Text & "','" & date_1.Text & "'),bb('" & emp_id_ & "','" & eyer_txt2.Text & "','" & date_2.Text & "') where  name_bb not in(select name_aa from aa('" & emp_id_ & "' ,'" & eyer_txt1.Text & "','" & date_1.Text & "')) union select  name_aa  from  aa('" & emp_id_ & "','" & eyer_txt1.Text & "','" & date_1.Text & "'),bb('" & emp_id_ & "','" & eyer_txt2.Text & "','" & date_2.Text & "') where val_aa<>val_bb and name_aa =name_bb "
                'Dim strm As String = "select distinct  name_aa from aa(1014,2008,'œÌ”„»—'),bb(1014,2009,'Ì‰«Ì—') where name_aa not in(select name_bb from bb(1014,2009,'Ì‰«Ì—')) union select distinct  name_bb from aa(1014,2008,'œÌ”„»—'),bb(1014,2009,'Ì‰«Ì—') where  name_bb not in(select name_aa from aa(1014,2008,'œÌ”„»—')) union select  name_aa  from  aa(1014,2008,'œÌ”„»—'),bb(1014,2009,'Ì‰«Ì—') where val_aa<>val_bb and name_aa =name_bb"
                Dim ADPm As New SqlClient.SqlDataAdapter(strm, Con)
                ADPm.Fill(DSm)
                'End If '‰Â«Ì… „ﬁ«—‰… »Ì‰ ‘Â—Ì‰ ·€Ì— «·„ÊﬁÊ›Ì‰

                '--------------------------------------------------------------

                name_ = ""

                If (DSm.Tables(0).Rows.Count >= 1) Then '«–«  „  «·„ﬁ«—‰… ÊÊÃœ ”Ã·« 
                    For k = 0 To DSm.Tables(0).Rows.Count - 1
                        'MsgBox(DSm.Tables(0).Rows(k).Item(0))
                        name_ = name_ + "," + DSm.Tables(0).Rows(k).Item(0)
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
                        'MsgBox("«Ìﬁ«› „— » ›Ï ‘Â—")
                        'name_ = " «Ìﬁ«› „— » ›Ï ‘Â— "
                        'name_ = name_ + date_1.Text
                        sabg = 0
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
                '------------------------------------------------------------------------------------------------------      
                'MsgBox("node5")
                ' '---------Õ›Ÿ «·»Ì«‰
                'Õ›Ÿ «·’«›Ï Ê«·»Ì«‰ ›Ï ÃœÊ· ··›—œ
                'MsgBox("2")
                'MsgBox("last")
                Dim cmdString As String = "INSERT INTO mwzna " + _
                                           "(emp_id,name_,zida,ngsan,safy_befor,safy_haly,class_id) " + _
                                           "VALUES('" & emp_id_ & "','" & name_ & "','" & ZIDA & "','" & NGSAN & "','" & sabg & "','" & haly & "','" & class_id & "')"
                Dim cmd As New SqlClient.SqlCommand(cmdString, Con)

                cmd.ExecuteNonQuery()

            End If 'if safy1<>sfy2         'Õ›Ÿ «·’«›Ï Ê«·»Ì«‰ ›Ï ÃœÊ· ··›—œ
        Next
        MsgBox("end")
        ' '777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777newwwwwwwwwwwwwwwwww

        '    If RadioButton7.Checked = True Then 'list
        '        _rpt = New listrep
        '        Dim x As String
        '        Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no ,employees.emp_name,classes.class_name from employees ,classes where  employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'", Con)
        '        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        '        Dim dt As New DataTable
        '        da.Fill(dt)
        '        If dt.Rows.Count < 1 Then
        '            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
        '            Exit Sub
        '        End If
        '        classname = ""
        '        classname = " ﬂ‘› »«”„«¡ " + dt.Rows(0).Item("class_name")
        '        Dim k As Integer
        '        'Dim id_em = dt.Rows(0).Item("emp_id")  employees.emp_no ,employees.emp_name,classes.class_name
        '        Dim _sqlString As String = "Select *"
        '        _sqlString = _sqlString + "FROM employees,classes"
        '        _sqlString = _sqlString + " WHERE  employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "' order by employees.emp_name"
        '        _DS.SQL = _sqlString
        '        _rpt.DataSource = _DS
        '    End If
        '    '=====================================================================
        '    If tfseely.Checked = True Then
        '        MsgBox(" ›’Ì·Ï")
        '        Dim x As String
        '        Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_id,classes.class_name ,classes.class_id from employees ,sites,classes where  employees.stop_flag='" & 2 & "' and employees.site_id=sites.site_id and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'", Con)
        '        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        '        Dim dt As New DataTable
        '        da.Fill(dt)
        '        If dt.Rows.Count < 1 Then
        '            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
        '            Exit Sub
        '        End If
        '        Dim class_i_d = dt.Rows(0).Item("class_id")
        '        Dim k As Integer
        '        'Dim id_em = dt.Rows(0).Item("emp_id")

        '        classname = " ﬂ‘› „— »«  " + dt.Rows(0).Item("class_name")
        '        '"ﬂ‘› „— »«  " + "" + classname
        '        Dim _sqlString As String = "Select archief.emp_no, archief.con_bdl_name,archief.con_bdl_val, archief.not_conbdel_name,archief.not_conbdle_val,archief.basic_sal,employees.emp_name,archief.date_ ,archief.con_est_name ,archief.con_est_val,archief.est_ok_name ,archief.est_ok_val ,archief.est_sum ,archief.bdl_sum ,archief.alsafy ,archief.dgree_name ,archief.stop_flag,archief.eyer "
        '        _sqlString = _sqlString + "FROM  archief,employees"
        '        _sqlString = _sqlString + " WHERE    employees.emp_id=archief.emp_id and archief.eyer ='" & eyer_txt.Text & "' and archief.date_ ='" & date_.Text & "'  and archief.class_id='" & class_i_d & "' ORDER BY archief.emp_no,archief.con_bdl_name"  'archief.emp_id---archief.emp_no= employees.emp_no and
        '        _DS.SQL = _sqlString
        '        _rpt.DataSource = _DS
        '    End If

        '    '///////////////////////////////////////////////////////////////////////‘Â«œ… „— »
        '    If cert_mrtb.Checked = True Then
        '        MsgBox("„— »")
        '        If empname_txt.Text = "" Then
        '            MsgBox("«Œ — «”„ «·„ÊŸ›")
        '        End If
        '        _rpt = New salary_cert1  'salary_cert
        '        Dim x As String
        '        Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_id ,classes.class_id,classes.class_name from employees ,sites,classes where   employees.stop_flag='" & 2 & "' and employees.site_id=sites.site_id and employees.class_id=classes.class_id and classes.class_name='" & class_txt.Text & "' and employees.emp_name='" & empname_txt.Text & "'", Con)
        '        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        '        Dim dt As New DataTable
        '        da.Fill(dt)
        '        If dt.Rows.Count < 1 Then
        '            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
        '            Exit Sub
        '        End If
        '        Dim class_i_d = dt.Rows(0).Item("class_id")

        '        classname = dt.Rows(0).Item("class_name") + "  ‘Â«œ… „— »  "
        '        Dim k As Integer
        '        Dim id_em = dt.Rows(0).Item("emp_id")
        '        Dim _sqlString As String = "Select * "
        '        _sqlString = _sqlString + "FROM archief,employees"
        '        _sqlString = _sqlString + " WHERE  archief.eyer ='" & eyer_txt.Text & "' and archief.date_ ='" & date_.Text & "' and employees.emp_id=archief.emp_id and archief.class_id='" & class_i_d & "' and archief.emp_id='" & id_em & "'"
        '        _DS.SQL = _sqlString
        '        _rpt.DataSource = _DS
        '        empname_txt.Enabled = False
        '    End If

        '    If egmaly.Checked = True Then '«Ã„«·Ï
        '        MsgBox("«Ã„«·Ï")
        '        _rpt = New totalsal
        '        Dim x As String
        '        Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_id,classes.class_name ,classes.class_id from employees ,sites,classes where   employees.stop_flag='" & 2 & "' and employees.site_id=sites.site_id and employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'", Con)
        '        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        '        Dim dt As New DataTable
        '        da.Fill(dt)
        '        If dt.Rows.Count < 1 Then
        '            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
        '            Exit Sub
        '        End If
        '        Dim class_i_d = dt.Rows(0).Item("class_id")
        '        Dim k As Integer
        '        Dim id_em = dt.Rows(0).Item("emp_id")

        '        classname = " ﬂ‘› ≈Ã„«·Ì „— »«  " + dt.Rows(0).Item("class_name")
        '        '"ﬂ‘› „— »«  " + "" + classname
        '        Dim mo As String = "Ì‰«Ì—"
        '        Dim _sqlString As String = "Select * "
        '        _sqlString = _sqlString + "FROM total"
        '        _sqlString = _sqlString + " WHERE  eyer='" & eyer_txt.Text & "' and total.date_ ='" & date_.Text & "'  and total.class_id='" & class_i_d & "'"
        '        _DS.SQL = _sqlString
        '        _rpt.DataSource = _DS



        '    End If
        '    '================«·»œÌ·
        '    'select sum(y.bdl) from ((select con_bdl_val as bdl from archief where emp_id=16) union (select not_conbdle_val as bdl from archief where emp_id=16 and not_conbdel_name='«Ã „«⁄Ì…' )) y
        '    '..
        '    If alngdy.Checked = True Then '«·»œÌ·
        '        Dim xx As Integer
        '        If (part_txt.Text = "„‰Õ… ⁄Ìœ «·«÷ÕÏ") Then
        '            xx = 2
        '        Else
        '            xx = 1
        '        End If
        '        If (class_txt.Text <> "«·„ ⁄«ﬁœÌ‰" And class_txt.Text <> "⁄„«· «·„ÿ»⁄…" And class_txt.Text <> "«·ﬁ÷«… «·„ ⁄«ﬁœÌ‰") Then
        '            '*********

        '            If (class_txt.Text = "÷»«ÿ" Or class_txt.Text = "÷»«ÿ «·’›" Or class_txt.Text = "«·Ã‰Êœ" Or class_txt.Text = "«·ﬁ÷«…") Then '«·ﬁ÷«… Ê«·‘—ÿ…
        '                _rpt = New bdeelrep2  'bdeelrep '
        '                Dim x As String
        '                Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no ,employees.emp_name,classes.class_id,classes.class_name from employees ,classes where employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id and classes.class_name='" & class_txt.Text & "' and employees.bdeel_flag='" & 0 & "' ", Con)
        '                Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        '                Dim dt As New DataTable
        '                da.Fill(dt)
        '                If dt.Rows.Count < 1 Then
        '                    MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
        '                    Exit Sub
        '                End If
        '                Dim clas_id = dt.Rows(0).Item("class_id")
        '                Dim dmga As String = "œ„€…"
        '                Dim egtmaya As String = "«Ã „«⁄Ì…"
        '                classname = ""
        '                If (part_txt.Text = "„‰Õ… ⁄Ìœ «·›ÿ—" Or part_txt.Text = "„‰Õ… ⁄Ìœ «·«÷ÕÏ") Then
        '                    classname = "(" + " ⁄»«—… ⁄‰   " + part_txt.Text + " " + "··⁄«„ «·„«·Ì" + str(EYER) + "„ " + " " + "( " + dt.Rows(0).Item("class_name")
        '                Else
        '                    classname = "(" + " ⁄»«—… ⁄‰ «·»œÌ· «·‰ﬁœÌ «·Ã“¡  " + part_txt.Text + " " + "··⁄«„ «·„«·Ì" + str(EYER) + "„ " + " " + "( " + dt.Rows(0).Item("class_name")
        '                End If

        '                Dim k As Integer
        '                Dim _sqlString As String
        '                If (class_txt.Text = "÷»«ÿ" Or class_txt.Text = "÷»«ÿ «·’›" Or class_txt.Text = "«·Ã‰Êœ") Then
        '                    'Dim id_em = dt.Rows(0).Item("emp_id")  employees.emp_no ,employees.emp_name,classes.class_name
        '                    ' _sqlString = "select x.emp_id,em.emp_no,em.emp_name,x.mblg ,ar.con_est_val dmga,(x.mblg-(ar.con_est_val)) net from employees em,(select sum(y.bdl) as mblg,y.emp_id from ((select emp_id,con_bdl_val as bdl from archief where  class_id='" & clas_id & "' and date_='" & date_.Text & "') union (select emp_id,not_conbdle_val as bdl from archief where  not_conbdel_name='" & egtmaya & "' and class_id='" & clas_id & "' and date_='" & date_.Text & "')) y group by y.emp_id) x,archief ar where em.bdeel_flag='" & 0 & "' and em.emp_id=ar.emp_id and ar.con_est_name='" & dmga & "' and ar.emp_id=x.emp_id and ar.date_='" & date_.Text & "' order by em.emp_no"
        '                    '''last'' _sqlString = "select employees.emp_id,employees.emp_no,employees.emp_name,(not_conbdel.blance+b_s.sum+basic_salary_emp.basic_sal)* " & xx & " mblg,0.5 dmga ,((not_conbdel.blance+b_s.sum+basic_salary_emp.basic_sal)-0.5)* " & xx & "  net from employees,basic_salary_emp,not_conbdel,base_bdl,(select sum(con_bdal.bdl_val) sum,con_bdal.degree_id d,con_bdal.class_id c from con_bdal where con_bdal.class_id='" & clas_id & "' group by con_bdal.degree_id,con_bdal.class_id)b_s where employees.class_id=b_s.c and employees.dgree_id=b_s.d and employees.emp_id=not_conbdel.emp_id and employees.class_id=not_conbdel.class_id and b_s.c=not_conbdel.class_id and not_conbdel.bdl_id=base_bdl.id and base_bdl.name='" & egtmaya & "' and employees.dgree_id=basic_salary_emp.degree_id and employees.class_id=basic_salary_emp.class_id and employees.sections=basic_salary_emp.section_count and employees.stop_flag='" & 2 & "' and employees.bdeel_flag='" & 0 & "' order by employees.emp_no"
        '                    _sqlString = "select employees.emp_id,employees.emp_no,employees.emp_name,(b_s.sum+basic_salary_emp.basic_sal)*  " & xx & " mblg,0.5 dmga ,((b_s.sum+basic_salary_emp.basic_sal)*  " & xx & ")- 0.5 net from employees,basic_salary_emp,(select sum(ss.sum) sum,ss.i,ss.d,ss.c from(select not_conbdel.blance sum,employees.dgree_id d,employees.class_id c,employees.emp_id i from employees,not_conbdel,base_bdl,classes where base_bdl.name='" & egtmaya & "' and employees.emp_id=not_conbdel.emp_id and not_conbdel.bdl_id=base_bdl.id and employees.class_id=classes.class_id and classes.class_id='" & clas_id & "' union select sum(con_bdal.bdl_val) sum,con_bdal.degree_id d,con_bdal.class_id c,employees.emp_id i from con_bdal,employees where con_bdal.degree_id=employees.dgree_id and con_bdal.class_id='" & clas_id & "' group by con_bdal.degree_id,con_bdal.class_id,employees.emp_id) ss group by ss.i,ss.d,ss.c)b_s where employees.class_id=b_s.c and employees.dgree_id=b_s.d and employees.emp_id=b_s.i and b_s.d=basic_salary_emp.degree_id and b_s.c=basic_salary_emp.class_id and employees.dgree_id=basic_salary_emp.degree_id and employees.class_id=basic_salary_emp.class_id and employees.sections=basic_salary_emp.section_count and employees.stop_flag='" & 2 & "' and employees.bdeel_flag='" & 0 & "' order by employees.emp_no"
        '                Else 'ﬁ÷«…
        '                    _sqlString = "select employees.emp_id,employees.emp_no,employees.emp_name,(sum(con_bdal.bdl_val)+basic_salary_emp.basic_sal)*" & xx & " as mblg,0.5 as dmga,(((sum(con_bdal.bdl_val)+basic_salary_emp.basic_sal)* " & xx & ") -'" & 0.5 & "')  as net,employees.emp_id,employees.emp_no,employees.emp_name from employees,con_bdal,basic_salary_emp where employees.dgree_id=con_bdal.degree_id and employees.class_id=con_bdal.class_id and  employees.class_id='" & clas_id & "' and employees.stop_flag='" & 2 & "' and employees.bdeel_flag='" & 0 & "' and employees.dgree_id=basic_salary_emp.degree_id and employees.sections=basic_salary_emp.section_count and employees.class_id=basic_salary_emp.class_id and employees.sections=basic_salary_emp.section_count group by employees.emp_id,employees.emp_no,employees.emp_name,basic_salary_emp.basic_sal order by employees.emp_no"
        '                End If
        '                '_sqlString = _sqlString + "FROM employees,classes"
        '                '_sqlString = _sqlString + " WHERE  employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'"
        '                _DS.SQL = _sqlString
        '                _rpt.DataSource = _DS
        '            Else '«·„ÊŸ›Ì‰ „« ⁄œ« «·„ ⁄«ﬁœÌ‰ /«·‘—ÿ… / «·ﬁ÷«…
        '                _rpt = New bdeelrep
        '                Dim x As String
        '                Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no ,employees.emp_name,classes.class_id,classes.class_name from employees ,classes where employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id and classes.class_name='" & class_txt.Text & "' and employees.bdeel_flag='" & 0 & "' ", Con)
        '                Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        '                Dim dt As New DataTable
        '                da.Fill(dt)
        '                If dt.Rows.Count < 1 Then
        '                    MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
        '                    Exit Sub
        '                End If
        '                Dim clas_id = dt.Rows(0).Item("class_id")
        '                Dim dmga As String = "œ„€…"
        '                Dim egtmaya As String = "«Ã „«⁄Ì…"
        '                classname = ""
        '                If (part_txt.Text = "„‰Õ… ⁄Ìœ «·›ÿ—" Or part_txt.Text = "„‰Õ… ⁄Ìœ «·«÷ÕÏ") Then
        '                    classname = "(" + " ⁄»«—… ⁄‰   " + part_txt.Text + " " + "··⁄«„ «·„«·Ì" + str(EYER) + "„ " + " " + "( " + dt.Rows(0).Item("class_name")
        '                Else
        '                    classname = "(" + " ⁄»«—… ⁄‰ «·»œÌ· «·‰ﬁœÌ «·Ã“¡  " + part_txt.Text + " " + "··⁄«„ «·„«·Ì" + str(EYER) + "„ " + " " + "( " + dt.Rows(0).Item("class_name")
        '                End If
        '                Dim k As Integer
        '                'Dim id_em = dt.Rows(0).Item("emp_id")  employees.emp_no ,employees.emp_name,classes.class_name
        '                Dim _sqlString As String = "select x.emp_id,em.emp_no,em.emp_name,x.mblg * " & xx & " mblg,ar.con_est_val dmga,10 * " & xx & " ngaba,(ar.con_est_val+10* " & xx & " ) tot,((x.mblg* " & xx & ") -(ar.con_est_val+10* " & xx & "))  net from employees em,(select sum(y.bdl) as mblg,y.emp_id from ((select emp_id,con_bdl_val as bdl from archief where  class_id='" & clas_id & "' and date_='" & date_.Text & "') union (select emp_id,not_conbdle_val as bdl from archief where  not_conbdel_name='" & egtmaya & "' and class_id='" & clas_id & "' and date_='" & date_.Text & "')) y group by y.emp_id) x,archief ar where em.bdeel_flag='" & 0 & "' and em.stop_flag='" & 2 & "' and em.emp_id=ar.emp_id and ar.con_est_name='" & dmga & "' and ar.emp_id=x.emp_id and ar.date_='" & date_.Text & "' order by em.emp_no"
        '                '_sqlString = _sqlString + "FROM employees,classes"
        '                '_sqlString = _sqlString + " WHERE  employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'"
        '                _DS.SQL = _sqlString
        '                _rpt.DataSource = _DS
        '            End If
        '            '********
        '        Else
        '            '«·„ ⁄«ﬁœÌ‰ / «·ﬁ÷«… «·„ ⁄«ﬁœÌ‰ / ⁄„«· «·„ÿ»⁄…
        '            _rpt = New bdeelrep2  'bdeelrep '
        '            Dim x As String
        '            Dim cmd2 As New SqlClient.SqlCommand("SELECT employees.emp_no ,employees.emp_name,classes.class_id,classes.class_name from employees ,classes where employees.stop_flag='" & 2 & "' and employees.class_id=classes.class_id and classes.class_name='" & class_txt.Text & "' and employees.bdeel_flag='" & 0 & "'", Con)
        '            Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        '            Dim dt As New DataTable
        '            da.Fill(dt)
        '            If dt.Rows.Count < 1 Then
        '                MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «· ’‰Ì›  :-" + "  " + class_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
        '                Exit Sub
        '            End If
        '            Dim clas_id = dt.Rows(0).Item("class_id")

        '            Dim dmga As String = "œ„€…"
        '            Dim mgmd As String = "«·„Ã„œ"
        '            'Dim egtmaya As String = "«Ã „«⁄Ì…"
        '            classname = ""
        '            If (part_txt.Text = "„‰Õ… ⁄Ìœ «·›ÿ—" Or part_txt.Text = "„‰Õ… ⁄Ìœ «·«÷ÕÏ") Then
        '                classname = "(" + " ⁄»«—… ⁄‰   " + part_txt.Text + " " + "··⁄«„ «·„«·Ì" + str(EYER) + "„ " + " " + "( " + dt.Rows(0).Item("class_name")
        '            Else
        '                classname = "(" + " ⁄»«—… ⁄‰ «·»œÌ· «·‰ﬁœÌ «·Ã“¡  " + part_txt.Text + " " + "··⁄«„ «·„«·Ì" + str(EYER) + "„ " + " " + "( " + dt.Rows(0).Item("class_name")
        '            End If
        '            Dim k As Integer

        '            'Dim id_em = dt.Rows(0).Item("emp_id")  employees.emp_no ,employees.emp_name,classes.class_name
        '            'Dim _sqlString As String = "select employees.emp_no,employees.emp_id,employees.emp_name,archief.not_conbdle_val mblg,archief.con_est_val dmga,(archief.not_conbdle_val-archief.con_est_val) net from employees,archief,classes where employees.bdeel_flag='" & 0 & "' and employees.emp_id=archief.emp_id and archief.class_id=classes.class_id and classes.class_id='" & clas_id & "' and archief.not_conbdel_name='" & mgmd & "' and archief.con_est_name='" & dmga & "' and archief.date_='" & date_.Text & "' order by employees.emp_no"
        '            Dim _sqlString As String = "select employees.emp_no,employees.emp_id,employees.emp_name,archief.not_conbdle_val* " & xx & " mblg,0.5  dmga,((archief.not_conbdle_val* " & xx & ") -0.5) net from employees,archief,classes where employees.bdeel_flag='" & 0 & "' and employees.emp_id=archief.emp_id and archief.class_id=classes.class_id and classes.class_id='" & clas_id & "' and archief.not_conbdel_name='" & mgmd & "' and archief.date_='" & date_.Text & "' order by employees.emp_no"  'and archief.con_est_name='" & dmga & "'
        '            'employees.emp_no,employees.emp_id,employees.emp_name,archief.not_conbdle_val mblg,0.5 dmga,(archief.not_conbdle_val-0.5) net  
        '            '_sqlString = _sqlString + "FROM employees,classes"
        '            '_sqlString = _sqlString + " WHERE  employees.class_id=classes.class_id    and  classes.class_name='" & class_txt.Text & "'"
        '            _DS.SQL = _sqlString

        '            _rpt.DataSource = _DS
        '        End If ' If (class_txt.Text <> "«·„ ⁄«ﬁœÌ‰" And class_txt.Text <> "⁄„«· «·„ÿ»⁄…
        '    End If 'If 'If alngdy.Checked = True Then '«·»œÌ·
        '    '================


        '    '/////////////////////////list


        '    Me.Viewer1.Document = _rpt.Document
        '    _rpt.Run(False)
        '    Me.Cursor = _tmp
        'Catch ex As DataDynamics.ActiveReports.ReportException
        'MessageBox.Show(Me, "Error fired while running the report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub mencard2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        empname_txt.Enabled = False
        part_txt.Enabled = False

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
        Dim str01 As String = "SELECT employees.emp_name from employees,dgree_base,sites,classes where employees.site_id=sites.site_id and employees.class_id=classes.class_id and employees.dgree_id=dgree_base.dgree_id  and classes.class_name='" & class_txt.Text & "' and employees.stop_flag='" & 2 & "' "
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
    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
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
End Class
