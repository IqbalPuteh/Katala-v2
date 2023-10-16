Public Class frmUserAccess01
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeStatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblReviewedDate As System.Windows.Forms.Label
    Friend WithEvents lblReviewedBy As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboApplicationName As System.Windows.Forms.ComboBox
    Friend WithEvents txtAccessValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblUserId As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUserAccess01))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.txtAccessValue = New System.Windows.Forms.NumericUpDown()
        Me.lblReviewedDate = New System.Windows.Forms.Label()
        Me.lblReviewedBy = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboApplicationName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEmployeeStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtAccessValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(471, 395)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "&Save"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(559, 395)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "&Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblUserId, Me.txtAccessValue, Me.lblReviewedDate, Me.lblReviewedBy, Me.Label5, Me.Label7, Me.Label6, Me.cboApplicationName, Me.Label4, Me.lblEmployeeStatus, Me.Label1, Me.lblEmployeeName, Me.Label3, Me.Label2})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 392)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Access Information"
        '
        'lblUserId
        '
        Me.lblUserId.AutoSize = True
        Me.lblUserId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserId.ForeColor = System.Drawing.Color.Black
        Me.lblUserId.Location = New System.Drawing.Point(112, 40)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(57, 14)
        Me.lblUserId.TabIndex = 31
        Me.lblUserId.Text = "lblUserId"
        '
        'txtAccessValue
        '
        Me.txtAccessValue.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtAccessValue.Location = New System.Drawing.Point(112, 152)
        Me.txtAccessValue.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.txtAccessValue.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtAccessValue.Name = "txtAccessValue"
        Me.txtAccessValue.ReadOnly = True
        Me.txtAccessValue.Size = New System.Drawing.Size(48, 21)
        Me.txtAccessValue.TabIndex = 30
        Me.txtAccessValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAccessValue.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblReviewedDate
        '
        Me.lblReviewedDate.AutoSize = True
        Me.lblReviewedDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReviewedDate.ForeColor = System.Drawing.Color.Black
        Me.lblReviewedDate.Location = New System.Drawing.Point(112, 208)
        Me.lblReviewedDate.Name = "lblReviewedDate"
        Me.lblReviewedDate.Size = New System.Drawing.Size(101, 14)
        Me.lblReviewedDate.TabIndex = 29
        Me.lblReviewedDate.Text = "lblReviewedDate"
        '
        'lblReviewedBy
        '
        Me.lblReviewedBy.AutoSize = True
        Me.lblReviewedBy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReviewedBy.ForeColor = System.Drawing.Color.Black
        Me.lblReviewedBy.Location = New System.Drawing.Point(112, 184)
        Me.lblReviewedBy.Name = "lblReviewedBy"
        Me.lblReviewedBy.Size = New System.Drawing.Size(88, 14)
        Me.lblReviewedBy.TabIndex = 28
        Me.lblReviewedBy.Text = "lblReviewedBy"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 14)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Reviewed By:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(22, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 14)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Reviewed Date:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(36, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 14)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Access Value:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboApplicationName
        '
        Me.cboApplicationName.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboApplicationName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboApplicationName.Location = New System.Drawing.Point(112, 120)
        Me.cboApplicationName.Name = "cboApplicationName"
        Me.cboApplicationName.Size = New System.Drawing.Size(368, 21)
        Me.cboApplicationName.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(18, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 14)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Application Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployeeStatus
        '
        Me.lblEmployeeStatus.AutoSize = True
        Me.lblEmployeeStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeStatus.ForeColor = System.Drawing.Color.Black
        Me.lblEmployeeStatus.Location = New System.Drawing.Point(112, 88)
        Me.lblEmployeeStatus.Name = "lblEmployeeStatus"
        Me.lblEmployeeStatus.Size = New System.Drawing.Size(110, 14)
        Me.lblEmployeeStatus.TabIndex = 21
        Me.lblEmployeeStatus.Text = "lblEmployeeStatus"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(68, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 14)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Status:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.Black
        Me.lblEmployeeName.Location = New System.Drawing.Point(112, 64)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(107, 14)
        Me.lblEmployeeName.TabIndex = 19
        Me.lblEmployeeName.Text = "lblEmployeeName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 14)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Employee Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(48, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "User Id:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmUserAccess01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(642, 423)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnSave, Me.btnClose, Me.GroupBox1})
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserAccess01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Access - Edit Screen"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtAccessValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim blnCancel As Boolean
    Dim arrProgramId() As String

    Public Function GetDataSet() As DataSet
        Dim myDS As New DataSet()

        Try
            myDS = CreateUserAccessRs()
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

        adoDataTable = adoDS.Tables("USER_ACCESS")
        adoDataRow = adoDataTable.NewRow()
        adoDataRow("USER_ID") = lblUserId.Text
        adoDataRow("PROGRAM_ID") = arrProgramId(cboApplicationName.SelectedIndex)
        adoDataRow("PROGRAM_NAME") = cboApplicationName.Text
        adoDataRow("ACCESS_VALUE") = txtAccessValue.Value
        adoDataRow("REVIEWED_BY") = USER_ID
        adoDataTable.Rows.Add(adoDataRow)
    End Sub

    Private Function CreateUserAccessRs() As DataSet
        Dim adoDS As New DataSet()
        Dim adoColumn As DataColumn

        adoDS.Tables.Add("USER_ACCESS")

        adoColumn = New DataColumn("USER_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("USER_ACCESS").Columns.Add(adoColumn)

        adoColumn = New DataColumn("PROGRAM_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("USER_ACCESS").Columns.Add(adoColumn)

        adoColumn = New DataColumn("PROGRAM_NAME")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("USER_ACCESS").Columns.Add(adoColumn)

        adoColumn = New DataColumn("ACCESS_VALUE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("USER_ACCESS").Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoDS.Tables("USER_ACCESS").Columns.Add(adoColumn)

        CreateUserAccessRs = adoDS
    End Function

    Public Function GetCancelStatus() As Boolean
        GetCancelStatus = blnCancel
    End Function

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Public Sub Initialization(ByVal adoDs As DataSet, ByVal strUserId As String, ByVal strEmployeeName As String, ByVal strEmployeeStatus As String)
        Dim adoRow As DataRow
        Dim I As Integer

        lblUserId.Text = strUserId
        lblEmployeeName.Text = strEmployeeName
        lblEmployeeStatus.Text = strEmployeeStatus
        lblReviewedBy.Text = USER_ID
        lblReviewedDate.Text = Format(Now, "dd MMM yyyy, HH:mm:ss")

        ReDim arrProgramId(adoDs.Tables("ResourceCode").Rows.Count)
        I = 0
        For Each adoRow In adoDs.Tables("ResourceCode").Rows
            arrProgramId(I) = adoRow!RESOURCE_CODE
            cboApplicationName.Items.Add(adoRow!RESOURCE_DESC & " (" & adoRow!RESOURCE_CODE & ")")
            I = I + 1
        Next
    End Sub

    Public Sub FillField(ByVal adoDS As DataSet)
        Dim adoRow As DataRow
        Dim I As Integer
        Dim blnFound As Boolean

        If adoDS.Tables("USER_ACCESS").Rows.Count > 0 Then
            adoRow = adoDS.Tables("USER_ACCESS").Rows(0)
            blnFound = False
            For I = 0 To UBound(arrProgramId)
                If arrProgramId(I) = adoRow!PROGRAM_ID Then
                    blnFound = True
                    Exit For
                End If
            Next

            If blnFound Then
                cboApplicationName.SelectedIndex = I
            Else
                cboApplicationName.SelectedIndex = -1
            End If
            txtAccessValue.Value = adoRow!ACCESS_VALUE
            lblReviewedBy.Text = adoRow!REVIEWED_BY
            lblReviewedDate.Text = Format(adoRow!REVIEWED_DATE, "dd MMM yyyy, HH:mm:ss")
            cboApplicationName.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidateEmptyField(cboApplicationName) Then
            Exit Sub
        End If

        blnCancel = False
        Me.Hide()
    End Sub

    Private Sub frmUserAccess01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        blnCancel = True
    End Sub
End Class
