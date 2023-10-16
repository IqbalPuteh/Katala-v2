Public Class frmTransaction01
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
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents cboTransDesc As System.Windows.Forms.ComboBox
    Friend WithEvents lblNameLabel As System.Windows.Forms.Label
    Friend WithEvents lblLastUpdate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTransId As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTransaction01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMemberNo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNameLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTransId = New System.Windows.Forms.Label()
        Me.cboTransType = New System.Windows.Forms.ComboBox()
        Me.cboTransDesc = New System.Windows.Forms.ComboBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.dtpTransDate = New System.Windows.Forms.DateTimePicker()
        Me.lblTransDate = New System.Windows.Forms.Label()
        Me.dtpAccPeriode = New System.Windows.Forms.DateTimePicker()
        Me.lblAccPeriod = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblLastUpdate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblMemberNo, Me.Label2, Me.lblName, Me.lblNameLabel})
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 80)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Member Info"
        '
        'lblMemberNo
        '
        Me.lblMemberNo.AutoSize = True
        Me.lblMemberNo.ForeColor = System.Drawing.Color.Black
        Me.lblMemberNo.Location = New System.Drawing.Point(128, 27)
        Me.lblMemberNo.Name = "lblMemberNo"
        Me.lblMemberNo.Size = New System.Drawing.Size(80, 14)
        Me.lblMemberNo.TabIndex = 1
        Me.lblMemberNo.Text = "lblMemberNo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(35, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 14)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Membership No.:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(128, 54)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 14)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "lblName"
        '
        'lblNameLabel
        '
        Me.lblNameLabel.AutoSize = True
        Me.lblNameLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameLabel.ForeColor = System.Drawing.Color.Black
        Me.lblNameLabel.Location = New System.Drawing.Point(83, 53)
        Me.lblNameLabel.Name = "lblNameLabel"
        Me.lblNameLabel.Size = New System.Drawing.Size(41, 14)
        Me.lblNameLabel.TabIndex = 4
        Me.lblNameLabel.Text = "Name :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblTransId, Me.cboTransType, Me.cboTransDesc, Me.txtAmount, Me.Label5, Me.lblType, Me.dtpTransDate, Me.lblTransDate, Me.dtpAccPeriode, Me.lblAccPeriod, Me.Label4})
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 176)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaction Info"
        '
        'lblTransId
        '
        Me.lblTransId.AutoSize = True
        Me.lblTransId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransId.ForeColor = System.Drawing.Color.Black
        Me.lblTransId.Location = New System.Drawing.Point(208, 29)
        Me.lblTransId.Name = "lblTransId"
        Me.lblTransId.Size = New System.Drawing.Size(43, 14)
        Me.lblTransId.TabIndex = 20
        Me.lblTransId.Text = "TransId"
        Me.lblTransId.Visible = False
        '
        'cboTransType
        '
        Me.cboTransType.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransType.Location = New System.Drawing.Point(128, 76)
        Me.cboTransType.Name = "cboTransType"
        Me.cboTransType.Size = New System.Drawing.Size(104, 21)
        Me.cboTransType.TabIndex = 3
        '
        'cboTransDesc
        '
        Me.cboTransDesc.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboTransDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTransDesc.Location = New System.Drawing.Point(128, 102)
        Me.cboTransDesc.Name = "cboTransDesc"
        Me.cboTransDesc.Size = New System.Drawing.Size(200, 21)
        Me.cboTransDesc.TabIndex = 4
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAmount.Location = New System.Drawing.Point(127, 127)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(200, 21)
        Me.txtAmount.TabIndex = 5
        Me.txtAmount.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(73, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 14)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Amount :"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.Black
        Me.lblType.Location = New System.Drawing.Point(85, 85)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(36, 14)
        Me.lblType.TabIndex = 16
        Me.lblType.Text = "Type :"
        '
        'dtpTransDate
        '
        Me.dtpTransDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTransDate.Location = New System.Drawing.Point(128, 49)
        Me.dtpTransDate.Name = "dtpTransDate"
        Me.dtpTransDate.ShowUpDown = True
        Me.dtpTransDate.Size = New System.Drawing.Size(104, 21)
        Me.dtpTransDate.TabIndex = 2
        '
        'lblTransDate
        '
        Me.lblTransDate.AutoSize = True
        Me.lblTransDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransDate.ForeColor = System.Drawing.Color.Black
        Me.lblTransDate.Location = New System.Drawing.Point(86, 57)
        Me.lblTransDate.Name = "lblTransDate"
        Me.lblTransDate.Size = New System.Drawing.Size(35, 14)
        Me.lblTransDate.TabIndex = 10
        Me.lblTransDate.Text = "Date :"
        '
        'dtpAccPeriode
        '
        Me.dtpAccPeriode.CustomFormat = "yyyy-MM"
        Me.dtpAccPeriode.Enabled = False
        Me.dtpAccPeriode.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAccPeriode.Location = New System.Drawing.Point(128, 24)
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
        Me.lblAccPeriod.Location = New System.Drawing.Point(23, 32)
        Me.lblAccPeriod.Name = "lblAccPeriod"
        Me.lblAccPeriod.Size = New System.Drawing.Size(102, 14)
        Me.lblAccPeriod.TabIndex = 8
        Me.lblAccPeriod.Text = "Accounting Period :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(28, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 14)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Transaction Desc :"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(468, 268)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 24)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "&Close"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(380, 268)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(80, 271)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(83, 14)
        Me.lblLastUpdate.TabIndex = 26
        Me.lblLastUpdate.Text = "lblLastUpdate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Last Update:"
        '
        'frmTransaction01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(554, 295)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblLastUpdate, Me.Label3, Me.btnClose, Me.btnSave, Me.GroupBox2, Me.GroupBox1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransaction01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTransaction01"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public blnCancel As Boolean
    Private arrTransDescText() As String
    Private arrTransCode() As String
    Public sngLastTransAmount As Single
    Public sngSavingAmount As Single

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
                              ByVal dtAccPeriod As Date, ByVal sngLastTransAmount As Single)
        Dim svcMembership As New Membership.svcMembership()
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping()
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
            cboTransType.Items.Add("KREDIT")
            adoDS = svcHouseKeeping.GetResourceCode("MEMBERSHIP", "TRANTYPE", APP_ID)
            I = 0
            ReDim arrTransCode(adoDS.Tables("ResourceCode").Rows.Count)
            For Each adorow In adoDS.Tables("ResourceCode").Rows
                cboTransDesc.Items.Add(adorow!RESOURCE_DESC)
                arrTransCode(I) = adorow!RESOURCE_CODE
                I = I + 1
            Next

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
        Dim adoDS As New DataSet()
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
        adoColumn.DataType = System.Type.GetType("System.Single")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("TOTAL")
        adoColumn.DataType = System.Type.GetType("System.Single")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        CreateRS = adoDS
    End Function

    Private Sub FillDataSet(ByRef adoDS As DataSet)
        Dim adoRow As DataRow
        Dim adoDataTable As New DataTable()
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
        adoRow!TOTAL = sngSavingAmount - sngLastTransAmount + IIf(cboTransType.Text = "DEBET", CSng(txtAmount.Text - 1), (CSng(txtAmount.Text)))
        adoRow!REVIEWED_BY = ValidateString(USER_ID)
        adoDataTable.Rows.Add(adoRow)
    End Sub


    Public Function GetDataSet(ByVal value01 As Single, ByVal value02 As Single) As DataSet
        Dim myDS As New DataSet()

        Try
            sngSavingAmount = value01
            sngLastTransAmount = value02
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
        Dim adoRow As DataRow
        Dim I As Integer
        Dim blnFound As Boolean
        Dim adoParameters As DataRow

        If adoDS.Tables("TRANSACTION").Rows.Count > 0 Then
            adoRow = adoDS.Tables("TRANSACTION").Rows(0)
            dtpAccPeriode.Value = DateSerial(New String(adoRow!ACCT_PERIOD).Substring(0, 4), New String(adoRow!ACCT_PERIOD).Substring(4), 1)
            dtpTransDate.Value = adoRow!TRANSACTION_DATE
            cboTransType.SelectedIndex = IIf(adoRow!TRANSACTION_TYPE = "DB", 0, 1)
            I = 0
            For I = 0 To (cboTransDesc.Items.Count - 1)
                If cboTransDesc.Items.Item(I) = adoRow!RESOURCE_DESC Then
                    cboTransDesc.SelectedIndex = I
                End If
            Next
            lblTransId.Text = adoRow!TRANSACTION_ID
            txtAmount.Text = adoRow!AMOUNT
            lblLastUpdate.Text = adoRow!REVIEWED_BY & " , " & adoRow!REVIEWED_DATE
        End If
    End Sub
End Class

