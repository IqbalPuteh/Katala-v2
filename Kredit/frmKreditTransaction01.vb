Public Class frmKreditTransaction01
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
    Friend WithEvents lblLastUpdate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboTransType As System.Windows.Forms.ComboBox
    Friend WithEvents cboTransDesc As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents dtpTransDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTransDate As System.Windows.Forms.Label
    Friend WithEvents dtpAccPeriode As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAccPeriod As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMemberNo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblNameLabel As System.Windows.Forms.Label
    Friend WithEvents lblTransDescDetail As System.Windows.Forms.Label
    Friend WithEvents lblTransactionID As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmKreditTransaction01))
        Me.lblLastUpdate = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblTransDescDetail = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.NumericUpDown
        Me.cboTransType = New System.Windows.Forms.ComboBox
        Me.cboTransDesc = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblType = New System.Windows.Forms.Label
        Me.dtpTransDate = New System.Windows.Forms.DateTimePicker
        Me.lblTransDate = New System.Windows.Forms.Label
        Me.dtpAccPeriode = New System.Windows.Forms.DateTimePicker
        Me.lblAccPeriod = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblTransactionID = New System.Windows.Forms.Label
        Me.lblMemberNo = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblNameLabel = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLastUpdate
        '
        Me.lblLastUpdate.AutoSize = True
        Me.lblLastUpdate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastUpdate.ForeColor = System.Drawing.Color.Black
        Me.lblLastUpdate.Location = New System.Drawing.Point(80, 408)
        Me.lblLastUpdate.Name = "lblLastUpdate"
        Me.lblLastUpdate.Size = New System.Drawing.Size(83, 17)
        Me.lblLastUpdate.TabIndex = 32
        Me.lblLastUpdate.Text = "lblLastUpdate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Last Update:"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(577, 404)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 25)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "&Close"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(488, 404)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 25)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "&Save"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTransDescDetail)
        Me.GroupBox2.Controls.Add(Me.txtDescription)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtAmount)
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
        Me.GroupBox2.Size = New System.Drawing.Size(658, 304)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaction Info"
        '
        'lblTransDescDetail
        '
        Me.lblTransDescDetail.AutoSize = True
        Me.lblTransDescDetail.ForeColor = System.Drawing.Color.Black
        Me.lblTransDescDetail.Location = New System.Drawing.Point(344, 114)
        Me.lblTransDescDetail.Name = "lblTransDescDetail"
        Me.lblTransDescDetail.Size = New System.Drawing.Size(111, 17)
        Me.lblTransDescDetail.TabIndex = 23
        Me.lblTransDescDetail.Text = "lblTransDescDetail"
        Me.lblTransDescDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.lblType.Location = New System.Drawing.Point(27, 90)
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
        Me.Label4.Location = New System.Drawing.Point(28, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Transaction Desc :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTransactionID)
        Me.GroupBox1.Controls.Add(Me.lblMemberNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.lblNameLabel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 96)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Member Info"
        '
        'lblTransactionID
        '
        Me.lblTransactionID.AutoSize = True
        Me.lblTransactionID.ForeColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.lblTransactionID.Location = New System.Drawing.Point(496, 16)
        Me.lblTransactionID.Name = "lblTransactionID"
        Me.lblTransactionID.Size = New System.Drawing.Size(42, 17)
        Me.lblTransactionID.TabIndex = 8
        Me.lblTransactionID.Text = "Label6"
        Me.lblTransactionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMemberNo
        '
        Me.lblMemberNo.AutoSize = True
        Me.lblMemberNo.ForeColor = System.Drawing.Color.Black
        Me.lblMemberNo.Location = New System.Drawing.Point(137, 29)
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
        Me.Label2.Location = New System.Drawing.Point(32, 29)
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
        Me.lblName.Location = New System.Drawing.Point(137, 62)
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
        Me.lblNameLabel.Location = New System.Drawing.Point(81, 62)
        Me.lblNameLabel.Name = "lblNameLabel"
        Me.lblNameLabel.Size = New System.Drawing.Size(41, 17)
        Me.lblNameLabel.TabIndex = 4
        Me.lblNameLabel.Text = "Name :"
        Me.lblNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmKreditTransaction01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(658, 432)
        Me.Controls.Add(Me.lblLastUpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKreditTransaction01"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Transaction Entry"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private arrTransDescDetailCR() As String
    Private arrTransDescDetailDB() As String
    Private sngLastTransAmount As Single
    Private arrTransCodeCR() As String
    Private arrTransCodeDB() As String
    Private adoDSTrans As DataSet
    Private _blnCancel As Boolean = True

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        _blnCancel = True
        Me.Hide()
    End Sub

    Public ReadOnly Property GetCancelStatus() As Boolean
        Get
            Return _blnCancel
        End Get
    End Property

    Private Function CreateRS() As DataSet
        Dim adoDS As New DataSet
        Dim adoColumn As DataColumn
        Dim adoTable As DataTable

        adoTable = New DataTable("TRANSACTION")
        adoDS.Tables.Add(adoTable)

        adoColumn = New DataColumn("LOAN_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoColumn.AllowDBNull = True
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("TRANSACTION_ID")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoColumn.AllowDBNull = True
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("MEMBERSHIP_NO")
        adoColumn.DataType = System.Type.GetType("System.String")
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

        adoColumn = New DataColumn("AMOUNT")
        adoColumn.DataType = System.Type.GetType("System.Int64")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("DESCRIPTION")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoColumn.AllowDBNull = True
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("REVIEWED_BY")
        adoColumn.DataType = System.Type.GetType("System.String")
        adoTable.Columns.Add(adoColumn)

        adoColumn = New DataColumn("PREV_TOTAL")
        adoColumn.DataType = System.Type.GetType("System.Int64")
        adoTable.Columns.Add(adoColumn)
        CreateRS = adoDS
    End Function

    Private Sub FillDataSet(ByRef adoDS As DataSet, ByVal intValue As Int64)
        Dim adoRow As DataRow
        Dim adoDataTable As New DataTable


        adoDataTable = adoDS.Tables("TRANSACTION")
        adoRow = adoDataTable.NewRow()
        adoRow!TRANSACTION_ID = Me.lblTransactionID.Text
        adoRow!MEMBERSHIP_NO = ValidateString(Me.lblMemberNo.Text)
        adoRow!ACCT_PERIOD = Format(dtpAccPeriode.Value, "yyyyMM")
        adoRow!TRANSACTION_TYPE = IIf(cboTransType.SelectedIndex = 0, "CR", "DB")
        If cboTransType.SelectedIndex = 0 Then
            adoRow!TRANSACTION_CODE = Me.arrTransCodeCR(Me.cboTransDesc.SelectedIndex)
        Else
            adoRow!TRANSACTION_CODE = Me.arrTransCodeDB(Me.cboTransDesc.SelectedIndex)
        End If
        adoRow!AMOUNT = CInt(txtAmount.Text)
        adoRow!DESCRIPTION = Me.txtDescription.Text.Trim
        adoRow!REVIEWED_BY = ValidateString(USER_ID)
        adoRow!PREV_TOTAL = intValue
        adoDataTable.Rows.Add(adoRow)

    End Sub

    Public Sub Initialization(ByVal strMemberId As String, ByVal strName As String, _
                              ByVal dtAccPeriod As Date, ByVal strLoanRegNo As String)
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping
        Dim svcSecurity As New SystemSecurity.svcSystemSecurity
        Dim svcLoan As New Loan.svcLoan
        Dim adorow As DataRow
        Dim I As Integer
        Dim intUserAccessVal As Int16

        Try
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting
            intUserAccessVal = svcSecurity.GetUserAccessValue(USER_ID, "LOAN", APP_ID)
            lblTransDescDetail.Text = ""
            lblMemberNo.Text = strMemberId
            lblName.Text = strName
            dtpTransDate.Value = Now
            dtpAccPeriode.Value = dtAccPeriod
            cboTransType.Items.Clear()
            cboTransType.Items.Add("CREDIT")
            cboTransType.Items.Add("DEBET")
            adoDSTrans = svcHouseKeeping.GetResourceCodeType1("LOAN", "TRANTYPE", "CR", APP_ID)
            I = 0
            ReDim arrTransCodeCR(adoDSTrans.Tables("ResourceCode").Rows.Count - 1)
            ReDim arrTransDescDetailCR(adoDSTrans.Tables("ResourceCode").Rows.Count - 1)
            For Each adorow In adoDSTrans.Tables("ResourceCode").Rows
                arrTransCodeCR(I) = adorow!RESOURCE_CODE
                arrTransDescDetailCR(I) = adorow!RESOURCE_DESC
                I = I + 1
                '|| Check user access value if Loan INIT flag
                '|  then if user not elegible to set a loan 
                '|  remove flag from the Credit Resource code
                If adorow!RESOURCE_CODE = "INIT" Then
                    If intUserAccessVal < 5 Then
                        I = I - 1
                    End If
                End If
            Next
            adoDSTrans = svcHouseKeeping.GetResourceCodeType1("LOAN", "TRANTYPE", "DB", APP_ID)
            I = 0
            ReDim arrTransCodeDB(adoDSTrans.Tables("ResourceCode").Rows.Count - 1)
            ReDim arrTransDescDetailDB(adoDSTrans.Tables("ResourceCode").Rows.Count - 1)
            For Each adorow In adoDSTrans.Tables("ResourceCode").Rows
                arrTransCodeDB(I) = adorow!RESOURCE_CODE
                arrTransDescDetailDB(I) = adorow!RESOURCE_DESC
                I = I + 1
            Next
            lblLastUpdate.Text = ValidateString(USER_ID) & " ," & Format(Now, "dd-MMM-yyyy hh:mm:ss tt")

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            ShowErrorMessage(ex.Message, ex.Source)
        Finally
            If Not IsNothing(svcLoan) Then
                svcLoan.Dispose()
            End If
            If Not IsNothing(svcHouseKeeping) Then
                svcHouseKeeping.Dispose()
            End If
            If Not IsNothing(svcSecurity) Then
                svcSecurity.Dispose()
            End If
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Public Function GetDataSet(ByVal intValue As Int64) As DataSet
        Dim myDS As New DataSet

        Try
            myDS = CreateRS()
            FillDataSet(myDS, intValue)
            GetDataSet = myDS

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            If ValidateEmptyField(cboTransDesc) Then
                Exit Sub
            End If
            If ValidateEmptyField(cboTransType) Then
                Exit Sub
            End If
            If txtAmount.Text = 0 Or NullToString(txtAmount.Text) = "" Then
                Exit Sub
            End If

            _blnCancel = False
            Me.Hide()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub FillField(ByVal adoDS As DataSet, ByVal bln As Boolean)
        Dim adoParameters As DataRow
        Dim blnFound As Boolean
        Dim adoRow As DataRow

        Try
            If adoDS.Tables(0).Rows.Count > 0 Then
                adoRow = adoDS.Tables(0).Rows(0)
                Me.lblTransactionID.Text = NullToString(adoRow!TRANSACTION_ID)
                dtpAccPeriode.Value = DateSerial(New String(adoRow!ACCT_PERIOD).Substring(0, 4), New String(adoRow!ACCT_PERIOD).Substring(4), 1)
                dtpTransDate.Value = adoRow!TRANSACTION_DATE
                cboTransType.SelectedIndex = IIf(adoRow!TRANSACTION_TYPE = "CR", 0, 1)
                If Me.cboTransType.SelectedIndex = 0 Then
                    Me.cboTransDesc.Items.Clear()
                    Me.lblTransDescDetail.Text = ""
                    For I As Int32 = Me.arrTransCodeCR.GetLowerBound(0) To arrTransCodeCR.GetUpperBound(0)
                        Me.cboTransDesc.Items.Add(Me.arrTransCodeCR(I))
                        If Me.arrTransCodeCR(I) = adoRow!TRANSACTION_CODE Then
                            Me.cboTransDesc.SelectedIndex = I
                        End If
                    Next
                Else
                    Me.cboTransDesc.Items.Clear()
                    Me.lblTransDescDetail.Text = ""
                    For I As Int32 = arrTransCodeDB.GetLowerBound(0) To arrTransCodeDB.GetUpperBound(0)
                        Me.cboTransDesc.Items.Add(Me.arrTransCodeDB(I))
                        If Me.arrTransCodeDB(I) = adoRow!TRANSACTION_CODE Then
                            Me.cboTransDesc.SelectedIndex = I
                        End If
                    Next
                End If
                txtAmount.Text = Format(adoRow!AMOUNT, "##,##0")
                txtDescription.Text = adoRow!DESCRIPTION
                lblLastUpdate.Text = adoRow!REVIEWED_BY & " , " & adoRow!REVIEWED_DATE
                Me.btnSave.Focus()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cboTransType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTransType.SelectedIndexChanged

        Try
            Me.Refresh()
            Application.DoEvents()
            If Me.cboTransType.SelectedIndex = 0 Then
                '|| Credit transaction selected
                Me.cboTransDesc.Items.Clear()
                Me.lblTransDescDetail.Text = ""
                Me.txtAmount.Text = "0"
                Me.txtDescription.Text = ""
                For i As Int32 = Me.arrTransCodeCR.GetLowerBound(0) To arrTransCodeCR.GetUpperBound(0)
                    Me.cboTransDesc.Items.Add(Me.arrTransCodeCR(i))
                Next
            Else
                '|| Debet transaction selected
                Me.cboTransDesc.Items.Clear()
                Me.lblTransDescDetail.Text = ""
                Me.txtAmount.Text = "0"
                Me.txtDescription.Text = ""
                For i As Int32 = arrTransCodeDB.GetLowerBound(0) To arrTransCodeDB.GetUpperBound(0)
                    Me.cboTransDesc.Items.Add(Me.arrTransCodeDB(i))
                Next
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub cboTransDesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTransDesc.SelectedIndexChanged

        Try
            Me.Refresh()
            Application.DoEvents()
            If Me.cboTransType.SelectedIndex = 0 Then
                Me.lblTransDescDetail.Text = Me.arrTransDescDetailCR(Me.cboTransDesc.SelectedIndex)
            Else
                Me.lblTransDescDetail.Text = Me.arrTransDescDetailDB(Me.cboTransDesc.SelectedIndex)
            End If
        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub frmKreditTransaction01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
