Module database_provider

    Public Con As New SqlClient.SqlConnection
    Private Cmd As SqlClient.SqlCommand
    Private Ad As SqlClient.SqlDataAdapter


    Public Sub ExecuteCommand(ByVal Str As String)
        Try
            Cmd = New SqlClient.SqlCommand(Str, Con)
            Cmd.CommandType = CommandType.Text
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Function RunSelectCommand(ByVal Str As String) As DataTable
        Try
            Cmd = New SqlClient.SqlCommand(Str, Con)
            Ad = New SqlClient.SqlDataAdapter(Cmd)
            Dim Dt As New DataTable
            Ad.Fill(Dt)
            Return Dt
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Function
    Public Sub bt_add1(ByVal edit As Button, ByVal add1 As Button, ByVal save As Button, ByVal search As Button, ByVal dell As Button)
        dell.Enabled = False
        search.Enabled = True
        'edit.Enabled = Not edit.Enabled
        save.Enabled = True
        edit.Enabled = False
        add1.Enabled = False
    End Sub
    Public Sub bt_save(ByVal edit As Button, ByVal add1 As Button, ByVal save As Button, ByVal search As Button, ByVal dell As Button)
        dell.Enabled = False
        search.Enabled = True
        'edit.Enabled = Not edit.Enabled
        save.Enabled = False
        edit.Enabled = False
        add1.Enabled = True
    End Sub
    Public Sub bt_low(ByVal edit As Button, ByVal add1 As Button, ByVal save As Button, ByVal search As Button, ByVal dell As Button)
        dell.Enabled = False
        search.Enabled = True
        'edit.Enabled = Not edit.Enabled
        save.Enabled = False
        edit.Enabled = False
        add1.Enabled = True
    End Sub
    Public Sub bt_dell(ByVal edit As Button, ByVal add1 As Button, ByVal save As Button, ByVal search As Button, ByVal dell As Button)
        dell.Enabled = False
        search.Enabled = True
        'edit.Enabled = Not edit.Enabled
        save.Enabled = False
        edit.Enabled = False
        add1.Enabled = True
    End Sub
    Public Sub bt_edit(ByVal edit As Button, ByVal add1 As Button, ByVal save As Button, ByVal search As Button, ByVal dell As Button)
        dell.Enabled = False
        search.Enabled = True
        'edit.Enabled = Not edit.Enabled
        save.Enabled = False
        edit.Enabled = False
        add1.Enabled = True
    End Sub
    Public Sub bt_search(ByVal edit As Button, ByVal add1 As Button, ByVal save As Button, ByVal search As Button, ByVal dell As Button)
        dell.Enabled = True
        search.Enabled = True
        'edit.Enabled = Not edit.Enabled
        save.Enabled = False
        edit.Enabled = True
        add1.Enabled = True
    End Sub
End Module
