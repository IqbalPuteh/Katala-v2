Public Class frmRptUserAccess
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeStatus As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRptUserAccess))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEmployeeStatus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.lblEmployeeStatus, Me.Label5, Me.lblEmployeeName, Me.Label3, Me.txtUserId, Me.Label2, Me.Label1})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(514, 232)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Parameters"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(288, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 14)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Blank = All"
        '
        'lblEmployeeStatus
        '
        Me.lblEmployeeStatus.AutoSize = True
        Me.lblEmployeeStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeStatus.ForeColor = System.Drawing.Color.Black
        Me.lblEmployeeStatus.Location = New System.Drawing.Point(112, 112)
        Me.lblEmployeeStatus.Name = "lblEmployeeStatus"
        Me.lblEmployeeStatus.Size = New System.Drawing.Size(110, 14)
        Me.lblEmployeeStatus.TabIndex = 23
        Me.lblEmployeeStatus.Text = "lblEmployeeStatus"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(69, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 14)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Status:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.Black
        Me.lblEmployeeName.Location = New System.Drawing.Point(112, 88)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(107, 14)
        Me.lblEmployeeName.TabIndex = 21
        Me.lblEmployeeName.Text = "lblEmployeeName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 14)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Employee Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUserId
        '
        Me.txtUserId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtUserId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserId.Location = New System.Drawing.Point(112, 56)
        Me.txtUserId.MaxLength = 20
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(168, 21)
        Me.txtUserId.TabIndex = 19
        Me.txtUserId.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(64, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 14)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "User Id:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please select the options below and click on preview button."
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(432, 248)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "&Close"
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(344, 248)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(80, 24)
        Me.btnPreview.TabIndex = 15
        Me.btnPreview.Text = "&Preview"
        '
        'frmRptUserAccess
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(514, 280)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.btnPreview, Me.GroupBox1})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptUserAccess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Access Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtUserId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserId.TextChanged
        lblEmployeeName.Text = ""
        lblEmployeeStatus.Text = ""
    End Sub

    Private Sub txtUserId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserId.KeyDown
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()
        Dim adoDS As New DataSet()
        Dim adoRow As DataRow

        Try
            If e.KeyCode = Keys.Return Then
                If txtUserId.Text = "" Then
                    Exit Sub
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = svcSecurity.GetUserInfo(txtUserId.Text, APP_ID)
                If adoDS.Tables("USERPROFILE").Rows.Count = 0 Then
                    MessageBox.Show("User Id does not exist.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtUserId.Focus()
                Else
                    adoRow = adoDS.Tables("USERPROFILE").Rows(0)
                    lblEmployeeName.Text = Trim(NullToString(adoRow!FIRST_NAME) & " " & Trim(NullToString(adoRow!MIDDLE_NAME) & " " & NullToString(adoRow!LAST_NAME)))
                    lblEmployeeStatus.Text = IIf(adoRow!ACTIVE_STATUS = "A", "Active", "Not Active")
                    btnPreview.Focus()
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            svcSecurity.Dispose()
            adoDS.Dispose()
        End Try
    End Sub

    Private Sub txtUserId_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserId.Leave
        If lblEmployeeName.Text = "" And txtUserId.Text <> "" Then
            txtUserId_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Return))
        End If
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity()
        Dim adoDS As New DataSet()

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            adoDS = svcSecurity.GetUserAccessReport(txtUserId.Text, APP_ID)
            If adoDS.Tables("USER_ACCESS").Rows.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("No record selected with selected options.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Generate_Report(adoDS)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
            If Not (svcSecurity Is Nothing) Then
                svcSecurity.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub Generate_Report(ByVal adoDS As DataSet)
        'Dim xlApp As Excel.Application
        'Dim xlWB As Excel.Workbook
        'Dim xlWS As Excel.Worksheet
        Dim xlApp As Object
        Dim xlWB As Object
        Dim xlWS As Object
        Dim I As Integer
        Dim strDestination As String
        Dim strTemplate As String
        Dim intNou As Integer
        Dim adoRow As DataRow
        Dim strUserId As String

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

            xlApp = CreateObject("Excel.Application")
            strTemplate = Application.StartupPath & "\Reports\SECURITY_USERACCESS.xls"

            'Open copied file
            xlWB = xlApp.Workbooks.Open(strTemplate)
            xlWS = xlWB.Worksheets(1)

            xlWS.Cells(3, 5) = "Print Date: " & Format(Now, "ddd, dd MMM yyyy")
            xlWS.Cells(4, 5) = "Print Time: " & Format(Now, "hh:mm:ss tt")

            I = 6
            intNou = 1
            strUserId = ""
            For Each adoRow In adoDS.Tables("USER_ACCESS").Rows
                If strUserId <> adoRow!USER_ID Then
                    I = I + 1
                    xlWS.Cells(I, 1) = intNou
                    xlWS.Cells(I, 2) = adoRow!USER_ID
                    xlWS.Cells(I, 3) = Trim(NullToString(adoRow!FIRST_NAME) & " " & Trim(NullToString(adoRow!MIDDLE_NAME) & " " & NullToString(adoRow!LAST_NAME))) & " (" & adoRow!EMPLOYEE_ID & ")"
                    intNou = intNou + 1
                    strUserId = adoRow!USER_ID
                End If
                xlWS.Cells(I, 4) = NullToString(adoRow!PROGRAM_NAME) & " (" & adoRow!PROGRAM_ID & ")"
                xlWS.Cells(I, 5) = adoRow!ACCESS_VALUE
                xlWS.Cells(I, 6) = IIf(adoRow!ACTIVE_STATUS = "A", "Active", "Not Active")
                I = I + 1
            Next

            I = I + 1
            xlWS.Range(xlWS.Cells(I, 1), xlWS.Cells(I, 6)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin

            I = I + 2
            xlWS.Cells(I, 1) = "OOOooo End Of Report oooOOO"
            xlWS.Range(xlWS.Cells(I, 1), xlWS.Cells(I, 6)).Merge()
            xlWS.Range(xlWS.Cells(I, 1), xlWS.Cells(I, 6)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            xlApp.UserControl = True
            xlWB.Application.Visible = True
        Catch ex As Exception
            If Not IsNothing(xlApp) Then
                If Not IsNothing(xlWB) Then
                    xlWB.Close(False)
                End If
                xlApp.Application.Quit()
                xlApp = Nothing
                xlWB = Nothing
                xlWS = Nothing
            End If
            Err.Clear()
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub frmRptUserAccess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblEmployeeName.Text = ""
        lblEmployeeStatus.Text = ""
    End Sub
End Class
