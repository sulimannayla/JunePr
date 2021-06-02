Public Class SECURITY
    Inherits System.Windows.Forms.Form
    Public Sub sec()
        Dim M As New MAIN1
        'Dim lsPassword, lsUserId As String

        'Con.ConnectionString = "User ID= '" & UserID.Text & "';" & _
        '"Password='" & Password.Text & "';" & _
        '"Initial Catalog=accoun;" & _
        '"Data Source=main2;" & _
        '"Connection TimeOut=30;"
        'If Con.State = ConnectionState.Broken = False Then
        '    Con.Close()
        'End If
        'Con.Open()
        'Con.Close()
        Me.Hide()
        M.ShowDialog()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents site_txt As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.UserID = New System.Windows.Forms.TextBox
        Me.Password = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.site_txt = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Location = New System.Drawing.Point(120, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "OK"
        '
        'UserID
        '
        Me.UserID.Location = New System.Drawing.Point(16, 16)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(176, 20)
        Me.UserID.TabIndex = 1
        Me.UserID.Text = "SA"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(16, 56)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(176, 20)
        Me.Password.TabIndex = 2
        Me.Password.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "«”„ «·„” Œœ„"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ﬂ·„… «·„—Ê—"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(16, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 24)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancel"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.UserID)
        Me.GroupBox1.Controls.Add(Me.Password)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 160)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'site_txt
        '
        Me.site_txt.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.site_txt.Location = New System.Drawing.Point(64, 176)
        Me.site_txt.Name = "site_txt"
        Me.site_txt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.site_txt.Size = New System.Drawing.Size(248, 21)
        Me.site_txt.TabIndex = 6
        Me.site_txt.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "«·Ã‹‹Â‹‹‹‹‹‹…"
        Me.Label3.Visible = False
        '
        'SECURITY
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(304, 173)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.site_txt)
        Me.Name = "SECURITY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Security"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim lsPassword, lsUserId As String

        Con.ConnectionString = "User ID= '" & UserID.Text & "';" & _
        "Password='" & Password.Text & "';" & _
        "Initial Catalog=accoun;" & _
        "Data Source=main2;" & _
        "Connection TimeOut=30;"
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()

        Dim DS01 As New DataSet
        Dim str01 As String = "SELECT DISTINCT  site_name  FROM sites"
        Dim ADP01 As New SqlClient.SqlDataAdapter(str01, Con)
        ADP01.Fill(DS01)
        Dim j As Integer
        For j = 0 To DS01.Tables(0).Rows.Count - 1
            Me.site_txt.Items.Add(DS01.Tables(0).Rows(j).Item(0))
        Next

        ADP01.Dispose()
    End Sub

    Private Sub Password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(UserID.Text) = "" Then  'Trim(site_txt.Text) = "" Or
            MsgBox(" «ﬂœ „‰ «œŒ«· «·»Ì«‰«  «·„ÿ·Ê»…")
            Exit Sub
        End If
        Dim DS512 As New DataSet
        If Con.State = ConnectionState.Broken = False Then
            Con.Close()
        End If
        Con.Open()
        'Dim t512 As DataTable
        'Dim cmd512 As New SqlClient.SqlCommand("SELECT site_id  FROM sites where site_name ='" & site_txt.Text & "'", Con)
        'Dim dr512 As SqlClient.SqlDataReader = cmd512.ExecuteReader()
        'dr512.Read()
        'Dim site_i_d As Integer = dr512.Item("site_id")
        'dr512.Close()


        sec()

        '=======================================================================================

        '.....=======================================================================================

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
