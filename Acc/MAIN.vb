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
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem83 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem84 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem85 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem86 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MAIN1))
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem40 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem41 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem42 = New System.Windows.Forms.MenuItem
        Me.MenuItem56 = New System.Windows.Forms.MenuItem
        Me.MenuItem67 = New System.Windows.Forms.MenuItem
        Me.MenuItem68 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem43 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New System.Windows.Forms.MenuItem
        Me.MenuItem47 = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        Me.MenuItem63 = New System.Windows.Forms.MenuItem
        Me.MenuItem62 = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem65 = New System.Windows.Forms.MenuItem
        Me.MenuItem64 = New System.Windows.Forms.MenuItem
        Me.MenuItem76 = New System.Windows.Forms.MenuItem
        Me.MenuItem77 = New System.Windows.Forms.MenuItem
        Me.MenuItem78 = New System.Windows.Forms.MenuItem
        Me.MenuItem86 = New System.Windows.Forms.MenuItem
        Me.MenuItem87 = New System.Windows.Forms.MenuItem
        Me.MenuItem79 = New System.Windows.Forms.MenuItem
        Me.MenuItem81 = New System.Windows.Forms.MenuItem
        Me.MenuItem80 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.MenuItem52 = New System.Windows.Forms.MenuItem
        Me.MenuItem54 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.MenuItem51 = New System.Windows.Forms.MenuItem
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
        Me.MenuItem58 = New System.Windows.Forms.MenuItem
        Me.MenuItem57 = New System.Windows.Forms.MenuItem
        Me.MenuItem60 = New System.Windows.Forms.MenuItem
        Me.MenuItem59 = New System.Windows.Forms.MenuItem
        Me.MenuItem61 = New System.Windows.Forms.MenuItem
        Me.MenuItem88 = New System.Windows.Forms.MenuItem
        Me.MenuItem66 = New System.Windows.Forms.MenuItem
        Me.MenuItem70 = New System.Windows.Forms.MenuItem
        Me.MenuItem71 = New System.Windows.Forms.MenuItem
        Me.MenuItem72 = New System.Windows.Forms.MenuItem
        Me.MenuItem73 = New System.Windows.Forms.MenuItem
        Me.MenuItem83 = New System.Windows.Forms.MenuItem
        Me.MenuItem82 = New System.Windows.Forms.MenuItem
        Me.MenuItem74 = New System.Windows.Forms.MenuItem
        Me.MenuItem75 = New System.Windows.Forms.MenuItem
        Me.MenuItem84 = New System.Windows.Forms.MenuItem
        Me.MenuItem89 = New System.Windows.Forms.MenuItem
        Me.MenuItem90 = New System.Windows.Forms.MenuItem
        Me.MenuItem85 = New System.Windows.Forms.MenuItem
        Me.MenuItem69 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenu1
        '
        Me.ContextMenu1.RightToLeft = CType(resources.GetObject("ContextMenu1.RightToLeft"), System.Windows.Forms.RightToLeft)
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem11})
        Me.MainMenu1.RightToLeft = CType(resources.GetObject("MainMenu1.RightToLeft"), System.Windows.Forms.RightToLeft)
        '
        'MenuItem1
        '
        Me.MenuItem1.Enabled = CType(resources.GetObject("MenuItem1.Enabled"), Boolean)
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem40, Me.MenuItem37, Me.MenuItem15, Me.MenuItem6, Me.MenuItem32, Me.MenuItem44, Me.MenuItem17, Me.MenuItem30, Me.MenuItem31, Me.MenuItem33, Me.MenuItem2, Me.MenuItem50, Me.MenuItem52, Me.MenuItem54, Me.MenuItem34, Me.MenuItem4, Me.MenuItem16, Me.MenuItem69})
        Me.MenuItem1.Shortcut = CType(resources.GetObject("MenuItem1.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem1.ShowShortcut = CType(resources.GetObject("MenuItem1.ShowShortcut"), Boolean)
        Me.MenuItem1.Text = resources.GetString("MenuItem1.Text")
        Me.MenuItem1.Visible = CType(resources.GetObject("MenuItem1.Visible"), Boolean)
        '
        'MenuItem40
        '
        Me.MenuItem40.Enabled = CType(resources.GetObject("MenuItem40.Enabled"), Boolean)
        Me.MenuItem40.Index = 0
        Me.MenuItem40.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem22, Me.MenuItem41, Me.MenuItem10, Me.MenuItem45, Me.MenuItem7, Me.MenuItem28, Me.MenuItem5, Me.MenuItem35, Me.MenuItem36, Me.MenuItem42, Me.MenuItem56, Me.MenuItem67, Me.MenuItem68})
        Me.MenuItem40.Shortcut = CType(resources.GetObject("MenuItem40.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem40.ShowShortcut = CType(resources.GetObject("MenuItem40.ShowShortcut"), Boolean)
        Me.MenuItem40.Text = resources.GetString("MenuItem40.Text")
        Me.MenuItem40.Visible = CType(resources.GetObject("MenuItem40.Visible"), Boolean)
        '
        'MenuItem22
        '
        Me.MenuItem22.Enabled = CType(resources.GetObject("MenuItem22.Enabled"), Boolean)
        Me.MenuItem22.Index = 0
        Me.MenuItem22.Shortcut = CType(resources.GetObject("MenuItem22.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem22.ShowShortcut = CType(resources.GetObject("MenuItem22.ShowShortcut"), Boolean)
        Me.MenuItem22.Text = resources.GetString("MenuItem22.Text")
        Me.MenuItem22.Visible = CType(resources.GetObject("MenuItem22.Visible"), Boolean)
        '
        'MenuItem41
        '
        Me.MenuItem41.Enabled = CType(resources.GetObject("MenuItem41.Enabled"), Boolean)
        Me.MenuItem41.Index = 1
        Me.MenuItem41.Shortcut = CType(resources.GetObject("MenuItem41.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem41.ShowShortcut = CType(resources.GetObject("MenuItem41.ShowShortcut"), Boolean)
        Me.MenuItem41.Text = resources.GetString("MenuItem41.Text")
        Me.MenuItem41.Visible = CType(resources.GetObject("MenuItem41.Visible"), Boolean)
        '
        'MenuItem10
        '
        Me.MenuItem10.Enabled = CType(resources.GetObject("MenuItem10.Enabled"), Boolean)
        Me.MenuItem10.Index = 2
        Me.MenuItem10.Shortcut = CType(resources.GetObject("MenuItem10.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem10.ShowShortcut = CType(resources.GetObject("MenuItem10.ShowShortcut"), Boolean)
        Me.MenuItem10.Text = resources.GetString("MenuItem10.Text")
        Me.MenuItem10.Visible = CType(resources.GetObject("MenuItem10.Visible"), Boolean)
        '
        'MenuItem45
        '
        Me.MenuItem45.Enabled = CType(resources.GetObject("MenuItem45.Enabled"), Boolean)
        Me.MenuItem45.Index = 3
        Me.MenuItem45.Shortcut = CType(resources.GetObject("MenuItem45.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem45.ShowShortcut = CType(resources.GetObject("MenuItem45.ShowShortcut"), Boolean)
        Me.MenuItem45.Text = resources.GetString("MenuItem45.Text")
        Me.MenuItem45.Visible = CType(resources.GetObject("MenuItem45.Visible"), Boolean)
        '
        'MenuItem7
        '
        Me.MenuItem7.Enabled = CType(resources.GetObject("MenuItem7.Enabled"), Boolean)
        Me.MenuItem7.Index = 4
        Me.MenuItem7.Shortcut = CType(resources.GetObject("MenuItem7.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem7.ShowShortcut = CType(resources.GetObject("MenuItem7.ShowShortcut"), Boolean)
        Me.MenuItem7.Text = resources.GetString("MenuItem7.Text")
        Me.MenuItem7.Visible = CType(resources.GetObject("MenuItem7.Visible"), Boolean)
        '
        'MenuItem28
        '
        Me.MenuItem28.Enabled = CType(resources.GetObject("MenuItem28.Enabled"), Boolean)
        Me.MenuItem28.Index = 5
        Me.MenuItem28.Shortcut = CType(resources.GetObject("MenuItem28.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem28.ShowShortcut = CType(resources.GetObject("MenuItem28.ShowShortcut"), Boolean)
        Me.MenuItem28.Text = resources.GetString("MenuItem28.Text")
        Me.MenuItem28.Visible = CType(resources.GetObject("MenuItem28.Visible"), Boolean)
        '
        'MenuItem5
        '
        Me.MenuItem5.Enabled = CType(resources.GetObject("MenuItem5.Enabled"), Boolean)
        Me.MenuItem5.Index = 6
        Me.MenuItem5.Shortcut = CType(resources.GetObject("MenuItem5.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem5.ShowShortcut = CType(resources.GetObject("MenuItem5.ShowShortcut"), Boolean)
        Me.MenuItem5.Text = resources.GetString("MenuItem5.Text")
        Me.MenuItem5.Visible = CType(resources.GetObject("MenuItem5.Visible"), Boolean)
        '
        'MenuItem35
        '
        Me.MenuItem35.Enabled = CType(resources.GetObject("MenuItem35.Enabled"), Boolean)
        Me.MenuItem35.Index = 7
        Me.MenuItem35.Shortcut = CType(resources.GetObject("MenuItem35.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem35.ShowShortcut = CType(resources.GetObject("MenuItem35.ShowShortcut"), Boolean)
        Me.MenuItem35.Text = resources.GetString("MenuItem35.Text")
        Me.MenuItem35.Visible = CType(resources.GetObject("MenuItem35.Visible"), Boolean)
        '
        'MenuItem36
        '
        Me.MenuItem36.Enabled = CType(resources.GetObject("MenuItem36.Enabled"), Boolean)
        Me.MenuItem36.Index = 8
        Me.MenuItem36.Shortcut = CType(resources.GetObject("MenuItem36.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem36.ShowShortcut = CType(resources.GetObject("MenuItem36.ShowShortcut"), Boolean)
        Me.MenuItem36.Text = resources.GetString("MenuItem36.Text")
        Me.MenuItem36.Visible = CType(resources.GetObject("MenuItem36.Visible"), Boolean)
        '
        'MenuItem42
        '
        Me.MenuItem42.Enabled = CType(resources.GetObject("MenuItem42.Enabled"), Boolean)
        Me.MenuItem42.Index = 9
        Me.MenuItem42.Shortcut = CType(resources.GetObject("MenuItem42.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem42.ShowShortcut = CType(resources.GetObject("MenuItem42.ShowShortcut"), Boolean)
        Me.MenuItem42.Text = resources.GetString("MenuItem42.Text")
        Me.MenuItem42.Visible = CType(resources.GetObject("MenuItem42.Visible"), Boolean)
        '
        'MenuItem56
        '
        Me.MenuItem56.Enabled = CType(resources.GetObject("MenuItem56.Enabled"), Boolean)
        Me.MenuItem56.Index = 10
        Me.MenuItem56.Shortcut = CType(resources.GetObject("MenuItem56.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem56.ShowShortcut = CType(resources.GetObject("MenuItem56.ShowShortcut"), Boolean)
        Me.MenuItem56.Text = resources.GetString("MenuItem56.Text")
        Me.MenuItem56.Visible = CType(resources.GetObject("MenuItem56.Visible"), Boolean)
        '
        'MenuItem67
        '
        Me.MenuItem67.Enabled = CType(resources.GetObject("MenuItem67.Enabled"), Boolean)
        Me.MenuItem67.Index = 11
        Me.MenuItem67.Shortcut = CType(resources.GetObject("MenuItem67.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem67.ShowShortcut = CType(resources.GetObject("MenuItem67.ShowShortcut"), Boolean)
        Me.MenuItem67.Text = resources.GetString("MenuItem67.Text")
        Me.MenuItem67.Visible = CType(resources.GetObject("MenuItem67.Visible"), Boolean)
        '
        'MenuItem68
        '
        Me.MenuItem68.Enabled = CType(resources.GetObject("MenuItem68.Enabled"), Boolean)
        Me.MenuItem68.Index = 12
        Me.MenuItem68.Shortcut = CType(resources.GetObject("MenuItem68.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem68.ShowShortcut = CType(resources.GetObject("MenuItem68.ShowShortcut"), Boolean)
        Me.MenuItem68.Text = resources.GetString("MenuItem68.Text")
        Me.MenuItem68.Visible = CType(resources.GetObject("MenuItem68.Visible"), Boolean)
        '
        'MenuItem37
        '
        Me.MenuItem37.Enabled = CType(resources.GetObject("MenuItem37.Enabled"), Boolean)
        Me.MenuItem37.Index = 1
        Me.MenuItem37.Shortcut = CType(resources.GetObject("MenuItem37.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem37.ShowShortcut = CType(resources.GetObject("MenuItem37.ShowShortcut"), Boolean)
        Me.MenuItem37.Text = resources.GetString("MenuItem37.Text")
        Me.MenuItem37.Visible = CType(resources.GetObject("MenuItem37.Visible"), Boolean)
        '
        'MenuItem15
        '
        Me.MenuItem15.Enabled = CType(resources.GetObject("MenuItem15.Enabled"), Boolean)
        Me.MenuItem15.Index = 2
        Me.MenuItem15.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem18, Me.MenuItem19, Me.MenuItem20, Me.MenuItem21, Me.MenuItem24, Me.MenuItem25, Me.MenuItem26})
        Me.MenuItem15.Shortcut = CType(resources.GetObject("MenuItem15.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem15.ShowShortcut = CType(resources.GetObject("MenuItem15.ShowShortcut"), Boolean)
        Me.MenuItem15.Text = resources.GetString("MenuItem15.Text")
        Me.MenuItem15.Visible = CType(resources.GetObject("MenuItem15.Visible"), Boolean)
        '
        'MenuItem18
        '
        Me.MenuItem18.Enabled = CType(resources.GetObject("MenuItem18.Enabled"), Boolean)
        Me.MenuItem18.Index = 0
        Me.MenuItem18.Shortcut = CType(resources.GetObject("MenuItem18.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem18.ShowShortcut = CType(resources.GetObject("MenuItem18.ShowShortcut"), Boolean)
        Me.MenuItem18.Text = resources.GetString("MenuItem18.Text")
        Me.MenuItem18.Visible = CType(resources.GetObject("MenuItem18.Visible"), Boolean)
        '
        'MenuItem19
        '
        Me.MenuItem19.Enabled = CType(resources.GetObject("MenuItem19.Enabled"), Boolean)
        Me.MenuItem19.Index = 1
        Me.MenuItem19.Shortcut = CType(resources.GetObject("MenuItem19.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem19.ShowShortcut = CType(resources.GetObject("MenuItem19.ShowShortcut"), Boolean)
        Me.MenuItem19.Text = resources.GetString("MenuItem19.Text")
        Me.MenuItem19.Visible = CType(resources.GetObject("MenuItem19.Visible"), Boolean)
        '
        'MenuItem20
        '
        Me.MenuItem20.Enabled = CType(resources.GetObject("MenuItem20.Enabled"), Boolean)
        Me.MenuItem20.Index = 2
        Me.MenuItem20.Shortcut = CType(resources.GetObject("MenuItem20.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem20.ShowShortcut = CType(resources.GetObject("MenuItem20.ShowShortcut"), Boolean)
        Me.MenuItem20.Text = resources.GetString("MenuItem20.Text")
        Me.MenuItem20.Visible = CType(resources.GetObject("MenuItem20.Visible"), Boolean)
        '
        'MenuItem21
        '
        Me.MenuItem21.Enabled = CType(resources.GetObject("MenuItem21.Enabled"), Boolean)
        Me.MenuItem21.Index = 3
        Me.MenuItem21.Shortcut = CType(resources.GetObject("MenuItem21.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem21.ShowShortcut = CType(resources.GetObject("MenuItem21.ShowShortcut"), Boolean)
        Me.MenuItem21.Text = resources.GetString("MenuItem21.Text")
        Me.MenuItem21.Visible = CType(resources.GetObject("MenuItem21.Visible"), Boolean)
        '
        'MenuItem24
        '
        Me.MenuItem24.Enabled = CType(resources.GetObject("MenuItem24.Enabled"), Boolean)
        Me.MenuItem24.Index = 4
        Me.MenuItem24.Shortcut = CType(resources.GetObject("MenuItem24.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem24.ShowShortcut = CType(resources.GetObject("MenuItem24.ShowShortcut"), Boolean)
        Me.MenuItem24.Text = resources.GetString("MenuItem24.Text")
        Me.MenuItem24.Visible = CType(resources.GetObject("MenuItem24.Visible"), Boolean)
        '
        'MenuItem25
        '
        Me.MenuItem25.Enabled = CType(resources.GetObject("MenuItem25.Enabled"), Boolean)
        Me.MenuItem25.Index = 5
        Me.MenuItem25.Shortcut = CType(resources.GetObject("MenuItem25.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem25.ShowShortcut = CType(resources.GetObject("MenuItem25.ShowShortcut"), Boolean)
        Me.MenuItem25.Text = resources.GetString("MenuItem25.Text")
        Me.MenuItem25.Visible = CType(resources.GetObject("MenuItem25.Visible"), Boolean)
        '
        'MenuItem26
        '
        Me.MenuItem26.Enabled = CType(resources.GetObject("MenuItem26.Enabled"), Boolean)
        Me.MenuItem26.Index = 6
        Me.MenuItem26.Shortcut = CType(resources.GetObject("MenuItem26.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem26.ShowShortcut = CType(resources.GetObject("MenuItem26.ShowShortcut"), Boolean)
        Me.MenuItem26.Text = resources.GetString("MenuItem26.Text")
        Me.MenuItem26.Visible = CType(resources.GetObject("MenuItem26.Visible"), Boolean)
        '
        'MenuItem6
        '
        Me.MenuItem6.Enabled = CType(resources.GetObject("MenuItem6.Enabled"), Boolean)
        Me.MenuItem6.Index = 3
        Me.MenuItem6.Shortcut = CType(resources.GetObject("MenuItem6.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem6.ShowShortcut = CType(resources.GetObject("MenuItem6.ShowShortcut"), Boolean)
        Me.MenuItem6.Text = resources.GetString("MenuItem6.Text")
        Me.MenuItem6.Visible = CType(resources.GetObject("MenuItem6.Visible"), Boolean)
        '
        'MenuItem32
        '
        Me.MenuItem32.Enabled = CType(resources.GetObject("MenuItem32.Enabled"), Boolean)
        Me.MenuItem32.Index = 4
        Me.MenuItem32.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem43, Me.MenuItem3, Me.MenuItem46, Me.MenuItem47, Me.MenuItem48, Me.MenuItem8, Me.MenuItem9, Me.MenuItem55, Me.MenuItem63, Me.MenuItem62})
        Me.MenuItem32.Shortcut = CType(resources.GetObject("MenuItem32.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem32.ShowShortcut = CType(resources.GetObject("MenuItem32.ShowShortcut"), Boolean)
        Me.MenuItem32.Text = resources.GetString("MenuItem32.Text")
        Me.MenuItem32.Visible = CType(resources.GetObject("MenuItem32.Visible"), Boolean)
        '
        'MenuItem43
        '
        Me.MenuItem43.Enabled = CType(resources.GetObject("MenuItem43.Enabled"), Boolean)
        Me.MenuItem43.Index = 0
        Me.MenuItem43.Shortcut = CType(resources.GetObject("MenuItem43.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem43.ShowShortcut = CType(resources.GetObject("MenuItem43.ShowShortcut"), Boolean)
        Me.MenuItem43.Text = resources.GetString("MenuItem43.Text")
        Me.MenuItem43.Visible = CType(resources.GetObject("MenuItem43.Visible"), Boolean)
        '
        'MenuItem3
        '
        Me.MenuItem3.Enabled = CType(resources.GetObject("MenuItem3.Enabled"), Boolean)
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Shortcut = CType(resources.GetObject("MenuItem3.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem3.ShowShortcut = CType(resources.GetObject("MenuItem3.ShowShortcut"), Boolean)
        Me.MenuItem3.Text = resources.GetString("MenuItem3.Text")
        Me.MenuItem3.Visible = CType(resources.GetObject("MenuItem3.Visible"), Boolean)
        '
        'MenuItem46
        '
        Me.MenuItem46.Enabled = CType(resources.GetObject("MenuItem46.Enabled"), Boolean)
        Me.MenuItem46.Index = 2
        Me.MenuItem46.Shortcut = CType(resources.GetObject("MenuItem46.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem46.ShowShortcut = CType(resources.GetObject("MenuItem46.ShowShortcut"), Boolean)
        Me.MenuItem46.Text = resources.GetString("MenuItem46.Text")
        Me.MenuItem46.Visible = CType(resources.GetObject("MenuItem46.Visible"), Boolean)
        '
        'MenuItem47
        '
        Me.MenuItem47.Enabled = CType(resources.GetObject("MenuItem47.Enabled"), Boolean)
        Me.MenuItem47.Index = 3
        Me.MenuItem47.Shortcut = CType(resources.GetObject("MenuItem47.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem47.ShowShortcut = CType(resources.GetObject("MenuItem47.ShowShortcut"), Boolean)
        Me.MenuItem47.Text = resources.GetString("MenuItem47.Text")
        Me.MenuItem47.Visible = CType(resources.GetObject("MenuItem47.Visible"), Boolean)
        '
        'MenuItem48
        '
        Me.MenuItem48.Enabled = CType(resources.GetObject("MenuItem48.Enabled"), Boolean)
        Me.MenuItem48.Index = 4
        Me.MenuItem48.Shortcut = CType(resources.GetObject("MenuItem48.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem48.ShowShortcut = CType(resources.GetObject("MenuItem48.ShowShortcut"), Boolean)
        Me.MenuItem48.Text = resources.GetString("MenuItem48.Text")
        Me.MenuItem48.Visible = CType(resources.GetObject("MenuItem48.Visible"), Boolean)
        '
        'MenuItem8
        '
        Me.MenuItem8.Enabled = CType(resources.GetObject("MenuItem8.Enabled"), Boolean)
        Me.MenuItem8.Index = 5
        Me.MenuItem8.Shortcut = CType(resources.GetObject("MenuItem8.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem8.ShowShortcut = CType(resources.GetObject("MenuItem8.ShowShortcut"), Boolean)
        Me.MenuItem8.Text = resources.GetString("MenuItem8.Text")
        Me.MenuItem8.Visible = CType(resources.GetObject("MenuItem8.Visible"), Boolean)
        '
        'MenuItem9
        '
        Me.MenuItem9.Enabled = CType(resources.GetObject("MenuItem9.Enabled"), Boolean)
        Me.MenuItem9.Index = 6
        Me.MenuItem9.Shortcut = CType(resources.GetObject("MenuItem9.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem9.ShowShortcut = CType(resources.GetObject("MenuItem9.ShowShortcut"), Boolean)
        Me.MenuItem9.Text = resources.GetString("MenuItem9.Text")
        Me.MenuItem9.Visible = CType(resources.GetObject("MenuItem9.Visible"), Boolean)
        '
        'MenuItem55
        '
        Me.MenuItem55.Enabled = CType(resources.GetObject("MenuItem55.Enabled"), Boolean)
        Me.MenuItem55.Index = 7
        Me.MenuItem55.Shortcut = CType(resources.GetObject("MenuItem55.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem55.ShowShortcut = CType(resources.GetObject("MenuItem55.ShowShortcut"), Boolean)
        Me.MenuItem55.Text = resources.GetString("MenuItem55.Text")
        Me.MenuItem55.Visible = CType(resources.GetObject("MenuItem55.Visible"), Boolean)
        '
        'MenuItem63
        '
        Me.MenuItem63.Enabled = CType(resources.GetObject("MenuItem63.Enabled"), Boolean)
        Me.MenuItem63.Index = 8
        Me.MenuItem63.Shortcut = CType(resources.GetObject("MenuItem63.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem63.ShowShortcut = CType(resources.GetObject("MenuItem63.ShowShortcut"), Boolean)
        Me.MenuItem63.Text = resources.GetString("MenuItem63.Text")
        Me.MenuItem63.Visible = CType(resources.GetObject("MenuItem63.Visible"), Boolean)
        '
        'MenuItem62
        '
        Me.MenuItem62.Enabled = CType(resources.GetObject("MenuItem62.Enabled"), Boolean)
        Me.MenuItem62.Index = 9
        Me.MenuItem62.Shortcut = CType(resources.GetObject("MenuItem62.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem62.ShowShortcut = CType(resources.GetObject("MenuItem62.ShowShortcut"), Boolean)
        Me.MenuItem62.Text = resources.GetString("MenuItem62.Text")
        Me.MenuItem62.Visible = CType(resources.GetObject("MenuItem62.Visible"), Boolean)
        '
        'MenuItem44
        '
        Me.MenuItem44.Enabled = CType(resources.GetObject("MenuItem44.Enabled"), Boolean)
        Me.MenuItem44.Index = 5
        Me.MenuItem44.Shortcut = CType(resources.GetObject("MenuItem44.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem44.ShowShortcut = CType(resources.GetObject("MenuItem44.ShowShortcut"), Boolean)
        Me.MenuItem44.Text = resources.GetString("MenuItem44.Text")
        Me.MenuItem44.Visible = CType(resources.GetObject("MenuItem44.Visible"), Boolean)
        '
        'MenuItem17
        '
        Me.MenuItem17.Enabled = CType(resources.GetObject("MenuItem17.Enabled"), Boolean)
        Me.MenuItem17.Index = 6
        Me.MenuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem29, Me.MenuItem39, Me.MenuItem38, Me.MenuItem65, Me.MenuItem64, Me.MenuItem76, Me.MenuItem77, Me.MenuItem78, Me.MenuItem86, Me.MenuItem87, Me.MenuItem79, Me.MenuItem81, Me.MenuItem80})
        Me.MenuItem17.Shortcut = CType(resources.GetObject("MenuItem17.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem17.ShowShortcut = CType(resources.GetObject("MenuItem17.ShowShortcut"), Boolean)
        Me.MenuItem17.Text = resources.GetString("MenuItem17.Text")
        Me.MenuItem17.Visible = CType(resources.GetObject("MenuItem17.Visible"), Boolean)
        '
        'MenuItem29
        '
        Me.MenuItem29.Enabled = CType(resources.GetObject("MenuItem29.Enabled"), Boolean)
        Me.MenuItem29.Index = 0
        Me.MenuItem29.Shortcut = CType(resources.GetObject("MenuItem29.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem29.ShowShortcut = CType(resources.GetObject("MenuItem29.ShowShortcut"), Boolean)
        Me.MenuItem29.Text = resources.GetString("MenuItem29.Text")
        Me.MenuItem29.Visible = CType(resources.GetObject("MenuItem29.Visible"), Boolean)
        '
        'MenuItem39
        '
        Me.MenuItem39.Enabled = CType(resources.GetObject("MenuItem39.Enabled"), Boolean)
        Me.MenuItem39.Index = 1
        Me.MenuItem39.Shortcut = CType(resources.GetObject("MenuItem39.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem39.ShowShortcut = CType(resources.GetObject("MenuItem39.ShowShortcut"), Boolean)
        Me.MenuItem39.Text = resources.GetString("MenuItem39.Text")
        Me.MenuItem39.Visible = CType(resources.GetObject("MenuItem39.Visible"), Boolean)
        '
        'MenuItem38
        '
        Me.MenuItem38.Enabled = CType(resources.GetObject("MenuItem38.Enabled"), Boolean)
        Me.MenuItem38.Index = 2
        Me.MenuItem38.Shortcut = CType(resources.GetObject("MenuItem38.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem38.ShowShortcut = CType(resources.GetObject("MenuItem38.ShowShortcut"), Boolean)
        Me.MenuItem38.Text = resources.GetString("MenuItem38.Text")
        Me.MenuItem38.Visible = CType(resources.GetObject("MenuItem38.Visible"), Boolean)
        '
        'MenuItem65
        '
        Me.MenuItem65.Enabled = CType(resources.GetObject("MenuItem65.Enabled"), Boolean)
        Me.MenuItem65.Index = 3
        Me.MenuItem65.Shortcut = CType(resources.GetObject("MenuItem65.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem65.ShowShortcut = CType(resources.GetObject("MenuItem65.ShowShortcut"), Boolean)
        Me.MenuItem65.Text = resources.GetString("MenuItem65.Text")
        Me.MenuItem65.Visible = CType(resources.GetObject("MenuItem65.Visible"), Boolean)
        '
        'MenuItem64
        '
        Me.MenuItem64.Enabled = CType(resources.GetObject("MenuItem64.Enabled"), Boolean)
        Me.MenuItem64.Index = 4
        Me.MenuItem64.Shortcut = CType(resources.GetObject("MenuItem64.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem64.ShowShortcut = CType(resources.GetObject("MenuItem64.ShowShortcut"), Boolean)
        Me.MenuItem64.Text = resources.GetString("MenuItem64.Text")
        Me.MenuItem64.Visible = CType(resources.GetObject("MenuItem64.Visible"), Boolean)
        '
        'MenuItem76
        '
        Me.MenuItem76.Enabled = CType(resources.GetObject("MenuItem76.Enabled"), Boolean)
        Me.MenuItem76.Index = 5
        Me.MenuItem76.Shortcut = CType(resources.GetObject("MenuItem76.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem76.ShowShortcut = CType(resources.GetObject("MenuItem76.ShowShortcut"), Boolean)
        Me.MenuItem76.Text = resources.GetString("MenuItem76.Text")
        Me.MenuItem76.Visible = CType(resources.GetObject("MenuItem76.Visible"), Boolean)
        '
        'MenuItem77
        '
        Me.MenuItem77.Enabled = CType(resources.GetObject("MenuItem77.Enabled"), Boolean)
        Me.MenuItem77.Index = 6
        Me.MenuItem77.Shortcut = CType(resources.GetObject("MenuItem77.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem77.ShowShortcut = CType(resources.GetObject("MenuItem77.ShowShortcut"), Boolean)
        Me.MenuItem77.Text = resources.GetString("MenuItem77.Text")
        Me.MenuItem77.Visible = CType(resources.GetObject("MenuItem77.Visible"), Boolean)
        '
        'MenuItem78
        '
        Me.MenuItem78.Enabled = CType(resources.GetObject("MenuItem78.Enabled"), Boolean)
        Me.MenuItem78.Index = 7
        Me.MenuItem78.Shortcut = CType(resources.GetObject("MenuItem78.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem78.ShowShortcut = CType(resources.GetObject("MenuItem78.ShowShortcut"), Boolean)
        Me.MenuItem78.Text = resources.GetString("MenuItem78.Text")
        Me.MenuItem78.Visible = CType(resources.GetObject("MenuItem78.Visible"), Boolean)
        '
        'MenuItem86
        '
        Me.MenuItem86.Enabled = CType(resources.GetObject("MenuItem86.Enabled"), Boolean)
        Me.MenuItem86.Index = 8
        Me.MenuItem86.Shortcut = CType(resources.GetObject("MenuItem86.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem86.ShowShortcut = CType(resources.GetObject("MenuItem86.ShowShortcut"), Boolean)
        Me.MenuItem86.Text = resources.GetString("MenuItem86.Text")
        Me.MenuItem86.Visible = CType(resources.GetObject("MenuItem86.Visible"), Boolean)
        '
        'MenuItem87
        '
        Me.MenuItem87.Enabled = CType(resources.GetObject("MenuItem87.Enabled"), Boolean)
        Me.MenuItem87.Index = 9
        Me.MenuItem87.Shortcut = CType(resources.GetObject("MenuItem87.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem87.ShowShortcut = CType(resources.GetObject("MenuItem87.ShowShortcut"), Boolean)
        Me.MenuItem87.Text = resources.GetString("MenuItem87.Text")
        Me.MenuItem87.Visible = CType(resources.GetObject("MenuItem87.Visible"), Boolean)
        '
        'MenuItem79
        '
        Me.MenuItem79.Enabled = CType(resources.GetObject("MenuItem79.Enabled"), Boolean)
        Me.MenuItem79.Index = 10
        Me.MenuItem79.Shortcut = CType(resources.GetObject("MenuItem79.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem79.ShowShortcut = CType(resources.GetObject("MenuItem79.ShowShortcut"), Boolean)
        Me.MenuItem79.Text = resources.GetString("MenuItem79.Text")
        Me.MenuItem79.Visible = CType(resources.GetObject("MenuItem79.Visible"), Boolean)
        '
        'MenuItem81
        '
        Me.MenuItem81.Enabled = CType(resources.GetObject("MenuItem81.Enabled"), Boolean)
        Me.MenuItem81.Index = 11
        Me.MenuItem81.Shortcut = CType(resources.GetObject("MenuItem81.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem81.ShowShortcut = CType(resources.GetObject("MenuItem81.ShowShortcut"), Boolean)
        Me.MenuItem81.Text = resources.GetString("MenuItem81.Text")
        Me.MenuItem81.Visible = CType(resources.GetObject("MenuItem81.Visible"), Boolean)
        '
        'MenuItem80
        '
        Me.MenuItem80.Enabled = CType(resources.GetObject("MenuItem80.Enabled"), Boolean)
        Me.MenuItem80.Index = 12
        Me.MenuItem80.Shortcut = CType(resources.GetObject("MenuItem80.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem80.ShowShortcut = CType(resources.GetObject("MenuItem80.ShowShortcut"), Boolean)
        Me.MenuItem80.Text = resources.GetString("MenuItem80.Text")
        Me.MenuItem80.Visible = CType(resources.GetObject("MenuItem80.Visible"), Boolean)
        '
        'MenuItem30
        '
        Me.MenuItem30.Enabled = CType(resources.GetObject("MenuItem30.Enabled"), Boolean)
        Me.MenuItem30.Index = 7
        Me.MenuItem30.Shortcut = CType(resources.GetObject("MenuItem30.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem30.ShowShortcut = CType(resources.GetObject("MenuItem30.ShowShortcut"), Boolean)
        Me.MenuItem30.Text = resources.GetString("MenuItem30.Text")
        Me.MenuItem30.Visible = CType(resources.GetObject("MenuItem30.Visible"), Boolean)
        '
        'MenuItem31
        '
        Me.MenuItem31.Enabled = CType(resources.GetObject("MenuItem31.Enabled"), Boolean)
        Me.MenuItem31.Index = 8
        Me.MenuItem31.Shortcut = CType(resources.GetObject("MenuItem31.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem31.ShowShortcut = CType(resources.GetObject("MenuItem31.ShowShortcut"), Boolean)
        Me.MenuItem31.Text = resources.GetString("MenuItem31.Text")
        Me.MenuItem31.Visible = CType(resources.GetObject("MenuItem31.Visible"), Boolean)
        '
        'MenuItem33
        '
        Me.MenuItem33.Enabled = CType(resources.GetObject("MenuItem33.Enabled"), Boolean)
        Me.MenuItem33.Index = 9
        Me.MenuItem33.Shortcut = CType(resources.GetObject("MenuItem33.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem33.ShowShortcut = CType(resources.GetObject("MenuItem33.ShowShortcut"), Boolean)
        Me.MenuItem33.Text = resources.GetString("MenuItem33.Text")
        Me.MenuItem33.Visible = CType(resources.GetObject("MenuItem33.Visible"), Boolean)
        '
        'MenuItem2
        '
        Me.MenuItem2.Enabled = CType(resources.GetObject("MenuItem2.Enabled"), Boolean)
        Me.MenuItem2.Index = 10
        Me.MenuItem2.Shortcut = CType(resources.GetObject("MenuItem2.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem2.ShowShortcut = CType(resources.GetObject("MenuItem2.ShowShortcut"), Boolean)
        Me.MenuItem2.Text = resources.GetString("MenuItem2.Text")
        Me.MenuItem2.Visible = CType(resources.GetObject("MenuItem2.Visible"), Boolean)
        '
        'MenuItem50
        '
        Me.MenuItem50.Enabled = CType(resources.GetObject("MenuItem50.Enabled"), Boolean)
        Me.MenuItem50.Index = 11
        Me.MenuItem50.Shortcut = CType(resources.GetObject("MenuItem50.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem50.ShowShortcut = CType(resources.GetObject("MenuItem50.ShowShortcut"), Boolean)
        Me.MenuItem50.Text = resources.GetString("MenuItem50.Text")
        Me.MenuItem50.Visible = CType(resources.GetObject("MenuItem50.Visible"), Boolean)
        '
        'MenuItem52
        '
        Me.MenuItem52.Enabled = CType(resources.GetObject("MenuItem52.Enabled"), Boolean)
        Me.MenuItem52.Index = 12
        Me.MenuItem52.Shortcut = CType(resources.GetObject("MenuItem52.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem52.ShowShortcut = CType(resources.GetObject("MenuItem52.ShowShortcut"), Boolean)
        Me.MenuItem52.Text = resources.GetString("MenuItem52.Text")
        Me.MenuItem52.Visible = CType(resources.GetObject("MenuItem52.Visible"), Boolean)
        '
        'MenuItem54
        '
        Me.MenuItem54.Enabled = CType(resources.GetObject("MenuItem54.Enabled"), Boolean)
        Me.MenuItem54.Index = 13
        Me.MenuItem54.Shortcut = CType(resources.GetObject("MenuItem54.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem54.ShowShortcut = CType(resources.GetObject("MenuItem54.ShowShortcut"), Boolean)
        Me.MenuItem54.Text = resources.GetString("MenuItem54.Text")
        Me.MenuItem54.Visible = CType(resources.GetObject("MenuItem54.Visible"), Boolean)
        '
        'MenuItem34
        '
        Me.MenuItem34.Enabled = CType(resources.GetObject("MenuItem34.Enabled"), Boolean)
        Me.MenuItem34.Index = 14
        Me.MenuItem34.Shortcut = CType(resources.GetObject("MenuItem34.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem34.ShowShortcut = CType(resources.GetObject("MenuItem34.ShowShortcut"), Boolean)
        Me.MenuItem34.Text = resources.GetString("MenuItem34.Text")
        Me.MenuItem34.Visible = CType(resources.GetObject("MenuItem34.Visible"), Boolean)
        '
        'MenuItem4
        '
        Me.MenuItem4.Enabled = CType(resources.GetObject("MenuItem4.Enabled"), Boolean)
        Me.MenuItem4.Index = 15
        Me.MenuItem4.Shortcut = CType(resources.GetObject("MenuItem4.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem4.ShowShortcut = CType(resources.GetObject("MenuItem4.ShowShortcut"), Boolean)
        Me.MenuItem4.Text = resources.GetString("MenuItem4.Text")
        Me.MenuItem4.Visible = CType(resources.GetObject("MenuItem4.Visible"), Boolean)
        '
        'MenuItem16
        '
        Me.MenuItem16.Enabled = CType(resources.GetObject("MenuItem16.Enabled"), Boolean)
        Me.MenuItem16.Index = 16
        Me.MenuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem49, Me.MenuItem51, Me.MenuItem53, Me.MenuItem58, Me.MenuItem57, Me.MenuItem60, Me.MenuItem59, Me.MenuItem61, Me.MenuItem88, Me.MenuItem66, Me.MenuItem70, Me.MenuItem71, Me.MenuItem72, Me.MenuItem73, Me.MenuItem83, Me.MenuItem82, Me.MenuItem74, Me.MenuItem75, Me.MenuItem84, Me.MenuItem89, Me.MenuItem90, Me.MenuItem85})
        Me.MenuItem16.Shortcut = CType(resources.GetObject("MenuItem16.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem16.ShowShortcut = CType(resources.GetObject("MenuItem16.ShowShortcut"), Boolean)
        Me.MenuItem16.Text = resources.GetString("MenuItem16.Text")
        Me.MenuItem16.Visible = CType(resources.GetObject("MenuItem16.Visible"), Boolean)
        '
        'MenuItem49
        '
        Me.MenuItem49.Enabled = CType(resources.GetObject("MenuItem49.Enabled"), Boolean)
        Me.MenuItem49.Index = 0
        Me.MenuItem49.Shortcut = CType(resources.GetObject("MenuItem49.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem49.ShowShortcut = CType(resources.GetObject("MenuItem49.ShowShortcut"), Boolean)
        Me.MenuItem49.Text = resources.GetString("MenuItem49.Text")
        Me.MenuItem49.Visible = CType(resources.GetObject("MenuItem49.Visible"), Boolean)
        '
        'MenuItem51
        '
        Me.MenuItem51.Enabled = CType(resources.GetObject("MenuItem51.Enabled"), Boolean)
        Me.MenuItem51.Index = 1
        Me.MenuItem51.Shortcut = CType(resources.GetObject("MenuItem51.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem51.ShowShortcut = CType(resources.GetObject("MenuItem51.ShowShortcut"), Boolean)
        Me.MenuItem51.Text = resources.GetString("MenuItem51.Text")
        Me.MenuItem51.Visible = CType(resources.GetObject("MenuItem51.Visible"), Boolean)
        '
        'MenuItem53
        '
        Me.MenuItem53.Enabled = CType(resources.GetObject("MenuItem53.Enabled"), Boolean)
        Me.MenuItem53.Index = 2
        Me.MenuItem53.Shortcut = CType(resources.GetObject("MenuItem53.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem53.ShowShortcut = CType(resources.GetObject("MenuItem53.ShowShortcut"), Boolean)
        Me.MenuItem53.Text = resources.GetString("MenuItem53.Text")
        Me.MenuItem53.Visible = CType(resources.GetObject("MenuItem53.Visible"), Boolean)
        '
        'MenuItem58
        '
        Me.MenuItem58.Enabled = CType(resources.GetObject("MenuItem58.Enabled"), Boolean)
        Me.MenuItem58.Index = 3
        Me.MenuItem58.Shortcut = CType(resources.GetObject("MenuItem58.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem58.ShowShortcut = CType(resources.GetObject("MenuItem58.ShowShortcut"), Boolean)
        Me.MenuItem58.Text = resources.GetString("MenuItem58.Text")
        Me.MenuItem58.Visible = CType(resources.GetObject("MenuItem58.Visible"), Boolean)
        '
        'MenuItem57
        '
        Me.MenuItem57.Enabled = CType(resources.GetObject("MenuItem57.Enabled"), Boolean)
        Me.MenuItem57.Index = 4
        Me.MenuItem57.Shortcut = CType(resources.GetObject("MenuItem57.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem57.ShowShortcut = CType(resources.GetObject("MenuItem57.ShowShortcut"), Boolean)
        Me.MenuItem57.Text = resources.GetString("MenuItem57.Text")
        Me.MenuItem57.Visible = CType(resources.GetObject("MenuItem57.Visible"), Boolean)
        '
        'MenuItem60
        '
        Me.MenuItem60.Enabled = CType(resources.GetObject("MenuItem60.Enabled"), Boolean)
        Me.MenuItem60.Index = 5
        Me.MenuItem60.Shortcut = CType(resources.GetObject("MenuItem60.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem60.ShowShortcut = CType(resources.GetObject("MenuItem60.ShowShortcut"), Boolean)
        Me.MenuItem60.Text = resources.GetString("MenuItem60.Text")
        Me.MenuItem60.Visible = CType(resources.GetObject("MenuItem60.Visible"), Boolean)
        '
        'MenuItem59
        '
        Me.MenuItem59.Enabled = CType(resources.GetObject("MenuItem59.Enabled"), Boolean)
        Me.MenuItem59.Index = 6
        Me.MenuItem59.Shortcut = CType(resources.GetObject("MenuItem59.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem59.ShowShortcut = CType(resources.GetObject("MenuItem59.ShowShortcut"), Boolean)
        Me.MenuItem59.Text = resources.GetString("MenuItem59.Text")
        Me.MenuItem59.Visible = CType(resources.GetObject("MenuItem59.Visible"), Boolean)
        '
        'MenuItem61
        '
        Me.MenuItem61.Enabled = CType(resources.GetObject("MenuItem61.Enabled"), Boolean)
        Me.MenuItem61.Index = 7
        Me.MenuItem61.Shortcut = CType(resources.GetObject("MenuItem61.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem61.ShowShortcut = CType(resources.GetObject("MenuItem61.ShowShortcut"), Boolean)
        Me.MenuItem61.Text = resources.GetString("MenuItem61.Text")
        Me.MenuItem61.Visible = CType(resources.GetObject("MenuItem61.Visible"), Boolean)
        '
        'MenuItem88
        '
        Me.MenuItem88.Enabled = CType(resources.GetObject("MenuItem88.Enabled"), Boolean)
        Me.MenuItem88.Index = 8
        Me.MenuItem88.Shortcut = CType(resources.GetObject("MenuItem88.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem88.ShowShortcut = CType(resources.GetObject("MenuItem88.ShowShortcut"), Boolean)
        Me.MenuItem88.Text = resources.GetString("MenuItem88.Text")
        Me.MenuItem88.Visible = CType(resources.GetObject("MenuItem88.Visible"), Boolean)
        '
        'MenuItem66
        '
        Me.MenuItem66.Enabled = CType(resources.GetObject("MenuItem66.Enabled"), Boolean)
        Me.MenuItem66.Index = 9
        Me.MenuItem66.Shortcut = CType(resources.GetObject("MenuItem66.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem66.ShowShortcut = CType(resources.GetObject("MenuItem66.ShowShortcut"), Boolean)
        Me.MenuItem66.Text = resources.GetString("MenuItem66.Text")
        Me.MenuItem66.Visible = CType(resources.GetObject("MenuItem66.Visible"), Boolean)
        '
        'MenuItem70
        '
        Me.MenuItem70.Enabled = CType(resources.GetObject("MenuItem70.Enabled"), Boolean)
        Me.MenuItem70.Index = 10
        Me.MenuItem70.Shortcut = CType(resources.GetObject("MenuItem70.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem70.ShowShortcut = CType(resources.GetObject("MenuItem70.ShowShortcut"), Boolean)
        Me.MenuItem70.Text = resources.GetString("MenuItem70.Text")
        Me.MenuItem70.Visible = CType(resources.GetObject("MenuItem70.Visible"), Boolean)
        '
        'MenuItem71
        '
        Me.MenuItem71.Enabled = CType(resources.GetObject("MenuItem71.Enabled"), Boolean)
        Me.MenuItem71.Index = 11
        Me.MenuItem71.Shortcut = CType(resources.GetObject("MenuItem71.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem71.ShowShortcut = CType(resources.GetObject("MenuItem71.ShowShortcut"), Boolean)
        Me.MenuItem71.Text = resources.GetString("MenuItem71.Text")
        Me.MenuItem71.Visible = CType(resources.GetObject("MenuItem71.Visible"), Boolean)
        '
        'MenuItem72
        '
        Me.MenuItem72.Enabled = CType(resources.GetObject("MenuItem72.Enabled"), Boolean)
        Me.MenuItem72.Index = 12
        Me.MenuItem72.Shortcut = CType(resources.GetObject("MenuItem72.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem72.ShowShortcut = CType(resources.GetObject("MenuItem72.ShowShortcut"), Boolean)
        Me.MenuItem72.Text = resources.GetString("MenuItem72.Text")
        Me.MenuItem72.Visible = CType(resources.GetObject("MenuItem72.Visible"), Boolean)
        '
        'MenuItem73
        '
        Me.MenuItem73.Enabled = CType(resources.GetObject("MenuItem73.Enabled"), Boolean)
        Me.MenuItem73.Index = 13
        Me.MenuItem73.Shortcut = CType(resources.GetObject("MenuItem73.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem73.ShowShortcut = CType(resources.GetObject("MenuItem73.ShowShortcut"), Boolean)
        Me.MenuItem73.Text = resources.GetString("MenuItem73.Text")
        Me.MenuItem73.Visible = CType(resources.GetObject("MenuItem73.Visible"), Boolean)
        '
        'MenuItem83
        '
        Me.MenuItem83.Enabled = CType(resources.GetObject("MenuItem83.Enabled"), Boolean)
        Me.MenuItem83.Index = 14
        Me.MenuItem83.Shortcut = CType(resources.GetObject("MenuItem83.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem83.ShowShortcut = CType(resources.GetObject("MenuItem83.ShowShortcut"), Boolean)
        Me.MenuItem83.Text = resources.GetString("MenuItem83.Text")
        Me.MenuItem83.Visible = CType(resources.GetObject("MenuItem83.Visible"), Boolean)
        '
        'MenuItem82
        '
        Me.MenuItem82.Enabled = CType(resources.GetObject("MenuItem82.Enabled"), Boolean)
        Me.MenuItem82.Index = 15
        Me.MenuItem82.Shortcut = CType(resources.GetObject("MenuItem82.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem82.ShowShortcut = CType(resources.GetObject("MenuItem82.ShowShortcut"), Boolean)
        Me.MenuItem82.Text = resources.GetString("MenuItem82.Text")
        Me.MenuItem82.Visible = CType(resources.GetObject("MenuItem82.Visible"), Boolean)
        '
        'MenuItem74
        '
        Me.MenuItem74.Enabled = CType(resources.GetObject("MenuItem74.Enabled"), Boolean)
        Me.MenuItem74.Index = 16
        Me.MenuItem74.Shortcut = CType(resources.GetObject("MenuItem74.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem74.ShowShortcut = CType(resources.GetObject("MenuItem74.ShowShortcut"), Boolean)
        Me.MenuItem74.Text = resources.GetString("MenuItem74.Text")
        Me.MenuItem74.Visible = CType(resources.GetObject("MenuItem74.Visible"), Boolean)
        '
        'MenuItem75
        '
        Me.MenuItem75.Enabled = CType(resources.GetObject("MenuItem75.Enabled"), Boolean)
        Me.MenuItem75.Index = 17
        Me.MenuItem75.Shortcut = CType(resources.GetObject("MenuItem75.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem75.ShowShortcut = CType(resources.GetObject("MenuItem75.ShowShortcut"), Boolean)
        Me.MenuItem75.Text = resources.GetString("MenuItem75.Text")
        Me.MenuItem75.Visible = CType(resources.GetObject("MenuItem75.Visible"), Boolean)
        '
        'MenuItem84
        '
        Me.MenuItem84.Enabled = CType(resources.GetObject("MenuItem84.Enabled"), Boolean)
        Me.MenuItem84.Index = 18
        Me.MenuItem84.Shortcut = CType(resources.GetObject("MenuItem84.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem84.ShowShortcut = CType(resources.GetObject("MenuItem84.ShowShortcut"), Boolean)
        Me.MenuItem84.Text = resources.GetString("MenuItem84.Text")
        Me.MenuItem84.Visible = CType(resources.GetObject("MenuItem84.Visible"), Boolean)
        '
        'MenuItem89
        '
        Me.MenuItem89.Enabled = CType(resources.GetObject("MenuItem89.Enabled"), Boolean)
        Me.MenuItem89.Index = 19
        Me.MenuItem89.Shortcut = CType(resources.GetObject("MenuItem89.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem89.ShowShortcut = CType(resources.GetObject("MenuItem89.ShowShortcut"), Boolean)
        Me.MenuItem89.Text = resources.GetString("MenuItem89.Text")
        Me.MenuItem89.Visible = CType(resources.GetObject("MenuItem89.Visible"), Boolean)
        '
        'MenuItem90
        '
        Me.MenuItem90.Enabled = CType(resources.GetObject("MenuItem90.Enabled"), Boolean)
        Me.MenuItem90.Index = 20
        Me.MenuItem90.Shortcut = CType(resources.GetObject("MenuItem90.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem90.ShowShortcut = CType(resources.GetObject("MenuItem90.ShowShortcut"), Boolean)
        Me.MenuItem90.Text = resources.GetString("MenuItem90.Text")
        Me.MenuItem90.Visible = CType(resources.GetObject("MenuItem90.Visible"), Boolean)
        '
        'MenuItem85
        '
        Me.MenuItem85.Enabled = CType(resources.GetObject("MenuItem85.Enabled"), Boolean)
        Me.MenuItem85.Index = 21
        Me.MenuItem85.Shortcut = CType(resources.GetObject("MenuItem85.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem85.ShowShortcut = CType(resources.GetObject("MenuItem85.ShowShortcut"), Boolean)
        Me.MenuItem85.Text = resources.GetString("MenuItem85.Text")
        Me.MenuItem85.Visible = CType(resources.GetObject("MenuItem85.Visible"), Boolean)
        '
        'MenuItem69
        '
        Me.MenuItem69.Enabled = CType(resources.GetObject("MenuItem69.Enabled"), Boolean)
        Me.MenuItem69.Index = 17
        Me.MenuItem69.Shortcut = CType(resources.GetObject("MenuItem69.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem69.ShowShortcut = CType(resources.GetObject("MenuItem69.ShowShortcut"), Boolean)
        Me.MenuItem69.Text = resources.GetString("MenuItem69.Text")
        Me.MenuItem69.Visible = CType(resources.GetObject("MenuItem69.Visible"), Boolean)
        '
        'MenuItem11
        '
        Me.MenuItem11.Enabled = CType(resources.GetObject("MenuItem11.Enabled"), Boolean)
        Me.MenuItem11.Index = 1
        Me.MenuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem12, Me.MenuItem14, Me.MenuItem23, Me.MenuItem27, Me.MenuItem13})
        Me.MenuItem11.Shortcut = CType(resources.GetObject("MenuItem11.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem11.ShowShortcut = CType(resources.GetObject("MenuItem11.ShowShortcut"), Boolean)
        Me.MenuItem11.Text = resources.GetString("MenuItem11.Text")
        Me.MenuItem11.Visible = CType(resources.GetObject("MenuItem11.Visible"), Boolean)
        '
        'MenuItem12
        '
        Me.MenuItem12.Enabled = CType(resources.GetObject("MenuItem12.Enabled"), Boolean)
        Me.MenuItem12.Index = 0
        Me.MenuItem12.Shortcut = CType(resources.GetObject("MenuItem12.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem12.ShowShortcut = CType(resources.GetObject("MenuItem12.ShowShortcut"), Boolean)
        Me.MenuItem12.Text = resources.GetString("MenuItem12.Text")
        Me.MenuItem12.Visible = CType(resources.GetObject("MenuItem12.Visible"), Boolean)
        '
        'MenuItem14
        '
        Me.MenuItem14.Enabled = CType(resources.GetObject("MenuItem14.Enabled"), Boolean)
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Shortcut = CType(resources.GetObject("MenuItem14.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem14.ShowShortcut = CType(resources.GetObject("MenuItem14.ShowShortcut"), Boolean)
        Me.MenuItem14.Text = resources.GetString("MenuItem14.Text")
        Me.MenuItem14.Visible = CType(resources.GetObject("MenuItem14.Visible"), Boolean)
        '
        'MenuItem23
        '
        Me.MenuItem23.Enabled = CType(resources.GetObject("MenuItem23.Enabled"), Boolean)
        Me.MenuItem23.Index = 2
        Me.MenuItem23.Shortcut = CType(resources.GetObject("MenuItem23.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem23.ShowShortcut = CType(resources.GetObject("MenuItem23.ShowShortcut"), Boolean)
        Me.MenuItem23.Text = resources.GetString("MenuItem23.Text")
        Me.MenuItem23.Visible = CType(resources.GetObject("MenuItem23.Visible"), Boolean)
        '
        'MenuItem27
        '
        Me.MenuItem27.Enabled = CType(resources.GetObject("MenuItem27.Enabled"), Boolean)
        Me.MenuItem27.Index = 3
        Me.MenuItem27.Shortcut = CType(resources.GetObject("MenuItem27.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem27.ShowShortcut = CType(resources.GetObject("MenuItem27.ShowShortcut"), Boolean)
        Me.MenuItem27.Text = resources.GetString("MenuItem27.Text")
        Me.MenuItem27.Visible = CType(resources.GetObject("MenuItem27.Visible"), Boolean)
        '
        'MenuItem13
        '
        Me.MenuItem13.Enabled = CType(resources.GetObject("MenuItem13.Enabled"), Boolean)
        Me.MenuItem13.Index = 4
        Me.MenuItem13.Shortcut = CType(resources.GetObject("MenuItem13.Shortcut"), System.Windows.Forms.Shortcut)
        Me.MenuItem13.ShowShortcut = CType(resources.GetObject("MenuItem13.ShowShortcut"), Boolean)
        Me.MenuItem13.Text = resources.GetString("MenuItem13.Text")
        Me.MenuItem13.Visible = CType(resources.GetObject("MenuItem13.Visible"), Boolean)
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleDescription = resources.GetString("PictureBox1.AccessibleDescription")
        Me.PictureBox1.AccessibleName = resources.GetString("PictureBox1.AccessibleName")
        Me.PictureBox1.Anchor = CType(resources.GetObject("PictureBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Dock = CType(resources.GetObject("PictureBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.PictureBox1.Enabled = CType(resources.GetObject("PictureBox1.Enabled"), Boolean)
        Me.PictureBox1.Font = CType(resources.GetObject("PictureBox1.Font"), System.Drawing.Font)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = CType(resources.GetObject("PictureBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.PictureBox1.Location = CType(resources.GetObject("PictureBox1.Location"), System.Drawing.Point)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.RightToLeft = CType(resources.GetObject("PictureBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.PictureBox1.Size = CType(resources.GetObject("PictureBox1.Size"), System.Drawing.Size)
        Me.PictureBox1.SizeMode = CType(resources.GetObject("PictureBox1.SizeMode"), System.Windows.Forms.PictureBoxSizeMode)
        Me.PictureBox1.TabIndex = CType(resources.GetObject("PictureBox1.TabIndex"), Integer)
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Text = resources.GetString("PictureBox1.Text")
        Me.PictureBox1.Visible = CType(resources.GetObject("PictureBox1.Visible"), Boolean)
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = resources.GetString("Label1.AccessibleDescription")
        Me.Label1.AccessibleName = resources.GetString("Label1.AccessibleName")
        Me.Label1.Anchor = CType(resources.GetObject("Label1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = CType(resources.GetObject("Label1.AutoSize"), Boolean)
        Me.Label1.Dock = CType(resources.GetObject("Label1.Dock"), System.Windows.Forms.DockStyle)
        Me.Label1.Enabled = CType(resources.GetObject("Label1.Enabled"), Boolean)
        Me.Label1.Font = CType(resources.GetObject("Label1.Font"), System.Drawing.Font)
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = CType(resources.GetObject("Label1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label1.ImageIndex = CType(resources.GetObject("Label1.ImageIndex"), Integer)
        Me.Label1.ImeMode = CType(resources.GetObject("Label1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label1.Location = CType(resources.GetObject("Label1.Location"), System.Drawing.Point)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = CType(resources.GetObject("Label1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label1.Size = CType(resources.GetObject("Label1.Size"), System.Drawing.Size)
        Me.Label1.TabIndex = CType(resources.GetObject("Label1.TabIndex"), Integer)
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = CType(resources.GetObject("Label1.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label1.Visible = CType(resources.GetObject("Label1.Visible"), Boolean)
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = resources.GetString("Label2.AccessibleDescription")
        Me.Label2.AccessibleName = resources.GetString("Label2.AccessibleName")
        Me.Label2.Anchor = CType(resources.GetObject("Label2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = CType(resources.GetObject("Label2.AutoSize"), Boolean)
        Me.Label2.Dock = CType(resources.GetObject("Label2.Dock"), System.Windows.Forms.DockStyle)
        Me.Label2.Enabled = CType(resources.GetObject("Label2.Enabled"), Boolean)
        Me.Label2.Font = CType(resources.GetObject("Label2.Font"), System.Drawing.Font)
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = CType(resources.GetObject("Label2.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label2.ImageIndex = CType(resources.GetObject("Label2.ImageIndex"), Integer)
        Me.Label2.ImeMode = CType(resources.GetObject("Label2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label2.Location = CType(resources.GetObject("Label2.Location"), System.Drawing.Point)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = CType(resources.GetObject("Label2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label2.Size = CType(resources.GetObject("Label2.Size"), System.Drawing.Size)
        Me.Label2.TabIndex = CType(resources.GetObject("Label2.TabIndex"), Integer)
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = CType(resources.GetObject("Label2.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label2.Visible = CType(resources.GetObject("Label2.Visible"), Boolean)
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = resources.GetString("Label3.AccessibleDescription")
        Me.Label3.AccessibleName = resources.GetString("Label3.AccessibleName")
        Me.Label3.Anchor = CType(resources.GetObject("Label3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = CType(resources.GetObject("Label3.AutoSize"), Boolean)
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Dock = CType(resources.GetObject("Label3.Dock"), System.Windows.Forms.DockStyle)
        Me.Label3.Enabled = CType(resources.GetObject("Label3.Enabled"), Boolean)
        Me.Label3.Font = CType(resources.GetObject("Label3.Font"), System.Drawing.Font)
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = CType(resources.GetObject("Label3.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label3.ImageIndex = CType(resources.GetObject("Label3.ImageIndex"), Integer)
        Me.Label3.ImeMode = CType(resources.GetObject("Label3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label3.Location = CType(resources.GetObject("Label3.Location"), System.Drawing.Point)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = CType(resources.GetObject("Label3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label3.Size = CType(resources.GetObject("Label3.Size"), System.Drawing.Size)
        Me.Label3.TabIndex = CType(resources.GetObject("Label3.TabIndex"), Integer)
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = CType(resources.GetObject("Label3.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label3.Visible = CType(resources.GetObject("Label3.Visible"), Boolean)
        '
        'StatusBar1
        '
        Me.StatusBar1.AccessibleDescription = resources.GetString("StatusBar1.AccessibleDescription")
        Me.StatusBar1.AccessibleName = resources.GetString("StatusBar1.AccessibleName")
        Me.StatusBar1.Anchor = CType(resources.GetObject("StatusBar1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.StatusBar1.BackgroundImage = CType(resources.GetObject("StatusBar1.BackgroundImage"), System.Drawing.Image)
        Me.StatusBar1.Dock = CType(resources.GetObject("StatusBar1.Dock"), System.Windows.Forms.DockStyle)
        Me.StatusBar1.Enabled = CType(resources.GetObject("StatusBar1.Enabled"), Boolean)
        Me.StatusBar1.Font = CType(resources.GetObject("StatusBar1.Font"), System.Drawing.Font)
        Me.StatusBar1.ImeMode = CType(resources.GetObject("StatusBar1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.StatusBar1.Location = CType(resources.GetObject("StatusBar1.Location"), System.Drawing.Point)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2})
        Me.StatusBar1.RightToLeft = CType(resources.GetObject("StatusBar1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StatusBar1.Size = CType(resources.GetObject("StatusBar1.Size"), System.Drawing.Size)
        Me.StatusBar1.TabIndex = CType(resources.GetObject("StatusBar1.TabIndex"), Integer)
        Me.StatusBar1.Text = resources.GetString("StatusBar1.Text")
        Me.StatusBar1.Visible = CType(resources.GetObject("StatusBar1.Visible"), Boolean)
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Alignment = CType(resources.GetObject("StatusBarPanel1.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.StatusBarPanel1.Icon = CType(resources.GetObject("StatusBarPanel1.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel1.MinWidth = CType(resources.GetObject("StatusBarPanel1.MinWidth"), Integer)
        Me.StatusBarPanel1.Text = resources.GetString("StatusBarPanel1.Text")
        Me.StatusBarPanel1.ToolTipText = resources.GetString("StatusBarPanel1.ToolTipText")
        Me.StatusBarPanel1.Width = CType(resources.GetObject("StatusBarPanel1.Width"), Integer)
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Alignment = CType(resources.GetObject("StatusBarPanel2.Alignment"), System.Windows.Forms.HorizontalAlignment)
        Me.StatusBarPanel2.Icon = CType(resources.GetObject("StatusBarPanel2.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel2.MinWidth = CType(resources.GetObject("StatusBarPanel2.MinWidth"), Integer)
        Me.StatusBarPanel2.Text = resources.GetString("StatusBarPanel2.Text")
        Me.StatusBarPanel2.ToolTipText = resources.GetString("StatusBarPanel2.ToolTipText")
        Me.StatusBarPanel2.Width = CType(resources.GetObject("StatusBarPanel2.Width"), Integer)
        '
        'MAIN1
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.Menu = Me.MainMenu1
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "MAIN1"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Try
            Dim F As New depetse
            F.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MAIN1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DNO As Date
        'EYER = DNO.Year
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        '//////////////////////////
        'Dim x As String
        'Dim cmd2 As New SqlClient.SqlCommand("SELECT * FROM basic_salary_emp,dgree_base where basic_salary_emp.degree_id=dgree_base.dgree_id  and dgree_base.dgree_name='" & degree_txt.Text & "'", Con)
        'Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd2)
        'Dim dt As New DataTable
        'da.Fill(dt)

        '        //////////////////////////




        Dim x As String
        Dim cmd As New SqlClient.SqlCommand("select * from eyers where id ='" & 1 & "'", Con)
        Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        EYER = dt.Rows(0).Item("eyer")

        Label1.Text = EYER


        'oconnection.Open()
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Try

            If Con.State = ConnectionState.Broken = False Then
                Con.Close()
            End If
            End

        Catch er As Exception
            MessageBox.Show(er.Message)


        End Try
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim fr As New repcar_type
            fr.ShowDialog()

        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try

    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Try
            Dim lRetVal As Double
            lRetVal = Shell("CALC", vbNormalFocus)
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frr341 As New cardatat
            'cardatat = "repcardatareco"
            frr341.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frr3413 As New mencard2
            frr3413.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        Try
            Dim frr341q As New basiksalary
            frr341q.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try

    End Sub
    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        Try
            Dim q12961 As New mencard2
            'q12961.emp_id_txt.Enabled = False
            'q12961.empname_txt.Enabled = False

            q12961.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try

    End Sub


    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click

        Try
            Dim q129w As New stpe
            q129w.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub


    Private Sub MenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem66.Click

        Try
            Dim q129b4s8351 As New viwe_est_bdl
            q129b4s8351.ShowDialog()
        Catch er As Exception
            MessageBox.Show(er.Message)
        End Try
    End Sub




End Class
