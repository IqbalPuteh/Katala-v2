Public Class frmKreditRealization01
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
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dtpTransferDate As System.Windows.Forms.DateTimePicker
    Public WithEvents txtMemberId As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtLoanAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtMontlyPay As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents txtTerm As System.Windows.Forms.TextBox
    Public WithEvents txtInterest As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblLoanID As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblPeriod As System.Windows.Forms.Label
    Friend WithEvents cboDeductionPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents txtAccountNo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents txtDeductionEnd As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmKreditRealization01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtAccountNo = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDeductionEnd = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboDeductionPeriod = New System.Windows.Forms.ComboBox
        Me.lblPeriod = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblLoanID = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTerm = New System.Windows.Forms.TextBox
        Me.txtInterest = New System.Windows.Forms.TextBox
        Me.txtMontlyPay = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.dtpTransferDate = New System.Windows.Forms.DateTimePicker
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtLoanAmount = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAccountNo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDeductionEnd)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboDeductionPeriod)
        Me.GroupBox1.Controls.Add(Me.lblPeriod)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblLoanID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTerm)
        Me.GroupBox1.Controls.Add(Me.txtInterest)
        Me.GroupBox1.Controls.Add(Me.txtMontlyPay)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.dtpTransferDate)
        Me.GroupBox1.Controls.Add(Me.txtMemberId)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtLoanAmount)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(2, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(630, 279)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loan Realization Detail"
        '
        'txtAccountNo
        '
        Me.txtAccountNo.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtAccountNo.Enabled = False
        Me.txtAccountNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountNo.Location = New System.Drawing.Point(128, 110)
        Me.txtAccountNo.MaxLength = 20
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.ReadOnly = True
        Me.txtAccountNo.Size = New System.Drawing.Size(256, 21)
        Me.txtAccountNo.TabIndex = 205
        Me.txtAccountNo.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(52, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 204
        Me.Label7.Text = "Account No :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDeductionEnd
        '
        Me.txtDeductionEnd.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtDeductionEnd.Enabled = False
        Me.txtDeductionEnd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeductionEnd.Location = New System.Drawing.Point(400, 226)
        Me.txtDeductionEnd.MaxLength = 20
        Me.txtDeductionEnd.Name = "txtDeductionEnd"
        Me.txtDeductionEnd.ReadOnly = True
        Me.txtDeductionEnd.Size = New System.Drawing.Size(133, 21)
        Me.txtDeductionEnd.TabIndex = 203
        Me.txtDeductionEnd.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(310, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 202
        Me.Label6.Text = "Last Deduction :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboDeductionPeriod
        '
        Me.cboDeductionPeriod.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboDeductionPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeductionPeriod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDeductionPeriod.ItemHeight = 13
        Me.cboDeductionPeriod.Location = New System.Drawing.Point(128, 226)
        Me.cboDeductionPeriod.Name = "cboDeductionPeriod"
        Me.cboDeductionPeriod.Size = New System.Drawing.Size(133, 21)
        Me.cboDeductionPeriod.TabIndex = 1
        '
        'lblPeriod
        '
        Me.lblPeriod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriod.ForeColor = System.Drawing.Color.Black
        Me.lblPeriod.Location = New System.Drawing.Point(504, 24)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(104, 17)
        Me.lblPeriod.TabIndex = 200
        Me.lblPeriod.Text = "lblPeriod"
        Me.lblPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(416, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 17)
        Me.Label5.TabIndex = 199
        Me.Label5.Text = "Current Period :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLoanID
        '
        Me.lblLoanID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanID.ForeColor = System.Drawing.Color.Black
        Me.lblLoanID.Location = New System.Drawing.Point(128, 56)
        Me.lblLoanID.Name = "lblLoanID"
        Me.lblLoanID.Size = New System.Drawing.Size(160, 17)
        Me.lblLoanID.TabIndex = 196
        Me.lblLoanID.Text = "lblLoanID"
        Me.lblLoanID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(71, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 195
        Me.Label3.Text = "Loan ID :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTerm
        '
        Me.txtTerm.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtTerm.Enabled = False
        Me.txtTerm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTerm.Location = New System.Drawing.Point(400, 168)
        Me.txtTerm.MaxLength = 20
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.ReadOnly = True
        Me.txtTerm.Size = New System.Drawing.Size(47, 21)
        Me.txtTerm.TabIndex = 192
        Me.txtTerm.Text = ""
        '
        'txtInterest
        '
        Me.txtInterest.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtInterest.Enabled = False
        Me.txtInterest.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterest.Location = New System.Drawing.Point(400, 139)
        Me.txtInterest.MaxLength = 20
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.ReadOnly = True
        Me.txtInterest.Size = New System.Drawing.Size(47, 21)
        Me.txtInterest.TabIndex = 191
        Me.txtInterest.Text = ""
        '
        'txtMontlyPay
        '
        Me.txtMontlyPay.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtMontlyPay.Enabled = False
        Me.txtMontlyPay.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontlyPay.Location = New System.Drawing.Point(128, 168)
        Me.txtMontlyPay.MaxLength = 20
        Me.txtMontlyPay.Name = "txtMontlyPay"
        Me.txtMontlyPay.ReadOnly = True
        Me.txtMontlyPay.Size = New System.Drawing.Size(133, 21)
        Me.txtMontlyPay.TabIndex = 190
        Me.txtMontlyPay.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(48, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "Monthly Pay :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(472, 170)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 17)
        Me.Label19.TabIndex = 188
        Me.Label19.Text = "Month"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpTransferDate
        '
        Me.dtpTransferDate.Checked = False
        Me.dtpTransferDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpTransferDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTransferDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTransferDate.Location = New System.Drawing.Point(128, 197)
        Me.dtpTransferDate.Name = "dtpTransferDate"
        Me.dtpTransferDate.ShowCheckBox = True
        Me.dtpTransferDate.Size = New System.Drawing.Size(133, 21)
        Me.dtpTransferDate.TabIndex = 0
        '
        'txtMemberId
        '
        Me.txtMemberId.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtMemberId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberId.Enabled = False
        Me.txtMemberId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberId.Location = New System.Drawing.Point(128, 81)
        Me.txtMemberId.MaxLength = 10
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(133, 21)
        Me.txtMemberId.TabIndex = 176
        Me.txtMemberId.TabStop = False
        Me.txtMemberId.Text = ""
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(272, 83)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 17)
        Me.lblName.TabIndex = 182
        Me.lblName.Text = "lblName"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(41, 199)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 17)
        Me.Label18.TabIndex = 187
        Me.Label18.Text = "Transfer Date :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtLoanAmount.Enabled = False
        Me.txtLoanAmount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAmount.Location = New System.Drawing.Point(128, 139)
        Me.txtLoanAmount.MaxLength = 20
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.ReadOnly = True
        Me.txtLoanAmount.Size = New System.Drawing.Size(133, 21)
        Me.txtLoanAmount.TabIndex = 177
        Me.txtLoanAmount.Text = ""
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(13, 141)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(108, 17)
        Me.Label32.TabIndex = 186
        Me.Label32.Text = "Transfered Amount :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(314, 141)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 17)
        Me.Label16.TabIndex = 183
        Me.Label16.Text = "Intrest / Year  :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(358, 170)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 17)
        Me.Label20.TabIndex = 184
        Me.Label20.Text = "Term :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(472, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 17)
        Me.Label11.TabIndex = 185
        Me.Label11.Text = "%"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(31, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "Membership No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(32, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 197
        Me.Label4.Text = "Start Deduction :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(551, 299)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 25)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(463, 299)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 25)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        '
        'frmKreditRealization01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(634, 328)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKreditRealization01"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Realization Detail"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _blnIsLoanDeducted As Boolean = False
    Private _blnCancel As Boolean = True
    Private _dtDate As Date

    Public WriteOnly Property SetDeductedStatus() As Boolean
        Set(ByVal Value As Boolean)
            _blnIsLoanDeducted = Value
        End Set
    End Property

    Public ReadOnly Property isCancelSave()
        Get
            Return _blnCancel
        End Get
    End Property



    Public Sub Initialization(ByVal strValue As String)
        Dim adoDS As DataSet
        Dim svcLoan As New Loan.svcLoan
        Dim adoRow As DataRow
        Dim clsInterest As FlatInterestClass
        Dim svcMembership As New Membership.svcMembership
        Dim strDate As String
        Dim dtDate As Date
        Dim dtTempDate As Date

        Try
            Me.btnSave.Enabled = False

            adoDS = svcLoan.GetRegistrationStatusDetail(strValue, APP_ID)
            If adoDS.Tables(0).Rows.Count = 0 Then
                Throw New Exception("No data available or incorrect Loan ID selected.")
            End If

            adoRow = adoDS.Tables(0).Rows(0)
            Me.txtMemberId.Text = adoRow!MEMBERSHIP_NO
            Me.lblLoanID.Text = adoRow!LOAN_ID
            Me.lblName.Text = adoRow!NAME
            Me.txtAccountNo.Text = adoRow!ACCOUNT_NO
            Me.txtLoanAmount.Text = Format(adoRow!AMOUNT, "#,##0")
            Me.txtTerm.Text = adoRow!TERM
            Me.txtInterest.Text = adoRow!INTEREST
            If NullToString(adoRow!PAYMENT_DATE) <> "" Then
                Me.dtpTransferDate.Checked = True
                Me.dtpTransferDate.Value = adoRow!PAYMENT_DATE
                Me._dtDate = dtpTransferDate.Value
            Else
                Me.dtpTransferDate.Checked = False
                'Me.dtpTransferDate.Value = New Date(1901, 1, 1)
            End If
            'Calculate montly payment amount
            clsInterest = New FlatInterestClass(adoRow!AMOUNT, adoRow!TERM, adoRow!INTEREST)
            Me.txtMontlyPay.Text = Format(clsInterest.GetMontlyDeduction, "#,##0")
            'Me.lblTotalDebt.Text = Format(clsInterest.GetTotalOwed, "#,##0")

            adoDS = svcMembership.GetMembershipAcctPeriod(APP_ID)
            strDate = adoDS.Tables(0).Rows(0).Item(0)
            Me.lblPeriod.Text = strDate
            Me.cboDeductionPeriod.Items.Add("")
            For intCount As Int16 = 1 To 3
                Me.cboDeductionPeriod.Items.Add(CInt(strDate) - 1 + intCount)
            Next

        Catch ex As Exception
            Throw ex
        Finally
            If Not IsNothing(svcLoan) Then
                svcLoan.Dispose()
            End If
        End Try
    End Sub

    Private Sub dtpTransferDate_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpTransferDate.Leave

        Try
            If Me.dtpTransferDate.Checked = False Then
                Me.dtpTransferDate.Value = New Date(1901, 1, 1)
            End If

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            If Me.cboDeductionPeriod.Text.Trim = "" Then
                Exit Sub
            End If
            If MessageBox.Show("Are you sure to save set realization for " & Me.txtMemberId.Text & _
                                " for period " & Me.cboDeductionPeriod.Text & " ?", "Confirmation", _
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            End If
            _blnCancel = False
            Me.Hide()

        Catch ex As Exception
            ShowErrorMessage(ex.Message, ex.Source)
            Me.btnSave.Hide()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Try
            Me.Hide()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cboDeductionPeriod_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDeductionPeriod.SelectedIndexChanged
        Dim strYear As Int16
        Dim strMonth As Int16
        Dim dtTempDate As Date

        Try
            If Me.cboDeductionPeriod.Text.Trim <> "" Then
                strYear = CInt(Me.cboDeductionPeriod.Text.Substring(0, 4))
                strMonth = Int(Me.cboDeductionPeriod.Text.Substring(4))
                dtTempDate = DateSerial(strYear, strMonth, 1)
                dtTempDate = dtTempDate.AddMonths(-1)
                dtTempDate = dtTempDate.AddMonths(CInt(Me.txtTerm.Text))
                Me.txtDeductionEnd.Text = dtTempDate.Year.ToString & IIf(dtTempDate.Month.ToString.Length = 1, "0" & _
                                          dtTempDate.Month.ToString, dtTempDate.Month.ToString)
            End If
        Catch ex As Exception
            Me.txtDeductionEnd.Text = ""
        End Try
    End Sub

    Private Sub dtpTransferDate_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dtpTransferDate.MouseUp

        Try
            If Me.dtpTransferDate.Checked Then
                Me.cboDeductionPeriod.Enabled = True
                Me.btnSave.Enabled = True
            Else
                Me.cboDeductionPeriod.Text = ""
                Me.cboDeductionPeriod.Enabled = False
                Me.txtDeductionEnd.Text = ""
                Me.btnSave.Enabled = False
            End If
        Catch ex As Exception
            'Nothing
        End Try
    End Sub


End Class
