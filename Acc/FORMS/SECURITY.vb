Public Class SECURITY
    Inherits System.Windows.Forms.Form
    Public Sub sec()
        On Error GoTo xx
        Dim M As New MAIN1
        Dim lsPassword, lsUserId As String
        If Trim(UserID.Text) = "" Then
            MsgBox("Enter UserName")
            Exit Sub
        End If
        Con.ConnectionString = "User ID= '" & UserID.Text & "';" & _
        "Password='" & Password.Text & "';" & _
        "Initial Catalog=car2;" & _
        "Data Source=pc;" & _
        "Connection TimeOut=30;"
        sect = UserID.Text
        pass = Password.Text
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        Con.Close()
        Me.Hide()
        M.ShowDialog()
        Exit Sub
xx:     MsgBox(" ⁄–— «·« ’«· »«·„Œœ„ «·—∆Ì”Ï")
    End Sub

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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents UserID As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.UserID = New System.Windows.Forms.TextBox
        Me.Password = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(88, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        '
        'UserID
        '
        Me.UserID.Location = New System.Drawing.Point(104, 40)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(136, 20)
        Me.UserID.TabIndex = 0
        Me.UserID.Text = ""
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(104, 72)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(136, 20)
        Me.Password.TabIndex = 1
        Me.Password.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "UserName"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(32, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PassWord"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(168, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 144)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'SECURITY
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(288, 165)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UserID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SECURITY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Security"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sec()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub
End Class
