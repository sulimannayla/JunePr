Public Class cardatat
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Viewer1 = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.SuspendLayout()
        '
        'Viewer1
        '
        Me.Viewer1.BackColor = System.Drawing.SystemColors.Control
        Me.Viewer1.Location = New System.Drawing.Point(0, 0)
        Me.Viewer1.Name = "Viewer1"
        Me.Viewer1.ReportViewer.CurrentPage = 0
        Me.Viewer1.ReportViewer.MultiplePageCols = 3
        Me.Viewer1.ReportViewer.MultiplePageRows = 2
        Me.Viewer1.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.Viewer1.Size = New System.Drawing.Size(784, 536)
        Me.Viewer1.TabIndex = 0
        Me.Viewer1.TableOfContents.Text = "Table Of Contents"
        Me.Viewer1.TableOfContents.Width = 200
        Me.Viewer1.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'cardatat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(784, 525)
        Me.Controls.Add(Me.Viewer1)
        Me.Name = "cardatat"
        Me.Text = "cardatat"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Viewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Viewer1.Load

    End Sub

    Private Sub cardatat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim df As New SECURITY
        Try
            Dim _tmp As Cursor
            _tmp = Me.Cursor
            Me.Cursor = Cursors.WaitCursor
            '**************************************************
            'If cardatat = sd Then
            '    Dim _rpt = New cardatamk
            'Else
            '    Dim _rpt = New repcardatareco
            'End If
            '*****************************************************************

            '**************************************************
            'Dim _rpt = New cardatamk
            '*************************
            '    Dim _DS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource
            '    _DS.ConnectionString = "User ID= '" & df.UserID.Text & "';" & _
            '"Password='" & df.Password.Text & "';" & _
            '"Initial Catalog=car;" & _
            '"Data Source=pc;" & _
            '"Connection TimeOut=30;"
            '*************************************************************************
            'If RadioButton1.Checked = True Then
            'Dim _sqlString As String = "Select sites.site_name,car_data.car_no, car_data.model, car_data.type_no, car_data.no_type,car_data.shase_no,car_data.machine_no,car_data.car_owner,car_data.insurance_date,car_data.insurance_no,car_data.driver,car_type.type_no,car_type.car_name"
            '_sqlString = _sqlString + " FROM car_type, car_data,sites"
            '_sqlString = _sqlString + " WHERE sites.site_id=car_data.site_id and car_data.type_no = car_type.type_no "
            ''_sqlString = _sqlString + 62 + "'"
            '_DS.SQL = _sqlString
            '_rpt.DataSource = _DS
            'End If
            '***************************************************************************
            'If RadioButton2.Checked = True Then
            '    Dim _sqlString As String = "Select car_data.car_no, car_data.model,  car_data.no_type,car_data.shase_no,car_data.machine_no,car_data.car_owner,car_data.insurance_date,car_data.insurance_no,car_data.driver,car_type.type_no,car_type.car_name"
            '    _sqlString = _sqlString + " FROM car_type, car_data"
            '    _sqlString = _sqlString + " WHERE car_data.type_no = car_type.type_no  AND car_data.driver = '" & driver_txt.Text & "'"
            '    '_sqlString = _sqlString + 62 + "'"
            '    _DS.SQL = _sqlString
            '    _rpt.DataSource = _DS
            'End If
            '******************************

            'If RadioButton3.Checked = True Then
            '    Dim _sqlString As String = "Select car_data.car_no, car_data.model,  car_data.no_type,car_data.shase_no,car_data.machine_no,car_data.car_owner,car_data.insurance_date,car_data.insurance_no,car_data.driver,car_type.type_no,car_type.car_name"
            '    _sqlString = _sqlString + " FROM car_type, car_data"
            '    _sqlString = _sqlString + " WHERE car_data.type_no = car_type.type_no  AND car_data.car_owner = '" & owner_txt.Text & "'"
            '    '_sqlString = _sqlString + 62 + "'"
            '    _DS.SQL = _sqlString
            '    _rpt.DataSource = _DS
            'End If
            '******************************************************
            'Me.Viewer1.Document = _rpt.Document
            '_rpt.Run(False)
            Me.Cursor = _tmp

        Catch ex As DataDynamics.ActiveReports.ReportException
            MessageBox.Show(Me, "Error fired while running the report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
