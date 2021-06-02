Public Class MAIN1
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
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MAIN1))
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem43 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.MenuItem40 = New System.Windows.Forms.MenuItem
        Me.MenuItem51 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem52 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New System.Windows.Forms.MenuItem
        Me.MenuItem42 = New System.Windows.Forms.MenuItem
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem47 = New System.Windows.Forms.MenuItem
        Me.MenuItem41 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem54 = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'ContextMenu1
        '
        Me.ContextMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem16, Me.MenuItem3, Me.MenuItem2, Me.MenuItem11, Me.MenuItem15})
        Me.MainMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem28, Me.MenuItem22})
        Me.MenuItem1.Text = "«·»Ì«‰«  «·«”«”Ì…"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem30, Me.MenuItem48, Me.MenuItem29, Me.MenuItem49, Me.MenuItem31})
        Me.MenuItem5.Text = "»Ì«‰«  «·⁄—»« "
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 0
        Me.MenuItem30.Text = "≈÷«›… »Ì«‰«  ⁄—»…"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 1
        Me.MenuItem48.Text = "-"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 2
        Me.MenuItem29.Text = " Œ’Ì’ ⁄—»… «Ê ”«∆ﬁ"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 3
        Me.MenuItem49.Text = "-"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 4
        Me.MenuItem31.Text = "⁄„· «Ã—«¡ ··⁄—»…"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.Text = "√‰Ê«⁄ «·⁄—»« "
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 3
        Me.MenuItem28.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 4
        Me.MenuItem22.Text = "«·«ÃÂ“… «·ﬁ÷«∆Ì…"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 1
        Me.MenuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem26, Me.MenuItem55, Me.MenuItem54, Me.MenuItem43, Me.MenuItem32, Me.MenuItem44, Me.MenuItem38, Me.MenuItem45, Me.MenuItem37, Me.MenuItem46, Me.MenuItem42, Me.MenuItem53})
        Me.MenuItem16.Text = "«· ﬁ«—Ì‹‹—"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 0
        Me.MenuItem26.Text = "«·’Ì‹‹‹‹‹‹«‰…"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 3
        Me.MenuItem43.Text = "-"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 4
        Me.MenuItem32.Text = "«‰Ê«⁄ «·⁄—»« "
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 5
        Me.MenuItem44.Text = "-"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 6
        Me.MenuItem38.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem39, Me.MenuItem50, Me.MenuItem40, Me.MenuItem51, Me.MenuItem35, Me.MenuItem52, Me.MenuItem36})
        Me.MenuItem38.Text = "»Ì«‰‹‹‹«  «·⁄‹‹—»‹« "
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 0
        Me.MenuItem39.Text = "»Ì«‰«  «·⁄—»«  „ﬂ „·…"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 1
        Me.MenuItem50.Text = "-"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 2
        Me.MenuItem40.Text = "»Ì«‰«  ⁄—»… „Õœœ…"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 3
        Me.MenuItem51.Text = "-"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 4
        Me.MenuItem35.Text = "≈Ã‹‹‹—«¡«  «·⁄—»‹‹‹‹‹‹‹« "
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 5
        Me.MenuItem52.Text = "-"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 6
        Me.MenuItem36.Text = "”«∆ﬁ ”«»ﬁ «Ê  Œ’Ì’"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 7
        Me.MenuItem45.Text = "-"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 8
        Me.MenuItem37.Text = "ﬂ—  ’Ì«‰… «·⁄—»« "
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 9
        Me.MenuItem46.Text = "-"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 10
        Me.MenuItem42.Text = "„·‹‹‹‹‹‹› «· ”ÊÌ…"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 11
        Me.MenuItem53.Text = "«·⁄—»«  «· Ï ﬁ«—»  «„Ì‰Â«"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8, Me.MenuItem9})
        Me.MenuItem3.Text = "«·›« Ê—…"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 0
        Me.MenuItem8.Text = "»Ì««‰«  «·›« Ê—…"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 1
        Me.MenuItem9.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem47, Me.MenuItem41})
        Me.MenuItem2.Text = "«·’Ì«‰…"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "ÿ·» «·’Ì«‰…"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 1
        Me.MenuItem47.Text = "-"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 2
        Me.MenuItem41.Text = "„·› «· ”ÊÌ…"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 4
        Me.MenuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem12, Me.MenuItem14, Me.MenuItem23, Me.MenuItem27, Me.MenuItem13})
        Me.MenuItem11.Text = "„·›"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 0
        Me.MenuItem12.Text = "ÕÊ· «·»—‰«„Ã"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Text = "-"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 2
        Me.MenuItem23.Text = "«¯·… Õ«”»…"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 3
        Me.MenuItem27.Text = "-"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 4
        Me.MenuItem13.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.MenuItem13.Text = "≈‰Â‹‹‹‹‹‹«¡"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 5
        Me.MenuItem15.Text = ""
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = -1
        Me.MenuItem17.Text = "«·’Ì‹‹‹‹‹‹‹‹«‰‹‹‹‹‹…"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = -1
        Me.MenuItem21.Text = "-"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = -1
        Me.MenuItem20.Text = "√‰‹‹‹‹‹Ê«⁄ «·⁄‹‹—»« "
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = -1
        Me.MenuItem18.Text = "-"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = -1
        Me.MenuItem24.Text = "»Ì«‰«  «·⁄—»«  „ﬂ „·…"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = -1
        Me.MenuItem19.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = -1
        Me.MenuItem10.Text = "»Ì«‰«  «·⁄—»«  „Œ’’…"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = -1
        Me.MenuItem25.Text = "ﬂ—  ’Ì«‰… «·⁄—»« "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(152, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(456, 416)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = -1
        Me.MenuItem33.Text = "≈Ã—«¡«  «·⁄—»‹‹‹‹‹‹‹‹‹‹‹« "
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = -1
        Me.MenuItem34.Text = "«· Œ’Ì’ «Ê «·”«∆ﬁ «·”«»ﬁ"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 2
        Me.MenuItem54.Text = "«¯Œ—  «—ÌŒ ·’—› «·«”»Ì—« "
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 1
        Me.MenuItem55.Text = "-"
        '
        'MAIN1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(744, 537)
        Me.Controls.Add(Me.PictureBox1)
        Me.Menu = Me.MainMenu1
        Me.Name = "MAIN1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "«·—∆Ì”Ì…"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
       
    End Sub

    Private Sub MAIN1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If

        Con.Open()
        Dim issa As String
        Dim DS3 As New DataSet
        Dim str As String = "Select DATEDIFF(day,insurance_date,'" & DateValue(Date.Now) & "') from car2_data where theweel <>1 and DATEDIFF(day, insurance_date,'" & DateValue(Date.Now) & "')< 5 "
        Dim ADP As New SqlClient.SqlDataAdapter(str, Con)
        ADP.Fill(DS3)
        Dim i As Integer
        If DS3.Tables(0).Rows.Count >= 1 Then
            MsgBox("  ⁄›Ê« Â‰«·ﬂ »⁄÷ «·⁄—»«  ﬁœ ﬁ«—»  «—ÌŒ «‰ Â«¡  √„Ì‰Â« " + "  " + issa, MsgBoxStyle.Information, " ‰»ÌÂ")
        End If
        Con.Close()
        'oconnection.Open()
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Try
            End
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Try
            Dim F0 As New car2type
            F0.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Try
            Dim Fw As New invoicecar2
            Fw.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Try
            Dim Fw2 As New maintenance
            Fw2.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Try
            Dim fr As New repcar2_type
            fr.ShowDialog()

        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try

    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim fr As New parts
            fr.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Try
            Dim lRetVal As Double
            lRetVal = Shell("CALC", vbNormalFocus)
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Try
            Dim fr34 As New princar2data
            'car2datat = "car2datamk"
            fr34.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click

        Try
            Dim fr341 As New reportmantenance
            fr341.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub
    Private Sub MenuItem22_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        Try
            Dim frr341 As New depet
            'car2datat = "repcar2datareco"
            frr341.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        Try
            Dim frr341 As New car2datat
            'car2datat = "repcar2datareco"
            frr341.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        Try
            Dim frr3413 As New mencar2d2
            frr3413.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        Try
            Dim ddd As New changename1
            ddd.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        Try

            dd = 0
            Dim F As New car2data
            F.search2.Visible = False
            F.Button1.Visible = False
            F.ShowDialog()
            F.save.Visible = True

        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        Try

            dd = 1
            Dim Fw1 As New car2data
            Fw1.Label10.Text = "«· ‹‹‹‹‹«—ÌŒ"
            Fw1.machine_no_txt.Enabled = False
            Fw1.save.Visible = False
            Fw1.no_type_txt.Enabled = False
            'Fw1.insurance_date.Enabled = False
            Fw1.save.Visible = True
            Fw1.model_txt.Enabled = False
            Fw1.type_no_txt.Enabled = False
            Fw1.shase_no_txt.Enabled = False
            Fw1.car2_owner_txt.Enabled = False
            Fw1.machine_no_txt.Enabled = False
            Fw1.insurance_no_txt.Enabled = False
            Fw1.driver_txt.Enabled = False
            Fw1.insudatstar.Enabled = False
            Fw1.search.Enabled = False
            Fw1.privet_no_txt.Enabled = False
            Fw1.reg_no_txt.Enabled = False
            Fw1.car2_no_txt.Enabled = False
            Fw1.MARKET_COSTXT.Enabled = False
            Fw1.save.Enabled = False
            Fw1.dell.Enabled = False
            Fw1.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        Try
            Dim fr341 As New reportmantenance
            fr341.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Try
            Dim fr As New repcar2_type
            fr.ShowDialog()

        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try

    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click

    End Sub

    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        Try
            Dim frr341 As New car2datat
            'car2datat = "repcar2datareco"
            frr341.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        Try
            Dim fr34 As New princar2data
            'car2datat = "car2datamk"
            fr34.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        Try
            Dim frr3413 As New mencar2d2
            frr3413.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem35_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        Try
            Dim fr34 As New estbad
            'car2datat = "car2datamk"
            fr34.ShowDialog()

            'repcar2datareco.Label6.text = "dfgfg"
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        Try
            Dim fr342 As New changedriver
            'car2datat = "car2datamk"
            fr342.ShowDialog()
            'repcar2datareco.Label6.text = "dfgfg"
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub
    Private Sub clear()

    End Sub
    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        Try
            Dim Fw2 As New taswia
            Fw2.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click

        Try
            Dim Fw2d As New reptswia2
            Fw2d.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        Try
            Dim Fw2d As New tamandate
            Fw2d.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try


    End Sub

    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click


        Try
            Dim Fw2d1 As New partrep
            Fw2d1.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try


    End Sub
End Class
