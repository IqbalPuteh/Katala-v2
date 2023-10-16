Public Class frmEmployeeRptGeneral
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblActiveStatus As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents txtEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rbtEach As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAll As System.Windows.Forms.RadioButton
    Friend WithEvents lblTitleActive As System.Windows.Forms.Label
    Friend WithEvents lblTitleEmpId As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEmployeeRptGeneral))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtAll = New System.Windows.Forms.RadioButton()
        Me.rbtEach = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblActiveStatus = New System.Windows.Forms.Label()
        Me.lblTitleActive = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.lblTitleEmpId = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbtAll, Me.rbtEach, Me.Label7, Me.lblActiveStatus, Me.lblTitleActive, Me.lblName, Me.txtEmployeeId, Me.lblTitleEmpId, Me.Label3})
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(594, 256)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selection Criteria"
        '
        'rbtAll
        '
        Me.rbtAll.ForeColor = System.Drawing.Color.Black
        Me.rbtAll.Location = New System.Drawing.Point(224, 51)
        Me.rbtAll.Name = "rbtAll"
        Me.rbtAll.Size = New System.Drawing.Size(104, 16)
        Me.rbtAll.TabIndex = 2
        Me.rbtAll.Text = "All Employees"
        '
        'rbtEach
        '
        Me.rbtEach.ForeColor = System.Drawing.Color.Black
        Me.rbtEach.Location = New System.Drawing.Point(48, 51)
        Me.rbtEach.Name = "rbtEach"
        Me.rbtEach.Size = New System.Drawing.Size(112, 16)
        Me.rbtEach.TabIndex = 1
        Me.rbtEach.Text = "Each Employee"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(40, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(525, 1)
        Me.Label7.TabIndex = 13
        '
        'lblActiveStatus
        '
        Me.lblActiveStatus.AutoSize = True
        Me.lblActiveStatus.ForeColor = System.Drawing.Color.Black
        Me.lblActiveStatus.Location = New System.Drawing.Point(120, 120)
        Me.lblActiveStatus.Name = "lblActiveStatus"
        Me.lblActiveStatus.Size = New System.Drawing.Size(90, 14)
        Me.lblActiveStatus.TabIndex = 7
        Me.lblActiveStatus.Text = "lblActiveStatus"
        '
        'lblTitleActive
        '
        Me.lblTitleActive.AutoSize = True
        Me.lblTitleActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleActive.ForeColor = System.Drawing.Color.Black
        Me.lblTitleActive.Location = New System.Drawing.Point(45, 120)
        Me.lblTitleActive.Name = "lblTitleActive"
        Me.lblTitleActive.Size = New System.Drawing.Size(73, 14)
        Me.lblTitleActive.TabIndex = 6
        Me.lblTitleActive.Text = "Active Status:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(226, 91)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 14)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "lblName"
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtEmployeeId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeId.Location = New System.Drawing.Point(120, 88)
        Me.txtEmployeeId.MaxLength = 10
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.TabIndex = 3
        Me.txtEmployeeId.Text = ""
        '
        'lblTitleEmpId
        '
        Me.lblTitleEmpId.AutoSize = True
        Me.lblTitleEmpId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleEmpId.ForeColor = System.Drawing.Color.Black
        Me.lblTitleEmpId.Location = New System.Drawing.Point(49, 91)
        Me.lblTitleEmpId.Name = "lblTitleEmpId"
        Me.lblTitleEmpId.Size = New System.Drawing.Size(71, 14)
        Me.lblTitleEmpId.TabIndex = 2
        Me.lblTitleEmpId.Text = "Employee Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(40, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(487, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Please choose the options below then click on the preview button to view the repo" & _
        "rt."
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(512, 267)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        '
        'btnPreview
        '
        Me.btnPreview.Enabled = False
        Me.btnPreview.Location = New System.Drawing.Point(424, 267)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(80, 24)
        Me.btnPreview.TabIndex = 4
        Me.btnPreview.Text = "&Preview"
        '
        'frmEmployeeRptGeneral
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(594, 294)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.btnPreview, Me.GroupBox2})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployeeRptGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee General Information - Report"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim adoDS As DataSet

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            If rbtEach.Checked Then
                If lblName.Text = "" Then
                    Exit Sub
                End If
                adoDS = svcHRIS.GetEmployeeInfo(txtEmployeeId.Text, "", APP_ID)
            Else
                adoDS = svcHRIS.GetEmployeeInfo("", "", APP_ID)
            End If
            If adoDS.Tables("EMPINFO").Rows.Count = 0 Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                MessageBox.Show("No record selected with selected options.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Generate_Report(adoDS)
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not (adoDS Is Nothing) Then
                adoDS.Dispose()
            End If
            If Not (svcHRIS Is Nothing) Then
                svcHRIS.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub Generate_Report(ByVal adoDS As DataSet)
        Dim xlApp As Object
        Dim xlWb As Object
        Dim xlWs As Object

        'Dim xlApp As  Excel.Application
        'Dim xlWb As Excel.Workbook
        'Dim xlWs As Excel.Worksheet
        Dim intNou As Int16
        Dim I As Int16
        Dim adoRow As DataRow
        Dim strTemplate As String

        Try
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            strTemplate = Application.StartupPath & "\Reports\EMPLOYEE_INFO.xls"

            'Open copied file
            xlWb = xlApp.Workbooks.Open(strTemplate)
            xlWs = xlWb.Worksheets(1)

            xlWs.Cells(3, 11) = "Print Date: " & Format(Now, "ddd, dd MMM yyyy")
            xlWs.Cells(4, 11) = "Print Time: " & Format(Now, "hh:mm:ss tt")
            I = 7
            intNou = 1
            For Each adoRow In adoDS.Tables("EMPINFO").Rows
                xlWs.Cells(I, 1) = CInt(intNou) & "."
                xlWs.Cells(I, 2) = NullToString(adoRow!EMPLOYEE_ID)
                xlWs.Cells(I, 3) = NullToString(adoRow!FIRST_NAME) & " " & NullToString(adoRow!MIDDLE_NAME) & " " & NullToString(adoRow!LAST_NAME) & "-" & NullToString(adoRow!PREF_NAME)
                If adoRow!ACTIVE_STATUS = "A" Then
                    xlWs.Cells(I, 4) = "Active"
                Else
                    xlWs.Cells(I, 4) = "Not Active"
                End If
                xlWs.Cells(I, 5) = NullToString(adoRow!RES_ADDRESS01) & NullToString(adoRow!RES_ADDRESS02)
                xlWs.Cells(I, 6) = NullToString(adoRow!POST_ADDRESS01) & NullToString(adoRow!POST_ADDRESS02)
                xlWs.Cells(I, 7) = NullToString(adoRow!OFFICE_PHONE)
                xlWs.Cells(I, 8) = NullToString(adoRow!OFFICE_FAX)
                xlWs.Cells(I, 9) = NullToString(adoRow!HOME_PHONE)
                xlWs.Cells(I, 10) = NullToString(adoRow!HOME_FAX)
                xlWs.Cells(I, 11) = NullToString(adoRow!MOBILE_PHONE)

                I = I + 1
                intNou = intNou + 1
            Next

            I = I + 1
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 11)).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin

            I = I + 1
            xlWs.Cells(I, 1) = "OOOooo End Of Report oooOOO"
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 11)).Merge()
            xlWs.Range(xlWs.Cells(I, 1), xlWs.Cells(I, 11)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            xlApp.UserControl = True
            xlWb.Application.Visible = True
        Catch ex As Exception
            If Not IsNothing(xlApp) Then
                If Not IsNothing(xlWb) Then
                    xlWb.Close(False)
                End If
                xlApp.Application.Quit()
                xlApp = Nothing
                xlWb = Nothing
                xlWs = Nothing
            End If
            Err.Clear()
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub frmMembershipRptIndividual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblActiveStatus.Text = ""
        lblName.Text = ""
        btnPreview.Enabled = False
        rbtEach.Checked = True
    End Sub

    Private Sub txtEmployeeId_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmployeeId.TextChanged
        lblName.Text = ""
        lblActiveStatus.Text = ""
        btnPreview.Enabled = False
    End Sub

    Private Sub txtEmployeeId_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmployeeId.KeyUp
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim adoDS As DataSet

        Try

            If e.KeyValue = Keys.Enter Then
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = svcHRIS.GetEmployeeName(txtEmployeeId.Text, APP_ID)
                If adoDS.Tables("EMPINFO").Rows.Count = 0 Then
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    MessageBox.Show("The Employee Name data is not found!", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblName.Text = ""
                    btnPreview.Enabled = False
                    Exit Sub
                Else
                    lblName.Text = adoDS.Tables("EMPINFO").Rows(0)("FIRST_NAME") & " " & adoDS.Tables("EMPINFO").Rows(0)("MIDDLE_NAME") & " " & " " & adoDS.Tables("EMPINFO").Rows(0)("LAST_NAME")
                    If adoDS.Tables("EMPINFO").Rows(0)("ACTIVE_STATUS") = "A" Then
                        lblActiveStatus.Text = "Active"
                    Else
                        lblActiveStatus.Text = "Not Active"
                    End If
                    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                    btnPreview.Enabled = True
                    btnPreview.Focus()
                End If
                adoDS.Dispose()
                svcHRIS.Dispose()
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub rbtEach_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtEach.CheckedChanged
        If rbtEach.Checked Then
            lblTitleEmpId.Visible = True
            txtEmployeeId.Visible = True
            txtEmployeeId.Text = ""
            btnPreview.Enabled = False
            lblName.Visible = True
            lblTitleActive.Visible = True
            lblActiveStatus.Visible = True
        Else
            lblTitleEmpId.Visible = False
            txtEmployeeId.Visible = False
            lblName.Visible = False
            lblTitleActive.Visible = False
            lblActiveStatus.Visible = False
            btnPreview.Enabled = True
        End If
    End Sub

    Private Sub rbtAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtAll.CheckedChanged
        If rbtEach.Checked Then
            lblTitleEmpId.Visible = True
            txtEmployeeId.Visible = True
            txtEmployeeId.Text = ""
            btnPreview.Enabled = False
            lblName.Visible = True
            lblTitleActive.Visible = True
            lblActiveStatus.Visible = True
        Else
            lblTitleEmpId.Visible = False
            txtEmployeeId.Visible = False
            lblName.Visible = False
            lblTitleActive.Visible = False
            lblActiveStatus.Visible = False
            btnPreview.Enabled = True
        End If
    End Sub

End Class
