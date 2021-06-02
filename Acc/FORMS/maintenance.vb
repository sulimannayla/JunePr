Public Class maintenance
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dell As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents add1 As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents apply_person_txt As System.Windows.Forms.TextBox
    Friend WithEvents apply_date_txt As System.Windows.Forms.DateTimePicker
    Friend WithEvents maintenance_req_txt As System.Windows.Forms.TextBox
    Friend WithEvents shop_report_txt As System.Windows.Forms.TextBox
    Friend WithEvents notes_txt As System.Windows.Forms.TextBox
    Friend WithEvents car2_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents maintenance_id_txt As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents medntxt As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.car2_no_txt = New System.Windows.Forms.TextBox
        Me.maintenance_id_txt = New System.Windows.Forms.TextBox
        Me.apply_person_txt = New System.Windows.Forms.TextBox
        Me.apply_date_txt = New System.Windows.Forms.DateTimePicker
        Me.maintenance_req_txt = New System.Windows.Forms.TextBox
        Me.shop_report_txt = New System.Windows.Forms.TextBox
        Me.notes_txt = New System.Windows.Forms.TextBox
        Me.dell = New System.Windows.Forms.Button
        Me.search = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.edit = New System.Windows.Forms.Button
        Me.add1 = New System.Windows.Forms.Button
        Me.save = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.medntxt = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Andalus", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(177, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(424, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ÿ·‹‹‹» «·’Ì‹‹‹‹«‰‹‹‹…"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Location = New System.Drawing.Point(-39, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 72)
        Me.Panel1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(665, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "—ﬁ‹‹‹‹„ «·⁄—»…"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(665, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 32)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "„‹·«ÕŸ‹‹‹‹« "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(665, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 32)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = " ﬁ—Ì‹‹‹— «·Ê—‘…"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(665, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 32)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "«·’Ì‹«‰… «·„ÿ·Ê»…"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(671, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 32)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = " ‹‹‹«—ÌŒ «·ÿ·»"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(665, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 24)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "„ﬁ‹‹‹‹œ„ «·ÿ·»"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(665, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 24)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "—ﬁ‹‹‹„ «·’Ì«‰…"
        '
        'car2_no_txt
        '
        Me.car2_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.car2_no_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.car2_no_txt.ForeColor = System.Drawing.Color.Black
        Me.car2_no_txt.Location = New System.Drawing.Point(513, 144)
        Me.car2_no_txt.Name = "car2_no_txt"
        Me.car2_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.car2_no_txt.Size = New System.Drawing.Size(152, 20)
        Me.car2_no_txt.TabIndex = 1
        Me.car2_no_txt.Text = ""
        '
        'maintenance_id_txt
        '
        Me.maintenance_id_txt.BackColor = System.Drawing.Color.White
        Me.maintenance_id_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.maintenance_id_txt.Enabled = False
        Me.maintenance_id_txt.Location = New System.Drawing.Point(512, 104)
        Me.maintenance_id_txt.Name = "maintenance_id_txt"
        Me.maintenance_id_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.maintenance_id_txt.Size = New System.Drawing.Size(152, 20)
        Me.maintenance_id_txt.TabIndex = 18
        Me.maintenance_id_txt.Text = ""
        '
        'apply_person_txt
        '
        Me.apply_person_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.apply_person_txt.Location = New System.Drawing.Point(393, 176)
        Me.apply_person_txt.Name = "apply_person_txt"
        Me.apply_person_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.apply_person_txt.Size = New System.Drawing.Size(272, 20)
        Me.apply_person_txt.TabIndex = 3
        Me.apply_person_txt.Text = ""
        '
        'apply_date_txt
        '
        Me.apply_date_txt.CustomFormat = "yyyy/MM/dd"
        Me.apply_date_txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.apply_date_txt.Location = New System.Drawing.Point(537, 208)
        Me.apply_date_txt.Name = "apply_date_txt"
        Me.apply_date_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.apply_date_txt.Size = New System.Drawing.Size(128, 20)
        Me.apply_date_txt.TabIndex = 4
        '
        'maintenance_req_txt
        '
        Me.maintenance_req_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.maintenance_req_txt.Location = New System.Drawing.Point(329, 240)
        Me.maintenance_req_txt.Multiline = True
        Me.maintenance_req_txt.Name = "maintenance_req_txt"
        Me.maintenance_req_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.maintenance_req_txt.Size = New System.Drawing.Size(336, 24)
        Me.maintenance_req_txt.TabIndex = 5
        Me.maintenance_req_txt.Text = ""
        '
        'shop_report_txt
        '
        Me.shop_report_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shop_report_txt.Location = New System.Drawing.Point(321, 272)
        Me.shop_report_txt.Multiline = True
        Me.shop_report_txt.Name = "shop_report_txt"
        Me.shop_report_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.shop_report_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.shop_report_txt.Size = New System.Drawing.Size(344, 64)
        Me.shop_report_txt.TabIndex = 6
        Me.shop_report_txt.Text = ""
        '
        'notes_txt
        '
        Me.notes_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.notes_txt.Location = New System.Drawing.Point(321, 384)
        Me.notes_txt.Multiline = True
        Me.notes_txt.Name = "notes_txt"
        Me.notes_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.notes_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.notes_txt.Size = New System.Drawing.Size(344, 56)
        Me.notes_txt.TabIndex = 8
        Me.notes_txt.Text = ""
        '
        'dell
        '
        Me.dell.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dell.Location = New System.Drawing.Point(232, 472)
        Me.dell.Name = "dell"
        Me.dell.Size = New System.Drawing.Size(88, 32)
        Me.dell.TabIndex = 11
        Me.dell.Text = "Õ–›"
        Me.dell.Visible = False
        '
        'search
        '
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.search.Location = New System.Drawing.Point(336, 472)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(88, 32)
        Me.search.TabIndex = 12
        Me.search.Text = "»ÕÀ"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Location = New System.Drawing.Point(104, 456)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(648, 64)
        Me.Label12.TabIndex = 67
        '
        'edit
        '
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.edit.Location = New System.Drawing.Point(432, 472)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(88, 32)
        Me.edit.TabIndex = 13
        Me.edit.Text = " ⁄œÌ·"
        '
        'add1
        '
        Me.add1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.add1.Location = New System.Drawing.Point(632, 472)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(96, 32)
        Me.add1.TabIndex = 0
        Me.add1.Text = "ÃœÌœ"
        '
        'save
        '
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.save.Location = New System.Drawing.Point(528, 472)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(96, 32)
        Me.save.TabIndex = 9
        Me.save.Text = "Õ›Ÿ"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.Location = New System.Drawing.Point(136, 472)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "ÿ»«⁄… «·”Ã·"
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(80, 224)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox1.TabIndex = 74
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(56, 200)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(232, 136)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "«Œ—  «—ÌŒ ·’—› «·«”»Ì—"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SeaShell
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(96, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(104, 24)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "mm/dd/yyyy"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SeaShell
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(96, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(104, 32)
        Me.Label4.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Simplified Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(660, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(150, 33)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = " Ê’Ì… „œÌ— «·‘∆Ê‰ «·«œ«—Ì…"
        '
        'CheckBox2
        '
        Me.CheckBox2.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(56, 120)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.TabIndex = 83
        Me.CheckBox2.Text = "Ê—‘… Œ«—ÃÌ…"
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(144, 32)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 24)
        Me.CheckBox1.TabIndex = 82
        Me.CheckBox1.Text = "Ê—‘… œ«Œ·Ì…"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 88)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(272, 72)
        Me.GroupBox3.TabIndex = 84
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "„ﬂ«‰ ’—› «·«”»Ì—"
        '
        'medntxt
        '
        Me.medntxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.medntxt.Location = New System.Drawing.Point(321, 350)
        Me.medntxt.Name = "medntxt"
        Me.medntxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.medntxt.Size = New System.Drawing.Size(335, 20)
        Me.medntxt.TabIndex = 7
        Me.medntxt.Text = ""
        '
        'maintenance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(804, 541)
        Me.Controls.Add(Me.medntxt)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dell)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.add1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.notes_txt)
        Me.Controls.Add(Me.shop_report_txt)
        Me.Controls.Add(Me.maintenance_req_txt)
        Me.Controls.Add(Me.apply_person_txt)
        Me.Controls.Add(Me.maintenance_id_txt)
        Me.Controls.Add(Me.car2_no_txt)
        Me.Controls.Add(Me.apply_date_txt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "maintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ÿ·» «·’Ì«‰…"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add1.Click
        GroupBox3.Visible = False
        Button2.Enabled = False
        CheckBox1.Visible = False
        CheckBox2.Visible = False
        ComboBox1.Visible = False
        GroupBox1.Visible = False
        Label4.Visible = False
        shop_report_txt.Enabled = False
        medntxt.Enabled = False
        ComboBox1.Items.Clear()
        bt_add1(edit, add1, save, search, dell)
        Call clear()
    End Sub
    Private Sub clear()
        car2_no_txt.Text = ""
        apply_person_txt.Text = ""
        apply_date_txt.Text = ""
        maintenance_req_txt.Text = ""
        notes_txt.Text = ""
        shop_report_txt.Text = ""
        maintenance_id_txt.Text = ""
        medntxt.Text = ""
    End Sub
    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        ComboBox1.Items.Clear()
        Dim wortxt As String
        If CheckBox1.Checked = True Then
            wortxt = ("«·Ê—‘… «·„Œ ’…")
        End If
        If CheckBox2.Checked = True Then
            wortxt = "Ê—‘… œ«Œ·Ì…"
        End If
        Dim DS As New DataSet
        Dim currRec As Integer = 0
        Dim t As DataTable

        If Trim(car2_no_txt.Text) = "" Or Trim(apply_person_txt.Text) = "" Or Trim(apply_date_txt.Text) = "" Or Trim(maintenance_req_txt.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If

        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()

        '***************************

        Dim DS3 As New DataSet
        Dim str As String = "SELECT  car2_no FROM car2_data where car2_no= '" & car2_no_txt.Text & "' "
        Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        ADP.Fill(DS3)
        Dim i As Integer
        'If DS.Rows(0).Item("group_no") Is DBNull.Value Then
        If DS3.Tables(0).Rows.Count < 1 Then
            MsgBox("·« ÊÃœ ⁄—»…  Õ„· «·—ﬁ„  :-" + "  " + car2_no_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            car2_no_txt.Text = ""
            Exit Sub
        End If
        'Sub datediff
        '***************************
        Dim DS2 As New DataSet
        Dim t2 As DataTable
        Dim cmd2 As New SqlClient.SqlCommand("SELECT type_no FROM car2_data where car2_no='" & car2_no_txt.Text.Trim & "'", Con)
        Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        dr.Read()
        Dim x As Integer = dr.Item("type_no")
        dr.Close()
        '********************
        Dim cmdString As String = "INSERT INTO maintenance " + _
                                  "(medn,chec1,chec2,type_no,car2_no,apply_person,apply_date,main_req,notes) " + _
                                  "VALUES('" & medntxt.Text & "','" & CheckBox1.CheckState & "','" & CheckBox2.CheckState & "','" & x & "','" & car2_no_txt.Text & "','" & apply_person_txt.Text & "','" & apply_date_txt.Text & "','" & maintenance_req_txt.Text & "','" & notes_txt.Text & "')"
        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        Button2.Enabled = True
        Try
            cmd.ExecuteNonQuery()
            Con.Close()
            Call num()
            MsgBox("·ﬁœ  „ Õ›Ÿ «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        bt_save(edit, add1, save, search, dell)

    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        ComboBox1.Text = ""
        ComboBox1.Items.Clear()
        Label4.Text = ""
        Dim wortxt As String
        If CheckBox1.Checked = True Then
            wortxt = ("«·Ê—‘… «·„Œ ’…")
        End If
        If CheckBox2.Checked = True Then
            wortxt = "Ê—‘… œ«Œ·Ì…"
        End If
        If Trim(car2_no_txt.Text) = "" Or Trim(apply_person_txt.Text) = "" Or Trim(apply_date_txt.Text) = "" Or Trim(maintenance_req_txt.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        Dim x As Integer
        ComboBox1.Enabled = True
        Label4.Enabled = True
        GroupBox1.Enabled = True
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        '***************************

        '***************************************************************
        Dim DS8 As New DataSet
        Dim str8 As String = "SELECT  car2_no FROM car2_data where car2_no= '" & car2_no_txt.Text & "' "
        Dim ADP8 As New SqlClient.SqlDataAdapter(str8, Con)
        ADP8.Fill(DS8)
        Dim i8 As Integer
        'If DS.Rows(0).Item("group_no") Is DBNull.Value Then
        If DS8.Tables(0).Rows.Count < 1 Then
            MsgBox("·« ÊÃœ ⁄—»…  Õ„· «·—ﬁ„  :-" + "  " + car2_no_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            car2_no_txt.Text = ""
            Exit Sub
        End If
        '***************************************************************


        '**************************************************************
        Dim DS2 As New DataSet
        Dim t2 As DataTable
        Dim cmd2 As New SqlClient.SqlCommand("SELECT type_no FROM car2_data where car2_no='" & car2_no_txt.Text.Trim & "'", Con)
        Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        dr.Read()
        Dim x2 As Integer = dr.Item("type_no")
        dr.Close()
        '*****************************************************
        Dim DS3 As New DataSet
        Dim str As String = "SELECT  car2_no FROM car2_data where car2_no= '" & car2_no_txt.Text & "' "
        Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        ADP.Fill(DS3)
        Dim i As Integer
        'If DS.Rows(0).Item("group_no") Is DBNull.Value Then
        If DS3.Tables(0).Rows.Count < 1 Then
            MsgBox("·« ÊÃœ ⁄—»…  Õ„· «·—ﬁ„  :-" + "  " + car2_no_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            car2_no_txt.Text = ""
            Exit Sub
        End If



        Dim cmdString As String = "UPDATE maintenance " + _
                                    "SET  car2_no= '" & car2_no_txt.Text & "',medn='" & medntxt.Text & "', chec1= '" & CheckBox1.CheckState & "',chec2= '" & CheckBox2.CheckState & "',apply_person= '" & apply_person_txt.Text & "',type_no= '" & x2 & "' ,apply_date= '" & apply_date_txt.Text & "',main_req= '" & maintenance_req_txt.Text & "', shop_report= '" & shop_report_txt.Text & "', notes= '" & notes_txt.Text & "' " + _
                                    "WHERE maintenance_id = '" & maintenance_id_txt.Text & "'"
        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        Button2.Enabled = True
        Try
            cmd.ExecuteNonQuery()
            MsgBox("·ﬁœ  „  ⁄œÌ· «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
            '////////////////////////////////////////////////////////

            'shop_report_txt.Enabled = False
            'medntxt.Enabled = False

            bt_edit(edit, add1, save, search, dell)
            Dim DS6 As New DataSet
            Dim str6 As String = "SELECT DISTINCT parts.part_name FROM parts , invoice where invoice.invoice_no = parts.invoice_no and invoice.car2_no= '" & car2_no_txt.Text & "' "
            Dim ADP6 As New SqlClient.SqlDataAdapter(str6, Con)
            ADP6.Fill(DS6)
            Dim i6 As Integer
            'If DS.Rows(0).Item("group_no") Is DBNull.Value Then
            If DS6.Tables(0).Rows.Count < 1 Then
                Label4.Text = "·„ Ì’—› «”»Ì— „‰ ﬁ»· "
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

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        Label4.Text = ""
        Dim dt2 As New DataTable
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim message, title, defaultValue, m, txt As String
        defaultValue = 0
        message = " «œŒ·  —ﬁ„ «·’Ì«‰… «·„—«œ «·»ÕÀ ⁄‰Â "
        title = "»ÕÀ"
        maintenance_id_txt.Text = Val(InputBox(message, title, defaultValue, MsgBoxStyle.OKOnly))
        If Trim(maintenance_id_txt.Text) = "" Then
            MsgBox("ÌÃ» «œŒ«· —ﬁ„ «·’Ì«‰…«Ê·«")
            Exit Sub
        End If
        Dim Cmd As New SqlClient.SqlCommand("mintnancemaintenance_SelectOne", Con)
        With Cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.Add("@imaintenance_id", maintenance_id_txt.Text)
        End With
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Cmd.ExecuteNonQuery()

        If dt.Rows.Count < 1 Then
            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «·—ﬁ„  :-" + "  " + maintenance_id_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            maintenance_id_txt.Text = ""
            Exit Sub
        End If
        
        'txt = dt.Rows(0).Item("type_no")
        '***********************************************
        ''Dim Cmd2 As New SqlClient.SqlCommand("partscar2_type_SelectOne", Con)
        ''With Cmd2
        ''    .CommandType = CommandType.StoredProcedure
        ''    .Parameters.Add("@itype_no", txt)
        ''    '.Parameters.Add("@ierrorcode", "")
        ''End With
        ''Dim da2 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd2)
        ''da2.Fill(dt2)
        '****************************************************************
        'Cmd2.ExecuteNonQuery()
        'If dt.Rows.Count < 1 Then
        '    MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «·—ﬁ„  :-" + "  " + maintenance_id_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
        '    maintenance_id_txt.Text = ""
        '    Exit Sub
        'End If
        Button2.Enabled = True
        shop_report_txt.Enabled = True
        medntxt.Enabled = True
        GroupBox3.Visible = True
        CheckBox1.Visible = True
        CheckBox2.Visible = True
        ComboBox1.Visible = True
        Label4.Visible = True
        GroupBox1.Visible = True
        bt_search(edit, add1, save, search, dell)
        maintenance_id_txt.Text = dt.Rows(0).Item("maintenance_id")
        car2_no_txt.Text = dt.Rows(0).Item("car2_no")
        apply_person_txt.Text = dt.Rows(0).Item("apply_person")
        apply_date_txt.Text = dt.Rows(0).Item("apply_date")
        maintenance_req_txt.Text = dt.Rows(0).Item("main_req")
        'car2typecom.Text = dt2.Rows(0).Item("car2_name")
        '***********************************************************************
        If dt.Rows(0).Item("chec1") = 1 Then
            CheckBox1.CheckState = CheckState.Checked
        Else
            CheckBox1.CheckState = CheckState.Unchecked
        End If

        If dt.Rows(0).Item("chec2") = 1 Then
            CheckBox2.CheckState = CheckState.Checked
        Else
            CheckBox2.CheckState = CheckState.Unchecked
        End If
        '*************************************************************************
        If dt.Rows(0).Item("shop_report") Is DBNull.Value Then
            shop_report_txt.Text = ""
        Else
            shop_report_txt.Text = dt.Rows(0).Item("shop_report")
        End If

        If dt.Rows(0).Item("notes") Is DBNull.Value Then
            notes_txt.Text = ""
        Else
            notes_txt.Text = dt.Rows(0).Item("notes")
        End If
        Try
            If dt.Rows(0).Item("medn") Is DBNull.Value Then
                medntxt.Text = ""
            Else
                medntxt.Text = dt.Rows(0).Item("medn")
            End If

            '***************************************************
            Dim DS As New DataSet
            Dim str As String = "SELECT DISTINCT parts.part_name FROM parts , invoice where invoice.invoice_no = parts.invoice_no and invoice.car2_no= '" & car2_no_txt.Text & "' "
            Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
            ADP.Fill(DS)
            Dim i As Integer
            'If DS.Rows(0).Item("group_no") Is DBNull.Value Then
            If DS.Tables(0).Rows.Count < 1 Then
                Label4.Text = "·„ Ì’—› «”»Ì— „‰ ﬁ»· "
                Con.Close()
                Exit Sub
            Else
                ComboBox1.Items.Clear()
                For i = 0 To DS.Tables(0).Rows.Count - 1
                    Me.ComboBox1.Items.Add(DS.Tables(0).Rows(i).Item(0))
                Next
                ADP.Dispose()
            End If
            '***************************************************
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
    End Sub

    Private Sub dell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dell.Click

        Label4.Text = ""
        ComboBox1.Text = ""
        ComboBox1.Items.Clear()
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim str As String
        str = MsgBox("·ﬁœ  —Ìœ Õ–› «·”Ã· «·–Ï ÌÕ„· «·—ﬁ„  :-" + "  " + maintenance_id_txt.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Information, " ‰»ÌÂ")
        If str = vbYes Then
            Dim Cmd As New SqlClient.SqlCommand("mintnancemaintenance_Delete", Con)
            With Cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add("@imaintenance_id ", maintenance_id_txt.Text)
                Try
                    Cmd.ExecuteNonQuery()
                    Call clear()
                    MsgBox("·ﬁœ  „ Õ–› «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
                    shop_report_txt.Enabled = False
                    medntxt.Enabled = False

                    bt_dell(edit, add1, save, search, dell)
                    GroupBox3.Visible = False
                    Button2.Enabled = False
                    CheckBox1.Visible = False
                    CheckBox2.Visible = False
                    ComboBox1.Visible = False
                    Label4.Visible = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    Button2.Enabled = False
                End Try

                Con.Close()
            End With
        End If
    End Sub
    Private Sub num()
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim DS As New DataSet
        Dim t As DataTable
        Dim cmd2 As New SqlClient.SqlCommand("select max(maintenance_id) maintenance_id from maintenance  ", Con)
        Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        dr.Read()
        maintenance_id_txt.Text = dr.Item("maintenance_id")
        dr.Close()
        Try
        Catch er As Exception
            MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√
        End Try
        Con.Close()
    End Sub
    Private Sub maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        shop_report_txt.Enabled = False
        medntxt.Enabled = False
        Button2.Enabled = False
        GroupBox3.Visible = False

        CheckBox1.Visible = False
        CheckBox2.Visible = False
        ComboBox1.Visible = False

        Label4.Visible = False
        GroupBox1.Visible = False
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        'Con.Open()

        bt_low(edit, add1, save, search, dell)
        'Dim df As New SECURITY
        'MsgBox(df.UserID.Text)
        'Dim user As String = df.UserID.Text
        'Dim password1 As String = df.Password.Text
        'Dim lsPassword, lsUserId As String
        'Con.ConnectionString = "User ID= '" & df.UserID.Text & "';" & _
        '"Password='" & df.Password.Text & "';" & _
        '"Initial Catalog=car2;" & _
        '"Data Source=pc;" & _
        '"Connection TimeOut=30;"

        'If Con.State.Open = ConnectionState.Open Then
        '    Con.Close()
        'End If
        'Con.Open()
        'Try
        '    Dim DS As New DataSet
        '    Dim str As String = "SELECT DISTINCT car2_name FROM car2_type"
        '    Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        '    ADP.Fill(DS)
        '    Dim i As Integer
        '    For i = 0 To DS.Tables(0).Rows.Count - 1
        '        Me.car2typecom.Items.Add(DS.Tables(0).Rows(i).Item(0))
        '    Next
        '    ADP.Dispose()
        'Catch er As Exception
        '    MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√
        'End Try
        'Con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cmd As New SqlClient.SqlCommand("SELECT date FROM invoice WHERE date=(select max(date) FROM invoice , parts where invoice.invoice_no = parts.invoice_no and invoice.car2_no= '" & car2_no_txt.Text & "' and parts.part_name = '" & ComboBox1.Text & "') ", Con)
        'Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        If dt.Rows.Count < 1 Then
            Label4.Text = "·„ Ì „ ’—› ≈”»Ì— „‰ ﬁ»· "
            'MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «·—ﬁ„  :-" + "  " + maintenance_id_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            Exit Sub
        End If
        Label4.Text = dt.Rows(0).Item("date")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ad2 = Me.maintenance_id_txt.Text
        Try
            Dim Fw As New pritmentenance1
            Fw.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try


    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(CheckBox1.CheckState)
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
End Class
