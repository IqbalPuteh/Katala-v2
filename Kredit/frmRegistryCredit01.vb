Public Class frmRegistryCredit01
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblActiveStatus As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboKreditType As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpRegistrationDate As System.Windows.Forms.DateTimePicker
    Public WithEvents txtMemberId As System.Windows.Forms.TextBox
    Public WithEvents txtRegistrationNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblSince As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblMontlyPayment As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblMontlyBasic As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyIntrestPayment As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents txtAccountNo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblPaymentRatio As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents cboPriority As System.Windows.Forms.ComboBox
    Friend WithEvents cboAccPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents cboTerm As System.Windows.Forms.ComboBox
    Friend WithEvents cboIntrest As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents gbCalculation As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalDebt As System.Windows.Forms.Label
    Friend WithEvents label110 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPayment As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents dtpTransferDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblMaxDeductionPercent As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lblInterest As System.Windows.Forms.Label
    Friend WithEvents lblTerm As System.Windows.Forms.Label
    Public WithEvents txtAmountReq As System.Windows.Forms.TextBox
    Public WithEvents txtLoanValueCalc As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents lblTerm1 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Public WithEvents txtApprovedAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblPeriod As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRegistryCredit01))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.lblPeriod = New System.Windows.Forms.Label
        Me.lblSaldo = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblDepartment = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblSince = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMemberId = New System.Windows.Forms.TextBox
        Me.lblActiveStatus = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtApprovedAmount = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.dtpTransferDate = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtAmountReq = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.cboPriority = New System.Windows.Forms.ComboBox
        Me.cboAccPeriod = New System.Windows.Forms.ComboBox
        Me.txtSalary = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtAccountNo = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtPurpose = New System.Windows.Forms.TextBox
        Me.txtRegistrationNo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboKreditType = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpRegistrationDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.cboTerm = New System.Windows.Forms.ComboBox
        Me.cboIntrest = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.gbCalculation = New System.Windows.Forms.GroupBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.lblTerm1 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.lblTerm = New System.Windows.Forms.Label
        Me.lblInterest = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.lblMaxDeductionPercent = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.lblTotalPayment = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.lblTotalDebt = New System.Windows.Forms.Label
        Me.label110 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.lblPaymentRatio = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.lblMonthlyIntrestPayment = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.lblMontlyBasic = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.lblMontlyPayment = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtLoanValueCalc = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbCalculation.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.lblPeriod)
        Me.GroupBox1.Controls.Add(Me.lblSaldo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblDepartment)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblSince)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtMemberId)
        Me.GroupBox1.Controls.Add(Me.lblActiveStatus)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(793, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Member Information"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(608, 48)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(84, 17)
        Me.Label41.TabIndex = 151
        Me.Label41.Text = "Current Period :"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriod.ForeColor = System.Drawing.Color.Black
        Me.lblPeriod.Location = New System.Drawing.Point(696, 48)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(55, 17)
        Me.lblPeriod.TabIndex = 150
        Me.lblPeriod.Text = "lblPeriod"
        Me.lblPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo.ForeColor = System.Drawing.Color.Black
        Me.lblSaldo.Location = New System.Drawing.Point(464, 72)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(50, 17)
        Me.lblSaldo.TabIndex = 149
        Me.lblSaldo.Text = "lblSaldo"
        Me.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(390, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 17)
        Me.Label8.TabIndex = 148
        Me.Label8.Text = "Total Saldo :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.Black
        Me.lblDepartment.Location = New System.Drawing.Point(128, 46)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(87, 17)
        Me.lblDepartment.TabIndex = 103
        Me.lblDepartment.Text = "lblDepartment"
        Me.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(48, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 17)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Department:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSince
        '
        Me.lblSince.AutoSize = True
        Me.lblSince.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSince.ForeColor = System.Drawing.Color.Black
        Me.lblSince.Location = New System.Drawing.Point(464, 48)
        Me.lblSince.Name = "lblSince"
        Me.lblSince.Size = New System.Drawing.Size(49, 17)
        Me.lblSince.TabIndex = 101
        Me.lblSince.Text = "lblSince"
        Me.lblSince.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(420, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Since :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMemberId
        '
        Me.txtMemberId.AcceptsTab = True
        Me.txtMemberId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMemberId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMemberId.Enabled = False
        Me.txtMemberId.Location = New System.Drawing.Point(128, 17)
        Me.txtMemberId.MaxLength = 10
        Me.txtMemberId.Name = "txtMemberId"
        Me.txtMemberId.Size = New System.Drawing.Size(112, 21)
        Me.txtMemberId.TabIndex = 0
        Me.txtMemberId.TabStop = False
        Me.txtMemberId.Text = ""
        '
        'lblActiveStatus
        '
        Me.lblActiveStatus.AutoSize = True
        Me.lblActiveStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveStatus.ForeColor = System.Drawing.Color.Black
        Me.lblActiveStatus.Location = New System.Drawing.Point(128, 73)
        Me.lblActiveStatus.Name = "lblActiveStatus"
        Me.lblActiveStatus.Size = New System.Drawing.Size(90, 17)
        Me.lblActiveStatus.TabIndex = 98
        Me.lblActiveStatus.Text = "lblActiveStatus"
        Me.lblActiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(247, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(51, 17)
        Me.lblName.TabIndex = 97
        Me.lblName.Text = "lblName"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Membership Status:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Membership No.:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtApprovedAmount)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.dtpTransferDate)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtAmountReq)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.cboPriority)
        Me.GroupBox2.Controls.Add(Me.cboAccPeriod)
        Me.GroupBox2.Controls.Add(Me.txtSalary)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtAccountNo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtPurpose)
        Me.GroupBox2.Controls.Add(Me.txtRegistrationNo)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cboKreditType)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.dtpRegistrationDate)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.cboTerm)
        Me.GroupBox2.Controls.Add(Me.cboIntrest)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(793, 200)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registry Information"
        '
        'txtApprovedAmount
        '
        Me.txtApprovedAmount.BackColor = System.Drawing.Color.White
        Me.txtApprovedAmount.Location = New System.Drawing.Point(616, 136)
        Me.txtApprovedAmount.MaxLength = 20
        Me.txtApprovedAmount.Name = "txtApprovedAmount"
        Me.txtApprovedAmount.ReadOnly = True
        Me.txtApprovedAmount.Size = New System.Drawing.Size(159, 21)
        Me.txtApprovedAmount.TabIndex = 177
        Me.txtApprovedAmount.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(504, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 17)
        Me.Label5.TabIndex = 178
        Me.Label5.Text = "Approved Amount :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(776, 8)
        Me.GroupBox3.TabIndex = 176
        Me.GroupBox3.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(449, 167)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 17)
        Me.Label19.TabIndex = 175
        Me.Label19.Text = "Month"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpTransferDate
        '
        Me.dtpTransferDate.Checked = False
        Me.dtpTransferDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpTransferDate.Enabled = False
        Me.dtpTransferDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTransferDate.Location = New System.Drawing.Point(104, 165)
        Me.dtpTransferDate.Name = "dtpTransferDate"
        Me.dtpTransferDate.ShowCheckBox = True
        Me.dtpTransferDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpTransferDate.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(8, 167)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 17)
        Me.Label18.TabIndex = 173
        Me.Label18.Text = "Transfer Date :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmountReq
        '
        Me.txtAmountReq.AcceptsTab = True
        Me.txtAmountReq.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtAmountReq.Location = New System.Drawing.Point(104, 136)
        Me.txtAmountReq.MaxLength = 20
        Me.txtAmountReq.Name = "txtAmountReq"
        Me.txtAmountReq.Size = New System.Drawing.Size(159, 21)
        Me.txtAmountReq.TabIndex = 8
        Me.txtAmountReq.Text = ""
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(16, 136)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(77, 17)
        Me.Label32.TabIndex = 172
        Me.Label32.Text = "Req. Amount :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(571, 52)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(47, 17)
        Me.Label30.TabIndex = 170
        Me.Label30.Text = "Priority :"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboPriority
        '
        Me.cboPriority.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPriority.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPriority.ItemHeight = 13
        Me.cboPriority.Location = New System.Drawing.Point(627, 50)
        Me.cboPriority.Name = "cboPriority"
        Me.cboPriority.Size = New System.Drawing.Size(159, 21)
        Me.cboPriority.TabIndex = 4
        '
        'cboAccPeriod
        '
        Me.cboAccPeriod.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboAccPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAccPeriod.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAccPeriod.ItemHeight = 13
        Me.cboAccPeriod.Location = New System.Drawing.Point(367, 78)
        Me.cboAccPeriod.Name = "cboAccPeriod"
        Me.cboAccPeriod.Size = New System.Drawing.Size(159, 21)
        Me.cboAccPeriod.TabIndex = 6
        '
        'txtSalary
        '
        Me.txtSalary.AcceptsTab = True
        Me.txtSalary.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(627, 78)
        Me.txtSalary.MaxLength = 20
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(159, 21)
        Me.txtSalary.TabIndex = 7
        Me.txtSalary.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(549, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 165
        Me.Label7.Text = "Base Salary :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAccountNo
        '
        Me.txtAccountNo.AcceptsTab = True
        Me.txtAccountNo.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtAccountNo.Location = New System.Drawing.Point(104, 78)
        Me.txtAccountNo.MaxLength = 20
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.Size = New System.Drawing.Size(159, 21)
        Me.txtAccountNo.TabIndex = 5
        Me.txtAccountNo.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(37, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 17)
        Me.Label14.TabIndex = 163
        Me.Label14.Text = "Acct. No.:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPurpose
        '
        Me.txtPurpose.AcceptsTab = True
        Me.txtPurpose.BackColor = System.Drawing.Color.White
        Me.txtPurpose.Location = New System.Drawing.Point(367, 50)
        Me.txtPurpose.MaxLength = 20
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(159, 21)
        Me.txtPurpose.TabIndex = 3
        Me.txtPurpose.Text = ""
        '
        'txtRegistrationNo
        '
        Me.txtRegistrationNo.AcceptsTab = True
        Me.txtRegistrationNo.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.txtRegistrationNo.Enabled = False
        Me.txtRegistrationNo.Location = New System.Drawing.Point(104, 21)
        Me.txtRegistrationNo.MaxLength = 20
        Me.txtRegistrationNo.Name = "txtRegistrationNo"
        Me.txtRegistrationNo.Size = New System.Drawing.Size(159, 21)
        Me.txtRegistrationNo.TabIndex = 0
        Me.txtRegistrationNo.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(24, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 17)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = "Credit Type:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboKreditType
        '
        Me.cboKreditType.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboKreditType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKreditType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKreditType.ItemHeight = 13
        Me.cboKreditType.Location = New System.Drawing.Point(104, 50)
        Me.cboKreditType.Name = "cboKreditType"
        Me.cboKreditType.Size = New System.Drawing.Size(159, 21)
        Me.cboKreditType.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(307, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 17)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "Purpose :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpRegistrationDate
        '
        Me.dtpRegistrationDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRegistrationDate.Location = New System.Drawing.Point(367, 21)
        Me.dtpRegistrationDate.Name = "dtpRegistrationDate"
        Me.dtpRegistrationDate.Size = New System.Drawing.Size(104, 21)
        Me.dtpRegistrationDate.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(298, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Reg. Date :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(40, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Reg. No.:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(295, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 17)
        Me.Label23.TabIndex = 167
        Me.Label23.Text = "Submit for :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(277, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 17)
        Me.Label16.TabIndex = 101
        Me.Label16.Text = "Intrest / Year  :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(321, 167)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 17)
        Me.Label20.TabIndex = 103
        Me.Label20.Text = "Term :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboTerm
        '
        Me.cboTerm.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTerm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTerm.ItemHeight = 13
        Me.cboTerm.Location = New System.Drawing.Point(367, 165)
        Me.cboTerm.Name = "cboTerm"
        Me.cboTerm.Size = New System.Drawing.Size(56, 21)
        Me.cboTerm.TabIndex = 10
        '
        'cboIntrest
        '
        Me.cboIntrest.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(192, Byte))
        Me.cboIntrest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIntrest.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIntrest.ItemHeight = 13
        Me.cboIntrest.Location = New System.Drawing.Point(367, 136)
        Me.cboIntrest.Name = "cboIntrest"
        Me.cboIntrest.Size = New System.Drawing.Size(56, 21)
        Me.cboIntrest.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(449, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 17)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "%"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(712, 539)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 26)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "&Cancel"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(624, 539)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 26)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "&Save"
        '
        'gbCalculation
        '
        Me.gbCalculation.Controls.Add(Me.Label40)
        Me.gbCalculation.Controls.Add(Me.Label39)
        Me.gbCalculation.Controls.Add(Me.lblTerm1)
        Me.gbCalculation.Controls.Add(Me.Label38)
        Me.gbCalculation.Controls.Add(Me.Label37)
        Me.gbCalculation.Controls.Add(Me.Label36)
        Me.gbCalculation.Controls.Add(Me.lblTerm)
        Me.gbCalculation.Controls.Add(Me.lblInterest)
        Me.gbCalculation.Controls.Add(Me.Label35)
        Me.gbCalculation.Controls.Add(Me.Label34)
        Me.gbCalculation.Controls.Add(Me.Label33)
        Me.gbCalculation.Controls.Add(Me.Label21)
        Me.gbCalculation.Controls.Add(Me.Label25)
        Me.gbCalculation.Controls.Add(Me.lblMaxDeductionPercent)
        Me.gbCalculation.Controls.Add(Me.Label29)
        Me.gbCalculation.Controls.Add(Me.lblTotalPayment)
        Me.gbCalculation.Controls.Add(Me.Label31)
        Me.gbCalculation.Controls.Add(Me.lblTotalDebt)
        Me.gbCalculation.Controls.Add(Me.label110)
        Me.gbCalculation.Controls.Add(Me.Label28)
        Me.gbCalculation.Controls.Add(Me.Label15)
        Me.gbCalculation.Controls.Add(Me.Label27)
        Me.gbCalculation.Controls.Add(Me.lblPaymentRatio)
        Me.gbCalculation.Controls.Add(Me.Label26)
        Me.gbCalculation.Controls.Add(Me.lblMonthlyIntrestPayment)
        Me.gbCalculation.Controls.Add(Me.Label24)
        Me.gbCalculation.Controls.Add(Me.lblMontlyBasic)
        Me.gbCalculation.Controls.Add(Me.Label22)
        Me.gbCalculation.Controls.Add(Me.lblMontlyPayment)
        Me.gbCalculation.Controls.Add(Me.Label17)
        Me.gbCalculation.Controls.Add(Me.txtLoanValueCalc)
        Me.gbCalculation.Controls.Add(Me.Label13)
        Me.gbCalculation.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbCalculation.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCalculation.ForeColor = System.Drawing.Color.Blue
        Me.gbCalculation.Location = New System.Drawing.Point(0, 312)
        Me.gbCalculation.Name = "gbCalculation"
        Me.gbCalculation.Size = New System.Drawing.Size(793, 224)
        Me.gbCalculation.TabIndex = 2
        Me.gbCalculation.TabStop = False
        Me.gbCalculation.Text = "Calculation Simulation"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(488, 121)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(13, 17)
        Me.Label40.TabIndex = 192
        Me.Label40.Text = "="
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(291, 187)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(11, 17)
        Me.Label39.TabIndex = 191
        Me.Label39.Text = "*"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTerm1
        '
        Me.lblTerm1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerm1.ForeColor = System.Drawing.Color.Black
        Me.lblTerm1.Location = New System.Drawing.Point(232, 121)
        Me.lblTerm1.Name = "lblTerm1"
        Me.lblTerm1.Size = New System.Drawing.Size(44, 17)
        Me.lblTerm1.TabIndex = 190
        Me.lblTerm1.Text = "lblTerm1"
        Me.lblTerm1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(232, 95)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(38, 17)
        Me.Label38.TabIndex = 189
        Me.Label38.Text = "Term :"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(432, 121)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(18, 17)
        Me.Label37.TabIndex = 188
        Me.Label37.Text = "%"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(276, 121)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(40, 17)
        Me.Label36.TabIndex = 187
        Me.Label36.Text = "Month"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTerm
        '
        Me.lblTerm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTerm.ForeColor = System.Drawing.Color.Black
        Me.lblTerm.Location = New System.Drawing.Point(232, 187)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(44, 17)
        Me.lblTerm.TabIndex = 186
        Me.lblTerm.Text = "lblTerm"
        Me.lblTerm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInterest
        '
        Me.lblInterest.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterest.ForeColor = System.Drawing.Color.Black
        Me.lblInterest.Location = New System.Drawing.Point(376, 121)
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(40, 17)
        Me.lblInterest.TabIndex = 185
        Me.lblInterest.Text = "lblInterest"
        Me.lblInterest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(232, 160)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(38, 17)
        Me.Label35.TabIndex = 184
        Me.Label35.Text = "Term :"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(376, 95)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(45, 17)
        Me.Label34.TabIndex = 183
        Me.Label34.Text = "Intrest :"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(32, 72)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(240, 17)
        Me.Label33.TabIndex = 182
        Me.Label33.Text = "Loan detail && Loan payment Calculation."
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(32, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 17)
        Me.Label21.TabIndex = 181
        Me.Label21.Text = "Loan Standart Rule."
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(442, 32)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(18, 17)
        Me.Label25.TabIndex = 180
        Me.Label25.Text = "%"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaxDeductionPercent
        '
        Me.lblMaxDeductionPercent.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxDeductionPercent.ForeColor = System.Drawing.Color.Navy
        Me.lblMaxDeductionPercent.Location = New System.Drawing.Point(362, 32)
        Me.lblMaxDeductionPercent.Name = "lblMaxDeductionPercent"
        Me.lblMaxDeductionPercent.Size = New System.Drawing.Size(60, 17)
        Me.lblMaxDeductionPercent.TabIndex = 179
        Me.lblMaxDeductionPercent.Text = "lblMax"
        Me.lblMaxDeductionPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(221, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(157, 17)
        Me.Label29.TabIndex = 178
        Me.Label29.Text = "Maximum Rasio Cicilan / Gaji :"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalPayment
        '
        Me.lblTotalPayment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayment.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblTotalPayment.Location = New System.Drawing.Point(32, 187)
        Me.lblTotalPayment.Name = "lblTotalPayment"
        Me.lblTotalPayment.Size = New System.Drawing.Size(129, 17)
        Me.lblTotalPayment.TabIndex = 169
        Me.lblTotalPayment.Text = "lblTotalPayment"
        Me.lblTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label31.Location = New System.Drawing.Point(32, 160)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(166, 17)
        Me.Label31.TabIndex = 168
        Me.Label31.Text = "Total  Payment (Rounding) :"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalDebt
        '
        Me.lblTotalDebt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDebt.ForeColor = System.Drawing.Color.Black
        Me.lblTotalDebt.Location = New System.Drawing.Point(528, 121)
        Me.lblTotalDebt.Name = "lblTotalDebt"
        Me.lblTotalDebt.Size = New System.Drawing.Size(100, 17)
        Me.lblTotalDebt.TabIndex = 167
        Me.lblTotalDebt.Text = "lblTotalDebt"
        Me.lblTotalDebt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label110
        '
        Me.label110.AutoSize = True
        Me.label110.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label110.ForeColor = System.Drawing.Color.Black
        Me.label110.Location = New System.Drawing.Point(528, 95)
        Me.label110.Name = "label110"
        Me.label110.Size = New System.Drawing.Size(98, 17)
        Me.label110.TabIndex = 166
        Me.label110.Text = "Actual Total Debt :"
        Me.label110.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(632, 187)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(13, 17)
        Me.Label28.TabIndex = 165
        Me.Label28.Text = "+"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(488, 187)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 17)
        Me.Label15.TabIndex = 164
        Me.Label15.Text = "="
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(752, 32)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(18, 17)
        Me.Label27.TabIndex = 160
        Me.Label27.Text = "%"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaymentRatio
        '
        Me.lblPaymentRatio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentRatio.ForeColor = System.Drawing.Color.Navy
        Me.lblPaymentRatio.Location = New System.Drawing.Point(696, 32)
        Me.lblPaymentRatio.Name = "lblPaymentRatio"
        Me.lblPaymentRatio.Size = New System.Drawing.Size(48, 17)
        Me.lblPaymentRatio.TabIndex = 159
        Me.lblPaymentRatio.Text = "lblPay"
        Me.lblPaymentRatio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(584, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(105, 17)
        Me.Label26.TabIndex = 158
        Me.Label26.Text = "Rasio Cicilan / Gaji :"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMonthlyIntrestPayment
        '
        Me.lblMonthlyIntrestPayment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyIntrestPayment.ForeColor = System.Drawing.Color.Black
        Me.lblMonthlyIntrestPayment.Location = New System.Drawing.Point(664, 187)
        Me.lblMonthlyIntrestPayment.Name = "lblMonthlyIntrestPayment"
        Me.lblMonthlyIntrestPayment.Size = New System.Drawing.Size(112, 17)
        Me.lblMonthlyIntrestPayment.TabIndex = 157
        Me.lblMonthlyIntrestPayment.Text = "lblMonthlyIntrestPayment"
        Me.lblMonthlyIntrestPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(664, 160)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(115, 17)
        Me.Label24.TabIndex = 156
        Me.Label24.Text = "Monthly Interest Pay :"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMontlyBasic
        '
        Me.lblMontlyBasic.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontlyBasic.ForeColor = System.Drawing.Color.Black
        Me.lblMontlyBasic.Location = New System.Drawing.Point(528, 187)
        Me.lblMontlyBasic.Name = "lblMontlyBasic"
        Me.lblMontlyBasic.Size = New System.Drawing.Size(103, 17)
        Me.lblMontlyBasic.TabIndex = 155
        Me.lblMontlyBasic.Text = "lblMontlyBasic"
        Me.lblMontlyBasic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(528, 160)
        Me.Label22.Name = "Label22"
        Me.Label22.TabIndex = 154
        Me.Label22.Text = "Monthly Main Pay :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMontlyPayment
        '
        Me.lblMontlyPayment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontlyPayment.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblMontlyPayment.Location = New System.Drawing.Point(376, 187)
        Me.lblMontlyPayment.Name = "lblMontlyPayment"
        Me.lblMontlyPayment.Size = New System.Drawing.Size(96, 17)
        Me.lblMontlyPayment.TabIndex = 153
        Me.lblMontlyPayment.Text = "lblMontlyPayment"
        Me.lblMontlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label17.Location = New System.Drawing.Point(335, 160)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(183, 17)
        Me.Label17.TabIndex = 152
        Me.Label17.Text = "Monthly  Payment (Rounding) :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLoanValueCalc
        '
        Me.txtLoanValueCalc.BackColor = System.Drawing.SystemColors.Control
        Me.txtLoanValueCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanValueCalc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanValueCalc.Location = New System.Drawing.Point(32, 119)
        Me.txtLoanValueCalc.MaxLength = 20
        Me.txtLoanValueCalc.Name = "txtLoanValueCalc"
        Me.txtLoanValueCalc.ReadOnly = True
        Me.txtLoanValueCalc.Size = New System.Drawing.Size(152, 21)
        Me.txtLoanValueCalc.TabIndex = 0
        Me.txtLoanValueCalc.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(32, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 17)
        Me.Label13.TabIndex = 99
        Me.Label13.Text = "Total Loan Amount :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmRegistryCredit01
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(793, 568)
        Me.Controls.Add(Me.gbCalculation)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistryCredit01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credit Registration-Edit Screen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.gbCalculation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private blnCancel As Boolean = True
    Private arrStrKreditType() As String
    Private arrStrPriority() As String
    Private arrStrIntrest() As String
    Private arrStrTerm() As String
    Private blnModify As Boolean = False
    Private adoDSMain As DataSet

    Public ReadOnly Property isCancelSave()
        Get
            Return blnCancel
        End Get
    End Property

    Private Function CreateRegistryCreditDS() As DataSet
        Dim adoDS As New DataSet
        Dim adoColoum As DataColumn

        adoDS.Tables.Add(New DataTable("DEFAULT"))

        adoColoum = New DataColumn("LOAN_ID")
        adoColoum.DataType = System.Type.GetType("System.String")
        adoColoum.MaxLength = 20
        adoDS.Tables(0).Columns.Add(adoColoum)

        adoColoum = New DataColumn("MEMBERSHIP_NO")
        adoColoum.DataType = System.Type.GetType("System.String")
        adoColoum.MaxLength = 10
        adoDS.Tables(0).Columns.Add(adoColoum)

        adoColoum = New DataColumn("REGISTER_DATE")
        adoColoum.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables(0).Columns.Add(adoColoum)

        adoColoum = New DataColumn("GROSS_SALARY")
        adoColoum.DataType = System.Type.GetType("System.Int64")
        adoDS.Tables(0).Columns.Add(adoColoum)

        adoColoum = New DataColumn("LOAN_TYPE")
        adoColoum.DataType = System.Type.GetType("System.String")
        adoColoum.MaxLength = 20
        adoDS.Tables(0).Columns.Add(adoColoum)

        adoColoum = New DataColumn("PRIORITY")
        adoColoum.DataType = System.Type.GetType("System.String")
        adoColoum.MaxLength = 10
        adoDS.Tables(0).Columns.Add(adoColoum)

        adoColoum = New DataColumn("PURPOSE")
        adoColoum.DataType = System.Type.GetType("System.String")
        adoColoum.MaxLength = 20
        adoDS.Tables(0).Columns.Add(adoColoum)

        adoColoum = New DataColumn("REQ_AMOUNT")
        adoColoum.DataType = System.Type.GetType("System.Int64")
        adoDS.Tables(0).Columns.Add(adoColoum)

        adoColoum = New DataColumn("TERM")
        adoColoum.DataType = System.Type.GetType("System.Int16")
        adoDS.Tables(0).Columns.Add(adoColoum)

        adoColoum = New DataColumn("INTEREST")
        adoColoum.DataType = System.Type.GetType("System.Int16")
        adoDS.Tables(0).Columns.Add(adoColoum)

        adoColoum = New DataColumn("ACCT_PERIOD")
        adoColoum.DataType = System.Type.GetType("System.String")
        adoColoum.MaxLength = 6
        adoDS.Tables(0).Columns.Add(adoColoum)

        adoColoum = New DataColumn("ACCOUNT_NO")
        adoColoum.DataType = System.Type.GetType("System.String")
        adoColoum.MaxLength = 20
        adoDS.Tables(0).Columns.Add(adoColoum)

        adoColoum = New DataColumn("NOTE")
        adoColoum.DataType = System.Type.GetType("System.String")
        adoColoum.MaxLength = 1000
        adoColoum.AllowDBNull = True
        adoDS.Tables(0).Columns.Add(adoColoum)

        adoColoum = New DataColumn("REVIEWED_DATE")
        adoColoum.DataType = System.Type.GetType("System.DateTime")
        adoDS.Tables(0).Columns.Add(adoColoum)

        adoColoum = New DataColumn("REVIEWED_BY")
        adoColoum.DataType = System.Type.GetType("System.String")
        adoColoum.MaxLength = 10
        adoDS.Tables(0).Columns.Add(adoColoum)

        adoDS.Tables(0).AcceptChanges()
        Return adoDS
    End Function

    Public Sub InitializeForm(ByVal strMembershipNo As String)
        Dim adoDS As DataSet
        Dim svcMembership As New Membership.svcMembership
        Dim adoDSMemberInfo As DataSet
        Dim adoRowMI, adoRow As DataRow
        Dim intSukarela As Single = 0
        Dim svcLoan As New Loan.svcLoan
        Dim strData As String

        Try
            adoDSMemberInfo = svcMembership.GetMemberTransactionSummary(strMembershipNo, APP_ID)
            For Each adoRowMI In adoDSMemberInfo.Tables(0).Rows
                If adoRowMI!TRANSACTION_CODE <> "WAJIB" Or adoRowMI!TRANSACTION_CODE <> "POKOK" Or adoRowMI!TRANSACTION_CODE <> "POKOKDB" Or adoRowMI!TRANSACTION_CODE <> "WAJIBDB" Then
                    intSukarela = intSukarela + adoRowMI!AMOUNT
                End If
            Next
            adoDS = svcMembership.GetMemberInfo(strMembershipNo, "", APP_ID)
            adoRow = adoDS.Tables(0).Rows(0)
            '// Header section //
            Me.txtMemberId.Text = adoRow!MEMBERSHIP_NO
            Me.lblName.Text = adoRow!FIRST_NAME
            Me.lblDepartment.Text = NullToString(adoRow!DEPARTMENT)
            Me.lblActiveStatus.Text = IIf(adoRow!ACTIVE_STATUS = "A", "Active", "Not Active")
            Me.lblSince.Text = Format(adoRow!MEMBERSHIP_DATE, "dd-MMM-yyyy")
            Me.lblSaldo.Text = Format(intSukarela, "#,##0")
            Me.lblMaxDeductionPercent.Text = "30"
            Me.lblMonthlyIntrestPayment.Text = "0"
            Me.lblMontlyBasic.Text = "0"
            Me.lblMontlyPayment.Text = "0"
            Me.lblPaymentRatio.Text = "0"

            '// Get Register No //
            Me.txtRegistrationNo.Text = ""
            strData = svcLoan.GetLastRegisterNumber(APP_ID)
            If strData.Length > 6 Then
                Me.txtRegistrationNo.Text = CType(CType(strData, Int64) + 1, String)
            Else
                Me.txtRegistrationNo.Text = strData & "00001"
            End If

            InitializeForm()
        Catch ex As Exception
            Throw ex
        Finally
            If Not IsNothing(adoDS) Then
                adoDS.Dispose()
                adoDS = Nothing
            End If
            If Not IsNothing(adoDSMemberInfo) Then
                adoDSMemberInfo.Dispose()
                adoDSMemberInfo = Nothing
            End If
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
                svcMembership = Nothing
            End If
        End Try
    End Sub

    Public Sub InitializeForm()
        Dim adoDS As DataSet
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping
        Dim svcMembership As New Membership.svcMembership
        Dim dtDate As Date
        Dim strDate As String

        Try
            adoDS = svcHouseKeeping.GetResourceCode("LOAN", "TYPE", APP_ID)
            ReDim arrStrKreditType(adoDS.Tables(0).Rows.Count)
            For intCount As Int16 = 0 To adoDS.Tables(0).Rows.Count - 1
                arrStrKreditType(intCount) = adoDS.Tables(0).Rows(intCount).Item("RESOURCE_CODE")
                cboKreditType.Items.Add(adoDS.Tables(0).Rows(intCount).Item("RESOURCE_DESC"))
            Next
            cboKreditType.SelectedIndex = -1

            adoDS = svcHouseKeeping.GetResourceCode("LOAN", "PRIORITY", APP_ID)
            ReDim arrStrPriority(adoDS.Tables(0).Rows.Count)
            For intCount As Int16 = 0 To adoDS.Tables(0).Rows.Count - 1
                arrStrPriority(intCount) = adoDS.Tables(0).Rows(intCount).Item("RESOURCE_CODE")
                cboPriority.Items.Add(adoDS.Tables(0).Rows(intCount).Item("RESOURCE_DESC"))
            Next
            cboPriority.SelectedIndex = -1

            adoDS = svcMembership.GetMembershipAcctPeriod(APP_ID)

            strDate = adoDS.Tables(0).Rows(0).Item(0)
            dtDate = DateSerial(strDate.Substring(0, 4), strDate.Substring(4), 1)
            For intCount As Int16 = 0 To 5
                cboAccPeriod.Items.Add(dtDate.Year.ToString & IIf(dtDate.Month.ToString.Length < 2, "0" & dtDate.Month.ToString, dtDate.Month.ToString))
                dtDate = dtDate.AddMonths(1)
            Next
            cboAccPeriod.SelectedIndex = -1
            Me.lblPeriod.Text = strDate
            Me.lblMaxDeductionPercent.Text = "30"
            Me.lblMonthlyIntrestPayment.Text = "0"
            Me.lblMontlyBasic.Text = "0"
            Me.lblMontlyPayment.Text = "0"
            Me.lblPaymentRatio.Text = "0"
            Me.lblTotalDebt.Text = "0"
            Me.lblTotalPayment.Text = "0"
            Me.lblTerm.Text = "0"
            Me.lblTerm1.Text = "0"
            Me.lblInterest.Text = "0"

            Me.txtMemberId.Focus()
        Catch ex As Exception
            Throw ex
        Finally
            If Not IsNothing(adoDS) Then
                adoDS.Dispose()
                adoDS = Nothing
            End If
            If Not IsNothing(svcHouseKeeping) Then
                svcHouseKeeping.Dispose()
                svcHouseKeeping = Nothing
            End If
            If Not IsNothing(svcMembership) Then
                svcMembership.Dispose()
                svcMembership = Nothing
            End If
        End Try
    End Sub

    Public Sub FillField(ByVal adoDS As DataSet)
        Dim adoRow, adoRowMI As DataRow
        Dim adoDSMemberInfo, adoDSTemp As DataSet
        Dim adoRowTemp As DataRow
        Dim svcMembership As New Membership.svcMembership
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping
        Dim intSukarela As Single = 0
        Dim clsFlatInterest As FlatInterestClass

        Try
            adoRow = adoDS.Tables(0).Rows(0)
            adoDSTemp = svcMembership.GetMemberTransactionSummary(adoRow!MEMBERSHIP_NO, APP_ID)
            For Each adoRowTemp In adoDSTemp.Tables(0).Rows
                If adoRowTemp!TRANSACTION_CODE <> "WAJIB" Or adoRowTemp!TRANSACTION_CODE <> "POKOK" Or adoRowMI!TRANSACTION_CODE <> "POKOKDB" Or adoRowMI!TRANSACTION_CODE <> "WAJIB" Then
                    intSukarela = intSukarela + adoRow!REQ_AMOUNT
                End If
            Next
            adoDSMemberInfo = svcMembership.GetMemberInfo(adoRow!MEMBERSHIP_NO, "", APP_ID)
            adoRowMI = adoDSMemberInfo.Tables(0).Rows(0)
            '// Header section //
            Me.lblName.Text = adoRowMI!FIRST_NAME
            Me.txtMemberId.Text = adoRowMI!MEMBERSHIP_NO
            Me.lblDepartment.Text = NullToString(adoRowMI!DEPARTMENT)
            Me.lblActiveStatus.Text = IIf(adoRowMI!ACTIVE_STATUS = "A", "Active", "Not Active")
            Me.lblSince.Text = Format(adoRowMI!MEMBERSHIP_DATE, "dd-MMM-yyyy")
            Me.lblSaldo.Text = Format(intSukarela, "#,##0")

            '//Registration Section //
            Me.txtRegistrationNo.Text = adoRow!LOAN_ID
            Me.dtpRegistrationDate.Value = adoRow!REGISTER_DATE
            Me.cboKreditType.SelectedIndex = GetStrArrayIndexValue(arrStrKreditType, NullToString(adoRow!LOAN_TYPE))
            Me.txtPurpose.Text = NullToString(adoRow!PURPOSE)
            Me.txtSalary.Text = Format(adoRow!GROSS_SALARY, "#,##0")
            Me.txtAccountNo.Text = NullToString(adoRow!ACCOUNT_NO)
            Me.cboPriority.SelectedIndex = GetStrArrayIndexValue(arrStrPriority, NullToString(adoRow!PRIORITY))
            Me.cboAccPeriod.SelectedItem = adoRow!ACCT_PERIOD
            Me.txtAmountReq.Text = Format(adoRow!REQ_AMOUNT, "#,##0")
            If NullToString(adoRow!AMOUNT) <> "0" Then
                Me.txtApprovedAmount.Text = Format(adoRow!AMOUNT, "#,##0")
                Me.txtLoanValueCalc.Text = Format(adoRow!AMOUNT, "#,##0")
            Else
                Me.txtLoanValueCalc.Text = Format(adoRow!REQ_AMOUNT, "#,##0")
            End If
            If NullToString(adoRow!PAYMENT_DATE) <> "" Then
                Me.dtpTransferDate.Enabled = True
                Me.dtpTransferDate.Value = adoRow!PAYMENT_DATE
            Else
                Me.dtpTransferDate.Value = #1/1/1901#
                Me.dtpTransferDate.Enabled = False
            End If

            '//Calculation Section //
            'Get it from system
            Me.lblMaxDeductionPercent.Text = "30"
            'End Get
            adoDSTemp = svcHouseKeeping.GetResourceCode(NullToString(adoRow!LOAN_TYPE), "INTEREST", APP_ID)
            ReDim arrStrIntrest(adoDSTemp.Tables(0).Rows.Count)
            Me.cboIntrest.Items.Clear()
            For intCount As Int16 = 1 To adoDSTemp.Tables(0).Rows.Count
                arrStrIntrest(intCount) = adoDSTemp.Tables(0).Rows(intCount - 1).Item("RESOURCE_CODE")
                Me.cboIntrest.Items.Add(adoDSTemp.Tables(0).Rows(intCount - 1).Item("RESOURCE_DESC"))
            Next
            Me.cboIntrest.SelectedIndex = GetComboIndexValue(Me.cboIntrest, CType(adoRow!INTEREST, String))
            adoDSTemp = svcHouseKeeping.GetResourceCode(NullToString(adoRow!LOAN_TYPE), "TERM", APP_ID)
            ReDim arrStrTerm(adoDSTemp.Tables(0).Rows.Count)
            Me.cboTerm.Items.Clear()
            For intCount As Int16 = 1 To adoDSTemp.Tables(0).Rows.Count
                arrStrTerm(intCount) = adoDSTemp.Tables(0).Rows(intCount - 1).Item("RESOURCE_CODE")
                Me.cboTerm.Items.Add(adoDSTemp.Tables(0).Rows(intCount - 1).Item("RESOURCE_DESC"))
            Next
            Me.cboTerm.SelectedIndex = GetComboIndexValue(Me.cboTerm, CType(adoRow!TERM, String))
            If adoRow!STATUS = "N" Then
                clsFlatInterest = New FlatInterestClass(adoRow!REQ_AMOUNT, _
                                                        CType(Me.cboTerm.SelectedItem, Short), _
                                                        CType(Me.cboIntrest.SelectedItem, Short))
            Else
                clsFlatInterest = New FlatInterestClass(adoRow!AMOUNT, _
                                                        CType(Me.cboTerm.SelectedItem, Short), _
                                                        CType(Me.cboIntrest.SelectedItem, Short))
            End If
            Me.lblMontlyPayment.Text = Format(Math.Ceiling(clsFlatInterest.GetMontlyDeduction), "#,##0")
            Me.lblMontlyBasic.Text = Format(clsFlatInterest.GetMontlyBasicDeduction, "#,##0.00")
            Me.lblMonthlyIntrestPayment.Text = Format(clsFlatInterest.GetMontlyInterestDeduction, "#,##0.00")
            Me.lblTotalPayment.Text = Format(Math.Ceiling(clsFlatInterest.GetMontlyDeduction) * CInt(Me.cboTerm.Text), "#,##0")
            Me.lblPaymentRatio.Text = Format(clsFlatInterest.GetMontlyDeduction / adoRow!REQ_AMOUNT, "###.#0")
            Me.lblTotalDebt.Text = Format(clsFlatInterest.GetTotalOwed, "#,##0")

            Me.lblPaymentRatio.Text = Format((clsFlatInterest.GetMontlyDeduction / adoRow!GROSS_SALARY) * 100, "###.#0")
            If (clsFlatInterest.GetMontlyDeduction / adoRow!GROSS_SALARY) * 100 > 30 Then
                Me.lblPaymentRatio.ForeColor = System.Drawing.Color.Red
            Else
                Me.lblPaymentRatio.ForeColor = System.Drawing.Color.Blue
            End If

            '//Button Section //
            '********************
            'STATUS CODE
            'Registered = N
            'Reviewed   = R
            'Realization= Y
            '********************
            If adoRow!STATUS <> "N" Then
                Me.btnSave.Enabled = False
            End If


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function FillDataSet()
        Dim adoRow As DataRow

        Try
            'If Me.cboApproved.Text = "YES" Then
            '    adoRow = adoDSMain.Tables(0).NewRow
            '    adoRow!LOAN_ID = Me.txtRegistrationNo.Text
            '    adoRow!PAYMENT_DATE = Me.dtpTransferDate.Value
            '    adoDSMain.Tables(0).Rows.Add(adoRow)
            'Else
            adoRow = adoDSMain.Tables(0).NewRow
            adoRow!LOAN_ID = Me.txtRegistrationNo.Text
            adoRow!MEMBERSHIP_NO = Me.txtMemberId.Text
            adoRow!REGISTER_DATE = Me.dtpRegistrationDate.Value
            adoRow!GROSS_SALARY = CType(Me.txtSalary.Text, Int64)
            adoRow!LOAN_TYPE = arrStrKreditType(Me.cboKreditType.SelectedIndex)
            adoRow!REQ_AMOUNT = CType(Me.txtAmountReq.Text, Int64)
            'adoRow!AMOUNT = CType(Me.txtLoanValue.Text, Int64)
            adoRow!TERM = CType(Me.cboTerm.Text, Int16)
            adoRow!INTEREST = CType(Me.cboIntrest.Text, Int16)
            adoRow!ACCT_PERIOD = Me.cboAccPeriod.Text
            adoRow!ACCOUNT_NO = Me.txtAccountNo.Text
            adoRow!NOTE = " "
            adoRow!PRIORITY = arrStrPriority(Me.cboPriority.SelectedIndex)
            adoRow!PURPOSE = Me.txtPurpose.Text
            adoRow!REVIEWED_DATE = Now
            adoRow!REVIEWED_BY = USER_ID
            adoDSMain.Tables(0).Rows.Add(adoRow)

            'End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetDataSet() As DataSet

        Try

            adoDSMain = CreateRegistryCreditDS()
            FillDataSet()
            Return adoDSMain

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        blnCancel = True
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        'Validate '//Registration Section //
        If ValidateEmptyField(Me.cboKreditType) Then
            Exit Sub
        End If
        If ValidateEmptyField(Me.txtSalary) Then
            Exit Sub
        End If
        If ValidateEmptyField(Me.txtAccountNo) Then
            Exit Sub
        End If
        If ValidateEmptyField(Me.cboPriority) Then
            Exit Sub
        End If
        If ValidateEmptyField(Me.cboAccPeriod) Then
            Exit Sub
        End If
        'Validate '//Calculation Section //
        If ValidateEmptyField(Me.txtLoanValueCalc) Then
            Exit Sub
        End If
        If ValidateEmptyField(Me.cboTerm) Then
            Exit Sub
        End If
        If ValidateEmptyField(Me.cboIntrest) Then
            Exit Sub
        End If
        If Me.lblMontlyPayment.Text = "" Then
            'Me.btnHitung.Focus()
            Exit Sub
        End If
        blnCancel = False
        Me.Hide()

    End Sub

    Private Sub txtLoanValue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoanValueCalc.TextChanged

        ClearCalculationField()
    End Sub

    Private Sub cboKreditType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKreditType.SelectedIndexChanged
        Dim svcHouseKeeping As New HouseKeeping.svcHouseKeeping
        Dim adoDSTemp As DataSet
        Dim strTemp As String

        Try
            ClearCalculationField()
            Me.cboTerm.Items.Clear()
            Me.cboIntrest.Items.Clear()
            If Me.cboKreditType.SelectedIndex = -1 Then
                Exit Sub
            End If
            strTemp = arrStrKreditType(Me.cboKreditType.SelectedIndex)

            adoDSTemp = svcHouseKeeping.GetResourceCode(strTemp, "INTEREST", APP_ID)
            ReDim arrStrIntrest(adoDSTemp.Tables(0).Rows.Count)
            For intCount As Int16 = 0 To adoDSTemp.Tables(0).Rows.Count - 1
                Me.arrStrIntrest(intCount) = adoDSTemp.Tables(0).Rows(intCount).Item("RESOURCE_CODE")
                Me.cboIntrest.Items.Add(adoDSTemp.Tables(0).Rows(intCount).Item("RESOURCE_DESC"))
            Next
            Me.cboIntrest.SelectedIndex = -1

            adoDSTemp = svcHouseKeeping.GetResourceCode(strTemp, "TERM", APP_ID)
            ReDim arrStrTerm(adoDSTemp.Tables(0).Rows.Count)
            For intCount As Int16 = 0 To adoDSTemp.Tables(0).Rows.Count - 1
                Me.arrStrTerm(intCount) = adoDSTemp.Tables(0).Rows(intCount).Item("RESOURCE_CODE")
                Me.cboTerm.Items.Add(adoDSTemp.Tables(0).Rows(intCount).Item("RESOURCE_DESC"))
            Next
            Me.cboTerm.SelectedIndex = -1

        Catch ex As Exception
            Throw ex
        Finally
            If Not IsNothing(svcHouseKeeping) Then
                svcHouseKeeping.Dispose()
                svcHouseKeeping = Nothing
            End If
        End Try
    End Sub

    Private Sub ClearCalculationField()

        Me.lblTerm.Text = "0"
        Me.lblTerm1.Text = "0"
        Me.lblInterest.Text = "0"
        Me.lblPaymentRatio.Text = "0"
        Me.lblMontlyPayment.Text = "0"
        Me.lblMontlyBasic.Text = "0"
        Me.lblMonthlyIntrestPayment.Text = "0"
        Me.lblTotalDebt.Text = "0"
        Me.lblTotalPayment.Text = "0"
    End Sub

    Private Sub CalculateFlatInterest()
        Dim clsFlatInterest As FlatInterestClass

        Try
            If Me.txtSalary.Text = "" Then
                ClearCalculationField()
                Exit Sub
            End If
            If txtLoanValueCalc.Text = "" Then
                ClearCalculationField()
                Exit Sub
            End If
            If Me.cboTerm.SelectedIndex = -1 Then
                ClearCalculationField()
                Exit Sub
            End If
            If Me.cboIntrest.SelectedIndex = -1 Then
                ClearCalculationField()
                Exit Sub
            End If

            Try
                If CType(Me.txtSalary.Text, Int64) = 0 Then
                    ClearCalculationField()
                    Exit Sub
                End If
                If CType(Me.txtLoanValueCalc.Text, Int64) = 0 Then
                    ClearCalculationField()
                    Exit Sub
                End If
                If CType(Me.cboTerm.SelectedItem, Int16) = 0 Then
                    ClearCalculationField()
                    Exit Sub
                End If
                If CType(Me.cboIntrest.SelectedItem, Int16) = 0 Then
                    ClearCalculationField()
                    Exit Sub
                End If
                clsFlatInterest = New FlatInterestClass(CType(txtLoanValueCalc.Text, Int64), CType(Me.cboTerm.SelectedItem, Int16), CType(Me.cboIntrest.SelectedItem, Int16))
                Me.lblTerm.Text = Me.cboTerm.SelectedItem
                Me.lblTerm1.Text = Me.cboTerm.SelectedItem
                Me.lblInterest.Text = Me.cboIntrest.SelectedItem
                'Me.lblPaymentRatio.Text = clsFlatInterest.
                Me.lblMontlyPayment.Text = Format(Math.Ceiling(clsFlatInterest.GetMontlyDeduction), "#,##0")
                Me.lblMontlyBasic.Text = Format(clsFlatInterest.GetMontlyBasicDeduction, "#,##0.00")
                Me.lblMonthlyIntrestPayment.Text = Format(clsFlatInterest.GetMontlyInterestDeduction, "#,##0.00")
                Me.lblTotalPayment.Text = Format(Math.Ceiling(clsFlatInterest.GetMontlyDeduction) * CInt(Me.cboTerm.Text), "#,##0")
                Me.lblTotalDebt.Text = Format(clsFlatInterest.GetTotalOwed, "#,##0")
                'Get it from system
                Me.lblMaxDeductionPercent.Text = "30"
                Me.lblPaymentRatio.Text = Format((clsFlatInterest.GetMontlyDeduction / CType(txtSalary.Text, Int64)) * 100, "###.#0")
                If (clsFlatInterest.GetMontlyDeduction / CType(txtSalary.Text, Int64)) * 100 > 30 Then
                    Me.lblPaymentRatio.ForeColor = System.Drawing.Color.Red
                Else
                    Me.lblPaymentRatio.ForeColor = System.Drawing.Color.Black
                End If

            Catch exc As Exception
                'Do Nothing Here
            End Try
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txtSalary_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalary.LostFocus

        Try
            If txtSalary.Text <> "" And txtSalary.Text <> "0" Then
                Me.txtSalary.Text = Format(CType(Me.txtSalary.Text, Int64), "#,##0")
            End If
        Catch ex As Exception
            'Me.txtSalary.Text = Me.txtSalary.Text
            Me.txtSalary.Text = 0
        End Try
    End Sub

    Private Sub txtSalary_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalary.GotFocus

        Try
            If txtSalary.Text <> "" And txtSalary.Text <> "0" Then
                Me.txtSalary.Text = Format(CType(Me.txtSalary.Text, Int64), "###0")
            End If
        Catch ex As Exception
            'Me.txtSalary.Text = Me.txtSalary.Text
            Me.txtSalary.Text = 0
        End Try
    End Sub


    Private Sub txtAmountReq_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmountReq.LostFocus

        Try
            If txtAmountReq.Text <> "" And txtAmountReq.Text <> "0" Then
                Me.txtAmountReq.Text = Format(CType(Me.txtAmountReq.Text, Int64), "#,##0")
                txtLoanValueCalc.Text = Format(CType(Me.txtAmountReq.Text, Int64), "#,##0")
            End If
            CalculateFlatInterest()
        Catch ex As Exception
            'Me.txtAmountReq.Text = Me.txtAmountReq.Text
            Me.txtAmountReq.Text = 0
        End Try
    End Sub

    Private Sub txtAmountReq_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAmountReq.GotFocus

        Try
            If txtAmountReq.Text <> "" And txtAmountReq.Text <> "0" Then
                Me.txtAmountReq.Text = Format(CType(Me.txtAmountReq.Text, Int64), "#,##0")
            End If
        Catch ex As Exception
            'Me.txtAmountReq.Text = Me.txtAmountReq.Text
            Me.txtAmountReq.Text = 0
        End Try
    End Sub

    Private Sub cboTerm_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTerm.LostFocus

        Try
            CalculateFlatInterest()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboIntrest_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboIntrest.LostFocus

        Try
            CalculateFlatInterest()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboIntrest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboIntrest.SelectedIndexChanged

        Try
            CalculateFlatInterest()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboTerm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTerm.SelectedIndexChanged

        Try
            CalculateFlatInterest()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmRegistryCredit01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

