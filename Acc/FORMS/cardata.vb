Public Class car2data
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dell As System.Windows.Forms.Button
    Friend WithEvents add1 As System.Windows.Forms.Button
    Friend WithEvents no_type_txt As System.Windows.Forms.ComboBox
    Friend WithEvents insurance_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents model_txt As System.Windows.Forms.TextBox
    Friend WithEvents shase_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents car2_owner_txt As System.Windows.Forms.TextBox
    Friend WithEvents driver_txt As System.Windows.Forms.TextBox
    Friend WithEvents car2_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents type_no_txt As System.Windows.Forms.ComboBox
    Friend WithEvents machine_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents insurance_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Button
    Friend WithEvents search As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents device_no_txt As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents privet_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents reg_no_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents NOTETXT As System.Windows.Forms.TextBox
    Friend WithEvents MARKET_COSTXT As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents insudatstar As System.Windows.Forms.DateTimePicker
    Friend WithEvents search2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.car2_no_txt = New System.Windows.Forms.TextBox
        Me.machine_no_txt = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.car2_owner_txt = New System.Windows.Forms.TextBox
        Me.model_txt = New System.Windows.Forms.TextBox
        Me.shase_no_txt = New System.Windows.Forms.TextBox
        Me.driver_txt = New System.Windows.Forms.TextBox
        Me.type_no_txt = New System.Windows.Forms.ComboBox
        Me.no_type_txt = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.insurance_date = New System.Windows.Forms.DateTimePicker
        Me.insurance_no_txt = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.dell = New System.Windows.Forms.Button
        Me.search = New System.Windows.Forms.Button
        Me.add1 = New System.Windows.Forms.Button
        Me.edit = New System.Windows.Forms.Button
        Me.save = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.device_no_txt = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.privet_no_txt = New System.Windows.Forms.TextBox
        Me.reg_no_txt = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.MARKET_COSTXT = New System.Windows.Forms.TextBox
        Me.NOTETXT = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.insudatstar = New System.Windows.Forms.DateTimePicker
        Me.search2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 72)
        Me.Panel1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arabic Transparent", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(424, 35)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "»Ì‹‹‹‹‹‹«‰«  «·⁄‹‹‹‹—»« "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "«·„‹‹‹‹‹ÊœÌ‹‹·"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(584, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "—ﬁ„ «·⁄—»… «·ÕﬂÊ„Ï"
        '
        'car2_no_txt
        '
        Me.car2_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.car2_no_txt.Location = New System.Drawing.Point(448, 80)
        Me.car2_no_txt.Name = "car2_no_txt"
        Me.car2_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.car2_no_txt.Size = New System.Drawing.Size(136, 20)
        Me.car2_no_txt.TabIndex = 1
        Me.car2_no_txt.Text = ""
        '
        'machine_no_txt
        '
        Me.machine_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.machine_no_txt.Location = New System.Drawing.Point(32, 112)
        Me.machine_no_txt.Name = "machine_no_txt"
        Me.machine_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.machine_no_txt.Size = New System.Drawing.Size(152, 20)
        Me.machine_no_txt.TabIndex = 10
        Me.machine_no_txt.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(584, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 40)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "«· Œ‹‹’Ì‹‹‹’"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label5.Location = New System.Drawing.Point(584, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 32)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "‰„‹‹—… «·‘«”‹Ï"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(184, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 32)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "‰‹Ê⁄ «· —ŒÌ‹‹’"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label7.Location = New System.Drawing.Point(584, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 32)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "‰‹‹‹‹Ê⁄ «·⁄—»…"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label8.Location = New System.Drawing.Point(184, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 32)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "—ﬁ‹‹„ «·„‹‹«ﬂÌ‰…"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label9.Location = New System.Drawing.Point(184, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 32)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "—ﬁ‹‹„ ÊÀÌﬁ… «· «„Ì‰"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label10.Location = New System.Drawing.Point(168, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(136, 32)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = " ≈‰ ‹Â«¡ «· «„‹‹Ì‹‰"
        '
        'car2_owner_txt
        '
        Me.car2_owner_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.car2_owner_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.car2_owner_txt.Location = New System.Drawing.Point(360, 240)
        Me.car2_owner_txt.Name = "car2_owner_txt"
        Me.car2_owner_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.car2_owner_txt.Size = New System.Drawing.Size(224, 22)
        Me.car2_owner_txt.TabIndex = 6
        Me.car2_owner_txt.Text = ""
        '
        'model_txt
        '
        Me.model_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.model_txt.Location = New System.Drawing.Point(32, 144)
        Me.model_txt.Name = "model_txt"
        Me.model_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.model_txt.Size = New System.Drawing.Size(152, 20)
        Me.model_txt.TabIndex = 11
        Me.model_txt.Text = ""
        '
        'shase_no_txt
        '
        Me.shase_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.shase_no_txt.Location = New System.Drawing.Point(360, 208)
        Me.shase_no_txt.Name = "shase_no_txt"
        Me.shase_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.shase_no_txt.Size = New System.Drawing.Size(224, 20)
        Me.shase_no_txt.TabIndex = 5
        Me.shase_no_txt.Text = ""
        '
        'driver_txt
        '
        Me.driver_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.driver_txt.Location = New System.Drawing.Point(360, 272)
        Me.driver_txt.Name = "driver_txt"
        Me.driver_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.driver_txt.Size = New System.Drawing.Size(224, 20)
        Me.driver_txt.TabIndex = 7
        Me.driver_txt.Text = ""
        '
        'type_no_txt
        '
        Me.type_no_txt.Location = New System.Drawing.Point(360, 176)
        Me.type_no_txt.Name = "type_no_txt"
        Me.type_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.type_no_txt.Size = New System.Drawing.Size(224, 21)
        Me.type_no_txt.TabIndex = 4
        '
        'no_type_txt
        '
        Me.no_type_txt.Items.AddRange(New Object() {"„‹‹‹‹·«ﬂÏ", "Õﬂ‹‹‹Ê„Ï", "«” À„«—"})
        Me.no_type_txt.Location = New System.Drawing.Point(32, 176)
        Me.no_type_txt.Name = "no_type_txt"
        Me.no_type_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.no_type_txt.Size = New System.Drawing.Size(152, 21)
        Me.no_type_txt.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label11.Location = New System.Drawing.Point(584, 265)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 32)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "«”‹‹‹‹„ «·”«∆ﬁ"
        '
        'insurance_date
        '
        Me.insurance_date.CustomFormat = "yyyy/MM/dd"
        Me.insurance_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.insurance_date.Location = New System.Drawing.Point(72, 240)
        Me.insurance_date.Name = "insurance_date"
        Me.insurance_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.insurance_date.Size = New System.Drawing.Size(112, 20)
        Me.insurance_date.TabIndex = 14
        '
        'insurance_no_txt
        '
        Me.insurance_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.insurance_no_txt.Location = New System.Drawing.Point(32, 272)
        Me.insurance_no_txt.Name = "insurance_no_txt"
        Me.insurance_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.insurance_no_txt.Size = New System.Drawing.Size(152, 20)
        Me.insurance_no_txt.TabIndex = 15
        Me.insurance_no_txt.Text = ""
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Location = New System.Drawing.Point(40, 368)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(544, 64)
        Me.Label12.TabIndex = 57
        '
        'dell
        '
        Me.dell.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dell.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dell.Location = New System.Drawing.Point(64, 384)
        Me.dell.Name = "dell"
        Me.dell.Size = New System.Drawing.Size(88, 32)
        Me.dell.TabIndex = 20
        Me.dell.Text = "Õ–›"
        '
        'search
        '
        Me.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.search.Location = New System.Drawing.Point(168, 384)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(88, 32)
        Me.search.TabIndex = 18
        Me.search.Text = "»ÕÀ"
        '
        'add1
        '
        Me.add1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.add1.Location = New System.Drawing.Point(480, 384)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(88, 32)
        Me.add1.TabIndex = 0
        Me.add1.Text = "ÃœÌœ"
        '
        'edit
        '
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.edit.Location = New System.Drawing.Point(264, 384)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(96, 32)
        Me.edit.TabIndex = 19
        Me.edit.Text = " ⁄œÌ·"
        '
        'save
        '
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.save.Location = New System.Drawing.Point(368, 384)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(104, 32)
        Me.save.TabIndex = 16
        Me.save.Text = "Õ›Ÿ"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label13.Location = New System.Drawing.Point(587, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 32)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "«·ÃÂ«“ «·ﬁ÷«∆‹‹Ì"
        '
        'device_no_txt
        '
        Me.device_no_txt.Location = New System.Drawing.Point(360, 144)
        Me.device_no_txt.Name = "device_no_txt"
        Me.device_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.device_no_txt.Size = New System.Drawing.Size(224, 21)
        Me.device_no_txt.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label14.Location = New System.Drawing.Point(184, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 24)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "—ﬁ„ «·⁄—»… «·Œ‹«’"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label15.Location = New System.Drawing.Point(584, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 32)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "—ﬁ‹‹‹„ «· ”ÃÌ‹·"
        '
        'privet_no_txt
        '
        Me.privet_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.privet_no_txt.Location = New System.Drawing.Point(32, 80)
        Me.privet_no_txt.Name = "privet_no_txt"
        Me.privet_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.privet_no_txt.Size = New System.Drawing.Size(152, 20)
        Me.privet_no_txt.TabIndex = 9
        Me.privet_no_txt.Text = ""
        '
        'reg_no_txt
        '
        Me.reg_no_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reg_no_txt.Location = New System.Drawing.Point(448, 112)
        Me.reg_no_txt.Name = "reg_no_txt"
        Me.reg_no_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.reg_no_txt.Size = New System.Drawing.Size(136, 20)
        Me.reg_no_txt.TabIndex = 2
        Me.reg_no_txt.Text = ""
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label16.Location = New System.Drawing.Point(184, 308)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 32)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "«·ﬁÌ„… «·”ÊﬁÌ… ··⁄—»…"
        '
        'MARKET_COSTXT
        '
        Me.MARKET_COSTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MARKET_COSTXT.Location = New System.Drawing.Point(32, 312)
        Me.MARKET_COSTXT.Name = "MARKET_COSTXT"
        Me.MARKET_COSTXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MARKET_COSTXT.Size = New System.Drawing.Size(152, 20)
        Me.MARKET_COSTXT.TabIndex = 16
        Me.MARKET_COSTXT.Text = ""
        '
        'NOTETXT
        '
        Me.NOTETXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NOTETXT.Location = New System.Drawing.Point(360, 304)
        Me.NOTETXT.Multiline = True
        Me.NOTETXT.Name = "NOTETXT"
        Me.NOTETXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NOTETXT.Size = New System.Drawing.Size(224, 48)
        Me.NOTETXT.TabIndex = 8
        Me.NOTETXT.Text = ""
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label17.Location = New System.Drawing.Point(592, 304)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 32)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "„·«ÕŸ‹‹‹‹« "
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.Location = New System.Drawing.Point(368, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Õ›Ÿ"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Simplified Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label18.Location = New System.Drawing.Point(168, 206)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label18.Size = New System.Drawing.Size(128, 32)
        Me.Label18.TabIndex = 66
        Me.Label18.Text = " ‹‹‹«—ÌŒ «· ‹«„Ì‰"
        '
        'insudatstar
        '
        Me.insudatstar.CustomFormat = "yyyy/MM/dd"
        Me.insudatstar.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.insudatstar.Location = New System.Drawing.Point(72, 208)
        Me.insudatstar.Name = "insudatstar"
        Me.insudatstar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.insudatstar.Size = New System.Drawing.Size(112, 20)
        Me.insudatstar.TabIndex = 13
        '
        'search2
        '
        Me.search2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.search2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.search2.Location = New System.Drawing.Point(168, 384)
        Me.search2.Name = "search2"
        Me.search2.Size = New System.Drawing.Size(88, 32)
        Me.search2.TabIndex = 18
        Me.search2.Text = "»ÕÀ"
        '
        'car2data
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(712, 429)
        Me.Controls.Add(Me.search2)
        Me.Controls.Add(Me.insudatstar)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.NOTETXT)
        Me.Controls.Add(Me.MARKET_COSTXT)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.reg_no_txt)
        Me.Controls.Add(Me.privet_no_txt)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.device_no_txt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dell)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.add1)
        Me.Controls.Add(Me.insurance_no_txt)
        Me.Controls.Add(Me.insurance_date)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.no_type_txt)
        Me.Controls.Add(Me.type_no_txt)
        Me.Controls.Add(Me.driver_txt)
        Me.Controls.Add(Me.shase_no_txt)
        Me.Controls.Add(Me.model_txt)
        Me.Controls.Add(Me.car2_owner_txt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.machine_no_txt)
        Me.Controls.Add(Me.car2_no_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Label12)
        Me.Name = "car2data"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "»Ì«‰«  «·⁄—»« "
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub
    Private Sub clear()
        no_type_txt.Text = ""
        insurance_date.Text = ""
        model_txt.Text = ""
        type_no_txt.Text = ""
        shase_no_txt.Text = ""
        car2_owner_txt.Text = ""
        machine_no_txt.Text = ""
        insurance_no_txt.Text = ""
        driver_txt.Text = ""
        car2_no_txt.Text = ""
        device_no_txt.Text = ""
        privet_no_txt.Text = ""
        reg_no_txt.Text = ""
        NOTETXT.Text = ""
        MARKET_COSTXT.Text = ""
    End Sub
    Private Sub add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add1.Click
        bt_add1(edit, add1, save, search, dell)
        clear()
        If dd = 1 Then
            dell.Enabled = False
            save.Visible = False
            Button1.Enabled = False
            search.Visible = False
        End If
    End Sub

    Private Sub search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search.Click
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim dt1 As New DataTable
        Dim dt5 As New DataTable
        Dim dt2 As New DataTable
        'Dim dt2 As New DataTable
        Dim message, title, defaultValue, m, x, txt, txt2 As String
        message = "«œŒ· —ﬁ„ «·⁄—»…"
        defaultValue = 0
        title = "»ÕÀ"
        car2_no_txt.Text = InputBox(message, title, defaultValue, MsgBoxStyle.OKOnly)
        If Trim(car2_no_txt.Text) = "" Then
            MsgBox("ÌÃ» «Œ Ì«— «·—ﬁ„ «·„ ”·”· «Ê·«")
            Exit Sub
        End If
        '**********************************************************
        Dim Cmd1 As New SqlClient.SqlCommand("SELECT * FROM car2_data  where theweel<>1 and    car2_no='" & car2_no_txt.Text.Trim & "'", Con)
        'With Cmd1
        '    .CommandType = CommandType.StoredProcedure
        '    .Parameters.Add("@icar2_no", car2_no_txt.Text)
        'End With
        Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd1)
        da1.Fill(dt1)
        Cmd1.ExecuteNonQuery()
        '***********************************************************************
        If dt1.Rows.Count < 1 Then
            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «·—ﬁ„  :-" + "  " + car2_no_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            Call clear()
            car2_no_txt.Text = ""
            Exit Sub
        End If
        txt2 = dt1.Rows(0).Item("site_id")
        txt = dt1.Rows(0).Item("type_no")
        '****************************************************************************
        Dim Cmd2 As New SqlClient.SqlCommand("SELECT * FROM car2_type where type_no='" & txt & "'", Con)
        Dim da2 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd2)
        da2.Fill(dt2)
        Cmd2.ExecuteNonQuery()
        If dt2.Rows.Count < 1 Then
            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„·2 «·—ﬁ„  :-" + "  " + car2_no_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            Exit Sub
        End If
        edit.Enabled = True
        '*****************************************************************
        '"SET site_name = '" & site_name_txt.Text & "' " + _
        '"WHERE site_id = '" & site_id_txt.Text & "'"
        Dim Cmd5 As New SqlClient.SqlCommand("SELECT * FROM sites where site_id='" & txt2 & "'", Con)
        Dim da5 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd5)
        da5.Fill(dt5)
        Cmd5.ExecuteNonQuery()
        If dt5.Rows.Count < 1 Then
            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «·—ﬁ„  :-" + "  " + device_no_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            Exit Sub
        End If
        '*********************************************************************
        bt_search(edit, add1, save, search, dell)
        device_no_txt.Text = dt5.Rows(0).Item("site_name")
        no_type_txt.Text = dt1.Rows(0).Item("no_type")
        insurance_date.Text = dt1.Rows(0).Item("insurance_date")
        model_txt.Text = dt1.Rows(0).Item("model")
        type_no_txt.Text = dt2.Rows(0).Item("car2_name")
        shase_no_txt.Text = dt1.Rows(0).Item("shase_no")
        car2_owner_txt.Text = dt1.Rows(0).Item("car2_owner")
        machine_no_txt.Text = dt1.Rows(0).Item("machine_no")
        insurance_no_txt.Text = dt1.Rows(0).Item("insurance_no")
        driver_txt.Text = dt1.Rows(0).Item("driver")
        car2_no_txt.Text = dt1.Rows(0).Item("car2_no")
        car2_no_txt.Text = dt1.Rows(0).Item("car2_no")
        privet_no_txt.Text = dt1.Rows(0).Item("privet_no")
        reg_no_txt.Text = dt1.Rows(0).Item("reg_no")
        'insudatstar
        insudatstar.Text = dt1.Rows(0).Item("insudatstard")
        If dt1.Rows(0).Item("MARKET_COS") Is DBNull.Value Then
            MARKET_COSTXT.Text = ""
        Else
            MARKET_COSTXT.Text = dt1.Rows(0).Item("MARKET_COS")
        End If
        If dt1.Rows(0).Item("NOTE") Is DBNull.Value Then
            NOTETXT.Text = ""
        Else
            NOTETXT.Text = dt1.Rows(0).Item("NOTE")
        End If
        '***********************************
        'car2_name_txt.Text = dt.Rows(0).Item("car2_name")
        Try

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If dd = 1 Then
            dell.Enabled = False
            save.Visible = False
            Button1.Enabled = True
        End If
        Con.Close()
    End Sub

    Private Sub dell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dell.Click
        '****************************             ********************************
        'bt_dell(edit, add1, save, search, dell)
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim str As String
        str = MsgBox("·ﬁœ  —Ìœ Õ–› «·”Ã· «·–Ï ÌÕ„· «·—ﬁ„  :-" + "  " + car2_no_txt.Text, MsgBoxStyle.YesNo + MsgBoxStyle.Information, " ‰»ÌÂ")
        If str = vbYes Then
            Dim cmd3 As New SqlClient.SqlCommand("DELETE FROM car2_data WHERE car2_no =  '" & car2_no_txt.Text & "'", Con)

            Dim da3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd3)
            cmd3.ExecuteNonQuery()
        Else
            Exit Sub
        End If
        Try
            bt_add1(edit, add1, save, search, dell)
            MsgBox("·ﬁœ  „ Õ–› «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
        '************************************************************************************
        device_no_txt.Text = ""
        car2_no_txt.Text = ""
        model_txt.Text = ""
        type_no_txt.Text = ""
        no_type_txt.Text = ""
        shase_no_txt.Text = ""
        machine_no_txt.Text = ""
        car2_owner_txt.Text = ""
        insurance_date.Text = ""
        insurance_no_txt.Text = ""
        driver_txt.Text = ""
        privet_no_txt.Text = ""
        reg_no_txt.Text = ""
        Call clear()
        If dd = 1 Then
            dell.Enabled = False
            save.Visible = False

        End If
    End Sub
    Private Sub car2data_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If dd = 1 Then
            search.Visible = False
            dell.Enabled = False
            'save.Visible = False
            Button1.Enabled = False
            save.Visible = False

        End If
        save.Visible = True
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        bt_low(edit, add1, save, search, dell)
        If dd = 1 Then
            dell.Enabled = False
            'save.Visible = False
            Button1.Enabled = False
            save.Visible = False
        End If
        'Dim df As New SECURITY
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
        Try
            Dim DS As New DataSet
            Dim str As String = "SELECT DISTINCT car2_name FROM car2_type"
            Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
            ADP.Fill(DS)
            Dim i As Integer
            For i = 0 To DS.Tables(0).Rows.Count - 1
                Me.type_no_txt.Items.Add(DS.Tables(0).Rows(i).Item(0))
            Next
            ADP.Dispose()
        Catch er As Exception
            MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√
        End Try
        '*****************************************************
        Try
            Dim DS As New DataSet
            Dim str As String = "SELECT DISTINCT site_name FROM sites"
            Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
            ADP.Fill(DS)
            Dim i As Integer
            For i = 0 To DS.Tables(0).Rows.Count - 1
                Me.device_no_txt.Items.Add(DS.Tables(0).Rows(i).Item(0))
            Next
            ADP.Dispose()
        Catch er As Exception
            MessageBox.Show(er.Message) '«ŸÂ«— —”«·… ›Ï Õ«·… ÕœÊÀ Œÿ√
        End Try


        '**************************

        'Con.Close()
    End Sub
    Public Sub sec2()

    End Sub

    Private Sub printre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm1 As New princar2data
        'Me.Hide()
        frm1.ShowDialog()
        'Dim we As princar2data
        'Me.Hide()
        'we.ShowDialog()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim we As princar2data
        Me.Hide()
        we.ShowDialog()

    End Sub


    Private Sub save_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If Trim(privet_no_txt.Text) = "" Or Trim(reg_no_txt.Text) = "" Or Trim(no_type_txt.Text) = "" Or Trim(insurance_date.Text) = "" Or Trim(model_txt.Text) = "" Or Trim(type_no_txt.Text) = "" Or Trim(shase_no_txt.Text) = "" Or Trim(car2_owner_txt.Text) = "" Or Trim(machine_no_txt.Text) = "" Or Trim(car2_owner_txt.Text) = "" Or Trim(driver_txt.Text) = "" Or Trim(insurance_no_txt.Text) = "" Or Trim(insurance_no_txt.Text) = "" Or Trim(insurance_no_txt.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        If Con.State = ConnectionState.Open = True Then
            Con.Close()
        End If
        '******************************************
        Con.Open()
        Dim Cmd1 As New SqlClient.SqlCommand("SELECT * FROM car2_DATA where car2_NO='" & car2_no_txt.Text & "'", Con)
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd1)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count >= 1 Then
            MsgBox(" ÊÃœ ⁄—»…  Õ„· «·—ﬁ„ «·„œŒ· :-" + "  " + car2_no_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            Exit Sub
        End If
        '*******************************************
        bt_save(edit, add1, save, search, dell)
        Dim DS As New DataSet
        Dim t As DataTable
        Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM car2_type where car2_name='" & type_no_txt.Text & "'", Con)
        Dim dr As SqlClient.SqlDataReader = cmd2.ExecuteReader()
        dr.Read()
        Dim x As Integer = dr.Item("type_no")
        dr.Close()
        '****************************************************************************
        Dim DS4 As New DataSet
        Dim t4 As DataTable
        Dim cmd4 As New SqlClient.SqlCommand("SELECT * FROM sites where site_name='" & device_no_txt.Text & "'", Con)
        Dim dr4 As SqlClient.SqlDataReader = cmd4.ExecuteReader()
        dr4.Read()
        Dim x4 As Integer = dr4.Item("site_id")
        dr4.Close()
        'NOTETXT

        '************************
        Dim cmdString As String = "INSERT INTO car2_data " + _
                                  "(insudatstard,NOTE,MARKET_COS,privet_no,reg_no,site_id,car2_no,model,type_no,no_type,shase_no,machine_no,car2_owner,insurance_date,insurance_no,driver) " + _
                                  "VALUES('" & insudatstar.Text & "','" & NOTETXT.Text.Trim & "','" & MARKET_COSTXT.Text.Trim & "','" & privet_no_txt.Text.Trim & "','" & reg_no_txt.Text.Trim & "','" & x4 & "','" & car2_no_txt.Text & "','" & model_txt.Text & "','" & x & "','" & no_type_txt.Text & "','" & shase_no_txt.Text & "' ,'" & machine_no_txt.Text & "' ,'" & car2_owner_txt.Text & "','" & insurance_date.Text & "','" & insurance_no_txt.Text & "','" & driver_txt.Text & "')"
        Dim cmd3 As New SqlClient.SqlCommand(cmdString, Con)
        cmd3.ExecuteNonQuery()
        model_txt.Text = ""
        type_no_txt.Text = ""
        no_type_txt.Text = ""
        shase_no_txt.Text = ""
        machine_no_txt.Text = ""
        car2_owner_txt.Text = ""
        insurance_date.Text = ""
        insurance_no_txt.Text = ""
        driver_txt.Text = ""
        car2_no_txt.Text = ""
        device_no_txt.Text = ""
        device_no_txt.Text = ""
        reg_no_txt.Text = ""
        privet_no_txt.Text = ""
        Call clear()
        Try
            'cmd.ExecuteNonQuery()
            MsgBox("·ﬁœ  „ Õ›Ÿ «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Con.Close()

    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        If dd = 1 Then
            dell.Enabled = False
            save.Visible = False

        End If
        bt_edit(edit, add1, save, search, dell)
        If Trim(no_type_txt.Text) = "" Or Trim(insurance_date.Text) = "" Or Trim(model_txt.Text) = "" Or Trim(type_no_txt.Text) = "" Or Trim(shase_no_txt.Text) = "" Or Trim(car2_owner_txt.Text) = "" Or Trim(machine_no_txt.Text) = "" Or Trim(car2_owner_txt.Text) = "" Or Trim(driver_txt.Text) = "" Or Trim(insurance_no_txt.Text) = "" Or Trim(insurance_no_txt.Text) = "" Or Trim(insurance_no_txt.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim cmd1 As New SqlClient.SqlCommand("SELECT * FROM car2_type where car2_name='" & type_no_txt.Text & "'", Con)
        'Dim cmd As New SqlCommand("SELECT * FROM car2_type where car2_name='" & type_no_txt.Value & "'")
        Dim dr As SqlClient.SqlDataReader = cmd1.ExecuteReader()
        dr.Read()
        Dim x As Integer = dr.Item("type_no")
        dr.Close()
        'x = type_no_txt.Value
        '**********************************************************************
        Dim DS4 As New DataSet
        Dim t4 As DataTable
        Dim cmd4 As New SqlClient.SqlCommand("SELECT * FROM sites where site_name='" & device_no_txt.Text & "'", Con)
        Dim dr4 As SqlClient.SqlDataReader = cmd4.ExecuteReader()
        dr4.Read()
        Dim x4 As Integer = dr4.Item("site_id")
        dr4.Close()
        '********************************************************************
        Dim cmdString As String = "UPDATE car2_data " + _
                                    "SET insudatstard='" & insudatstar.Text & "',theweel = '" & dd & "',model = '" & model_txt.Text & "',MARKET_COS= '" & MARKET_COSTXT.Text.Trim & "',NOTE='" & NOTETXT.Text.Trim & "', reg_no='" & reg_no_txt.Text.Trim & "',privet_no='" & privet_no_txt.Text.Trim & "',site_id ='" & x4 & "', car2_no='" & car2_no_txt.Text & "',insurance_date='" & insurance_date.Text & "',type_no='" & x & "', shase_no='" & shase_no_txt.Text & "',car2_owner='" & car2_owner_txt.Text & "',machine_no='" & machine_no_txt.Text & "',insurance_no='" & insurance_no_txt.Text & "', driver= '" & driver_txt.Text & "', no_type='" & no_type_txt.Text & "' " + _
                                    "WHERE car2_no = '" & car2_no_txt.Text & "'"
        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        'MsgBox("well22")
        cmd.ExecuteNonQuery()
        Try
            'cmd.ExecuteNonQuery()
            MsgBox("·ﬁœ  „  ⁄œÌ· «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Con.Close()
    End Sub

    Private Sub type_no_txt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles type_no_txt.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        dell.Enabled = False
        search.Enabled = True
        'edit.Enabled = Not edit.Enabled
        save.Enabled = False
        edit.Enabled = False
        add1.Enabled = True
        If Trim(insurance_date.Text) = "" Or Trim(NOTETXT.Text) = "" Or Trim(car2_no_txt.Text) = "" Then
            MsgBox("«ﬂ„· «œŒ«· «·»Ì«‰« ")
            Exit Sub
        End If
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim cmd1 As New SqlClient.SqlCommand("SELECT * FROM car2_type where car2_name='" & type_no_txt.Text & "'", Con)
        'Dim cmd As New SqlCommand("SELECT * FROM car2_type where car2_name='" & type_no_txt.Value & "'")
        Dim dr As SqlClient.SqlDataReader = cmd1.ExecuteReader()
        dr.Read()
        Dim x As Integer = dr.Item("type_no")
        dr.Close()
        'x = type_no_txt.Value
        '**********************************************************************
        Dim DS4 As New DataSet
        Dim t4 As DataTable
        Dim cmd4 As New SqlClient.SqlCommand("SELECT * FROM sites where site_name='" & device_no_txt.Text & "'", Con)
        Dim dr4 As SqlClient.SqlDataReader = cmd4.ExecuteReader()
        dr4.Read()
        Dim x4 As Integer = dr4.Item("site_id")
        dr4.Close()
        '********************************************************************
        Dim cmdString As String = "UPDATE car2_data " + _
                                    "SET theweel = '" & dd & "',model = '" & model_txt.Text & "',MARKET_COS= '" & MARKET_COSTXT.Text.Trim & "',date_th='" & insurance_date.Text & "',NOTE='" & NOTETXT.Text.Trim & "', reg_no='" & reg_no_txt.Text.Trim & "',privet_no='" & privet_no_txt.Text.Trim & "',site_id ='" & x4 & "', car2_no='" & car2_no_txt.Text & "',insurance_date='" & insurance_date.Text & "',type_no='" & x & "', shase_no='" & shase_no_txt.Text & "',car2_owner='" & car2_owner_txt.Text & "',machine_no='" & machine_no_txt.Text & "',insurance_no='" & insurance_no_txt.Text & "', driver= '" & driver_txt.Text & "', no_type='" & no_type_txt.Text & "' " + _
                                    "WHERE car2_no = '" & car2_no_txt.Text & "'"
        Dim cmd As New SqlClient.SqlCommand(cmdString, Con)
        'MsgBox("well22")
        cmd.ExecuteNonQuery()
        Button1.Enabled = False
        Con.Close()
        Try
            'cmd.ExecuteNonQuery()
            MsgBox("·ﬁœ  „  ⁄œÌ· «·”Ã· »‰Ã«Õ", MsgBoxStyle.Information, " ‰»ÌÂ")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub search2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search2.Click
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Dim dt1 As New DataTable
        Dim dt5 As New DataTable
        Dim dt2 As New DataTable
        'Dim dt2 As New DataTable
        Dim message, title, defaultValue, m, x, txt, txt2 As String
        message = "«œŒ· —ﬁ„ «·⁄—»…"
        defaultValue = 0
        title = "»ÕÀ"
        car2_no_txt.Text = InputBox(message, title, defaultValue, MsgBoxStyle.OKOnly)
        If Trim(car2_no_txt.Text) = "" Then
            MsgBox("ÌÃ» «Œ Ì«— «·—ﬁ„ «·„ ”·”· «Ê·«")
            Exit Sub
        End If
        '**********************************************************
        Dim Cmd1 As New SqlClient.SqlCommand("SELECT * FROM car2_data  where    car2_no='" & car2_no_txt.Text.Trim & "'", Con)
        'With Cmd1
        '    .CommandType = CommandType.StoredProcedure
        '    .Parameters.Add("@icar2_no", car2_no_txt.Text)
        'End With
        Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd1)
        da1.Fill(dt1)
        Cmd1.ExecuteNonQuery()
        '***********************************************************************
        If dt1.Rows.Count < 1 Then
            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «·—ﬁ„  :-" + "  " + car2_no_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            Call clear()
            car2_no_txt.Text = ""
            Exit Sub
        End If
        txt2 = dt1.Rows(0).Item("site_id")
        txt = dt1.Rows(0).Item("type_no")
        '****************************************************************************
        Dim Cmd2 As New SqlClient.SqlCommand("SELECT * FROM car2_type where type_no='" & txt & "'", Con)
        Dim da2 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd2)
        da2.Fill(dt2)
        Cmd2.ExecuteNonQuery()
        If dt2.Rows.Count < 1 Then
            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„·2 «·—ﬁ„  :-" + "  " + car2_no_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            Exit Sub
        End If
        edit.Enabled = True
        '*****************************************************************
        '"SET site_name = '" & site_name_txt.Text & "' " + _
        '"WHERE site_id = '" & site_id_txt.Text & "'"
        Dim Cmd5 As New SqlClient.SqlCommand("SELECT * FROM sites where site_id='" & txt2 & "'", Con)
        Dim da5 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(Cmd5)
        da5.Fill(dt5)
        Cmd5.ExecuteNonQuery()
        If dt5.Rows.Count < 1 Then
            MsgBox("·«ÌÊÃœ ”Ã· ÌÕ„· «·—ﬁ„  :-" + "  " + device_no_txt.Text, MsgBoxStyle.Information, " ‰»ÌÂ")
            Exit Sub
        End If
        '*********************************************************************
        bt_search(edit, add1, save, search, dell)
        device_no_txt.Text = dt5.Rows(0).Item("site_name")
        no_type_txt.Text = dt1.Rows(0).Item("no_type")
        insurance_date.Text = dt1.Rows(0).Item("insurance_date")
        model_txt.Text = dt1.Rows(0).Item("model")
        type_no_txt.Text = dt2.Rows(0).Item("car2_name")
        shase_no_txt.Text = dt1.Rows(0).Item("shase_no")
        car2_owner_txt.Text = dt1.Rows(0).Item("car2_owner")
        machine_no_txt.Text = dt1.Rows(0).Item("machine_no")
        insurance_no_txt.Text = dt1.Rows(0).Item("insurance_no")
        driver_txt.Text = dt1.Rows(0).Item("driver")
        car2_no_txt.Text = dt1.Rows(0).Item("car2_no")
        car2_no_txt.Text = dt1.Rows(0).Item("car2_no")
        privet_no_txt.Text = dt1.Rows(0).Item("privet_no")
        reg_no_txt.Text = dt1.Rows(0).Item("reg_no")
        'insudatstar
        insudatstar.Text = dt1.Rows(0).Item("insudatstard")
        If dt1.Rows(0).Item("MARKET_COS") Is DBNull.Value Then
            MARKET_COSTXT.Text = ""
        Else
            MARKET_COSTXT.Text = dt1.Rows(0).Item("MARKET_COS")
        End If
        If dt1.Rows(0).Item("NOTE") Is DBNull.Value Then
            NOTETXT.Text = ""
        Else
            NOTETXT.Text = dt1.Rows(0).Item("NOTE")
        End If
        '***********************************
        'car2_name_txt.Text = dt.Rows(0).Item("car2_name")
        Try

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If dd = 1 Then
            dell.Enabled = False
            save.Visible = False
            Button1.Enabled = True
        End If
        Con.Close()
    End Sub
End Class
