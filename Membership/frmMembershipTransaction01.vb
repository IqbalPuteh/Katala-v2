Public Class frmMembershipTransaction01
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
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMemberNo As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dtpAccPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAccPeriod As System.Windows.Forms.Label
    Friend WithEvents dtpTransDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboTransType As System.Windows.Forms.ComboBox
    Friend WithEvents cboTransDesc As System.Windows.Forms.ComboBox
    Friend WithEvents lblNameLabel As System.Windows.Forms.Label
    Friend WithEvents lblLastUpdate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTransId As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMembershipTransaction01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblMemberNo = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblNameLabel = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.NumericUpDown
        Me.lblTransId = New System.Windows.Forms.Label
        Me.cboTransType = New System.Windows.Forms.ComboBox
        Me.cboTransDesc = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblType = New System.Windows.Forms.Label
        Me.dtpTransDate = New System.Windows.Forms.DateTimePicker
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.dtpAccPeriode = New System.Windows.Forms.DateTimePicker
        Me.lblAccPeriod = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblLastUpdate = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMemberNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.lblNameLabel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 96)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Member Info"
        '
        'lblMemberNo
        '
        Me.lblMemberNo.AutoSize = True
        Me.lblMemberNo.ForeColor = System.Drawing.Color.Black
        Me.lblMemberNo.Location = New System.Drawing.Point(128, 32)
        Me.lblMemberNo.Name = "lblMemberNo"
        Me.lblMemberNo.Size = New System.Drawing.Size(80, 17)
        Me.lblMemberNo.TabIndex = 1
        Me.lblMemberNo.Text = "lblMemberNo"
        Me.lblMemberNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(39, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Membership No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(128, 56)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 17)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "lblName"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNameLabel
        '
        Me.lblNameLabel.AutoSize = True
        Me.lblNameLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameLabel.ForeColor = System.Drawing.Color.Black
        Me.lblNameLabel.Location = New System.Drawing.Point(88, 56)
        Me.lblNameLabel.Name = "lblNameLabel"
        Me.lblNameLabel.Size = New System.Drawing.Size(41, 17)
        Me.lblNameLabel.TabIndex = 4
        Me.lblNameLabel.Text = "Name :"
        Me.lblNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDescription)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtAmount)
        Me.GroupBox2.Controls.Add(Me.lblTransId)
        Me.GroupBox2.Controls.Add(Me.cboTransType)
        Me.GroupBox2.Controls.Add(Me.cboTransDesc)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblType)
        Me.GroupBox2.Controls.Add(Me.dtpTransDate)
        Me.GroupBox2.Controls.Add(Me.lblTransDate)
        Me.GroupBox2.Controls.Add(Me.dtpAccPeriode)
        Me.GroupBox2.Controls.Add(Me.lblAccPeriod)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 304)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaction Info"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(128, 160)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(464, 88)
        Me.txtDescription.TabIndex = 6
        Me.txtDescription.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(58, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Description :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(128, 136)
        Me.txtAmount.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(104, 21)
        Me.txtAmount.TabIndex = 5
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTransId
        '
        Me.lblTransId.AutoSize = True
        Me.lblTransId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransId.ForeColor = System.Drawing.Color.Black
        Me.lblTransId.Location = New System.Drawing.Point(224, 42)
        Me.lblTransId.Name = "lblTransId"
        Me.lblTransId.Size = New System.Drawing.Size(43, 17)
        Me.lblTransId.TabIndex = 20
        Me.lblTransId.Text = "TransId"
        Me.lblTransId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTransId.Visible = False
        '
        'cboTransType
        '
        Me.cboTransType.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransType.Location = New System.Drawing.Point(128, 88)
        Me.cboTransType.Name = "cboTransType"
        Me.cboTransType.Size = New System.Drawing.Size(104, 21)
        Me.cboTransType.TabIndex = 4
        '
        'cboTransDesc
        '
        Me.cboTransDesc.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboTransDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransDesc.Location = New System.Drawing.Point(128, 112)
        Me.cboTransDesc.Name = "cboTransDesc"
        Me.cboTransDesc.Size = New System.Drawing.Size(200, 21)
        Me.cboTransDesc.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(74, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Amount :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.Black
        Me.lblType.Location = New System.Drawing.Point(26, 88)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(98, 17)
        Me.lblType.TabIndex = 16
        Me.lblType.Text = "Transaction Type :"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTransDate
        '
        Me.dtpTransDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTransDate.Location = New System.Drawing.Point(128, 64)
        Me.dtpTransDate.Name = "dtpTransDate"
        Me.dtpTransDate.Size = New System.Drawing.Size(104, 21)
        Me.dtpTransDate.TabIndex = 2
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(90, 66)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(35, 17)
        Me.lblTransDate.TabIndex = 10
        Me.lblTransDate.Text = "Date :"
        Me.lblTransDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpAccPeriode
        '
        Me.dtpAccPeriode.CustomFormat = "yyyy-MM"
        Me.dtpAccPeriode.Enabled = False
        Me.dtpAccPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAccPeriode.Location = New System.Drawing.Point(128, 40)
        Me.dtpAccPeriode.Name = "dtpAccPeriode"
        Me.dtpAccPeriode.ShowUpDown = True
        Me.dtpAccPeriode.Size = New System.Drawing.Size(80, 21)
        Me.dtpAccPeriode.TabIndex = 1
        '
        'lblAccPeriod
        '
        Me.lblAccPeriod.AutoSize = True
        Me.lblAccPeriod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccPeriod.ForeColor = System.Drawing.Color.Black
        Me.lblAccPeriod.Location = New System.Drawing.Point(23, 42)
        Me.lblAccPeriod.Name = "lblAccPeriod"
        Me.lblAccPeriod.Size = New System.Drawing.Size(102, 17)
        Me.lblAccPeriod.TabIndex = 8
        Me.lblAccPeriod.Text = "Accounting Period :"
        Me.lblAccPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(28, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Transaction Desc :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(584, 408)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "&Close"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(496, 408)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(80, 416)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(83, 17)
        Me.lblLastUpdate.TabIndex = 26
        Me.lblLastUpdate.Text = "lblLastUpdate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 416)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Last Update:"
        '
        'frmMembershipTransaction01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(674, 440)
        Me.Controls.Add(Me.lblLastUpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMembershipTransaction01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail Transaction"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim blnCancel As Boolean
    Dim arrTransDescText() As String
    Dim arrTransCode() As String
    Dim sngLastTransAmount As Single
    Dim sngSavingAmount As Single

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        blnCancel = True
        Me.Dispose()
    End Sub

    Public Function GetCancelStatus() As Boolean
        Return blnCancel
    End Function

    Private Sub frmTransaction01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        blnCancel = False
        lblLastUpdate.Text = ""
    End Sub

    Public Sub Initialization(ByVal strMemberId As String, ByVal strName As String, _
                              ByVal dtAccPeriod As Date)
        Dim svcMembership As New Membership.svcMembership
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping
        Dim adoDS As DataSet
        Dim adorow As DataRow
        Dim I As Integer

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
            lblMemberNo.Text = strMemberId
            lblName.Text = strName
            dtpTransDate.Value = Now
            dtpAccPeriode.Value = dtAccPeriod
            cboTransType.Items.Add("DEBET")
            cboTransType.Items.Add("CREDIT")
            'adoDS = svcHouseKeeping.GetResourceCode("MEMBERSHIP", "TRANTYPE", APP_ID)
            'I = 0
            'ReDim arrTransCode(adoDS.Tables("ResourceCode").Rows.Count)
            'For Each adorow In adoDS.Tables("ResourceCode").Rows
            '    cboTransDesc.Items.Add(adorow!RESOURCE_DESC)
            '    arrTransCode(I) = adorow!RESOURCE_CODE
            '    I = I + 1
            'Next
            Me.cboTransDesc.Enabled = False
            lblLastUpdate.Text = ValidateString(USER_ID) & " ," & Format(Now, "dd-MMM-yyyy hh:mm:ss tt")
        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Function CreateRS() As DataSet
        Dim adoDS As New DataSet
        Dim adoColumn As DataColumn
        Dim adoTable As DataTable

        adoTable = New DataTable("TRANSACTION")
        adoDS.Tables.Add(adoTable)

        adoColumn = New DataColumn("TRANSACTION_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("MEMBERSHIP_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("TRANSACTION_DATE")
        adoColumn.DataType = System.Type.GetType("System.DateTime")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("ACCT_PERIOD")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("TRANSACTION_TYPE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("TRANSACTION_CODE")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("RESOURCE_DESC")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("AMOUNT")
        adoColumn.DataType = System.Type.GetType("System.Int64")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("TOTAL")
        adoColumn.DataType = System.Type.GetType("System.Int64")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("DESCRIPTION")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        CreateRS = adoDS
    End Function

    Private Sub FillDataSet(ByRef adoDS As DataSet)
        Dim adoRow As DataRow
        Dim adoDataTable As New DataTable
        Dim I As Integer

        adoDataTable = adoDS.Tables("TRANSACTION")
        adoRow = adoDataTable.NewRow()
        adoRow!TRANSACTION_ID = lblTransId.Text
        adoRow!MEMBERSHIP_NO = ValidateString(lblMemberNo.Text)
        adoRow!ACCT_PERIOD = Format(dtpAccPeriode.Value, "yyyyMM")
        adoRow!TRANSACTION_DATE = dtpTransDate.Value
        adoRow!TRANSACTION_TYPE = IIf(cboTransType.Text = "DEBET", "DB", "CR")
        I = 0
        For I = 0 To (cboTransDesc.Items.Count - 1)
            If cboTransDesc.Items.Item(I) = cboTransDesc.Text Then
                adoRow!TRANSACTION_CODE = arrTransCode(I)
            End If
        Next
        adoRow!RESOURCE_DESC = cboTransDesc.Text
        adoRow!AMOUNT = txtAmount.Text
        'adoRow!TOTAL = sngSavingAmount + IIf(cboTransType.Text = "DEBET", CSng(txtAmount.Text * -1), (CSng(txtAmount.Text)))
        If cboTransType.SelectedIndex = 0 Then
            adoRow!TOTAL = sngSavingAmount - txtAmount.Text
        Else
            adoRow!TOTAL = sngSavingAmount + txtAmount.Text
        End If
        adoRow!REVIEWED_BY = ValidateString(USER_ID)
        adoRow!DESCRIPTION = txtDescription.Text
        adoDataTable.Rows.Add(adoRow)
    End Sub


    Public Function GetDataSet(ByVal PrevSavingAmount As Single) As DataSet
        Dim myDS As New DataSet

        Try
            sngSavingAmount = PrevSavingAmount
            myDS = CreateRS()
            FillDataSet(myDS)
            GetDataSet = myDS
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If cboTransType.Text = "" Then Exit Sub
        If cboTransDesc.Text = "" Then Exit Sub
        If txtAmount.Text = 0 Or NullToString(txtAmount.Text) = "" Then
            Exit Sub
        End If
        Me.Hide()
    End Sub

    Public Sub FillField(ByVal adoDS As DataSet, ByVal bln As Boolean)
        Dim svcMembership As Membership.svcMembership = New Membership.svcMembership
        Dim adoRow As DataRow
        Dim IntCount As Integer
        Dim blnFound As Boolean
        Dim adoParameters As DataRow
        Dim adoDSTemp As DataSet

        If adoDS.Tables("TRANSACTION").Rows.Count > 0 Then
            adoRow = adoDS.Tables("TRANSACTION").Rows(0)
            dtpAccPeriode.Value = DateSerial(New String(adoRow!ACCT_PERIOD).Substring(0, 4), New String(adoRow!ACCT_PERIOD).Substring(4), 1)
            dtpTransDate.Value = adoRow!TRANSACTION_DATE
            'cboTransType.SelectedIndex = IIf(adoRow!TRANSACTION_TYPE = "DB", 0, 1)
            'I = 0
            'For I = 0 To (cboTransDesc.Items.Count - 1)
            '    If cboTransDesc.Items.Item(I) = adoRow!RESOURCE_DESC Then
            '        cboTransDesc.SelectedIndex = I
            '    End If
            'Next
            If adoRow!TRANSACTION_TYPE = "DB" Then
                cboTransType.SelectedIndex = 0
                adoDSTemp = svcMembership.GetTransCodeDB(APP_ID)
                IntCount = 0
                ReDim arrTransCode(adoDSTemp.Tables(0).Rows.Count)
                For Each adoParameters In adoDSTemp.Tables(0).Rows
                    cboTransDesc.Items.Add(adoParameters!RESOURCE_DESC)
                    arrTransCode(IntCount) = adoParameters!RESOURCE_CODE
                    IntCount = IntCount + 1
                Next
            Else
                cboTransType.SelectedIndex = 1
                adoDSTemp = svcMembership.GetTransCodeCR(APP_ID)
                IntCount = 0
                ReDim arrTransCode(adoDSTemp.Tables(0).Rows.Count)
                For Each adoParameters In adoDSTemp.Tables(0).Rows
                    cboTransDesc.Items.Add(adoParameters!RESOURCE_DESC)
                    arrTransCode(IntCount) = adoParameters!RESOURCE_CODE
                    IntCount = IntCount + 1
                Next
            End If
            '/* Addition: Enabling defaul user to review transaction of "ADJUST" type [via modify button] */
            cboTransDesc.Items.Add("Adjustment Transaksi")
            cboTransDesc.SelectedIndex = IntCount + 1
            '/* End of : Addition  */
            Me.cboTransDesc.Enabled = True
            For IntCount = 0 To (cboTransDesc.Items.Count - 1)
                If cboTransDesc.Items.Item(IntCount) = adoRow!RESOURCE_DESC Then
                    cboTransDesc.SelectedIndex = IntCount
                End If
            Next

            lblTransId.Text = adoRow!TRANSACTION_ID
            txtAmount.Text = Format(adoRow!AMOUNT, "##,##0")
            txtDescription.Text = adoRow!DESCRIPTION
            lblLastUpdate.Text = adoRow!REVIEWED_BY & " , " & adoRow!REVIEWED_DATE
        End If
    End Sub

    Private Sub cboTransType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTransType.SelectedIndexChanged
        Dim svcMembership As Membership.svcMembership = New Membership.svcMembership
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity
        Dim dataRow As DataRow
        Dim adoDS As DataSet
        Dim adoRow As DataRow
        Dim IntCount As Int32
        Dim MyDs As DataSet

        Try
            Me.cboTransDesc.Items.Clear()
            If Me.cboTransType.SelectedIndex <> -1 Then
                Me.cboTransDesc.Enabled = True
            Else
                Me.cboTransDesc.Enabled = False
            End If
            If Me.cboTransDesc.Enabled Then
                If Me.cboTransType.Text = "DEBET" Then
                    adoDS = svcMembership.GetTransCodeDB(APP_ID)
                    IntCount = 0
                    ReDim arrTransCode(adoDS.Tables(0).Rows.Count)
                    For Each adoRow In adoDS.Tables(0).Rows
                        cboTransDesc.Items.Add(adoRow!RESOURCE_DESC)
                        arrTransCode(IntCount) = adoRow!RESOURCE_CODE
                        IntCount = IntCount + 1
                    Next
                Else
                    adoDS = svcMembership.GetTransCodeCR(APP_ID)
                    IntCount = 0
                    ReDim arrTransCode(adoDS.Tables(0).Rows.Count)
                    For Each adoRow In adoDS.Tables(0).Rows
                        cboTransDesc.Items.Add(adoRow!RESOURCE_DESC)
                        arrTransCode(IntCount) = adoRow!RESOURCE_CODE
                        IntCount = IntCount + 1
                    Next
                End If
                '/* Addition: Allow only admin user that enable to make adjust trans */ 
                MyDs = svcSecurity.GetUserAccessRecord(USER_ID, APP_ID)
                For Each dataRow In MyDs.Tables("USER_ACCESS").Rows
                    If dataRow("PROGRAM_ID") = "MEMBERSHIP" Then
                        If dataRow("ACCESS_VALUE") > 5 Then
                            ReDim Preserve arrTransCode(IntCount + 1)
                            cboTransDesc.Items.Add("Adjustment Transaksi")
                            arrTransCode(IntCount) = "ADJUST"
                        End If
                    End If
                Next
                '/* End of : Addition  */

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class

