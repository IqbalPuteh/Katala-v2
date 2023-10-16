Public Class frmUserProfile01
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
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents lblReviewedBy As System.Windows.Forms.Label
    Friend WithEvents lblReviewedDate As System.Windows.Forms.Label
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeId As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUserProfile01))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblReviewedDate = New System.Windows.Forms.Label()
        Me.lblReviewedBy = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(471, 395)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(559, 395)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "&Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblReviewedDate, Me.lblReviewedBy, Me.Label5, Me.lblEmployeeName, Me.txtUserId, Me.Label4, Me.txtPassword, Me.Label3, Me.txtEmployeeId, Me.Label1, Me.Label2})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 392)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Profile"
        '
        'lblReviewedDate
        '
        Me.lblReviewedDate.AutoSize = True
        Me.lblReviewedDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReviewedDate.ForeColor = System.Drawing.Color.Black
        Me.lblReviewedDate.Location = New System.Drawing.Point(112, 144)
        Me.lblReviewedDate.Name = "lblReviewedDate"
        Me.lblReviewedDate.Size = New System.Drawing.Size(101, 14)
        Me.lblReviewedDate.TabIndex = 16
        Me.lblReviewedDate.Text = "lblReviewedDate"
        '
        'lblReviewedBy
        '
        Me.lblReviewedBy.AutoSize = True
        Me.lblReviewedBy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReviewedBy.ForeColor = System.Drawing.Color.Black
        Me.lblReviewedBy.Location = New System.Drawing.Point(112, 120)
        Me.lblReviewedBy.Name = "lblReviewedBy"
        Me.lblReviewedBy.Size = New System.Drawing.Size(88, 14)
        Me.lblReviewedBy.TabIndex = 15
        Me.lblReviewedBy.Text = "lblReviewedBy"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(23, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 14)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Reviewed By:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.Black
        Me.lblEmployeeName.Location = New System.Drawing.Point(216, 67)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(107, 14)
        Me.lblEmployeeName.TabIndex = 13
        Me.lblEmployeeName.Text = "lblEmployeeName"
        '
        'txtUserId
        '
        Me.txtUserId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtUserId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserId.Location = New System.Drawing.Point(112, 40)
        Me.txtUserId.MaxLength = 20
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(168, 21)
        Me.txtUserId.TabIndex = 0
        Me.txtUserId.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 14)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Reviewed Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(112, 88)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(168, 21)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(30, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtEmployeeId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmployeeId.Location = New System.Drawing.Point(112, 64)
        Me.txtEmployeeId.MaxLength = 10
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.Size = New System.Drawing.Size(96, 21)
        Me.txtEmployeeId.TabIndex = 1
        Me.txtEmployeeId.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(32, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Employee Id:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(48, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "User Id:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmUserProfile01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(642, 423)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnSave, Me.btnClose, Me.GroupBox1})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserProfile01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Profile - Edit Screen"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim blnCancel As Boolean

    Private Sub frmUserProfile01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        blnCancel = True
    End Sub

    Public Sub Initialize()
        lblEmployeeName.Text = ""
        lblReviewedBy.Text = USER_ID
        lblReviewedDate.Text = Format(Now, "dd MMM yyyy, HH:mm:ss")
    End Sub

    Public Function GetDataSet() As DataSet
        Dim myDS As New DataSet()

        Try
            myDS = CreateResourceCodeRs()
            FillDataSet(myDS)
            GetDataSet = myDS
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub FillDataSet(ByRef adoDS As DataSet)
        Dim adoDataRow As DataRow
        Dim adoDataTable As New DataTable()
        Dim intSequence As Integer

        adoDataTable = adoDS.Tables("USERPROFILE")
        adoDataRow = adoDataTable.NewRow()
        adoDataRow("USER_ID") = txtUserId.Text
        adoDataRow("PASSWORD") = txtPassword.Text
        adoDataRow("EMPLOYEE_ID") = txtEmployeeId.Text
        adoDataRow("EMPLOYEE_NAME") = lblEmployeeName.Text
        adoDataRow("REVIEWED_BY") = USER_ID
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Private Function CreateResourceCodeRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("USERPROFILE")

        adoColumn = New DataColumn("USER_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("USERPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("PASSWORD")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("USERPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("EMPLOYEE_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("USERPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("EMPLOYEE_NAME")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("USERPROFILE").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("USERPROFILE").Columns.Add(adoColumn)

        CreateResourceCodeRs = adoDS
    End Function

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Public Sub FillField(ByVal adoDS As DataSet)
        Dim intSequence As Integer
        Dim adoRow As DataRow

        If adoDS.Tables("USERPROFILE").Rows.Count > 0 Then
            adoRow = adoDS.Tables("USERPROFILE").Rows(0)
            txtUserId.Text = adoRow!USER_ID
            txtEmployeeId.Text = adoRow!EMPLOYEE_ID
            txtPassword.Text = adoRow!PASSWORD
            lblReviewedBy.Text = adoRow!REVIEWED_BY
            lblReviewedDate.Text = Format(adoRow!REVIEWED_DATE, "dd MMM yyyy, HH:mm:ss")
            lblEmployeeName.Text = Trim(NullToString(adoRow!FIRST_NAME) & " " & Trim(NullToString(adoRow!MIDDLE_NAME) & " " & NullToString(adoRow!LAST_NAME)))
            If adoRow!ACTIVE_STATUS <> "A" Then
                GroupBox1.Enabled = False
                btnSave.Enabled = False
            End If
        End If
            txtUserId.Enabled = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateEmptyField(txtUserId) Then
            Exit Sub
        End If
        If ValidateEmptyField(txtEmployeeId) Then
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Sub txtEmployeeId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployeeId.TextChanged
        lblEmployeeName.Text = ""
    End Sub

    Private Sub txtEmployeeId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmployeeId.KeyDown
        Dim svcHRIS As New HRIS.svcHRIS()
        Dim adoDS As New DataSet()
        Dim adoRow As DataRow

        Try
            If e.KeyCode = Keys.Return Then
                If txtEmployeeId.Text = "" Then
                    Exit Sub
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
                adoDS = svcHRIS.GetEmployeeName(txtEmployeeId.Text, APP_ID)
                If adoDS.Tables("EMPINFO").Rows.Count = 0 Then
                    MessageBox.Show("Employee Id does not exist.", APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtEmployeeId.Focus()
                Else
                    adoRow = adoDS.Tables("EMPINFO").Rows(0)
                    lblEmployeeName.Text = Trim(NullToString(adoRow!FIRST_NAME) & " " & Trim(NullToString(adoRow!MIDDLE_NAME) & " " & NullToString(adoRow!LAST_NAME)))
                End If
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            svcHRIS.Dispose()
            adoDS.Dispose()
        End Try
    End Sub

    Private Sub txtEmployeeId_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmployeeId.Leave
        If lblEmployeeName.Text = "" And txtEmployeeId.Text <> "" Then
            txtEmployeeId_KeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Return))
        End If
    End Sub

End Class
